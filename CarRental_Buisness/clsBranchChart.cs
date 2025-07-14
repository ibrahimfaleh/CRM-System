using CarRental_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRental_Business
{
    public class clsBranchChart
    {
        public short NumberOfVehicles { private set; get; }
        public short NumberOfEmployees { private set; get; }
        public short NumberOfUsers { private set; get; }
        public int NumberOfRentalBooking { private set; get; }
        public int NumberOfRentalTransactionsCompleted { private set; get; }
        public int NumberOfRentalTransactionsNew { get { return NumberOfRentalBooking - NumberOfRentalTransactionsCompleted; } }
        public int NumberOfBills { private set; get; }
        public double TotalBillAmounts { private set; get; }
        public double TotalBillPaidAmounts { private set; get; }
        public short NumberOfContracts { private set; get; }
        public decimal TotalContractAmounts { private set; get; }
        public decimal TotalContractPaidAmounts { private set; get; }   
        public decimal TotalRealProfitFromBranch { private set; get; }
        public decimal SalaryPayments { private set; get; }
        public decimal ExpectedNewProfits { private set; get; }
        public decimal TotalIncome { private set; get; }
        public decimal TotalFinesForVehicleDamage {private set; get; }
        public decimal TotalSpentAmounts { get { return (SalaryPayments +((decimal)TotalBillPaidAmounts+TotalContractPaidAmounts)); } }
        public short NumberOfBranches {private set; get; }


        public clsBranchChart() 
        {
            this.ExpectedNewProfits = 0;
            this.TotalRealProfitFromBranch = 0;
            this.SalaryPayments = 0;
            this.NumberOfVehicles = 0;
            this.NumberOfEmployees = 0;
            this.NumberOfUsers = 0;
            this.NumberOfRentalTransactionsCompleted = 0;
            this.TotalIncome = TotalIncome;
            this.TotalFinesForVehicleDamage = 0;
            this.NumberOfBranches = 0;
            this.NumberOfBills = 0;
            this.TotalBillAmounts = 0;
            this.TotalBillPaidAmounts = 0;
            this.NumberOfContracts = 0;
            this.TotalContractAmounts = 0;
            this.TotalContractPaidAmounts = 0;
            this.NumberOfRentalBooking = 0;
        }

        private clsBranchChart(short NumberOfBranches, short numberOfVehicles, short numberOfEmployees, short numberOfUsers, int numberOfRentalTransactionsCompleted, decimal TotalRealProfitFromBranch, decimal salaryPayments, decimal ExpectedNewProfits,decimal TotalIncome,
            decimal TotalFinesForVehicleDamage,int NumberOfBills,double TotalBillAmounts,double TotalBillPaidAmounts,short NumberOfContracts,decimal TotalContractAmounts,decimal TotalContractPaidAmounts,int NumberOfRentalBooking)
        {
            this.ExpectedNewProfits = ExpectedNewProfits;
            this.TotalRealProfitFromBranch= TotalRealProfitFromBranch;
            this.SalaryPayments = salaryPayments;
            this.NumberOfVehicles = numberOfVehicles;
            this.NumberOfEmployees = numberOfEmployees;
            this.NumberOfUsers = numberOfUsers;
            this.NumberOfRentalTransactionsCompleted= numberOfRentalTransactionsCompleted;
            this.TotalIncome = TotalIncome;
            this.TotalFinesForVehicleDamage = TotalFinesForVehicleDamage;
            this.NumberOfBranches = NumberOfBranches;
            this.NumberOfBills = NumberOfBills;
            this.TotalBillAmounts = TotalBillAmounts;
            this.TotalBillPaidAmounts = TotalBillPaidAmounts;
            this.NumberOfContracts = NumberOfContracts;
            this.TotalContractAmounts = TotalContractAmounts;
            this.TotalContractPaidAmounts= TotalContractPaidAmounts;
            this.NumberOfRentalBooking = NumberOfRentalBooking;
        }


        public static clsBranchChart FindByBranchID(int BranchID)
        {
            decimal ExpectedNewProfits = 0;
            decimal TotalRealProfitFromBranch = 0;
            decimal SalaryPayments = 0;
            short NumberOfVehicles = 0;
            short NumberOfEmployees = 0;
            short NumberOfUsers = 0;
            int NumberOfRentalTransactionsCompleted = 0;
            decimal TotalIncome = 0;
            decimal TotalFinesForVehicleDamage = 0;
            short NumberOfBranches = 0;
            int NumberOfBills = 0;
            double TotalBillAmounts = 0;
            double TotalBillPaidAmounts = 0;
            short NumberOfContracts = 0;
            decimal TotalContractAmounts = 0;
            decimal TotalContractPaidAmounts = 0;
            int NumberOfRentalBooking = 0;
            if (clsBranchDetailsData.GetBranchDetailsByID(ref NumberOfBranches,ref  NumberOfVehicles,ref  NumberOfEmployees,ref NumberOfUsers, ref NumberOfRentalTransactionsCompleted,ref TotalRealProfitFromBranch,ref SalaryPayments,
                    ref ExpectedNewProfits, ref TotalIncome,
             ref TotalFinesForVehicleDamage, ref NumberOfBills, ref TotalBillAmounts, ref TotalBillPaidAmounts,ref NumberOfContracts,ref TotalContractAmounts,ref TotalContractPaidAmounts,ref NumberOfRentalBooking, BranchID))
                return new clsBranchChart(NumberOfBranches, NumberOfVehicles, NumberOfEmployees, NumberOfUsers, NumberOfRentalTransactionsCompleted, TotalRealProfitFromBranch, SalaryPayments,
                    ExpectedNewProfits, TotalIncome,
             TotalFinesForVehicleDamage, NumberOfBills, TotalBillAmounts, TotalBillPaidAmounts, NumberOfContracts, TotalContractAmounts, TotalContractPaidAmounts, NumberOfRentalBooking);
            else
                return null;
        }
        public static clsBranchChart SumAllBranches()
        {
            decimal ExpectedNewProfits = 0;
            decimal TotalRealProfitFromBranch = 0;
            decimal SalaryPayments = 0;
            short NumberOfVehicles = 0;
            short NumberOfEmployees = 0;
            short NumberOfUsers = 0;
            int NumberOfRentalTransactionsCompleted = 0;
            decimal TotalIncome = 0;
            decimal TotalFinesForVehicleDamage = 0;
            short NumberOfBranches = 0;
            int NumberOfBills = 0;
            double TotalBillAmounts = 0;
            double TotalBillPaidAmounts = 0;
            short NumberOfContracts = 0;
            decimal TotalContractAmounts = 0;
            decimal TotalContractPaidAmounts = 0;
            int NumberOfRentalBooking = 0;

            if (clsBranchDetailsData.GetAllBranchesDetails(ref NumberOfBranches, ref NumberOfVehicles, ref NumberOfEmployees, ref NumberOfUsers, ref NumberOfRentalTransactionsCompleted, ref TotalRealProfitFromBranch, ref SalaryPayments,
                    ref ExpectedNewProfits, ref TotalIncome,
             ref TotalFinesForVehicleDamage, ref NumberOfBills, ref TotalBillAmounts, ref TotalBillPaidAmounts, ref NumberOfContracts, ref TotalContractAmounts, ref TotalContractPaidAmounts, ref NumberOfRentalBooking))
                return new clsBranchChart( NumberOfBranches,  NumberOfVehicles,  NumberOfEmployees,  NumberOfUsers,  NumberOfRentalTransactionsCompleted, 
                    TotalRealProfitFromBranch,  SalaryPayments, 
                    ExpectedNewProfits,  TotalIncome,
             TotalFinesForVehicleDamage,  NumberOfBills,  TotalBillAmounts,  TotalBillPaidAmounts,  NumberOfContracts,  TotalContractAmounts,  TotalContractPaidAmounts,  NumberOfRentalBooking);
            else
                return null;
        }

        public static DataTable GetChartLast6years(short Year,int BranchID)
        {
            return clsBranchDetailsData.GetChartLast6years(Year,BranchID);
        }
        public static DataTable GetChartLast6years(short Year)
        {
            return clsBranchDetailsData.GetChartLast6years(Year);
        }
        public static DataTable GetCharFromToYear(short FromYear,short ToYear)
        {
            return clsBranchDetailsData.GetChartFromToYear(FromYear, ToYear);
        }
    }
}
