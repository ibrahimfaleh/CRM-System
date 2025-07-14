using CarRental_DataAccess;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace CarRental_Business
{
    public class clsRentalBooking
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enRentalBookingStatus { New = 0, Completed = 1 };

        public int BookingID { set; get; }
        public int CustomerID { set; get; }
        public int VehicleID { set; get; }
        public clsVehicle VehicleInfo { set; get; }
        public DateTime RentalStartDate { set; get; }
        public DateTime RentalEndDate { set; get; }
        public double RentalPricePerMileage { get; set; }
        public short FreeKilometersCredit { get; set; }
        public float RentalPricePerHours { get; set; }
        public int PickupBranchID { set; get; }
        public int? DropOffBranchID { set; get; }
        public bool IsMonthly { set; get; }
        public byte NumberDaysOfCustomMonth {  set; get; }  
        public short InitialRentalDays 
        {
            get
            {
                if(!IsMonthly)
                    return (short)Math.Round( (RentalEndDate - RentalStartDate).TotalDays);
                return 0;
            }
        }
        public float RentalPricePerMonth { get; set; }
        public byte InitialRentalMonths
        {
            get
            {
                if (IsMonthly)
                    if(NumberDaysOfCustomMonth == 0)
                    return (byte)(RentalEndDate.Month - RentalStartDate.Month);
                else
                    {
                        return (byte)((RentalEndDate - RentalStartDate).Days/NumberDaysOfCustomMonth);
                    }
                return 0;
            }
        }
        public float RentalPricePerDay { get; set; }
        public double InitialTotalDueAmount 
        {
            get 
            {
                if(IsMonthly)
                    return InitialRentalMonths * RentalPricePerMonth;
                else
                    return InitialRentalDays * RentalPricePerDay;
            }
        }
        protected clsVehicleCheck _vehicleCheck;
        public clsVehicleCheck VehicleCheckInfo { get { return _vehicleCheck; } }
        public int VehicleCheckID { set; get; }
        public byte BookingStatus { get; set; }
        public int BranchID { set; get; }
        private clsRentalBooking(int bookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, double RentalPricePerMileage, short FreeKilometersCredit, float RentalPricePerHours,
            int PickupBranchID, int? DropOffBranchID
            , float RentalPricePerDay, float RentalPricePerMonth, int VehicleCheckID, byte BookingStatus, bool IsMonthly, int BranchID, byte numberDaysOfCustomMonth)
        {
            this.BookingID = bookingID;
            this.CustomerID = CustomerID;
            this.VehicleID = VehicleID;
            this.RentalStartDate = RentalStartDate;
            this.RentalEndDate = RentalEndDate;
            this.RentalPricePerMileage = RentalPricePerMileage;
            this.FreeKilometersCredit = FreeKilometersCredit;
            this.RentalPricePerHours = RentalPricePerHours;
            this.DropOffBranchID = DropOffBranchID;
            this.PickupBranchID = PickupBranchID;
            this.RentalPricePerDay = RentalPricePerDay;
            this.VehicleCheckID = VehicleCheckID;
            this.BookingStatus = BookingStatus;
            this.RentalPricePerMonth = RentalPricePerMonth;
            this.VehicleInfo = clsVehicle.Find(VehicleID);
            this.IsMonthly = IsMonthly;
            this.BranchID = BranchID;
            this._vehicleCheck = clsVehicleCheck.Find(VehicleCheckID);
            Mode = enMode.Update;
            NumberDaysOfCustomMonth = numberDaysOfCustomMonth;
        }
        protected clsRentalBooking(int bookingID)
        {
            clsRentalBooking rentalBooking = clsRentalBooking.Find(bookingID);
          this.BookingID = bookingID;
            this.NumberDaysOfCustomMonth = rentalBooking.NumberDaysOfCustomMonth;
            this.CustomerID = rentalBooking.CustomerID;
            this.VehicleID = rentalBooking.VehicleID;
            this.RentalStartDate = rentalBooking.RentalStartDate;
            this.RentalEndDate = rentalBooking.RentalEndDate;
            this.DropOffBranchID = rentalBooking.DropOffBranchID;
            this.PickupBranchID = rentalBooking.PickupBranchID;
            this.RentalPricePerDay = rentalBooking.RentalPricePerDay;
            this.VehicleCheckID = rentalBooking.VehicleCheckID;
            this.BookingStatus = rentalBooking.BookingStatus;
            this.RentalPricePerMonth = rentalBooking.RentalPricePerMonth;
            this.VehicleInfo = clsVehicle.Find(VehicleID);
            this.IsMonthly = rentalBooking.IsMonthly;
            Mode = enMode.Update;
        }

        public clsRentalBooking()

        {
            this.BookingID = -1;
            this.RentalStartDate = DateTime.Now;
            this.RentalEndDate = this.RentalStartDate.AddDays(1);
            Mode = enMode.AddNew;
        }
        public string days()
        {
            string x = (this.RentalEndDate - this.RentalStartDate).TotalDays.ToString();
            return x;
        }
        private bool _AddNewRentalBooking()
        {
            this.BookingID = clsRentalBookingData.AddNewRentalBooking(CustomerID, VehicleID, RentalStartDate, RentalEndDate, RentalPricePerMileage, FreeKilometersCredit, RentalPricePerHours,
                PickupBranchID, DropOffBranchID, RentalPricePerMonth, InitialRentalMonths, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, VehicleCheckID, BookingStatus, IsMonthly, BranchID, NumberDaysOfCustomMonth);
            return BookingID != -1;
        }
        private bool _UpdateRentalBooking()
        {
            return clsRentalBookingData.UpdateRentalBooking(this.BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, RentalPricePerMileage,
FreeKilometersCredit,
RentalPricePerHours,

 PickupBranchID, DropOffBranchID, InitialRentalMonths, InitialRentalDays, RentalPricePerMonth, RentalPricePerDay, InitialTotalDueAmount, VehicleCheckID, BookingStatus, IsMonthly, NumberDaysOfCustomMonth);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalBooking())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateRentalBooking())
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
        public static clsRentalBooking Find(int BookingID)
        {


            int CustomerID = 0;
            int VehicleID = 0;
            DateTime RentalStartDate = DateTime.Now;
            DateTime RentalEndDate = DateTime.Now;
            double RentalPricePerMileage = 0;
            short FreeKilometersCredit = 0;
            float RentalPricePerHours = 0;
            int PickupBranchID = 0;
            int? DropOffBranchID = null;
            float RentalPricePerDay = 0;
            int VehicleCheckID = 0;
            byte BookingStatus = 0;
            bool IsMonthly = false;
            float RentalPricePerMonth = 0;
            int BranchID = -1;
            byte NumberDaysOfCustomMonth = 0;
            if (clsRentalBookingData.GetRentalBookingInfoByID(BookingID, ref CustomerID, ref VehicleID, ref RentalStartDate, ref RentalEndDate, ref RentalPricePerMileage, ref FreeKilometersCredit, ref RentalPricePerHours, ref PickupBranchID,
            ref DropOffBranchID, ref RentalPricePerMonth, ref RentalPricePerDay, ref VehicleCheckID, ref BookingStatus, ref IsMonthly, ref BranchID,ref NumberDaysOfCustomMonth))

                return new clsRentalBooking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, RentalPricePerMileage, FreeKilometersCredit, RentalPricePerHours,
             PickupBranchID, DropOffBranchID,
             RentalPricePerDay, RentalPricePerMonth, VehicleCheckID, BookingStatus, IsMonthly, BranchID, NumberDaysOfCustomMonth);
            return null;


        }
        public static bool isRentalBookingExist(int BookingID)
        {
            return clsRentalBookingData.IsRentalBookingExist(BookingID);
        }
        public static DataTable GetAllRentalBooking()
        {
            return clsRentalBookingData.GetAllRentalBooking();
        }

    }
}
