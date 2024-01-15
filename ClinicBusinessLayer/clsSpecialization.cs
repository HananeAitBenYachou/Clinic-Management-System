using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsSpecialization
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int SpecializationID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public clsSpecialization()
        {
            _Mode = enMode.AddNew;
            SpecializationID = -1;
            Name = "";
            Description = "";
        }

        private clsSpecialization(int SpecializationID, string Name, string Description)
        {
            _Mode = enMode.Update;
            this.SpecializationID = SpecializationID;
            this.Name = Name;
            this.Description = Description;
        }

        public static clsSpecialization Find(int SpecializationID)
        {
            string Name = "";
            string Description = "";

            bool isFound = clsSpecializationData.GetSpecializationInfoByID(SpecializationID, ref Name, ref Description);

            if (isFound)
                return new clsSpecialization(SpecializationID, Name, Description);
            else
                return null;
        }

        public static bool IsSpecializationExist(int SpecializationID)
        {
            return clsSpecializationData.IsSpecializationExist(SpecializationID);
        }

        public static bool IsSpecializationExist(string Name)
        {
            return clsSpecializationData.IsSpecializationExist(Name);
        }

        private bool _AddNewSpecialization()
        {
            SpecializationID = clsSpecializationData.AddNewSpecialization(Name, Description);
            return SpecializationID != -1;
        }

        private bool _UpdateSpecialization()
        {
            return clsSpecializationData.UpdateSpecializationInfo(SpecializationID, Name, Description);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSpecialization())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateSpecialization();

            }
            return false;
        }

        public static bool DeleteSpecialization(int SpecializationID)
        {
            return clsSpecializationData.DeleteSpecialization(SpecializationID);
        }

        public static DataTable ListSpecializations()
        {
            return clsSpecializationData.GetAllSpecializations();
        }

        public static short CountSpecializations()
        {
            return clsSpecializationData.GetNumberOfSpecializations();
        }
    }
}
