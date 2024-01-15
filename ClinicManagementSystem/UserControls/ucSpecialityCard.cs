using ClinicBusinessLayer;
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

namespace ClinicManagementSystem.UserControls
{
    public partial class ucSpecialityCard : UserControl
    {
        private clsSpecialization _Speciality = new clsSpecialization();

        private int _SpecialityID = -1;

        public ucSpecialityCard()
        {
            InitializeComponent();
        }

        public void LoadSpecialityData(int SpecialityID)
        {
            _SpecialityID = SpecialityID;
            _Speciality = clsSpecialization.Find(_SpecialityID);

            if (_Speciality == null)
            {
                MessageBox.Show($"Speciality with SpecialityID {_SpecialityID} is not found in the system !");
                return;
            }

            lbSpecialityID.Text = _Speciality.SpecializationID.ToString();
            tbSpecialityName.Text = _Speciality.Name.ToString();
            tbDescription.Text = _Speciality.Description.ToString();

        }

        public void Refresh()
        {
            lbSpecialityID.Text = "N/A";
            tbSpecialityName.Text = "????";
            tbDescription.Text = "????";
        }

        private void ucSpecialityCard_Load(object sender, EventArgs e)
        {
            //LoadSpecialityData(1);
        }
    }
}
