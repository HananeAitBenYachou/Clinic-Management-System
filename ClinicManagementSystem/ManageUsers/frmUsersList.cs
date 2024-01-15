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

namespace ClinicManagementSystem.ManageUsers
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }

        private enum enSearchByOptions { UserID, Name, Gender, PhoneNumber, UserName,Permissions};

        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _Refresh();
            _DataView = clsPatient.ListPatients().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshUsersList();
        }

        private void _RefreshUsersList()
        {
            dgvUsersList.DataSource = clsUser.ListUsers();
            _DataView = clsPatient.ListPatients().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "UserID":
                    return enSearchByOptions.UserID;

                case "Name":
                    return enSearchByOptions.Name;

                case "Gender":
                    return enSearchByOptions.Gender;

                case "PhoneNumber":
                    return enSearchByOptions.PhoneNumber;

                case "UserName":
                    return enSearchByOptions.PhoneNumber;

                case "Permissions":
                    return enSearchByOptions.PhoneNumber;

                default:
                    return enSearchByOptions.UserID;
            }

        }

        private void _SearchUser()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.UserID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "UserID = " + _SearchValue;
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

                case enSearchByOptions.UserName:
                    _DataView.RowFilter = "UserName LIKE '%" + _SearchValue + "%'";
                    break;

                case enSearchByOptions.Permissions:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "Permissions = " + _SearchValue;
                    break;
            }

            dgvUsersList.DataSource = _DataView;
        }

        private void dgvUsersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 200;
            }
        }

        private void dgvUsersList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvUsersList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
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
                _SearchUser();
            }
            else
            {
                _RefreshUsersList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUserInfo();
            frm.ShowDialog();
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedRows.Count > 0)
            {
                Form frm = new frmAddEditUserInfo(Convert.ToInt16(dgvUsersList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedRows.Count > 0)
            {
                Form frm = new frmShowUserInfo(Convert.ToInt16(dgvUsersList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void addtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUserInfo();
            frm.ShowDialog();
            _Refresh();
        }
    }
}
