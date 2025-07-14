using CarRental_DataAccess;
using System;
using System.Data;
using System.Net.Http.Headers;

namespace CarRental_Business
{
    public class clsVehicleSale
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enPaymentDetails { Cash=1, BankTransfer =2}
        private int _SaleID;
        public int SaleID { get { return _SaleID; } }
        public int VehicleID { get; set; }
        public DateTime SaleDate { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Byte PaymentDetails { get; set; }
        public int CreatedByUserID { set; get; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdatedDate { get; set; }
        private clsVehicleSale(int SaleID, int VehicleID, DateTime SaleDate, string Description, double Price, Byte PaymentDetails,int CreatedByUserID,int?UpdatedByUserID,DateTime?UpdatedDate)
        {

            _SaleID = SaleID;

            this.VehicleID = VehicleID;
            this.SaleDate = SaleDate;
            this.Description = Description;
            this.Price = Price;
            this.PaymentDetails = PaymentDetails;
            this.UpdatedDate = UpdatedDate;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            Mode = enMode.Update;
        }
        public clsVehicleSale()

        {
            this._SaleID = -1;
            SaleDate = DateTime.Now;
            this.PaymentDetails = 1;
            this.Price = 0;
            this.Description = "";
            this.CreatedByUserID = -1;
            this.UpdatedByUserID = null;
            this.UpdatedDate = null;
            Mode = enMode.AddNew;

        }
        private bool _AddNewVehicleSale()
        {
            this._SaleID = clsVehicleSaleData.AddNewVehicleSale(VehicleID, SaleDate, Description, Price, PaymentDetails, CreatedByUserID, UpdatedByUserID, UpdatedDate);
            return _SaleID != 0;
        }
        private bool _UpdateVehicleSale()
        {
            return clsVehicleSaleData.UpdateVehicleSale(this._SaleID, VehicleID, SaleDate, Description, Price, PaymentDetails,CreatedByUserID,UpdatedByUserID,UpdatedDate);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleSale())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateVehicleSale())
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
        public static clsVehicleSale Find(int SaleID)
        {


            int VehicleID = 0;
            DateTime SaleDate = DateTime.Now;
            string Description = "";
            double Price = 0;
            Byte PaymentDetails = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime? UpdatedDate =null;   

            if (clsVehicleSaleData.GetVehicleSaleInfoByID(SaleID, ref VehicleID, ref SaleDate, ref Description, ref Price, ref PaymentDetails,ref CreatedByUserID,ref UpdatedByUserID,ref UpdatedDate))

                return new clsVehicleSale(SaleID, VehicleID, SaleDate, Description, Price, PaymentDetails, CreatedByUserID, UpdatedByUserID, UpdatedDate);
            else
                return null;
        }
        public static clsVehicleSale FindByVehicleID(int vehicleID)
        {


            int SaleID = 0;
            DateTime SaleDate = DateTime.Now;
            string Description = "";
            double Price = 0;
            Byte PaymentDetails = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime? UpdatedDate = null;

            if (clsVehicleSaleData.GetVehicleSaleInfoByVehicleID(vehicleID,ref SaleID, ref SaleDate, ref Description, ref Price, ref PaymentDetails, ref CreatedByUserID, ref UpdatedByUserID, ref UpdatedDate))

                return new clsVehicleSale(SaleID, vehicleID, SaleDate, Description, Price, PaymentDetails, CreatedByUserID, UpdatedByUserID, UpdatedDate);
            else
                return null;
        }
        public static bool isVehicleSaleExist(int SaleID)
        {
            return clsVehicleSaleData.IsVehicleSaleExist(SaleID);
        }
        public static DataTable GetAllVehicleSales()
        {
            return clsVehicleSaleData.GetAllVehicleSales();
        }
    }
}
