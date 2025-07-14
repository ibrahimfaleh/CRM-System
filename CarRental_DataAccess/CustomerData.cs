using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CarRental_DataAccess
{
    public class clsCustomerData
    {
         
        public static int AddNewCustomer(int PersonID, string DriverLicenseNumber)
        {
            int CustomerID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Customers ( PersonID, DriverLicenseNumber,NumberRentedTransActions,InitialTotalDueAmountsAfterTax,PaidInitialTotalDueAmounts,TotalPayments,TotalRentPayments
,TotalVehiclesBreakdownPayments,TotalInitialRentalDays,TotalActualRentalDays,TotalKilometersConsumed)
                             VALUES ( @PersonID, @DriverLicenseNumber,0,0,0,0,0,0,0,0,0);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CustomerID = insertedID;
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


            return CustomerID;
        }
         
        public static bool GetCustomerInfoByID(int CustomerID, ref int PersonID, ref string DriverLicenseNumber, ref int CreatedByUserID, ref short NumberRentedTransActions, 
            ref double InitialTotalDueAmountsAfterTax,
                   ref double PaidInitialTotalDueAmounts, ref double TotalPayments, ref double TotalRentPayments, ref double TotalVehiclesBreakdownPayments,
                   ref short TotalInitialRentalDays, ref short TotalActualRentalDays, ref int TotalKilometersConsumed)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    DriverLicenseNumber = (string)reader["DriverLicenseNumber"];
                    CreatedByUserID = -1;
                    //(int)reader["CreatedByUserID"];
                    NumberRentedTransActions = (short)reader["NumberRentedTransActions"];
                    InitialTotalDueAmountsAfterTax = double.Parse(reader["InitialTotalDueAmountsAfterTax"].ToString());
                    PaidInitialTotalDueAmounts = double.Parse(reader["PaidInitialTotalDueAmounts"].ToString());
                    TotalPayments = double.Parse(reader["TotalPayments"].ToString());
                    TotalRentPayments = double.Parse(reader["TotalRentPayments"].ToString());
                    TotalVehiclesBreakdownPayments = double.Parse(reader["TotalVehiclesBreakdownPayments"].ToString());
                    TotalInitialRentalDays = short.Parse(reader["TotalInitialRentalDays"].ToString());
                    TotalKilometersConsumed = (int)reader["TotalKilometersConsumed"];
                    TotalActualRentalDays= (short)reader["TotalActualRentalDays"];
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
        public static bool GetCustomerInfoByPersonID(ref int CustomerID,  int PersonID, ref string DriverLicenseNumber, ref int CreatedByUserID, ref short NumberRentedTransActions,
            ref double InitialTotalDueAmountsAfterTax,
                   ref double PaidInitialTotalDueAmounts, ref double TotalPayments, ref double TotalRentPayments, ref double TotalVehiclesBreakdownPayments,
                   ref short TotalInitialRentalDays, ref short TotalActualRentalDays, ref int TotalKilometersConsumed)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Customers WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CustomerID = (int)reader["CustomerID"];
                    DriverLicenseNumber = (string)reader["DriverLicenseNumber"];
                    CreatedByUserID = (int)reader["PersonID"];
                    NumberRentedTransActions = short.Parse(reader["NumberRentedTransActions"].ToString());
                    InitialTotalDueAmountsAfterTax = double.Parse(reader["InitialTotalDueAmountsAfterTax"].ToString());
                    PaidInitialTotalDueAmounts = double.Parse(reader["PaidInitialTotalDueAmounts"].ToString());
                    TotalPayments = double.Parse(reader["TotalPayments"].ToString());
                    TotalRentPayments = double.Parse(reader["TotalRentPayments"].ToString());
                    TotalVehiclesBreakdownPayments = double.Parse(reader["TotalVehiclesBreakdownPayments"].ToString());
                    TotalInitialRentalDays = short.Parse(reader["NumberRentedTransActions"].ToString());
                    TotalKilometersConsumed = (int)reader["TotalKilometersConsumed"];
                    TotalActualRentalDays = (short)reader["TotalActualRentalDays"];
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
         

        public static bool IsCustomerExist(int CustomerID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Customers WHERE CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

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
        public static bool isCustomerExistForPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Customers WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static bool isDriverLicenseNumberExist(string DriverLicenseNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Customers WHERE DriverLicenseNumber = @DriverLicenseNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

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
         
        public static DataTable GetAllCustomers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM View_Customers";

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

        public static bool DeleteCustomer(int CustomerID)
        {
            
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Customers 
                                where CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static bool UpdateCustomer(int CustomerID, int PersonID, string DriverLicenseNumber)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Customers  
                            set
			PersonID = @PersonID,
			DriverLicenseNumber = @DriverLicenseNumber
             where CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
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
