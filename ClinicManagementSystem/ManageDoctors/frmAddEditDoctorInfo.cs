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
using ClinicManagementSystem.ManagePeople;
using static ClinicManagementSystem.frmAddEditPersonInfo;

namespace ClinicManagementSystem.ManageDoctors
{
    public partial class frmAddEditDoctorInfo : Form
    {
        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsPerson _Person;

        private clsDoctor _Doctor;

        private int _DoctorID = -1;

        private int _SpecialityID = -1;

        private DataTable _DataTable = new DataTable();

        private bool _CanSelectSpecialityTapPage = false;

        public frmAddEditDoctorInfo()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        public frmAddEditDoctorInfo(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;
            _Mode = _enMode.Update;
            _CanSelectSpecialityTapPage = true;
            lbTitle.Text = "Update Doctor";
            btnUpdatePerson.Enabled = true;
            btnSelectPerson.Enabled = false;
        }

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            _SetNumericUpDownMaximum();
            ucSpecialityCard1.LoadSpecialityData(1);

            if (_Mode == _enMode.AddNew)
            {
                _Doctor = new clsDoctor();
                return;
            }

            _LoadDoctorData();
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            _SpecialityID = (int)Nud.Value;

            if (!clsSpecialization.IsSpecializationExist(_SpecialityID))
                ucSpecialityCard1.Refresh();

            else
            {
                ucSpecialityCard1.LoadSpecialityData(_SpecialityID);
            }
        }

        private void _LoadDoctorData()
        {
            _Doctor = clsDoctor.Find(_DoctorID);

            if (_Doctor == null)
            {
                MessageBox.Show($"No Doctor with DoctorID {_DoctorID} is found in the system !");
                btnClose.PerformClick();
                return;
            }

            _Person = clsPerson.Find(_Doctor.PersonID);
            Nud.Value = _Doctor.SpecializationID;        
            ucPersonCard1.LoadPersonData(_Person.PersonID);
        }

        private bool _SaveDoctorData()
        {
            _Doctor.SpecializationID = _SpecialityID;
            _Doctor.Name = _Person.Name;
            _Doctor.Gender = _Person.Gender;
            _Doctor.DateOfBirth = _Person.DateOfBirth;
            _Doctor.Address = _Person.Address;
            _Doctor.Email = _Person.Email;
            _Doctor.PhoneNumber = _Person.PhoneNumber;
            _Doctor.ImagePath = _Person.ImagePath;

            if (_Doctor.Save(_Person.PersonID))
            {
                MessageBox.Show($"Doctor Data is saved successfully !");
                return true;
            }

            else
            {
                MessageBox.Show($"Doctor Data was not saved successfully !");
                return false;
            }
        }

        private void _SetNumericUpDownMaximum()
        {
            _DataTable = clsSpecialization.ListSpecializations();

            Nud.Maximum = Convert.ToInt16(_DataTable.Rows[_DataTable.Rows.Count - 1][0]);         
        }

        private void frmFindPerson_PersonDataBack(object sender , int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            ucPersonCard1.LoadPersonData(PersonID);
        }

        private void tc_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tpSpecialityInfo && !_CanSelectSpecialityTapPage)
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

            else if (_Mode == _enMode.AddNew && clsDoctor.IsDoctorExistByPersonID(_Person.PersonID))
            {
                MessageBox.Show("Selected person already has a doctor , Choose another one !",
                    "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _CanSelectSpecialityTapPage = true;
            tc.SelectTab(tpSpecialityInfo);
            btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_Person != null && _SpecialityID != -1)
            {
                if(_SaveDoctorData())
                {
                    _Mode = _enMode.Update;
                    lbTitle.Text = "Update Doctor";
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

    }
}
