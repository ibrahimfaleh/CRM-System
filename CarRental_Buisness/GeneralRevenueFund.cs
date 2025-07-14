using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsGeneralRevenueFund
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _GeneralRevenueFundID;
        public int GeneralRevenueFundID { get { return _GeneralRevenueFundID; } }
        public double ActualProfits { get; set; }
        public double VehicleBreakdownRevenues { get; set; }
        public double AnotherIncome { get; set; }
        public double Cash { get; set; }
        public double Bank { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public Boolean IsClosed { get; set; }
        public int CreatedByUserID { get; set; }
        public int? ClosedByUserID { get; set; }
        public double TotalAmount { get { return this.Bank + this.Cash; } }
        public double ExpectedProfit { get; set; }  
        public double VehicleSales { get; set; }    
        private clsGeneralRevenueFund(int GeneralRevenueFundID, double ActualProfits, double VehicleBreakdownRevenues, double AnotherIncome, double Cash, double Bank, DateTime CreatedDate, DateTime? ClosedDate, Boolean IsClosed, int CreatedByUserID, int? ClosedByUserID, double expectedProfit, double vehicleSales)
        {

            _GeneralRevenueFundID = GeneralRevenueFundID;

            this.ActualProfits = ActualProfits;
            this.VehicleBreakdownRevenues = VehicleBreakdownRevenues;
            this.AnotherIncome = AnotherIncome;
            this.Cash = Cash;
            this.Bank = Bank;
            this.CreatedDate = CreatedDate;
            this.ClosedDate = ClosedDate;
            this.IsClosed = IsClosed;
            this.CreatedByUserID = CreatedByUserID;
            this.ClosedByUserID = ClosedByUserID;
            Mode = enMode.Update;
            this.ExpectedProfit = expectedProfit;
            VehicleSales = vehicleSales;
        }
        public clsGeneralRevenueFund()

        {
            _GeneralRevenueFundID = -1;

            this.ActualProfits = 0;
            this.VehicleBreakdownRevenues = 0;
            this.AnotherIncome = 0;
            this.Cash = 0;
            this.Bank = 0;
            this.CreatedDate = DateTime.Now;
            this.ClosedDate = null;
            this.IsClosed = false;
            this.CreatedByUserID = 0;
            this.ClosedByUserID = null;
            this.ExpectedProfit = 0;
            this.VehicleSales = 0;
            Mode = enMode.AddNew;

        }
        private bool _AddNewGeneralRevenueFund()
        {
            this._GeneralRevenueFundID = clsGeneralRevenueFundData.AddNewGeneralRevenueFund(ActualProfits, VehicleBreakdownRevenues, ExpectedProfit, AnotherIncome, Cash, Bank, CreatedDate, ClosedDate, IsClosed, CreatedByUserID, ClosedByUserID, VehicleSales);
            return _GeneralRevenueFundID != 0;
        }
        private bool _UpdateGeneralRevenueFund()
        {
            return clsGeneralRevenueFundData.UpdateGeneralRevenueFund(this._GeneralRevenueFundID, ActualProfits, VehicleBreakdownRevenues, ExpectedProfit, AnotherIncome, Cash, Bank, CreatedDate, ClosedDate, IsClosed, CreatedByUserID, ClosedByUserID, VehicleSales);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGeneralRevenueFund())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateGeneralRevenueFund())
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
        public static clsGeneralRevenueFund Find(int GeneralRevenueFundID)
        {


            double ActualProfits = 0;
            double VehicleBreakdownRevenues = 0;
            double AnotherIncome = 0;
            double Cash = 0;
            double Bank = 0;
            DateTime CreatedDate = DateTime.Now;
            DateTime? ClosedDate = null;
            Boolean IsClosed = false;
            int CreatedByUserID = 0;
            int? ClosedByUserID = null;
            double ExpectedProfit = 0;
            double VehicleSales = 0;

            if (clsGeneralRevenueFundData.GetGeneralRevenueFundInfoByID(GeneralRevenueFundID, ref ActualProfits, ref VehicleBreakdownRevenues,ref ExpectedProfit, ref AnotherIncome, ref Cash, ref Bank, ref CreatedDate, ref ClosedDate, ref IsClosed, ref CreatedByUserID, ref ClosedByUserID,ref VehicleSales))

                return new clsGeneralRevenueFund(GeneralRevenueFundID, ActualProfits, VehicleBreakdownRevenues, AnotherIncome, Cash, Bank, CreatedDate, ClosedDate, IsClosed, CreatedByUserID, ClosedByUserID, ExpectedProfit, VehicleSales);
            else
                return null;
        }
        public static clsGeneralRevenueFund GetGeneralRevenueFund()
        {

            int GeneralRevenueFundID = -1;
            double ActualProfits = 0;
            double VehicleBreakdownRevenues = 0;
            double AnotherIncome = 0;
            double Cash = 0;
            double Bank = 0;
            DateTime CreatedDate = DateTime.Now;
            DateTime? ClosedDate = null;
            Boolean IsClosed = false;
            int CreatedByUserID = 0;
            int? ClosedByUserID = null;
            double ExpectedProfit = 0;
            double VehicleSales = 0;

            if (clsGeneralRevenueFundData.GetGeneralRevenueFund(ref GeneralRevenueFundID, ref ActualProfits, ref VehicleBreakdownRevenues, ref ExpectedProfit, ref AnotherIncome, ref Cash, ref Bank, ref CreatedDate, ref ClosedDate, ref IsClosed, ref CreatedByUserID, ref ClosedByUserID,ref VehicleSales))

                return new clsGeneralRevenueFund(GeneralRevenueFundID, ActualProfits, VehicleBreakdownRevenues, AnotherIncome, Cash, Bank, CreatedDate, ClosedDate, IsClosed, CreatedByUserID, ClosedByUserID, ExpectedProfit, VehicleSales);
            else
                return null;
        }
        public static bool isGeneralRevenueFundExist(int GeneralRevenueFundID)
        {
            return clsGeneralRevenueFundData.IsGeneralRevenueFundExist(GeneralRevenueFundID);
        }
        public static DataTable GetAllGeneralRevenueFund()
        {
            return clsGeneralRevenueFundData.GetAllGeneralRevenueFund();
        }
    }
}
