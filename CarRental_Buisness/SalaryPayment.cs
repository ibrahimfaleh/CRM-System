using CarRental_DataAccess;
using System.Data;
using System.Threading;

namespace CarRental_Business
{
    public class clsSalaryPayment
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _SalaryPaymentID;
        public int SalaryPaymentID { get { return _SalaryPaymentID; } }
        public int AmountSpentID { get; set; }
        private clsSalaryPayment(int SalaryPaymentID, int AmountSpentID)
        {

            _SalaryPaymentID = SalaryPaymentID;

            this.AmountSpentID = AmountSpentID;
            Mode = enMode.Update;
        }
        public clsSalaryPayment()

        {
            this._SalaryPaymentID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewSalaryPayment()
        {
            this._SalaryPaymentID = clsSalaryPaymentData.AddNewSalaryPayment(AmountSpentID);
            return _SalaryPaymentID != 0;
        }
        private bool _UpdateSalaryPayment()
        {
            return clsSalaryPaymentData.UpdateSalaryPayment(this._SalaryPaymentID, AmountSpentID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSalaryPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateSalaryPayment())
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
        public static clsSalaryPayment Find(int SalaryPaymentID)
        {


            int AmountSpentID = 0;


            if (clsSalaryPaymentData.GetSalaryPaymentInfoByID(SalaryPaymentID, ref AmountSpentID))

                return new clsSalaryPayment(SalaryPaymentID, AmountSpentID);
            else
                return null;
        }
        public static bool isSalaryPaymentExist(int SalaryPaymentID)
        {
            return clsSalaryPaymentData.IsSalaryPaymentExist(SalaryPaymentID);
        }


        public static DataTable GetAllSalariesPaid(int BranchID)
        {
            return clsSalaryPaymentData.GetAllSalariesPaid(BranchID);
        }
        public static DataTable GetAllSalariesPaid()
        {
            return clsSalaryPaymentData.GetAllSalariesPaid();
        }
        public static DataTable GetAllSalariesPaidForEmployeeID(int EmployeeID)
        {
            return clsSalaryPaymentData.GetAllSalariesPaidForEmployeeID(EmployeeID);
        }


        public static DataTable GetAllEmployeeSalaries()
        {
            return clsSalaryPaymentData.GetAllEmployeeSalaries();
        }
        public static DataTable GetAllEmployeeSalaries(int BranchID)
        {
            return clsSalaryPaymentData.GetAllEmployeeSalaries(BranchID);
        }


        public static bool PaymentOfSalaries(DataTable dtEmployeeSalaries,int GeneralRevenueFundID,int CreatedByUserID,byte PaymentDetails)
        {
            return clsSalaryPaymentData.PaymentOfSalaries(dtEmployeeSalaries, GeneralRevenueFundID,CreatedByUserID, PaymentDetails);
        }
    }
}
