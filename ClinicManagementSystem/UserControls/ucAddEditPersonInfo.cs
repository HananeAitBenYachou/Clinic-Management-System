using System;
using System.Windows.Forms;
using ClinicBusinessLayer;
using Guna.UI2.WinForms;

namespace ClinicManagementSystem
{
    public partial class ucAddEditPersonInfo : UserControl
    {
        private enum _enMode { AddNew , Update};

        private _enMode _Mode;

        private int _PersonID = -1;

        private clsPerson _Person = new clsPerson();

        public ucAddEditPersonInfo()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
            lbRemoveImage.Visible = false;
        }
        
        public void SetPersonID(int PersonID)
        {
            _PersonID = PersonID;
            _Mode = _enMode.Update;
        }

        private void ucAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            if (_Mode == _enMode.AddNew)
            {
                _Person = new clsPerson();
                return;
            }

            else
                _LoadPersonData();
        }

        private void _LoadPersonData()
        {           
            _Person = clsPerson.Find(_PersonID);

            if(_Person == null)
            {
                MessageBox.Show($"No Person with PersonID {_PersonID} is found in the system !");
                btnClose.PerformClick();
            }

            tbName.Text = _Person.Name.ToString();
            tbAddress.Text = _Person.Address.ToString();
            tbPhoneNumber.Text = _Person.PhoneNumber.ToString();
            tbEmail.Text = _Person.Email.ToString();
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (_Person.ImagePath != "")
                pictureBox.Load(_Person.ImagePath);

            else
                pictureBox.Image = Properties.Resources.unknown;

            lbRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private bool _SavePersonData()
        {
            _Person.Name = tbName.Text.ToString();
            _Person.Address = tbAddress.Text.ToString();
            _Person.PhoneNumber = tbPhoneNumber.Text.ToString();
            _Person.Email = tbEmail.Text.ToString();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = (rbMale.Checked ? 'M' : 'F');

            if(pictureBox.ImageLocation != @"C:\Users\hanan\source\repos\ClinicManagementSystem\Resources\unknown.png")
                _Person.ImagePath = pictureBox.ImageLocation;

            else
                _Person.ImagePath = "";
            
            if(_Person.Save())
            {
                MessageBox.Show($"Person Data is saved successfully !");
                _PersonID = _Person.PersonID;
                return true ;             
            }

            else
            {
                MessageBox.Show($"Person Data was not saved successfully !");
                return false;
            }

        }

        private void lbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\hanan\Contacts\Desktop\Downloads";
            openFileDialog1.Title = "File Dialog";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog1.FileName);
                lbRemoveImage.Visible = true;
            }
        }

        private void lbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbRemoveImage.Visible = false;
            lbUploadImage.Visible = true;
            pictureBox.ImageLocation = @"C:\Users\hanan\source\repos\ClinicManagementSystem\Resources\unknown.png";
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if(string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox,"This field is required !");    
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
                if (_SavePersonData())
                {
                    _Mode = _enMode.Update;

                    frmAddEditPersonInfo parentForm = FindForm() as frmAddEditPersonInfo;
                    parentForm?.ucAddEditPersonInfo_SaveButtonClicked(true, _PersonID);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            parentForm?.Close();
        }
    }
}
