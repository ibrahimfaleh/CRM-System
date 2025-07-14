using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsPaymentMethodData
    {
        public static int AddNewPaymentMethod(string PaymentMethod, float PaymentFees)
        {
            int PaymentMethodID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO PaymentMethods ( PaymentMethod, PaymentFees)
                             VALUES ( @PaymentMethod, @PaymentFees);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@PaymentFees", PaymentFees);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PaymentMethodID = insertedID;
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


            return PaymentMethodID;
        }
        public static bool GetPaymentMethodInfoByID(int PaymentMethodID, ref string PaymentMethod, ref float PaymentFees)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PaymentMethods WHERE PaymentMethodID = @PaymentMethodID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PaymentMethod = (string)reader["PaymentMethod"];
                    PaymentFees = float.Parse(reader["PaymentFees"].ToString());
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

        public static bool GetPaymentMethodInfoByPaymentMethod(ref int  PaymentMethodID,  string PaymentMethod, ref float PaymentFees)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PaymentMethods WHERE PaymentMethod = @PaymentMethod";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PaymentMethodID = (int)reader["PaymentMethodID"];
                    PaymentFees = float.Parse(reader["PaymentFees"].ToString());
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

        public static bool IsPaymentMethodExist(int PaymentMethodID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM PaymentMethods WHERE PaymentMethodID = @PaymentMethodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

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
        public static DataTable GetAllPaymentMethods()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM PaymentMethods";

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

        public static bool DeletePaymentMethod(int PaymentMethodID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete PaymentMethods 
                                where PaymentMethodID = @PaymentMethodID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

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

        public static bool UpdatePaymentMethod(int PaymentMethodID, string PaymentMethod, float PaymentFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  PaymentMethods  
                            set
			PaymentMethod = @PaymentMethod,
			PaymentFees = @PaymentFees
             where PaymentMethodID = @PaymentMethodID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@PaymentFees", PaymentFees);
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
