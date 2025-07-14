using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsVehicleReturnData
    {
         
        public static int AddNewVehicleReturn(DateTime ActualReturnDate, Byte AdditionalHours, Int16 ActualRentalDays,byte ActualRentalMonths, int Mileage, int ConsumedMileage,int AdditionalKilometer, double AdditionalCharges,double ActualTotalDueAmount)
        {
            int ReturnID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO VehicleReturns ( ActualReturnDate, AdditionalHours, ActualRentalDays,ActualRentalMonths, Mileage, ConsumedMileage,AdditionalKilometer, AdditionalCharges,ActualTotalDueAmount)
                             VALUES ( @ActualReturnDate, @AdditionalHours, @ActualRentalDays,@ActualRentalMonths, @Mileage, @ConsumedMileage,@AdditionalKilometer, @AdditionalCharges,@ActualTotalDueAmount)
SELECT SCOPE_IDENTITY();

            

                 
";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
            command.Parameters.AddWithValue("@ActualRentalMonths",ActualRentalMonths);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
            command.Parameters.AddWithValue("@AdditionalHours", AdditionalHours);
            command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
            command.Parameters.AddWithValue("@AdditionalKilometer", AdditionalKilometer);
              command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ReturnID = insertedID;
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


            return ReturnID;
        }
         
        public static bool GetVehicleReturnInfoByID(int ReturnID, ref DateTime ActualReturnDate, ref Byte AdditionalHours, ref Int16 ActualRentalDays,ref byte ActualRentalMonths, ref int Mileage, ref int ConsumedMileage,ref int AdditionalKilometer, ref double AdditionalCharges,ref double ActualTotalDueAmount)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleReturns WHERE ReturenID = @ReturenID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReturenID", ReturnID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    ActualRentalDays = (Int16)reader["ActualRentalDays"];
                    ActualRentalMonths = (byte)reader["ActualRentalMonths"];
                    Mileage = (int)reader["Mileage"];
                    ConsumedMileage = (int)reader["ConsumedMileage"];
                    AdditionalHours = (Byte)reader["AdditionalHours"];
                    AdditionalKilometer = int.Parse(reader["AdditionalKilometer"].ToString());
                    AdditionalCharges = Double.Parse(reader["AdditionalCharges"].ToString());
                    ActualTotalDueAmount = double.Parse(reader["ActualTotalDueAmount"].ToString());
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
         

        public static bool IsVehicleReturnExist(int ReturnID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM VehicleReturns WHERE ReturnID = @ReturnID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReturnID", ReturnID);

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
         
        public static DataTable GetAllVehicleReturns()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VehicleReturns";

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

        public static bool DeleteVehicleReturn(int ReturnID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete VehicleReturns 
                                where ReturnID = @ReturnID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReturnID", ReturnID);

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

        public static bool UpdateVehicleReturn(int ReturnID, DateTime ActualReturnDate, Byte AdditionalHours, Int16 ActualRentalDays,byte ActualRentalMonths, int Mileage, int ConsumedMileage,int AdditionalKilometer, Double AdditionalCharges,double ActualTotalDueAmount)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  VehicleReturns  
                            set
			ActualReturnDate = @ActualReturnDate,
			ActualRentalDays = @ActualRentalDays,
            ActualRentalMonths=@ActualRentalMonths,
			Mileage = @Mileage,
			ConsumedMileage = @ConsumedMileage,
			AdditionalHours = @AdditionalHours,
			FinalCheckID = @FinalCheckID,
            AdditionalKilometer=@AdditionalKilometer,
			AdditionalCharges = @AdditionalCharges
             where ReturnID = @ReturnID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReturnID", ReturnID);
            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
            command.Parameters.AddWithValue("@ActualRentalMonths", ActualRentalMonths);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
            command.Parameters.AddWithValue("@AdditionalHours", AdditionalHours);
            command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
            command.Parameters.AddWithValue("@AdditionalKilometer", AdditionalKilometer);
            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
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
