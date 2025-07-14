using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsGeneralFundBill
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _TransactionID;
        public int TransactionID { get { return _TransactionID; } }
        public int BillID { get; set; }
        public int? AmountSpentID { get; set; }
        private clsGeneralFundBill(int TransactionID, int BillID, int? AmountSpentID)
        {

            _TransactionID = TransactionID;

            this.BillID = BillID;
            this.AmountSpentID = AmountSpentID;
            Mode = enMode.Update;
        }
        public clsGeneralFundBill()

        {
            this._TransactionID = -1;
            this.AmountSpentID = null;   
            Mode = enMode.AddNew;

        }
        private bool _AddNewGeneralFundBill()
        {
            this._TransactionID = clsGeneralFundBillData.AddNewGeneralFundBill(BillID, AmountSpentID);
            return _TransactionID != -1;
        }
        private bool _UpdateGeneralFundBill()
        {
            return clsGeneralFundBillData.UpdateGeneralFundBill(this._TransactionID, BillID, AmountSpentID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGeneralFundBill())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateGeneralFundBill())
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
        public static clsGeneralFundBill Find(int TransactionID)
        {


            int BillID = 0;
            int? AmountSpentID = null;


            if (clsGeneralFundBillData.GetGeneralFundBillInfoByID(TransactionID, ref BillID, ref AmountSpentID))

                return new clsGeneralFundBill(TransactionID, BillID, AmountSpentID);
            else
                return null;
        }
        public static bool isGeneralFundBillExist(int TransactionID)
        {
            return clsGeneralFundBillData.IsGeneralFundBillExist(TransactionID);
        }
        public static bool isGeneralFundBillExistByBillID(int BillID)
        {
            return clsGeneralFundBillData.IsGeneralFundBillExistByBillID(BillID);
        }
        public static DataTable GetAllGeneralFundBills()
        {
            return clsGeneralFundBillData.GetAllGeneralFundBills();
        }
        public static bool DeleteGeneralFundBill(int Transaction)
        {
            return clsGeneralFundBillData.DeleteGeneralFundBill(Transaction);
        }
    }
}
