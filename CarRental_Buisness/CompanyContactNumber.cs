using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsCompanyContactNumber
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enType { Phone = 1, Telephone = 2, Fax = 3 }
        public string GetTypeName
        {
            get
            {
                if (Type == (byte)enType.Telephone)
                    return "Telephone";
                if (Type == (byte)enType.Phone)
                    return "Phone";
                return "Fax";
            }
        }
        private int _ContactNumberID;
        public int ContactNumberID { get { return _ContactNumberID; } }
        public int CompanyID { get; set; }
        public string Number { get; set; }
        public Byte Type { get; set; }
        private clsCompanyContactNumber(int ContactNumberID, int CompanyID, string Number, Byte Type)
        {

            _ContactNumberID = ContactNumberID;

            this.CompanyID = CompanyID;
            this.Number = Number;
            this.Type = Type;
            Mode = enMode.Update;
        }
        public clsCompanyContactNumber()

        {
            this._ContactNumberID = -1;
            this.CompanyID = -1;
            this.Number = "";
            this.Type = 1;
            Mode = enMode.AddNew;

        }
        private bool _AddNewCompanyContactNumber()
        {
            this._ContactNumberID = clsCompanyContactNumberData.AddNewCompanyContactNumber(CompanyID, Number, Type);
            return _ContactNumberID != 0;
        }
        private bool _UpdateCompanyContactNumber()
        {
            return clsCompanyContactNumberData.UpdateCompanyContactNumber(this._ContactNumberID, CompanyID, Number, Type);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCompanyContactNumber())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateCompanyContactNumber())
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
        public static clsCompanyContactNumber Find(int ContactNumberID)
        {


            int CompanyID = 0;
            string Number = "";
            Byte Type = 0;


            if (clsCompanyContactNumberData.GetCompanyContactNumberInfoByID(ContactNumberID, ref CompanyID, ref Number, ref Type))

                return new clsCompanyContactNumber(ContactNumberID, CompanyID, Number, Type);
            else
                return null;
        }
        public static bool isCompanyContactNumberExist(int ContactNumberID)
        {
            return clsCompanyContactNumberData.IsCompanyContactNumberExist(ContactNumberID);
        }
        public static DataTable GetAllCompanyContactNumbers()
        {
            return clsCompanyContactNumberData.GetAllCompanyContactNumbers();
        }
        public static bool DeleteCompanyContactNumber(int ContactID)
        {
            return clsCompanyContactNumberData.DeleteCompanyContactNumber(ContactID);
        }
    }
}
