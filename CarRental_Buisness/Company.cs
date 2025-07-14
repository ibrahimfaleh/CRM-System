using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsCompany
    {
        private int _CompanyID;
        public int CompanyID { get { return _CompanyID; } }
        public string Name { get; set; }
        public string Email { get; set; }
        public string LogoPath { get; set; }
        private clsCompany(int CompanyID, string Name, string Email, string LogoPath)
        {

            _CompanyID = CompanyID;

            this.Name = Name;
            this.Email = Email;
            this.LogoPath = LogoPath;
        }
        private bool _UpdateCompany()
        {
            return clsCompanyData.UpdateCompany(Name, Email, LogoPath);
        }
        public bool Save()
        {
            return _UpdateCompany();    
        }
        public static clsCompany GetCompanyInfo()
        {
            int CompanyID = 0;  
            string Name = "";
            string Email = "";
            string LogoPath = "";
            if (clsCompanyData.GetCompanyInfo(ref CompanyID, ref Name, ref Email, ref LogoPath))

                return new clsCompany(CompanyID, Name, Email, LogoPath);
            else
                return null;
        }
    }
}
