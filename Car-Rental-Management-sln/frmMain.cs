using CarRental.Amounts_Spent.Salary_Payments;
using CarRental.Classes;
using CarRental.Contract_Payment_Scheduling_Applications;
using CarRental.Customers;
using CarRental.FinancialObligations.ContractPaymentSchedulingApplications;
using CarRental.Login;
using CarRental.Maintenance_Management;
using CarRental.People.Employee;
using CarRental.People.User;
using CarRental.Pepole.Person;
using CarRental.Rental_Fund;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental.Rental_Transaction;
using CarRental.Rental_Transaction.Rental_Settings;
using CarRental.Users;
using CarRental.Vehicles;
using CarRental.Vehicles.Forms;
using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        frmAdministration  _frmAdministration;
        int _branchid {  get; set; }
        public frmMain(frmLogin frm,int brancid)
        {
            InitializeComponent();
            _frmLogin = frm;
            _branchid = brancid;    
        }

        public frmMain(frmAdministration frm, int branchid)
        {
            InitializeComponent();
            _frmAdministration = frm;
            _branchid = branchid;
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle frmAddUpdateVehicle = new frmAddUpdateVehicle();
            frmAddUpdateVehicle.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }


        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddNewBooking frm = new frmAddNewBooking();
            frm.ShowDialog();
        }

        private void vehicleRetuenToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmListRentalTransAction frm = new frmListRentalTransAction(clsGlobal.Branch.BranchID);
                frm.ShowDialog();
        }

        private void rentalTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListRentalTransAction frm = new frmListRentalTransAction();
            frm.ShowDialog();
        }



        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle();
            frm.ShowDialog();
        }

        private void listVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListVehicels frmList = new frmListVehicels(clsGlobal.Branch.BranchID);
            frmList.ShowDialog();
        }


        private void mangFundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managingTheDailyIncomeFundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ctrlEmployeeCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();
        }

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCustomers frm = new frmListCustomers();
            frm.ShowDialog();
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }

        private void usersTransactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListUsersTransActions frm = new frmListUsersTransActions();
            frm.ShowDialog();
        }

        private void addNewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();
            frm.ShowDialog();
        }

        private void listEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListEmployees frm = new frmListEmployees(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }


        private void dailyIncomeFundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDailyIncomeFund fund = clsDailyIncomeFund.GetDailyIncomeFundToDaye((float)clsGlobal.Branch.AmountSpentInfo.Amount, clsGlobal.Branch.CountHoursDailyIncomeFund, clsGlobal.Branch.BranchID);
            frmDailyIncomeFund frm2 = new frmDailyIncomeFund(fund.DailyIncomeFundID);
            frm2.ShowDialog();
        }

        private void listDailyIncomeFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDailyIncomeFunds frm = new frmListDailyIncomeFunds(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }

        private void generalRevenueFundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagingGeneralFund frm = new frmManagingGeneralFund(clsGlobal.GeneralRevenueFundID);
            frm.ShowDialog();
        }

        private void salaryPaymentsNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentOfSalaries frm = new frmPaymentOfSalaries(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }

        private void listSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfSalariesPaid frm = new frmListOfSalariesPaid(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }

        private void listTransavtionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moneyWithdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        bool _LoadBranch()
        {
            clsGlobal.Branch = clsBranch.Find(_branchid);
            clsGlobal.IsBranchInformationAvailable = clsGlobal.Branch!=null;
            return clsGlobal.IsBranchInformationAvailable;  
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadBranch();
            clsGlobal.Tax = clsTax.GetVat();
            clsGlobal.GetGeneralRevenueFund();
            if (clsGlobal.IsBranchInformationAvailable)
                clsGlobal.IsDailyFundAvailable = clsDailyIncomeFund.GetDailyIncomeFundToDaye((float)clsGlobal.Branch.AmountSpentInfo.Amount, clsGlobal.Branch.CountHoursDailyIncomeFund, clsGlobal.Branch.BranchID) != null;
            if (_frmLogin == null && clsGlobal.CurrentUser.IsAdmin)
            {
                msMainMenue.Items["AccountSettings"].Visible = false;
                msMainMenue.Items["GoBack"].Visible = true;
            }
            pbLogo.ImageLocation = clsGlobal.CurrentCompany.LogoPath;
            lblDate.Text = DateTime.Now.ToString("D");
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranchManagment frm = new frmBranchManagment();
            frm.ShowDialog();
        }

        private void vatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVat frmVat = new frmVat();
            frmVat.ShowDialog();
        }

        private void managementBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranchManagment frm = new frmBranchManagment(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void mangeMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaintenanceTransaction frm = new frmAddUpdateMaintenanceTransaction();
            frm.ShowDialog();
        }

        private void transferringANewCarToMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMaintenanceTransactions frm = new frmListMaintenanceTransactions();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void salesVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellingVehicle frm = new frmSellingVehicle();
            frm.ShowDialog();
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract frm = new frmAddUpdateContract();
            frm.ShowDialog();
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentOfInstallments frm = new frmPaymentOfInstallments(9);
            frm.ShowDialog();
        }

        private void sssssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateContractPaymentScheduling frm = new frmAddUpdateContractPaymentScheduling();
            frm.ShowDialog();
        }

        private void AccountSettings_Click(object sender, EventArgs e)
        {

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.Branch = null;
            clsGlobal.IsBranchInformationAvailable = false;
            this.Close();
            _frmAdministration.Show();
        }

        private void RentalBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfBillsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListOfBills frmListOfBills = new frmListOfBills(clsGlobal.Branch.BranchID);   
            frmListOfBills.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddUpdateContractPaymentScheduling frmAddUpdateContractPaymentScheduling = new frmAddUpdateContractPaymentScheduling();
            frmAddUpdateContractPaymentScheduling.ShowDialog();
        }

        private void listOfApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfSchedulingApplication frm = new frmListOfSchedulingApplication(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }

        private void installmentsDueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstallmentsDueThisMonth frmInstallmentsDueThisMonth = new frmInstallmentsDueThisMonth(clsGlobal.Branch.BranchID);
            frmInstallmentsDueThisMonth.ShowDialog();
        }

        private void addNewContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract frmAddUpdateContract = new frmAddUpdateContract();
            frmAddUpdateContract.ShowDialog();
        }

        private void listOfContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfContracts frm = new frmListOfContracts(clsGlobal.Branch.BranchID);
            frm.ShowDialog();
        }

        private void vehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiclesReturn frmVehicleReturn = new frmVehiclesReturn();
            frmVehicleReturn.ShowDialog();  
        }

        private void listPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople listPeople = new frmListPeople();
            listPeople.ShowDialog();    
        }
    }
}
