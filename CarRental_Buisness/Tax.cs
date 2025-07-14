using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{

    public class clsTax 
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _TaxID;
        public int TaxID() { return _TaxID; }
        public float Vat { get; set; }
        public string TaxDetails { get; set; }
        private clsTax(int TaxID, float Tax, string TaxDetails)
        {

            _TaxID = TaxID;

            this.Vat = Tax;
            this.TaxDetails = TaxDetails;
            Mode = enMode.Update;
        }
        public clsTax()

        {
            this._TaxID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewTax()
        {
            this._TaxID = clsTaxData.AddNewTax(Vat, TaxDetails);
            return _TaxID != 0;
        }
        private bool _UpdateTax()
        {
            return clsTaxData.UpdateTax(this._TaxID, Vat, TaxDetails);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTax())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateTax())
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
        public static clsTax GetVat()
        {

            int TaxID = -1;
            float Tax = 0;
            string TaxDetails = "";


            if (clsTaxData.GetVat(ref TaxID, ref Tax, ref TaxDetails))

                return new clsTax(TaxID, Tax, TaxDetails);
            else
                return null;
        }
        public static bool isTaxExist(int TaxID)
        {
            return clsTaxData.IsTaxExist(TaxID);
        }
        public static DataTable GetAllTaxes()
        {
            return clsTaxData.GetAllTaxes();
        }
    }
}
