using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class frmAddEditPersonInfo : Form
    {
        public delegate void PersonDataBackEventHanlder(object sender, int PersonID);

        public event PersonDataBackEventHanlder PersonDataBack;

        private int _PersonID = -1;

        public frmAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();
            lbTitle.Text = "Update Person";
            lbPersonID.Text = PersonID.ToString();
            ucAddEditPersonInfo1.SetPersonID(PersonID);
        }

        public frmAddEditPersonInfo()
        {
            InitializeComponent();
            lbPersonID.Text = "N/A";
        }

        public void ucAddEditPersonInfo_SaveButtonClicked(bool isSaved, int PersonID)
        {
            _PersonID = PersonID;

            if (isSaved)
            {
                lbPersonID.Text = PersonID.ToString();
                lbTitle.Text = "Update Person";
                PersonDataBack?.Invoke(this, _PersonID);
            }
        }
    }

}

