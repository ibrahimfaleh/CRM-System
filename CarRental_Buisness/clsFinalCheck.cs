using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsFinalCheck
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _FinalCheckID;
        public int FinalCheckID() { return _FinalCheckID; }
        public int BookingID { get; set; }
        private clsFinalCheck(int FinalCheckID, int BookingID)
        {

            _FinalCheckID = FinalCheckID;

            this.BookingID = BookingID;
            Mode = enMode.Update;
        }
        public clsFinalCheck()

        {
            this._FinalCheckID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewFinalCheck()
        {
            this._FinalCheckID = clsFinalCheckData.AddNewFinalCheck(BookingID);
            return _FinalCheckID != 0;
        }
        private bool _UpdateFinalCheck()
        {
            return clsFinalCheckData.UpdateFinalCheck(this._FinalCheckID, BookingID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFinalCheck())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateFinalCheck())
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
        public static clsFinalCheck Find(int FinalCheckID)
        {


            int BookingID = 0;


            if (clsFinalCheckData.GetFinalCheckInfoByID(FinalCheckID, ref BookingID))

                return new clsFinalCheck(FinalCheckID, BookingID);
            else
                return null;
        }
        public static bool isFinalCheckExist(int FinalCheckID)
        {
            return clsFinalCheckData.IsFinalCheckExist(FinalCheckID);
        }
        public static DataTable GetAllFinalChecks()
        {
            return clsFinalCheckData.GetAllFinalChecks();
        }
    }
}
