using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicBusinessLayer
{
    public class clsDoctor : clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int DoctorID { get; private set; }
        private int PersonID { get; set; }
        public int SpecializationID { get; set; }

        public clsDoctor() : base()
        {
            _Mode = enMode.AddNew;
            DoctorID = -1;
            PersonID = -1;
            SpecializationID = -1;
        }

        private clsDoctor(int DoctorID, int PersonID, int SpecializationID, string Name,char Gender, DateTime DateOfBirth, 
            string Address, string PhoneNumber, string Email, string ImagePath) : base(PersonID ,Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath)
        {
            _Mode = enMode.Update;
            this.DoctorID = DoctorID;
            this.PersonID = PersonID;
            this.SpecializationID = SpecializationID;
        }

        public static new clsDoctor Find(int DoctorID)
        {
            int PersonID = -1;
            int SpecializationID = -1;
            string Name = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            string ImagePath = "";

            bool isDoctorFound = clsDoctorData.GetDoctorInfoByID(DoctorID, ref PersonID, ref SpecializationID);

            bool isPersonFound = clsPersonData.GetPersonInfoByID(PersonID, ref Name, ref Gender, ref DateOfBirth, ref Address, ref PhoneNumber, ref Email, ref ImagePath);

            if (isPersonFound && isDoctorFound)
                return new clsDoctor(DoctorID, PersonID, SpecializationID, Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath);
            else
                return null;
        }

        public static bool IsDoctorExist(int DoctorID)
        {
            return clsDoctorData.IsDoctorExist(DoctorID);
        }

        public static bool IsDoctorExistByPersonID(int PersonID)
        {
            return clsDoctorData.IsDoctorExistByPersonID(PersonID);
        }

        private bool _AddNewDoctor()
        {
            base.PersonID = clsPersonData.AddNewPerson(Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath); 
            
            if(base.PersonID != -1)
            {
                this.PersonID = base.PersonID;
                DoctorID = clsDoctorData.AddNewDoctor(PersonID, SpecializationID);

                return DoctorID != -1;
            }
            return false;         
        }

        private bool _AddNewDoctor(int PersonID)
        {
            base.PersonID = PersonID;

            if (base.PersonID != -1)
            {
                this.PersonID = base.PersonID;
                DoctorID = clsDoctorData.AddNewDoctor(PersonID, SpecializationID);

                return DoctorID != -1;
            }
            return false;
        }

        private bool _UpdateDoctor()
        {
            if(clsPersonData.UpdatePersonInfo(base.PersonID , Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath))
            {
                return clsDoctorData.UpdateDoctorInfo(DoctorID, PersonID, SpecializationID);
            }
            return false;
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor() && base.Save())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return (_UpdateDoctor() && base.Save());

            }
            return false;
        }

        public bool Save(int PersonID)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor(PersonID))
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return (_UpdateDoctor());

            }
            return false;
        }

        public static bool DeleteDoctor(int DoctorID)
        {
            int PersonID = clsDoctor.Find(DoctorID).PersonID;

            if (clsDoctorData.DeleteDoctor(DoctorID))
            {
                return clsPersonData.DeletePerson(PersonID);
            }

            return false;
        }

        public static DataTable ListDoctors()
        {
            return clsDoctorData.GetAllDoctors();
        }

        public static short CountDoctors()
        {
            return clsDoctorData.GetNumberOfDoctors();
        }
    }
}
