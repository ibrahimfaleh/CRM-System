using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsBranchData
    {
        // Implemention AddNew
        public static int AddNewBranch(string StreetName, string BranchLocation, int CityID, Byte CountDailyIncomeFundPerDay, Boolean IsPublic,int? AmountSpentID)
        {
            int BranchID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Branches ( StreetName, BranchLocation, CityID, CountDailyIncomeFundPerDay, IsPublic,AmountSpentID)
                             VALUES ( @StreetName, @BranchLocation, @CityID, @CountDailyIncomeFundPerDay, @IsPublic,@AmountSpentID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StreetName", StreetName);
            command.Parameters.AddWithValue("@BranchLocation", BranchLocation);
            command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@CountDailyIncomeFundPerDay", CountDailyIncomeFundPerDay);
            command.Parameters.AddWithValue("@AmountSpentID",(object) AmountSpentID??DBNull.Value);
            command.Parameters.AddWithValue("@IsPublic", IsPublic);
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
        // Implemention GetByID
        public static bool GetBranchInfoByID(int BranchID, ref string StreetName, ref string BranchLocation, ref int CityID, ref Byte CountDailyIncomeFundPerDay, ref Boolean IsPublic,ref int? AmountSpentID)
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
                    if (reader["AmountSpentID"] != DBNull.Value)
                        AmountSpentID = (int)reader["AmountSpentID"];
                    StreetName = (string)reader["StreetName"];
                    BranchLocation = (string)reader["BranchLocation"];
                    CityID = (int)reader["CityID"];
                    CountDailyIncomeFundPerDay = (Byte)reader["CountDailyIncomeFundPerDay"];
                    IsPublic = (Boolean)reader["IsPublic"];
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

        public static bool GetBranchInfoByStreetName(ref int BranchID,  string StreetName, ref string BranchLocation, ref int CityID, ref Byte CountDailyIncomeFundPerDay, ref Boolean IsPublic,ref int? AmountSpentID)
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
                    if (reader["AmountSpentID"] != DBNull.Value)
                        AmountSpentID = (int)reader["AmountSpentID"];
                    BranchID = (int)reader["BranchID"];
                    BranchLocation = (string)reader["BranchLocation"];
                    CityID = (int)reader["CityID"];
                    CountDailyIncomeFundPerDay = (Byte)reader["CountDailyIncomeFundPerDay"];
                    IsPublic = (Boolean)reader["IsPublic"];
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
        public static bool IsBranchExist(int BranchID)
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
        public static DataTable GetAllBranches(string CityName)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Branches.BranchID, Cities.CityName, Branches.StreetName, Branches.BranchLocation, Branches.CountDailyIncomeFundPerDay,StartDailyIncomeFundAmount=(select Amount from AmountsSpent where AmountSpentID=Branches.AmountSpentID),
                         Branches.IsPublic
FROM            Branches INNER JOIN
                         Cities ON Branches.CityID = Cities.CityID where Cities.CityName=@CityName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CityName", CityName);
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
        public static DataTable GetAllBranches(int CityID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Branches.BranchID, Cities.CityName, Branches.StreetName, Branches.BranchLocation, Branches.CountDailyIncomeFundPerDay,StartDailyIncomeFundAmount=(select Amount from AmountsSpent where AmountSpentID=Branches.AmountSpentID),
                          Branches.IsPublic
FROM            Branches INNER JOIN
                         Cities ON Branches.CityID = Cities.CityID where Cities.CityID=@CityID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CityID", CityID);
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
        public static DataTable GetAllBranches()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Branches.BranchID, Cities.CityName, Branches.StreetName, Branches.BranchLocation, Branches.CountDailyIncomeFundPerDay,StartDailyIncomeFundAmount=(select Amount from AmountsSpent where AmountSpentID=Branches.AmountSpentID),
                          Branches.IsPublic
FROM            Branches INNER JOIN
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
        public static bool UpdateBranch(int BranchID, string StreetName, string BranchLocation, int CityID, Byte CountDailyIncomeFundPerDay, Boolean IsPublic,int? AmountSpentID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Branches  
                            set
			StreetName = @StreetName,
			BranchLocation = @BranchLocation,
			CityID = @CityID,
			CountDailyIncomeFundPerDay = @CountDailyIncomeFundPerDay,
			IsPublic = @IsPublic,
            AmountSpentID=@AmountSpentID
             where BranchID = @BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@StreetName", StreetName);
            command.Parameters.AddWithValue("@BranchLocation", BranchLocation);
            command.Parameters.AddWithValue("@CityID", CityID);
            command.Parameters.AddWithValue("@CountDailyIncomeFundPerDay", CountDailyIncomeFundPerDay);
            command.Parameters.AddWithValue("@IsPublic", IsPublic);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID ?? DBNull.Value);
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
