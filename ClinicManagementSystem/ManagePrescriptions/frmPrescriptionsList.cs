using ClinicBusinessLayer;
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

namespace ClinicManagementSystem.ManagePrescriptions
{
    public partial class frmPrescriptionsList : Form
    {
        private enum enSearchByOptions { PrescriptionID, MedicalRecordID, MedicationName };

        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;

        public frmPrescriptionsList()
        {
            InitializeComponent();
        }

        private void frmPrescriptionsList_Load(object sender, EventArgs e)
        {
            _Refresh();
            _DataView = clsPrescription.ListPrescriptions().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshPrescriptionsList();
        }

        private void _RefreshPrescriptionsList()
        {
            dgvPrescriptionsList.DataSource = clsPrescription.ListPrescriptions();
            _DataView = clsPrescription.ListPrescriptions().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "PrescriptionID":
                    return enSearchByOptions.PrescriptionID;

                case "MedicalRecordID":
                    return enSearchByOptions.MedicalRecordID;

                case "MedicationName":
                    return enSearchByOptions.MedicationName;

                default:
                    return enSearchByOptions.PrescriptionID;
            }
        }

        private void _SearchPrescription()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.PrescriptionID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "PrescriptionID = " + _SearchValue;
                    break;

                case enSearchByOptions.MedicalRecordID:
                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "MedicalRecordID = " + _SearchValue;
                    break;

                case enSearchByOptions.MedicationName:
                    _DataView.RowFilter = "MedicationName LIKE '%" + _SearchValue + "%'";
                    break;
            }

            dgvPrescriptionsList.DataSource = _DataView;
        }

        private void dgvPrescriptionsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 250;
            }
        }

        private void dgvPrescriptionsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvPrescriptionsList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
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
                _SearchPrescription();
            }
            else
            {
                _RefreshPrescriptionsList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptionsList.SelectedRows.Count > 0)
            {
                int MedicalRecordID = clsPatient.GetPatientIDByName((dgvPrescriptionsList.SelectedRows[0].Cells[1].Value).ToString());

                Form frm = new frmAddEditPrescriptionInfo(Convert.ToInt16(dgvPrescriptionsList.SelectedRows[0].Cells[0].Value), MedicalRecordID);
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptionsList.SelectedRows.Count > 0)
            {
                Form frm = new frmShowPrescriptionInfo(Convert.ToInt16(dgvPrescriptionsList.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
            }
        }
    }
}
