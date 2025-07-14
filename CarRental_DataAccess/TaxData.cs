using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsTaxData
    {
        // Implemention AddNew
        public static int AddNewTax(float Tax, string TaxDetails)
        {
            int TaxID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Taxes ( Tax, TaxDetails)
                             VALUES ( @Tax, @TaxDetails);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tax", Tax);
            command.Parameters.AddWithValue("@TaxDetails", TaxDetails);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TaxID = insertedID;
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


            return TaxID;
        }
        // Implemention GetByID
        public static bool GetVat(ref int TaxID, ref float Tax, ref string TaxDetails)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT top(1) * FROM Taxes";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    TaxID = (int)reader["TaxID"];
                    Tax = float.Parse(reader["Tax"].ToString());
                    TaxDetails = (string)reader["TaxDetails"];
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

        public static bool IsTaxExist(int TaxID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Taxes WHERE TaxID = @TaxID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaxID", TaxID);

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
        public static DataTable GetAllTaxes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Taxes";

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

        public static bool DeleteTax(int TaxID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Taxes 
                                where TaxID = @TaxID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaxID", TaxID);

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

        public static bool UpdateTax(int TaxID, float Tax, string TaxDetails)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Taxes  
                            set
			Tax = @Tax,
			TaxDetails = @TaxDetails
             where TaxID = @TaxID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TaxID", TaxID);
            command.Parameters.AddWithValue("@Tax", Tax);
            command.Parameters.AddWithValue("@TaxDetails", TaxDetails);
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
