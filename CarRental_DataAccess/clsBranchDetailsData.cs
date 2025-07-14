using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsBranchDetailsData
    {
        public static bool GetBranchDetailsByID(ref short NumberOfBranches,ref  short numberOfVehicles,ref  short numberOfEmployees,
            ref short numberOfUsers,ref int numberOfRentalTransactionsCompleted,ref decimal TotalRealProfitFromBranch,ref decimal salaryPayments,
            ref decimal ExpectedNewProfits,ref decimal TotalIncome,
            ref decimal TotalFinesForVehicleDamage,ref int NumberOfBills, ref double TotalBillAmounts,ref double TotalBillPaidAmounts,
            ref short NumberOfContracts,ref decimal TotalContractAmounts,ref decimal TotalContractPaidAmounts,ref int NumberOfRentalBooking, int BranchID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from View_BranchStatistics where branchId=@BranchID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BranchID", BranchID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    NumberOfBranches = 1;
                    NumberOfBills = (int)reader["NumberOfBills"];
                    TotalBillAmounts = double.Parse(reader["TotalBillAmounts"].ToString());
                    TotalBillPaidAmounts = double.Parse(reader["TotalBillPaidAmounts"].ToString());

                    NumberOfContracts = short.Parse(reader["NumberOfContracts"].ToString());
                    TotalContractAmounts = decimal.Parse(reader["TotalContractAmounts"].ToString());
                    TotalContractPaidAmounts = decimal.Parse(reader["TotalContractPaidAmounts"].ToString());

                    numberOfVehicles = short.Parse(reader["NumberOfVehicles"].ToString());
                    numberOfEmployees = short.Parse(reader["NumberOfEmployees"].ToString());
                    numberOfRentalTransactionsCompleted = (int)reader["NumberOfRentalBookingCompleted"];
                    NumberOfRentalBooking = (int)reader["NumberOfRentalBooking"];
                    numberOfUsers = short.Parse(reader["NumberOfUsers"].ToString());
                    salaryPayments = decimal.Parse(reader["TotalPaidSalaryAmount"].ToString());
                    ExpectedNewProfits = decimal.Parse(reader["ExpectedProfit"].ToString()); 
                    TotalRealProfitFromBranch = decimal.Parse(reader["ActualProfits"].ToString());
                    TotalIncome = decimal.Parse(reader["TotalIncome"].ToString());
                    TotalFinesForVehicleDamage = decimal.Parse(reader["VehicleBreakdownRevenues"].ToString());

                }
                else
                {

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

        public static bool GetAllBranchesDetails(ref short NumberOfBranches, ref short numberOfVehicles, ref short numberOfEmployees,
            ref short numberOfUsers, ref int numberOfRentalTransactionsCompleted, ref decimal TotalRealProfitFromBranch, ref decimal salaryPayments,
            ref decimal ExpectedNewProfits, ref decimal TotalIncome,
            ref decimal TotalFinesForVehicleDamage, ref int NumberOfBills, ref double TotalBillAmounts, ref double TotalBillPaidAmounts,
            ref short NumberOfContracts, ref decimal TotalContractAmounts, ref decimal TotalContractPaidAmounts, ref int NumberOfRentalBooking)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select count(BranchID)as NumberOfBranches,sum(NumberOfEmployees) as NumberOfEmployees,sum(NumberOfUsers) as NumberOfUsers ,sum(NumberOfVehicles) as NumberOfVehicles 
, sum(TotalPaidSalaryAmount) as TotalPaidSalaryAmount , sum(NumberOfRentalBooking) as NumberOfRentalBooking ,sum(NumberOfRentalBookingCompleted) as NumberOfRentalBookingCompleted, sum(ActualProfits) as ActualProfits
, sum(ExpectedProfit) as ExpectedProfit , sum (VehicleBreakdownRevenues)  as VehicleBreakdownRevenues
, sum(TotalIncome) as TotalIncome , sum(NumberOfContracts) as NumberOfContracts,sum(TotalContractAmounts) as TotalContractAmounts , sum(TotalContractPaidAmounts) as TotalContractPaidAmounts, sum(NumberOfBills) as NumberOfBills
, sum(TotalBillAmounts) as TotalBillAmounts
,sum(TotalBillPaidAmounts) as TotalBillPaidAmounts
from  View_BranchStatistics";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    NumberOfBranches = short.Parse(reader["NumberOfBranches"].ToString());
                    NumberOfBills = (int)reader["NumberOfBills"];
                    TotalBillAmounts = double.Parse(reader["TotalBillAmounts"].ToString());
                    TotalBillPaidAmounts = double.Parse(reader["TotalBillPaidAmounts"].ToString());

                    NumberOfContracts = short.Parse(reader["NumberOfContracts"].ToString());
                    TotalContractAmounts = decimal.Parse(reader["TotalContractAmounts"].ToString());
                    TotalContractPaidAmounts = decimal.Parse(reader["TotalContractPaidAmounts"].ToString());

                    numberOfVehicles = short.Parse(reader["NumberOfVehicles"].ToString());
                    numberOfEmployees = short.Parse(reader["NumberOfEmployees"].ToString());
                    numberOfRentalTransactionsCompleted = (int)reader["NumberOfRentalBookingCompleted"];
                    NumberOfRentalBooking = (int)reader["NumberOfRentalBooking"];
                    numberOfUsers = short.Parse(reader["NumberOfUsers"].ToString());
                    salaryPayments = decimal.Parse(reader["TotalPaidSalaryAmount"].ToString());
                    ExpectedNewProfits = decimal.Parse(reader["ExpectedProfit"].ToString());
                    TotalRealProfitFromBranch = decimal.Parse(reader["ActualProfits"].ToString());
                    TotalIncome = decimal.Parse(reader["TotalIncome"].ToString());
                    TotalFinesForVehicleDamage = decimal.Parse(reader["VehicleBreakdownRevenues"].ToString());

                }
                else
                {

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



        public static DataTable GetChartLast6years(short EndYear,int BranchID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT        Year=@Year,dbo.Branches.BranchID, COUNT(Employees_1.EmployeeID) AS NumberOfEmployees, COUNT(dbo.Users.UserID) AS NumberOfUsers,
                             (SELECT        CASE WHEN SUM(AmountsSpent.Amount) > 0 THEN SUM(AmountsSpent.Amount) ELSE 0 END AS Expr1
                               FROM            dbo.Branches AS branches1 INNER JOIN
                                                         dbo.Employees ON branches1.BranchID = dbo.Employees.EmployeeID INNER JOIN
                                                         dbo.SalaryPayments ON dbo.Employees.EmployeeID = dbo.SalaryPayments.EmployeeID INNER JOIN
                                                         dbo.AmountsSpent ON dbo.SalaryPayments.AmountSpentID = dbo.AmountsSpent.AmountSpentID
                               WHERE        (branches1.BranchID = dbo.Branches.BranchID and Year(AmountsSpent.Date)=@Year)) AS TotalPaidSalaryAmount,
                             (SELECT        COUNT(BookingID) AS Expr1
                               FROM            dbo.RentalBooking
                               WHERE        (BranchID = dbo.Branches.BranchID and Year(RentalBooking.RentalStartDate)=@Year)) AS NumberOfRentalBooking,
                             (SELECT        COUNT(BookingID) AS Expr1
                               FROM            dbo.RentalBooking AS RentalBooking_1
                               WHERE        (BookingStatus = 1) AND (BranchID = dbo.Branches.BranchID and Year(RentalBooking_1.RentalStartDate)=@Year)) AS NumberOfRentalBookingCompleted,


                             (SELECT        CASE WHEN SUM(ActualProfits) > 0 THEN SUM(ActualProfits) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1) and Year(DailyIncomeFunds.Date)=@Year) AS ActualProfits,


                             (SELECT        CASE WHEN SUM(ExpectedProfit) > 0 THEN SUM(ExpectedProfit) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_3
                               WHERE        (BranchID = dbo.Branches.BranchID )and  (IsClose = 1) and (Year(DailyIncomeFunds_3.Date)=@Year)) AS ExpectedProfit,



                             (SELECT        CASE WHEN SUM(VehicleBreakdownRevenues) > 0 THEN SUM(VehicleBreakdownRevenues) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1)and (DailyIncomeFunds_2.Date)=@Year) AS VehicleBreakdownRevenues,--


                             (SELECT        CASE WHEN SUM(TotalIncome) > 0 THEN SUM(TotalIncome) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1)and (Year(DailyIncomeFunds_1.Date)=@Year)) AS TotalIncome,--



                             (SELECT        COUNT(ContractID) AS Expr1
                               FROM            dbo.Contracts
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1) and (Year(Contracts.CreatedDate)=@Year)) AS NumberOfContracts,--


                             (SELECT        CASE WHEN SUM(ContractAmount) > 0 THEN SUM(ContractAmount) ELSE 0 END AS Expr1
                               FROM            dbo.Contracts AS Contracts_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1)and (Year(CreatedDate)=@Year)) AS TotalContractAmounts,--


                             (SELECT        CASE WHEN SUM(TotalAmountPaid) > 0 THEN SUM(TotalAmountPaid) ELSE 0 END AS Expr1
                               FROM            dbo.Contracts AS Contracts_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1)and(Year(CreatedDate)=@Year)) AS TotalContractPaidAmounts,--



                             (SELECT        COUNT(BillID) AS Expr1
                               FROM            dbo.Bills
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsActive = 1)and (Year(CreatedDate)=@Year)) AS NumberOfBills,--



                             (SELECT        CASE WHEN SUM(Cost) > 0 THEN SUM(Cost) ELSE 0 END AS Expr1
                               FROM            dbo.Bills AS Bills_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsActive = 1)and (Year(CreatedDate)=@Year)) AS TotalBillAmounts,--



                             (SELECT        CASE WHEN SUM(Cost) > 0 THEN SUM(Cost) ELSE 0 END AS Expr1
                               FROM            dbo.Bills AS Bills_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsPaid = 1)and (Year(CreatedDate)=@Year)) AS TotalBillPaidAmounts



