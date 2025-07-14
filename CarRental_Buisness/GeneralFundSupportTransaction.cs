using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsGeneralFundSupportTransaction
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enPaymentDetails { Cash = 0, Transformation = 1 }
        public enPaymentDetails ePaymentDetails { get; set; }
        private int _FundSupportTransactionID;
        public int FundSupportTransactionID { get { return _FundSupportTransactionID; } }
        public double Amount { get; set; }
        public string Details { get; set; }
        public Byte PaymentDetails { get; set; }
        public DateTime Date { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int GeneralRevenueFundID { get; set; }
        public int CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        private clsGeneralFundSupportTransaction(int FundSupportTransactionID, double Amount, string Details, Byte PaymentDetails, DateTime Date, DateTime? UpdateDate, int GeneralRevenueFundID, int CreatedByUserID, int? UpdatedByUserID)
        {

            _FundSupportTransactionID = FundSupportTransactionID;

            this.Amount = Amount;
            this.Details = Details;
            this.ePaymentDetails =(enPaymentDetails)PaymentDetails;
            this.Date = Date;
            this.UpdateDate = UpdateDate;
            this.GeneralRevenueFundID = GeneralRevenueFundID;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            Mode = enMode.Update;
        }
        public clsGeneralFundSupportTransaction()

        {
            this._FundSupportTransactionID = -1;
            this.ePaymentDetails = enPaymentDetails.Transformation;
            Mode = enMode.AddNew;

        }
        private bool _AddNewGeneralFundSupportTransaction()
        {
            this._FundSupportTransactionID = clsGeneralFundSupportTransactionData.AddNewGeneralFundSupportTransaction(Amount, Details, (byte)ePaymentDetails, Date, UpdateDate, GeneralRevenueFundID, CreatedByUserID, UpdatedByUserID);
            return _FundSupportTransactionID != 0;
        }
        private bool _UpdateGeneralFundSupportTransaction()
        {
            return clsGeneralFundSupportTransactionData.UpdateGeneralFundSupportTransaction(this._FundSupportTransactionID, Amount, Details, (byte)ePaymentDetails, Date, UpdateDate, GeneralRevenueFundID, CreatedByUserID, UpdatedByUserID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGeneralFundSupportTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateGeneralFundSupportTransaction())
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
        public static clsGeneralFundSupportTransaction Find(int FundSupportTransactionID)
        {


            double Amount = 0;
            string Details = "";
            Byte PaymentDetails = 0;
            DateTime Date = DateTime.Now;
            DateTime? UpdateDate = null;
            int GeneralRevenueFundID = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;


            if (clsGeneralFundSupportTransactionData.GetGeneralFundSupportTransactionInfoByID(FundSupportTransactionID, ref Amount, ref Details, ref PaymentDetails, ref Date, ref UpdateDate, ref GeneralRevenueFundID, ref CreatedByUserID, ref UpdatedByUserID))

                return new clsGeneralFundSupportTransaction(FundSupportTransactionID, Amount, Details, PaymentDetails, Date, UpdateDate, GeneralRevenueFundID, CreatedByUserID, UpdatedByUserID);
            else
                return null;
        }
        public static bool isGeneralFundSupportTransactionExist(int FundSupportTransactionID)
        {
            return clsGeneralFundSupportTransactionData.IsGeneralFundSupportTransactionExist(FundSupportTransactionID);
        }
        public static DataTable GetAllGeneralFundSupportTransactions(int GeneralRevenueFundID)
        {
            return clsGeneralFundSupportTransactionData.GetAllGeneralFundSupportTransactions(GeneralRevenueFundID);
        }
    }
}
