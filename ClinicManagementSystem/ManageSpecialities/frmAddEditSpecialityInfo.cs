using ClinicBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ClinicManagementSystem.ManageSpecialities
{
    public partial class frmAddEditSpecialityInfo : Form
    {
        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsSpecialization _Speciality;

        private int _SpecialityID = -1;

        public frmAddEditSpecialityInfo(int SpecialityID)
        {
            InitializeComponent();
            _SpecialityID = SpecialityID;
            lbTitle.Text = "Update Speciality";
            tbSpecialityName.Enabled = false;
            _Mode = _enMode.Update;
         }

        public frmAddEditSpecialityInfo()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        private void frmAddEditSpecialityInfo_Load(object sender, EventArgs e)
        {
            if (_Mode == _enMode.AddNew)
            {
                _Speciality = new clsSpecialization();
                return;
            }

            else
                _LoadSpecialityData();
        }

        private void _LoadSpecialityData()
        {
            _Speciality = clsSpecialization.Find(_SpecialityID);

            if (_Speciality == null)
            {
                MessageBox.Show($"Speciality with SpecialityID {_SpecialityID} is not found in the system !");
                btnClose.PerformClick();
            }

            lbSpecialityID.Text = _Speciality.SpecializationID.ToString();
            tbSpecialityName.Text = _Speciality.Name.ToString();
            tbDescription.Text = _Speciality.Description.ToString();
            
        }

        private bool _SaveSpecialityData()
        {
            _Speciality.Name = tbSpecialityName.Text.ToString();
            _Speciality.Description = tbDescription.Text.ToString();
          
            if (_Speciality.Save())
            {
                MessageBox.Show($"Speciality Data is saved successfully !");
                _SpecialityID = _Speciality.SpecializationID;
                return true;
            }

            else
            {
                MessageBox.Show($"Speciality Data was not saved successfully !");
                return false;
            }
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void tbSpecialityName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if(_Mode == _enMode.AddNew && clsSpecialization.IsSpecializationExist(tbSpecialityName.Text.ToString()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSpecialityName, "This speciality already exists , please choose another name !");
            }
            
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSpecialityName, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveSpecialityData())
                {
                    _Mode = _enMode.Update;
                    lbSpecialityID.Text = _SpecialityID.ToString();
                    lbTitle.Text = "Update Speciality";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
