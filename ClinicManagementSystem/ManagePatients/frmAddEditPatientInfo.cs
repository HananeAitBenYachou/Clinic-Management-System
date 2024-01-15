using ClinicBusinessLayer;
using ClinicManagementSystem.ManagePeople;
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
    public partial class frmAddEditPatientInfo : Form
    {
        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsPerson _Person;

        private clsPatient _Patient;

        private int _PatientID = -1;

        public frmAddEditPatientInfo()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }

        public frmAddEditPatientInfo(int PatientID)
        {
            InitializeComponent();
            _PatientID = PatientID;
            _Mode = _enMode.Update;
            lbTitle.Text = "Update Patient";
            btnUpdatePerson.Enabled = true;
            btnSelectPerson.Enabled = false;
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            if (_Mode == _enMode.AddNew)
            {
                _Patient = new clsPatient();
                return;
            }

            _LoadPatientData();
        }

        private void _LoadPatientData()
        {
            _Patient = clsPatient.Find(_PatientID);

            if (_Patient == null)
            {
                MessageBox.Show($"No Patient with PatientID {_PatientID} is found in the system !");
                btnClose.PerformClick();
                return;
            }

            _Person = clsPerson.Find(_Patient.PersonID);         
            ucPersonCard1.LoadPersonData(_Person.PersonID);
        }

        private bool _SavePatientData()
        {
            _Patient.Name = _Person.Name;
            _Patient.Gender = _Person.Gender;
            _Patient.DateOfBirth = _Person.DateOfBirth;
            _Patient.Address = _Person.Address;
            _Patient.Email = _Person.Email;
            _Patient.PhoneNumber = _Person.PhoneNumber;
            _Patient.ImagePath = _Person.ImagePath;
            
            if (_Patient.Save(_Person.PersonID))
            {
                MessageBox.Show($"Patient Data is saved successfully !");
                return true;
            }

            else
            {
                MessageBox.Show($"Patient Data was not saved successfully !");
                return false;
            }
        }

        private void frmFindPerson_PersonDataBack(object sender, int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            ucPersonCard1.LoadPersonData(PersonID);
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.PersonDataBack += frmFindPerson_PersonDataBack;
            frm.ShowDialog();
        }

        private bool _IsPersonSelectedValid()
        {
            if (_Person == null)
            {
                MessageBox.Show("Please select a person first !",
                    "Select a person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (_Mode == _enMode.AddNew && clsPatient.IsPatientExistByPersonID(_Person.PersonID))
            {
                MessageBox.Show("Selected person already has a patient , Choose another one !",
                    "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsPersonSelectedValid())
                return;

            if (_SavePatientData())
            {
                _Mode = _enMode.Update;
                lbTitle.Text = "Update Patient";
                btnUpdatePerson.Enabled = true;
                btnSelectPerson.Enabled = false;
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
