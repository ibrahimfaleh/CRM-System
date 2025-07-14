using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsRentalTransactionData
    {
         
        public static int AddNewRentalTransaction(int BookingID, int? ReturnID, double Vat, int InitialPaymentMethodID, int? FinalPaymentMethodID, double PaidInitialTotalDueAmount, double? ActualTotalDueAmount, double? TotalRemaining, double? TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate, int CreatedByUserID, int? UpdateByUserID)
        {
            int TransactionID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO RentalTransaction ( BookingID, ReturnID,Vat, InitialPaymentMethodID,FinalPaymentMethodID, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate,CreatedByUserID,UpdateByUserID)
                             VALUES ( @BookingID, @ReturnID,@Vat, @InitialPaymentMethodID,@FinalPaymentMethodID, @PaidInitialTotalDueAmount, @ActualTotalDueAmount, @TotalRemaining, @TotalRefundedAmount, @TransactionDate, @UpdatedTransactionDate,@CreatedByUserID,@UpdateByUserID);
                             SELECT SCOPE_IDENTITY();

                             update Users
                             set CountCreatedRentalBooking+=1
                             where UserID=@CreatedByUserID

                              Update Vehicles 
                         set NumberTimesRented+=1
                         where VehicleID=
                         (SELECT        RentalBooking.VehicleID
                         FROM            RentalBooking INNER JOIN
                         RentalTransaction ON RentalBooking.BookingID = RentalTransaction.BookingID
						 where RentalTransaction.TransactionID=(SELECT SCOPE_IDENTITY()))";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@ReturnID", (object)ReturnID ?? DBNull.Value);
            command.Parameters.AddWithValue("@Vat", Vat);
            command.Parameters.AddWithValue("@InitialPaymentMethodID", InitialPaymentMethodID);
            command.Parameters.AddWithValue("@FinalPaymentMethodID", (object)FinalPaymentMethodID ?? DBNull.Value);
            command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
            command.Parameters.AddWithValue("@ActualTotalDueAmount", (object)ActualTotalDueAmount ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalRemaining", (object)TotalRemaining ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalRefundedAmount", (object)TotalRefundedAmount ?? DBNull.Value);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@UpdatedTransactionDate", (object)UpdatedTransactionDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdateByUserID", (object)UpdateByUserID ?? DBNull.Value);

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
         
        public static bool GetRentalTransactionInfoByID(int TransactionID, ref int BookingID, ref int? ReturnID, ref double Vat, ref int InitialPaymentMethodID,
            ref int? FinalPaymentMethodID, ref double PaidInitialTotalDueAmount, ref double? ActualTotalDueAmount,
            ref double? TotalRemaining, ref double? TotalRefundedAmount, ref DateTime TransactionDate,
            ref DateTime? UpdatedTransactionDate, ref int CreatedByUserID, ref int? UpdateByUserID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM RentalTransaction WHERE TransactionID = @TransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found

                    BookingID = (int)reader["BookingID"];
                    if (reader["ReturnID"] == DBNull.Value)
                        ReturnID = null;
                    else
                        ReturnID = (int?)reader["ReturnID"];
                    Vat = double.Parse(reader["Vat"].ToString());
                    InitialPaymentMethodID = (int)reader["InitialPaymentMethodID"];

                    if (reader["FinalPaymentMethodID"] == DBNull.Value)
                        FinalPaymentMethodID = null;
                    else
                        FinalPaymentMethodID = (int)reader["FinalPaymentMethodID"];

                    PaidInitialTotalDueAmount = double.Parse(reader["PaidInitialTotalDueAmount"].ToString());


                    if (reader["ActualTotalDueAmount"] == DBNull.Value)
                        ActualTotalDueAmount = null;
                    else
                        ActualTotalDueAmount = double.Parse(reader["ActualTotalDueAmount"].ToString());
                    if (reader["TotalRemaining"] == DBNull.Value)
                        TotalRemaining = null;
                    else
                        TotalRemaining = double.Parse(reader["TotalRemaining"].ToString());
                    if (reader["TotalRefundedAmount"] == DBNull.Value)
                        TotalRefundedAmount = null;
                    else
                        TotalRefundedAmount = double.Parse(reader["TotalRefundedAmount"].ToString());
                    TransactionDate = (DateTime)reader["TransactionDate"];
                    if (reader["UpdatedTransactionDate"] == DBNull.Value)
                        UpdatedTransactionDate = null;
                    else
                        UpdatedTransactionDate = (DateTime?)reader["UpdatedTransactionDate"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["UpdateByUserID"] == DBNull.Value)
                        UpdateByUserID = null;
                    else
                        UpdateByUserID = (int?)reader["UpdateByUserID"];



                    isFound = true;


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
        public static bool GetNewRentalTransactionInfoByPlateNumber(string PlateNumber,ref int TransactionID, ref int BookingID, ref int? ReturnID, ref double Vat, ref int InitialPaymentMethodID,
    ref int? FinalPaymentMethodID, ref double PaidInitialTotalDueAmount, ref double? ActualTotalDueAmount,
    ref double? TotalRemaining, ref double? TotalRefundedAmount, ref DateTime TransactionDate,
    ref DateTime? UpdatedTransactionDate, ref int CreatedByUserID, ref int? UpdateByUserID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT *    from RentalTransaction join rentalbooking on rentalbooking.bookingid=RentalTransaction.BookingID join vehicles on vehicles.vehicleid=RentalBooking.vehicleid WHERE Vehicles.PlateNumber=@PlateNumber and bookingstatus=0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TransactionID = (int)reader["TransactionID"];
                    BookingID = (int)reader["BookingID"];
                    if (reader["ReturnID"] == DBNull.Value)
                        ReturnID = null;
                    else
                        ReturnID = (int?)reader["ReturnID"];
                    Vat = double.Parse(reader["Vat"].ToString());
                    InitialPaymentMethodID = (int)reader["InitialPaymentMethodID"];

                    if (reader["FinalPaymentMethodID"] == DBNull.Value)
                        FinalPaymentMethodID = null;
                    else
                        FinalPaymentMethodID = (int)reader["FinalPaymentMethodID"];

                    PaidInitialTotalDueAmount = double.Parse(reader["PaidInitialTotalDueAmount"].ToString());


                    if (reader["ActualTotalDueAmount"] == DBNull.Value)
                        ActualTotalDueAmount = null;
                    else
                        ActualTotalDueAmount = double.Parse(reader["ActualTotalDueAmount"].ToString());
                    if (reader["TotalRemaining"] == DBNull.Value)
                        TotalRemaining = null;
                    else
                        TotalRemaining = double.Parse(reader["TotalRemaining"].ToString());
                    if (reader["TotalRefundedAmount"] == DBNull.Value)
                        TotalRefundedAmount = null;
                    else
                        TotalRefundedAmount = double.Parse(reader["TotalRefundedAmount"].ToString());
                    TransactionDate = (DateTime)reader["TransactionDate"];
                    if (reader["UpdatedTransactionDate"] == DBNull.Value)
                        UpdatedTransactionDate = null;
                    else
                        UpdatedTransactionDate = (DateTime?)reader["UpdatedTransactionDate"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["UpdateByUserID"] == DBNull.Value)
                        UpdateByUserID = null;
                    else
                        UpdateByUserID = (int?)reader["UpdateByUserID"];



                    isFound = true;


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
        public static bool GetRentalTransactionInfoByBookingID(ref int TransactionID, int BookingID, ref int? ReturnID, ref double Vat, ref int InitialPaymentMethodID, ref int? FinalPaymentMethodID, ref double PaidInitialTotalDueAmount
            , ref double? ActualTotalDueAmount, ref double? TotalRemaining,
            ref double? TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime? UpdatedTransactionDate, ref int CreatedByUserID, ref int? UpdateByUserID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM RentalTransaction WHERE BookingID = @BookingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    TransactionID = (int)reader["TransactionID"];
                    if (reader["ReturnID"] == DBNull.Value)
                        ReturnID = null;
                    else
                        ReturnID = (int?)reader["ReturnID"];
                    Vat = double.Parse(reader["Vat"].ToString());
                    InitialPaymentMethodID = (int)reader["InitialPaymentMethodID"];
                    FinalPaymentMethodID = (int)(object)reader["FinalPaymentMethodID"];


                    PaidInitialTotalDueAmount = double.Parse(reader["PaidInitialTotalDueAmount"].ToString());


                    if (reader["ActualTotalDueAmount"] == DBNull.Value)
                        ActualTotalDueAmount = null;
                    else
                        ActualTotalDueAmount = double.Parse(reader["ActualTotalDueAmount"].ToString());
                    if (reader["TotalRemaining"] == DBNull.Value)
                        TotalRemaining = null;
                    else
                        TotalRemaining = (double?)reader["TotalRemaining"];
                    if (reader["TotalRefundedAmount"] == DBNull.Value)
                        TotalRefundedAmount = null;
                    else
                        TotalRefundedAmount = double.Parse(reader["TotalRefundedAmount"].ToString());
                    TransactionDate = (DateTime)reader["TransactionDate"];
                    if (reader["UpdatedTransactionDate"] == DBNull.Value)
                        UpdatedTransactionDate = null;
                    else
                        UpdatedTransactionDate = (DateTime?)reader["UpdatedTransactionDate"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["UpdateByUserID"] == DBNull.Value)
                        UpdateByUserID = null;
                    else
                        UpdateByUserID = (int?)reader["UpdateByUserID"];

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
         
        public static float GetVatBayBookingID(int BookingID)
        {
            float Vat;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Vat FROM RentalTransaction WHERE BookingID = @BookingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Vat = float.Parse(reader["Vat"].ToString());
                }
                else
                {
                    // The record was not found
                    Vat = 1;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                Vat = 1;
            }
            finally
            {
                connection.Close();
            }

            return Vat;
        }
        public static bool IsRentalTransactionExist(int TransactionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM RentalTransaction WHERE TransactionID = @TransactionID";

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
         
        public static DataTable GetAllRentalTransaction()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Cities.CityName,Branches.StreetName,RentalTransaction.TransactionID, Vehicles.Name,ModelName=(select MakeModels.ModelName from MakeModels where MakeModels.ModelID=  Vehicles.ModelID), Vehicles.Year, Vehicles.PlateNumber, RentalBooking.RentalStartDate, RentalBooking.InitialRentalDays, RentalBooking.InitialRentalMonths, 
                  RentalBooking.RentalPricePerDay, RentalBooking.RentalPricePerMonth, RentalBooking.InitialTotalDueAmount, RentalTransaction.PaidInitialTotalDueAmount, VehicleReturns.ActualReturnDate, VehicleReturns.ActualRentalDays, 
                  VehicleReturns.ActualRentalMonths, VehicleReturns.AdditionalHours, VehicleReturns.ConsumedMileage, RentalTransaction.ActualTotalDueAmount, RentalTransaction.TotalRemaining, RentalTransaction.TotalRefundedAmount, 
                  Customers.CustomerID,FullName=( People.FirstName+' '+People.LastName), People.NationalNo, RentalTransaction.CreatedByUserID, RentalTransaction.UpdateByUserID,case when RentalBooking.BookingStatus=0 then 'New' else 'Completed' end as Status
FROM     Vehicles INNER JOIN
                  People INNER JOIN
                  Customers ON People.PersonID = Customers.PersonID INNER JOIN
                  RentalBooking ON Customers.CustomerID = RentalBooking.CustomerID ON Vehicles.VehicleID = RentalBooking.VehicleID inner JOIN
                  RentalTransaction on RentalBooking.BookingID=RentalTransaction.BookingID left JOIN
                  VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID join 
				  Branches on RentalBooking.BranchID=Branches.BranchID join 
				  Cities on Branches.CityID=Cities.CityID
                  order by RentalBooking.RentalStartDate desc"

;
            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)

                {
                    dt.Load(reader);
                    // dt.Load(reader2);

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
        public static DataTable GetAllRentalTransactionForBranchIsPublic()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        RentalTransaction.TransactionID, Vehicles.Name,ModelName=(select MakeModels.ModelName from MakeModels where MakeModels.ModelID=  Vehicles.ModelID), Vehicles.Year, Vehicles.PlateNumber, RentalBooking.RentalStartDate, RentalBooking.InitialRentalDays, RentalBooking.InitialRentalMonths, 
                  RentalBooking.RentalPricePerDay, RentalBooking.RentalPricePerMonth, RentalBooking.InitialTotalDueAmount, RentalTransaction.PaidInitialTotalDueAmount, VehicleReturns.ActualReturnDate, VehicleReturns.ActualRentalDays, 
                  VehicleReturns.ActualRentalMonths, VehicleReturns.AdditionalHours, VehicleReturns.ConsumedMileage, RentalTransaction.ActualTotalDueAmount, RentalTransaction.TotalRemaining, RentalTransaction.TotalRefundedAmount, 
                  Customers.CustomerID,FullName=( People.FirstName+' '+People.LastName), People.NationalNo, RentalTransaction.CreatedByUserID, RentalTransaction.UpdateByUserID,case when RentalBooking.BookingStatus=0 then 'New' else 'Completed' end as Status
				  ,vehicles.VehicleID
FROM            Branches inner JOIN
                         RentalBooking ON Branches.BranchID = RentalBooking.BranchID left JOIN
                         RentalTransaction ON RentalBooking.BookingID = RentalTransaction.BookingID INNER JOIN
                         Vehicles ON  RentalBooking.VehicleID = Vehicles.VehicleID INNER JOIN
                         Customers ON RentalBooking.CustomerID = Customers.CustomerID INNER JOIN
                         People ON Customers.PersonID = People.PersonID left JOIN
                         VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID
						 where Branches.isPublic=1
						 order by RentalBooking.RentalStartDate desc;"

;
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)

                {
                    dt.Load(reader);
                    // dt.Load(reader2);

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
        public static DataTable GetAllRentalTransactionByBranchID(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Cities.CityName,Branches.StreetName,RentalTransaction.TransactionID, Vehicles.Name,ModelName=(select MakeModels.ModelName from MakeModels where MakeModels.ModelID=  Vehicles.ModelID), Vehicles.Year, Vehicles.PlateNumber, RentalBooking.RentalStartDate, RentalBooking.InitialRentalDays, RentalBooking.InitialRentalMonths, 
                  RentalBooking.RentalPricePerDay, RentalBooking.RentalPricePerMonth, RentalBooking.InitialTotalDueAmount, RentalTransaction.PaidInitialTotalDueAmount, VehicleReturns.ActualReturnDate, VehicleReturns.ActualRentalDays, 
                  VehicleReturns.ActualRentalMonths, VehicleReturns.AdditionalHours, VehicleReturns.ConsumedMileage, RentalTransaction.ActualTotalDueAmount, RentalTransaction.TotalRemaining, RentalTransaction.TotalRefundedAmount, 
                  Customers.CustomerID,FullName=( People.FirstName+' '+People.LastName), People.NationalNo, RentalTransaction.CreatedByUserID, RentalTransaction.UpdateByUserID,case when RentalBooking.BookingStatus=0 then 'New' else 'Completed' end as Status
FROM     Vehicles INNER JOIN
                  People INNER JOIN
                  Customers ON People.PersonID = Customers.PersonID INNER JOIN
                  RentalBooking ON Customers.CustomerID = RentalBooking.CustomerID ON Vehicles.VehicleID = RentalBooking.VehicleID inner JOIN
                  RentalTransaction on RentalBooking.BookingID=RentalTransaction.BookingID left JOIN
                  VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID join 
				  Branches on RentalBooking.BranchID=Branches.BranchID join 
				  Cities on Branches.CityID=Cities.CityID	
						 where Branches.BranchID=@BranchID
						 order by RentalBooking.RentalStartDate desc;"

;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)

                {
                    dt.Load(reader);
                    // dt.Load(reader2);

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
        public static DataTable GetAllRentalTransactionByCustomerID(int CustomerID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Cities.CityName,Branches.StreetName,RentalTransaction.TransactionID, Vehicles.Name,ModelName=(select MakeModels.ModelName from MakeModels where MakeModels.ModelID=  Vehicles.ModelID), Vehicles.Year, Vehicles.PlateNumber, RentalBooking.RentalStartDate, RentalBooking.InitialRentalDays, RentalBooking.InitialRentalMonths, 
                  RentalBooking.RentalPricePerDay, RentalBooking.RentalPricePerMonth, RentalBooking.InitialTotalDueAmount, RentalTransaction.PaidInitialTotalDueAmount, VehicleReturns.ActualReturnDate, VehicleReturns.ActualRentalDays, 
                  VehicleReturns.ActualRentalMonths, VehicleReturns.AdditionalHours, VehicleReturns.ConsumedMileage, RentalTransaction.ActualTotalDueAmount, RentalTransaction.TotalRemaining, RentalTransaction.TotalRefundedAmount, 
                  Customers.CustomerID,FullName=( People.FirstName+' '+People.LastName), People.NationalNo, RentalTransaction.CreatedByUserID, RentalTransaction.UpdateByUserID,case when RentalBooking.BookingStatus=0 then 'New' else 'Completed' end as Status
FROM     Vehicles INNER JOIN
                  People INNER JOIN
                  Customers ON People.PersonID = Customers.PersonID INNER JOIN
                  RentalBooking ON Customers.CustomerID = RentalBooking.CustomerID ON Vehicles.VehicleID = RentalBooking.VehicleID inner JOIN
                  RentalTransaction on RentalBooking.BookingID=RentalTransaction.BookingID left JOIN
                  VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID join 
				  Branches on RentalBooking.BranchID=Branches.BranchID join 
				  Cities on Branches.CityID=Cities.CityID			  
where RentalBooking.CustomerID=@CustomerID  order by RentalBooking.RentalStartDate desc;

";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static bool DeleteRentalTransaction(int TransactionID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete RentalTransaction 
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

        public static bool UpdateRentalTransaction(int TransactionID, int BookingID, int? ReturnID, double Vat, int InitialPaymentMethodID, int? FinalPaymentMethodID, double PaidInitialTotalDueAmount, double? AdditionalKilometerCharges, double? TotalHourlyCharge,
            double? ActualTotalDueAmount, double? TotalRemaining,
            double? TotalRefundedAmount, DateTime TransactionDate, DateTime? UpdatedTransactionDate, int CreatedByUserID, int? UpdateByUserID, double TotalRentalIncome)
         {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
Update
RentalTransaction  
                            set
			BookingID = @BookingID,
			ReturnID = @ReturnID,
            Vat=@Vat,
			InitialPaymentMethodID = @InitialPaymentMethodID,
            FinalPaymentMethodID=@FinalPaymentMethodID,
            AdditionalKilometerCharges=@AdditionalKilometerCharges,
			PaidInitialTotalDueAmount = @PaidInitialTotalDueAmount,
			ActualTotalDueAmount = @ActualTotalDueAmount,
			TotalRemaining = @TotalRemaining,
			TotalRefundedAmount = @TotalRefundedAmount,
            TotalHourlyCharge=@TotalHourlyCharge,
			TransactionDate = @TransactionDate,
			UpdatedTransactionDate = @UpdatedTransactionDate,
            CreatedByUserID=@CreatedByUserID,
            UpdateByUserID=@UpdateByUserID
             where TransactionID = @TransactionID;


                Update a

				set a.NumberRentedTransActions=a.NumberRentedTransActions+1
				,a.InitialTotalDueAmountsAfterTax+=b.InitialTotalDueAmount*b.Vat
				,a.PaidInitialTotalDueAmounts+=b.PaidInitialTotalDueAmount
				,a.TotalPayments+=b.ActualTotalDueAmount
				,a.TotalRentPayments+=(b.ActualTotalDueAmount-b.AdditionalCharges)
				,a.TotalVehiclesBreakdownPayments+=b.AdditionalCharges
				,a.TotalInitialRentalDays+=b.InitialRentalDays
				,a.TotalActualRentalDays+=b.ActualRentalDays
				,a.TotalKilometersConsumed+=b.ConsumedMileage
				from Customers a inner join (SELECT RentalBooking.BookingID,RentalBooking.CustomerID,RentalTransaction.Vat, RentalBooking.InitialTotalDueAmount, RentalTransaction.PaidInitialTotalDueAmount, RentalTransaction.ActualTotalDueAmount, VehicleReturns.AdditionalCharges, RentalBooking.InitialRentalDays, 
                  VehicleReturns.ActualRentalDays, VehicleReturns.ConsumedMileage
                    FROM     RentalBooking INNER JOIN
                  RentalTransaction ON RentalBooking.BookingID = RentalTransaction.BookingID inner JOIN
                  VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID
				  where RentalTransaction.TransactionID=@TransactionID) b on a.CustomerID=b.CustomerID
				  where a.CustomerID=b.CustomerID

          
                  update Users
                  set TotalRentalIncome+=@TotalRentalIncome
                  where UserID=@CreatedByUserID;
                  

                   update Users
                   set CountVehiclesReturn+=1
                   where UserID=@UpdateByUserID;

			                               Update Vehicles 
                      set TotalRentalIncome+=@TotalRentalIncome
                      where VehicleID=
                      (SELECT        RentalBooking.VehicleID
                      FROM            RentalBooking INNER JOIN
                      RentalTransaction ON RentalBooking.BookingID = RentalTransaction.BookingID
			 where RentalTransaction.TransactionID=@TransactionID)
";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@ReturnID", ReturnID);
            command.Parameters.AddWithValue("@Vat", Vat);
            command.Parameters.AddWithValue("@InitialPaymentMethodID", InitialPaymentMethodID);
            command.Parameters.AddWithValue("@AdditionalKilometerCharges", AdditionalKilometerCharges);
            command.Parameters.AddWithValue("@TotalHourlyCharge", TotalHourlyCharge);
            command.Parameters.AddWithValue("@FinalPaymentMethodID", (object)FinalPaymentMethodID ?? DBNull.Value);
            command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
            command.Parameters.AddWithValue("@ActualTotalDueAmount", (object)ActualTotalDueAmount ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalRemaining", (object)TotalRemaining ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalRefundedAmount", (object)TotalRefundedAmount ?? DBNull.Value);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@UpdatedTransactionDate", (object)UpdatedTransactionDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdateByUserID", (object)UpdateByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@TotalRentalIncome", TotalRentalIncome);
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
