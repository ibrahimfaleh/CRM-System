using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsSalaryPaymentData
    {

        public static int AddNewSalaryPayment(int AmountSpentID)
        {
            int SalaryPaymentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO SalaryPayments ( AmountSpentID)
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
                    SalaryPaymentID = insertedID;
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


            return SalaryPaymentID;
        }
        public static bool GetSalaryPaymentInfoByID(int SalaryPaymentID, ref int AmountSpentID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM SalaryPayments WHERE SalaryPaymentID = @SalaryPaymentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SalaryPaymentID", SalaryPaymentID);
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
        public static bool IsSalaryPaymentExist(int SalaryPaymentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM SalaryPayments WHERE SalaryPaymentID = @SalaryPaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SalaryPaymentID", SalaryPaymentID);

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
        public static bool PaymentOfSalaries(DataTable dtEmployeeSalaries, int GeneralRevenueFundID, int CreatedByUserID, byte PaymentDetails)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
INSERT INTO AmountsSpent
           (GeneralRevenueFundID
           ,Amount
           ,Details
           ,PaymentDetails
           ,FromAnotherIncome
           ,FromVehicleSales
           ,FromExpectedProfit
           ,FromActualProfits
           ,FromVehicleBreakdownRevenues
           ,ObligatedToPayFullAmount
           ,Date
           ,UpdateDate
           ,CreatedByUserID
           ,UpdatedByUserID)
     VALUES
           (@GeneralRevenueFundID
           ,@PaymentAmount
           ,'EmployeeSalaryPayment'
           ,@PaymentDetails
           ,@FromAnotherIncome
           ,@FromVehicleSales
           ,@FromExpectedProfit
           ,@FromActualProfits
           ,@FromVehicleBreakdownRevenues
           ,0
           ,GETDATE()
           ,null
           ,@CreatedByUserID
           ,null);



 INSERT INTO SalaryPayments
           (AmountSpentID,employeeID)
     VALUES
           ( (SELECT SCOPE_IDENTITY()),@EmployeeID);";



            try
            {
                connection.Open();
                foreach (DataRow row in dtEmployeeSalaries.Rows)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
                    if (row["PaymentAmount"].ToString() != "")
                        command.Parameters.AddWithValue("@PaymentAmount", row["PaymentAmount"]);
                    else
                        command.Parameters.AddWithValue("@PaymentAmount", "0");
                    command.Parameters.AddWithValue("@EmployeeID", row["EmployeeID"]);
                    if (row["FromVehicleBreakdownRevenues"].ToString() == "")
                        command.Parameters.AddWithValue("@FromVehicleBreakdownRevenues",0);
                    else
                        command.Parameters.AddWithValue("@FromVehicleBreakdownRevenues", row["FromVehicleBreakdownRevenues"]);

                    if (row["FromActualProfits"].ToString() == "")
                        command.Parameters.AddWithValue("@FromActualProfits", 0);
                    else
                        command.Parameters.AddWithValue("@FromActualProfits", row["FromActualProfits"]);

                    if (row["FromExpectedProfit"].ToString() == "")
                        command.Parameters.AddWithValue("@FromExpectedProfit", 0);
                    else
                        command.Parameters.AddWithValue("@FromExpectedProfit", row["FromExpectedProfit"]);

                    if (row["FromAnotherIncome"].ToString() == "")
                        command.Parameters.AddWithValue("@FromAnotherIncome", 0);
                    else
                        command.Parameters.AddWithValue("@FromAnotherIncome", row["FromAnotherIncome"]);
                    if (row["FromVehicleSales"].ToString() == "")
                        command.Parameters.AddWithValue("@FromVehicleSales", 0);
                    else
                        command.Parameters.AddWithValue("@FromVehicleSales", row["FromVehicleSales"]);

                    command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    rowsAffected += command.ExecuteNonQuery();
                    command.Parameters.Clear();

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

            return rowsAffected == (dtEmployeeSalaries.Rows.Count * 2);
        }
        public static DataTable GetAllEmployeeSalaries()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from View_EmployeeSalaries";

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
        public static DataTable GetAllEmployeeSalaries(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * from View_EmployeeSalaries where BranchID =@BranchID order by PaymentDate  desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
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
        public static DataTable GetAllSalariesPaidForEmployeeID(int EmpoyeeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * FRom View_SalariesPaid wehre EmpoyeeID=@EmpoyeeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmpoyeeID", EmpoyeeID);

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
        public static DataTable GetAllSalariesPaid()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * FRom View_SalariesPaid order by PaymentDate  desc";

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
        public static DataTable GetAllSalariesPaid(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * FRom View_SalariesPaid where BranchID=@BranchID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);

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
        public static bool DeleteSalaryPayment(int SalaryPaymentID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete SalaryPayments 
                                where SalaryPaymentID = @SalaryPaymentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SalaryPaymentID", SalaryPaymentID);

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
        public static bool UpdateSalaryPayment(int SalaryPaymentID, int AmountSpentID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  SalaryPayments  
                            set
			AmountSpentID = @AmountSpentID
             where SalaryPaymentID = @SalaryPaymentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SalaryPaymentID", SalaryPaymentID);
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
