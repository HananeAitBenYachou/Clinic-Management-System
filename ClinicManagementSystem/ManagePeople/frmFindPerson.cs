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

namespace ClinicManagementSystem.ManagePeople
{
    public partial class frmFindPerson : Form
    {
        public delegate void PersonIDDataBackEventHandler(object sender, int PersonID);

        public event PersonIDDataBackEventHandler PersonDataBack;

        private int _PersonID = -1;

        private clsPerson _Person = null;

        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void _SearchPerson()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"No Person with PersonID {_PersonID} is found in the system !");
                tbPersonIDToSearch.ResetText();
                return;
            }

            ucPersonCard1.LoadPersonData(_PersonID);
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                _SearchPerson();
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPersonInfo frmAddEditPersonInfo = new frmAddEditPersonInfo();
            frmAddEditPersonInfo.PersonDataBack += frmAddEditPersonInfo_PersonDataBack;
            frmAddEditPersonInfo.ShowDialog();
        }

        private void tbPersonIDToSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPersonIDToSearch.Text))
            {
                e.Cancel = true;
                tbPersonIDToSearch.Focus();
                errorProvider1.SetError(tbPersonIDToSearch, "Please enter personID to search !");
            }

            else if(!int.TryParse(tbPersonIDToSearch.Text,out int _))
            {
                e.Cancel = true;
                tbPersonIDToSearch.Focus();
                errorProvider1.SetError(tbPersonIDToSearch, "Please enter numbers only !");
            }
         
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPersonIDToSearch, "");
                _PersonID = int.Parse(tbPersonIDToSearch.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(_PersonID != -1)
            {
                PersonDataBack?.Invoke(this, _PersonID);
            }

            this.Close();
        }

        private void frmAddEditPersonInfo_PersonDataBack(object sender, int PersonID)
        {
            _PersonID = PersonID;
            _SearchPerson();
        }

    }
}
