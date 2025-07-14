using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsFuleType
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _ID;
        public int ID() { return _ID; }
        public string FuleType { get; set; }
        private clsFuleType(int ID, string FuleType)
        {

            _ID = ID;

            this.FuleType = FuleType;
            Mode = enMode.Update;
        }
        public clsFuleType()

        {
            this._ID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewFuleType()
        {
            this._ID = clsFuleTypeData.AddNewFuleType(FuleType);
            return _ID != 0;
        }
        private bool _UpdateFuleType()
        {
            return clsFuleTypeData.UpdateFuleType(this._ID, FuleType);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFuleType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateFuleType())
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
        public static clsFuleType Find(int ID)
        {


            string FuleType = "";


            if (clsFuleTypeData.GetFuleTypeInfoByID(ID, ref FuleType))

                return new clsFuleType(ID, FuleType);
            else
                return null;
        }
        public static clsFuleType Find(string FuleTypeName)
        {


            int FuleTypeID = -1;


            if (clsFuleTypeData.GetFuleTypeInfoByFulTypeName(ref FuleTypeID, FuleTypeName))

                return new clsFuleType(FuleTypeID, FuleTypeName);
            else
                return null;
        }
        public static bool isFuleTypeExist(int ID)
        {
            return clsFuleTypeData.IsFuleTypeExist(ID);
        }
        public static DataTable GetAllFuleTypes()
        {
            return clsFuleTypeData.GetAllFuleTypes();
        }
    }
}
