using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsGeneralFundSupportTransactionData
    {
        // Implemention AddNew
        public static int AddNewGeneralFundSupportTransaction(double Amount, string Details, Byte PaymentDetails, DateTime Date, DateTime? UpdateDate, int GeneralRevenueFundID, int CreatedByUserID, int? UpdatedByUserID)
        {
            int FundSupportTransactionID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO GeneralFundSupportTransactions ( Amount, Details, PaymentDetails, Date, UpdateDate, GeneralRevenueFundID, CreatedByUserID, UpdatedByUserID)
                             VALUES ( @Amount, @Details, @PaymentDetails, @Date, @UpdateDate, @GeneralRevenueFundID, @CreatedByUserID, @UpdatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Details", Details);
            command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@UpdateDate", (object)UpdateDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    FundSupportTransactionID = insertedID;
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


            return FundSupportTransactionID;
        }
        // Implemention GetByID
        public static bool GetGeneralFundSupportTransactionInfoByID(int FundSupportTransactionID, ref double Amount, ref string Details, ref Byte PaymentDetails, ref DateTime Date, ref DateTime? UpdateDate, ref int GeneralRevenueFundID, ref int CreatedByUserID, ref int? UpdatedByUserID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM GeneralFundSupportTransactions WHERE FundSupportTransactionID = @FundSupportTransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FundSupportTransactionID", FundSupportTransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    Amount = double.Parse(reader["Amount"].ToString());
                    Details = (string)reader["Details"];
                    PaymentDetails = (Byte)reader["PaymentDetails"];
                    Date = (DateTime)reader["Date"];
                    if (reader["UpdateDate"] != DBNull.Value)
                        UpdateDate = (DateTime?)reader["UpdateDate"];
                    GeneralRevenueFundID = (int)reader["GeneralRevenueFundID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int?)reader["UpdatedByUserID"];
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

        public static bool IsGeneralFundSupportTransactionExist(int FundSupportTransactionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM GeneralFundSupportTransactions WHERE FundSupportTransactionID = @FundSupportTransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FundSupportTransactionID", FundSupportTransactionID);

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
        public static DataTable GetAllGeneralFundSupportTransactions(int GeneralRevenueFundID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT     GeneralFundSupportTransactions.FundSupportTransactionID,fullName=( People.FirstName+' '+ People.SecondName+' '+ People.LastName), GeneralFundSupportTransactions.Amount, case when GeneralFundSupportTransactions.PaymentDetails=0 then 'Cash'else 'Bank'end as PaymentDetails, GeneralFundSupportTransactions.CreatedByUserID,UserName =(select UserName from Users where UserID= GeneralFundSupportTransactions.CreatedByUserID), 
                  GeneralFundSupportTransactions.UpdatedByUserID,UserName =(select UserName from Users where UserID= GeneralFundSupportTransactions.CreatedByUserID), GeneralFundSupportTransactions.Date,GeneralFundSupportTransactions.updateDate
FROM        People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
                  Users ON Employees.EmployeeID = Users.EmployeeID INNER JOIN
                  GeneralFundSupportTransactions ON Users.UserID = GeneralFundSupportTransactions.CreatedByUserID OR Users.UserID = GeneralFundSupportTransactions.UpdatedByUserID 
				  where GeneralFundSupportTransactions.GeneralRevenueFundID=@GeneralRevenueFundID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GeneralRevenueFundID",GeneralRevenueFundID);
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

        public static bool DeleteGeneralFundSupportTransaction(int FundSupportTransactionID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete GeneralFundSupportTransactions 
                                where FundSupportTransactionID = @FundSupportTransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FundSupportTransactionID", FundSupportTransactionID);

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

        public static bool UpdateGeneralFundSupportTransaction(int FundSupportTransactionID, double Amount, string Details, Byte PaymentDetails, DateTime Date, DateTime? UpdateDate, int GeneralRevenueFundID, int CreatedByUserID, int? UpdatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  GeneralFundSupportTransactions  
                            set
			Amount = @Amount,
			Details = @Details,
			PaymentDetails = @PaymentDetails,
			Date = @Date,
			UpdateDate = @UpdateDate,
			GeneralRevenueFundID = @GeneralRevenueFundID,
			CreatedByUserID = @CreatedByUserID,
			UpdatedByUserID = @UpdatedByUserID
             where FundSupportTransactionID = @FundSupportTransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FundSupportTransactionID", FundSupportTransactionID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Details", Details);
            command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@UpdateDate", UpdateDate);
            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
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
