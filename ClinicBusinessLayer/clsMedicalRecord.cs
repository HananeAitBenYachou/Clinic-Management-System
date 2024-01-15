
using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsMedicalRecord
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int MedicalRecordID { get; private set; }
        public string VisitDescription { get; set; }
        public string Diagnosis { get; set; }
        public string AdditionalNotes { get; set; }

        public clsMedicalRecord()
        {
            _Mode = enMode.AddNew;
            MedicalRecordID = -1;
            VisitDescription = "";
            Diagnosis = "";
            AdditionalNotes = "";
        }
        private clsMedicalRecord(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            _Mode = enMode.Update;
            this.MedicalRecordID = MedicalRecordID;
            this.VisitDescription = VisitDescription;
            this.Diagnosis = Diagnosis;
            this.AdditionalNotes = AdditionalNotes;
        }

        public static clsMedicalRecord Find(int MedicalRecordID)
        {
            string VisitDescription = "";
            string Diagnosis = "";
            string AdditionalNotes = "";

            bool isFound = clsMedicalRecordData.GetMedicalRecordInfoByID(MedicalRecordID, ref VisitDescription, ref Diagnosis, ref AdditionalNotes);

            if (isFound)
                return new clsMedicalRecord(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes);
            else
                return null;
        }

        public static bool IsMedicalRecordExist(int MedicalRecordID)
        {
            return clsMedicalRecordData.IsMedicalRecordExist(MedicalRecordID);
        }

        private bool _AddNewMedicalRecord()
        {
            MedicalRecordID = clsMedicalRecordData.AddNewMedicalRecord(VisitDescription, Diagnosis, AdditionalNotes);
            return MedicalRecordID != -1;
        }

        private bool _UpdateMedicalRecord()
        {
            return clsMedicalRecordData.UpdateMedicalRecordInfo(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMedicalRecord())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateMedicalRecord();

            }
            return false;
        }

        public static bool DeleteMedicalRecord(int MedicalRecordID)
        {
            return clsMedicalRecordData.DeleteMedicalRecord(MedicalRecordID);
        }

        public static DataTable ListMedicalRecords()
        {
            return clsMedicalRecordData.GetAllMedicalRecords();
        }

        public static short CountMedicalRecords()
        {
            return clsMedicalRecordData.GetNumberOfMedicalRecords();
        }
    }
}
