using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace CarRental_DataAccess
{
    public class clsContractPaymentScheduleData
    {
        public static int AddNewContractObligation(int ApplicationID, Byte TypeObligation, Byte SchedulingMethod, double DeservedAmount, double AmountPaid, double RemainingAmount, DateTime DueDate, DateTime? PaymentDate, Byte PaymentStatus, int? PaymentByUserID, int? AmountSpentID, bool IsActive, byte? ReasonInActive, int? PartOfObligationID)
        {
            int ObligationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO ContractPaymentSchedules ( ApplicationID, TypeObligation, SchedulingMethod, DeservedAmount, AmountPaid, RemainingAmount, DueDate, PaymentDate, PaymentStatus, PaymentByUserID, AmountSpentID, IsActive, ReasonInActive,PartOfObligationID)
                             VALUES ( @ApplicationID, @TypeObligation, @SchedulingMethod, @DeservedAmount, @AmountPaid, @RemainingAmount, @DueDate, @PaymentDate, @PaymentStatus, @PaymentByUserID,@AmountSpentID, @IsActive, @ReasonInActive,@PartOfObligationID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@TypeObligation", TypeObligation);
            command.Parameters.AddWithValue("@SchedulingMethod", SchedulingMethod);
            command.Parameters.AddWithValue("@DeservedAmount", DeservedAmount);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            command.Parameters.AddWithValue("@RemainingAmount", RemainingAmount);
            command.Parameters.AddWithValue("@DueDate", DueDate);
            command.Parameters.AddWithValue("@PaymentDate", (object)PaymentDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
            command.Parameters.AddWithValue("@PaymentByUserID", (object)PaymentByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID ?? DBNull.Value);
            command.Parameters.AddWithValue("@ReasonInActive", (object)ReasonInActive ?? DBNull.Value);
            command.Parameters.AddWithValue("@PartOfObligationID", (object)PartOfObligationID ?? DBNull.Value);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ObligationID = insertedID;
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


            return ObligationID;
        }
        public static bool GetContractObligationInfoByID(int ObligationID, ref int ApplicationID, ref Byte TypeObligation, ref Byte SchedulingMethod, ref double DeservedAmount, ref double AmountPaid, ref double RemainingAmount, ref DateTime DueDate, ref DateTime? PaymentDate, ref Byte PaymentStatus,
             ref int? PaymentByUserID, ref int? AmountSpentID, ref bool IsActive, ref byte? ReasonInActive, ref int? PartOfObligationID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ContractPaymentSchedules WHERE ObligationID = @ObligationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ObligationID", ObligationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    TypeObligation = (Byte)reader["TypeObligation"];
                    SchedulingMethod = (Byte)reader["SchedulingMethod"];
                    DeservedAmount = double.Parse(reader["DeservedAmount"].ToString());
                    AmountPaid = double.Parse(reader["AmountPaid"].ToString());
                    RemainingAmount = double.Parse(reader["RemainingAmount"].ToString());
                    DueDate = (DateTime)reader["DueDate"];
                    if (reader["PaymentDate"] != DBNull.Value)
                        PaymentDate = (DateTime)reader["PaymentDate"];
                    PaymentStatus = (Byte)reader["PaymentStatus"];
                    if (reader["PaymentByUserID"] != DBNull.Value)
                        PaymentByUserID = (int)reader["PaymentByUserID"];

                    if (reader["AmountSpentID"] != DBNull.Value)
                        AmountSpentID = (int)reader["AmountSpentID"];

                    IsActive = (bool)reader["IsActive"];

                    if (reader["ReasonInActive"] != DBNull.Value)
                        ReasonInActive = (byte)reader["ReasonInActive"];
                    if (reader["PartOfObligationID"] != DBNull.Value)
                        PartOfObligationID = (int)reader["PartOfObligationID"];
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
        public static bool ClearingOldInstallments(int ApplicationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update ContractPaymentSchedules 
                             set 
                              DeservedAmount=AmountPaid
							 ,RemainingAmount=AmountPaid
                             ,IsActive = case when AmountPaid>0 and PaymentStatus=3 then 1 else 0 end
                             ,ReasonInActive = case when AmountPaid=0 then 1 else null end
                             ,PaymentStatus =case when AmountPaid>0 then 3 else 1 end 
                             where ( ApplicationID=@ApplicationID and IsActive=1)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

            return true;
        }
        public static bool UpdateThePaymentScheduleAfterPayingOneInstallment(int ObligationID, int PartOfObligationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update ContractPaymentSchedules 
                             set 
							 RemainingAmount=0,
							 PaymentStatus=3,
							 PaymentDate = GETDATE()
                             where PartOfObligationID=@ObligationID;

update ContractPaymentSchedules 
                             set 
                             AmountPaid+=(select AmountPaid from ContractPaymentSchedules  where ObligationID =@ObligationID),
							 RemainingAmount-=(select AmountPaid from ContractPaymentSchedules  where ObligationID =@ObligationID),
							 PaymentStatus=2
                             where ObligationID=@PartOfObligationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ObligationID", ObligationID);
            command.Parameters.AddWithValue("@PartOfObligationID", PartOfObligationID);
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
        public static bool IsContractObligationExist(int ObligationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM ContractPaymentSchedules WHERE ObligationID = @ObligationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ObligationID", ObligationID);

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
        public static bool IsContractExist(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM ContractPaymentSchedules WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static DateTime? GetLstPaidInstallmentDateForPartialPayments(int ApplicationID)
        {
            DateTime? LastDate = null;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select top(1) DueDate from ContractPaymentSchedules join ContractPaymentSchedulingApplications on ContractPaymentSchedulingApplications.ApplicationID=ContractPaymentSchedules.ApplicationID 
where ContractPaymentSchedulingApplications.ApplicationID=@ApplicationID and ContractPaymentSchedules.IsActive=1 and ContractPaymentSchedules.PaymentStatus=3and ContractPaymentSchedules.TypeObligation=4 order by DueDate desc";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LastDate = (DateTime)reader[0];
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return LastDate;
        }
        public static int? GetLstOrderPaidInstallmentForFinalPayment(int ApplicationID)
        {
            int? lOrder = null;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select  count(*) from ContractPaymentSchedules join ContractPaymentSchedulingApplications on ContractPaymentSchedulingApplications.ApplicationID=ContractPaymentSchedules.ApplicationID 
where ContractPaymentSchedulingApplications.ApplicationID=@ApplicationID and ContractPaymentSchedules.IsActive=1 and ContractPaymentSchedules.AmountPaid!=0 and ContractPaymentSchedules.TypeObligation=2 ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lOrder = (int)reader[0];
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return lOrder;
        }
        public static DataTable GetAllInstallmentsDueThisMonth(short Year,Byte Month)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * From View_InstallmentsDue
                            where Month(DueDate) = @Month and Year(DueDate)=@Year and IsActive =1
                            order by DueDate ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Month", Month);
            command.Parameters.AddWithValue("@Year", Year);

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
        public static DataTable GetAllInstallmentsDueThisMonth(short Year, Byte Month,int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * From View_InstallmentsDue
                            where Month(DueDate) between @Month and Year(DueDate)=@Year and BranchID=@BranchID and IsActive =1
                            order by DueDate";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Month", Month);
            command.Parameters.AddWithValue("@Year", Year);
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
        public static DataTable GetAllContractPaymentSchedules()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * From View_InstallmentsDue where IsActive =1";

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
        public static DataTable GetAllContractPaymentSchedules(int ApplicationID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from View_InstallmentsDue where ApplicationID=@ApplicationID and IsActive =1 order by dueDate";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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
        public static DataTable GetAllContractPaymentSchedulesByBranchID(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from View_InstallmentsDue where BranchID=@BranchID and IsActive =1";
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
        public static bool GenerateContractPaymentSchedules(DataTable dtContractPaymentSchedules, int ApplicationID, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                             INSERT INTO ContractPaymentSchedules 
                             ( ApplicationID, TypeObligation, SchedulingMethod, DeservedAmount, AmountPaid, RemainingAmount, DueDate, PaymentDate, PaymentStatus, PaymentByUserID, AmountSpentID, IsActive, ReasonInActive)
                             VALUES ( 
                                     @ApplicationID, 
                                     @TypeObligation, 
                                     @SchedulingMethod, 
                                     @DeservedAmount,
                                     @AmountPaid,
                                     @RemainingAmount,
                                     @DueDate,
                                     @PaymentDate,
                                     @PaymentStatus,
                                     null,
                                     null,
                                     @IsActive,
                                     null);";

            try
            {
                connection.Open();
                foreach (DataRow row in dtContractPaymentSchedules.Rows)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@TypeObligation", row["TypeObligation"]);
                    command.Parameters.AddWithValue("@SchedulingMethod", row["SchedulingMethod"]);
                    command.Parameters.AddWithValue("@DeservedAmount", row["DeservedAmount"]);
                    command.Parameters.AddWithValue("@AmountPaid", row["AmountPaid"]);
                    command.Parameters.AddWithValue("@RemainingAmount", row["RemainingAmount"]);
                    command.Parameters.AddWithValue("@DueDate", row["DueDate"]);
                    command.Parameters.AddWithValue("@PaymentDate", row["PaymentDate"]);
                    command.Parameters.AddWithValue("@PaymentStatus", row["PaymentStatus"]);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

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

            return rowsAffected == dtContractPaymentSchedules.Rows.Count;

        }
        public static bool DeleteContractObligation(int ObligationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete ContractPaymentSchedules 
                                where ObligationID = @ObligationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ObligationID", ObligationID);

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
        public static bool UpdateContractObligation(int ObligationID, int ApplicationID, Byte TypeObligation, Byte SchedulingMethod, double DeservedAmount, double AmountPaid, double RemainingAmount, DateTime DueDate, DateTime? PaymentDate, Byte PaymentStatus, int? PaymentByUserID, int? AmountSpentID, bool IsActive, byte? ReasonInActive, int? PartOfObligationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  ContractPaymentSchedules  
                            set
			ApplicationID = @ApplicationID,
			TypeObligation = @TypeObligation,
			SchedulingMethod = @SchedulingMethod,
			DeservedAmount = @DeservedAmount,
			AmountPaid = @AmountPaid,
			RemainingAmount = @RemainingAmount,
			DueDate = @DueDate,
			PaymentDate = @PaymentDate,
			PaymentStatus = @PaymentStatus,
			PaymentByUserID = @PaymentByUserID,
            AmountSpentID=@AmountSpentID,
            IsActive=@IsActive,
            ReasonInActive=@ReasonInActive,
            PartOfObligationID=@PartOfObligationID
            where ObligationID = @ObligationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ObligationID", ObligationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@TypeObligation", TypeObligation);
            command.Parameters.AddWithValue("@SchedulingMethod", SchedulingMethod);
            command.Parameters.AddWithValue("@DeservedAmount", DeservedAmount);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            command.Parameters.AddWithValue("@RemainingAmount", RemainingAmount);
            command.Parameters.AddWithValue("@DueDate", DueDate);
            command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
            command.Parameters.AddWithValue("@PaymentByUserID", PaymentByUserID);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID ?? DBNull.Value);
            command.Parameters.AddWithValue("@ReasonInActive", (object)ReasonInActive ?? DBNull.Value);
            command.Parameters.AddWithValue("@PartOfObligationID", (object)PartOfObligationID ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static bool IsDueInstallmentDateForSchedulingMethodFacilitator(int ApplicationID,int ObligationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select   Found=1 from 
(
                             select top(1) ObligationID from ContractPaymentSchedules where ApplicationID = @ApplicationID and PaymentStatus !=3 and SchedulingMethod=2 and IsActive=1
                             order by DueDate
                             )r1
                             where ObligationID=@ObligationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ObligationID", ObligationID);

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
        public static bool IsDueInstallmentDateForSchedulingMethodBasic(int ApplicationID, int ObligationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top(1) koko= 1 from ContractPaymentSchedules where 
DueDate < (select  DueDate from ContractPaymentSchedules where ObligationID=@ObligationID ) and ApplicationID =@ApplicationID  and PaymentStatus !=3  and IsActive=1 ";
                             

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ObligationID", ObligationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.Read();

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
        public static bool HaveTheFinalPaymentInstallmentsBeenScheduled(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select case when 
(select 1 from ContractPaymentSchedules where ApplicationID=@ApplicationID and TypeObligation=2 and SchedulingMethod=2)=1then 1
else 0 end";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
    }
}
