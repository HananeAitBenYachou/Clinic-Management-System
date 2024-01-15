using ClinicBusinessLayer;
using ClinicManagementSystem.ManagePatients;
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
    public partial class frmSpecialitiesList : Form
    {
        private enum enSearchByOptions { SpecialityID, Name, Description };

        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;

        public frmSpecialitiesList()
        {
            InitializeComponent();
        }

        private void frmSpecialitiesList_Load(object sender, EventArgs e)
        {
            _Refresh();
            _DataView = clsSpecialization.ListSpecializations().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshSpecialitiesList();
        }

        private void _RefreshSpecialitiesList()
        {
            dgvSpecialitiesList.DataSource = clsSpecialization.ListSpecializations();
            _DataView = clsSpecialization.ListSpecializations().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "SpecialityID":
                    return enSearchByOptions.SpecialityID;

                case "Name":
                    return enSearchByOptions.Name;            

                case "Description":
                    return enSearchByOptions.Description;

                default:
                    return enSearchByOptions.SpecialityID;
            }

        }

        private void _SearchSpeciality()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.SpecialityID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "SpecializationID = " + _SearchValue;
                    break;

                case enSearchByOptions.Name:
                    _DataView.RowFilter = "Name LIKE '%" + _SearchValue + "%'";
                    break;

                case enSearchByOptions.Description:
                    _DataView.RowFilter = "Description LIKE '%" + _SearchValue + "%'";
                    break;
            }

            dgvSpecialitiesList.DataSource = _DataView;
        }

        private void dgvSpecialitiesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 430;
            }
        }

        private void dgvSpecialitiesList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvSpecialitiesList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
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
                _SearchSpeciality();
            }
            else
            {
                _RefreshSpecialitiesList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditSpecialityInfo();
            frm.ShowDialog();
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvSpecialitiesList.SelectedRows.Count > 0)
            {
                Form frm = new frmAddEditSpecialityInfo(Convert.ToInt16(dgvSpecialitiesList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvSpecialitiesList.SelectedRows.Count > 0)
            {
                Form frm = new frmShowSpecialityInfo(Convert.ToInt16(dgvSpecialitiesList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void addtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditSpecialityInfo();
            frm.ShowDialog();
            _Refresh();
        }
    }
}
