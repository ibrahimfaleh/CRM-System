using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsDriveType
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _DriveTypeID;
        public int DriveTypeID() { return _DriveTypeID; }
        public string DriveTypeName { get; set; }
        private clsDriveType(int DriveTypeID, string DriveTypeName)
        {

            _DriveTypeID = DriveTypeID;

            this.DriveTypeName = DriveTypeName;
            Mode = enMode.Update;
        }
        public clsDriveType()

        {
            this._DriveTypeID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewDriveType()
        {
            this._DriveTypeID = clsDriveTypeData.AddNewDriveType(DriveTypeName);
            return _DriveTypeID != 0;
        }
        private bool _UpdateDriveType()
        {
            return clsDriveTypeData.UpdateDriveType(this._DriveTypeID, DriveTypeName);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriveType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateDriveType())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }
        public static clsDriveType Find(string DriveTypeName)
        {


            int DriveTypeID = -1;


            if (clsDriveTypeData.GetDriveTypeInfoByDriveTypeName(ref DriveTypeID, DriveTypeName))

                return new clsDriveType(DriveTypeID, DriveTypeName);
            else
                return null;
        }
        public static clsDriveType Find(int DriveTypeID)
        {


            string DriveTypeName = "";


            if (clsDriveTypeData.GetDriveTypeInfoByID(DriveTypeID, ref DriveTypeName))

                return new clsDriveType(DriveTypeID, DriveTypeName);
            else
                return null;
        }
        public static bool isDriveTypeExist(int DriveTypeID)
        {
            return clsDriveTypeData.IsDriveTypeExist(DriveTypeID);
        }
        public static DataTable GetAllDriveTypes()
        {
            return clsDriveTypeData.GetAllDriveTypes();
        }
    }
}
