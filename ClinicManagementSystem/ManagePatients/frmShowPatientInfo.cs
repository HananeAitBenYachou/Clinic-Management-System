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

namespace ClinicManagementSystem.ManagePatients
{
    public partial class frmShowPatientInfo : Form
    {
        private clsPatient _Patient;

        private int _PatientID;

        public frmShowPatientInfo(int PatientID)
        {
            InitializeComponent();
            _PatientID = PatientID;
        }
      
        private void _LoadPatientData()
        {
            _Patient = clsPatient.Find(_PatientID);

            if (_Patient == null)
            {
                MessageBox.Show($"No Patient with PatientID {_PatientID} is found in the system !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _Patient = clsPatient.Find(_PatientID);
            ucPersonCard1.LoadPersonData(_Patient.PersonID);
        }

        private void frmShowPatientInfo_Load(object sender, EventArgs e)
        {
            _LoadPatientData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
