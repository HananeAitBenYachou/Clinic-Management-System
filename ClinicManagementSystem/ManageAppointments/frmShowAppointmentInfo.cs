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

namespace ClinicManagementSystem.ManageAppointments
{
    public partial class frmShowAppointmentInfo : Form
    {
        private clsAppointment _Appointment;

        private int _AppointmentID = -1;

        public frmShowAppointmentInfo(int AppointmentID)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
        }

        private void _LoadAppointmentData()
        {
            _Appointment = clsAppointment.Find(_AppointmentID);

            if (_Appointment == null)
            {
                MessageBox.Show($"No Appointment with AppointmentID {_AppointmentID} is found in the system !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbAppointmentID.Text = _Appointment.AppointmentID.ToString();
            lbPatientID.Text = _Appointment.PatientID.ToString();
            lbDoctorID.Text = _Appointment.DoctorID.ToString();
            dtpAppointmentDate.Value = _Appointment.AppointmentDateTime;
            cbAppointmentStatus.SelectedIndex = (_Appointment.AppointmentStatus)-1;

            if (_Appointment.MedicalRecordID != null)
                lbMedicalRecordID.Text = _Appointment.MedicalRecordID.ToString();
            else
                lbMedicalRecordID.Text = "N/A";

            if (_Appointment.PaymentID != null)
                lbPaymentID.Text = _Appointment.PaymentID.ToString();
            else
                lbPaymentID.Text = "N/A";
        }

        private void frmShowAppointmentInfo_Load(object sender, EventArgs e)
        {
            _LoadAppointmentData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
