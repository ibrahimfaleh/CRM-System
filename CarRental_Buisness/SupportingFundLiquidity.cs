using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsSupportingFundLiquidity 
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _SupportingID;
        public int SupportingID { get { return _SupportingID; } }
        public int AmountSpentID { get; set; }
        public int DailyIncomeFundTransactionID { get; set; }
        public Boolean SupportStatus { get; set; }
        private clsSupportingFundLiquidity(int SupportingID, int AmountSpentID, int DailyIncomeFundTransactionID, Boolean SupportStatus) 
        {

            _SupportingID = SupportingID;
            this.AmountSpentID = AmountSpentID;
            this.DailyIncomeFundTransactionID = DailyIncomeFundTransactionID;
            this.SupportStatus = SupportStatus;
            Mode = enMode.Update;
        }
        public clsSupportingFundLiquidity()

        {
            this._SupportingID = -1;

        }
        private bool _AddNewSupportingFundLiquidity()
        {
            this._SupportingID = clsSupportingFundLiquidityData.AddNewSupportingFundLiquidity(AmountSpentID, DailyIncomeFundTransactionID, SupportStatus);
            return _SupportingID != 0;
        }
        private bool _UpdateSupportingFundLiquidity()
        {
            return clsSupportingFundLiquidityData.UpdateSupportingFundLiquidity(this._SupportingID, AmountSpentID, DailyIncomeFundTransactionID, SupportStatus);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSupportingFundLiquidity())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateSupportingFundLiquidity())
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
        public static clsSupportingFundLiquidity Find(int SupportingID)
        {

            int AmountSpentID = 0;
            int DailyIncomeFundTransactionID = 0;
            Boolean SupportStatus = false;


            if (clsSupportingFundLiquidityData.GetSupportingFundLiquidityInfoByID(SupportingID, ref AmountSpentID, ref DailyIncomeFundTransactionID, ref SupportStatus))
                return new clsSupportingFundLiquidity(SupportingID, AmountSpentID, DailyIncomeFundTransactionID,
                    SupportStatus);
            else
                return null;
        }
        public static bool isSupportingFundLiquidityExist(int SupportingID)
        {
            return clsSupportingFundLiquidityData.IsSupportingFundLiquidityExist(SupportingID);
        }
        public static bool isSupportingFundLiquidityExistByDailyIncomeFundTransactionID(int DailyIncomeFundTransactionID)
        {
            return clsSupportingFundLiquidityData.IsSupportingFundLiquidityExistByDailyIncomeFundTransactionID(DailyIncomeFundTransactionID);
        }
        public static DataTable GetAllSupportingFundsLiquidity()
        {
            return clsSupportingFundLiquidityData.GetAllSupportingFundsLiquidity();
        }
        public static DataTable GetAllSupportingFundsLiquidity(int DailyIncomeFundID)
        {
            return clsSupportingFundLiquidityData.GetAllSupportingFundsLiquidity(DailyIncomeFundID);
        }
    }
}
