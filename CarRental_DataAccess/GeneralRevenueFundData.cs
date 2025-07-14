using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsGeneralRevenueFundData
    {
        // Implemention AddNew
        public static int AddNewGeneralRevenueFund(double ActualProfits, double VehicleBreakdownRevenues,double ExpectedProfit, double AnotherIncome, double Cash, double Bank, DateTime CreatedDate, DateTime? ClosedDate, Boolean IsClosed, int CreatedByUserID, int? ClosedByUserID,double VehicleSales)
        {
            int GeneralRevenueFundID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO GeneralRevenueFund ( ActualProfits, VehicleBreakdownRevenues,ExpectedProfit, AnotherIncome,VehicleSales, Cash, Bank, CreatedDate, ClosedDate, IsClosed, CreatedByUserID, ClosedByUserID)
                             VALUES ( @ActualProfits, @VehicleBreakdownRevenues,@ExpectedProfit, @AnotherIncome,@VehicleSales, @Cash, @Bank, @CreatedDate, @ClosedDate, @IsClosed, @CreatedByUserID, @ClosedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ActualProfits", ActualProfits);
            command.Parameters.AddWithValue("@VehicleBreakdownRevenues", VehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@AnotherIncome", AnotherIncome);
            command.Parameters.AddWithValue("@Cash", Cash);
            command.Parameters.AddWithValue("@Bank", Bank);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@ClosedDate", (object)ClosedDate??DBNull.Value);
            command.Parameters.AddWithValue("@IsClosed", IsClosed);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ClosedByUserID",(object)ClosedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@ExpectedProfit", ExpectedProfit);
            command.Parameters.AddWithValue("@VehicleSales", VehicleSales);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    GeneralRevenueFundID = insertedID;
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


            return GeneralRevenueFundID;
        }
        // Implemention GetByID
        public static bool GetGeneralRevenueFundInfoByID(int GeneralRevenueFundID, ref double ActualProfits, ref double VehicleBreakdownRevenues,ref double ExpectedProfit,  ref double AnotherIncome, ref double Cash, ref double Bank, ref DateTime CreatedDate, ref DateTime? ClosedDate, ref Boolean IsClosed, ref int CreatedByUserID, ref int? ClosedByUserID,ref double VehicleSales)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM GeneralRevenueFund WHERE GeneralRevenueFundID = @GeneralRevenueFundID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ActualProfits = double.Parse(reader["ActualProfits"].ToString());
                    VehicleBreakdownRevenues = double.Parse(reader["VehicleBreakdownRevenues"].ToString());
                    AnotherIncome = double.Parse(reader["AnotherIncome"].ToString());
                    Cash = double.Parse(reader["Cash"].ToString());
                    Bank = double.Parse(reader["Bank"].ToString());
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    if(reader["ClosedDate"]!=DBNull.Value)
                        ClosedDate = (DateTime)reader["CloseDate"];
                    IsClosed = (Boolean)reader["IsClosed"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["ClosedByUserID"] != DBNull.Value)
                        ClosedByUserID = (int)reader["ClosedByUserID"];
                    ExpectedProfit = double.Parse(reader["ExpectedProfit"].ToString());
                    VehicleSales = double.Parse(reader["VehicleSales"].ToString());

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
        public static bool GetGeneralRevenueFund(ref int GeneralRevenueFundID, ref double ActualProfits, ref double VehicleBreakdownRevenues, ref double ExpectedProfit, ref double AnotherIncome, ref double Cash, ref double Bank, ref DateTime CreatedDate, ref DateTime? ClosedDate, ref Boolean IsClosed, ref int CreatedByUserID, ref int? ClosedByUserID,ref double VehicleSales)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM GeneralRevenueFund WHERE IsClosed = 0";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    GeneralRevenueFundID =(int) reader["GeneralRevenueFundID"];
                    ActualProfits = double.Parse(reader["ActualProfits"].ToString());
                    VehicleBreakdownRevenues = double.Parse(reader["VehicleBreakdownRevenues"].ToString());
                    AnotherIncome = double.Parse(reader["AnotherIncome"].ToString());
                    Cash = double.Parse(reader["Cash"].ToString());
                    Bank = double.Parse(reader["Bank"].ToString());
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    if (reader["ClosedDate"] != DBNull.Value)
                        ClosedDate = (DateTime)reader["CloseDate"];
                    IsClosed = (Boolean)reader["IsClosed"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["ClosedByUserID"] != DBNull.Value)
                        ClosedByUserID = (int)reader["ClosedByUserID"];
                    ExpectedProfit = double.Parse(reader["ExpectedProfit"].ToString());
                    VehicleSales = double.Parse(reader["VehicleSales"].ToString()) ;    

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
        // Implemention IsExist

        public static bool IsGeneralRevenueFundExist(int GeneralRevenueFundID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM GeneralRevenueFund WHERE GeneralRevenueFundID = @GeneralRevenueFundID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);

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
        public static DataTable GetAllGeneralRevenueFund()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM GeneralRevenueFund";

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

        public static bool DeleteGeneralRevenueFund(int GeneralRevenueFundID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete GeneralRevenueFund 
                                where GeneralRevenueFundID = @GeneralRevenueFundID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);

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

        public static bool UpdateGeneralRevenueFund(int GeneralRevenueFundID, double ActualProfits, double VehicleBreakdownRevenues,double ExpectedProfit, double AnotherIncome, double Cash, double Bank, DateTime CreatedDate, DateTime? ClosedDate, Boolean IsClosed, int CreatedByUserID, int? ClosedByUserID,double VehicleSales)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  GeneralRevenueFund  
                            set
			ActualProfits = @ActualProfits,
			VehicleBreakdownRevenues = @VehicleBreakdownRevenues,
            ExpectedProfit=@ExpectedProfit,
			AnotherIncome = @AnotherIncome,
            VehicleSales=@VehicleSales,
			Cash = @Cash,
			Bank = @Bank,
			CreatedDate = @CreatedDate,
			ClosedDate = @ClosedDate,
			IsClosed = @IsClosed,
			CreatedByUserID = @CreatedByUserID,
			ClosedByUserID = @ClosedByUserID
             where GeneralRevenueFundID = @GeneralRevenueFundID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GeneralRevenueFundID", GeneralRevenueFundID);
            command.Parameters.AddWithValue("@ActualProfits", ActualProfits);
            command.Parameters.AddWithValue("@VehicleBreakdownRevenues", VehicleBreakdownRevenues);
            command.Parameters.AddWithValue("@AnotherIncome", AnotherIncome);
            command.Parameters.AddWithValue("@Cash", Cash);
            command.Parameters.AddWithValue("@Bank", Bank);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@ClosedDate", (object)ClosedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsClosed", IsClosed);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ClosedByUserID", (object)ClosedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@ExpectedProfit", ExpectedProfit);
            command.Parameters.AddWithValue("@VehicleSales", VehicleSales);
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
