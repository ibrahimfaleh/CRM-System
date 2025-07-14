using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsCustomer
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _CustomerID;
        public int CustomerID() { return _CustomerID; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public string DriverLicenseNumber { get; set; }
        public int CreatedBuUserID { set; get; }
        public short NumberRentedTransActions { private set; get; }
        public double InitialTotalDueAmountsAfterTax { private set; get; }
        public double PaidInitialTotalDueAmounts { private set; get; }
        public double TotalPayments { private set; get; }
        public double TotalRentPayments { private set; get; }
        public double TotalVehiclesBreakdownPayments { private set; get; }  
        public short TotalInitialRentalDays { private set; get; }
        public short TotalActualRentalDays { private set; get; }
        public int TotalKilometersConsumed { private set; get; }    

        private clsCustomer( int customerID, int personID, string driverLicenseNumber, 
            int createdBuUserID, short  nmberRentedTransActions, double initialTotalDueAmountsAfterTax, double paidInitialTotalDueAmounts,
            double totalPayments, double totalRentPayments, double totalVehiclesBreakdownPayments, short totalInitialRentalDays, short totalActualRentalDays, int totalKilometersConsumed)
        {
            Mode = enMode.Update;
            _CustomerID = customerID;
            PersonID = personID;
            DriverLicenseNumber = driverLicenseNumber;
            CreatedBuUserID = createdBuUserID;
            NumberRentedTransActions = nmberRentedTransActions;
            InitialTotalDueAmountsAfterTax = initialTotalDueAmountsAfterTax;
            PaidInitialTotalDueAmounts = paidInitialTotalDueAmounts;
            TotalPayments = totalPayments;
            TotalRentPayments = totalRentPayments;
            TotalVehiclesBreakdownPayments = totalVehiclesBreakdownPayments;
            TotalInitialRentalDays = totalInitialRentalDays;
            TotalActualRentalDays = totalActualRentalDays;
            TotalKilometersConsumed = totalKilometersConsumed;
            PersonInfo = clsPerson.Find(personID);
        }

        public clsCustomer()

        {
            this._CustomerID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewCustomer()
        {
            this._CustomerID = clsCustomerData.AddNewCustomer(PersonID, DriverLicenseNumber);
            return _CustomerID != -1;
        }
        private bool _UpdateCustomer()
        {
            return clsCustomerData.UpdateCustomer(this._CustomerID, PersonID, DriverLicenseNumber);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateCustomer())
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
        public static clsCustomer Find(int CustomerID)
        {


            int PersonID = 0;
            string DriverLicenseNumber = "";
            int CreatedByUserID = 0;
            short NumberRentedTransActions = 0;
            double InitialTotalDueAmountsAfterTax = 0;
            double PaidInitialTotalDueAmounts = 0;
            double TotalPayments = 0;
            double TotalRentPayments = 0;
            double TotalVehiclesBreakdownPayments = 0;
            short TotalInitialRentalDays = 0;
            short TotalActualRentalDays = 0;
            int TotalKilometersConsumed = 0;
            if (clsCustomerData.GetCustomerInfoByID( CustomerID, ref PersonID, ref DriverLicenseNumber, ref CreatedByUserID, ref NumberRentedTransActions, ref InitialTotalDueAmountsAfterTax,
                   ref PaidInitialTotalDueAmounts, ref TotalPayments, ref TotalRentPayments, ref TotalVehiclesBreakdownPayments,
                   ref TotalInitialRentalDays, ref TotalActualRentalDays, ref TotalKilometersConsumed))

                return new clsCustomer(CustomerID, PersonID, DriverLicenseNumber, CreatedByUserID, NumberRentedTransActions, InitialTotalDueAmountsAfterTax,
                    PaidInitialTotalDueAmounts, TotalPayments, TotalRentPayments, TotalVehiclesBreakdownPayments,
                    TotalInitialRentalDays, TotalActualRentalDays, TotalKilometersConsumed);
            else
                return null;
        }
        public static clsCustomer Find(string Phone)
        {
            clsPerson person = clsPerson.Find(Phone);
            if (person == null)
                return null;
            int CustomerID = -1;
            string DriverLicenseNumber = "";
            int CreatedByUserID = 0;
            short NumberRentedTransActions = 0;
            double InitialTotalDueAmountsAfterTax = 0;
            double PaidInitialTotalDueAmounts = 0;
            double TotalPayments = 0;
            double TotalRentPayments = 0;
            double TotalVehiclesBreakdownPayments = 0;
            short TotalInitialRentalDays = 0;
            short TotalActualRentalDays = 0;
            int TotalKilometersConsumed = 0;


            if (clsCustomerData.GetCustomerInfoByPersonID(ref CustomerID, person.PersonID(), ref DriverLicenseNumber,ref CreatedByUserID,ref NumberRentedTransActions,ref InitialTotalDueAmountsAfterTax,
                   ref PaidInitialTotalDueAmounts,ref TotalPayments,ref TotalRentPayments,ref TotalVehiclesBreakdownPayments,
                   ref TotalInitialRentalDays,ref TotalActualRentalDays,ref TotalKilometersConsumed))

                return new clsCustomer(CustomerID, person.PersonID(), DriverLicenseNumber,CreatedByUserID,NumberRentedTransActions,InitialTotalDueAmountsAfterTax,
                    PaidInitialTotalDueAmounts,TotalPayments,TotalRentPayments,TotalVehiclesBreakdownPayments,
                    TotalInitialRentalDays,TotalActualRentalDays,TotalKilometersConsumed);
            else
                return null;
        }
        public static bool isCustomerExist(int CustomerID)
        {
            return clsCustomerData.IsCustomerExist(CustomerID);
        }
        public static bool isCustomerExistForPersonID(int PersonID)
        {
           return clsCustomerData.isCustomerExistForPersonID(PersonID);
        }
        public static bool isDriverLicenseNumberExist(string DriverLicenseNumber)
        {
            return clsCustomerData.isDriverLicenseNumberExist(DriverLicenseNumber);
        }
        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomers();
        }
        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomerData.DeleteCustomer(CustomerID);
        }
    }
}
