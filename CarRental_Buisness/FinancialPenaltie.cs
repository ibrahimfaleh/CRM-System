using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsFinancialPenaltie
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _PenaltyID;
        public int PenaltyID { get { return _PenaltyID; } }
        public double Cost { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public int TypeID { get; set; }
        public int CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? AmountSpentID { get; set; }
        public string ImagePath { get; set; }
        public bool IsPaid { set; get; }
        private clsFinancialPenaltie(int PenaltyID, double Cost, string Details, DateTime Date, int TypeID, int CreatedByUserID, int? UpdatedByUserID, DateTime? UpdateDate, int? AmountSpentID, string ImagePath, bool isPaid)
        {

            _PenaltyID = PenaltyID;

            this.Cost = Cost;
            this.Details = Details;
            this.Date = Date;
            this.TypeID = TypeID;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            this.UpdateDate = UpdateDate;
            this.AmountSpentID = AmountSpentID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
            IsPaid = isPaid;
        }
        public clsFinancialPenaltie()

        {
            this._PenaltyID = -1;
            this.Cost = 0;
            this.Details = "";
            this.Date = DateTime.Now;
            this.TypeID = -1;
            this.CreatedByUserID = -1;
            this.UpdatedByUserID = null;
            this.UpdateDate = null;
            this.AmountSpentID = null;
            this.ImagePath = "";
            this.IsPaid = false;    
            Mode = enMode.AddNew;

        }
        private bool _AddNewFinancialPenaltie()
        {
            this._PenaltyID = clsFinancialPenaltieData.AddNewFinancialPenaltie(Cost, Details, Date, TypeID, CreatedByUserID, UpdatedByUserID, UpdateDate, AmountSpentID, ImagePath,IsPaid);
            return _PenaltyID != 0;
        }
        private bool _UpdateFinancialPenaltie()
        {
            return clsFinancialPenaltieData.UpdateFinancialPenaltie(this._PenaltyID, Cost, Details, Date, TypeID, CreatedByUserID, UpdatedByUserID, UpdateDate, AmountSpentID, ImagePath, IsPaid);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFinancialPenaltie())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateFinancialPenaltie())
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
        public static clsFinancialPenaltie Find(int PenaltyID)
        {


            double Cost = 0;
            string Details = "";
            DateTime Date = DateTime.Now;
            int TypeID = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime? UpdateDate = null;
            int? AmountSpentID = null;
            string ImagePath = "";
            bool IsPaid = false;

            if (clsFinancialPenaltieData.GetFinancialPenaltieInfoByID(PenaltyID, ref Cost, ref Details, ref Date, ref TypeID, ref CreatedByUserID, ref UpdatedByUserID, ref UpdateDate, ref AmountSpentID, ref ImagePath,ref IsPaid))

                return new clsFinancialPenaltie(PenaltyID, Cost, Details, Date, TypeID, CreatedByUserID, UpdatedByUserID, UpdateDate, AmountSpentID, ImagePath, IsPaid);
            else
                return null;
        }
        public static bool isFinancialPenaltieExist(int PenaltyID)
        {
            return clsFinancialPenaltieData.IsFinancialPenaltieExist(PenaltyID);
        }
        public static DataTable GetAllFinancialPenalties()
        {
            return clsFinancialPenaltieData.GetAllFinancialPenalties();
        }
    }
}
