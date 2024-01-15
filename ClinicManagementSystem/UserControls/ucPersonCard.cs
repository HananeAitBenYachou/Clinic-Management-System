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

namespace ClinicManagementSystem.UserControls
{
    public partial class ucPersonCard : UserControl
    {
        private clsPerson _Person = new clsPerson();

        private int _PersonID = -1; 

        public ucPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonData(int PersonID)
        {
            _PersonID = PersonID;
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"No Person with PersonID {_PersonID} is not found in the system !");
                return;
            }

            lbPersonID.Text = _Person.PersonID.ToString();
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
        }

    }
}
