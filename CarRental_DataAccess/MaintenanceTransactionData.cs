using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsMaintenanceTransactionData
    {
        // Implemention AddNew
        public static int AddNewMaintenanceTransaction(int VehicleID, int Mileage, string Description, DateTime MaintenanceDate, double? Cost, Int16? ConsumedMileage, DateTime? ReturnDate, int? AmountSpentID, int CreatedByUserID, int? UpdatedByUserID, int TransferredByEmployeeID, int? VehicleReturnByEmployeeID, Boolean IsCompleted,int? NewMileage)
        {
            int MaintenanceID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO MaintenanceTransactions ( VehicleID, Mileage, Description, MaintenanceDate, Cost, ConsumedMileage, ReturnDate,NewMileage, AmountSpentID, CreatedByUserID, UpdatedByUserID, TransferredByEmployeeID, VehicleReturnByEmployeeID, IsCompleted)
                             VALUES ( @VehicleID, @Mileage, @Description, @MaintenanceDate, @Cost, @ConsumedMileage, @ReturnDate,@NewMileage, @AmountSpentID, @CreatedByUserID, @UpdatedByUserID, @TransferredByEmployeeID, @VehicleReturnByEmployeeID, @IsCompleted);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
            command.Parameters.AddWithValue("@Cost", (object)Cost ?? DBNull.Value);
            command.Parameters.AddWithValue("@ConsumedMileage", (object)ConsumedMileage ?? DBNull.Value);
            command.Parameters.AddWithValue("@ReturnDate", (object)ReturnDate??DBNull.Value);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@TransferredByEmployeeID", TransferredByEmployeeID);
            command.Parameters.AddWithValue("@VehicleReturnByEmployeeID", (object)VehicleReturnByEmployeeID ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsCompleted", IsCompleted);
            command.Parameters.AddWithValue("@NewMileage", (object)NewMileage??DBNull.Value);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    MaintenanceID = insertedID;
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


            return MaintenanceID;
        }
        // Implemention GetByID
        public static bool GetMaintenanceTransactionInfoByID(int MaintenanceID, ref int VehicleID, ref int Mileage, ref string Description, ref DateTime MaintenanceDate, ref double? Cost, ref Int16? ConsumedMileage, ref DateTime? ReturnDate, ref int? AmountSpentID, ref int CreatedByUserID, ref int? UpdatedByUserID, ref int TransferredByEmployeeID, ref int? VehicleReturnByEmployeeID, ref Boolean IsCompleted,ref int? NewMileage)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM MaintenanceTransactions WHERE MaintenanceID = @MaintenanceID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    VehicleID = (int)reader["VehicleID"];
                    Mileage = (int)reader["Mileage"];
                    Description = (string)reader["Description"];
                    MaintenanceDate = (DateTime)reader["MaintenanceDate"];

                    if (reader["Cost"] != DBNull.Value)
                        Cost = double.Parse(reader["Cost"].ToString());

                    if (reader["ConsumedMileage"] != DBNull.Value)
                        ConsumedMileage = (Int16)reader["ConsumedMileage"];

                    if (reader["ReturnDate"] != DBNull.Value)
                        ReturnDate = (DateTime)reader["ReturnDate"];

                    if (reader["AmountSpentID"] != DBNull.Value)
                        AmountSpentID = (int)reader["AmountSpentID"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];

                    TransferredByEmployeeID = (int)reader["TransferredByEmployeeID"];

                    if (reader["VehicleReturnByEmployeeID"] != DBNull.Value)
                        VehicleReturnByEmployeeID = (int?)reader["VehicleReturnByEmployeeID"];
                    IsCompleted = (Boolean)reader["IsCompleted"];
                    if (reader["NewMileage"] != DBNull.Value)
                        NewMileage = (int)reader["NewMileage"];
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

        public static bool GetMaintenanceTransactionInfoByPlateNumber(string PlateNumber ,ref int MaintenanceID, ref int VehicleID, ref int Mileage, ref string Description, ref DateTime MaintenanceDate, ref double? Cost, ref Int16? ConsumedMileage, ref DateTime? ReturnDate, ref int? AmountSpentID, ref int CreatedByUserID, ref int? UpdatedByUserID, ref int TransferredByEmployeeID, ref int? VehicleReturnByEmployeeID, ref Boolean IsCompleted,ref int? NewMileage)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM MaintenanceTransactions WHERE VehicleID =(select vehicleID from Vehicles where PlateNumber = @PlateNumber)";
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
                    MaintenanceID = (int)reader["MaintenanceID"];
                    VehicleID = (int)reader["VehicleID"];
                    Mileage = (int)reader["Mileage"];
                    Description = (string)reader["Description"];
                    MaintenanceDate = (DateTime)reader["MaintenanceDate"];

                    if (reader["Cost"] != DBNull.Value)
                        Cost = double.Parse(reader["Cost"].ToString());

                    if (reader["ConsumedMileage"] != DBNull.Value)
                        ConsumedMileage = (Int16)reader["ConsumedMileage"];

                    if (reader["ReturnDate"] != DBNull.Value)
                        ReturnDate = (DateTime)reader["ReturnDate"];

                    if (reader["AmountSpentID"] != DBNull.Value)
                        AmountSpentID = (int)reader["AmountSpentID"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];

                    TransferredByEmployeeID = (int)reader["TransferredByEmployeeID"];

                    if (reader["VehicleReturnByEmployeeID"] != DBNull.Value)
                        VehicleReturnByEmployeeID = (int?)reader["VehicleReturnByEmployeeID"];
                    IsCompleted = (Boolean)reader["IsCompleted"];
                    if (reader["NewMileage"] != DBNull.Value)
                        NewMileage = (int)reader["NewMileage"];
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

        public static bool IsMaintenanceTransactionExist(int MaintenanceID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM MaintenanceTransactions WHERE MaintenanceID = @MaintenanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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

        public static bool IsMaintenanceTransactionNewExistByPlateNumber(string PlateNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM MaintenanceTransactions WHERE VehicleID =(select VehicleID from Vehicles where PlateNumber = @PlateNumber) and IsCompleted =0";

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
        public static bool IsMaintenanceTransactionNewExist(int MaintenanceID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM MaintenanceTransactions WHERE MaintenanceID = @MaintenanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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

        public static DataTable GetAllMaintenanceTransactions()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from View_MaintenanceTransactions where BranchId=@BranchID order by MaintenanceDate desc";

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
        public static DataTable GetAllMaintenanceTransactions(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from View_MaintenanceTransactions where BranchId=@BranchID order by MaintenanceDate desc";

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

        public static bool DeleteMaintenanceTransaction(int MaintenanceID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete MaintenanceTransactions 
                                where MaintenanceID = @MaintenanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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

        public static bool UpdateMaintenanceTransaction(int MaintenanceID, int VehicleID, int Mileage, string Description, DateTime MaintenanceDate, double? Cost, Int16? ConsumedMileage, DateTime? ReturnDate, int? AmountSpentID, int CreatedByUserID, int? UpdatedByUserID, int TransferredByEmployeeID, int? VehicleReturnByEmployeeID, Boolean IsCompleted,int? NewMileage)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  MaintenanceTransactions  
                            set
			VehicleID = @VehicleID,
			Mileage = @Mileage,
			Description = @Description,
			MaintenanceDate = @MaintenanceDate,
			Cost = @Cost,
			ConsumedMileage = @ConsumedMileage,
			ReturnDate = @ReturnDate,
            NewMileage=@NewMileage,
			AmountSpentID = @AmountSpentID,
			CreatedByUserID = @CreatedByUserID,
			UpdatedByUserID = @UpdatedByUserID,
			TransferredByEmployeeID = @TransferredByEmployeeID,
			VehicleReturnByEmployeeID = @VehicleReturnByEmployeeID,
			IsCompleted = @IsCompleted
             where MaintenanceID = @MaintenanceID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
            command.Parameters.AddWithValue("@Cost", (object)Cost ?? DBNull.Value);
            command.Parameters.AddWithValue("@ConsumedMileage", (object)ConsumedMileage ?? DBNull.Value);
            command.Parameters.AddWithValue("@ReturnDate", (object)ReturnDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@TransferredByEmployeeID", TransferredByEmployeeID);
            command.Parameters.AddWithValue("@VehicleReturnByEmployeeID", (object)VehicleReturnByEmployeeID ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsCompleted", IsCompleted);
            command.Parameters.AddWithValue("@NewMileage",(object)NewMileage??DBNull.Value);
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
