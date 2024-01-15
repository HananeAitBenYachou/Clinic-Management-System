using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClinicBusinessLayer;

namespace ClinicManagementSystem.ManageDoctors
{
    public partial class frmDoctorsList : Form
    {
        private enum enSearchByOptions { DoctorID , Name , Gender , PhoneNumber , Speciality};
        
        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;

        public frmDoctorsList()
        {
            InitializeComponent();
        }

        private void frmDoctorsList_Load(object sender, EventArgs e)
        {
            _Refresh();     
            _DataView = clsDoctor.ListDoctors().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshDoctorsList();
        }

        private void _RefreshDoctorsList()
        {
            dgvDoctorsList.DataSource = clsDoctor.ListDoctors();
            _DataView = clsDoctor.ListDoctors().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "DoctorID":
                    return enSearchByOptions.DoctorID;

                case "Name":
                    return enSearchByOptions.Name;

                case "Gender":
                    return enSearchByOptions.Gender;

                case "PhoneNumber":
                    return enSearchByOptions.PhoneNumber;

                case "Speciality":
                    return enSearchByOptions.Speciality;

                default:
                    return enSearchByOptions.DoctorID;
            }

        }

        private void _SearchDoctor()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.DoctorID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "DoctorID = " + _SearchValue;
                    break;

                case enSearchByOptions.Name:
                    _DataView.RowFilter = "Name LIKE '%" + _SearchValue + "%'";
                    break;

                case enSearchByOptions.Gender:
                    _DataView.RowFilter = "Gender LIKE '%" + _SearchValue + "%'";
                    break;

                case enSearchByOptions.PhoneNumber:
                    _DataView.RowFilter = "PhoneNumber LIKE '%" + _SearchValue + "%'";
                    break;

                case enSearchByOptions.Speciality:
                    _DataView.RowFilter = "Speciality LIKE '%" + _SearchValue + "%'";
                    break;                
            }

            dgvDoctorsList.DataSource = _DataView;
        }

        private void dgvDoctorsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 210;
            }
        }

        private void dgvDoctorsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {           
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvDoctorsList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbSearchValue.Text))
            {
                _SearchValue = tbSearchValue.Text;
                _SearchDoctor();
            }
            else
            {
                _RefreshDoctorsList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditDoctorInfo();
            frm.ShowDialog();
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvDoctorsList.SelectedRows.Count > 0)
            {
                Form frm = new frmAddEditDoctorInfo(Convert.ToInt16(dgvDoctorsList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvDoctorsList.SelectedRows.Count > 0)
            {
                Form frm = new frmShowDoctorInfo(Convert.ToInt16(dgvDoctorsList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void addtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditDoctorInfo();
            frm.ShowDialog();
            _Refresh();

        }
    }
}
