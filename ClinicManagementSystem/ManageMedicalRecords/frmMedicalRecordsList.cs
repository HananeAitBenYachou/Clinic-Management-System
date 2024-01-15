using ClinicBusinessLayer;
using ClinicManagementSystem.ManageSpecialities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.ManageMedicalRecords
{
    public partial class frmMedicalRecordsList : Form
    {
        private enum enSearchByOptions { MedicalRecordID, Diagnosis };

        private enSearchByOptions _SearchByOption;

        private string _SearchValue;

        private DataView _DataView;

        public frmMedicalRecordsList()
        {
            InitializeComponent();
        }

        private void frmMedicalRecordsList_Load(object sender, EventArgs e)
        {
            _Refresh();
            _DataView = clsMedicalRecord.ListMedicalRecords().DefaultView;
            cbSearchByOptions.SelectedIndex = 0;
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshMedicalRecordsList();
        }

        private void _RefreshMedicalRecordsList()
        {
            dgvMedicalRecordsList.DataSource = clsMedicalRecord.ListMedicalRecords();
            _DataView = clsMedicalRecord.ListMedicalRecords().DefaultView;
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "MedicalRecordID":
                    return enSearchByOptions.MedicalRecordID;

                case "Diagnosis":
                    return enSearchByOptions.Diagnosis;

                default:
                    return enSearchByOptions.MedicalRecordID;
            }
        }

        private void _SearchMedicalRecord()
        {
            switch (_SearchByOption)
            {
                case enSearchByOptions.MedicalRecordID:

                    if (!int.TryParse(_SearchValue, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    _DataView.RowFilter = "MedicalRecordID = " + _SearchValue;
                    break;

                case enSearchByOptions.Diagnosis:
                    _DataView.RowFilter = "Diagnosis LIKE '%" + _SearchValue + "%'";
                    break;
            }

            dgvMedicalRecordsList.DataSource = _DataView;
        }

        private void dgvMedicalRecordsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                dataGridViewColumn.Width = 250;
            }
        }

        private void dgvMedicalRecordsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(211, 217, 248)), e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }

            Color headerForeColor = Color.White;

            dgvMedicalRecordsList.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
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
                _SearchMedicalRecord();
            }
            else
            {
                _RefreshMedicalRecordsList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedIndex = 0;
            _Refresh();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvMedicalRecordsList.SelectedRows.Count > 0)
            {
                int PatientID = clsPatient.GetPatientIDByName((dgvMedicalRecordsList.SelectedRows[0].Cells[1].Value).ToString());

                Form frm = new frmAddEditMedicalRecordInfo(Convert.ToInt16(dgvMedicalRecordsList.SelectedRows[0].Cells[0].Value), PatientID);
                frm.ShowDialog();
                _Refresh();
            }
        }

        private void showDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvMedicalRecordsList.SelectedRows.Count > 0)
            {
                int PatientID = clsPatient.GetPatientIDByName((dgvMedicalRecordsList.SelectedRows[0].Cells[1].Value).ToString());

                Form frm = new frmShowMedicalRecordInfo(Convert.ToInt16(dgvMedicalRecordsList.SelectedRows[0].Cells[0].Value), PatientID);
                frm.ShowDialog();
            }
        }
    }
}
