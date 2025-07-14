using CarRental_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ctrlBranchStatistics : UserControl
    {
        public ctrlBranchStatistics()
        {
            InitializeComponent();
        }
        public short NumberOfBranches { private set; get; }
        private void _ResetDefaultValues()
        {
            lblExpectedNewProfits.Text = "";
            lblNumberOfEmployees.Text = "";
            lblNumberOfUsers.Text = "";
            lblNumberOfRentalCompleted.Text = "";
            lblNumberOfRentalNew.Text = "";
            lblNumberOfVehicles.Text = "";
            lblTotalContactPaidAmounts.Text = ""
;            lblTotalRealProfitFromBranch.Text = "";
            lblTotalIncme.Text = "";
            lblTotalSpentAmounts.Text = "";
            lblSalaryPayments.Text = "";
            lblTotalBillPaidAmounts.Text = "";
        }

        public void LOadDateForBranchID(int branchID)
        {
            clsBranchChart branchDetails =clsBranchChart.FindByBranchID(branchID);
            if(branchDetails==null)
                _ResetDefaultValues();
            else
            {
                lblNumberOfRentalNew.Text=branchDetails.NumberOfRentalTransactionsNew.ToString();
                lblNumberOfRentalCompleted.Text=branchDetails.NumberOfRentalTransactionsCompleted.ToString();   
                lblNumberOfUsers.Text=branchDetails.NumberOfUsers.ToString();   
                lblNumberOfEmployees.Text=branchDetails.NumberOfEmployees.ToString();
                lblTotalIncme.Text=branchDetails.TotalIncome.ToString();
                lblTotalSpentAmounts.Text=branchDetails.TotalSpentAmounts.ToString();
                lblTotalRealProfitFromBranch.Text = branchDetails.TotalRealProfitFromBranch.ToString();
                lblExpectedNewProfits.Text=branchDetails.ExpectedNewProfits.ToString();
                lblSalaryPayments.Text=branchDetails.SalaryPayments.ToString();
                lblNumberOfVehicles.Text=branchDetails.NumberOfVehicles.ToString();
                lblTotalFinesForVehicleDamage.Text = branchDetails.TotalFinesForVehicleDamage.ToString();
                lblTotalBillPaidAmounts.Text = branchDetails.TotalBillPaidAmounts.ToString();
                lblTotalContactPaidAmounts.Text = branchDetails.TotalContractPaidAmounts.ToString();
            }
        }
        public void LOadDateSumAllBranches()
        {
            clsBranchChart branchDetails = clsBranchChart.SumAllBranches();
            if (branchDetails == null)
                _ResetDefaultValues();
            else
            {
                lblNumberOfRentalNew.Text = branchDetails.NumberOfRentalTransactionsNew.ToString();
                lblNumberOfRentalCompleted.Text = branchDetails.NumberOfRentalTransactionsCompleted.ToString();
                lblNumberOfUsers.Text = branchDetails.NumberOfUsers.ToString();
                lblNumberOfEmployees.Text = branchDetails.NumberOfEmployees.ToString();
                lblTotalIncme.Text = branchDetails.TotalIncome.ToString();
                lblTotalSpentAmounts.Text = branchDetails.TotalSpentAmounts.ToString();
                lblTotalRealProfitFromBranch.Text = branchDetails.TotalRealProfitFromBranch.ToString();
                lblExpectedNewProfits.Text = branchDetails.ExpectedNewProfits.ToString();
                lblSalaryPayments.Text = branchDetails.SalaryPayments.ToString();
                lblNumberOfVehicles.Text = branchDetails.NumberOfVehicles.ToString();
                lblTotalFinesForVehicleDamage.Text=branchDetails.TotalFinesForVehicleDamage.ToString();
                NumberOfBranches=branchDetails.NumberOfBranches;
                lblTotalBillPaidAmounts.Text = branchDetails.TotalBillPaidAmounts.ToString();
                lblTotalContactPaidAmounts.Text = branchDetails.TotalContractPaidAmounts.ToString();
            }
        }
        private void ctrlStatistics_Load(object sender, EventArgs e)
        {

        }
    }
}
