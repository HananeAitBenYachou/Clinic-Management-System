using ClinicBusinessLayer;
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

namespace ClinicManagementSystem.ManageSpecialities
{
    public partial class frmShowSpecialityInfo : Form
    {
        private clsSpecialization _Speciality;

        private int _SpecialityID;

        public frmShowSpecialityInfo(int SpecialityID)
        {
            InitializeComponent();
            _SpecialityID = SpecialityID;
        }

        private void _LoadSpecialityData()
        {
            _Speciality = clsSpecialization.Find(_SpecialityID);

            if (_Speciality == null)
            {
                MessageBox.Show($"No Speciality with SpecialityID {_SpecialityID} is found in the system !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucSpecialityCard1.LoadSpecialityData(_Speciality.SpecializationID);
        }

        private void frmShowSpecialityInfo_Load(object sender, EventArgs e)
        {
            _LoadSpecialityData();
        }
    }
}