FROM            dbo.Branches LEFT OUTER JOIN
                         dbo.Employees AS Employees_1 ON Employees_1.BranchID = dbo.Branches.BranchID AND Employees_1.ExitDate IS NULL and Year( Employees_1.HireDate)=@Year LEFT OUTER JOIN
                         dbo.Users ON dbo.Users.EmployeeID = Employees_1.EmployeeID where Branches.BranchID=@BranchID
GROUP BY dbo.Branches.BranchID";

            connection.Open();

            try
            {

                for (byte i = 0; i < 6; i++)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BranchID", BranchID);
                    command.Parameters.AddWithValue("@Year", EndYear);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)

                    {
                        dt.Load(reader);
                    }
                    command.Parameters.Clear();
                    EndYear -= 1;

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

            return dt;

        }
        public static DataTable GetChartLast6years(short EndYear)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @" SELECT       Year=@Year, dbo.Branches.BranchID, COUNT(Employees_1.EmployeeID) AS NumberOfEmployees, COUNT(dbo.Users.UserID) AS NumberOfUsers,
                             (SELECT        CASE WHEN SUM(AmountsSpent.Amount) > 0 THEN SUM(AmountsSpent.Amount) ELSE 0 END AS Expr1
                               FROM            dbo.Branches AS branches1 INNER JOIN
                                                         dbo.Employees ON branches1.BranchID = dbo.Employees.EmployeeID INNER JOIN
                                                         dbo.SalaryPayments ON dbo.Employees.EmployeeID = dbo.SalaryPayments.EmployeeID INNER JOIN
                                                         dbo.AmountsSpent ON dbo.SalaryPayments.AmountSpentID = dbo.AmountsSpent.AmountSpentID
                               WHERE        (branches1.BranchID = dbo.Branches.BranchID and Year(AmountsSpent.Date)=@Year)) AS TotalPaidSalaryAmount,
                             (SELECT        COUNT(BookingID) AS Expr1
                               FROM            dbo.RentalBooking
                               WHERE        (BranchID = dbo.Branches.BranchID and Year(RentalBooking.RentalStartDate)=@Year)) AS NumberOfRentalBooking,
                             (SELECT        COUNT(BookingID) AS Expr1
                               FROM            dbo.RentalBooking AS RentalBooking_1
                               WHERE        (BookingStatus = 1) AND (BranchID = dbo.Branches.BranchID and Year(RentalBooking_1.RentalStartDate)=@Year)) AS NumberOfRentalBookingCompleted,


                             (SELECT        CASE WHEN SUM(ActualProfits) > 0 THEN SUM(ActualProfits) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1) and Year(DailyIncomeFunds.Date)=@Year) AS ActualProfits,


                             (SELECT        CASE WHEN SUM(ExpectedProfit) > 0 THEN SUM(ExpectedProfit) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_3
                               WHERE        (BranchID = dbo.Branches.BranchID )and  (IsClose = 1) and (Year(DailyIncomeFunds_3.Date)=@Year)) AS ExpectedProfit,



                             (SELECT        CASE WHEN SUM(VehicleBreakdownRevenues) > 0 THEN SUM(VehicleBreakdownRevenues) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1)and (DailyIncomeFunds_2.Date)=@Year) AS VehicleBreakdownRevenues,--


                             (SELECT        CASE WHEN SUM(TotalIncome) > 0 THEN SUM(TotalIncome) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1)and (Year(DailyIncomeFunds_1.Date)=@Year)) AS TotalIncome,--



                             (SELECT        COUNT(ContractID) AS Expr1
                               FROM            dbo.Contracts
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1) and (Year(Contracts.CreatedDate)=@Year)) AS NumberOfContracts,--


                             (SELECT        CASE WHEN SUM(ContractAmount) > 0 THEN SUM(ContractAmount) ELSE 0 END AS Expr1
                               FROM            dbo.Contracts AS Contracts_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1)and (Year(CreatedDate)=@Year)) AS TotalContractAmounts,--


                             (SELECT        CASE WHEN SUM(TotalAmountPaid) > 0 THEN SUM(TotalAmountPaid) ELSE 0 END AS Expr1
                               FROM            dbo.Contracts AS Contracts_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1)and(Year(CreatedDate)=@Year)) AS TotalContractPaidAmounts,--



                             (SELECT        COUNT(BillID) AS Expr1
                               FROM            dbo.Bills
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsActive = 1)and (Year(CreatedDate)=@Year)) AS NumberOfBills,--



                             (SELECT        CASE WHEN SUM(Cost) > 0 THEN SUM(Cost) ELSE 0 END AS Expr1
                               FROM            dbo.Bills AS Bills_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsActive = 1)and (Year(CreatedDate)=@Year)) AS TotalBillAmounts,--



                             (SELECT        CASE WHEN SUM(Cost) > 0 THEN SUM(Cost) ELSE 0 END AS Expr1
                               FROM            dbo.Bills AS Bills_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsPaid = 1)and (Year(CreatedDate)=@Year)) AS TotalBillPaidAmounts



