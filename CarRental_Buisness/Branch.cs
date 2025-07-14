using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsBranch
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _BranchID;
        public int BranchID { get { return _BranchID; } }
        public string StreetName { get; set; }
        public string BranchLocation { get; set; }
        public int CityID { get; set; }
        public clsCity City { get; private set; }
        public Byte CountDailyIncomeFundPerDay { get; set; }

        public clsAmountSpent AmountSpentInfo { get;private set; }
        public Boolean IsPublic { get; set; }
        public byte CountHoursDailyIncomeFund { get { return (byte)(24 / CountDailyIncomeFundPerDay); } }
        public int? AmountSpentID { set;get; }   
        private clsBranch(int BranchID, string StreetName, string BranchLocation, int CityID , Byte CountDailyIncomeFundPerDay, Boolean IsPublic, int? amountSpentID)
        {

            _BranchID = BranchID;

            this.StreetName = StreetName;
            this.BranchLocation = BranchLocation;
            this.CityID = CityID;
            this.City = clsCity.Find(CityID);
            this.CountDailyIncomeFundPerDay = CountDailyIncomeFundPerDay;
            if (amountSpentID.HasValue)
                this.AmountSpentInfo = clsAmountSpent.Find(amountSpentID.Value);
            else
                this.AmountSpentInfo =new clsAmountSpent();
            this.IsPublic = IsPublic;
            Mode = enMode.Update;
            AmountSpentID = amountSpentID;
        }
        public clsBranch()

        {
            this._BranchID = -1;
            AmountSpentID =null;
            Mode = enMode.AddNew;

        }
        private bool _AddNewBranch()
        {
            this._BranchID = clsBranchData.AddNewBranch(StreetName, BranchLocation, CityID, CountDailyIncomeFundPerDay, IsPublic,AmountSpentID);
            return _BranchID != 0;
        }
        private bool _UpdateBranch()
        {
            return clsBranchData.UpdateBranch(this._BranchID, StreetName, BranchLocation, CityID, CountDailyIncomeFundPerDay, IsPublic, AmountSpentID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBranch())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateBranch())
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
        public static clsBranch Find(int BranchID)
        {


            string StreetName = "";
            string BranchLocation = "";
            int CityID = 0;
            Byte CountDailyIncomeFundPerDay = 0;
            Boolean IsPublic = false;
            int? AmountSpentID=null;

            if (clsBranchData.GetBranchInfoByID(BranchID, ref StreetName, ref BranchLocation, ref CityID, ref CountDailyIncomeFundPerDay, ref IsPublic,ref AmountSpentID))

                return new clsBranch(BranchID, StreetName, BranchLocation, CityID, CountDailyIncomeFundPerDay, IsPublic, AmountSpentID);
            else
                return null;
        }

        public static clsBranch Find(string StreetName)
        {


            int BranchID = -1;
            string BranchLocation = "";
            int CityID = 0;
            Byte CountDailyIncomeFundPerDay = 0;
            Boolean IsPublic = false;
            int? AmountSpentID = null;

            if (clsBranchData.GetBranchInfoByStreetName(ref BranchID,  StreetName, ref BranchLocation, ref CityID, ref CountDailyIncomeFundPerDay, ref IsPublic,ref AmountSpentID))

                return new clsBranch(BranchID, StreetName, BranchLocation, CityID, CountDailyIncomeFundPerDay, IsPublic, AmountSpentID);
            else
                return null;
        }
        public static bool isBranchExist(int BranchID)
        {
            return clsBranchData.IsBranchExist(BranchID);
        }
        
        public static DataTable GetAllBranches()
        {
            return clsBranchData.GetAllBranches();
        }
        public static DataTable GetAllBranches(string CityName)
        {
            return clsBranchData.GetAllBranches( CityName);
        }
    }
}
