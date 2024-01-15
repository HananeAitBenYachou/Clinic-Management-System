using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsPrescription
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int PrescriptionID { get; private set; }
        public int MedicalRecordID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }

        public clsPrescription()
        {
            _Mode = enMode.AddNew;
            PrescriptionID = -1;
            MedicalRecordID = -1;
            MedicationName = "";
            Dosage = "";
            Frequency = "";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            SpecialInstructions = "";
        }

        private clsPrescription(int PrescriptionID, int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            _Mode = enMode.Update;
            this.PrescriptionID = PrescriptionID;
            this.MedicalRecordID = MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
        }

        public static clsPrescription Find(int PrescriptionID)
        {
            int MedicalRecordID = -1;
            string MedicationName = "";
            string Dosage = "";
            string Frequency = "";
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            string SpecialInstructions = "";

            bool isFound = clsPrescriptionData.GetPrescriptionInfoByID(PrescriptionID, ref MedicalRecordID, ref MedicationName, ref Dosage, ref Frequency, ref StartDate, ref EndDate, ref SpecialInstructions);

            if (isFound)
                return new clsPrescription(PrescriptionID, MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
            else
                return null;
        }

        public static bool IsPrescriptionExist(int PrescriptionID)
        {
            return clsPrescriptionData.IsPrescriptionExist(PrescriptionID);
        }

        private bool _AddNewPrescription()
        {
            PrescriptionID = clsPrescriptionData.AddNewPrescription(MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
            return PrescriptionID != -1;
        }

        private bool _UpdatePrescription()
        {
            return clsPrescriptionData.UpdatePrescriptionInfo(PrescriptionID, MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPrescription())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePrescription();

            }
            return false;
        }

        public static bool DeletePrescription(int PrescriptionID)
        {
            return clsPrescriptionData.DeletePrescription(PrescriptionID);
        }

        public static DataTable ListPrescriptions()
        {
            return clsPrescriptionData.GetAllPrescriptions();
        }

        public static short CountPrescriptions()
        {
            return clsPrescriptionData.GetNumberOfPrescriptions();
        }
    }
}
