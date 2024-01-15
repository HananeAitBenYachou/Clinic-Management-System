using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsAppointment
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int AppointmentID { get; private set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public short AppointmentStatus { get; set; }
        public int? MedicalRecordID { get; set; }
        public int? PaymentID { get; set; }

        public clsAppointment()
        {
            _Mode = enMode.AddNew;
            AppointmentID = -1;
            PatientID = -1;
            DoctorID = -1;
            AppointmentDateTime = DateTime.Now;
            AppointmentStatus = 0;
            MedicalRecordID = null;
            PaymentID = null;
        }

        private clsAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, short AppointmentStatus, int? MedicalRecordID, int? PaymentID)
        {
            _Mode = enMode.Update;
            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.AppointmentDateTime = AppointmentDateTime;
            this.AppointmentStatus = AppointmentStatus;
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;
        }

        public static clsAppointment Find(int AppointmentID)
        {
            int PatientID = -1;
            int DoctorID = -1;
            DateTime AppointmentDateTime = DateTime.Now;
            short AppointmentStatus = 0;
            int? MedicalRecordID = null;
            int? PaymentID = null;

            bool isFound = clsAppointmentData.GetAppointmentInfoByID(AppointmentID, ref PatientID, ref DoctorID, ref AppointmentDateTime, ref AppointmentStatus, ref MedicalRecordID, ref PaymentID);

            if (isFound)
                return new clsAppointment(AppointmentID, PatientID, DoctorID, AppointmentDateTime, AppointmentStatus, MedicalRecordID, PaymentID);
            else
                return null;
        }

        public static bool IsAppointmentExist(int AppointmentID)
        {
            return clsAppointmentData.IsAppointmentExist(AppointmentID);
        }

        public static bool IsAppointmentDateFree(int DoctorID,DateTime AppointmentDateTime)
        {
            return clsAppointmentData.IsAppointmentDateFree(DoctorID, AppointmentDateTime);
        }

        public static bool IsAppointmentFeesPaid(int AppointmentID)
        {
            return clsAppointmentData.IsAppointmentFeesPaid(AppointmentID);
        }

        private bool _AddNewAppointment()
        {
            AppointmentID = clsAppointmentData.AddNewAppointment(PatientID, DoctorID, AppointmentDateTime, AppointmentStatus, MedicalRecordID, PaymentID);
            return AppointmentID != -1;
        }

        private bool _UpdateAppointment()
        {
            return clsAppointmentData.UpdateAppointmentInfo(AppointmentID, PatientID, DoctorID, AppointmentDateTime, AppointmentStatus, MedicalRecordID, PaymentID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateAppointment();

            }
            return false;
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            return clsAppointmentData.DeleteAppointment(AppointmentID);
        }

        public static DataTable ListAppointments()
        {
            return clsAppointmentData.GetAllAppointments();
        }

        public static short CountAppointments()
        {
            return clsAppointmentData.GetNumberOfAppointments();
        }
    }

}
