using ClinicBusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmAddEditPaymentInfo : Form
    {
        public delegate void PaymentDataBackEventHandler(object sender, int PaymentID);

        public event PaymentDataBackEventHandler PaymentDataBack;
        private enum _enMode { AddNew, Update };

        private _enMode _Mode;

        private clsPayment _Payment;

        private int _PaymentID = -1;

        private int _PatientID = -1;

        public frmAddEditPaymentInfo(int PaymentID, int PatientID)
        {
            InitializeComponent();
            _PaymentID = PaymentID;
            _PatientID = PatientID;
            lbTitle.Text = "Update Payment";
            _Mode = _enMode.Update;
        }

        public frmAddEditPaymentInfo(int PatientID)
        {
            InitializeComponent();
            _PatientID = PatientID;
            _Mode = _enMode.AddNew;
        }

        private void frmAddEditPaymentInfo_Load(object sender, EventArgs e)
        {
            lbPatientID.Text = _PatientID.ToString();

            if (_Mode == _enMode.AddNew)
            {
                _Payment = new clsPayment();
                return;
            }

            else
                _LoadPaymentData();
        }

        private void _LoadPaymentData()
        {
            _Payment = clsPayment.Find(_PaymentID);

            if (_Payment == null)
            {
                MessageBox.Show($"No Payment with PaymentID {_PaymentID} is found in the system !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbPaymentID.Text = _Payment.PaymentID.ToString();
            lbPatientID.Text = _PatientID.ToString();
            dtpPaymentDate.Value = _Payment.PaymentDate;
            cbPaymentMethod.SelectedItem = _Payment.PaymentMethod.ToString();
            tbAmountPaid.Text = _Payment.AmountPaid.ToString();
            tbAdditionalNotes.Text = _Payment.AdditionalNotes.ToString();
        }

        private bool _SavePaymentData()
        {
            _Payment.AmountPaid = Convert.ToDouble(tbAmountPaid.Text.ToString());
            _Payment.PaymentMethod = cbPaymentMethod.SelectedItem.ToString();
            _Payment.PaymentDate = dtpPaymentDate.Value;
            _Payment.AdditionalNotes = tbAdditionalNotes.Text.ToString();

            if (_Payment.Save())
            {
                MessageBox.Show($"Payment Data is saved successfully !");
                _PaymentID = _Payment.PaymentID;
                return true;
            }

            else
            {
                MessageBox.Show($"Payment Data was not saved successfully !");
                return false;
            }
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SavePaymentData())
                {
                    _Mode = _enMode.Update;
                    lbPaymentID.Text = _PaymentID.ToString();
                    lbTitle.Text = "Update Payment";

                    PaymentDataBack?.Invoke(this, _PaymentID);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {        
            this.Close();
        }
    }
}
