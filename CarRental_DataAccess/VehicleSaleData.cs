using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsVehicleSaleData
    {
        // Implemention AddNew
        public static int AddNewVehicleSale(int VehicleID, DateTime SaleDate, string Description, double Price, Byte PaymentDetails,int CreatedByUserID,int? UpdatedByUserID,DateTime? UpdatedDate)
        {
            int SaleID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO VehicleSales ( VehicleID, SaleDate, Description, Price, PaymentDetails,CreatedByUserId,UpdatedByUserId,UpdatedDate)
                             VALUES ( @VehicleID, @SaleDate, @Description, @Price, @PaymentDetails,@CreatedByUserID,@UpdatedByUserId,@UpdatedDate);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@SaleDate", SaleDate);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID",(object) UpdatedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedDate", (object)UpdatedDate ?? DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    SaleID = insertedID;
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


            return SaleID;
        }
        // Implemention GetByID
        public static bool GetVehicleSaleInfoByID(int SaleID, ref int VehicleID, ref DateTime SaleDate, ref string Description, ref double Price, 
            ref Byte PaymentDetails, ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime? UpdatedDate)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleSales WHERE SaleID = @SaleID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SaleID", SaleID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    VehicleID = (int)reader["VehicleID"];
                    SaleDate = (DateTime)reader["SaleDate"];
                    Description = (string)reader["Description"];
                    Price = double.Parse(reader["Price"].ToString());
                    PaymentDetails = (Byte)reader["PaymentDetails"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];
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
        public static bool GetVehicleSaleInfoByVehicleID(int VehicleID,ref int SaleID, ref DateTime SaleDate, ref string Description, ref double Price,
            ref Byte PaymentDetails, ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime? UpdatedDate)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleSales WHERE VehicleID = @VehicleID";
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

                    SaleID = (int)reader["SaleID"];
                    SaleDate = (DateTime)reader["SaleDate"];
                    Description = (string)reader["Description"];
                    Price = double.Parse(reader["Price"].ToString());
                    PaymentDetails = (Byte)reader["PaymentDetails"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];
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

        public static bool IsVehicleSaleExist(int SaleID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM VehicleSales WHERE SaleID = @SaleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SaleID", SaleID);

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
        public static DataTable GetAllVehicleSales()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Cities.CityName, Branches.StreetName, VehicleSales.SaleID, VehicleSales.VehicleID, Vehicles.Name,Vehicles.Year,Vehicles.Mileage,  Makes.Make,  Vehicles.PlateNumber, Vehicles.NumberTimesRented, 
                         Vehicles.TotalRentalIncome, Vehicles.TotalMaintenanceFees, Vehicles.NumberTimesOfMaintenance, AmountsSpent.Amount, AmountsSpent.Date, VehicleSales.SaleDate, VehicleSales.Price, VehicleSales.Description, 
                         case when VehicleSales.PaymentDetails=1 then 'Cash'else 'BankTransfer'end as PaymentDetails, VehicleSales.CreatedByUserID, VehicleSales.UpdatedByUserID, VehicleSales.UpdatedDate
FROM            VehicleSales INNER JOIN        
                         Vehicles ON VehicleSales.VehicleID = Vehicles.VehicleID INNER JOIN
                         MakeModels ON Vehicles.ModelID = MakeModels.ModelID INNER JOIN
                         Makes ON MakeModels.MakeID = Makes.MakeID INNER JOIN
                         AmountsSpent ON Vehicles.AmountSpentID = AmountsSpent.AmountSpentID INNER JOIN
                         Branches ON Vehicles.BranchID = Branches.BranchID INNER JOIN
                         Cities ON Branches.CityID = Cities.CityID";

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
        public static DataTable GetAllVehicleSales(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Cities.CityName, Branches.StreetName, VehicleSales.SaleID, VehicleSales.VehicleID, Vehicles.Name,Vehicles.Year,Vehicles.Mileage,  Makes.Make,  Vehicles.PlateNumber, Vehicles.NumberTimesRented, 
                         Vehicles.TotalRentalIncome, Vehicles.TotalMaintenanceFees, Vehicles.NumberTimesOfMaintenance, AmountsSpent.Amount, AmountsSpent.Date, VehicleSales.SaleDate, VehicleSales.Price, VehicleSales.Description, 
                         case when VehicleSales.PaymentDetails=1 then 'Cash'else 'BankTransfer'end as PaymentDetails, VehicleSales.CreatedByUserID, VehicleSales.UpdatedByUserID, VehicleSales.UpdatedDate
FROM            VehicleSales INNER JOIN        
                         Vehicles ON VehicleSales.VehicleID = Vehicles.VehicleID INNER JOIN
                         MakeModels ON Vehicles.ModelID = MakeModels.ModelID INNER JOIN
                         Makes ON MakeModels.MakeID = Makes.MakeID INNER JOIN
                         AmountsSpent ON Vehicles.AmountSpentID = AmountsSpent.AmountSpentID INNER JOIN
                         Branches ON Vehicles.BranchID = Branches.BranchID INNER JOIN
                         Cities ON Branches.CityID = Cities.CityID Branches.BranchID=@BranchID";

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
        // Implemention Delete

        public static bool DeleteVehicleSale(int SaleID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete VehicleSales 
                                where SaleID = @SaleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SaleID", SaleID);

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

        public static bool UpdateVehicleSale(int SaleID, int VehicleID, DateTime SaleDate, string Description, double Price, Byte PaymentDetails, int CreatedByUserID, int? UpdatedByUserID, DateTime? UpdatedDate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  VehicleSales  
                            set
			VehicleID = @VehicleID,
			SaleDate = @SaleDate,
			Description = @Description,
			Price = @Price,
			PaymentDetails = @PaymentDetails,
            CreatedByUserID=@CreatedByUserID,
            UpdatedByUserID=@UpdatedByUserID,
            UpdatedDate=@UpdatedDate
             where SaleID = @SaleID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SaleID", SaleID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@SaleDate", SaleDate);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedDate", (object)UpdatedDate ?? DBNull.Value);
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
