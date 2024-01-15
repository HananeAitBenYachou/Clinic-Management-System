using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsPatient : clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int PatientID { get; private set; }
        private int PersonID { get; set; }

        public clsPatient() : base()
        {
            _Mode = enMode.AddNew;
            PatientID = -1;
            PersonID = -1;
        }
        private clsPatient(int PatientID, int PersonID, string Name, char Gender, DateTime DateOfBirth,
            string Address, string PhoneNumber, string Email, string ImagePath) : base(PersonID, Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath)
        {
            _Mode = enMode.Update;
            this.PatientID = PatientID;
            this.PersonID = PersonID;
        }

        public static new clsPatient Find(int PatientID)
        {
            int PersonID = -1;
            string Name = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            string ImagePath = "";

            bool isPatientFound = clsPatientData.GetPatientInfoByID(PatientID, ref PersonID);

            bool isPersonFound = clsPersonData.GetPersonInfoByID(PersonID, ref Name, ref Gender, ref DateOfBirth, ref Address, ref PhoneNumber, ref Email, ref ImagePath);

            if (isPersonFound && isPatientFound)
                return new clsPatient(PatientID, PersonID, Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath);
            else
                return null;
        }

        public static int GetPatientIDByName(string Name)
        {
            return clsPatientData.GetPatientIDByName(Name);
        }

        public static bool IsPatientExist(int PatientID)
        {
            return clsPatientData.IsPatientExist(PatientID);
        }

        public static bool IsPatientExistByPersonID(int PersonID)
        {
            return clsPatientData.IsPatientExistByPersonID(PersonID);
        }

        private bool _AddNewPatient()
        {
            base.PersonID = clsPersonData.AddNewPerson(Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath);

            if (base.PersonID != -1)
            {
                this.PersonID = base.PersonID;
                PatientID = clsPatientData.AddNewPatient(PersonID);

                return PatientID != -1;
            }
            return false;
        }

        private bool _AddNewPatient(int PersonID)
        {
            base.PersonID = PersonID;

            if (base.PersonID != -1)
            {
                this.PersonID = base.PersonID;
                PatientID = clsPatientData.AddNewPatient(PersonID);

                return PatientID != -1;
            }
            return false;
        }

        private bool _UpdatePatient()
        {
            if (clsPersonData.UpdatePersonInfo(base.PersonID, Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath))
            {
                return clsPatientData.UpdatePatientInfo(PatientID, PersonID);
            }
            return false;       
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient() && base.Save())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return (_UpdatePatient() && base.Save());

            }
            return false;
        }

        public bool Save(int PersonID)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient(PersonID))
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePatient();

            }
            return false;
        }

        public static bool DeletePatient(int PatientID)
        {
            int PersonID = clsPatient.Find(PatientID).PersonID;

            if (clsPatientData.DeletePatient(PatientID))
            {
                return clsPersonData.DeletePerson(PersonID);
            }

            return false;
        }

        public static DataTable ListPatients()
        {
            return clsPatientData.GetAllPatients();
        }

        public static short CountPatients()
        {
            return clsPatientData.GetNumberOfPatients();
        }

    }
}
