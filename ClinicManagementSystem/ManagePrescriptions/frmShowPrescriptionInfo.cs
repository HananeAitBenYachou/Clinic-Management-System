using ClinicBusinessLayer;
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
    public partial class frmShowPrescriptionInfo : Form
    {
        private clsPrescription _Prescription;

        private int _PrescriptionID = -1;

        public frmShowPrescriptionInfo(int PrescriptionID)
        {
            InitializeComponent();
            _PrescriptionID = PrescriptionID;
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

        private void frmShowPrescriptionInfo_Load(object sender, EventArgs e)
        {
            _LoadPrescriptionData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
