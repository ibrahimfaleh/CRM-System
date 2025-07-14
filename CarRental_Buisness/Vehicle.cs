using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsVehicle
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _VehicleID;
        public int VehicleID { get { return _VehicleID; } }
        public int ModelID { get; set; }
        public clsMakeModel MakeModelInfo { private set; get; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int BodyID { get; set; }
        public clsBodie BodieInfo { get; private set; }
        public int DriveTypeID { get; set; }
        public clsDriveType DriveTypeInfo { private set; get; }
        public int FuelTypeID { get; set; }
        public clsFuleType FuelTypeInfo { private set; get; }
        public string PlateNumber { get; set; }
        public float RentalPricePerMileage { get; set; }
        public float RentalPricePerDay { get; set; }
        public float RentalPricePerHours { get; set; }
        public float RentalPricePerMonth { get; set; }
        public double RentalPricePerYear { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsAvailableForRental { get; set; }
        public string ImagePath { get; set; }
        public int CreatedByUserID { get; set; }
        public int? UpdateByUserID { get; set; }
        public Int16? NumberTimesRented { get; set; }
        public double? TotalRentalIncome { get; set; }
        public double? TotalMaintenanceFees { get; set; }
        public Int16? NumberTimesOfMaintenance { get; set; }
        public int BranchID { get; set; }
        public bool IsSold { get; set; }
        public int AmountSpentID { set; get; }
        public clsAmountSpent AmountSpentInfo { private set; get; } 
        private clsVehicle(int VehicleID, int ModelID, string Name, int Year, int Mileage, int BodyID, int DriveTypeID, int FuelTypeID, string PlateNumber, 
            float RentalPricePerMileage, float RentalPricePerDay, float RentalPricePerHours, float RentalPricePerMonth, double RentalPricePerYear, 
            Boolean IsActive, Boolean IsAvailableForRental, string ImagePath, int CreatedByUserID, int? UpdateByUserID, Int16? NumberTimesRented,
            double? TotalRentalIncome, double? TotalMaintenanceFees, Int16? NumberTimesOfMaintenance, int BranchID, bool IsSold, int amountSpentID)
        {

            _VehicleID = VehicleID;

            this.ModelID = ModelID;
            this.Name = Name;
            this.Year = Year;
            this.Mileage = Mileage;
            this.BodyID = BodyID;
            this.DriveTypeID = DriveTypeID;
            this.FuelTypeID = FuelTypeID;
            this.PlateNumber = PlateNumber;
            this.RentalPricePerMileage = RentalPricePerMileage;
            this.RentalPricePerDay = RentalPricePerDay;
            this.RentalPricePerHours = RentalPricePerHours;
            this.RentalPricePerMonth = RentalPricePerMonth;
            this.RentalPricePerYear = RentalPricePerYear;
            this.IsActive = IsActive;
            this.IsAvailableForRental = IsAvailableForRental;
            this.ImagePath = ImagePath;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdateByUserID = UpdateByUserID;
            this.NumberTimesRented = NumberTimesRented;
            this.TotalRentalIncome = TotalRentalIncome;
            this.TotalMaintenanceFees = TotalMaintenanceFees;
            this.NumberTimesOfMaintenance = NumberTimesOfMaintenance;
            this.BranchID = BranchID;
            this.IsSold = IsSold;
            this.FuelTypeInfo = clsFuleType.Find(FuelTypeID);
            this.BodieInfo = clsBodie.Find(BodyID);
            this.DriveTypeInfo = clsDriveType.Find(DriveTypeID);
            this.MakeModelInfo = clsMakeModel.Find(ModelID);
            this.AmountSpentInfo = clsAmountSpent.Find(amountSpentID);
            Mode = enMode.Update;
            AmountSpentID = amountSpentID;
        }
        public clsVehicle()

        {
            this._VehicleID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewVehicle()
        {
            this._VehicleID = clsVehicleData.AddNewVehicle(ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, 
                RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental,
                ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance,
                BranchID, IsSold, AmountSpentID);
            return _VehicleID != 0;
        }
        private bool _UpdateVehicle()
        {
            return clsVehicleData.UpdateVehicle(this._VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber,
                RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive,
                IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, 
                TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold
                , AmountSpentID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicle())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateVehicle())
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
        public static clsVehicle Find(int VehicleID)
        {


            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            string PlateNumber = "";
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            Boolean IsAvailableForRental = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            int BranchID = 0;
            bool IsSold = false;
            int AmountSpentID = 0;

            if (clsVehicleData.GetVehicleInfoByID(VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID, ref PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive, ref IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance, ref BranchID,ref IsSold,ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold,AmountSpentID);
            else
                return null;
        }
        public static clsVehicle Find(int VehicleID,bool IsAvailableForRental)
        {


            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            string PlateNumber = "";
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            int BranchID = 0;
            bool IsSold = false;
            int AmountSpentID = 0;

            if (clsVehicleData.GetVehicleInfoByID(VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID, ref PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive, IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance, ref BranchID, ref IsSold, ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold, AmountSpentID);
            else
                return null;
        }
        public static clsVehicle Find(int VehicleID,int BranchID)
        {


            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            string PlateNumber = "";
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            Boolean IsAvailableForRental = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            bool IsSold = false;
            int AmountSpentID = 0;

            if (clsVehicleData.GetVehicleInfoByID(VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID,ref  PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive, ref IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance, BranchID, ref IsSold, ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold, AmountSpentID);
            else
                return null;
        }
        public static clsVehicle Find(int VehicleID, int BranchID,bool IsAvailableForRental)
        {


            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            string PlateNumber = "";
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            bool IsSold = false;
            int AmountSpentID = 0;

            if (clsVehicleData.GetVehicleInfoByID(VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID, ref PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive,  IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance,  BranchID, ref IsSold, ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold, AmountSpentID);
            else
                return null;
        }
        public static clsVehicle Find(string PlateNumber)
        {

            int VehicleID=-1;
            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            Boolean IsAvailableForRental = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            bool IsSold = false;
            int AmountSpentID = 0;
            int BranchID = -1;

            if (clsVehicleData.GetVehicleInfoByPlateNumber(ref VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID,  PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive, ref IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance, ref BranchID,ref IsSold,ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold, AmountSpentID);
            else
                return null;
        }






        public static clsVehicle Find(string PlateNumber, bool IsAvailableForRental)
        {
            int VehicleID = 0;
            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            int BranchID = 0;
            bool IsSold = false;
            int AmountSpentID = 0;

            if (clsVehicleData.GetVehicleInfoByID(ref VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID,  PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive, IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance, ref BranchID, ref IsSold, ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold, AmountSpentID);
            else
                return null;
        }
        public static clsVehicle Find(string PlateNumber, int BranchID)
        {

            int VehicleID = 0;
            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            Boolean IsAvailableForRental = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            bool IsSold = false;
            int AmountSpentID = 0;

            if (clsVehicleData.GetVehicleInfoByID(ref VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID,  PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive, ref IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance, BranchID, ref IsSold, ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold, AmountSpentID);
            else
                return null;
        }
        public static clsVehicle Find( string PlateNumber, int BranchID, bool IsAvailableForRental)
        {


            int ModelID = 0;
            string Name = "";
            int Year = 0;
            int Mileage = 0;
            int BodyID = 0;
            int DriveTypeID = 0;
            int FuelTypeID = 0;
            int VehicleID = 0;
            float RentalPricePerMileage = 0;
            float RentalPricePerDay = 0;
            float RentalPricePerHours = 0;
            float RentalPricePerMonth = 0;
            double RentalPricePerYear = 0;
            Boolean IsActive = false;
            string ImagePath = "";
            int CreatedByUserID = 0;
            int? UpdateByUserID = null;
            Int16? NumberTimesRented = null;
            double? TotalRentalIncome = null;
            double? TotalMaintenanceFees = null;
            Int16? NumberTimesOfMaintenance = null;
            bool IsSold = false;
            int AmountSpentID = 0;

            if (clsVehicleData.GetVehicleInfoByID(ref VehicleID, ref ModelID, ref Name, ref Year, ref Mileage, ref BodyID, ref DriveTypeID, ref FuelTypeID,  PlateNumber, ref RentalPricePerMileage, ref RentalPricePerDay, ref RentalPricePerHours, ref RentalPricePerMonth, ref RentalPricePerYear, ref IsActive, IsAvailableForRental, ref ImagePath, ref CreatedByUserID, ref UpdateByUserID, ref NumberTimesRented, ref TotalRentalIncome, ref TotalMaintenanceFees, ref NumberTimesOfMaintenance, BranchID, ref IsSold, ref AmountSpentID))

                return new clsVehicle(VehicleID, ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID, IsSold, AmountSpentID);
            else
                return null;
        }




        public static bool isVehicleExist(int VehicleID)
        {
            return clsVehicleData.IsVehicleExist(VehicleID);
        }
        public static bool isVehicleExist(string PlateNumber)
        {
            return clsVehicleData.IsVehicleExist(PlateNumber);
        }
        public static DataTable GetAllVehicles()
        {
            return clsVehicleData.GetAllVehicles();
        }
        public static DataTable GetAllVehicles(int BranchID)
        {
            return clsVehicleData.GetAllVehicles(BranchID);
        }
        public static DataTable GetAllVehiclesForSelect(int BranchID)
        {
            return clsVehicleData.GetAllVehiclesForSelect(BranchID);
        }

        public static DataTable GetAllVehiclesForSelect(bool IsAvailableForRental)
        {
            return clsVehicleData.GetAllVehiclesForSelect(IsAvailableForRental);
        }

        public static DataTable GetAllVehiclesForSelect(int BranchID ,bool IsAvailableForRental)
        {
            return clsVehicleData.GetAllVehiclesForSelect(BranchID,IsAvailableForRental);
        }
        public static DataTable GetAllVehiclesForSelect()
        {
            return clsVehicleData.GetAllVehiclesForSelect();
        }
    }
}
