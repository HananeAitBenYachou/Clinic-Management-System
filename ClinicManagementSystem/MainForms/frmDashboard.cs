using ClinicBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {           
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private CultureInfo _englishCulture = new CultureInfo("en-US");

        private void _LoadDashboardData()
        {
            lblNumberOfDoctors.Text = clsDoctor.CountDoctors().ToString();
            lblNumberOfPatients.Text = clsPatient.CountPatients().ToString();
            lblNumberOfUsers.Text = clsUser.CountUsers().ToString();
            lblNumberOfSpecialities.Text = clsSpecialization.CountSpecializations().ToString();
            lblNumberOfAppointments.Text = clsAppointment.CountAppointments().ToString();
            lblNumberOfPayments.Text = clsPayment.CountPayments().ToString();
            lblNumberOfMedRecords.Text = clsMedicalRecord.CountMedicalRecords().ToString();
            lblNumberOfPrescriptions.Text = clsPrescription.CountPrescriptions().ToString();
        }

        private void _UpadateCurrentTime()
        {
            lblCurrentTime.Text = DateTime.Now.ToString("T", _englishCulture);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _UpadateCurrentTime();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToString("d", _englishCulture);
            _LoadDashboardData();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar2.Value < 100)
                guna2CircleProgressBar2.Value += 5;

            else
                guna2CircleProgressBar2.Value = 5;
        }

    }
}
