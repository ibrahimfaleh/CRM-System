using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsBodiesData
    {
		// Implemention AddNew
			public static int AddNewBodies( string BodyName )
{
	int BodyID = -1;
				SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Bodies ( BodyName)
                             VALUES ( @BodyName);
                             SELECT SCOPE_IDENTITY();";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@BodyName", BodyName);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
            

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                        BodyID = insertedID;
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


            return BodyID;
}
		// Implemention GetByID
public static bool GetBodiesInfoByID(int BodyID  ,ref string BodyName)
{
	
	bool isFound = false;
				SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM Bodies WHERE BodyID = @BodyID";
				SqlCommand command = new SqlCommand(query, connection);
	command.Parameters.AddWithValue("@BodyID",BodyID);
             try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                 
 BodyName = (string)reader["BodyName"];
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
		// Implemention IsExist

        public static bool IsBodiesExist(int BodyID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Bodies WHERE BodyID = @BodyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BodyID", BodyID);

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
        public static DataTable GetAllBodies()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Bodies";

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

        public  static bool DeleteBodies(int BodyID)
        {

            int rowsAffected=0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Bodies 
                                where BodyID = @BodyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BodyID", BodyID);

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

        public static bool UpdateBodies(int BodyID ,  string BodyName )
        {

            int rowsAffected=0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Bodies  
                            set
			BodyName = @BodyName
             where BodyID = @BodyID";
				SqlCommand command = new SqlCommand(query, connection);
command.Parameters.AddWithValue("@BodyID", BodyID);
				command.Parameters.AddWithValue("@BodyName", BodyName);
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
