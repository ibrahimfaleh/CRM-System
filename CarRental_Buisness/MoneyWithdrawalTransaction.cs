using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsMoneyWithdrawalTransaction
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _MoneyWithdrawalTransactionsID;
        public int MoneyWithdrawalTransactionsID { get { return _MoneyWithdrawalTransactionsID; } }
        public int AmountSpentID { get; set; }
        private clsMoneyWithdrawalTransaction(int MoneyWithdrawalTransactionsID, int AmountSpentID)
        {

            _MoneyWithdrawalTransactionsID = MoneyWithdrawalTransactionsID;

            this.AmountSpentID = AmountSpentID;
            Mode = enMode.Update;
        }
        public clsMoneyWithdrawalTransaction()

        {
            this._MoneyWithdrawalTransactionsID = -1;
            this.AmountSpentID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewMoneyWithdrawalTransaction()
        {
            this._MoneyWithdrawalTransactionsID = clsMoneyWithdrawalTransactionData.AddNewMoneyWithdrawalTransaction(AmountSpentID);
            return _MoneyWithdrawalTransactionsID != 0;
        }
        private bool _UpdateMoneyWithdrawalTransaction()
        {
            return clsMoneyWithdrawalTransactionData.UpdateMoneyWithdrawalTransaction(this._MoneyWithdrawalTransactionsID, AmountSpentID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMoneyWithdrawalTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateMoneyWithdrawalTransaction())
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
        public static clsMoneyWithdrawalTransaction Find(int MoneyWithdrawalTransactionsID)
        {


            int AmountSpentID = 0;


            if (clsMoneyWithdrawalTransactionData.GetMoneyWithdrawalTransactionInfoByID(MoneyWithdrawalTransactionsID, ref AmountSpentID))

                return new clsMoneyWithdrawalTransaction(MoneyWithdrawalTransactionsID, AmountSpentID);
            else
                return null;
        }
        public static bool isMoneyWithdrawalTransactionExist(int MoneyWithdrawalTransactionsID)
        {
            return clsMoneyWithdrawalTransactionData.IsMoneyWithdrawalTransactionExist(MoneyWithdrawalTransactionsID);
        }
        public static DataTable GetAllMoneyWithdrawalTransactions(int GeneralRevenueFundID)
        {
            return clsMoneyWithdrawalTransactionData.GetAllMoneyWithdrawalTransactions(GeneralRevenueFundID);
        }
    }
}
