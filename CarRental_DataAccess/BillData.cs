using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsBillData
    {
        // Implemention AddNew
        public static int AddNewBill(int TypeID, int BranchID, double Cost, string Details, DateTime CreatedDate, string ImagePath, Boolean IsPaid, DateTime? PaymentDate, Boolean IsActive, int CreatedByUserID, int? UpdatedByUserID, DateTime? UpdatedDate)
        {
            int BillID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Bills ( TypeID, BranchID, Cost, Details, CreatedDate, ImagePath, IsPaid, PaymentDate, IsActive, CreatedByUserID, UpdatedByUserID, UpdatedDate)
                             VALUES ( @TypeID, @BranchID, @Cost, @Details, @CreatedDate, @ImagePath, @IsPaid, @PaymentDate, @IsActive, @CreatedByUserID, @UpdatedByUserID, @UpdatedDate);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@Cost", Cost);
            command.Parameters.AddWithValue("@Details",Details);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsPaid", IsPaid);
            command.Parameters.AddWithValue("@PaymentDate", (object)PaymentDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID",(object)UpdatedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedDate", (object)UpdatedDate??DBNull.Value);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BillID = insertedID;
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


            return BillID;
        }
        public static bool GetBillInfoByID(int BillID, ref int TypeID, ref int BranchID, ref double Cost, ref string Details, ref DateTime CreatedDate, ref string ImagePath, ref Boolean IsPaid, ref DateTime? PaymentDate, ref Boolean IsActive, ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime? UpdatedDate)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Bills WHERE BillID = @BillID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BillID", BillID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    TypeID = (int)reader["TypeID"];
                    BranchID = (int)reader["BranchID"];
                    Cost = double.Parse(reader["Cost"].ToString());
                    Details = (string)reader["Details"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    ImagePath = (string)reader["ImagePath"];
                    IsPaid = (Boolean)reader["IsPaid"];
                    if(reader["PaymentDate"]!=DBNull.Value)
                    PaymentDate = (DateTime)reader["PaymentDate"];
                    IsActive = (Boolean)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if(reader["UpdatedByUserID"] != DBNull.Value)
                    UpdatedByUserID = (int)reader["UpdatedByUserID"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];
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
        public static bool GetBillInfoByIDAndBranchID(int BillID, ref int TypeID,  int BranchID, ref double Cost, ref string Details, ref DateTime CreatedDate, ref string ImagePath, ref Boolean IsPaid, ref DateTime? PaymentDate, ref Boolean IsActive, ref int CreatedByUserID, ref int? UpdatedByUserID, ref DateTime? UpdatedDate)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Bills WHERE BillID = @BillID and BranchID=@BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    TypeID = (int)reader["TypeID"];
                    Cost = double.Parse(reader["Cost"].ToString());
                    Details = (string)reader["Details"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    ImagePath = (string)reader["ImagePath"];
                    IsPaid = (Boolean)reader["IsPaid"];
                    if (reader["PaymentDate"] != DBNull.Value)
                        PaymentDate = (DateTime)reader["PaymentDate"];
                    IsActive = (Boolean)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];
                    if (reader["UpdatedDate"] != DBNull.Value)
                        UpdatedDate = (DateTime)reader["UpdatedDate"];
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
        public static bool IsBillExist(int BillID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Bills WHERE BillID = @BillID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BillID", BillID);

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
        public static DataTable GetAllBills()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Bills.BranchID,Cities.CityName,Branches.StreetName, Bills.BillID, TypesOfBills.Type, Bills.Cost, Bills.Details, Bills.CreatedDate,case when  Bills.IsPaid=1 then 'Paid' else 'Unpaid'end as PaymentStatus , Bills.PaymentDate, Bills.IsActive, Bills.CreatedByUserID, Bills.UpdatedByUserID, 
                         Bills.UpdatedDate
FROM            Bills INNER JOIN
                         TypesOfBills ON Bills.TypeID = TypesOfBills.TypeID join
						 Branches on Branches.BranchID=Bills.BranchID join
						 Cities on Branches.CityID=Cities.CityID order by Bills.CreatedDate desc";

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
        public static DataTable GetAllBills(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Bills.BranchID,Cities.CityName,Branches.StreetName, Bills.BillID, TypesOfBills.Type, Bills.Cost, Bills.Details, Bills.CreatedDate,case when  Bills.IsPaid=1 then 'Paid' else 'Unpaid'end as PymentStatus , Bills.PaymentDate, Bills.IsActive, Bills.CreatedByUserID, Bills.UpdatedByUserID, 
                         Bills.UpdatedDate
FROM            Bills INNER JOIN
                         TypesOfBills ON Bills.TypeID = TypesOfBills.TypeID join
						 Branches on Branches.BranchID=Bills.BranchID join
						 Cities on Branches.CityID=Cities.CityID where Branches.BranchID=@BranchID order by Bills.CreatedDate desc";

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
        public static bool DeleteBill(int BillID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Bills 
                                where BillID = @BillID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BillID", BillID);

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
        public static bool UpdateBill(int BillID, int TypeID, int BranchID, double Cost, string Details, DateTime CreatedDate, string ImagePath, Boolean IsPaid, DateTime? PaymentDate, Boolean IsActive, int CreatedByUserID, int? UpdatedByUserID, DateTime? UpdatedDate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Bills  
                            set
			TypeID = @TypeID,
			BranchID = @BranchID,
			Cost = @Cost,
			Details = @Details,
			CreatedDate = @CreatedDate,
			ImagePath = @ImagePath,
			IsPaid = @IsPaid,
			PaymentDate = @PaymentDate,
			IsActive = @IsActive,
			CreatedByUserID = @CreatedByUserID,
			UpdatedByUserID = @UpdatedByUserID,
			UpdatedDate = @UpdatedDate
             where BillID = @BillID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BillID", BillID);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            command.Parameters.AddWithValue("@Cost", Cost);
            command.Parameters.AddWithValue("@Details", Details);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsPaid", IsPaid);
            command.Parameters.AddWithValue("@PaymentDate", (object)PaymentDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@UpdatedByUserID", (object)UpdatedByUserID??DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedDate", (object)UpdatedDate??DBNull.Value);
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
