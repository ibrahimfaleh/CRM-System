using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsAmountSpentData
    {
        // Implemention AddNew

        public static int AddNewAmountSpent(int GeneralRevenueFundID, double Amount, string Details, byte PaymentDetails, DateTime Date, int CreatedByUserID,
            int? UpdatedByUserID, DateTime? UpdateDate,double FromVehicleBreakdownRevenues,double FromAnotherIncome,double 
            FromExpectedProfit,double FromActualProfits,double FromVehicleSales,double? NotMoreThan, bool ObligatedToPayFullAmount)
        {
            int AmountSpentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO AmountsSpent ( GeneralRevenueFundID, Amount, Details, PaymentDetails,FromAnotherIncome,FromVehicleSales,FromExpectedProfit,FromActualProfits,FromVehicleBreakdownRevenues,NotMoreThan,ObligatedToPayFullAmount, Date,UpdateDate, CreatedByUserID, UpdatedByUserID)
                             VALUES ( @GeneralRevenueFundID, @Amount, @Details, @PaymentDetails,@FromAnotherIncome,@FromVehicleSales,@FromExpectedProfit,@FromActualProfits ,@FromVehicleBreakdownRevenues,@NotMoreThan,@ObligatedToPayFullAmount,@Date,@UpdateDate, @CreatedByUserID, @UpdatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Details", Details);
            command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            command.Parameters.AddWithValue("@FromVehicleBreakdownRevenues", FromVehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdateDate", (object)UpdateDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@FromAnotherIncome", FromAnotherIncome);
            command.Parameters.AddWithValue("@FromExpectedProfit", FromExpectedProfit);
            command.Parameters.AddWithValue("@FromActualProfits", FromActualProfits);
            command.Parameters.AddWithValue("@FromVehicleSales", FromVehicleSales);
            command.Parameters.AddWithValue("@ObligatedToPayFullAmount", ObligatedToPayFullAmount);
            command.Parameters.AddWithValue("@NotMoreThan", (object) NotMoreThan??DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AmountSpentID = insertedID;
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


            return AmountSpentID;
        }
        // Implemention GetByID
        public static bool GetAmountSpentInfoByID(int AmountSpentID, ref int GeneralRevenueFundID, ref double Amount, ref string Details, 
            ref byte PaymentDetails, ref DateTime Date, ref int CreatedByUserID, ref int? UpdatedByUserID,
            ref DateTime? UpdateDate,ref double FromVehicleBreakdownRevenues,ref double FromAnotherIncome,
            ref double FromExpectedProfit,ref double FromActualProfits,ref double FromVehicleSales,ref double? NotMoreThan, ref bool ObligatedToPayFullAmount)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM AmountsSpent WHERE AmountSpentID = @AmountSpentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    GeneralRevenueFundID = (int)reader["GeneralRevenueFundID"];
                    Amount = double.Parse(reader["Amount"].ToString());
                    Details = (string)reader["Details"];
                    PaymentDetails = (byte)reader["PaymentDetails"];
                    FromVehicleBreakdownRevenues = double.Parse(reader["FromVehicleBreakdownRevenues"].ToString());
                    Date = (DateTime)reader["Date"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];
                    if (reader["UpdateDate"] != DBNull.Value)
                        UpdateDate = (DateTime)reader["UpdateDate"];
                    FromAnotherIncome = double.Parse(reader["FromAnotherIncome"].ToString());
                    FromActualProfits = double.Parse(reader["FromActualProfits"].ToString());
                    FromExpectedProfit = double.Parse(reader["FromExpectedProfit"].ToString());
                    FromVehicleSales = double.Parse(reader["FromVehicleSales"].ToString());
                    ObligatedToPayFullAmount = (bool)reader["ObligatedToPayFullAmount"];
                    if (reader["NotMoreThan"] != DBNull.Value)
                        NotMoreThan = double.Parse(reader["NotMoreThan"].ToString());
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

        public static bool IsAmountSpentExist(int AmountSpentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM AmountsSpent WHERE AmountSpentID = @AmountSpentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);

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
        public static DataTable GetAllAmountsSpent()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM AmountsSpent order by AmountSpentID desc";

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

        public static bool DeleteAmountSpent(int AmountSpentID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete AmountsSpent 
                                where AmountSpentID = @AmountSpentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);

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

        public static bool UpdateAmountSpent(int AmountSpentID, int GeneralRevenueFundID, double Amount, string Details, byte PaymentDetails, DateTime Date, int CreatedByUserID, int? UpdatedByUserID,DateTime? UpdateDate,
            double FromVehicleBreakdownRevenues,double FromAnotherIncome,double FromExpectedProfit,double FromActualProfits,double FromVehicleSales, double? NotMoreThan, bool ObligatedToPayFullAmount)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  AmountsSpent  
                            set
			GeneralRevenueFundID = @GeneralRevenueFundID,
			Amount = @Amount,
			Details = @Details,
			PaymentDetails = @PaymentDetails,
            FromAnotherIncome=@FromAnotherIncome,
            FromVehicleSales=@FromVehicleSales,
            FromExpectedProfit=@FromExpectedProfit,
            FromActualProfits=@FromActualProfits,
            FromVehicleBreakdownRevenues=@FromVehicleBreakdownRevenues,
            NotMoreThan=@NotMoreThan,
            ObligatedToPayFullAmount=@ObligatedToPayFullAmount,
			Date = @Date,
            UpdateDate=@UpdateDate,
			CreatedByUserID = @CreatedByUserID,
			UpdatedByUserID = @UpdatedByUserID
             where AmountSpentID = @AmountSpentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AmountSpentID", AmountSpentID);
            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Details", Details);
            command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);
            command.Parameters.AddWithValue("@FromVehicleBreakdownRevenues", FromVehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@UpdateDate", (object)UpdateDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@FromAnotherIncome", FromAnotherIncome);
            command.Parameters.AddWithValue("@FromActualProfits", FromActualProfits);
            command.Parameters.AddWithValue("@FromExpectedProfit", FromExpectedProfit);
            command.Parameters.AddWithValue("@FromVehicleSales", FromVehicleSales);
            command.Parameters.AddWithValue("@ObligatedToPayFullAmount", ObligatedToPayFullAmount);
            command.Parameters.AddWithValue("@NotMoreThan",(object) NotMoreThan??DBNull.Value);

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
