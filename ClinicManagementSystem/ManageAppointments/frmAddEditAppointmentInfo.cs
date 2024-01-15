using ClinicBusinessLayer;
using ClinicManagementSystem.ManageMedicalRecords;
using ClinicManagementSystem.ManagePayments;
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

namespace ClinicManagementSystem.ManageAppointments
{
    public partial class frmAddEditAppointmentInfo : Form
    {
        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsAppointment _Appointment;

        private int _AppointmentID = -1;

        public frmAddEditAppointmentInfo(int AppointmentID)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            lbTitle.Text = "Update Appointment";
            _Mode = _enMode.Update;
        }

        public frmAddEditAppointmentInfo()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        private void frmAddEditAppointmentInfo_Load(object sender, EventArgs e)
        {
            if (_Mode == _enMode.AddNew)
            {
                _Appointment = new clsAppointment();
                return;
            }

            else
                _LoadAppointmentData();
        }

        private bool _IsAppointmentDateFree()
        {
            if (!clsAppointment.IsAppointmentDateFree(Convert.ToInt16(tbDoctorID.Text), dtpAppointmentDate.Value))
            {
                MessageBox.Show($"Doctor with DoctorID {tbDoctorID.Text} already has an appointment at this date , please choose different doctor or different date !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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
            tbPatientID.Text = _Appointment.PatientID.ToString();
            tbDoctorID.Text = _Appointment.DoctorID.ToString();
            dtpAppointmentDate.Value = _Appointment.AppointmentDateTime;
            cbAppointmentStatus.SelectedIndex = (_Appointment.AppointmentStatus)-1;

            if (_Appointment.MedicalRecordID != null)
            {
                lbMedicalRecordID.Text = _Appointment.MedicalRecordID.ToString();
                btnAddMedicalRecord.Visible = false;
            }
            else
            {
                lbMedicalRecordID.Text = "N/A";
            }

            if (_Appointment.PaymentID != null)
            {
                lbPaymentID.Text = _Appointment.PaymentID.ToString();
                btnPay.Visible = false;
            }
            else
                lbPaymentID.Text = "N/A";
        }

        private bool _SaveAppointmentData()
        {
            _Appointment.PatientID = Convert.ToInt16(tbPatientID.Text);
            _Appointment.DoctorID = Convert.ToInt16(tbDoctorID.Text);
            _Appointment.AppointmentDateTime = dtpAppointmentDate.Value;
            _Appointment.AppointmentStatus = Convert.ToInt16(cbAppointmentStatus.SelectedIndex+1);

            if (_Appointment.Save())
            {          
                MessageBox.Show($"Appointment Data is saved successfully !");
                _AppointmentID = _Appointment.AppointmentID ;
                return true;
            }

            else
            {
                MessageBox.Show($"Appointment Data was not saved successfully !");
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if ((_Mode == _enMode.AddNew && !_IsAppointmentDateFree()))
                    return;

                if (_SaveAppointmentData())
                {
                    _Mode = _enMode.Update;
                    lbAppointmentID.Text = _AppointmentID.ToString();
                    lbTitle.Text = "Update Appointment";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMedicalRecord_Click(object sender, EventArgs e)
        {
            frmAddEditMedicalRecordInfo frm = new frmAddEditMedicalRecordInfo(Convert.ToInt16(tbPatientID.Text));
            frm.MedicalRecordDataBack += frmAddEditMedicalRecordInfo_MedicalRecordDataBack;
            frm.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmAddEditPaymentInfo frm = new frmAddEditPaymentInfo(Convert.ToInt16(tbPatientID.Text));
            frm.PaymentDataBack += frmAddEditPaymentInfo_PaymentDataBack;
            frm.ShowDialog();
        }

        private void frmAddEditPaymentInfo_PaymentDataBack(object sender, int PaymentID)
        {
            if(PaymentID != -1)
            {
                btnPay.Visible = false;
                lbPaymentID.Text = PaymentID.ToString();
                _Appointment.PaymentID = PaymentID;
            }
        }

        private void frmAddEditMedicalRecordInfo_MedicalRecordDataBack(object sender, int MedicalRecordID)
        {
            if (MedicalRecordID != -1)
            {
                btnAddMedicalRecord.Visible = false;
                lbMedicalRecordID.Text = MedicalRecordID.ToString();
                _Appointment.MedicalRecordID = MedicalRecordID;
            }
        }

        private void tbPatientID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPatientID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPatientID, "This field is required !");
            }

            else if (!clsPatient.IsPatientExist(Convert.ToInt32(tbPatientID.Text)))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPatientID, "Please enter a valid PatientID!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPatientID, "");
            }
        }

        private void tbDoctorID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDoctorID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDoctorID, "This field is required !");
            }

            else if (!clsDoctor.IsDoctorExist(Convert.ToInt32(tbDoctorID.Text)))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDoctorID,"Please enter a valid DoctorID!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbDoctorID, "");
            }
        }       

    }
}
