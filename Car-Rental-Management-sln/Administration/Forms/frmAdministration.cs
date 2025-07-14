using CarRental.Administration.Forms;
using CarRental.Amounts_Spent.Salary_Payments;
using CarRental.Bill_And_Financial_Penalties.Financial_Penalties.Forms;
using CarRental.Classes;
using CarRental.company_information;
using CarRental.Contract_Payment_Scheduling_Applications;
using CarRental.Customers;
using CarRental.FinancialObligations.ContractPaymentSchedulingApplications;
using CarRental.FinancialPenaltyAndFines.Fines.Forms;
using CarRental.Login;
using CarRental.People;
using CarRental.People.Employee;
using CarRental.People.User;
using CarRental.Pepole.Person;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental.Rental_Transaction;
using CarRental.Rental_Transaction.Rental_Settings;
using CarRental.Users;
using CarRental.Vehicles;
using CarRental.Vehicles.Forms;
using CarRental_Business;
using Guna.UI2.WinForms;
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
    public partial class frmAdministration : Form
    {
        frmLogin _frmLogin;
        public frmAdministration(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }


        private void DepartmentOfAccounting_Click(object sender, EventArgs e)
        {

        }

        private void frmProgramManagement_Load(object sender, EventArgs e)
        {
            clsGlobal.GetGeneralRevenueFund();
            clsGlobal.Tax=clsTax.GetVat();
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            pbLogo.ImageLocation = clsGlobal.CurrentCompany.LogoPath;
            lblDate.Text = DateTime.Now.ToString("D");
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.ShowDialog();
        }

        private void DailyIncomeFunds_Click(object sender, EventArgs e)
        {
            frmListDailyIncomeFunds frm=new frmListDailyIncomeFunds();
            frm.ShowDialog();
        }

        private void GeneralRevenueFund_Click(object sender, EventArgs e)
        {
            frmManagingGeneralFund frm = new frmManagingGeneralFund(clsGlobal.GeneralRevenueFundID);
            frm.ShowDialog();   
        }

        private void PaymentOfSalaries_Click(object sender, EventArgs e)
        {
            frmPaymentOfSalaries frm = new frmPaymentOfSalaries();
            frm.ShowDialog();
        }

        private void SalaryDisbursementList_Click(object sender, EventArgs e)
        {
            frmListOfSalariesPaid frm = new frmListOfSalariesPaid();
            frm.ShowDialog();
        }

        private void ListOfVehicles_Click(object sender, EventArgs e)
        {
            frmListVehicels frm = new frmListVehicels();
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

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            clsGlobal.CurrentUser = null;
            this.Close();

            _frmLogin.Show();

        }

        private void AddUpdatePerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            
        }

        private void AddUpdateCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();
        }

        private void ListOfCustomer_Click(object sender, EventArgs e)
        {
            frmListCustomers frm = new frmListCustomers();  
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();  
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmListUsersTransActions frm = new frmListUsersTransActions();
            frm.ShowDialog();
        }

        private void AddNewBranch_Click(object sender, EventArgs e)
        {
            frmBranchManagment frm = new frmBranchManagment();
            frm.ShowDialog();
        }

        private void AddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle(300);
            frm.ShowDialog();
        }

        private void SellingVehicles_Click(object sender, EventArgs e)
        {
            frmSellingVehicle frm = new frmSellingVehicle();
            frm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void rentalTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListRentalTransAction frm = new frmListRentalTransAction();
            frm.ShowDialog();
        }

        private void listOfBranchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfBranchesAndLogInToThem frmListOfBranches = new frmListOfBranchesAndLogInToThem(this);
            frmListOfBranches.Show();
        }

        private void addNewContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract frm = new frmAddUpdateContract();
            frm.ShowDialog();
        }

        private void listOfContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfContracts frmListOf =new frmListOfContracts();
            frmListOf.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBills frm = new frmAddUpdateBills();
            frm.ShowDialog();
        }

        private void listOfBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfBills frm =new frmListOfBills();
            frm.ShowDialog();
        }

        private void paymwntBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayGeneralFundBill frm = new frmPayGeneralFundBill();
            frm.ShowDialog();
        }

        private void ContractManagement_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddUpdateContractPaymentScheduling frm = new frmAddUpdateContractPaymentScheduling();
            frm.ShowDialog();
        }

        private void listOfBillsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListOfBills frmListOf =new frmListOfBills();
            frmListOf.ShowDialog();
        }

        private void paymentBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayGeneralFundBill frmPayGeneralFundBill = new frmPayGeneralFundBill();
            frmPayGeneralFundBill.ShowDialog();
        }

        private void vehicleSalesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            femListOfVehicleSales femListOfVehicleSales = new femListOfVehicleSales();
            femListOfVehicleSales.ShowDialog();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract frmAddUpdateContract = new frmAddUpdateContract();
            frmAddUpdateContract.ShowDialog();
        }

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCustomers frm =new frmListCustomers();
            frm.ShowDialog();
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser();
                frmAddUpdateUser.ShowDialog();
        }

        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm =new frmListUsers();
            frm.ShowDialog();
        }

        private void usersTransactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListUsersTransActions frm =new frmListUsersTransActions();
            frm.ShowDialog();
        }

        private void addNewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frmAddUpdateEmployee = new frmAddUpdateEmployee();
            frmAddUpdateEmployee.ShowDialog();
        }

        private void listEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListEmployees frm =new frmListEmployees();   
            frm.ShowDialog();
        }

        private void listOfApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfSchedulingApplication frmListOfSchedulingApplication = new frmListOfSchedulingApplication();
            frmListOfSchedulingApplication.ShowDialog();    
        }

        private void installmentsDueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstallmentsDueThisMonth frmInstallmentsDueThisMonth = new frmInstallmentsDueThisMonth();
            frmInstallmentsDueThisMonth.ShowDialog();
        }

        private void addNewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmAddUpdateFinancialPenalty frmAddUpdateFinancialPenalty = new frmAddUpdateFinancialPenalty();
            frmAddUpdateFinancialPenalty.ShowDialog();
        }

        private void listFinancialPenaltiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfFinancialPenalties frmListOfFinancialPenalties = new frmListOfFinancialPenalties();
            frmListOfFinancialPenalties.ShowDialog();
        }

        private void companyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompanyInformation frmCompanyInformation = new frmCompanyInformation();
            frmCompanyInformation.ShowDialog();
            frmProgramManagement_Load(null,null);
        }

        private void carRentalRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarRentalRules frmCarRentalRules = new frmCarRentalRules();
            frmCarRentalRules.ShowDialog();
        }

        private void vatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVat frmVat = new frmVat();
            frmVat.ShowDialog();
        }

        private void listPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople listPeople = new frmListPeople();
            listPeople.ShowDialog();
        }
    }

}
