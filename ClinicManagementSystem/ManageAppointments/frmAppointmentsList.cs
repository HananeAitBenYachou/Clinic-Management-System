using ClinicBusinessLayer;
using ClinicManagementSystem.ManageDoctors;
using ClinicManagementSystem.ManageMedicalRecords;
using ClinicManagementSystem.ManagePayments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.ManageAppointments
{
    public partial class frmAppointmentsList : Form
    {
        private enum enSearchByOptions { AppointmentID, AppointmentStatus , PatientID , DoctorID };

        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;

        public frmAppointmentsList()
        {
            InitializeComponent();
        }

        private void frmAppointmentsList_Load(object sender, EventArgs e)
        {
            _Refresh();
            _DataView = clsAppointment.ListAppointments().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshAppointmentsList();
        }

        private void _RefreshAppointmentsList()
        {
            dgvAppointmentsList.DataSource = clsAppointment.ListAppointments();
            _DataView = clsAppointment.ListAppointments().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            cbAppointmentStatus.Visible = false;
            tbSearchValue.Enabled = true;

            switch (cbSearchByOptions.SelectedItem)
            {
                case "AppointmentID":
                    return enSearchByOptions.AppointmentID;

                case "AppointmentStatus":
                    cbAppointmentStatus.Visible = true;
                    tbSearchValue.Enabled = false;
                    return enSearchByOptions.AppointmentStatus;

                case "PatientID":
                    return enSearchByOptions.PatientID;

                case "DoctorID":
                    return enSearchByOptions.DoctorID;

                default:
                    return enSearchByOptions.AppointmentID;
            }
        }

        private void _SearchAppointment()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.AppointmentID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "AppointmentID = " + _SearchValue;
                    break;

                case enSearchByOptions.AppointmentStatus:
                    _SearchAppointmentByStatus();
                    break;

                case enSearchByOptions.PatientID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "PatientID = " + _SearchValue;
                    break;

                case enSearchByOptions.DoctorID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "DoctorID = " + _SearchValue;
                    break;
            }

            dgvAppointmentsList.DataSource = _DataView;
        }

        private void _SearchAppointmentByStatus()
        {
            _DataView.RowFilter = "AppointmentStatus LIKE '%" + cbAppointmentStatus.SelectedItem + "%'";
        }

        private void dgvAppointmentsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 250;
            }
        }

        private void dgvAppointmentsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvAppointmentsList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
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
                _SearchAppointment();
            }
            else
            {
                _RefreshAppointmentsList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentsList.SelectedRows.Count > 0)
            {
                Form frm = new frmAddEditAppointmentInfo(Convert.ToInt16(dgvAppointmentsList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentsList.SelectedRows.Count > 0)
            {
                Form frm = new frmShowAppointmentInfo(Convert.ToInt16(dgvAppointmentsList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
            }
        }

        private void cbAppointmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchAppointment();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditAppointmentInfo();
            frm.ShowDialog();
            _Refresh();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAppointmentsList.SelectedRows.Count > 0)
            {
                bool isPaid = clsAppointment.IsAppointmentFeesPaid(Convert.ToInt16(dgvAppointmentsList.SelectedRows[0].Cells[0].Value));

                if (isPaid)
                    payToolStripMenuItem.Visible = false;
                else
                    payToolStripMenuItem.Visible = true;

            }
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentsList.SelectedRows.Count > 0)
            {
                int PatientID = Convert.ToInt16(dgvAppointmentsList.SelectedRows[0].Cells[1].Value);

                Form frm = new frmAddEditPaymentInfo(PatientID);
                frm.ShowDialog();
                _Refresh();
            }
        }
    }
}
