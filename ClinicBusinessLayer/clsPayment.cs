using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsPayment
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int PaymentID { get; private set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public double AmountPaid { get; set; }
        public string AdditionalNotes { get; set; }

        public clsPayment()
        {
            _Mode = enMode.AddNew;
            PaymentID = -1;
            PaymentDate = DateTime.Now;
            PaymentMethod = "";
            AmountPaid = 0;
            AdditionalNotes = "";
        }
        private clsPayment(int PaymentID, DateTime PaymentDate, string PaymentMethod, double AmountPaid, string AdditionalNotes)
        {
            _Mode = enMode.Update;
            this.PaymentID = PaymentID;
            this.PaymentDate = PaymentDate;
            this.PaymentMethod = PaymentMethod;
            this.AmountPaid = AmountPaid;
            this.AdditionalNotes = AdditionalNotes;
        }

        public static clsPayment Find(int PaymentID)
        {
            DateTime PaymentDate = DateTime.Now;
            string PaymentMethod = "";
            double AmountPaid = 0;
            string AdditionalNotes = "";

            bool isFound = clsPaymentData.GetPaymentInfoByID(PaymentID, ref PaymentDate, ref PaymentMethod, ref AmountPaid, ref AdditionalNotes);

            if (isFound)
                return new clsPayment(PaymentID, PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);
            else
                return null;
        }

        public static bool IsPaymentExist(int PaymentID)
        {
            return clsPaymentData.IsPaymentExist(PaymentID);
        }

        private bool _AddNewPayment()
        {
            PaymentID = clsPaymentData.AddNewPayment(PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);
            return PaymentID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePaymentInfo(PaymentID, PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePayment();

            }
            return false;
        }

        public static bool DeletePayment(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }

        public static DataTable ListPayments()
        {
            return clsPaymentData.GetAllPayments();
        }

        public static short CountPayments()
        {
            return clsPaymentData.GetNumberOfPayments();
        }
    }
}
