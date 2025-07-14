using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsBranchesData
    {
         
        public static int AddNewBranch(string StreetName, string BranchLocation)
        {
            int BranchID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Branches ( StreetName, BranchLocation)
                             VALUES ( @StreetName, @BranchLocation);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StreetName", StreetName);
            command.Parameters.AddWithValue("@BranchLocation", BranchLocation);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BranchID = insertedID;
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


            return BranchID;
        }
         
        public static bool GetBranchInfoByID(int BranchID, ref string StreetName, ref string BranchLocation)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Branches WHERE BranchID = @BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    StreetName = (string)reader["StreetName"];
                    BranchLocation = (string)reader["BranchLocation"];
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
        public static bool GetBranchInfoByStreetName(ref int BranchID,  string StreetName, ref string BranchLocation)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Branches WHERE StreetName = @StreetName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StreetName", StreetName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    BranchID = (int)reader["BranchID"];
                    BranchLocation = (string)reader["BranchLocation"];
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
         

        public static bool IsRentalBranchExist(int BranchID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Branches WHERE BranchID = @BranchID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchID", BranchID);

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
         
        public static DataTable GetAllBranches()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Branches";

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

        public static bool DeleteBranch(int BranchID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Branches 
                                where BranchID = @BranchID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BranchID", BranchID);

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

        public static bool UpdateBranch(int BranchID, string StreetName, string BranchLocation)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Branches  
                            set
			StreetName = @StreetName,
			BranchLocation = @BranchLocation
             where BranchID = @BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@StreetName", StreetName);
            command.Parameters.AddWithValue("@BranchLocation", BranchLocation);
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
