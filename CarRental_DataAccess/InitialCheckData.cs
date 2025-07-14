using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsInitialCheckData
    {
		 
			public static int AddNewInitialCheck( int CheckID )
{
	int InitialCheckID = -1;
				SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO InitialChecks ( CheckID)
                             VALUES ( @CheckID);
                             SELECT SCOPE_IDENTITY();";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@CheckID", CheckID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
            

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                        InitialCheckID = insertedID;
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


            return InitialCheckID;
}
		 
public static bool GetInitialCheckInfoByID(int InitialCheckID  ,ref int CheckID)
{
	
	bool isFound = false;
				SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM InitialChecks WHERE InitialCheckID = @InitialCheckID";
				SqlCommand command = new SqlCommand(query, connection);
	command.Parameters.AddWithValue("@InitialCheckID",InitialCheckID);
             try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                 
 CheckID = (int)reader["CheckID"];
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
		 

        public static bool IsInitialCheckExist(int InitialCheckID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM InitialChecks WHERE InitialCheckID = @InitialCheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InitialCheckID", InitialCheckID);

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
		 
        public static DataTable GetAllInitialChecks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM InitialChecks";

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

        public  static bool DeleteInitialCheck(int InitialCheckID)
        {

            int rowsAffected=0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete InitialChecks 
                                where InitialCheckID = @InitialCheckID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InitialCheckID", InitialCheckID);

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

        public static bool UpdateInitialCheck(int InitialCheckID ,  int CheckID )
        {

            int rowsAffected=0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  InitialChecks  
                            set
			CheckID = @CheckID
             where InitialCheckID = @InitialCheckID";
				SqlCommand command = new SqlCommand(query, connection);
command.Parameters.AddWithValue("@InitialCheckID", InitialCheckID);
				command.Parameters.AddWithValue("@CheckID", CheckID);
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
