using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace CarRental_DataAccess
{
    public class clsContractData
    {
        // Implemention AddNew
        public static int AddNewContract(int BranchID, DateTime StartContract, DateTime EndContract, int TypeID,
            double ContractAmount, double InitialPayment, double FinalPayment, Byte PaymentType, Byte PaymentEveryYears,
            Byte PaymentEveryMonths, double TotalAmountPaid, double TotalRemainingAmount, DateTime? DeferredPaymentDueDate,
            Boolean AllowingFinalPaymentInstallments, Byte NumberOfMonthsOfFinalPaymentInstallments, Byte PaymentStatus,
            int CreatedByUserID, int? UpdatedByUserID, DateTime CreatedDate, DateTime? UpdatedDate,double InitialAmountPaid,double FinalAmountPaid)
        {
            int ContractID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Contracts ( BranchID, StartContract, EndContract, TypeID, ContractAmount, InitialPayment, FinalPayment,
PaymentType, PaymentEveryYears, PaymentEveryMonths, TotalAmountPaid, TotalRemainingAmount,DeferredPaymentDueDate, AllowingFinalPaymentInstallments,
NumberOfMonthsOfFinalPaymentInstallments, PaymentStatus, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate,IsActive,initialAmountpaid,finalamountpaid)
                             VALUES ( @BranchID, @StartContract, @EndContract, @TypeID, @ContractAmount, @InitialPayment,
@FinalPayment, @PaymentType, @PaymentEveryYears, @PaymentEveryMonths, @TotalAmountPaid, @TotalRemainingAmount,@DeferredPaymentDueDate
, @AllowingFinalPaymentInstallments, @NumberOfMonthsOfFinalPaymentInstallments, @PaymentStatus, @CreatedByUserID, @UpdatedByUserID, @CreatedDate,
@UpdatedDate,1,@InitialAmountPaid,@FinalAmountPaid);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@StartContract", StartContract);
            command.Parameters.AddWithValue("@EndContract", EndContract);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@ContractAmount", ContractAmount);
            command.Parameters.AddWithValue("@InitialPayment", InitialPayment);
            command.Parameters.AddWithValue("@FinalPayment", FinalPayment);
            command.Parameters.AddWithValue("@PaymentType", PaymentType);
            command.Parameters.AddWithValue("@PaymentEveryYears", PaymentEveryYears);
            command.Parameters.AddWithValue("@PaymentEveryMonths", PaymentEveryMonths);
            command.Parameters.AddWithValue("@TotalAmountPaid", TotalAmountPaid);
            command.Parameters.AddWithValue("@TotalRemainingAmount", TotalRemainingAmount);
            command.Parameters.AddWithValue("@AllowingFinalPaymentInstallments", AllowingFinalPaymentInstallments);
            command.Parameters.AddWithValue("@NumberOfMonthsOfFinalPaymentInstallments", NumberOfMonthsOfFinalPaymentInstallments);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@DeferredPaymentDueDate", (object)DeferredPaymentDueDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedDate", (object)UpdatedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@InitialAmountPaid", InitialAmountPaid);
            command.Parameters.AddWithValue("@FinalAmountPaid", FinalAmountPaid);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ContractID = insertedID;
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


            return ContractID;
        }
        // Implemention GetByID
        public static bool GetContractInfoByID(int ContractID, ref int BranchID, ref DateTime StartContract,
            ref DateTime EndContract, ref int TypeID, ref double ContractAmount, ref double InitialPayment,
            ref double FinalPayment, ref Byte PaymentType, ref Byte PaymentEveryYears, ref Byte PaymentEveryMonths,
            ref double TotalAmountPaid, ref double TotalRemainingAmount, ref DateTime? DeferredPaymentDueDate,
            ref Boolean AllowingFinalPaymentInstallments, ref Byte NumberOfMonthsOfFinalPaymentInstallments,
            ref Byte PaymentStatus, ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime CreatedDate,
            ref DateTime? UpdatedDate, ref bool IsActive,ref double InitialAmountPaid,ref double FinalAmountPaid )
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Contracts WHERE ContractID = @ContractID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContractID", ContractID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    BranchID = (int)reader["BranchID"];
                    StartContract = (DateTime)reader["StartContract"];
                    EndContract = (DateTime)reader["EndContract"];
                    TypeID = (int)reader["TypeID"];
                    ContractAmount = double.Parse(reader["ContractAmount"].ToString());
                    InitialPayment = double.Parse(reader["InitialPayment"].ToString());
                    FinalPayment = double.Parse(reader["FinalPayment"].ToString());
                    PaymentType = (Byte)reader["PaymentType"];
                    PaymentEveryYears = (Byte)reader["PaymentEveryYears"];
                    PaymentEveryMonths = (Byte)reader["PaymentEveryMonths"];
                    TotalAmountPaid = double.Parse(reader["TotalAmountPaid"].ToString());
                    TotalRemainingAmount = double.Parse(reader["TotalRemainingAmount"].ToString());
                    AllowingFinalPaymentInstallments = (Boolean)reader["AllowingFinalPaymentInstallments"];
                    NumberOfMonthsOfFinalPaymentInstallments = (Byte)reader["NumberOfMonthsOfFinalPaymentInstallments"];
                    PaymentStatus = (Byte)reader["PaymentStatus"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    InitialAmountPaid = double.Parse(reader["InitialAmountPaid"].ToString());
                    FinalAmountPaid = double.Parse(reader["FinalAmountPaid"].ToString());
                    IsActive = (bool)reader["IsActive"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];

                    CreatedDate = (DateTime)reader["CreatedDate"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];

                    if (reader["DeferredPaymentDueDate"] != DBNull.Value)
                        DeferredPaymentDueDate = (DateTime)reader["DeferredPaymentDueDate"];
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
        public static bool GetContractInfoByID(int ContractID, int BranchID, ref DateTime StartContract, 
            ref DateTime EndContract, ref int TypeID, ref double ContractAmount, ref double InitialPayment,
            ref double FinalPayment, ref Byte PaymentType, ref Byte PaymentEveryYears, ref Byte PaymentEveryMonths,
            ref double TotalAmountPaid, ref double TotalRemainingAmount, ref DateTime? DeferredPaymentDueDate,
            ref Boolean AllowingFinalPaymentInstallments, ref Byte NumberOfMonthsOfFinalPaymentInstallments,
            ref Byte PaymentStatus, ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime CreatedDate, 
            ref DateTime? UpdatedDate,bool IsActive, ref double InitialAmountPaid, ref double FinalAmountPaid)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Contracts WHERE ContractID = @ContractID and BranchID=@BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContractID", ContractID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    StartContract = (DateTime)reader["StartContract"];
                    EndContract = (DateTime)reader["EndContract"];
                    TypeID = (int)reader["TypeID"];
                    ContractAmount = double.Parse(reader["ContractAmount"].ToString());
                    InitialPayment = double.Parse(reader["InitialPayment"].ToString());
                    FinalPayment = double.Parse(reader["FinalPayment"].ToString());
                    PaymentType = (Byte)reader["PaymentType"];
                    PaymentEveryYears = (Byte)reader["PaymentEveryYears"];
                    PaymentEveryMonths = (Byte)reader["PaymentEveryMonths"];
                    TotalAmountPaid = double.Parse(reader["TotalAmountPaid"].ToString());
                    TotalRemainingAmount = double.Parse(reader["TotalRemainingAmount"].ToString());
                    AllowingFinalPaymentInstallments = (Boolean)reader["AllowingFinalPaymentInstallments"];
                    NumberOfMonthsOfFinalPaymentInstallments = (Byte)reader["NumberOfMonthsOfFinalPaymentInstallments"];
                    PaymentStatus = (Byte)reader["PaymentStatus"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsActive = (bool)reader["IsActive"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];

                    CreatedDate = (DateTime)reader["CreatedDate"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];

                    if (reader["DeferredPaymentDueDate"] != DBNull.Value)
                        DeferredPaymentDueDate = (DateTime)reader["DeferredPaymentDueDate"];
                    InitialAmountPaid = double.Parse(reader["InitialAmountPaid"].ToString());
                    FinalAmountPaid = double.Parse(reader["FinalAmountPaid"].ToString());
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

        public static bool IsContractExist(int ContractID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Contracts WHERE ContractID = @ContractID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContractID", ContractID);

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
        public static DataTable GetAllContracts(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from View_Contracts where BranchID=@BranchID";

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
        public static DataTable GetAllContracts()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from View_Contracts ";

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

        public static bool DeleteContract(int ContractID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Contracts 
                                where ContractID = @ContractID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContractID", ContractID);

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

        public static bool UpdateContract(int ContractID, int BranchID, DateTime StartContract, DateTime EndContract,
            int TypeID, double ContractAmount, double InitialPayment, double FinalPayment, Byte PaymentType,
            Byte PaymentEveryYears, Byte PaymentEveryMonths, double TotalAmountPaid, double TotalRemainingAmount,
            DateTime? DeferredPaymentDueDate, Boolean AllowingFinalPaymentInstallments, Byte NumberOfMonthsOfFinalPaymentInstallments,
            Byte PaymentStatus, int CreatedByUserID, int? UpdatedByUserID, DateTime CreatedDate, DateTime? UpdatedDate,bool IsActive,double InitialAmountPaid,double FinalAmountPaid)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Contracts  
                            set
			BranchID = @BranchID,
			StartContract = @StartContract,
			EndContract = @EndContract,
			TypeID = @TypeID,
			ContractAmount = @ContractAmount,
			InitialPayment = @InitialPayment,
			FinalPayment = @FinalPayment,
			PaymentType = @PaymentType,
			PaymentEveryYears = @PaymentEveryYears,
			PaymentEveryMonths = @PaymentEveryMonths,
			TotalAmountPaid = @TotalAmountPaid,
			TotalRemainingAmount = @TotalRemainingAmount,
            DeferredPaymentDueDate=@DeferredPaymentDueDate,
			AllowingFinalPaymentInstallments = @AllowingFinalPaymentInstallments,
			NumberOfMonthsOfFinalPaymentInstallments = @NumberOfMonthsOfFinalPaymentInstallments,
			PaymentStatus = @PaymentStatus,
			CreatedByUserID = @CreatedByUserID,
			UpdatedByUserID = @UpdatedByUserID,
            InitialAmountPaid = @InitialAmountPaid,
            FinalAmountPaid=@FinalAmountPaid,
			CreatedDate = @CreatedDate,
			UpdatedDate = @UpdatedDate
             where ContractID = @ContractID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContractID", ContractID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@StartContract", StartContract);
            command.Parameters.AddWithValue("@EndContract", EndContract);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@ContractAmount", ContractAmount);
            command.Parameters.AddWithValue("@InitialPayment", InitialPayment);
            command.Parameters.AddWithValue("@FinalPayment", FinalPayment);
            command.Parameters.AddWithValue("@PaymentType", PaymentType);
            command.Parameters.AddWithValue("@PaymentEveryYears", PaymentEveryYears);
            command.Parameters.AddWithValue("@DeferredPaymentDueDate", (object)DeferredPaymentDueDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@PaymentEveryMonths", PaymentEveryMonths);
            command.Parameters.AddWithValue("@TotalAmountPaid", TotalAmountPaid);
            command.Parameters.AddWithValue("@TotalRemainingAmount", TotalRemainingAmount);
            command.Parameters.AddWithValue("@AllowingFinalPaymentInstallments", AllowingFinalPaymentInstallments);
            command.Parameters.AddWithValue("@NumberOfMonthsOfFinalPaymentInstallments", NumberOfMonthsOfFinalPaymentInstallments);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", ((object)UpdatedByUserID ?? DBNull.Value));
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@UpdatedDate", ((object)UpdatedDate ?? DBNull.Value));
            command.Parameters.AddWithValue("@InitialAmountPaid", InitialAmountPaid);
            command.Parameters.AddWithValue("@FinalAmountPaid", FinalAmountPaid);
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
