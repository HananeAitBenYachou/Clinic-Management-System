using ClinicBusinessLayer;
using ClinicManagementSystem.ManageMedicalRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.ManagePayments
{
    public partial class frmPaymentsList : Form
    {
        private enum enSearchByOptions { PaymentID , PaymentMethod , AmountPaid };

        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;
        public frmPaymentsList()
        {
            InitializeComponent();
        }

        private void frmPaymentsList_Load(object sender, EventArgs e)
        {
            _Refresh();
            _DataView = clsPayment.ListPayments().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshPaymentsList();
        }

        private void _RefreshPaymentsList()
        {
            dgvPaymentsList.DataSource = clsPayment.ListPayments();
            _DataView = clsPayment.ListPayments().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "PaymentID":
                    return enSearchByOptions.PaymentID;

                case "PaymentMethod":
                    return enSearchByOptions.PaymentMethod;

                case "AmountPaid":
                    return enSearchByOptions.AmountPaid;

                default:
                    return enSearchByOptions.PaymentID;
            }
        }

        private void _SearchPayment()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.PaymentID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "MedicalRecordID = " + _SearchValue;
                    break;

                case enSearchByOptions.PaymentMethod:
                    _DataView.RowFilter = "Diagnosis LIKE '%" + _SearchValue + "%'";
                    break;

                case enSearchByOptions.AmountPaid:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "AmountPaid = " + _SearchValue;
                    break;
            }

            dgvPaymentsList.DataSource = _DataView;
        }

        private void dgvPaymentsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 250;
            }
        }

        private void dgvPaymentsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvPaymentsList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
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
                _SearchPayment();
            }
            else
            {
                _RefreshPaymentsList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvPaymentsList.SelectedRows.Count > 0)
            {
                int PatientID = Convert.ToInt16(dgvPaymentsList.SelectedRows[0].Cells[1].Value);
                Form frm = new frmAddEditPaymentInfo(Convert.ToInt16(dgvPaymentsList.SelectedRows[0].Cells[0].Value), PatientID);
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvPaymentsList.SelectedRows.Count > 0)
            {
                int PatientID = Convert.ToInt16(dgvPaymentsList.SelectedRows[0].Cells[1].Value);
                Form frm = new frmShowPaymentInfo(Convert.ToInt16(dgvPaymentsList.SelectedRows[0].Cells[0].Value), PatientID);
                frm.ShowDialog();
            }
        }
    }
}
