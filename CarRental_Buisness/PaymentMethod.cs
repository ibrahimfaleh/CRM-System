using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsPaymentMethod
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _PaymentMethodID;
        public int PaymentMethodID {get{  return _PaymentMethodID; } }
        public string PaymentMethod { get; set; }
        public float PaymentFees { get; set; }
        private clsPaymentMethod(int PaymentMethodID, string PaymentMethod, float PaymentFees)
        {

            _PaymentMethodID = PaymentMethodID;

            this.PaymentMethod = PaymentMethod;
            this.PaymentFees = PaymentFees;
            Mode = enMode.Update;
        }
        public clsPaymentMethod()

        {
            this._PaymentMethodID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewPaymentMethod()
        {
            this._PaymentMethodID = clsPaymentMethodData.AddNewPaymentMethod(PaymentMethod, PaymentFees);
            return _PaymentMethodID != 0;
        }
        private bool _UpdatePaymentMethod()
        {
            return clsPaymentMethodData.UpdatePaymentMethod(this._PaymentMethodID, PaymentMethod, PaymentFees);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPaymentMethod())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdatePaymentMethod())
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
        public static clsPaymentMethod Find(int PaymentMethodID)
        {


            string PaymentMethod = "";
            float PaymentFees =0;


            if (clsPaymentMethodData.GetPaymentMethodInfoByID(PaymentMethodID, ref PaymentMethod, ref PaymentFees))

                return new clsPaymentMethod(PaymentMethodID, PaymentMethod, PaymentFees);
            else
                return null;
        }

        public static clsPaymentMethod Find(string PaymentMethodName)
        {
            int PaymentMethodID = 0;
            float PaymentFees = 0;


            if (clsPaymentMethodData.GetPaymentMethodInfoByPaymentMethod(ref PaymentMethodID, PaymentMethodName, ref PaymentFees))

                return new clsPaymentMethod(PaymentMethodID, PaymentMethodName, PaymentFees);
            else
                return null;
        }

        public static bool isPaymentMethodExist(int PaymentMethodID)
        {
            return clsPaymentMethodData.IsPaymentMethodExist(PaymentMethodID);
        }
        public static DataTable GetAllPaymentMethods()
        {
            return clsPaymentMethodData.GetAllPaymentMethods();
        }
    }
}
