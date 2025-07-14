using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsBodie
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _BodyID;
        public int BodyID() { return _BodyID; }
        public string BodyName { get; set; }
        private clsBodie(int BodyID, string BodyName)
        {

            _BodyID = BodyID;

            this.BodyName = BodyName;
            Mode = enMode.Update;
        }
        public clsBodie()

        {
            this._BodyID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewBodie()
        {
            this._BodyID = clsBodieData.AddNewBodie(BodyName);
            return _BodyID != 0;
        }
        private bool _UpdateBodie()
        {
            return clsBodieData.UpdateBodie(this._BodyID, BodyName);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBodie())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateBodie())
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
        public static clsBodie Find(int BodyID)
        {


            string BodyName = "";


            if (clsBodieData.GetBodieInfoByID(BodyID, ref BodyName))

                return new clsBodie(BodyID, BodyName);
            else
                return null;
        }
        public static clsBodie Find(string BodyName)
        {


            int BodyID =0;


            if (clsBodieData.GetBodieInfoByBodyName(ref BodyID, BodyName))

                return new clsBodie(BodyID, BodyName);
            else
                return null;
        }
        public static bool isBodieExist(int BodyID)
        {
            return clsBodieData.IsBodieExist(BodyID);
        }
        public static DataTable GetAllBodies()
        {
            return clsBodieData.GetAllBodies();
        }
    }
}
