using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace CarRental_DataAccess
{
    public class clsContractPaymentSchedulingApplicationData
    {
        // Implemention AddNew
        public static int AddNewContractPaymentSchedulingApplication(int ContractID, int CreatedByUserID, int? UpdatedByUserID, DateTime CreatedDate, DateTime? UpdatedDate,byte status)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO ContractPaymentSchedulingApplications ( ContractID, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate,status)
                             VALUES ( @ContractID, @CreatedByUserID, @UpdatedByUserID, @CreatedDate, @UpdatedDate,@status);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContractID", ContractID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@UpdatedDate", (object)UpdatedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@status", status);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
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


            return ApplicationID;
        }
        // Implemention GetByID
        public static bool GetContractPaymentSchedulingApplicationInfoByID(int ApplicationID, ref int ContractID, 
            ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime CreatedDate, ref DateTime? UpdatedDate,
            ref byte status)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ContractPaymentSchedulingApplications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ContractID = (int)reader["ContractID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];
                    status = (byte)reader["status"];
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
        public static bool GetContractPaymentSchedulingApplicationInfoByContractID(ref int ApplicationID,  int ContractID, ref int CreatedByUserID, 
            ref int? UpdatedByUserID, ref DateTime CreatedDate, 
            ref DateTime? UpdatedDate,ref byte status)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ContractPaymentSchedulingApplications WHERE ContractID = @ContractID";
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

                    ApplicationID = (int)reader["ApplicationID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];
                    status = (byte)reader["status"];
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
        public static bool isContractPaymentSchedulingApplicationExistByContractID(int ContractID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM ContractPaymentSchedulingApplications WHERE ContractID = @ContractID";

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
        public static bool IsContractPaymentSchedulingApplicationExist(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM ContractPaymentSchedulingApplications WHERE ApplicationID = @ApplicationID";

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
        // Implemention GetAllDataTablw
        public static DataTable GetAllContractPaymentSchedulingApplications()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from View_SchedulingApplications order by createddate desc";

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
        public static DataTable GetAllContractPaymentSchedulingApplications(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from View_SchedulingApplications where BranchID =@BranchID order by  createddate desc ";

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
        // Implemention Delete

        public static bool DeleteContractPaymentSchedulingApplication(int ApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete ContractPaymentSchedulingApplications 
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool UpdateContractPaymentSchedulingApplication(int ApplicationID, int ContractID, int CreatedByUserID, int? UpdatedByUserID, DateTime CreatedDate, DateTime? UpdatedDate,byte status)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  ContractPaymentSchedulingApplications  
                            set
			ContractID = @ContractID,
			CreatedByUserID = @CreatedByUserID,
			UpdatedByUserID = @UpdatedByUserID,
			CreatedDate = @CreatedDate,
			UpdatedDate = @UpdatedDate,
            status=@status
             where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ContractID", ContractID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@UpdatedDate", (object)UpdatedDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@status", status);
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
