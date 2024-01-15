using ClinicBusinessLayer;
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
    public partial class frmShowPaymentInfo : Form
    {
        private clsPayment _Payment;

        private int _PaymentID = -1;

        private int _PatientID = -1;

        public frmShowPaymentInfo(int PaymentID, int PatientID)
        {
            InitializeComponent();
            _PaymentID = PaymentID;
            _PatientID = PatientID;
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

        private void frmShowPaymentInfo_Load(object sender, EventArgs e)
        {
            _LoadPaymentData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
