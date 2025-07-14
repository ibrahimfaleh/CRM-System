using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsBill
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _BillID;
        public int BillID { get { return _BillID; } }
        public int TypeID { get; set; }
        public int BranchID { get; set; }
        public double Cost { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImagePath { get; set; }
        public Boolean IsPaid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public Boolean IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdatedDate { get; set; }
        private clsBill(int BillID, int TypeID, int BranchID, double Cost, string Details, DateTime CreatedDate, string ImagePath, Boolean IsPaid, DateTime? PaymentDate, Boolean IsActive, int CreatedByUserID, int? UpdatedByUserID, DateTime? UpdatedDate)
        {

            _BillID = BillID;

            this.TypeID = TypeID;
            this.BranchID = BranchID;
            this.Cost = Cost;
            this.Details = Details;
            this.CreatedDate = CreatedDate;
            this.ImagePath = ImagePath;
            this.IsPaid = IsPaid;
            this.PaymentDate = PaymentDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            this.UpdatedDate = UpdatedDate;
            Mode = enMode.Update;
        }
        public clsBill()

        {
            this._BillID = -1;
            this.TypeID = -1;
            this.BranchID = -1;
            this.Cost = 0;
            this.Details = string.Empty;
            this.CreatedDate = DateTime.Now;
            this.ImagePath = string.Empty;
            this.IsPaid = false;
            this.PaymentDate = null;
            this.IsActive = true;
            this.CreatedByUserID = -1;
            this.UpdatedByUserID = null;
            this.UpdatedDate = null;
            Mode = enMode.AddNew;

        }
        private bool _AddNewBill()
        {
            this._BillID = clsBillData.AddNewBill(TypeID, BranchID, Cost, Details, CreatedDate, ImagePath, IsPaid, PaymentDate, IsActive, CreatedByUserID, UpdatedByUserID, UpdatedDate);
            return _BillID != -1;
        }
        private bool _UpdateBill()
        {
            return clsBillData.UpdateBill(this._BillID, TypeID, BranchID, Cost, Details, CreatedDate, ImagePath, IsPaid, PaymentDate, IsActive, CreatedByUserID, UpdatedByUserID, UpdatedDate);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBill())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateBill())
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
        public static clsBill Find(int BillID)
        {


            int TypeID = 0;
            int BranchID = 0;
            double Cost = 0;
            string Details = "";
            DateTime CreatedDate = DateTime.Now;
            string ImagePath = "";
            Boolean IsPaid = false;
            DateTime? PaymentDate = null;
            Boolean IsActive = false;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime? UpdatedDate = null;


            if (clsBillData.GetBillInfoByID(BillID, ref TypeID, ref BranchID, ref Cost, ref Details, ref CreatedDate, ref ImagePath, ref IsPaid, ref PaymentDate, ref IsActive, ref CreatedByUserID, ref UpdatedByUserID, ref UpdatedDate))

                return new clsBill(BillID, TypeID, BranchID, Cost, Details, CreatedDate, ImagePath, IsPaid, PaymentDate, IsActive, CreatedByUserID, UpdatedByUserID, UpdatedDate);
            else
                return null;
        }
        public static clsBill Find(int BillID,int BranchID)
        {


            int TypeID = 0;
            double Cost = 0;
            string Details = "";
            DateTime CreatedDate = DateTime.Now;
            string ImagePath = "";
            Boolean IsPaid = false;
            DateTime? PaymentDate = null;
            Boolean IsActive = false;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime? UpdatedDate = null;


            if (clsBillData.GetBillInfoByIDAndBranchID(BillID, ref TypeID,  BranchID, ref Cost, ref Details, ref CreatedDate, ref ImagePath, ref IsPaid, ref PaymentDate, ref IsActive, ref CreatedByUserID, ref UpdatedByUserID, ref UpdatedDate))

                return new clsBill(BillID, TypeID, BranchID, Cost, Details, CreatedDate, ImagePath, IsPaid, PaymentDate, IsActive, CreatedByUserID, UpdatedByUserID, UpdatedDate);
            else
                return null;
        }
        public static bool isBillExist(int BillID)
        {
            return clsBillData.IsBillExist(BillID);
        }
        public static DataTable GetAllBills()
        {
            return clsBillData.GetAllBills();
        }
        public static DataTable GetAllBills(int BranchID)
        {
            return clsBillData.GetAllBills(BranchID);
        }
    }
}
