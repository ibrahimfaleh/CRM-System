using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsGeneralFundBillData
    {
        public static int AddNewGeneralFundBill(int BillID, int? AmountSpentID)
        {
            int TransactionID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO GeneralFundBills ( BillID, AmountSpentID)
                             VALUES ( @BillID, @AmountSpentID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID ?? DBNull.Value);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TransactionID = insertedID;
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


            return TransactionID;
        }
        public static bool GetGeneralFundBillInfoByID(int TransactionID, ref int BillID, ref int? AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM GeneralFundBills WHERE TransactionID = @TransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    BillID = (int)reader["BillID"];
                    if (reader["AmountSpentID"] != DBNull.Value)
                        AmountSpentID = (int)reader["AmountSpentID"];
                }
                else
                {
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
        public static bool IsGeneralFundBillExist(int TransactionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM GeneralFundBills WHERE TransactionID = @TransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);

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
        public static bool IsGeneralFundBillExistByBillID(int BillID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM GeneralFundBills WHERE BillID = @BillID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BillID", BillID);

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
        public static DataTable GetAllGeneralFundBills()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT   Cities.CityName, Branches.StreetName, GeneralFundBills.TransactionID, Bills.BillID, Bills.Cost, Bills.Details, Bills.CreatedDate,case when  Bills.IsPaid=0 then 'Unpaid'else 'Paid'end as IsPaid , Bills.PaymentDate,case when  Bills.IsActive=0 then 'InActive'else 'Active'end as Active, 
                         Bills.CreatedByUserID, Bills.UpdatedByUserID, Bills.UpdatedDate
FROM         Branches INNER JOIN
                         Cities ON Branches.CityID = Cities.CityID INNER JOIN
                         Bills ON Branches.BranchID = Bills.BranchID INNER JOIN
                         GeneralFundBills ON Bills.BillID = GeneralFundBills.BillID";

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
        public static bool DeleteGeneralFundBill(int TransactionID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete GeneralFundBills 
                                where TransactionID = @TransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);

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
        public static bool UpdateGeneralFundBill(int TransactionID, int BillID, int? AmountSpentID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  GeneralFundBills  
                            set
			BillID = @BillID,
			AmountSpentID = @AmountSpentID
             where TransactionID = @TransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@AmountSpentID",(object) AmountSpentID??DBNull.Value);
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
