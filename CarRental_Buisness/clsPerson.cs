using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _PersonID;
        public int PersonID() { return _PersonID; }
        public string NationalNo { get;set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FullName { get {return FirstName + " " + SecondName + " " + LastName; } }
        public clsCountry CountryInfo;
        public Byte Gendor { get; set; }
        public int CityID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        private clsPerson(int PersonID,string NationalNo, string FirstName, string SecondName, string LastName, Byte Gendor, int CityID, DateTime DateOfBirth, string Email, string Phone, int NationalityCountryID, string ImagePath)
        {

            _PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.Gendor = Gendor;
            this.CityID = CityID;
            this.DateOfBirth = DateOfBirth;
            this.Email = Email;
            this.Phone = Phone;
            this.NationalityCountryID = NationalityCountryID;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }
        public clsPerson()

        {
            this._PersonID = -1;
            this.ImagePath = "";
            Mode = enMode.AddNew;
            
        }
        private bool _AddNewPerson()
        {
            this._PersonID = clsPersonData.AddNewPerson(NationalNo,FirstName, SecondName, LastName, Gendor, CityID, DateOfBirth, Email, Phone, NationalityCountryID, ImagePath);
            return _PersonID != 0;
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this._PersonID, NationalNo, FirstName, SecondName, LastName, Gendor, CityID, DateOfBirth, Email, Phone, NationalityCountryID, ImagePath);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdatePerson())
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
        public static clsPerson Find(int PersonID)
        {

            string NationalNo ="";
            string FirstName = "";
            string SecondName = "";
            string LastName = "";
            Byte Gendor = 0;
            int CityID = -1;
            DateTime DateOfBirth = DateTime.Now;
            string Email = "";
            string Phone = "";
            int NationalityCountryID = 0;
            string ImagePath = "";


            if (clsPersonData.GetPersonInfoByID(PersonID,ref NationalNo, ref FirstName, ref SecondName, ref LastName, ref Gendor, ref CityID, ref DateOfBirth, ref Email, ref Phone, ref NationalityCountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, LastName, Gendor, CityID, DateOfBirth, Email, Phone, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson Find(string Phone)
        {

            int PersonID = -1;
            string NationalNo ="";
            string FirstName = "";
            string SecondName = "";
            string LastName = "";
            Byte Gendor = 0;
            int CityID = -1;
            DateTime DateOfBirth = DateTime.Now;
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";


            if (clsPersonData.GetPersonInfoByPhoneNumber(ref PersonID,ref NationalNo ,ref FirstName, ref SecondName, ref LastName, ref Gendor, ref CityID, ref DateOfBirth, ref Email,  Phone, ref NationalityCountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, LastName, Gendor, CityID, DateOfBirth, Email, Phone, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static clsPerson FindByNationalNo(string NationalNo)
        {

            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string LastName = "";
            Byte Gendor = 0;
            int CityID = -1;
            DateTime DateOfBirth = DateTime.Now;
            string Email = "";
            string Phone = "";
            int NationalityCountryID = 0;
            string ImagePath = "";


            if (clsPersonData.GetPersonInfoByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref LastName, ref Gendor, ref CityID, ref DateOfBirth, ref Email,ref Phone, ref NationalityCountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, LastName, Gendor, CityID, DateOfBirth, Email, Phone, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public static bool isPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        public static bool Delete(int personid)
        {
            return clsPersonData.DeletePerson(personid);    
        }
    }
}
