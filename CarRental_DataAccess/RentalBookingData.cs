using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsRentalBookingData
    {
         


        public static int AddNewRentalBooking(int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, double RentalPricePerMileage, short FreeKilometersCredit, 
            float RentalPricePerHours, int PickupBranchID, int? DropOffBranchID,double RentalPricePerMonth, byte InitialRentalMonths, short InitialRentalDays, double RentalPricePerDay,
            Double InitialTotalDueAmount, int VehicleCheckID, byte BookingStatus,bool IsMonthly,int BranchID, byte NumberDaysOfCustomMonth)
        {
            int BookingID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO RentalBooking ( CustomerID, VehicleID, RentalStartDate, RentalEndDate,RentalPricePerMileage,FreeKilometersCredit,RentalPricePerHours,
PickupBranchID, DropOffBranchID, InitialRentalMonths,InitialRentalDays,RentalPricePerMonth, RentalPricePerDay, InitialTotalDueAmount, VehicleCheckID, BookingStatus,IsMonthly,BranchID,NumberDaysOfCustomMonth)
                             VALUES ( @CustomerID, @VehicleID, @RentalStartDate, @RentalEndDate,@RentalPricePerMileage,@FreeKilometersCredit,
@RentalPricePerHours, @PickupBranchID, @DropOffBranchID,@InitialRentalMonths, @InitialRentalDays,@RentalPricePerMonth, @RentalPricePerDay, @InitialTotalDueAmount, @VehicleCheckID, @BookingStatus,@IsMonthly,@BranchID,@NumberDaysOfCustomMonth);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
            command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
            command.Parameters.AddWithValue("@RentalPricePerMileage", RentalPricePerMileage);
            command.Parameters.AddWithValue("@FreeKilometersCredit", FreeKilometersCredit);
            command.Parameters.AddWithValue("@RentalPricePerHours", RentalPricePerHours);
            command.Parameters.AddWithValue("@PickupBranchID", PickupBranchID);
            command.Parameters.AddWithValue("@DropOffBranchID",(object) DropOffBranchID??DBNull.Value);
            command.Parameters.AddWithValue("@InitialRentalMonths", InitialRentalMonths);
            command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
            command.Parameters.AddWithValue("@RentalPricePerMonth", RentalPricePerMonth);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
            command.Parameters.AddWithValue("@VehicleCheckID", VehicleCheckID);
            command.Parameters.AddWithValue("@BookingStatus", BookingStatus);
            command.Parameters.AddWithValue("@NumberDaysOfCustomMonth", NumberDaysOfCustomMonth);
            command.Parameters.AddWithValue("IsMonthly",IsMonthly);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BookingID = insertedID;
                }
            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return BookingID;
        }
         
        public static bool GetRentalBookingInfoByID(int BookingID,ref int CustomerID,ref int VehicleID,ref DateTime RentalStartDate,ref DateTime RentalEndDate, ref double RentalPricePerMileage, ref short FreeKilometersCredit,ref  float RentalPricePerHours, ref int PickupBranchID,
            ref int? DropOffBranchID,ref float RentalPricePerMonth, ref float RentalPricePerDay,ref int VehicleCheckID,ref  byte BookingStatus,ref bool IsMonthly,ref int BranchID,ref byte NumberDaysOfCustomMonth)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM RentalBooking WHERE BookingID = @BookingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CustomerID = (int)reader["CustomerID"];
                    VehicleID = (int)reader["VehicleID"];
                    RentalStartDate = (DateTime)reader["RentalStartDate"];
                    RentalEndDate = (DateTime)reader["RentalEndDate"];
                    PickupBranchID = (int)reader["PickupBranchID"];

                    RentalPricePerMileage = double.Parse(reader["RentalPricePerMileage"].ToString());
                    FreeKilometersCredit = (short)reader["FreeKilometersCredit"];
                    RentalPricePerHours = float.Parse(reader["RentalPricePerHours"].ToString());

                    if (reader["DropOffBranchID"] == DBNull.Value)
                        DropOffBranchID = null;
                    else
                        DropOffBranchID =(int)reader["DropOffBranchID"];
                    RentalPricePerMonth = float.Parse(reader["RentalPricePerMonth"].ToString());
                    RentalPricePerDay = float.Parse(reader["RentalPricePerDay"].ToString());
                    VehicleCheckID = (int)reader["VehicleCheckID"];
                    BookingStatus = (byte)reader["BookingStatus"];
                    NumberDaysOfCustomMonth = (byte)reader["NumberDaysOfCustomMonth"];
                    IsMonthly = (bool)reader["IsMonthly"];
                    BranchID = (int)reader["BranchID"];
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
         

        public static bool IsRentalBookingExist(int BookingID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM RentalBooking WHERE BookingID = @BookingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

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
         
        public static DataTable GetAllRentalBooking()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM RentalBooking order by BookingID desc";

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

        public static bool DeleteRentalBooking(int BookingID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete RentalBooking 
                                where BookingID = @BookingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);

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

        public static bool UpdateRentalBooking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, double RentalPricePerMileage, short FreeKilometersCredit, float RentalPricePerHours, int PickupBranchID, int? DropOffBranchID,
            byte InitialRentalMonths, short InitialRentalDays,
            double RentalPricePerMonth, double RentalPricePerDay,
            double InitialTotalDueAmount, int VehicleCheckID, byte BookingStatus,bool IsMonthly,byte NumberDaysOfCustomMonth)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  RentalBooking  
                            set
			CustomerID = @CustomerID,
			VehicleID = @VehicleID,
			RentalStartDate = @RentalStartDate,
			RentalEndDate = @RentalEndDate,
            RentalPricePerMileage=@RentalPricePerMileage,
            FreeKilometersCredit=@FreeKilometersCredit,
            RentalPricePerHours=@RentalPricePerHours,
			PickupBranchID = @PickupBranchID,
			DropOffBranchID = @DropOffBranchID,
            InitialRentalMonths=@InitialRentalMonths,
			InitialRentalDays = @InitialRentalDays,
            RentalPricePerMonth=@RentalPricePerMonth,
			RentalPricePerDay = @RentalPricePerDay,
			InitialTotalDueAmount = @InitialTotalDueAmount,
			VehicleCheckID = @VehicleCheckID,
			BookingStatus = @BookingStatus,
            IsMonthly=@IsMonthly,
            NumberDaysOfCustomMonth = @NumberDaysOfCustomMonth
             where BookingID = @BookingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
            command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
            command.Parameters.AddWithValue("@RentalPricePerMileage", RentalPricePerMileage);
            command.Parameters.AddWithValue("@FreeKilometersCredit", FreeKilometersCredit);
            command.Parameters.AddWithValue("@RentalPricePerHours", RentalPricePerHours);
            command.Parameters.AddWithValue("@PickupBranchID", PickupBranchID);
            command.Parameters.AddWithValue("@DropOffBranchID", (object)DropOffBranchID ?? DBNull.Value);
            command.Parameters.AddWithValue("@InitialRentalMonths", InitialRentalMonths);
            command.Parameters.AddWithValue("@RentalPricePerMonth", RentalPricePerMonth);
            command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
            command.Parameters.AddWithValue("@VehicleCheckID", VehicleCheckID);
            command.Parameters.AddWithValue("@BookingStatus", BookingStatus);
            command.Parameters.AddWithValue("@IsMonthly",IsMonthly);
            command.Parameters.AddWithValue("@NumberDaysOfCustomMonth", NumberDaysOfCustomMonth);
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
