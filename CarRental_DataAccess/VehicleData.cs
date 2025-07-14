using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsVehicleData
    {
        // Implemention AddNew
        public static int AddNewVehicle(int ModelID, string Name, int Year, int Mileage, int BodyID, int DriveTypeID,
            int FuelTypeID, string PlateNumber, float RentalPricePerMileage, float RentalPricePerDay, float RentalPricePerHours,
            float RentalPricePerMonth, double RentalPricePerYear, Boolean IsActive, Boolean IsAvailableForRental,
            string ImagePath, int CreatedByUserID, int? UpdateByUserID, Int16? NumberTimesRented, double? TotalRentalIncome,
            double? TotalMaintenanceFees, Int16? NumberTimesOfMaintenance, int BranchID, bool IsSold, int AmountSpentID)
        {
            int VehicleID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Vehicles ( ModelID, Name, Year, Mileage, BodyID, DriveTypeID, FuelTypeID, PlateNumber, RentalPricePerMileage, RentalPricePerDay, RentalPricePerHours, RentalPricePerMonth, RentalPricePerYear, IsActive, IsAvailableForRental, ImagePath, CreatedByUserID, UpdateByUserID, NumberTimesRented, TotalRentalIncome, TotalMaintenanceFees, NumberTimesOfMaintenance, BranchID,AmountSpentID,IsSold)
                             VALUES ( @ModelID, @Name, @Year, @Mileage, @BodyID, @DriveTypeID, @FuelTypeID, @PlateNumber, @RentalPricePerMileage, @RentalPricePerDay, @RentalPricePerHours, @RentalPricePerMonth, @RentalPricePerYear, @IsActive, @IsAvailableForRental, @ImagePath, @CreatedByUserID, @UpdateByUserID, @NumberTimesRented, @TotalRentalIncome, @TotalMaintenanceFees, @NumberTimesOfMaintenance, @BranchID,@AmountSpentID,@IsSold);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ModelID", ModelID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@BodyID", BodyID);
            command.Parameters.AddWithValue("@DriveTypeID", DriveTypeID);
            command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            command.Parameters.AddWithValue("@RentalPricePerMileage", RentalPricePerMileage);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@RentalPricePerHours", RentalPricePerHours);
            command.Parameters.AddWithValue("@RentalPricePerMonth", RentalPricePerMonth);
            command.Parameters.AddWithValue("@RentalPricePerYear", RentalPricePerYear);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRental);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdateByUserID", (object)UpdateByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@NumberTimesRented", (object)NumberTimesRented ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalRentalIncome", (object)TotalRentalIncome ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalMaintenanceFees", (object)TotalMaintenanceFees ?? DBNull.Value);
            command.Parameters.AddWithValue("@NumberTimesOfMaintenance", (object)NumberTimesOfMaintenance ?? DBNull.Value);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
            command.Parameters.AddWithValue("@IsSold", IsSold);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    VehicleID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return VehicleID;
        }
        // Implemention GetByID

        public static bool GetVehicleInfoByID(ref int VehicleID, ref int ModelID, ref string Name, ref int Year,
ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
ref float RentalPricePerHours, ref float RentalPricePerMonth,
ref double RentalPricePerYear, ref Boolean IsActive,
 Boolean IsAvailableForRentalFor, ref string ImagePath, ref int CreatedByUserID,
ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, int BranchID,
ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE  VehicleID = @VehicleID and plateNumber=@plateNumber And IsAvailableForRental=@IsAvailableForRental And BranchID=@BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@plateNumber", PlateNumber);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRentalFor);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    BranchID = (int)reader["BranchID"];
                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetVehicleInfoByID(ref int VehicleID, ref int ModelID, ref string Name, ref int Year,
ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
 string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
ref float RentalPricePerHours, ref float RentalPricePerMonth,
ref double RentalPricePerYear, ref Boolean IsActive,
 Boolean IsAvailableForRental, ref string ImagePath, ref int CreatedByUserID,
ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, ref int BranchID,
ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE  VehicleID = @VehicleID and plateNumber=@plateNumber And IsAvailableForRental=@IsAvailableForRental";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@plateNumber", PlateNumber);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRental);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    BranchID = (int)reader["BranchID"];
                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetVehicleInfoByID(ref int VehicleID, ref int ModelID, ref string Name, ref int Year,
ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
 string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
ref float RentalPricePerHours, ref float RentalPricePerMonth,
ref double RentalPricePerYear, ref Boolean IsActive,
ref Boolean IsAvailableForRental, ref string ImagePath, ref int CreatedByUserID,
ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, int BranchID,
ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE  VehicleID = @VehicleID and plateNumber=@plateNumber And BranchID=@BranchID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@plateNumber", PlateNumber);
            command.Parameters.AddWithValue("@plateNumber", BranchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    IsAvailableForRental = (Boolean)reader["IsAvailableForRental"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    BranchID = (int)reader["BranchID"];
                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetVehicleInfoByID(int VehicleID, ref int ModelID, ref string Name, ref int Year,
ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
ref string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
ref float RentalPricePerHours, ref float RentalPricePerMonth,
ref double RentalPricePerYear, ref Boolean IsActive,
ref Boolean IsAvailableForRental, ref string ImagePath, ref int CreatedByUserID,
ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, ref int BranchID,
ref bool IsSold, ref int AmountSpentID, int branchID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE  VehicleID = @VehicleID and branchID=@branchID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@branchID", branchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    IsAvailableForRental = (Boolean)reader["IsAvailableForRental"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    BranchID = (int)reader["BranchID"];
                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }









        public static bool GetVehicleInfoByID(int VehicleID, ref int ModelID, ref string Name, ref int Year,
    ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
    ref string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
    ref float RentalPricePerHours, ref float RentalPricePerMonth,
    ref double RentalPricePerYear, ref Boolean IsActive,
     Boolean IsAvailableForRental, ref string ImagePath, ref int CreatedByUserID,
    ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

    ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, int BranchID,
    ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE  VehicleID = @VehicleID and branchID=@branchID and IsAvailableForRental=@IsAvailableForRental";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@branchID", BranchID);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRental);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }








        public static bool GetVehicleInfoByID(int VehicleID, ref int ModelID, ref string Name, ref int Year,
    ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
    ref string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
    ref float RentalPricePerHours, ref float RentalPricePerMonth,
    ref double RentalPricePerYear, ref Boolean IsActive,
     ref Boolean IsAvailableForRental, ref string ImagePath, ref int CreatedByUserID,
    ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

    ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, int BranchID,
    ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE  VehicleID = @VehicleID and branchID=@branchID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@branchID", BranchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsAvailableForRental = (bool)reader["IsAvailableForRental"];
                    IsActive = (Boolean)reader["IsActive"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }







        public static bool GetVehicleInfoByID(int VehicleID, ref int ModelID, ref string Name, ref int Year,
    ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
    ref string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
    ref float RentalPricePerHours, ref float RentalPricePerMonth,
    ref double RentalPricePerYear, ref Boolean IsActive,
    ref Boolean IsAvailableForRental, ref string ImagePath, ref int CreatedByUserID,
    ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

    ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, ref int BranchID,
    ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE VehicleID = @VehicleID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    IsAvailableForRental = (Boolean)reader["IsAvailableForRental"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    BranchID = (int)reader["BranchID"];
                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetVehicleInfoByID(int VehicleID, ref int ModelID, ref string Name, ref int Year,
            ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID,
            ref string PlateNumber, ref float RentalPricePerMileage, ref float RentalPricePerDay,
            ref float RentalPricePerHours, ref float RentalPricePerMonth,
            ref double RentalPricePerYear, ref Boolean IsActive,
             Boolean IsAvailableForRental, ref string ImagePath, ref int CreatedByUserID,
            ref int? UpdateByUserID, ref Int16? NumberTimesRented, ref double? TotalRentalIncome,

            ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance, ref int BranchID,
            ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE VehicleID = @VehicleID and IsAvailableForRental=@IsAvailableForRental";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRental);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    if (reader["ImagePath"] != DBNull.Value)
                                            if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    BranchID = (int)reader["BranchID"];
                    IsSold = (bool)reader["IsSold"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetVehicleInfoByPlateNumber(ref int VehicleID, ref int ModelID, ref string Name, ref int Year,
            ref int Mileage, ref int BodyID, ref int DriveTypeID, ref int FuelTypeID, string PlateNumber, ref float RentalPricePerMileage,
            ref float RentalPricePerDay, ref float RentalPricePerHours, ref float RentalPricePerMonth,
            ref double RentalPricePerYear, ref Boolean IsActive, ref Boolean IsAvailableForRental,
            ref string ImagePath, ref int CreatedByUserID, ref int? UpdateByUserID, ref Int16? NumberTimesRented,
            ref double? TotalRentalIncome, ref double? TotalMaintenanceFees, ref Int16? NumberTimesOfMaintenance,
            ref int BranchID, ref bool IsSold, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE PlateNumber = @PlateNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    VehicleID = (int)reader["VehicleID"];
                    ModelID = (int)reader["ModelID"];
                    Name = (string)reader["Name"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    BodyID = (int)reader["BodyID"];
                    DriveTypeID = (int)reader["DriveTypeID"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    RentalPricePerMileage = float.Parse(reader["RentalPricePerMileage"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerYear = double.Parse(reader["RentalPricePerYear"].ToString());
                    IsActive = (Boolean)reader["IsActive"];
                    IsAvailableForRental = (Boolean)reader["IsAvailableForRental"];
                     if (reader["ImagePath"] != DBNull.Value) ImagePath = (string)reader["ImagePath"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdateByUserID"] != DBNull.Value)
                        UpdateByUserID = (int?)reader["UpdateByUserID"];
                    if (reader["NumberTimesRented"] != DBNull.Value)
                        NumberTimesRented = (Int16?)reader["NumberTimesRented"];
                    if (reader["TotalRentalIncome"] != DBNull.Value)
                        TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());

                    if (reader["TotalMaintenanceFees"] != DBNull.Value)
                        TotalMaintenanceFees = double.Parse(reader["TotalMaintenanceFees"].ToString());

                    if (reader["NumberTimesOfMaintenance"] != DBNull.Value)
                        NumberTimesOfMaintenance = (Int16?)reader["NumberTimesOfMaintenance"];

                    BranchID = (int)reader["BranchID"];
                    AmountSpentID = (int)reader["AmountSpentID"];
                    IsSold = (bool)reader["IsSold"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        // Implemention IsExist

        public static bool IsVehicleExist(int VehicleID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Vehicles WHERE VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsVehicleExist(string PlateNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Vehicles WHERE PlateNumber = @PlateNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        // Implemention GetAllDataTablw 
        public static DataTable GetAllVehiclesForSelect()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select VehicleID ,name,year, Mileage,RentalPricePerDay,RentalPricePerMonth from Vehicles";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static DataTable GetAllVehiclesForSelect(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select VehicleID ,name,year, Mileage,RentalPricePerDay,RentalPricePerMonth from Vehicles where BranchID=@BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static DataTable GetAllVehiclesForSelect(bool IsAvailableForRental)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select VehicleID ,name,year, Mileage,RentalPricePerDay,RentalPricePerMonth from Vehicles where IsAvailableForRental=@IsAvailableForRental";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRental);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static DataTable GetAllVehiclesForSelect(int BranchID,bool IsAvailableForRental)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select VehicleID ,name,year, Mileage,RentalPricePerDay,RentalPricePerMonth from Vehicles where IsAvailableForRental=@IsAvailableForRental and BranchID =@BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRental);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }



        public static DataTable GetAllVehicles(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Cities.CityName, Branches.StreetName, Vehicles.VehicleID, Vehicles.Name, Vehicles.Year,Vehicles.Mileage , Makes.Make,MakeModels.ModelName, Bodies.BodyName, DriveTypes.DriveTypeName, FuleTypes.FuleType, Vehicles.PlateNumber, 
                         Vehicles.RentalPricePerDay, Vehicles.RentalPricePerMonth, Vehicles.NumberTimesRented, Vehicles.TotalRentalIncome, Vehicles.TotalMaintenanceFees, Vehicles.NumberTimesOfMaintenance,PurchasingPrice= AmountsSpent.Amount, 
                       PurchasingDate=  AmountsSpent.Date,case when Vehicles.IsActive=0 then 'Inactive'else 'Active'end as Active,case when Vehicles.IsAvailableForRental=0 then 'Available'else 'Unavailable'end as AvailableForRental, case when Vehicles.ISsold=0 then 'Unsold' else 'sold' end as ISsold,
					   Vehicles.CreatedByUserID,Vehicles.UpdateByUserID
FROM            Branches INNER JOIN
                         Cities ON Branches.CityID = Cities.CityID INNER JOIN
                         Vehicles ON Branches.BranchID = Vehicles.BranchID INNER JOIN
                         Bodies ON Vehicles.BodyID = Bodies.BodyID INNER JOIN
                         DriveTypes ON Vehicles.DriveTypeID = DriveTypes.DriveTypeID INNER JOIN
                         FuleTypes ON Vehicles.FuelTypeID = FuleTypes.ID INNER JOIN
                         MakeModels ON Vehicles.ModelID = MakeModels.ModelID INNER JOIN
                         Makes ON MakeModels.MakeID = Makes.MakeID INNER JOIN
                         AmountsSpent ON Vehicles.AmountSpentID = AmountsSpent.AmountSpentID where Branches.BranchID=@BranchID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static DataTable GetAllVehicles()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
SELECT        Cities.CityName, Branches.StreetName, Vehicles.VehicleID, Vehicles.Name, Vehicles.Year,Vehicles.Mileage , Makes.Make,MakeModels.ModelName, Bodies.BodyName, DriveTypes.DriveTypeName, FuleTypes.FuleType, Vehicles.PlateNumber, 
                         Vehicles.RentalPricePerDay, Vehicles.RentalPricePerMonth, Vehicles.NumberTimesRented, Vehicles.TotalRentalIncome, Vehicles.TotalMaintenanceFees, Vehicles.NumberTimesOfMaintenance,PurchasingPrice= AmountsSpent.Amount, 
                       PurchasingDate=  AmountsSpent.Date,case when Vehicles.IsActive=0 then 'Inactive'else 'Active'end as Active,case when Vehicles.IsAvailableForRental=0 then 'Available'else 'Unavailable'end as AvailableForRental, case when Vehicles.ISsold=0 then 'Unsold' else 'sold' end as ISsold,
					   Vehicles.CreatedByUserID,Vehicles.UpdateByUserID
FROM            Branches INNER JOIN
                         Cities ON Branches.CityID = Cities.CityID INNER JOIN
                         Vehicles ON Branches.BranchID = Vehicles.BranchID INNER JOIN
                         Bodies ON Vehicles.BodyID = Bodies.BodyID INNER JOIN
                         DriveTypes ON Vehicles.DriveTypeID = DriveTypes.DriveTypeID INNER JOIN
                         FuleTypes ON Vehicles.FuelTypeID = FuleTypes.ID INNER JOIN
                         MakeModels ON Vehicles.ModelID = MakeModels.ModelID INNER JOIN
                         Makes ON MakeModels.MakeID = Makes.MakeID INNER JOIN
                         AmountsSpent ON Vehicles.AmountSpentID = AmountsSpent.AmountSpentID


";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        // Implemention Delete

        public static bool DeleteVehicle(int VehicleID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Vehicles 
                                where VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
        // Implemention Update

        public static bool UpdateVehicle(int VehicleID, int ModelID, string Name, int Year,
            int Mileage, int BodyID, int DriveTypeID, int FuelTypeID, string PlateNumber,
            float RentalPricePerMileage, float RentalPricePerDay, float RentalPricePerHours,
            float RentalPricePerMonth, double RentalPricePerYear, Boolean IsActive, Boolean
            IsAvailableForRental, string ImagePath, int CreatedByUserID, int? UpdateByUserID
            , Int16? NumberTimesRented, double? TotalRentalIncome, double? TotalMaintenanceFees,
            Int16? NumberTimesOfMaintenance, int BranchID,
            bool IsSold, int AmountSpentID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Vehicles  
                            set
			ModelID = @ModelID,
			Name = @Name,
			Year = @Year,
			Mileage = @Mileage,
			BodyID = @BodyID,
			DriveTypeID = @DriveTypeID,
			FuelTypeID = @FuelTypeID,
			PlateNumber = @PlateNumber,
			RentalPricePerMileage = @RentalPricePerMileage,
			RentalPricePerDay = @RentalPricePerDay,
			RentalPricePerHours = @RentalPricePerHours,
			RentalPricePerMonth = @RentalPricePerMonth,
			RentalPricePerYear = @RentalPricePerYear,
			IsActive = @IsActive,
			IsAvailableForRental = @IsAvailableForRental,
			ImagePath = @ImagePath,
			CreatedByUserID = @CreatedByUserID,
			UpdateByUserID = @UpdateByUserID,
			NumberTimesRented = @NumberTimesRented,
			TotalRentalIncome = @TotalRentalIncome,
			TotalMaintenanceFees = @TotalMaintenanceFees,
			NumberTimesOfMaintenance = @NumberTimesOfMaintenance,
			BranchID = @BranchID,
			IsSold = @IsSold,
            AmountSpentID=@AmountSpentID
             where VehicleID = @VehicleID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@ModelID", ModelID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@BodyID", BodyID);
            command.Parameters.AddWithValue("@DriveTypeID", DriveTypeID);
            command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            command.Parameters.AddWithValue("@RentalPricePerMileage", RentalPricePerMileage);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@RentalPricePerHours", RentalPricePerHours);
            command.Parameters.AddWithValue("@RentalPricePerMonth", RentalPricePerMonth);
            command.Parameters.AddWithValue("@RentalPricePerYear", RentalPricePerYear);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IsAvailableForRental", IsAvailableForRental);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdateByUserID", (object)UpdateByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@NumberTimesRented", (object)NumberTimesRented ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalRentalIncome", (object)TotalRentalIncome ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalMaintenanceFees", (object)TotalMaintenanceFees ?? DBNull.Value);
            command.Parameters.AddWithValue("@NumberTimesOfMaintenance", (object)NumberTimesOfMaintenance ?? DBNull.Value);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@IsSold", IsSold);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
