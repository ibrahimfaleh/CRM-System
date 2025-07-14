using System;
using System.Configuration;

namespace CarRental_DataAccess
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        //clsDataAccessSettings.ConnectionString
    }
}
