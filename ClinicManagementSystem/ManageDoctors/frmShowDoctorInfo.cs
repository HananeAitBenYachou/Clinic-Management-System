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

namespace ClinicManagementSystem.ManageDoctors
{
    public partial class frmShowDoctorInfo : Form
    {
        private clsDoctor _Doctor;

        private int _DoctorID;

        public frmShowDoctorInfo(int DoctorID)
        {
            InitializeComponent();
            _DoctorID = DoctorID;         
        }

        private void _LoadDoctorData()
        {
            _Doctor = clsDoctor.Find(_DoctorID);

            if (_Doctor == null)
            {
                MessageBox.Show($"No Doctor with DoctorID {_DoctorID} is found in the system !","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucPersonCard1.LoadPersonData(_Doctor.PersonID);
            ucSpecialityCard1.LoadSpecialityData(_Doctor.SpecializationID);
        }

        private void frmShowDoctorInfo_Load(object sender, EventArgs e)
        {
            _LoadDoctorData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
