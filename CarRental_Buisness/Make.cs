using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsMake
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _MakeID;
        public int MakeID() { return _MakeID; }
        public string Make { get; set; }
        private clsMake(int MakeID, string Make)
        {

            _MakeID = MakeID;

            this.Make = Make;
            Mode = enMode.Update;
        }
        public clsMake()

        {
            this._MakeID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewMake()
        {
            this._MakeID = clsMakeData.AddNewMake(Make);
            return _MakeID != 0;
        }
        private bool _UpdateMake()
        {
            return clsMakeData.UpdateMake(this._MakeID, Make);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMake())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateMake())
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
        public static clsMake Find(int MakeID)
        {


            string Make = "";


            if (clsMakeData.GetMakeInfoByID(MakeID, ref Make))

                return new clsMake(MakeID, Make);
            else
                return null;
        }
        public static clsMake Find(string MakeName)
        {


            int MakeID = -1;


            if (clsMakeData.GetMakeInfoByMakeName(ref MakeID,  MakeName))

                return new clsMake(MakeID, MakeName);
            else
                return null;
        }
        public static bool isMakeExist(int MakeID)
        {
            return clsMakeData.IsMakeExist(MakeID);
        }
        public static DataTable GetAllMakes()
        {
            return clsMakeData.GetAllMakes();
        }
    }
}
