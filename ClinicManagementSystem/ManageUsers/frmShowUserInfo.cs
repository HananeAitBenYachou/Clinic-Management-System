using ClinicBusinessLayer;
using ClinicManagementSystem.UserControls;
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

namespace ClinicManagementSystem.ManageUsers
{
    public partial class frmShowUserInfo : Form
    {
        private clsUser _User;

        private int _UserID;

        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void _LoadUserPermissions()
        {
            if ((_User.CheckUserAccessPermission(clsUser.enUserPermissions.All)))
            {
                tsAll.Checked = true;
                return;
            }

            foreach (Guna2ToggleSwitch toggleSwitch in PermissionsPanel.Controls)
            {
                clsUser.enUserPermissions permission = (clsUser.enUserPermissions)Enum.Parse(typeof(clsUser.enUserPermissions), toggleSwitch.Tag.ToString());

                if (_User.CheckUserAccessPermission(permission))
                {
                    toggleSwitch.Checked = true;

                }
            }
        }

        private void _LoadUserAccountData()
        {
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            _LoadUserPermissions();
        }

        private void _LoadUserData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"No User with UserID {_UserID} is found in the system !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucPersonCard1.LoadPersonData(_User.PersonID);
            _LoadUserAccountData();
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            _LoadUserData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAll_CheckedChanged(object sender, EventArgs e)
        {           
            foreach (Guna2ToggleSwitch toggleSwitch in PermissionsPanel.Controls)
            {
                toggleSwitch.Checked = tsAll.Checked;
            }             
        }
    }
}
