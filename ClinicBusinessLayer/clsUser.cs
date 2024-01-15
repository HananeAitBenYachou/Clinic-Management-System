using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsUser : clsPerson
    {
        public enum enUserPermissions { All = -1 , ManagePatients = 1, ManageDoctors = 2 , ManageSpecialities = 4 , ManageAppointments = 8 ,ManagePrescriptions = 16, ManagePayments = 32, ManageMedicalRecords = 64 , ManageUsers = 128};
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int UserID { get; private set; }
        public int PersonID { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public short Permissions { get; set; }
        public clsUser() : base()
        {
            _Mode = enMode.AddNew;
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            Permissions = 0;
        }
        private clsUser(int UserID, int PersonID, string UserName, string Password, short Permissions, string Name, char Gender, DateTime DateOfBirth,
            string Address, string PhoneNumber, string Email, string ImagePath) : base(PersonID, Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath)
        {
            _Mode = enMode.Update;
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;
        }

        public static new clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            short Permissions = 0;
            string Name = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            string ImagePath = "";

            bool isUserFound = clsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref Permissions);

            bool isPersonFound = clsPersonData.GetPersonInfoByID(PersonID, ref Name, ref Gender, ref DateOfBirth, ref Address, ref PhoneNumber, ref Email, ref ImagePath);

            if (isPersonFound && isUserFound)
                return new clsUser(UserID, PersonID, UserName, Password, Permissions,Name,Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath);
            else
                return null;
        }

        public static  clsUser Find(string UserName , string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            short Permissions = 0;
            string Name = "";
            char Gender = ' ';
            DateTime DateOfBirth = DateTime.Now;
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            string ImagePath = "";

            bool isUserFound = clsUserData.GetUserInfoByUserNameAndPassword(ref UserID, ref PersonID, UserName, Password, ref Permissions);

            bool isPersonFound = clsPersonData.GetPersonInfoByID(PersonID, ref Name, ref Gender, ref DateOfBirth, ref Address, ref PhoneNumber, ref Email, ref ImagePath);

            if (isPersonFound && isUserFound)
                return new clsUser(UserID, PersonID, UserName, Password, Permissions, Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath);
            else
                return null;
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }

        private bool _AddNewUser()
        {
            base.PersonID = clsPersonData.AddNewPerson(Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath);

            if (base.PersonID != -1)
            {
                this.PersonID = base.PersonID;
                UserID = clsUserData.AddNewUser(PersonID, UserName, Password, Permissions);
                return UserID != -1;
            }
            return false;
        }

        private bool _AddNewUser(int PersonID)
        {
            base.PersonID = PersonID;

            if (base.PersonID != -1)
            {
                this.PersonID = base.PersonID;
                UserID = clsUserData.AddNewUser(PersonID, UserName, Password, Permissions);
                return UserID != -1;
            }
            return false;
        }

        private bool _UpdateUser()
        {
            if (clsPersonData.UpdatePersonInfo(base.PersonID, Name, Gender, DateOfBirth, Address, PhoneNumber, Email, ImagePath))
            {
                return clsUserData.UpdateUserInfo(UserID, PersonID, UserName, Password, Permissions);
            }
            return false;
        }

        public new bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser() && base.Save())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return (_UpdateUser() && base.Save());

            }
            return false;
        }

        public bool Save(int PersonID)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser(PersonID))
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return (_UpdateUser());

            }
            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            int PersonID = clsUser.Find(UserID).PersonID;

            if (clsUserData.DeleteUser(UserID))
            {
                return clsPersonData.DeletePerson(PersonID);
            }

            return false;
        }

        public static DataTable ListUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static short CountUsers()
        {
            return clsUserData.GetNumberOfUsers();
        }

        public bool CheckUserAccessPermission(enUserPermissions Permissions)
        {
            if (this.Permissions == -1)
                return true;

            else if(((short)Permissions & this.Permissions) == (short)Permissions)        
                return true;
            
            return false;
        }
    }
}
