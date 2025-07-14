using CarRental_DataAccess;
using System.Data;

namespace CarRental_Business
{
    public class clsDailyIncomeFundTransaction
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _DailyIncomeFundTransactionID;
        public int DailyIncomeFundTransactionID { get { return _DailyIncomeFundTransactionID; } }
        public int DailyIncomeFundID { get; set; }
        public int TransactionID { get; set; }
        private clsDailyIncomeFundTransaction(int DailyIncomeFundTransactionID, int DailyIncomeFundID, int TransactionID)
        {

            _DailyIncomeFundTransactionID = DailyIncomeFundTransactionID;

            this.DailyIncomeFundID = DailyIncomeFundID;
            this.TransactionID = TransactionID;
            Mode = enMode.Update;
        }
        public clsDailyIncomeFundTransaction()

        {
            this._DailyIncomeFundTransactionID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewDailyIncomeFundTransaction()
        {
            this._DailyIncomeFundTransactionID = clsDailyIncomeFundTransactionData.AddNewDailyIncomeFundTransaction(DailyIncomeFundID, TransactionID);
            return _DailyIncomeFundTransactionID != 0;
        }
        private bool _UpdateDailyIncomeFundTransaction()
        {
            return clsDailyIncomeFundTransactionData.UpdateDailyIncomeFundTransaction(this._DailyIncomeFundTransactionID, DailyIncomeFundID, TransactionID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDailyIncomeFundTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateDailyIncomeFundTransaction())
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
        public static clsDailyIncomeFundTransaction Find(int DailyIncomeFundTransactionID)
        {


            int DailyIncomeFundID = 0;
            int TransactionID = 0;


            if (clsDailyIncomeFundTransactionData.GetDailyIncomeFundTransactionInfoByID(DailyIncomeFundTransactionID, ref DailyIncomeFundID, ref TransactionID))
                return new clsDailyIncomeFundTransaction(DailyIncomeFundTransactionID, DailyIncomeFundID, TransactionID);

            return null;
        }
        public static bool isDailyIncomeFundTransactionExist(int DailyIncomeFundTransactionID)
        {
            return clsDailyIncomeFundTransactionData.IsDailyIncomeFundTransactionExist(DailyIncomeFundTransactionID);
        }
        public static DataTable GetAllDailyIncomeFundTransactions()
        {
            return clsDailyIncomeFundTransactionData.GetAllDailyIncomeFundTransactions();
        }
        public static DataTable GetAllDailyIncomeFundTransactions(int DailyIncomeFundID)
        {
            return clsDailyIncomeFundTransactionData.GetAllDailyIncomeFundTransactions(DailyIncomeFundID);
        }
    }
}
