using ClinicBusinessLayer;
using ClinicManagementSystem.ManagePrescriptions;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.ManageMedicalRecords
{
    public partial class frmAddEditMedicalRecordInfo : Form
    {
        public delegate void MedicalRecordDataBackEventHandler(object sender, int MedicalRecordID);

        public event MedicalRecordDataBackEventHandler MedicalRecordDataBack;

        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsMedicalRecord _MedicalRecord;

        private int _MedicalRecordID = -1;

        private int _PatientID = -1;
        public frmAddEditMedicalRecordInfo(int MedicalRecordID , int PatientID)
        {
            InitializeComponent();
            _MedicalRecordID = MedicalRecordID;
            _PatientID = PatientID;
            lbTitle.Text = "Update Medical Record";
            _Mode = _enMode.Update;
            btnAddPrescription.Visible = true;
        }

        public frmAddEditMedicalRecordInfo(int PatientID)
        {
            InitializeComponent();
            _PatientID = PatientID;
            _Mode = _enMode.AddNew;
        }

        private void frmAddEditMedicalRecordInfo_Load(object sender, EventArgs e)
        {
            lbPatientID.Text = _PatientID.ToString();

            if (_Mode == _enMode.AddNew)
            {
                _MedicalRecord = new clsMedicalRecord();
                return;
            }

            else
                _LoadMedicalRecordData();
        }

        private void _LoadMedicalRecordData()
        {
            _MedicalRecord = clsMedicalRecord.Find(_MedicalRecordID);

            if (_MedicalRecord == null)
            {
                MessageBox.Show($"No MedicalRecord with MedicalRecordID {_MedicalRecordID} is found in the system !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbMedicalRecordID.Text = _MedicalRecord.MedicalRecordID.ToString();
            tbDiagnosis.Text = _MedicalRecord.Diagnosis.ToString();
            tbVisitDescription.Text = _MedicalRecord.VisitDescription.ToString();
            tbAdditionalNotes.Text = _MedicalRecord.AdditionalNotes.ToString();
        }

        private bool _SaveMedicalRecordData()
        {
            _MedicalRecord.Diagnosis = tbDiagnosis.Text.ToString();
            _MedicalRecord.VisitDescription = tbVisitDescription.Text.ToString();
            _MedicalRecord.AdditionalNotes = tbAdditionalNotes.Text.ToString();

            if (_MedicalRecord.Save())
            {
                MessageBox.Show($"MedicalRecord Data is saved successfully !");
                _MedicalRecordID = _MedicalRecord.MedicalRecordID;
                return true;
            }

            else
            {
                MessageBox.Show($"MedicalRecord Data was not saved successfully !");
                return false;
            }
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveMedicalRecordData())
                {
                    _Mode = _enMode.Update;
                    lbMedicalRecordID.Text = _MedicalRecordID.ToString();
                    lbTitle.Text = "Update Medical Record";
                    btnAddPrescription.Visible = true;

                    MedicalRecordDataBack?.Invoke(this, _MedicalRecordID);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPrescriptionInfo(_MedicalRecordID);
            frm.ShowDialog();
        }
    }
}
