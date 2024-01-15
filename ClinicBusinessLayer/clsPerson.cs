using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicDataAccessLayer;

namespace ClinicBusinessLayer
{
    public class clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        public int PersonID { get; protected set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            PersonID = -1;
            Name = "";
            Gender = ' ';
            DateOfBirth = DateTime.Now;
            Address = "";
            PhoneNumber = "";
            Email = "";
            ImagePath = "";
            _Mode = enMode.AddNew;
        }
        protected clsPerson(int personID, string name, char gender, DateTime dateOfBirth, string address, string phoneNumber, string email, string imagePath)
        {
            PersonID = personID;
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            ImagePath = imagePath;
            _Mode = enMode.Update;
        }

        public static clsPerson Find(int PersonID)
        {
            string Name = "", Address = "", PhoneNumber = "", Email = "", ImagePath = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;

            bool isFound = clsPersonData.GetPersonInfoByID(PersonID, ref Name, ref Gender, ref DateOfBirth,
                ref Address, ref PhoneNumber, ref Email, ref ImagePath);

            if (isFound)
                return new clsPerson(PersonID, Name, Gender, DateOfBirth,
                 Address, PhoneNumber, Email, ImagePath);

            else
                return null;
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(Name, Gender, DateOfBirth,
                 Address, PhoneNumber, Email, ImagePath);

            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePersonInfo(PersonID, Name, Gender, DateOfBirth,
                 Address, PhoneNumber, Email, ImagePath);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePerson();

            }
            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

    }

}
