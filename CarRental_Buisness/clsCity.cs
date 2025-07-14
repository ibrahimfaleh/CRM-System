using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsCity
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _CityID;
        public int CityID() { return _CityID; }
        public string CityName { get; set; }
        private clsCity(int CityID, string CityName)
        {

            _CityID = CityID;

            this.CityName = CityName;
            Mode = enMode.Update;
        }
        public clsCity()

        {
            this._CityID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewCity()
        {
            this._CityID = clsCityData.AddNewCity(CityName);
            return _CityID != 0;
        }
        private bool _UpdateCity()
        {
            return clsCityData.UpdateCity(this._CityID, CityName);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCity())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateCity())
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
        public static clsCity Find(int CityID)
        {


            string CityName = "";


            if (clsCityData.GetCityInfoByID(CityID, ref CityName))

                return new clsCity(CityID, CityName);
            else
                return null;
        }
        public static clsCity Find(string CityName)
        {


            int CityID = -1;


            if (clsCityData.GetCountryInfoByName(ref CityID,CityName))

                return new clsCity(CityID, CityName);
            else
                return null;
        }
        public static bool isCityExist(int CityID)
        {
            return clsCityData.IsCityExist(CityID);
        }
        public static DataTable GetAllCities()
        {
            return clsCityData.GetAllCities();
        }
    }
}
