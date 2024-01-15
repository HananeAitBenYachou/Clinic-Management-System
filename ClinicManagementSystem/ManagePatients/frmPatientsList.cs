using ClinicBusinessLayer;
using ClinicManagementSystem.ManageDoctors;
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
    public partial class frmPatientsList : Form
    {
        public frmPatientsList()
        {
            InitializeComponent();
        }

        private enum enSearchByOptions { PatientID, Name, Gender, PhoneNumber };

        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;

        private void frmPatientsList_Load(object sender, EventArgs e)
        {
            _Refresh();
            _DataView = clsPatient.ListPatients().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshPatientsList();
        }

        private void _RefreshPatientsList()
        {
            dgvPatientsList.DataSource = clsPatient.ListPatients();
            _DataView = clsPatient.ListPatients().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "PatientID":
                    return enSearchByOptions.PatientID;

                case "Name":
                    return enSearchByOptions.Name;

                case "Gender":
                    return enSearchByOptions.Gender;

                case "PhoneNumber":
                    return enSearchByOptions.PhoneNumber;

                default:
                    return enSearchByOptions.PatientID;
            }

        }

        private void _SearchPatient()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.PatientID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "PatientID = " + _SearchValue;
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
               
            }

            dgvPatientsList.DataSource = _DataView;
        }

        private void dgvPatientsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 210;
            }
        }

        private void dgvPatientsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvPatientsList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearchValue.Text))
            {
                _SearchValue = tbSearchValue.Text;
                _SearchPatient();
            }
            else
            {
                _RefreshPatientsList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPatientInfo();
            frm.ShowDialog();
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvPatientsList.SelectedRows.Count > 0)
            {
                Form frm = new frmAddEditPatientInfo(Convert.ToInt16(dgvPatientsList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvPatientsList.SelectedRows.Count > 0)
            {
                Form frm = new frmShowPatientInfo(Convert.ToInt16(dgvPatientsList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void addtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPatientInfo();
            frm.ShowDialog();
            _Refresh();
        }
    }
}
