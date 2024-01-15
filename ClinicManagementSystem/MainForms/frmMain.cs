using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusinessLayer;
using ClinicManagementSystem.ManageAppointments;
using ClinicManagementSystem.ManageDoctors;
using ClinicManagementSystem.ManageMedicalRecords;
using ClinicManagementSystem.ManagePatients;
using ClinicManagementSystem.ManagePayments;
using ClinicManagementSystem.ManagePrescriptions;
using ClinicManagementSystem.ManageSpecialities;
using ClinicManagementSystem.ManageUsers;

namespace ClinicManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }

        private void _FillFormInPanelContainer(Form form)
        {    
            form.BackColor = Color.FromArgb(240, 236, 252);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _FillFormInPanelContainer(new frmDashboard());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            if(!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManageDoctors))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmDoctorsList());
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManagePatients))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmPatientsList());
        }

        private void btnSpecialities_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManageSpecialities))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmSpecialitiesList());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedicalRecords_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManageMedicalRecords))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmMedicalRecordsList());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManagePayments))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmPaymentsList());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManageUsers))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmUsersList());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManageAppointments))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmAppointmentsList());
        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckUserAccessPermission(clsUser.enUserPermissions.ManagePrescriptions))
            {
                MessageBox.Show("You don't have the permission to access , please contact your admin !", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillFormInPanelContainer(new frmPrescriptionsList());
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
           // _FillFormInPanelContainer(new frmShowUserInfo(clsGlobalUser.CurrentUser.UserID));

            Form frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
    }
}
