using ClinicBusinessLayer;
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

namespace ClinicManagementSystem.ManagePrescriptions
{
    public partial class frmAddEditPrescriptionInfo : Form
    {
        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsPrescription _Prescription;

        private int _PrescriptionID = -1;

        private int _MedicalRecord = -1;

        public frmAddEditPrescriptionInfo(int PrescriptionID , int MedicalRecordID)
        {
            InitializeComponent();
            _PrescriptionID = PrescriptionID;
            _MedicalRecord = MedicalRecordID;
            lbTitle.Text = "Update Prescription";
            _Mode = _enMode.Update;
        }

        public frmAddEditPrescriptionInfo(int MedicalRecordID)
        {
            InitializeComponent();
            _MedicalRecord = MedicalRecordID;
            lbMedicalRecordID.Text =MedicalRecordID.ToString();
            _Mode = _enMode.AddNew;
        }

        private void frmAddEditPrescriptionInfo_Load(object sender, EventArgs e)
        {

            if (_Mode == _enMode.AddNew)
            {
                _Prescription = new clsPrescription();
                return;
            }

            else
                _LoadPrescriptionData();
        }

        private void _LoadPrescriptionData()
        {
            _Prescription = clsPrescription.Find(_PrescriptionID);

            if (_Prescription == null)
            {
                MessageBox.Show($"No Prescription with PrescriptionID {_PrescriptionID} is found in the system !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbPrescriptionID.Text = _Prescription.PrescriptionID.ToString();
            lbMedicalRecordID.Text = _Prescription.MedicalRecordID.ToString();
            tbMedicationName.Text = _Prescription.MedicationName;
            tbDosage.Text = _Prescription.Dosage;
            tbFrequency.Text = _Prescription.Frequency;
            dtpStartDate.Value = _Prescription.StartDate;
            dtpEndDate.Value = _Prescription.EndDate;
            tbSpecialInstructions.Text = _Prescription.SpecialInstructions;
        }

        private bool _SavePrescriptionData()
        {
            _Prescription.MedicationName = tbMedicationName.Text;
            _Prescription.Dosage = tbDosage.Text;
            _Prescription.Frequency = tbFrequency.Text;
            _Prescription.StartDate = dtpStartDate.Value;
            _Prescription.EndDate = dtpEndDate.Value;
            _Prescription.SpecialInstructions = tbSpecialInstructions.Text;
            _Prescription.MedicalRecordID = Convert.ToInt16(lbMedicalRecordID.Text);

            if (_Prescription.Save())
            {
                MessageBox.Show($"Prescription Data is saved successfully !");
                _PrescriptionID = _Prescription.PrescriptionID;
                return true;
            }

            else
            {
                MessageBox.Show($"Prescription Data was not saved successfully !");
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
                if (_SavePrescriptionData())
                {
                    _Mode = _enMode.Update;
                    lbPrescriptionID.Text = _PrescriptionID.ToString();
                    lbTitle.Text = "Update Prescription";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
