using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsVehicleReturn
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        protected int _ReturnID;
        public int ReturnID { get { return _ReturnID; } }
        public DateTime ActualReturnDate { get; set; }
        public Int16 ActualRentalDays { set; get; }
        public byte ActualRentalMonths { set; get; }
        public int Mileage { get; set; }
        public int ConsumedMileage { get; set; }
        public Byte AdditionalHours { get; set; }
        public int AdditionalKilometer { get; set; }
        public Double AdditionalCharges { get; set; }
        public double ActualTotalDueAmount {get; set; }
        private clsVehicleReturn(int ReturnID, DateTime ActualReturnDate, int Mileage, int ConsumedMileage, Int16 ActualRentalDays,byte ActualRentalMonths, Byte AdditionalHours, int AdditionalKilometer, Double AdditionalCharges, double actualTotalDueAmount)
        {

            _ReturnID = ReturnID;

            this.ActualReturnDate = ActualReturnDate;
            this.Mileage = Mileage;
            this.ConsumedMileage = ConsumedMileage;
            this.ActualRentalDays = ActualRentalDays;
            this.AdditionalHours = AdditionalHours;
            this.AdditionalKilometer = AdditionalKilometer;
            this.AdditionalCharges = AdditionalCharges;
            this.ActualRentalMonths = ActualRentalMonths;
            Mode = enMode.Update;
            ActualTotalDueAmount = actualTotalDueAmount;
        }
        public clsVehicleReturn()

        {
            this._ReturnID = -1;
            this.AdditionalHours = 0;
            this.AdditionalKilometer = 0;
            this.AdditionalCharges = 0;
            this.ActualTotalDueAmount = 0;
            Mode = enMode.AddNew;

        }
        private bool _AddNewVehicleReturn()
        {
            this._ReturnID = clsVehicleReturnData.AddNewVehicleReturn( ActualReturnDate,  AdditionalHours,  ActualRentalDays, ActualRentalMonths,  Mileage,  ConsumedMileage,AdditionalKilometer, AdditionalCharges,ActualTotalDueAmount);
            return _ReturnID != 0;
        }
        private bool _UpdateVehicleReturn()
        {
            return clsVehicleReturnData.UpdateVehicleReturn(this._ReturnID, ActualReturnDate, AdditionalHours, ActualRentalDays, ActualRentalMonths, Mileage, ConsumedMileage,AdditionalKilometer, AdditionalCharges,ActualTotalDueAmount);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleReturn())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateVehicleReturn())
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
        public static clsVehicleReturn Find(int ReturnID)
        {


            DateTime ActualReturnDate = DateTime.Now;
            Int16 ActualRentalDays = 0;
            byte ActualRentalMonths = 0;
            int Mileage = 0;
            int ConsumedMileage = 0;
            Byte AdditionalHours = 0;
            int AdditionalKilometer = 0;
            double AdditionalCharges = 0;
            double ActualTotalDueAmount = 0;

            if (clsVehicleReturnData.GetVehicleReturnInfoByID(ReturnID, ref  ActualReturnDate, ref  AdditionalHours, ref  ActualRentalDays,ref ActualRentalMonths, ref  Mileage, ref  ConsumedMileage,ref AdditionalKilometer, ref  AdditionalCharges,ref ActualTotalDueAmount))

                return new clsVehicleReturn(ReturnID,ActualReturnDate,Mileage,ConsumedMileage,ActualRentalDays, ActualRentalMonths,AdditionalHours, AdditionalKilometer, AdditionalCharges, ActualTotalDueAmount);
            else
                return null;
        }
        public static bool isVehicleReturnExist(int ReturnID)
        {
            return clsVehicleReturnData.IsVehicleReturnExist(ReturnID);
        }
        public static DataTable GetAllVehicleReturns()
        {
            return clsVehicleReturnData.GetAllVehicleReturns();
        }

    }
}
