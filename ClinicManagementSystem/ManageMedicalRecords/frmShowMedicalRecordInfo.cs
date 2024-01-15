using ClinicBusinessLayer;
using ClinicManagementSystem.UserControls;
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
    public partial class frmShowMedicalRecordInfo : Form
    {
        private clsMedicalRecord _MedicalRecord;

        private int _MedicalRecordID = -1;

        private int _PatientID = -1;
        public frmShowMedicalRecordInfo(int MedicalRecordID, int PatientID)
        {
            InitializeComponent();
            _MedicalRecordID = MedicalRecordID;
            _PatientID = PatientID;
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
            lbPatientID.Text = _PatientID.ToString();
            tbDiagnosis.Text = _MedicalRecord.Diagnosis.ToString();
            tbVisitDescription.Text = _MedicalRecord.VisitDescription.ToString();
            tbAdditionalNotes.Text = _MedicalRecord.AdditionalNotes.ToString();
        }

        private void frmShowMedicalRecordInfo_Load(object sender, EventArgs e)
        {
            _LoadMedicalRecordData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