FROM            dbo.Branches LEFT OUTER JOIN
                         dbo.Employees AS Employees_1 ON Employees_1.BranchID = dbo.Branches.BranchID AND Employees_1.ExitDate IS NULL and Year( Employees_1.HireDate)=@Year LEFT OUTER JOIN
                         dbo.Users ON dbo.Users.EmployeeID = Employees_1.EmployeeID
GROUP BY dbo.Branches.BranchID
";

            connection.Open();

            try
            {

                for (byte i = 0; i < 6; i++)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Year", EndYear);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)

                    {
                        dt.Load(reader);
                    }
                    command.Parameters.Clear();
                    EndYear -= 1;

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

            return dt;

        }
        public static DataTable GetChartFromToYear(short FromYear,short ToYear)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @" SELECT       Year=@Year, dbo.Branches.BranchID, COUNT(Employees_1.EmployeeID) AS NumberOfEmployees, COUNT(dbo.Users.UserID) AS NumberOfUsers,
                             (SELECT        CASE WHEN SUM(AmountsSpent.Amount) > 0 THEN SUM(AmountsSpent.Amount) ELSE 0 END AS Expr1
                               FROM            dbo.Branches AS branches1 INNER JOIN
                                                         dbo.Employees ON branches1.BranchID = dbo.Employees.EmployeeID INNER JOIN
                                                         dbo.SalaryPayments ON dbo.Employees.EmployeeID = dbo.SalaryPayments.EmployeeID INNER JOIN
                                                         dbo.AmountsSpent ON dbo.SalaryPayments.AmountSpentID = dbo.AmountsSpent.AmountSpentID
                               WHERE        (branches1.BranchID = dbo.Branches.BranchID and Year(AmountsSpent.Date)=@Year)) AS TotalPaidSalaryAmount,
                             (SELECT        COUNT(BookingID) AS Expr1
                               FROM            dbo.RentalBooking
                               WHERE        (BranchID = dbo.Branches.BranchID and Year(RentalBooking.RentalStartDate)=@Year)) AS NumberOfRentalBooking,
                             (SELECT        COUNT(BookingID) AS Expr1
                               FROM            dbo.RentalBooking AS RentalBooking_1
                               WHERE        (BookingStatus = 1) AND (BranchID = dbo.Branches.BranchID and Year(RentalBooking_1.RentalStartDate)=@Year)) AS NumberOfRentalBookingCompleted,


                             (SELECT        CASE WHEN SUM(ActualProfits) > 0 THEN SUM(ActualProfits) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1) and Year(DailyIncomeFunds.Date)=@Year) AS ActualProfits,


                             (SELECT        CASE WHEN SUM(ExpectedProfit) > 0 THEN SUM(ExpectedProfit) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_3
                               WHERE        (BranchID = dbo.Branches.BranchID )and  (IsClose = 1) and (Year(DailyIncomeFunds_3.Date)=@Year)) AS ExpectedProfit,



                             (SELECT        CASE WHEN SUM(VehicleBreakdownRevenues) > 0 THEN SUM(VehicleBreakdownRevenues) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1)and (DailyIncomeFunds_2.Date)=@Year) AS VehicleBreakdownRevenues,--


                             (SELECT        CASE WHEN SUM(TotalIncome) > 0 THEN SUM(TotalIncome) ELSE 0 END AS Expr1
                               FROM            dbo.DailyIncomeFunds AS DailyIncomeFunds_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsClose = 1)and (Year(DailyIncomeFunds_1.Date)=@Year)) AS TotalIncome,--



                             (SELECT        COUNT(ContractID) AS Expr1
                               FROM            dbo.Contracts
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1) and (Year(Contracts.CreatedDate)=@Year)) AS NumberOfContracts,--


                             (SELECT        CASE WHEN SUM(ContractAmount) > 0 THEN SUM(ContractAmount) ELSE 0 END AS Expr1
                               FROM            dbo.Contracts AS Contracts_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1)and (Year(CreatedDate)=@Year)) AS TotalContractAmounts,--


                             (SELECT        CASE WHEN SUM(TotalAmountPaid) > 0 THEN SUM(TotalAmountPaid) ELSE 0 END AS Expr1
                               FROM            dbo.Contracts AS Contracts_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (isActive = 1)and(Year(CreatedDate)=@Year)) AS TotalContractPaidAmounts,--



                             (SELECT        COUNT(BillID) AS Expr1
                               FROM            dbo.Bills
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsActive = 1)and (Year(CreatedDate)=@Year)) AS NumberOfBills,--



                             (SELECT        CASE WHEN SUM(Cost) > 0 THEN SUM(Cost) ELSE 0 END AS Expr1
                               FROM            dbo.Bills AS Bills_2
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsActive = 1)and (Year(CreatedDate)=@Year)) AS TotalBillAmounts,--



                             (SELECT        CASE WHEN SUM(Cost) > 0 THEN SUM(Cost) ELSE 0 END AS Expr1
                               FROM            dbo.Bills AS Bills_1
                               WHERE        (BranchID = dbo.Branches.BranchID) AND (IsPaid = 1)and (Year(CreatedDate)=@Year)) AS TotalBillPaidAmounts



FROM            dbo.Branches LEFT OUTER JOIN
                         dbo.Employees AS Employees_1 ON Employees_1.BranchID = dbo.Branches.BranchID AND Employees_1.ExitDate IS NULL and Year( Employees_1.HireDate)=@Year LEFT OUTER JOIN
                         dbo.Users ON dbo.Users.EmployeeID = Employees_1.EmployeeID
GROUP BY dbo.Branches.BranchID
";

            connection.Open();

            try
            {

                for (; FromYear <= ToYear; FromYear++)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Year", FromYear);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)

                    {
                        dt.Load(reader);
                    }
                    command.Parameters.Clear();
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

            return dt;

        }
    }
}
