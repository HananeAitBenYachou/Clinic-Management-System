using ClinicBusinessLayer;
using ClinicManagementSystem.ManagePeople;
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
    public partial class frmAddEditUserInfo : Form
    {
        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsPerson _Person;

        private clsUser _User;

        private int _UserID = -1;

        private bool _CanSelectSpecialityTapPage = false;

        public frmAddEditUserInfo()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        public frmAddEditUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = _enMode.Update;
            _CanSelectSpecialityTapPage = true;
            lbTitle.Text = "Update User";
            btnUpdatePerson.Enabled = true;
            btnSelectPerson.Enabled = false;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (_Mode == _enMode.AddNew)
            {
                _User = new clsUser();
                return;
            }

            _LoadUserData();
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

            _Person = clsPerson.Find(_User.PersonID);
            ucPersonCard1.LoadPersonData(_User.PersonID);
            _LoadUserAccountData();
        }

        private short _GetUserPermissions()
        {
            if (tsAll.Checked)
                return -1;

            short Permissions = 0;

            foreach (Guna2ToggleSwitch toggleSwitch in PermissionsPanel.Controls)
            {
                if(toggleSwitch.Checked)
                   Permissions += Convert.ToInt16(toggleSwitch.Tag);
            }

            return Permissions;
        }

        private bool _SaveUserData()
        {
            _User.Name = _Person.Name;
            _User.Gender = _Person.Gender;
            _User.DateOfBirth = _Person.DateOfBirth;
            _User.Address = _Person.Address;
            _User.Email = _Person.Email;
            _User.PhoneNumber = _Person.PhoneNumber;
            _User.ImagePath = _Person.ImagePath;
            _User.UserName = tbUserName.Text;
            _User.Password = tbPassword.Text;
            _User.Permissions = _GetUserPermissions();

            if (_User.Save(_Person.PersonID))
            {
                MessageBox.Show($"User Data is saved successfully !");
                return true;
            }

            else
            {
                MessageBox.Show($"User Data was not saved successfully !");
                return false;
            }
        }

        private void tsAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Guna2ToggleSwitch toggleSwitch in PermissionsPanel.Controls)
            {
                toggleSwitch.Checked = tsAll.Checked;
            }
        }

        private void frmFindPerson_PersonDataBack(object sender, int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            ucPersonCard1.LoadPersonData(PersonID);
        }

        private void tc_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tpAccountInfo && !_CanSelectSpecialityTapPage)
            {
                e.Cancel = true;
            }
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmFindPerson FormFindPerson = new frmFindPerson();
            FormFindPerson.PersonDataBack += frmFindPerson_PersonDataBack;
            FormFindPerson.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Person == null)
            {
                MessageBox.Show("Please select a person first !",
                    "Select a person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (_Mode == _enMode.AddNew && clsUser.IsUserExistByPersonID(_Person.PersonID))
            {
                MessageBox.Show("Selected person already has a user , Choose another one !",
                    "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _CanSelectSpecialityTapPage = true;
            tc.SelectTab(tpAccountInfo);
            btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Person != null && ValidateChildren())
            {
                if (_SaveUserData())
                {
                    _Mode = _enMode.Update;
                    lbTitle.Text = "Update User";
                    btnUpdatePerson.Enabled = true;
                    btnSelectPerson.Enabled = false;
                }

            }
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            frmAddEditPersonInfo frm = new frmAddEditPersonInfo(_Person.PersonID);
            frm.PersonDataBack += frmAddEditPersonInfo_PersonDataBack;
            frm.ShowDialog();

            ucPersonCard1.LoadPersonData(_Person.PersonID);
        }

        private void frmAddEditPersonInfo_PersonDataBack(object sender, int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
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
      
    }
}
