using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsSupportingFundLiquidityData
    {
         
        public static int AddNewSupportingFundLiquidity(int AmountSpentID, int DailyIncomeFundTransactionID, Boolean SupportStatus)
        {
            int SupportingID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO SupportingFundsLiquidity ( AmountSpentID, DailyIncomeFundTransactionID, SupportStatus)
                             VALUES ( @AmountSpentID, @DailyIncomeFundTransactionID, @SupportStatus);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
            command.Parameters.AddWithValue("@DailyIncomeFundTransactionID", DailyIncomeFundTransactionID);
            command.Parameters.AddWithValue("@SupportStatus", SupportStatus);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    SupportingID = insertedID;
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


            return SupportingID;
        }
         
        public static bool GetSupportingFundLiquidityInfoByID(int SupportingID, ref int AmountSpentID, ref int DailyIncomeFundTransactionID, ref Boolean SupportStatus)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM SupportingFundsLiquidity WHERE SupportingID = @SupportingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SupportingID", SupportingID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    AmountSpentID = (int)reader["AmountSpentID"];
                    DailyIncomeFundTransactionID = (int)reader["DailyIncomeFundTransactionID"];
                    SupportStatus = (Boolean)reader["SupportStatus"];
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
         

        public static bool IsSupportingFundLiquidityExist(int SupportingID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM SupportingFundsLiquidity WHERE SupportingID = @SupportingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupportingID", SupportingID);

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
        public static bool IsSupportingFundLiquidityExistByDailyIncomeFundTransactionID(int DailyIncomeFundTransactionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM SupportingFundsLiquidity WHERE DailyIncomeFundTransactionID = @DailyIncomeFundTransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DailyIncomeFundTransactionID", DailyIncomeFundTransactionID);

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
         
        public static DataTable GetAllSupportingFundsLiquidity()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM SupportingFundsLiquidity";

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

        public static DataTable GetAllSupportingFundsLiquidity(int DailyIncomeFundID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT DailyIncomeFundTransactions.DailyIncomeFundTransactionID, DailyIncomeFundTransactions.DailyIncomeFundID, SupportingFundsLiquidity.SupportingID, AmountsSpent.GeneralRevenueFundID, AmountsSpent.Amount, 
                  AmountsSpent.PaymentDetails, AmountsSpent.Date
FROM     DailyIncomeFundTransactions INNER JOIN
                  SupportingFundsLiquidity ON DailyIncomeFundTransactions.DailyIncomeFundTransactionID = SupportingFundsLiquidity.DailyIncomeFundTransactionID INNER JOIN
                  AmountsSpent ON SupportingFundsLiquidity.AmountSpentID = AmountsSpent.AmountSpentID
				  where DailyIncomeFundTransactions.DailyIncomeFundID=@DailyIncomeFundID order by DailyIncomeFundTransactions.DailyIncomeFundTransactionID desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);
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

        public static bool DeleteSupportingFundLiquidity(int SupportingID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete SupportingFundsLiquidity 
                                where SupportingID = @SupportingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupportingID", SupportingID);

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

        public static bool UpdateSupportingFundLiquidity(int SupportingID, int AmountSpentID, int DailyIncomeFundTransactionID, Boolean SupportStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  SupportingFundsLiquidity  
                            set
			AmountSpentID = @AmountSpentID,
			DailyIncomeFundTransactionID = @DailyIncomeFundTransactionID,
			SupportStatus = @SupportStatus
             where SupportingID = @SupportingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SupportingID", SupportingID);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
            command.Parameters.AddWithValue("@DailyIncomeFundTransactionID", DailyIncomeFundTransactionID);
            command.Parameters.AddWithValue("@SupportStatus", SupportStatus);
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
