using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enTypeTransAction { CreatedUser = 0, CreatedRental = 1, ReturnVehicle = 2 }

        public int UserID { set; get; }
        public int EmployeeID { set; get; }
        public clsEmployee EmployeeInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public  bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }
        public short CountVehiclesReturn { set; get; }
        public short CountCreatedRentalBooking { set; get; }
        public short CountCreatedUsers { set; get; }
        public double TotalRentalIncome { set; get; }
        public short CountDaysRented { set; get; }
        public DateTime CreatedDate { set; get; }

        public int Permissions { set; get; }
        public int GivePermissions { set; get; }
        public int CountTransActions { get { return CountVehiclesReturn + CountCreatedUsers + CountCreatedRentalBooking; } }
        public bool IsAdmin { set; get; }  

        public clsUser()

        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            this.CountCreatedRentalBooking = 0;
            this.CountCreatedUsers = 0;
            this.CountDaysRented = 0;
            this.CreatedDate = DateTime.Now;
            this.CountVehiclesReturn = 0;
            Mode = enMode.AddNew;
        }


        private clsUser(int userID, int EmployeeID, string userName, string password, bool isActive, int createdByUserID, short countVehiclesReturn,
    short countCreatedRentalBooking, short countCreatedUsers, double totalRentalIncome, short countDaysRented, DateTime createdDate
    ,int Permissions,int GivePermissions,bool IsAdmin)
        {
            UserID = userID;
            this.EmployeeID = EmployeeID;
            UserName = userName;
            Password = password;
            this.IsActive = isActive;
            CreatedByUserID = createdByUserID;
            CountVehiclesReturn = countVehiclesReturn;
            CountCreatedRentalBooking = countCreatedRentalBooking;
            CountCreatedUsers = countCreatedUsers;
            TotalRentalIncome = totalRentalIncome;
            CountDaysRented = countDaysRented;
            CreatedDate = createdDate;
            EmployeeInfo = clsEmployee.Find(EmployeeID);
            Mode = enMode.Update;
            this.Permissions = Permissions;
            this.GivePermissions = GivePermissions;
            this.IsAdmin = IsAdmin;
        }


        private bool _AddNewUser()
        {


            this.UserID = clsUserData.AddNewUser(this.EmployeeID, this.UserName,
                this.Password, this.IsActive, this.CreatedByUserID, this.CountVehiclesReturn, this.CountCreatedRentalBooking, this.CountCreatedUsers, this.TotalRentalIncome, this.CountDaysRented, this.CreatedDate, Permissions, GivePermissions,IsAdmin);

            return (this.UserID != -1);
        }
        private bool _UpdateUser(int UpdatedByUserID)
        {
            if (clsUserData.UpdateUser(this.UserID, this.EmployeeID, this.UserName,
               this.Password, this.IsActive, this.CreatedByUserID, this.CountVehiclesReturn, this.CountCreatedRentalBooking, this.CountCreatedUsers, this.TotalRentalIncome, this.CountDaysRented, this.CreatedDate, Permissions, GivePermissions,IsAdmin, UpdatedByUserID))

                return true;

            else return false;

        }
        public static clsUser FindByUserID(int UserID)
        {
            int EmployeeID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;
            int CreatedByUserID = 0;
            short CountVehiclesReturn = 0;
            short CountCreatedRentalBooking = 0;
            short CountCreatedUsers = 0;
            double TotalRentalIncome = 0;
            short CountDaysRented = 0;
            int Permissions = -1;
            int GivePermissions = -1;
            bool IsAdmin = false;
            DateTime CreatedDate = DateTime.Now;
            bool IsFound = clsUserData.GetUserInfoByUserID
                                (UserID, ref EmployeeID, ref UserName, ref Password, ref IsActive, ref CreatedByUserID, ref CountVehiclesReturn, ref CountCreatedRentalBooking, ref CountCreatedUsers, ref TotalRentalIncome, ref CountDaysRented, ref CreatedDate, ref Permissions,ref GivePermissions,ref IsAdmin);

            if (IsFound)
                return new clsUser(UserID, EmployeeID, UserName, Password, IsActive, CreatedByUserID, CountVehiclesReturn, CountCreatedRentalBooking, CountCreatedUsers, TotalRentalIncome, CountDaysRented, CreatedDate,Permissions, GivePermissions,IsAdmin);
            else
                return null;
        }
        public static clsUser FindByUserID(string UserName)
        {
            int EmployeeID = -1;
            int UserID = -1;
            string Password = "";
            bool IsActive = false;
            int CreatedByUserID = 0;
            short CountVehiclesReturn = 0;
            short CountCreatedRentalBooking = 0;
            short CountCreatedUsers = 0;
            double TotalRentalIncome = 0;
            short CountDaysRented = 0;
            int GivePermissions = -1;
            int Permissions = -1;
            bool IsAdmin = false;   
            DateTime CreatedDate = DateTime.Now;
            bool IsFound = clsUserData.GetUserInfoByUserName
                                (ref UserID, ref EmployeeID,  UserName, ref Password, ref IsActive, ref CreatedByUserID, ref CountVehiclesReturn, ref CountCreatedRentalBooking, ref CountCreatedUsers, ref TotalRentalIncome, ref CountDaysRented, ref CreatedDate,ref Permissions,ref GivePermissions,ref IsAdmin);


            if (IsFound)
                return new clsUser(UserID, EmployeeID, UserName, Password, IsActive, CreatedByUserID, CountVehiclesReturn, CountCreatedRentalBooking, CountCreatedUsers, TotalRentalIncome, CountDaysRented, CreatedDate, Permissions, GivePermissions, IsAdmin);
            else
                return null;
        }
        public static clsUser FindByEmployeeID(int EmployeeID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;
            int CreatedByUserID = 0;
            short CountVehiclesReturn = 0;
            short CountCreatedRentalBooking = 0;
            short CountCreatedUsers = 0;
            double TotalRentalIncome = 0;
            short CountDaysRented = 0;
            int GivePermissions = -1;
            int Permissions = -1;
            bool IsAdmin = false;   
            DateTime CreatedDate = DateTime.Now;

            bool IsFound = clsUserData.GetUserInfoByEmployeeID
                                (EmployeeID, ref UserID, ref UserName, ref Password, ref IsActive, ref CreatedByUserID, ref CountVehiclesReturn, ref CountCreatedRentalBooking, ref CountCreatedUsers, ref TotalRentalIncome, ref CountDaysRented, ref CreatedDate,ref Permissions,ref GivePermissions,ref IsAdmin);


            if (IsFound)
                return new clsUser(UserID, EmployeeID, UserName, Password, IsActive, CreatedByUserID, CountVehiclesReturn, CountCreatedRentalBooking, CountCreatedUsers, TotalRentalIncome, CountDaysRented, CreatedDate, Permissions, GivePermissions, IsAdmin);
            else
                return null;
        }
        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int EmployeeID = -1;
            int CreatedByUserID = 0;
            short CountVehiclesReturn = 0;
            short CountCreatedRentalBooking = 0;
            short CountCreatedUsers = 0;
            double TotalRentalIncome = 0;
            short CountDaysRented = 0;
            int GivePermissions = -1;
            int Permissions = -1;
            DateTime CreatedDate = DateTime.Now;
            bool IsActive = false;
            bool IsAdmin = false;
            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword
                                (ref EmployeeID, ref UserID, UserName, Password, ref IsActive, ref CreatedByUserID, ref CountVehiclesReturn, ref CountCreatedRentalBooking, ref CountCreatedUsers, ref TotalRentalIncome, ref CountDaysRented, ref CreatedDate, ref Permissions,ref GivePermissions,ref IsAdmin);

            if (IsFound)
                return new clsUser(UserID, EmployeeID, UserName, Password, IsActive, CreatedByUserID, CountVehiclesReturn, CountCreatedRentalBooking, CountCreatedUsers, TotalRentalIncome, CountDaysRented, CreatedDate, Permissions, GivePermissions, IsAdmin);
            else
                return null;
        }

        public bool Save(int UpdateByUserID)
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser(UpdateByUserID);

            }

            return false;
        }

        public static DataTable GetAllUsers(int BranchID)
        {
            return clsUserData.GetAllUsers(BranchID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }



        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool isUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public static bool isUserExistForEmployeeID(int EmployeeID)
        {
            return clsUserData.IsUserExistForEmployeeID(EmployeeID);
        }



        public static DataTable GetRentalTransActionsUsersByBranchID(int BranchID)
        {
            return clsUserData.GetRentalTransActionsUsersByBranchID(BranchID);
        }
        public static DataTable GetRentalTransActionsUsersByUserID(int UserID)
        {
            return clsUserData.GetRentalTransActionsUsersByUserID(UserID);
        }
        public static DataTable GetRentalTransActionsUsers()
        {
            return clsUserData.GetRentalTransActionsUsers();
        }




        public static DataTable GetTransactionOnCreatedUsersByBranchID(int BranchID)
        {
            return clsUserData.GetTransActionsOnCreatedUsersByBranchID(BranchID);
        }
        public static DataTable GetTransactionOnCreatedUsersByUserID(int UserID)
        {
            return clsUserData.GetTransActionsOnCreatedUsersByUserID(UserID);
        }
        public static DataTable GetTransactionOnCreatedUsers()
        {
            return clsUserData.GetTransActionsOnCreatedUsers();
        }


        public static int GetBranchID(int userid)
        {
            return clsUserData.GetBranchID(userid);
        }
        public static DataTable GetTransactionOnUpdatedUsersByBranchID(int BranchID)
        {
            return clsUserData.GetTransActionsOnUpdatedUsersByBranchID(BranchID);
        }
        public static DataTable GetTransactionOnUpdatedUsersByUserID(int UserID)
        {
            return clsUserData.GetTransActionsOnUpdatedUsersByUserID(UserID);
        }
        public static DataTable GetTransactionOnUpdatedUsers()
        {
            return clsUserData.GetTransActionsOnUpdatedUsers();
        }
    }
}
