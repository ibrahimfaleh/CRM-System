using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsFinalCheckData
    {
		 
			public static int AddNewFinalCheck( int BookingID )
{
	int FinalCheckID = -1;
				SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO FinalChecks ( BookingID)
                             VALUES ( @BookingID);
                             SELECT SCOPE_IDENTITY();";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@BookingID", BookingID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
            

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                        FinalCheckID = insertedID;
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


            return FinalCheckID;
}
		 
public static bool GetFinalCheckInfoByID(int FinalCheckID  ,ref int BookingID)
{
	
	bool isFound = false;
				SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM FinalChecks WHERE FinalCheckID = @FinalCheckID";
				SqlCommand command = new SqlCommand(query, connection);
	command.Parameters.AddWithValue("@FinalCheckID",FinalCheckID);
             try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                 
 BookingID = (int)reader["BookingID"];
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

            return isFound;}
		 

        public static bool IsFinalCheckExist(int FinalCheckID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM FinalChecks WHERE FinalCheckID = @FinalCheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FinalCheckID", FinalCheckID);

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
		 
        public static DataTable GetAllFinalChecks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM FinalChecks";

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

        public  static bool DeleteFinalCheck(int FinalCheckID)
        {

            int rowsAffected=0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete FinalChecks 
                                where FinalCheckID = @FinalCheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FinalCheckID", FinalCheckID);

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

        public static bool UpdateFinalCheck(int FinalCheckID ,  int BookingID )
        {

            int rowsAffected=0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  FinalChecks  
                            set
			BookingID = @BookingID
             where FinalCheckID = @FinalCheckID";
				SqlCommand command = new SqlCommand(query, connection);
command.Parameters.AddWithValue("@FinalCheckID", FinalCheckID);
				command.Parameters.AddWithValue("@BookingID", BookingID);
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

}}
