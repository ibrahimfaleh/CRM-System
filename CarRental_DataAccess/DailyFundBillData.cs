using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsDailyFundBillData
    {
        // Implemention AddNew
        public static int AddNewDailyFundBill(int BillID, int DailyIncomeFundID, int PaidByUserID, double FromExpectedProfit, double FromVehicleBreakdownRevenues, double ActualProfits)
        {
            int TransactionID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO DailyFundBills ( BillID, DailyIncomeFundID, PaidByUserID, FromExpectedProfit, FromVehicleBreakdownRevenues, ActualProfits)
                             VALUES ( @BillID, @DailyIncomeFundID, @PaidByUserID, @FromExpectedProfit, @FromVehicleBreakdownRevenues, @ActualProfits);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);
            command.Parameters.AddWithValue("@PaidByUserID", PaidByUserID);
            command.Parameters.AddWithValue("@FromExpectedProfit", FromExpectedProfit);
            command.Parameters.AddWithValue("@FromVehicleBreakdownRevenues", FromVehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@ActualProfits", ActualProfits);
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
        // Implemention GetByID
        public static bool GetDailyFundBillInfoByID(int TransactionID, ref int BillID, ref int DailyIncomeFundID, ref int PaidByUserID, ref double FromExpectedProfit, ref double FromVehicleBreakdownRevenues, ref double ActualProfits)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DailyFundBills WHERE TransactionID = @TransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    BillID = (int)reader["BillID"];
                    DailyIncomeFundID = (int)reader["DailyIncomeFundID"];
                    PaidByUserID = (int)reader["PaidByUserID"];
                    FromExpectedProfit = double.Parse(reader["FromExpectedProfit"].ToString());
                    FromVehicleBreakdownRevenues = double.Parse(reader["FromVehicleBreakdownRevenues"].ToString());
                    ActualProfits = double.Parse(reader["ActualProfits"].ToString());
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

        public static bool IsDailyFundBillExist(int TransactionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DailyFundBills WHERE TransactionID = @TransactionID";

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
        // Implemention GetAllDataTablw
        public static DataTable GetAllDailyFundBills(int DailyIncomeFundID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT   DailyFundBills.TransactionID, DailyFundBills.BillID, Bills.Cost, DailyFundBills.FromExpectedProfit,DailyFundBills.ActualProfits, DailyFundBills.FromVehicleBreakdownRevenues, 
                         DailyFundBills.PaidByUserID
FROM         Bills INNER JOIN
                         DailyFundBills ON Bills.BillID = DailyFundBills.BillID join
						 DailyIncomeFunds on DailyFundBills.DailyIncomeFundID = DailyIncomeFunds.DailyIncomeFundID join 
						 Branches on branches.BranchID=DailyIncomeFunds.BranchID  where DailyIncomeFunds.DailyIncomeFundID=@DailyIncomeFundID";

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

        public static bool DeleteDailyFundBill(int TransactionID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete DailyFundBills 
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
        // Implemention Update

        public static bool UpdateDailyFundBill(int TransactionID, int BillID, int DailyIncomeFundID, int PaidByUserID, double FromExpectedProfit, double FromVehicleBreakdownRevenues, double ActualProfits)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  DailyFundBills  
                            set
			BillID = @BillID,
			DailyIncomeFundID = @DailyIncomeFundID,
			PaidByUserID = @PaidByUserID,
			FromExpectedProfit = @FromExpectedProfit,
			FromVehicleBreakdownRevenues = @FromVehicleBreakdownRevenues,
			ActualProfits = @ActualProfits
             where TransactionID = @TransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);
            command.Parameters.AddWithValue("@PaidByUserID", PaidByUserID);
            command.Parameters.AddWithValue("@FromExpectedProfit", FromExpectedProfit);
            command.Parameters.AddWithValue("@FromVehicleBreakdownRevenues", FromVehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@ActualProfits", ActualProfits);
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
