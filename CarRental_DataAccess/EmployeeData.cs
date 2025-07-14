using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsEmployeeData
    {
        public static int AddNewEmployee(int PersonID, int DepartmentID, float MonthlySalary, DateTime HireDate, DateTime? ExitDate,int BranchID)
        {
            int EmployeeID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Employees ( PersonID, DepartmentID, MonthlySalary, HireDate, ExitDate ,BranchID)
                             VALUES ( @PersonID, @DepartmentID, @MonthlySalary, @HireDate, @ExitDate,@BranchID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@MonthlySalary", MonthlySalary);
            command.Parameters.AddWithValue("@HireDate", HireDate);
            command.Parameters.AddWithValue("@ExitDate", (object)ExitDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    EmployeeID = insertedID;
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


            return EmployeeID;
        }
        public static bool GetEmployeeInfoByID(int EmployeeID, ref int PersonID, ref int DepartmentID, ref float MonthlySalary, ref DateTime HireDate, ref DateTime? ExitDate,ref int BranchID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    DepartmentID = (int)reader["DepartmentID"];
                    MonthlySalary = float.Parse(reader["MonthlySalary"].ToString());
                    HireDate = (DateTime)reader["HireDate"];
                    if (reader["ExitDate"] != DBNull.Value)
                        ExitDate = (DateTime)reader["ExitDate"];
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
        public static bool GetEmployeeInfoByPersonID(ref int EmployeeID, int PersonID, ref int DepartmentID, ref float MonthlySalary, ref DateTime HireDate, ref DateTime? ExitDate,ref int BranchID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Employees WHERE PersonID = @PersonID";
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

                    EmployeeID = (int)reader["EmployeeID"];
                    DepartmentID = (int)reader["DepartmentID"];
                    MonthlySalary = float.Parse(reader["MonthlySalary"].ToString());
                    HireDate = (DateTime)reader["HireDate"];
                    ExitDate = (DateTime?)reader["ExitDate"];
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
        public static bool GetEmployeeInfoByPhone(string Phone, ref int EmployeeID, ref int PersonID, ref int DepartmentID, ref float MonthlySalary, ref DateTime HireDate, ref DateTime? ExitDate,ref int BranchId)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from  Employees where PersonID=( select PersonID from People where Phone=@Phone)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Phone", Phone);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    EmployeeID = (int)reader["EmployeeID"];
                    DepartmentID = (int)reader["DepartmentID"];
                    MonthlySalary = float.Parse(reader["MonthlySalary"].ToString());
                    HireDate = (DateTime)reader["HireDate"];
                    if (reader["ExitDate"] != DBNull.Value)
                        ExitDate = (DateTime?)reader["ExitDate"];
                    BranchId = (int)reader["BranchID"];
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
        public static bool GetEmployeeInfoByNationalNo(string NationalNo, ref int EmployeeID, ref int PersonID, ref int DepartmentID, ref float MonthlySalary, ref DateTime HireDate, ref DateTime? ExitDate,ref int BranchID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from  Employees where PersonID=( select PersonID from People where NationalNo=@NationalNo)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    EmployeeID = (int)reader["EmployeeID"];
                    DepartmentID = (int)reader["DepartmentID"];
                    MonthlySalary = float.Parse(reader["MonthlySalary"].ToString());
                    HireDate = (DateTime)reader["HireDate"];
                    ExitDate = (DateTime?)reader["ExitDate"];
                    BranchID = (int)reader["BranhcID"];
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
        public static bool IsEmployeeExistForPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Employees WHERE PersonID = @PersonID";

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
        public static bool IsEmployeeExist(int EmployeeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Employees WHERE EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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
        public static DataTable GetAllEmployees(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * From View_Employees where BranchID=@BranchID";

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
        public static DataTable GetAllEmployeesForSelect(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Employees.EmployeeID, FullNem=(People.FirstName+' '+People.SecondName+' '+People.LastName) from 
Employees join Departments on Employees.DepartmentID = Departments.DepartmentID join People on People.PersonID=Employees.PersonID 
where BranchID=@BranchID";

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
        public static DataTable GetAllEmployees()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * From View_Employees";
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
        public static bool DeleteEmployee(int EmployeeID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Employees 
                                where EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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
        public static bool UpdateEmployee(int EmployeeID, int PersonID, int DepartmentID, float MonthlySalary, DateTime HireDate, DateTime? ExitDate,int BranchID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Employees  
                            set
			PersonID = @PersonID,
			DepartmentID = @DepartmentID,
			MonthlySalary = @MonthlySalary,
			HireDate = @HireDate,
			ExitDate = @ExitDate,
            BranchID=@BranchID
             where EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@MonthlySalary", MonthlySalary);
            command.Parameters.AddWithValue("@HireDate", HireDate);
            command.Parameters.AddWithValue("@ExitDate",(object) ExitDate??DBNull.Value);
            command.Parameters.AddWithValue("@BranchID", BranchID);
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
