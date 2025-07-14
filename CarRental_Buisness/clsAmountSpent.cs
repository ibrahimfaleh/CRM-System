using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsAmountSpent
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enPaymentDetails { Cash = 0,Transformation = 1 }
        public enPaymentDetails PaymentDetails { set; get; }
        private int _AmountSpentID;
        public int AmountSpentID { get { return _AmountSpentID; } }
        public int GeneralRevenueFundID { get; set; }
        public double Amount { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public int CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdateDate { set; get; } 
        public double FromVehicleBreakdownRevenues { set; get; }
        public double FromAnotherIncome { set; get; }
        public double FromExpectedProfit { set; get; }
        public double FromActualProfits { set; get; }
        public double FromVehicleSales { set; get; }
        public double? NotMoreThan { set; get; }
        public bool ObligatedToPayFullAmount { set; get; }
        protected clsAmountSpent(int AmountSpentID, int GeneralRevenueFundID, double Amount, string Details, byte PaymentDetails, DateTime Date, int CreatedByUserID, int? UpdatedByUserID, DateTime? updateDate, double FromVehicleBreakdownRevenues, double fromAnotherIncome, double fromExpectedProfit, double fromActualProfits, double fromVehicleSales, double? notMoreThan, bool obligatedToPayFullAmount)
        {

            _AmountSpentID = AmountSpentID;

            this.GeneralRevenueFundID = GeneralRevenueFundID;
            this.Amount = Amount;
            this.Details = Details;
            this.PaymentDetails = (enPaymentDetails)PaymentDetails;
            this.Date = Date;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            this.Mode = enMode.Update;
            this.UpdateDate = updateDate;
            this.FromVehicleBreakdownRevenues = FromVehicleBreakdownRevenues;
            this.FromAnotherIncome = fromAnotherIncome;
            FromExpectedProfit = fromExpectedProfit;
            FromActualProfits = fromActualProfits;
            FromVehicleSales = fromVehicleSales;
            NotMoreThan = notMoreThan;
            ObligatedToPayFullAmount = obligatedToPayFullAmount;
        }
        public clsAmountSpent()

        {
            this._AmountSpentID = -1;
            this.PaymentDetails = enPaymentDetails.Transformation;
            Mode = enMode.AddNew;
            this.GeneralRevenueFundID = GeneralRevenueFundID;
            this.Amount = Amount;
            this.Details = Details;
            this.Date = DateTime.Now;
            this.CreatedByUserID = -1;
            this.UpdatedByUserID = null;
            this.UpdateDate = null;
            this.FromVehicleBreakdownRevenues = 0 ;
            this.FromAnotherIncome = 0;
            this.FromExpectedProfit = 0 ;
            this.FromActualProfits = 0 ;
            this.FromVehicleSales = 0;
            this.NotMoreThan = null ;
            this.ObligatedToPayFullAmount = false;
        }
        private bool _AddNewAmountSpent()
        {
            this._AmountSpentID = clsAmountSpentData.AddNewAmountSpent(GeneralRevenueFundID, 
                Amount, Details, (byte)PaymentDetails, Date, CreatedByUserID, UpdatedByUserID,
                UpdateDate, FromVehicleBreakdownRevenues,FromAnotherIncome,FromExpectedProfit
                ,FromActualProfits, FromVehicleSales,NotMoreThan,ObligatedToPayFullAmount);
            return _AmountSpentID != -1;
        }
        private bool _UpdateAmountSpent()
        {
            return clsAmountSpentData.UpdateAmountSpent(this._AmountSpentID,
                GeneralRevenueFundID, Amount, Details, (byte)PaymentDetails,
                Date, CreatedByUserID, UpdatedByUserID,UpdateDate, 
                FromVehicleBreakdownRevenues, FromAnotherIncome,
                FromExpectedProfit,FromActualProfits, FromVehicleSales, NotMoreThan, ObligatedToPayFullAmount);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAmountSpent())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateAmountSpent())
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
        public static clsAmountSpent Find(int AmountSpentID)
        {


            int GeneralRevenueFundID = 0;
            double Amount = 0;
            string Details = "";
            byte PaymentDetails = 0;
            DateTime Date = DateTime.Now;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime? UpdateDate = null;
            double FromVehicleBreakdownRevenues=0;
            double FromAnotherIncome=0;
            double FromExpectedProfit = 0;
            double FromActualProfits = 0;
            double FromVehicleSales = 0;
            double? NotMoreThan = null;
            bool ObligatedToPayFullAmount = false;
            if (clsAmountSpentData.GetAmountSpentInfoByID(AmountSpentID, ref GeneralRevenueFundID, ref Amount, ref Details, ref PaymentDetails, ref Date, ref CreatedByUserID, ref UpdatedByUserID,ref UpdateDate,ref FromVehicleBreakdownRevenues,ref FromAnotherIncome,ref FromExpectedProfit,ref FromActualProfits,ref FromVehicleSales, ref NotMoreThan,ref  ObligatedToPayFullAmount))

                return new clsAmountSpent(AmountSpentID, GeneralRevenueFundID, Amount, Details, PaymentDetails, Date, CreatedByUserID, UpdatedByUserID, UpdateDate, FromVehicleBreakdownRevenues, FromAnotherIncome, FromExpectedProfit, FromActualProfits, FromVehicleSales, NotMoreThan, ObligatedToPayFullAmount);
            else
                return null;
        }
        public static bool isAmountSpentExist(int AmountSpentID)
        {
            return clsAmountSpentData.IsAmountSpentExist(AmountSpentID);
        }
        public static DataTable GetAllAmountsSpent()
        {
            return clsAmountSpentData.GetAllAmountsSpent();
        }
    }
}
