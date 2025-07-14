using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsVehicleCheckData
    {
         
        public static int AddNewVehicleCheck(int InitialCheckID, int? FinalCheckID,byte Status ,int VehicleID)
        {
            int VehicleCheckID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO VehicleChecks ( InitialCheckID, FinalCheckID,Status,VehicleID)
                             VALUES ( @InitialCheckID, @FinalCheckID,@Status,@VehicleID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InitialCheckID", InitialCheckID);
            command.Parameters.AddWithValue("@FinalCheckID", (object)FinalCheckID ?? DBNull.Value);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    VehicleCheckID = insertedID;
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


            return VehicleCheckID;
        }
        
         
        public static bool GetVehicleCheckInfoByID(int VehicleCheckID, ref int InitialCheckID, ref int? FinalCheckID,ref byte Status,ref int VehicleID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
						 Select * From VehicleChecks Where VehicleCheckID=@VehicleCheckID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleCheckID", VehicleCheckID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;
                    Status = (byte)reader["Status"] ;
                    InitialCheckID = (int)reader["InitialCheckID"];
                    if (reader["FinalCheckID"] == DBNull.Value)
                        FinalCheckID = null;
                    else
                        FinalCheckID = (int)reader["FinalCheckID"];
                    VehicleID = (int)reader["VehicleID"];

                }
                else
                {

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
        public static bool GetVehicleCheckInfoByVehicleIDAndStatus( int VehicleID,ref int VehicleCheckID,ref int InitialCheckID,ref int? FinalCheckID,byte Status)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * From  VehicleChecks  where VehicleID=@VehicleID and Status=@Status
                               ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    VehicleCheckID = (int)reader["VehicleCheckID"];
                    InitialCheckID = (int)reader["InitialCheckID"];
                    if (reader["FinalCheckID"] == DBNull.Value)
                        FinalCheckID = null;
                    else
                        FinalCheckID = (int?)reader["FinalCheckID"];

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
         

        public static bool IsVehicleCheckExist(int VehicleCheckID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM VehicleChecks WHERE VehicleCheckID = @VehicleCheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleCheckID", VehicleCheckID);

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
         
        public static DataTable GetAllVehicleChecks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VehicleChecks order by VehicleCheckID desc";

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

        public static bool DeleteVehicleCheck(int VehicleCheckID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete VehicleChecks 
                                where VehicleCheckID = @VehicleCheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleCheckID", VehicleCheckID);

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

        public static bool UpdateVehicleCheck(int VehicleCheckID, int InitialCheckID, int? FinalCheckID,byte Status,int VehicleID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  VehicleChecks  
                            set
            VehicleID=@VehicleID,
			InitialCheckID = @InitialCheckID,
			FinalCheckID = @FinalCheckID,
            Status=@Status
             where VehicleCheckID = @VehicleCheckID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleCheckID", VehicleCheckID);
            command.Parameters.AddWithValue("@InitialCheckID", InitialCheckID);
            command.Parameters.AddWithValue("@FinalCheckID", (object) FinalCheckID??DBNull.Value);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
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
