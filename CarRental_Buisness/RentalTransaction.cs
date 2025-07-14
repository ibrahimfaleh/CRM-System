using CarRental_DataAccess;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace CarRental_Business
{
    public class clsRentalTransaction :clsRentalBooking
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        protected int _TransactionID;
        public int TransactionID { get { return _TransactionID; } }
        public int BookingID { get { return base.BookingID; } }
        public int? ReturnID { get; set; }
        public double Vat { set ; get ;}
        private clsVehicleReturn _VehicleReturn=new clsVehicleReturn(); 
        public clsVehicleReturn VehicleReturnInfo { get { return _VehicleReturn; } }
        public int InitialPaymentMethodID { get; set; }
        public int? FinalPaymentMethodID { get;set; }
        public double? AdditionalKilometerCharges { get { return VehicleReturnInfo.AdditionalKilometer * base.RentalPricePerMileage; } }
        public double PaidInitialTotalDueAmount { set; get; }
        public double? ActualTotalDueAmount { get; set; }
        public double? TotalRemaining { get; set; }
        public double? TotalRefundedAmount { get; set; }
        public double? TotalHourlyCharge { get { return double.Parse(( VehicleReturnInfo.AdditionalHours * base.RentalPricePerHours).ToString()); } }
        public double InitialTotalDueAmountAfterTax { get { return Math.Round( (base.InitialTotalDueAmount  * this.Vat),2); } }
        public DateTime TransactionDate { get; set; }
        public DateTime? UpdatedTransactionDate { get; set; }
        public int CreatedByUserID { set; get; }
        public int? UpdateByUserID { set; get; }
        private clsRentalTransaction(int TransactionID, int BookingID, int? ReturnID, double Vat, int InitialPaymentMethodID, int? FinalPaymentMethodID, double PaidInitialTotalDueAmount, double? ActualTotalDueAmount,
            double? TotalRemaining, double? TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate,int CreatedByUserID,int? UpdateByUserID, int CustomerID, int VehicleID,
            DateTime RentalStartDate, DateTime RentalEndDate, double RentalPricePerMileage, short FreeKilometersCredit, float RentalPricePerHours, int PickupBranchID, int? DropOffBranchID
            , float RentalPricePerDay, int VehicleCheckID, byte BookingStatus,bool IsMonthly,float RentalPricePerMonth,int BranchID)
        {

            _TransactionID = TransactionID;

            base.BookingID = BookingID;
            this.ReturnID = ReturnID;
            this.InitialPaymentMethodID = InitialPaymentMethodID;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TotalRemaining = TotalRemaining;
            this.TotalRefundedAmount = TotalRefundedAmount;
            this.TransactionDate = TransactionDate;
            this.UpdatedTransactionDate = UpdatedTransactionDate;
            this.Vat = Vat;
            this.FinalPaymentMethodID = FinalPaymentMethodID;
            this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdateByUserID = UpdateByUserID;
            Mode = enMode.Update;
            base.CustomerID = CustomerID;
            base.VehicleID = VehicleID;
            base.RentalStartDate = RentalStartDate;
            base.RentalEndDate = RentalEndDate;
            base.DropOffBranchID = DropOffBranchID;
            base.PickupBranchID = PickupBranchID;
            base.RentalPricePerDay = RentalPricePerDay;
            base.RentalPricePerMileage = RentalPricePerMileage;
            base.RentalPricePerHours = RentalPricePerHours;
            base.FreeKilometersCredit = FreeKilometersCredit;
            base.VehicleCheckID = VehicleCheckID;
            base.BookingStatus = BookingStatus;
            base.IsMonthly= IsMonthly;
            base.RentalPricePerMonth = RentalPricePerMonth;
            base.BranchID = BranchID;
            base.VehicleInfo = clsVehicle.Find(VehicleID);
            base._vehicleCheck = clsVehicleCheck.Find(VehicleCheckID);
            if (this.ReturnID.HasValue)
                this._VehicleReturn = clsVehicleReturn.Find(ReturnID.Value);
            base.Mode = clsRentalBooking.enMode.Update;
        }
        public clsRentalTransaction()

        {
            this._TransactionID = -1;
            Mode = enMode.AddNew;
            this._VehicleReturn= clsVehicleReturn.Find(ReturnID ?? -1) ?? new clsVehicleReturn();
        }
        private bool _AddNewRentalTransaction()
        {
            this._TransactionID = clsRentalTransactionData.AddNewRentalTransaction(BookingID, ReturnID, Vat, InitialPaymentMethodID,FinalPaymentMethodID, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate,CreatedByUserID,UpdateByUserID);
            return _TransactionID !=-1;
        }
        private bool _UpdateRentalTransaction()
        {
            return clsRentalTransactionData.UpdateRentalTransaction(this._TransactionID, BookingID, ReturnID, Vat, InitialPaymentMethodID,FinalPaymentMethodID, PaidInitialTotalDueAmount, AdditionalKilometerCharges,TotalHourlyCharge, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate, CreatedByUserID, UpdateByUserID,(this.ActualTotalDueAmount-this.VehicleReturnInfo.AdditionalCharges)??0);
        }
        public bool Save()

        {
            base.Mode = (clsRentalBooking.enMode)Mode;
            if (!base.Save())
                return false;
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateRentalTransaction())
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
        public static clsRentalTransaction Find(int TransactionID)
        {


            int BookingID = 0;
            int? ReturnID = null;
            double Vat = 0;
            int InitialPaymentMethodID = -1;
            int? FinalPaymentMethodID = null;
            double PaidInitialTotalDueAmount = 0;
            double? ActualTotalDueAmount= null;
            double? TotalRemaining = null;
            double? TotalRefundedAmount = null;
            DateTime TransactionDate = DateTime.Now;
            DateTime? UpdatedTransactionDate = null;
            int CreatedByUserID = 0;
            int? UpdateByUserID = 0;


            if (!clsRentalTransactionData.GetRentalTransactionInfoByID(TransactionID, ref BookingID, ref ReturnID, ref Vat, ref InitialPaymentMethodID,ref FinalPaymentMethodID,ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate,ref CreatedByUserID,ref UpdateByUserID))
                return null;

            clsRentalBooking rentalBooking = clsRentalBooking.Find(BookingID);
                return new clsRentalTransaction(TransactionID, BookingID, ReturnID,Vat, InitialPaymentMethodID,FinalPaymentMethodID,  PaidInitialTotalDueAmount,
                    ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate,
                    UpdatedTransactionDate,CreatedByUserID,UpdateByUserID,rentalBooking.CustomerID,rentalBooking.VehicleID,rentalBooking.RentalStartDate,rentalBooking.RentalEndDate,rentalBooking.RentalPricePerMileage,rentalBooking.FreeKilometersCredit,
                    rentalBooking.RentalPricePerHours,rentalBooking.PickupBranchID,
                    rentalBooking.DropOffBranchID,rentalBooking.RentalPricePerDay, rentalBooking.VehicleCheckID,rentalBooking.BookingStatus,rentalBooking.IsMonthly,rentalBooking.RentalPricePerMonth, rentalBooking.BranchID);

        }
        public static clsRentalTransaction FindNewBooking(string PlateNumber)
        {

            int TransactionID = 0;
            int BookingID = 0;
            int? ReturnID = null;
            double Vat = 0;
            int InitialPaymentMethodID = -1;
            int? FinalPaymentMethodID = null;
            double PaidInitialTotalDueAmount = 0;
            double? ActualTotalDueAmount = null;
            double? TotalRemaining = null;
            double? TotalRefundedAmount = null;
            DateTime TransactionDate = DateTime.Now;
            DateTime? UpdatedTransactionDate = null;
            int CreatedByUserID = 0;
            int? UpdateByUserID = 0;


            if (!clsRentalTransactionData.GetNewRentalTransactionInfoByPlateNumber( PlateNumber,ref TransactionID, ref BookingID, ref ReturnID, ref Vat, ref InitialPaymentMethodID, ref FinalPaymentMethodID, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate, ref CreatedByUserID, ref UpdateByUserID))
                return null;

            clsRentalBooking rentalBooking = clsRentalBooking.Find(BookingID);
            return new clsRentalTransaction(TransactionID, BookingID, ReturnID, Vat, InitialPaymentMethodID, FinalPaymentMethodID, PaidInitialTotalDueAmount,
                ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate,
                UpdatedTransactionDate, CreatedByUserID, UpdateByUserID, rentalBooking.CustomerID, rentalBooking.VehicleID, rentalBooking.RentalStartDate, rentalBooking.RentalEndDate, rentalBooking.RentalPricePerMileage, rentalBooking.FreeKilometersCredit,
                rentalBooking.RentalPricePerHours, rentalBooking.PickupBranchID,
                rentalBooking.DropOffBranchID, rentalBooking.RentalPricePerDay, rentalBooking.VehicleCheckID, rentalBooking.BookingStatus, rentalBooking.IsMonthly, rentalBooking.RentalPricePerMonth, rentalBooking.BranchID);
        }
        public static clsRentalTransaction FindByBookingID(int BookingID)
        {


            int TransactionID = -1;
            int? ReturnID = null;
            double Vat = 0;
            int InitialPaymentMethodID = -1;
            int? FinalPaymentMethodID = null;
            double? ActualTotalDueAmount = null;
            double? TotalRemaining = null;
            double? TotalRefundedAmount = null;
            double PaidInitialTotalDueAmount = 0;
            DateTime TransactionDate = DateTime.Now;
            DateTime? UpdatedTransactionDate = null;
            int CreatedByUserID = 0;
            int? UpdateByUserID = 0;

            if (!clsRentalTransactionData.GetRentalTransactionInfoByBookingID(ref TransactionID, BookingID, ref ReturnID, ref Vat, ref InitialPaymentMethodID,ref FinalPaymentMethodID,ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate, ref CreatedByUserID, ref UpdateByUserID))
                return null;
            clsRentalBooking rentalBooking = clsRentalBooking.Find(BookingID);
            return new clsRentalTransaction(TransactionID, BookingID, ReturnID, Vat, InitialPaymentMethodID, FinalPaymentMethodID, PaidInitialTotalDueAmount,
                ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate,
                UpdatedTransactionDate, CreatedByUserID, UpdateByUserID, rentalBooking.CustomerID, rentalBooking.VehicleID, rentalBooking.RentalStartDate, rentalBooking.RentalEndDate, rentalBooking.RentalPricePerMileage, rentalBooking.FreeKilometersCredit,
                rentalBooking.RentalPricePerHours, rentalBooking.PickupBranchID,
                rentalBooking.DropOffBranchID, rentalBooking.RentalPricePerDay, rentalBooking.VehicleCheckID, rentalBooking.BookingStatus, rentalBooking.IsMonthly, rentalBooking.RentalPricePerMonth,  rentalBooking.BranchID);
        }
        public static bool isRentalTransactionExist(int TransactionID)
        {
            return clsRentalTransactionData.IsRentalTransactionExist(TransactionID);
        }
        public static float GetVatBayBookingID(int BookingID)
        {
            return clsRentalTransactionData.GetVatBayBookingID(BookingID);
        }
        public static DataTable GetAllRentalTransaction()
        {
            return clsRentalTransactionData.GetAllRentalTransaction();
        }
        public static DataTable GetAllRentalTransactionForBranchIsPublic()
        {
            return clsRentalTransactionData.GetAllRentalTransactionForBranchIsPublic();
        }
        public static DataTable GetAllRentalTransactionByCustomerID(int CustomerID)
        {
            return clsRentalTransactionData.GetAllRentalTransactionByCustomerID(CustomerID);
        }
        public static DataTable GetAllRentalTransactionByBranchID(int BranchID)
        {
            return clsRentalTransactionData.GetAllRentalTransactionByBranchID(BranchID);
        }
    }
}
