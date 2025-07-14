using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsDailyIncomeFundTransactionData
    {
         
        public static int AddNewDailyIncomeFundTransaction(int DailyIncomeFundID, int TransactionID)
        {
            int DailyIncomeFundTransactionID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO DailyIncomeFundTransactions ( DailyIncomeFundID, TransactionID)
                             VALUES ( @DailyIncomeFundID, @TransactionID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DailyIncomeFundTransactionID = insertedID;
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


            return DailyIncomeFundTransactionID;
        }
         
        public static bool GetDailyIncomeFundTransactionInfoByID(int DailyIncomeFundTransactionID, ref int DailyIncomeFundID, ref int TransactionID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DailyIncomeFundTransactions WHERE DailyIncomeFundTransactionID = @DailyIncomeFundTransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DailyIncomeFundTransactionID", DailyIncomeFundTransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;
                    DailyIncomeFundID = (int)reader["DailyIncomeFundID"];
                    TransactionID = (int)reader["TransactionID"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsDailyIncomeFundTransactionExist(int DailyIncomeFundTransactionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DailyIncomeFundTransactions WHERE DailyIncomeFundTransactionID = @DailyIncomeFundTransactionID";

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
        public static DataTable GetAllDailyIncomeFundTransactions()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DailyIncomeFundTransactions";

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
        public static DataTable GetAllDailyIncomeFundTransactions(int DailyIncomeFundID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
SELECT        DailyIncomeFundTransactions.DailyIncomeFundTransactionID, DailyIncomeFundTransactions.DailyIncomeFundID, RentalTransaction.TransactionID,
case 
when RentalTransaction.ActualTotalDueAmount is null
 then RentalTransaction.PaidInitialTotalDueAmount
when (select top(1) DailyIncomeFundTransactionID from  DailyIncomeFundTransactions where TransactionID = RentalTransaction.TransactionID order by DailyIncomeFundTransactionID desc)>DailyIncomeFundTransactions.DailyIncomeFundTransactionID
 then RentalTransaction.PaidInitialTotalDueAmount

 else RentalTransaction.TotalRemaining
 end 
 as Amount,

 case 
when RentalTransaction.ActualTotalDueAmount is null
 then RentalTransaction.InitialPaymentMethodID
when (select top(1) DailyIncomeFundTransactionID from  DailyIncomeFundTransactions where TransactionID = RentalTransaction.TransactionID order by DailyIncomeFundTransactionID desc)>DailyIncomeFundTransactions.DailyIncomeFundTransactionID
 then RentalTransaction.FinalPaymentMethodID

 else RentalTransaction.FinalPaymentMethodID
 end 
 as PaymentDetails,

 case 
when RentalTransaction.ActualTotalDueAmount is null
 then RentalTransaction.TransactionDate
when (select top(1) DailyIncomeFundTransactionID from  DailyIncomeFundTransactions where TransactionID = RentalTransaction.TransactionID order by DailyIncomeFundTransactionID desc)>DailyIncomeFundTransactions.DailyIncomeFundTransactionID
 then RentalTransaction.TransactionDate

 else RentalTransaction.UpdatedTransactionDate
 end 
 as Date

FROM            DailyIncomeFundTransactions INNER JOIN
                         RentalTransaction ON DailyIncomeFundTransactions.TransactionID = RentalTransaction.TransactionID
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
        // Implemention Delete

        public static bool DeleteDailyIncomeFundTransaction(int DailyIncomeFundTransactionID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete DailyIncomeFundTransactions 
                                where DailyIncomeFundTransactionID = @DailyIncomeFundTransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DailyIncomeFundTransactionID", DailyIncomeFundTransactionID);

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

        public static bool UpdateDailyIncomeFundTransaction(int DailyIncomeFundTransactionID, int DailyIncomeFundID, int TransactionID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  DailyIncomeFundTransactions  
                            set
			DailyIncomeFundID = @DailyIncomeFundID,
			TransactionID = @TransactionID
             where DailyIncomeFundTransactionID = @DailyIncomeFundTransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DailyIncomeFundTransactionID", DailyIncomeFundTransactionID);
            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
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
