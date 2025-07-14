using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsDailyIncomeFund
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enStatus { Deficit=1,Surplus=2,Balanced=3 }
        private int _DailyIncomeFundID;
        public int DailyIncomeFundID { get { return _DailyIncomeFundID; } }
        public double TotalIncome { get { return ExpectedCashAmount + ExpectedTransformationAmount; } }
        public double ExpectedCashAmount { get; set; }
        public double ExpectedTransformationAmount { get; set; }
        public double ActualProfits { set; get; }
        public double ExpectedProfit { set; get; }
        public float StartAmount { set; get; }
        public double TotalAvailableCashAmount { set; get; }
        public double TotalAvailableTransformationAmount { get; set; }
        public double TotalRevenueDeficitOrSurplus { get { return ((TotalAvailableTransformationAmount + TotalAvailableCashAmount)-StartAmount) - TotalIncome; } }
        public double VehicleBreakdownRevenues { get; set; }
        public Boolean IsClose { get; set; }
        public DateTime Date { get; set; }
        public int BranchID { set; get; }
        public int? ClosedByUserID { set; get; }

        public byte Status 
        {
            get
            {
                if (TotalRevenueDeficitOrSurplus<0)
                    return (byte)enStatus.Deficit;
                if (TotalRevenueDeficitOrSurplus>0)
                    return (byte)enStatus.Surplus;
                return (byte)enStatus.Balanced;  
            }
        }    
        public string GetStatus 
        {
            get 
            {
                if (Status== (byte)enStatus.Deficit)
                    return "Deficit";
                if (Status==(byte)enStatus.Surplus)
                    return "Surplus";
                return "Balanced";
            }
        }
        private clsDailyIncomeFund(int DailyIncomeFundID, double ExpectedCashAmount, double ExpectedTransformationAmount, double TotalAvailableCashAmount, double TotalAvailableTransformationAmount, double VehicleBreakdownRevenues, Boolean IsClose, DateTime Date, int BranchID, int? closedByUserID, float startAmount, double actualProfits, double expectedProfit)
        {

            _DailyIncomeFundID = DailyIncomeFundID;
            this.ExpectedCashAmount = ExpectedCashAmount;
            this.ExpectedTransformationAmount = ExpectedTransformationAmount;
            this.TotalAvailableCashAmount = TotalAvailableCashAmount;
            this.TotalAvailableTransformationAmount = TotalAvailableTransformationAmount;
            this.VehicleBreakdownRevenues = VehicleBreakdownRevenues;
            this.IsClose = IsClose;
            this.Date = Date;
            this.BranchID = BranchID;
            ClosedByUserID = closedByUserID;
            StartAmount = startAmount;
            Mode = enMode.Update;
            this.ActualProfits = actualProfits;
            this.ExpectedProfit = expectedProfit;
        }
        public clsDailyIncomeFund()

        {
            this.ExpectedCashAmount = 0;
            this.ExpectedTransformationAmount = 0;
            this.TotalAvailableCashAmount = 0;
            this.TotalAvailableTransformationAmount = 0;
            this.VehicleBreakdownRevenues = 0;
            this.IsClose = false;
            this.Date = DateTime.Now;
            this.BranchID = -1;
            this.ActualProfits = 0;
            this.ExpectedProfit = 0;
            ClosedByUserID = null;
            StartAmount = 0;
            Mode = enMode.AddNew;

        }
        public static DateTime GetStartDate(Byte CountHours)
        {
            DateTime Date = DateTime.Now.AddHours(-(DateTime.Now.Hour)).AddMinutes(-(DateTime.Now.Minute));
         
            if (DateTime.Now.Hour <= (CountHours * 2) && DateTime.Now.Hour > CountHours)
            {
                return Date.AddHours((CountHours));
            }
            else if (DateTime.Now.Hour < (CountHours * 3) && DateTime.Now.Hour > (CountHours*2))
            {
                return Date.AddHours((CountHours * 2));
            }
            return Date;
        }
        private bool _AddNewDailyIncomeFunds()
        {
            this._DailyIncomeFundID = clsDailyIncomeFundData.AddNewDailyIncomeFunds(TotalIncome, ExpectedCashAmount, ExpectedTransformationAmount, TotalAvailableCashAmount, TotalAvailableTransformationAmount, TotalRevenueDeficitOrSurplus,VehicleBreakdownRevenues, Status, IsClose, Date, BranchID, ClosedByUserID,StartAmount,ActualProfits,ExpectedProfit);
            return _DailyIncomeFundID != 0;
        }
        private bool _UpdateDailyIncomeFunds()
        {
            return clsDailyIncomeFundData.UpdateDailyIncomeFunds(this._DailyIncomeFundID, TotalIncome, ExpectedCashAmount, ExpectedTransformationAmount, TotalAvailableCashAmount, TotalAvailableTransformationAmount, TotalRevenueDeficitOrSurplus,VehicleBreakdownRevenues, Status, IsClose, Date, BranchID, ClosedByUserID, ActualProfits, ExpectedProfit);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDailyIncomeFunds())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateDailyIncomeFunds())
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
        public static clsDailyIncomeFund Find(int DailyIncomeFundID)
        { 
            double ExpectedCashAmount = 0;
            double ExpectedTransformationAmount = 0;
            double TotalAvailableCashAmount = 0;
            double TotalAvailableTransformationAmount = 0;
            double TotalRevenueDeficitOrSurplus = 0;
            double VehicleBreakdownRevenues = 0;
            Boolean IsClose = false;
            DateTime Date = DateTime.Now;
            int BranchID = 0;
            int? ClosedByUserID = null;
            float startAmount = 0;
            double ActualProfits = 0, ExpectedProfit = 0;
            if (clsDailyIncomeFundData.GetDailyIncomeFundsInfoByID(DailyIncomeFundID, ref ExpectedCashAmount, ref ExpectedTransformationAmount, ref TotalAvailableCashAmount, ref TotalAvailableTransformationAmount, ref TotalRevenueDeficitOrSurplus, ref VehicleBreakdownRevenues, ref IsClose, ref Date,ref BranchID,ref ClosedByUserID,ref startAmount, ref ActualProfits, ref ExpectedProfit))

                return new clsDailyIncomeFund(DailyIncomeFundID, ExpectedCashAmount, ExpectedTransformationAmount, TotalAvailableCashAmount, TotalAvailableTransformationAmount,VehicleBreakdownRevenues, IsClose, Date, BranchID, ClosedByUserID,startAmount, ActualProfits, ExpectedProfit);
            else
                return null;
        }

        public static clsDailyIncomeFund GetDailyIncomeFundToDaye(float StartAmount, byte CountHours,int BranchID)
        {
            int DailyIncomeFundID = -1;
            double ExpectedCashAmount = 0;
            double ExpectedTransformationAmount = 0;
            double TotalAvailableCashAmount = 0;
            double TotalAvailableTransformationAmount = 0;
            double TotalRevenueDeficitOrSurplus = 0;
            double VehicleBreakdownRevenues = 0;
            int? ClosedByUserID=null;
            Boolean IsClose = false;
            double ActualProfits = 0, ExpectedProfit = 0;
            DateTime Date = GetStartDate(CountHours);
            if (clsDailyIncomeFundData.GetDailyIncomeFundInfoByDate(ref DailyIncomeFundID, ref ExpectedCashAmount, ref ExpectedTransformationAmount, ref TotalAvailableCashAmount,
                ref TotalAvailableTransformationAmount, ref TotalRevenueDeficitOrSurplus,ref VehicleBreakdownRevenues, ref IsClose,ref Date,ref BranchID,ref ClosedByUserID, CountHours,ref StartAmount,ref ActualProfits,ref ExpectedProfit))
                return new clsDailyIncomeFund(DailyIncomeFundID, ExpectedCashAmount, ExpectedTransformationAmount, TotalAvailableCashAmount, TotalAvailableTransformationAmount,VehicleBreakdownRevenues, IsClose, Date, BranchID, ClosedByUserID, StartAmount, ActualProfits, ExpectedProfit);

            clsDailyIncomeFund DailyIncomeFund = new clsDailyIncomeFund();
            DailyIncomeFund.StartAmount = StartAmount;
            DailyIncomeFund.BranchID = BranchID;
            DailyIncomeFund.Save();
            return DailyIncomeFund;
        }

        public static bool isDailyIncomeFundsExist(int DailyIncomeFundID)
        {
            return clsDailyIncomeFundData.IsDailyIncomeFundsExist(DailyIncomeFundID);
        }
        public static DataTable GetAllDailyIncomeFunds()
        {
            return clsDailyIncomeFundData.GetAllDailyIncomeFunds();
        }
        public static DataTable GetAllDailyIncomeFunds(int BranchID)
        {
            return clsDailyIncomeFundData.GetAllDailyIncomeFunds(BranchID);
        }
    }
}
