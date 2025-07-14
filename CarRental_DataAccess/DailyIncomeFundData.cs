using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsDailyIncomeFundData
    {
        public static int AddNewDailyIncomeFunds(double TotalIncome, double ExpectedCashAmount, double ExpectedTransformationAmount, double TotalAvailableCashAmount, double TotalAvailableTransformationAmount,
            double TotalRevenueDeficitOrSurplus, double VehicleBreakdownRevenues, byte Status, Boolean IsClose, DateTime Date,int BranchID, int? ClosedByUserID,float StartAmount,double ActualProfits,double ExpectedProfit)
        {
            int DailyIncomeFundID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO DailyIncomeFunds ( TotalIncome, ExpectedCashAmount, ExpectedTransformationAmount, TotalAvailableCashAmount, TotalAvailableTransformationAmount, TotalRevenueDeficitOrSurplus,ActualProfits,ExpectedProfit,VehicleBreakdownRevenues,StartAmount, Status, IsClose, Date,BranchID,ClosedByUserID)
                             VALUES ( @TotalIncome, @ExpectedCashAmount, @ExpectedTransformationAmount, @TotalAvailableCashAmount, @TotalAvailableTransformationAmount, @TotalRevenueDeficitOrSurplus,@ActualProfits,@ExpectedProfit,@VehicleBreakdownRevenues,@StartAmount, @Status, @IsClose, @Date,@BranchID,@ClosedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TotalIncome", TotalIncome);
            command.Parameters.AddWithValue("@ExpectedCashAmount", ExpectedCashAmount);
            command.Parameters.AddWithValue("@ExpectedTransformationAmount", ExpectedTransformationAmount);
            command.Parameters.AddWithValue("@TotalAvailableCashAmount", TotalAvailableCashAmount);
            command.Parameters.AddWithValue("@TotalAvailableTransformationAmount", TotalAvailableTransformationAmount);
            command.Parameters.AddWithValue("@TotalRevenueDeficitOrSurplus", TotalRevenueDeficitOrSurplus);
            command.Parameters.AddWithValue("@VehicleBreakdownRevenues", VehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@ExpectedProfit", ExpectedProfit);
            command.Parameters.AddWithValue("@ActualProfits", ActualProfits);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@IsClose", IsClose);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@ClosedByUserID",(object) ClosedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@StartAmount", StartAmount);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DailyIncomeFundID = insertedID;
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


            return DailyIncomeFundID;
        }
        public static bool GetDailyIncomeFundsInfoByID(int DailyIncomeFundID, ref double ExpectedCashAmount, ref double ExpectedTransformationAmount,
            ref double TotalAvailableCashAmount, ref double TotalAvailableTransformationAmount, ref double TotalRevenueDeficitOrSurplus,ref double VehicleBreakdownRevenues, ref Boolean IsClose, ref DateTime Date,ref int BranchID,ref int? ClosedByUserID,ref float StartAmount,ref double ActualProfits,ref double ExpectedProfit)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DailyIncomeFunds WHERE DailyIncomeFundID = @DailyIncomeFundID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ExpectedCashAmount = double.Parse(reader["ExpectedCashAmount"].ToString());
                    ExpectedTransformationAmount = double.Parse(reader["ExpectedTransformationAmount"].ToString());
                    TotalAvailableCashAmount = double.Parse(reader["TotalAvailableCashAmount"].ToString());
                    TotalAvailableTransformationAmount = double.Parse(reader["TotalAvailableTransformationAmount"].ToString());
                    TotalRevenueDeficitOrSurplus = double.Parse(reader["TotalRevenueDeficitOrSurplus"].ToString());
                    VehicleBreakdownRevenues = double.Parse(reader["VehicleBreakdownRevenues"].ToString());
                    IsClose = (Boolean)reader["IsClose"];
                    Date = (DateTime)reader["Date"];
                    BranchID = (int)reader["BranchID"];
                    if (reader["ClosedByUserID"] != DBNull.Value)
                        ClosedByUserID =(int)reader["ClosedByUserID"];
                    StartAmount = float.Parse(reader["StartAmount"].ToString());
                    ActualProfits = double.Parse(reader["ActualProfits"].ToString());
                    ExpectedProfit = double.Parse(reader["ExpectedProfit"].ToString());
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
        public static bool GetDailyIncomeFundInfoByDate(ref int DailyIncomeFundID, ref double ExpectedCashAmount, ref double ExpectedTransformationAmount, ref double TotalAvailableCashAmount, 
            ref double TotalAvailableTransformationAmount, ref double TotalRevenueDeficitOrSurplus,ref double VehicleBreakdownRevenues, ref Boolean IsClose,ref DateTime Date,ref int BranchID,ref int? ClosedByUserID, byte CountHours,ref float StartAmount,ref double ActualProfits,ref double ExpectedProfit)
        {
            string DateTo = Date.AddHours(CountHours).ToString("yyy/MM/dd HH:mm");
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DailyIncomeFunds where Date>=@Date and Date<@DateTo and (IsClose=0 and BranchID=@BranchID)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Date", Date.ToString("yyy/MM/dd HH:mm"));
            command.Parameters.AddWithValue("@DateTo", DateTo);
            command.Parameters.AddWithValue("@BranchID", BranchID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    DailyIncomeFundID = (int)reader["DailyIncomeFundID"];
                    ExpectedCashAmount = double.Parse(reader["ExpectedCashAmount"].ToString());
                    ExpectedTransformationAmount = double.Parse(reader["ExpectedTransformationAmount"].ToString());
                    TotalAvailableCashAmount = double.Parse(reader["TotalAvailableCashAmount"].ToString());
                    TotalAvailableTransformationAmount = double.Parse(reader["TotalAvailableTransformationAmount"].ToString());
                    TotalRevenueDeficitOrSurplus = double.Parse(reader["TotalRevenueDeficitOrSurplus"].ToString());
                    VehicleBreakdownRevenues = double.Parse(reader["VehicleBreakdownRevenues"].ToString());
                    IsClose = (Boolean)reader["IsClose"];
                    Date = (DateTime)reader["Date"];
                    BranchID = (int)reader["BranchID"];
                    if (reader["ClosedByUserID"] != DBNull.Value)
                        ClosedByUserID = (int)reader["ClosedByUserID"];
                    StartAmount = float.Parse(reader["StartAmount"].ToString());
                    ActualProfits = double.Parse(reader["ActualProfits"].ToString());
                    ExpectedProfit = double.Parse(reader["ExpectedProfit"].ToString());
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


        public static bool IsDailyIncomeFundsExist(int DailyIncomeFundID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DailyIncomeFunds WHERE DailyIncomeFundID = @DailyIncomeFundID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);

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
        public static DataTable GetAllDailyIncomeFunds()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from View_DailyFunds order by Date desc";

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
        public static DataTable GetAllDailyIncomeFunds(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from View_DailyFunds where BranchID = @BranchID order by Date desc";


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

        public static bool DeleteDailyIncomeFunds(int DailyIncomeFundID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete DailyIncomeFunds 
                                where DailyIncomeFundID = @DailyIncomeFundID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);

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

        public static bool UpdateDailyIncomeFunds(int DailyIncomeFundID, double TotalIncome, double ExpectedCashAmount, double ExpectedTransformationAmount, double TotalAvailableCashAmount, double TotalAvailableTransformationAmount, double TotalRevenueDeficitOrSurplus,double VehicleBreakdownRevenues, byte Status, Boolean IsClose, DateTime Date,int BranchID,int? ClosedByUserID,double ActualProfits,double ExpectedProfit)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  DailyIncomeFunds  
                            set
			TotalIncome = @TotalIncome,
			ExpectedCashAmount = @ExpectedCashAmount,
			ExpectedTransformationAmount = @ExpectedTransformationAmount,
			TotalAvailableCashAmount = @TotalAvailableCashAmount,
			TotalAvailableTransformationAmount = @TotalAvailableTransformationAmount,
			TotalRevenueDeficitOrSurplus = @TotalRevenueDeficitOrSurplus,
            ActualProfits=@ActualProfits,
            ExpectedProfit=@ExpectedProfit,
            VehicleBreakdownRevenues=@VehicleBreakdownRevenues,
			Status = @Status,
			IsClose = @IsClose,
			Date = @Date,
            BranchID=@BranchID,
            ClosedByUserID=@ClosedByUserID
             where DailyIncomeFundID = @DailyIncomeFundID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DailyIncomeFundID", DailyIncomeFundID);
            command.Parameters.AddWithValue("@TotalIncome", TotalIncome);
            command.Parameters.AddWithValue("@ExpectedCashAmount", ExpectedCashAmount);
            command.Parameters.AddWithValue("@ExpectedTransformationAmount", ExpectedTransformationAmount);
            command.Parameters.AddWithValue("@TotalAvailableCashAmount", TotalAvailableCashAmount);
            command.Parameters.AddWithValue("@TotalAvailableTransformationAmount", TotalAvailableTransformationAmount);
            command.Parameters.AddWithValue("@TotalRevenueDeficitOrSurplus", TotalRevenueDeficitOrSurplus);
            command.Parameters.AddWithValue("@VehicleBreakdownRevenues", VehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@IsClose", IsClose);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@ClosedByUserID",(object )ClosedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@ActualProfits", ActualProfits);
            command.Parameters.AddWithValue("@ExpectedProfit", ExpectedProfit);
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
