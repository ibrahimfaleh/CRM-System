using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsMoneyWithdrawalTransactionData
    {
        // Implemention AddNew
        public static int AddNewMoneyWithdrawalTransaction(int AmountSpentID)
        {
            int MoneyWithdrawalTransactionsID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO MoneyWithdrawalTransactions ( AmountSpentID)
                             VALUES ( @AmountSpentID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    MoneyWithdrawalTransactionsID = insertedID;
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


            return MoneyWithdrawalTransactionsID;
        }
        // Implemention GetByID
        public static bool GetMoneyWithdrawalTransactionInfoByID(int MoneyWithdrawalTransactionsID, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM MoneyWithdrawalTransactions WHERE MoneyWithdrawalTransactionsID = @MoneyWithdrawalTransactionsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MoneyWithdrawalTransactionsID", MoneyWithdrawalTransactionsID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    AmountSpentID = (int)reader["AmountSpentID"];
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

        public static bool IsMoneyWithdrawalTransactionExist(int MoneyWithdrawalTransactionsID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM MoneyWithdrawalTransactions WHERE MoneyWithdrawalTransactionsID = @MoneyWithdrawalTransactionsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MoneyWithdrawalTransactionsID", MoneyWithdrawalTransactionsID);

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
        public static DataTable GetAllMoneyWithdrawalTransactions(int GeneralRevenueFundID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT     MoneyWithdrawalTransactions.MoneyWithdrawalTransactionsID, MoneyWithdrawalTransactions.AmountSpentID,fullName=( People.FirstName+' '+ People.SecondName+' '+ People.LastName),TotalAmount= AmountsSpent.Amount,AmountsSpent.FromVehicleBreakdownRevenues,AmountsSpent.Details, case when AmountsSpent.PaymentDetails=0 then 'Cash'else 'Bank'end as PymentDetails, AmountsSpent.CreatedByUserID,UserName =(select UserName from Users where UserID= AmountsSpent.CreatedByUserID), 
                  AmountsSpent.UpdatedByUserID,UserName =(select UserName from Users where UserID= AmountsSpent.CreatedByUserID), AmountsSpent.Date,AmountsSpent.updateDate
FROM        People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
                  Users ON Employees.EmployeeID = Users.EmployeeID INNER JOIN
                  AmountsSpent ON Users.UserID = AmountsSpent.CreatedByUserID OR Users.UserID = AmountsSpent.UpdatedByUserID INNER JOIN
                  MoneyWithdrawalTransactions ON AmountsSpent.AmountSpentID = MoneyWithdrawalTransactions.AmountSpentID
				  where AmountsSpent.GeneralRevenueFundID=@GeneralRevenueFundID order by MoneyWithdrawalTransactions.MoneyWithdrawalTransactionsID desc";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
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

        public static bool DeleteMoneyWithdrawalTransaction(int MoneyWithdrawalTransactionsID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete MoneyWithdrawalTransactions 
                                where MoneyWithdrawalTransactionsID = @MoneyWithdrawalTransactionsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MoneyWithdrawalTransactionsID", MoneyWithdrawalTransactionsID);

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

        public static bool UpdateMoneyWithdrawalTransaction(int MoneyWithdrawalTransactionsID, int AmountSpentID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  MoneyWithdrawalTransactions  
                            set
			AmountSpentID = @AmountSpentID
             where MoneyWithdrawalTransactionsID = @MoneyWithdrawalTransactionsID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MoneyWithdrawalTransactionsID", MoneyWithdrawalTransactionsID);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
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
