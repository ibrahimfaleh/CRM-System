using CarRental_DataAccess;
using System.Data;

namespace CarRental_Business
{
    public class clsDailyFundBill
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _TransactionID;
        public int TransactionID { get { return _TransactionID; } }
        public int BillID { get; set; }
        public int DailyIncomeFundID { get; set; }
        public int PaidByUserID { get; set; }
        public double FromExpectedProfit { get; set; }
        public double FromVehicleBreakdownRevenues { get; set; }
        public double ActualProfits { get; set; }
        private clsDailyFundBill(int TransactionID, int BillID, int DailyIncomeFundID, int PaidByUserID, double FromExpectedProfit, double FromVehicleBreakdownRevenues, double ActualProfits)
        {

            _TransactionID = TransactionID;

            this.BillID = BillID;
            this.DailyIncomeFundID = DailyIncomeFundID;
            this.PaidByUserID = PaidByUserID;
            this.FromExpectedProfit = FromExpectedProfit;
            this.FromVehicleBreakdownRevenues = FromVehicleBreakdownRevenues;
            this.ActualProfits = ActualProfits;
            Mode = enMode.Update;
        }
        public clsDailyFundBill()

        {
            this.BillID = BillID;
            this.DailyIncomeFundID = -1;
            this.PaidByUserID = -1;
            this.FromExpectedProfit = 0;
            this.FromVehicleBreakdownRevenues = 0;
            this.ActualProfits = 0;
            this._TransactionID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewDailyFundBill()
        {
            this._TransactionID = clsDailyFundBillData.AddNewDailyFundBill(BillID, DailyIncomeFundID, PaidByUserID, FromExpectedProfit, FromVehicleBreakdownRevenues, ActualProfits);
            return _TransactionID != 0;
        }
        private bool _UpdateDailyFundBill()
        {
            return clsDailyFundBillData.UpdateDailyFundBill(this._TransactionID, BillID, DailyIncomeFundID, PaidByUserID, FromExpectedProfit, FromVehicleBreakdownRevenues, ActualProfits);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDailyFundBill())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateDailyFundBill())
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
        public static clsDailyFundBill Find(int TransactionID)
        {


            int BillID = 0;
            int DailyIncomeFundID = 0;
            int PaidByUserID = 0;
            double FromExpectedProfit = 0;
            double FromVehicleBreakdownRevenues =0;
            double ActualProfits = 0;


            if (clsDailyFundBillData.GetDailyFundBillInfoByID(TransactionID, ref BillID, ref DailyIncomeFundID, ref PaidByUserID, ref FromExpectedProfit, ref FromVehicleBreakdownRevenues, ref ActualProfits))

                return new clsDailyFundBill(TransactionID, BillID, DailyIncomeFundID, PaidByUserID, FromExpectedProfit, FromVehicleBreakdownRevenues, ActualProfits);
            else
                return null;
        }
        public static bool isDailyFundBillExist(int TransactionID)
        {
            return clsDailyFundBillData.IsDailyFundBillExist(TransactionID);
        }
        public static DataTable GetAllDailyFundBills(int DailyFund)
        {
            return clsDailyFundBillData.GetAllDailyFundBills(DailyFund);
        }
    }
}
