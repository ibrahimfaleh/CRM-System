using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental_DataAccess
{
    public class clsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, ref int EmployeeID, ref string UserName,
                  ref string Password, ref bool IsActive, ref int CreatedByUserID, ref short CountVehiclesReturn, ref short CountCreatedRentalBooking,
          ref short CountCreatedUsers, ref double TotalRentalIncome, ref short CountDaysRented, ref DateTime CreatedDate,ref int Permissions,ref int GivePermissions ,ref bool IsAdmin)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    EmployeeID = (int)reader["EmployeeID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CountVehiclesReturn = (short)reader["CountVehiclesReturn"];
                    CountCreatedRentalBooking = (short)reader["CountCreatedRentalBooking"];
                    CountCreatedUsers = (short)reader["CountCreatedUsers"];
                    TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());
                    CountDaysRented = (short)reader["CountDaysRented"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    GivePermissions = (int)reader["GivePermissions"]; 
                    Permissions = (int)reader["Permissions"];
                    IsAdmin = (bool)reader["IsAdmin"];







                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool GetUserInfoByUserName(ref int UserID, ref int EmployeeID, string UserName,
          ref string Password, ref bool IsActive, ref int CreatedByUserID, ref short CountVehiclesReturn, ref short CountCreatedRentalBooking,
         ref short CountCreatedUsers, ref double TotalRentalIncome, ref short CountDaysRented, ref DateTime CreatedDate,ref int Permissions,ref int GivePermissions ,ref bool IsAdmin)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    EmployeeID = (int)reader["EmployeeID"];
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CountVehiclesReturn = (short)reader["CountVehiclesReturn"];
                    CountCreatedRentalBooking = (short)reader["CountCreatedRentalBooking"];
                    CountCreatedUsers = (short)reader["CountCreatedUsers"];
                    TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());
                    CountDaysRented = (short)reader["CountDaysRented"];
                    CreatedDate = (DateTime)reader["CreatedDate"]; GivePermissions = (int)reader["GivePermissions"]; Permissions = (int)reader["Permissions"];
                    IsAdmin = (bool)reader["IsAdmin"];

                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool GetUserInfoByEmployeeID(int EmployeeID, ref int UserID, ref string UserName,
          ref string Password, ref bool IsActive, ref int CreatedByUserID, ref short CountVehiclesReturn, ref short CountCreatedRentalBooking,
          ref short CountCreatedUsers, ref double TotalRentalIncome, ref short CountDaysRented, ref DateTime CreatedDate,ref int Permissions,ref int GivePermissions ,ref bool IsAdmin)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CountVehiclesReturn = (short)reader["CountVehiclesReturn"];
                    CountCreatedRentalBooking = (short)reader["CountCreatedRentalBooking"];
                    CountCreatedUsers = (short)reader["CountCreatedUsers"];
                    TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());
                    CountDaysRented = (short)reader["CountDaysRented"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    GivePermissions = (int)reader["GivePermissions"];
                    Permissions = (int)reader["Permissions"];
                    IsAdmin = (bool)reader["IsAdmin"];


                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(ref int EmployeeID, ref int UserID, string UserName,
           string Password, ref bool IsActive, ref int CreatedByUserID, ref short CountVehiclesReturn, ref short CountCreatedRentalBooking,
          ref short CountCreatedUsers, ref double TotalRentalIncome, ref short CountDaysRented, ref DateTime CreatedDate,ref int Permissions,ref int GivePermissions ,ref bool IsAdmin)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Username = @Username and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    EmployeeID = (int)reader["EmployeeID"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CountVehiclesReturn = (short)reader["CountVehiclesReturn"];
                    CountCreatedRentalBooking = (short)reader["CountCreatedRentalBooking"];
                    CountCreatedUsers = (short)reader["CountCreatedUsers"];
                    TotalRentalIncome = double.Parse(reader["TotalRentalIncome"].ToString());
                    CountDaysRented = (short)reader["CountDaysRented"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    GivePermissions = (int)reader["GivePermissions"];
                    Permissions = (int)reader["Permissions"];
                    IsAdmin = (bool)reader["IsAdmin"];



                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewUser(int EmployeeID, string UserName, String Password, bool IsActive, int CreatedByUserID, short CountVehiclesReturn, short CountCreatedRentalBooking,
            short CountCreatedUsers, double TotalRentalIncome, short CountDaysRented, DateTime CreatedDate,int Permissions,int GivePermissions,bool IsAdmin)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (EmployeeID,UserName,Password,IsActive,CreatedByUserID, CountVehiclesReturn,CountCreatedRentalBooking,CountCreatedUsers ,TotalRentalIncome ,CountDaysRented,CountUpdatedUsers,CreatedDate,Permissions,GivePermissions,IsAdmin)
                             VALUES (@EmployeeID, @UserName,@Password,@IsActive,@CreatedByUserID,@CountVehiclesReturn,@CountCreatedRentalBooking,@CountCreatedUsers,@TotalRentalIncome,@CountDaysRented,0,@CreatedDate,@Permissions,@GivePermissions,@IsAdmin);
                             SELECT SCOPE_IDENTITY();

                                  update Users
                             set CountCreatedUsers+=1
                             where UserID=@CreatedByUserID
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@CountVehiclesReturn", CountVehiclesReturn);
            command.Parameters.AddWithValue("@CountCreatedRentalBooking", CountCreatedRentalBooking);
            command.Parameters.AddWithValue("@CountCreatedUsers", CountCreatedUsers);
            command.Parameters.AddWithValue("@TotalRentalIncome", TotalRentalIncome);
            command.Parameters.AddWithValue("@CountDaysRented", CountDaysRented);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@GivePermissions", GivePermissions);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@IsAdmin", IsAdmin);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return UserID;
        }


        public static bool UpdateUser(int UserID, int EmployeeID, string UserName, String Password, bool IsActive, int CreatedByUserID,
            short CountVehiclesReturn, short CountCreatedRentalBooking, short CountCreatedUsers, double TotalRentalIncome, short CountDaysRented, DateTime CreatedDate,int Permissions, int GivePermissions,bool IsAdmin, int UpdateByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"

                                   	insert into UpdateUsers 
                                   	(UserID,UpdateByUserID,UpdateIsActive,UpdateIsPassWord,UpdateIsUserName,UpdateDate)
                                   	values
                                   	(@UserID,@UpdateByUserID,(	select 
                                   	CASE
                                       WHEN IsActive =@IsActive THEN 0
                                       ELSE 1
                                   END 
                                   from Users where UserID=@UserID),(	select 
                                   	CASE
                                       WHEN PassWord =@Password THEN 0
                                       ELSE 1
                                   END 
                                   from Users where UserID=@UserID),(	select 
                                   	CASE
                                       WHEN UserName =@UserName THEN 0
                                       ELSE 1
                                   END 
                                   from Users where UserID=@UserID),GETDATE());

                                Update  Users  
                            set EmployeeID = @EmployeeID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive,
                                CreatedByUserID=@CreatedByUserID,
                                CountVehiclesReturn=@CountVehiclesReturn,
                                CountCreatedRentalBooking=@CountCreatedRentalBooking,
                                CountCreatedUsers=@CountCreatedUsers,
                                TotalRentalIncome=@TotalRentalIncome,
                                CountDaysRented=@CountDaysRented,
                                CreatedDate=@CreatedDate,
                                Permissions=@Permissions,
                                GivePermissions=@GivePermissions,
                                IsAdmin=@IsAdmin
                                where UserID = @UserID;
 
                                update Users 
                                set  CountUpdatedUsers+=1
                                where UserID=@UpdateByUserID;
select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@CountVehiclesReturn", CountVehiclesReturn);
            command.Parameters.AddWithValue("@CountCreatedRentalBooking", CountCreatedRentalBooking);
            command.Parameters.AddWithValue("@CountCreatedUsers", CountCreatedUsers);
            command.Parameters.AddWithValue("@TotalRentalIncome", TotalRentalIncome);
            command.Parameters.AddWithValue("@CountDaysRented", CountDaysRented);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@GivePermissions", GivePermissions);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            command.Parameters.AddWithValue("@UpdateByUserID", UpdateByUserID);
            command.Parameters.AddWithValue("@IsAdmin", IsAdmin);

            command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllUsers(int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from View_Users where BranchID=@BranchID";

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

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from View_Users";
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






        public static DataTable GetRentalTransActionsUsersByBranchID(int BranchID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"

SELECT users.UserID, Users.UserName,TransActionID=RentalTransaction.TransactionID,(People.FirstName+' '+People.SecondName+' '+People.LastName+' ')as FullName,TransActionType='Created Rental Booking',RentalBooking.RentalStartDate as CreatedDate
FROM     People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
				  Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
				  Users on Employees.EmployeeID=Users.EmployeeID inner join
                  RentalTransaction ON Users.UserID = RentalTransaction.CreatedByUserID  INNER JOIN
                  RentalBooking ON RentalTransaction.BookingID = RentalBooking.BookingID
				  where Departments.BranchID=@BranchID
union ALl

SELECT        users.UserID, Users.UserName,TransActionID=RentalTransaction.TransactionID,(People.FirstName+' '+People.SecondName+' '+People.LastName+' ')as FullName,TransActionType='Vehicle Return',VehicleReturns.ActualReturnDate as CreatedDate
FROM            People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
				  Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
				  Users on Employees.EmployeeID=Users.EmployeeID inner join
                         RentalTransaction ON Users.UserID = RentalTransaction.UpdateByUserID AND Users.UserID = RentalTransaction.UpdateByUserID INNER JOIN
                         VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID
						 where Departments.BranchID=@BranchID
"

;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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
        public static DataTable GetRentalTransActionsUsersByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"


SELECT users.UserID, Users.UserName,TransActionID=RentalTransaction.TransactionID,(People.FirstName+' '+People.SecondName+' '+People.LastName+' ')as FullName,TransActionType='Created Rental Booking',RentalBooking.RentalStartDate as CreatedDate
FROM     People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
				  Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
				  Users on Employees.EmployeeID=Users.EmployeeID inner join
                  RentalTransaction ON Users.UserID = RentalTransaction.CreatedByUserID  INNER JOIN
                  RentalBooking ON RentalTransaction.BookingID = RentalBooking.BookingID
				  where Users.UserID=@UserID
union ALl

SELECT        users.UserID, Users.UserName,TransActionID=RentalTransaction.TransactionID,(People.FirstName+' '+People.SecondName+' '+People.LastName+' ')as FullName,TransActionType='Vehicle Return',VehicleReturns.ActualReturnDate as CreatedDate
FROM            People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
				  Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
				  Users on Employees.EmployeeID=Users.EmployeeID inner join
                         RentalTransaction ON Users.UserID = RentalTransaction.UpdateByUserID AND Users.UserID = RentalTransaction.UpdateByUserID INNER JOIN
                         VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID
						 where Users.UserID=@UserID

";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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
        public static DataTable GetRentalTransActionsUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"

SELECT users.UserID, Users.UserName,TransActionID=RentalTransaction.TransactionID,(People.FirstName+' '+People.SecondName+' '+People.LastName+' ')as FullName,TransActionType='Created Rental Booking',RentalBooking.RentalStartDate as CreatedDate
FROM     People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
				  Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
				  Users on Employees.EmployeeID=Users.EmployeeID inner join
                  RentalTransaction ON Users.UserID = RentalTransaction.CreatedByUserID  INNER JOIN
                  RentalBooking ON RentalTransaction.BookingID = RentalBooking.BookingID
union ALl

SELECT        users.UserID, Users.UserName,TransActionID=RentalTransaction.TransactionID,(People.FirstName+' '+People.SecondName+' '+People.LastName+' ')as FullName,TransActionType='Vehicle Return',VehicleReturns.ActualReturnDate as CreatedDate
FROM            People INNER JOIN
                  Employees ON People.PersonID = Employees.PersonID INNER JOIN
				  Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
				  Users on Employees.EmployeeID=Users.EmployeeID inner join
                         RentalTransaction ON Users.UserID = RentalTransaction.UpdateByUserID AND Users.UserID = RentalTransaction.UpdateByUserID INNER JOIN
                         VehicleReturns ON RentalTransaction.ReturnID = VehicleReturns.ReturenID

";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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

        public static int GetBranchID(int Userid)
        {
            int branchid = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select branches.branchid from branches join employees on employees.branchid=branches.branchid join users on employees.employeeid = users.employeeid where users.userid=@userID
                            ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userid",Userid);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                branchid = (int)result;
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }

            return branchid;
        }


        public static DataTable GetTransActionsOnCreatedUsersByBranchID(int BranchID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"


SELECT        Users_1.UserID AS UserID, Users_1.UserName AS UserName,Users.UserID as CreatedUserID, Users.UserName as createdUserName,Users.CreatedDate
FROM            Employees inner join
                         Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
                         Users ON Employees.EmployeeID = Users.EmployeeID inner join
                         Users AS Users_1 ON Users.CreatedByUserID = Users_1.UserID

                         where Departments.BranchID=@BranchID
"

;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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
        public static DataTable GetTransActionsOnCreatedUsersByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"

SELECT        Users_1.UserID AS UserID, Users_1.UserName AS UserName,Users.UserID as CreatedUserID, Users.UserName as createdUserName,Users.CreatedDate
FROM            Employees inner join
                         Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
                         Users ON Employees.EmployeeID = Users.EmployeeID inner join
                         Users AS Users_1 ON Users.CreatedByUserID = Users_1.UserID
						 where Users.CreatedByUserID=@UserID

";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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
        public static DataTable GetTransActionsOnCreatedUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"

SELECT        Users_1.UserID AS UserID, Users_1.UserName AS UserName,Users.UserID as CreatedUserID, Users.UserName as createdUserName,Users.CreatedDate
FROM            Employees inner join
                         Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
                         Users ON Employees.EmployeeID = Users.EmployeeID inner join
                         Users AS Users_1 ON Users.CreatedByUserID = Users_1.UserID

";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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





        public static DataTable GetTransActionsOnUpdatedUsersByBranchID(int BranchID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT   UpdateUsers.UpdateID,UpdateUsers.UpdateByUserID as UpdatedByUserID,Users.UserName as UpdatedByUserName,UpdateUsers.UserID ,(select UserName from users where UserID=UpdateUsers.UserID)as UserName,case when UpdateUsers.UpdateIsUserName=0 then 'No'else 'Yeas'end as UpdateIsUserName, case when UpdateUsers.UpdateIsPassWord=0then 'No'else 'Yeas'end as UpdateIsPassWord,case when UpdateUsers.UpdateIsActive=0 then 'No'else 'Yeas' end as UpdateIsPassWord ,UpdateUsers.UpdateDate
FROM         People INNER JOIN
                         Employees ON People.PersonID = Employees.PersonID INNER JOIN
                         Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
                         Users ON Employees.EmployeeID = Users.EmployeeID INNER JOIN
                         UpdateUsers ON  Users.UserID = UpdateUsers.UpdateByUserID
						 where Departments.BranchID=@BranchID
"

;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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
        public static DataTable GetTransActionsOnUpdatedUsersByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"


SELECT   UpdateUsers.UpdateID,UpdateUsers.UpdateByUserID as UpdatedByUserID,Users.UserName as UpdatedByUserName,UpdateUsers.UserID ,(select UserName from users where UserID=UpdateUsers.UserID)as UserName,UpdateUsers.UpdateIsUserName,UpdateUsers.UpdateIsPassWord,UpdateUsers.UpdateIsActive,UpdateUsers.UpdateDate
FROM         People INNER JOIN
                         Employees ON People.PersonID = Employees.PersonID INNER JOIN
                         Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
                         Users ON Employees.EmployeeID = Users.EmployeeID INNER JOIN
                         UpdateUsers ON  Users.UserID = UpdateUsers.UpdateByUserID
						 where (users.UserID=@UserID or UpdateUsers.UserID=@UserID)

";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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
        public static DataTable GetTransActionsOnUpdatedUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"


SELECT   UpdateUsers.UpdateID,UpdateUsers.UpdateByUserID as UpdatedByUserID,Users.UserName as UpdatedByUserName,UpdateUsers.UserID ,(select UserName from users where UserID=UpdateUsers.UserID)as UserName,UpdateUsers.UpdateIsUserName,UpdateUsers.UpdateIsPassWord,UpdateUsers.UpdateIsActive,UpdateUsers.UpdateDate
FROM         People INNER JOIN
                         Employees ON People.PersonID = Employees.PersonID INNER JOIN
                         Departments ON Employees.DepartmentID = Departments.DepartmentID INNER JOIN
                         Users ON Employees.EmployeeID = Users.EmployeeID INNER JOIN
                         UpdateUsers ON  Users.UserID = UpdateUsers.UpdateByUserID

";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

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



        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static bool IsUserExistForEmployeeID(int EmployeeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE EmployeeID = @EmployeeID";

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

        public static bool DoesPersonHaveUser44(int EmployeeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE EmployeeID = @EmployeeID";

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

        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserID", NewPassword);


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
