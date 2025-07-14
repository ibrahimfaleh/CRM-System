using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsFinancialPenaltieData
    {
        // Implemention AddNew
        public static int AddNewFinancialPenaltie(double Cost, string Details, DateTime Date, int TypeID, int CreatedByUserID, int? UpdatedByUserID, DateTime? UpdateDate, int? AmountSpentID, string ImagePath,bool IsPaid)
        {
            int PenaltyID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO FinancialPenalties ( Cost, Details, Date, TypeID, CreatedByUserID, UpdatedByUserID, UpdateDate, AmountSpentID, ImagePath,IsPaid)
                             VALUES ( @Cost, @Details, @Date, @TypeID, @CreatedByUserID, @UpdatedByUserID, @UpdateDate, @AmountSpentID, @ImagePath,@IsPaid);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cost", Cost);
            command.Parameters.AddWithValue("@Details", Details);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID",(object) UpdatedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@UpdateDate", (object)UpdateDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID??DBNull.Value);
            command.Parameters.AddWithValue("@ImagePath", (object)ImagePath??DBNull.Value);
            command.Parameters.AddWithValue("@IsPaid", IsPaid);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PenaltyID = insertedID;
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


            return PenaltyID;
        }
        // Implemention GetByID
        public static bool GetFinancialPenaltieInfoByID(int PenaltyID, ref double Cost, ref string Details, ref DateTime Date, ref int TypeID, ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime? UpdateDate, ref int? AmountSpentID, ref string ImagePath,ref bool IsPaid)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM FinancialPenalties WHERE PenaltyID = @PenaltyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PenaltyID", PenaltyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    isFound = true;
                    IsPaid = (bool)reader["IsPaid"];
                    Cost = double.Parse(reader["Cost"].ToString());
                    Details = (string)reader["Details"];
                    Date = (DateTime)reader["Date"];
                    TypeID = (int)reader["TypeID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int?)reader["UpdatedByUserID"];
                    if (reader["UpdateDate"] != DBNull.Value)
                        UpdateDate = (DateTime)reader["UpdateDate"];

                    if (reader["AmountSpentID"] != DBNull.Value)
                        AmountSpentID = (int?)reader["AmountSpentID"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
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

        public static bool IsFinancialPenaltieExist(int PenaltyID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM FinancialPenalties WHERE PenaltyID = @PenaltyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PenaltyID", PenaltyID);

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
        public static DataTable GetAllFinancialPenalties()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM View_FinancialPenalties";

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

        public static bool DeleteFinancialPenaltie(int PenaltyID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete FinancialPenalties 
                                where PenaltyID = @PenaltyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PenaltyID", PenaltyID);

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

        public static bool UpdateFinancialPenaltie(int PenaltyID, double Cost, string Details, DateTime Date, int TypeID, int CreatedByUserID, int? UpdatedByUserID, DateTime? UpdateDate, int? AmountSpentID, string ImagePath,bool IsPaid)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  FinancialPenalties  
                            set
			Cost = @Cost,
			Details = @Details,
			Date = @Date,
			TypeID = @TypeID,
			CreatedByUserID = @CreatedByUserID,
			UpdatedByUserID = @UpdatedByUserID,
			UpdateDate = @UpdateDate,
			AmountSpentID = @AmountSpentID,
			ImagePath = @ImagePath,
            IsPaid=@IsPaid
             where PenaltyID = @PenaltyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PenaltyID", PenaltyID);
            command.Parameters.AddWithValue("@Cost", Cost);
            command.Parameters.AddWithValue("@Details", Details);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID ?? DBNull.Value);
            command.Parameters.AddWithValue("@UpdateDate", (object)UpdateDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@AmountSpentID", (object)AmountSpentID ?? DBNull.Value);
            command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsPaid", IsPaid);
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
