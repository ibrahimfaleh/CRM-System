using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsMaintenanceTransaction
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _MaintenanceID;
        public int MaintenanceID { get { return _MaintenanceID; } }
        public int VehicleID { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public double? Cost { get; set; }


        public DateTime? ReturnDate { get; set; }
        public int? AmountSpentID { get; set; }
        public int CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        public int TransferredByEmployeeID { get; set; }
        public int? VehicleReturnByEmployeeID { get; set; }
        public Boolean IsCompleted { get; set; }
        public int? NewMileage { set; get; }
        public Int16? ConsumedMileage { get { return (Int16)((NewMileage??Mileage) - Mileage); } }
        private clsMaintenanceTransaction(int MaintenanceID, int VehicleID, int Mileage, string Description, DateTime MaintenanceDate, double? Cost, DateTime? ReturnDate, int? AmountSpentID, int CreatedByUserID, int? UpdatedByUserID, int TransferredByEmployeeID, int? VehicleReturnByEmployeeID, Boolean IsCompleted, int? newMileage)
        {

            _MaintenanceID = MaintenanceID;

            this.VehicleID = VehicleID;
            this.Mileage = Mileage;
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;
            this.ReturnDate = ReturnDate;
            this.AmountSpentID = AmountSpentID;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            this.TransferredByEmployeeID = TransferredByEmployeeID;
            this.VehicleReturnByEmployeeID = VehicleReturnByEmployeeID;
            this.IsCompleted = IsCompleted;
            Mode = enMode.Update;
            NewMileage = newMileage;
        }
        public clsMaintenanceTransaction()

        {
            this._MaintenanceID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewMaintenanceTransaction()
        {
            this._MaintenanceID = clsMaintenanceTransactionData.AddNewMaintenanceTransaction(VehicleID, Mileage, Description, MaintenanceDate, Cost, ConsumedMileage, ReturnDate, AmountSpentID, CreatedByUserID, UpdatedByUserID, TransferredByEmployeeID, VehicleReturnByEmployeeID, IsCompleted, NewMileage);
            return _MaintenanceID != 0;
        }
        private bool _UpdateMaintenanceTransaction()
        {
            return clsMaintenanceTransactionData.UpdateMaintenanceTransaction(this._MaintenanceID, VehicleID, Mileage, Description, MaintenanceDate, Cost, ConsumedMileage, ReturnDate, AmountSpentID, CreatedByUserID, UpdatedByUserID, TransferredByEmployeeID, VehicleReturnByEmployeeID, IsCompleted, NewMileage);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMaintenanceTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateMaintenanceTransaction())
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
        public static clsMaintenanceTransaction Find(int MaintenanceID)
        {


            int VehicleID = 0;
            int Mileage = 0;
            string Description = "";
            DateTime MaintenanceDate = DateTime.Now;
            double? Cost = null;
            Int16? ConsumedMileage = null;
            DateTime? ReturnDate = null;
            int? AmountSpentID = null;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            int TransferredByEmployeeID = 0;
            int? VehicleReturnByEmployeeID = null;
            Boolean IsCompleted = false;
            int? NewMileage = null;

            if (clsMaintenanceTransactionData.GetMaintenanceTransactionInfoByID(MaintenanceID, ref VehicleID, ref Mileage, ref Description, ref MaintenanceDate, ref Cost, ref ConsumedMileage, ref ReturnDate, ref AmountSpentID, ref CreatedByUserID, ref UpdatedByUserID, ref TransferredByEmployeeID, ref VehicleReturnByEmployeeID, ref IsCompleted,ref NewMileage))

                return new clsMaintenanceTransaction(MaintenanceID, VehicleID, Mileage, Description, MaintenanceDate, Cost, ReturnDate, AmountSpentID, CreatedByUserID, UpdatedByUserID, TransferredByEmployeeID, VehicleReturnByEmployeeID, IsCompleted, NewMileage);
            else
                return null;
        }
        public static clsMaintenanceTransaction Find(string PlateNumber)
        {

            int MaintenanceID = -1;
            int VehicleID = 0;
            int Mileage = 0;
            string Description = "";
            DateTime MaintenanceDate = DateTime.Now;
            double? Cost = null;
            Int16? ConsumedMileage = null;
            DateTime? ReturnDate = null;
            int? AmountSpentID = null;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            int TransferredByEmployeeID = 0;
            int? VehicleReturnByEmployeeID = null;
            Boolean IsCompleted = false;
            int? NewMileage = null;


            if (clsMaintenanceTransactionData.GetMaintenanceTransactionInfoByPlateNumber(PlateNumber, ref MaintenanceID, ref VehicleID, ref Mileage, ref Description, ref MaintenanceDate, ref Cost, ref ConsumedMileage, ref ReturnDate, ref AmountSpentID, ref CreatedByUserID, ref UpdatedByUserID, ref TransferredByEmployeeID, ref VehicleReturnByEmployeeID, ref IsCompleted,ref NewMileage))

                return new clsMaintenanceTransaction(MaintenanceID, VehicleID, Mileage, Description, MaintenanceDate, Cost, ReturnDate, AmountSpentID, CreatedByUserID, UpdatedByUserID, TransferredByEmployeeID, VehicleReturnByEmployeeID, IsCompleted, NewMileage);
            else
                return null;
        }
        public static bool isMaintenanceTransactionExist(int MaintenanceID)
        {
            return clsMaintenanceTransactionData.IsMaintenanceTransactionExist(MaintenanceID);
        }
        public static bool isMaintenanceTransactionExist(string PlateNumber)
        {
            return clsMaintenanceTransactionData.IsMaintenanceTransactionNewExistByPlateNumber(PlateNumber);
        }
        public static DataTable GetAllMaintenanceTransactions()
        {
            return clsMaintenanceTransactionData.GetAllMaintenanceTransactions();
        }
        public static DataTable GetAllMaintenanceTransactions(int BranchID)
        {
            return clsMaintenanceTransactionData.GetAllMaintenanceTransactions(BranchID);
        }
    }
}
