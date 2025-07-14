using CarRental.Classes;
using CarRental_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.Users
{
    public partial class frmAddUpdateUser : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        clsUser _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = UserID;
        }
        private int _SetPermissions()
        {
            int P = 0;
            if (cbSetAllPermissions.Checked)
                return (int)clsGlobal.enPermissions.All;
            if (cbAddUbdatePerson.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdatePerson;

            if (cbAddUpdateCustomer.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateCustomer;

            if (cbListVehicles.Checked)
                P += (int)clsGlobal.enPermissions.frmListVehicles;

            if (cbBookingCheck.Checked)
                P += (int)clsGlobal.enPermissions.frmAddNewRentalBooking;

            if (cbVehicleReturn.Checked)
                P += (int)clsGlobal.enPermissions.frmVehicleReturn;

            if (cbListRentalTransactions.Checked)
                P += (int)clsGlobal.enPermissions.frmListRentalTransactions;

            if (cbShowCustomerDetails.Checked)
                P += (int)clsGlobal.enPermissions.frmShowCustomerDetails;

            if (cbShowRentalTransactionDetails.Checked)
                P += (int)clsGlobal.enPermissions.frmShowRentalDetails;

            if (cbAddNewRentalBooking.Checked)
                P += (int)clsGlobal.enPermissions.frmAddNewRentalBooking;

            if (cbDailyIncomeFund.Checked)
                P += (int)clsGlobal.enPermissions.frmDailyIncomeFund;

            if (cbListDailyIncomeFunds.Checked)
                P += (int)clsGlobal.enPermissions.frmListDailyIncomeFunds;

            if (cbSalaryPayments.Checked)
                P += (int)clsGlobal.enPermissions.frmSalaryPayments;

            if (cbListsalaryPayments.Checked)
                P += (int)clsGlobal.enPermissions.frmListSalaryPayments;

            if (cbMoneyWithdrawal.Checked)
                P += (int)clsGlobal.enPermissions.frmMoneyWithdrawal;

            if (cbVat.Checked)
                P += (int)clsGlobal.enPermissions.frmVat;

            if (cbaddNewBranch.Checked)
                P += (int)clsGlobal.enPermissions.frmAddNewBranch;

            if (cbUpdateBranch.Checked)
                P += (int)clsGlobal.enPermissions.frmUpdateBranch;

            if (cbAddUpdateUser.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateUsers;

            if (cbListusers.Checked)
                P += (int)clsGlobal.enPermissions.frmListUsers;

            if (cbUserDetails.Checked)
                P += (int)clsGlobal.enPermissions.frmUserDetails;

            if (cbListUserTransactions.Checked)
                P += (int)clsGlobal.enPermissions.frmListUsersTransaction;

            if (cbListEmployees.Checked)
                P += (int)clsGlobal.enPermissions.frmListEmployees;

            if (cbGeneralFundSupport.Checked)
                P += (int)clsGlobal.enPermissions.frmGeneralFundSupport;

            if (cbListGeneralFundSupports.Checked)
                P += (int)clsGlobal.enPermissions.frmListGeneralFundSupporters;

            if (cbListMaintenanceTransaction.Checked)
                P += (int)clsGlobal.enPermissions.frmListMaintenanceTransactions;

            if (cbManagingGeneralFund.Checked)
                P += (int)clsGlobal.enPermissions.frmManagingGeneralFund;

            if (cbAddUpdateEmployee.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateEmployee;

            if (cbAddUpdateMaintenance.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateMaintenance;

            if (cbUpdateAmountSpent.Checked)
                P += (int)clsGlobal.enPermissions.frmUpdateAmountSpent;
            return P;
        }
        private int _GivePermissions()
        {
            int P = 0;
            if (cbGiveAllPermissions.Checked)
                return (int)clsGlobal.enPermissions.All;
            if (cbGiveAddUpdatePerson.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdatePerson;

            if (cbGiveAddUpdateCustomer.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateCustomer;

            if (cbGiveListVehicles.Checked)
                P += (int)clsGlobal.enPermissions.frmListVehicles;

            if (cbGiveBookingCheck.Checked)
                P += (int)clsGlobal.enPermissions.frmAddNewRentalBooking;

            if (cbGiveVehicleRetuen.Checked)
                P += (int)clsGlobal.enPermissions.frmVehicleReturn;

            if (cbGiveRentalTransaction.Checked)
                P += (int)clsGlobal.enPermissions.frmListRentalTransactions;

            if (cbGiveShowCustomerDetails.Checked)
                P += (int)clsGlobal.enPermissions.frmShowCustomerDetails;

            if (cbGiveShowRentalDetails.Checked)
                P += (int)clsGlobal.enPermissions.frmShowRentalDetails;

            if (cbGiveAddNewRentalBooking.Checked)
                P += (int)clsGlobal.enPermissions.frmAddNewRentalBooking;

            if (cbGiveDailyIncomeFund.Checked)
                P += (int)clsGlobal.enPermissions.frmDailyIncomeFund;

            if (cbGiveListDailyIncomeFunds.Checked)
                P += (int)clsGlobal.enPermissions.frmListDailyIncomeFunds;

            if (cbGiveSalaryPayments.Checked)
                P += (int)clsGlobal.enPermissions.frmSalaryPayments;

            if (cbGiveListSalaryPayments.Checked)
                P += (int)clsGlobal.enPermissions.frmListSalaryPayments;

            if (cbGiveMoneyWithdrawal.Checked)
                P += (int)clsGlobal.enPermissions.frmMoneyWithdrawal;

            if (cbGiveVat.Checked)
                P += (int)clsGlobal.enPermissions.frmVat;

            if (cbGiveAddNewBranch.Checked)
                P += (int)clsGlobal.enPermissions.frmAddNewBranch;

            if (cbGiveUpdateBranch.Checked)
                P += (int)clsGlobal.enPermissions.frmUpdateBranch;

            if (cbGiveAddUpdateUser.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateUsers;

            if (cbGiveListUsers.Checked)
                P += (int)clsGlobal.enPermissions.frmListUsers;

            if (cbGiveUserDetails.Checked)
                P += (int)clsGlobal.enPermissions.frmUserDetails;

            if (cbGiveListUserTransactions.Checked)
                P += (int)clsGlobal.enPermissions.frmListUsersTransaction;

            if (cbGiveListEmployees.Checked)
                P += (int)clsGlobal.enPermissions.frmListEmployees;

            if (cbGiveGeneralFundSupport.Checked)
                P += (int)clsGlobal.enPermissions.frmGeneralFundSupport;

            if (cbGiveListGeneralFundSupports.Checked)
                P += (int)clsGlobal.enPermissions.frmListGeneralFundSupporters;

            if (cbGiveListMaintenanceTransaction.Checked)
                P += (int)clsGlobal.enPermissions.frmListMaintenanceTransactions;

            if (cbGiveManagingGeneralFund.Checked)
                P += (int)clsGlobal.enPermissions.frmManagingGeneralFund;

            if (cbGiveAddUpdateEmployee.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateEmployee;

            if (cbGiveAddUpdateMaintenance.Checked)
                P += (int)clsGlobal.enPermissions.frmAddUpdateMaintenance;

            if (cbGiveUpdateAmountSpent.Checked)
                P += (int)clsGlobal.enPermissions.frmUpdateAmountSpent;
            return P;
        }
        private void _ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                tpLoginInfo.Enabled = false;
                tabSetPermissions.Enabled = false;

                ctrlEmployeeCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
                tabGivePermissions.Enabled = true;
                tabSetPermissions.Enabled = true;

            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
            tabGivePermissions.Enabled = false;

        }
        private void _LoadSetPermissionsForGive()
        {

            if ((((int)clsGlobal.enPermissions.All) & clsGlobal.CurrentUser.Permissions) == (int)clsGlobal.enPermissions.All)
                return;

            if ((((int)clsGlobal.enPermissions.frmAddUpdatePerson) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmAddUpdatePerson)
                cbAddUbdatePerson.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateCustomer) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmAddUpdateCustomer)
                cbAddUpdateCustomer.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListVehicles) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListVehicles)
                cbListVehicles.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmBookingCheck) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmBookingCheck)
                cbBookingCheck.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmVehicleReturn) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmVehicleReturn)
                cbVehicleReturn.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListRentalTransactions) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListRentalTransactions)
                cbListRentalTransactions.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmShowCustomerDetails) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmShowCustomerDetails)
                cbShowCustomerDetails.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmShowRentalDetails) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmShowRentalDetails)
                cbShowRentalTransactionDetails.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmAddNewRentalBooking) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmAddNewRentalBooking)
                cbAddNewRentalBooking.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmDailyIncomeFund) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmDailyIncomeFund)
                cbDailyIncomeFund.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListDailyIncomeFunds) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListDailyIncomeFunds)
                cbListDailyIncomeFunds.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmSalaryPayments) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmSalaryPayments)
                cbSalaryPayments.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListSalaryPayments) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListSalaryPayments)
                cbListsalaryPayments.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmMoneyWithdrawal) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmMoneyWithdrawal)
                cbMoneyWithdrawal.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmVat) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmVat)
                cbVat.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmAddNewBranch) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmAddNewBranch)
                cbaddNewBranch.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmUpdateBranch) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmUpdateBranch)
                cbUpdateBranch.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateUsers) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmAddUpdateUsers)
                cbAddUpdateUser.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListUsers) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListUsers)
                cbListusers.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmUserDetails) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmUserDetails)
                cbUserDetails.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListUsersTransaction) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListUsersTransaction)
                cbListUserTransactions.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListEmployees) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListEmployees)
                cbListEmployees.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmGeneralFundSupport) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmGeneralFundSupport)
                cbGeneralFundSupport.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListGeneralFundSupporters) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListGeneralFundSupporters)
                cbListGeneralFundSupports.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateEmployee) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmAddUpdateEmployee)
                cbAddUpdateEmployee.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateMaintenance) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmAddUpdateMaintenance)
                cbAddUpdateMaintenance.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmListMaintenanceTransactions) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmListMaintenanceTransactions)
                cbListMaintenanceTransaction.Enabled = false;

            if ((((int)clsGlobal.enPermissions.frmManagingGeneralFund) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmManagingGeneralFund)
                cbManagingGeneralFund.Enabled = false;


            if ((((int)clsGlobal.enPermissions.frmUpdateAmountSpent) & clsGlobal.CurrentUser.GivePermissions) != (int)clsGlobal.enPermissions.frmUpdateAmountSpent)
                cbUpdateAmountSpent.Enabled = false;
            cbSetAllPermissions.Enabled = false;
        }
        private void _LoadSetPermissions()
        {

            if ((((int)clsGlobal.enPermissions.All) & _User.Permissions) == (int)clsGlobal.enPermissions.All)
            {
                cbSetAllPermissions.Checked = true;
                return;
            }

            if ((((int)clsGlobal.enPermissions.frmAddUpdatePerson) & _User.Permissions) == (int)clsGlobal.enPermissions.frmAddUpdatePerson)
                cbAddUbdatePerson.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateCustomer) & _User.Permissions) == (int)clsGlobal.enPermissions.frmAddUpdateCustomer)
                cbAddUpdateCustomer.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListVehicles) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListVehicles)
                cbListVehicles.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmBookingCheck) & _User.Permissions) == (int)clsGlobal.enPermissions.frmBookingCheck)
                cbBookingCheck.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmVehicleReturn) & _User.Permissions) == (int)clsGlobal.enPermissions.frmVehicleReturn)
                cbVehicleReturn.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListRentalTransactions) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListRentalTransactions)
                cbListRentalTransactions.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmShowCustomerDetails) & _User.Permissions) == (int)clsGlobal.enPermissions.frmShowCustomerDetails)
                cbShowCustomerDetails.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmShowRentalDetails) & _User.Permissions) == (int)clsGlobal.enPermissions.frmShowRentalDetails)
                cbShowRentalTransactionDetails.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddNewRentalBooking) & _User.Permissions) == (int)clsGlobal.enPermissions.frmAddNewRentalBooking)
                cbAddNewRentalBooking.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmDailyIncomeFund) & _User.Permissions) == (int)clsGlobal.enPermissions.frmDailyIncomeFund)
                cbDailyIncomeFund.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListDailyIncomeFunds) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListDailyIncomeFunds)
                cbListDailyIncomeFunds.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmSalaryPayments) & _User.Permissions) == (int)clsGlobal.enPermissions.frmSalaryPayments)
                cbSalaryPayments.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListSalaryPayments) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListSalaryPayments)
                cbListsalaryPayments.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmMoneyWithdrawal) & _User.Permissions) == (int)clsGlobal.enPermissions.frmMoneyWithdrawal)
                cbMoneyWithdrawal.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmVat) & _User.Permissions) == (int)clsGlobal.enPermissions.frmVat)
                cbVat.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddNewBranch) & _User.Permissions) == (int)clsGlobal.enPermissions.frmAddNewBranch)
                cbaddNewBranch.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmUpdateBranch) & _User.Permissions) == (int)clsGlobal.enPermissions.frmUpdateBranch)
                cbUpdateBranch.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateUsers) & _User.Permissions) == (int)clsGlobal.enPermissions.frmAddUpdateUsers)
                cbAddUpdateUser.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListUsers) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListUsers)
                cbListusers.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmUserDetails) & _User.Permissions) == (int)clsGlobal.enPermissions.frmUserDetails)
                cbUserDetails.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListUsersTransaction) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListUsersTransaction)
                cbListUserTransactions.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListEmployees) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListEmployees)
                cbListEmployees.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmGeneralFundSupport) & _User.Permissions) == (int)clsGlobal.enPermissions.frmGeneralFundSupport)
                cbGeneralFundSupport.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListGeneralFundSupporters) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListGeneralFundSupporters)
                cbListGeneralFundSupports.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateEmployee) & _User.Permissions) == (int)clsGlobal.enPermissions.frmAddUpdateEmployee)
                cbAddUpdateEmployee.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateMaintenance) & _User.Permissions) == (int)clsGlobal.enPermissions.frmAddUpdateMaintenance)
                cbAddUpdateMaintenance.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListMaintenanceTransactions) & _User.Permissions) == (int)clsGlobal.enPermissions.frmListMaintenanceTransactions)
                cbListMaintenanceTransaction.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmManagingGeneralFund) & _User.Permissions) == (int)clsGlobal.enPermissions.frmManagingGeneralFund)
                cbManagingGeneralFund.Checked = true;


            if ((((int)clsGlobal.enPermissions.frmUpdateAmountSpent) & _User.Permissions) == (int)clsGlobal.enPermissions.frmUpdateAmountSpent)
                cbUpdateAmountSpent.Checked = true;
            cbSetAllPermissions.Checked = false;
        }
        private void _Load_GivePermissions()
        {

            if ((((int)clsGlobal.enPermissions.All) & _User.GivePermissions) == (int)clsGlobal.enPermissions.All)
            {
                cbGiveAllPermissions.Checked = true;
                return;
            }

            if ((((int)clsGlobal.enPermissions.frmAddUpdatePerson) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmAddUpdatePerson)
                cbGiveAddUpdatePerson.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateCustomer) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmAddUpdateCustomer)
                cbGiveAddUpdateCustomer.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListVehicles) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListVehicles)
                cbGiveListVehicles.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmBookingCheck) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmBookingCheck)
                cbGiveBookingCheck.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmVehicleReturn) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmVehicleReturn)
                cbGiveVehicleRetuen.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListRentalTransactions) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListRentalTransactions)
                cbGiveRentalTransaction.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmShowCustomerDetails) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmShowCustomerDetails)
                cbGiveShowCustomerDetails.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmShowRentalDetails) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmShowRentalDetails)
                cbGiveShowRentalDetails.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddNewRentalBooking) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmAddNewRentalBooking)
                cbGiveAddNewRentalBooking.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmDailyIncomeFund) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmDailyIncomeFund)
                cbGiveDailyIncomeFund.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListDailyIncomeFunds) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListDailyIncomeFunds)
                cbGiveListDailyIncomeFunds.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmSalaryPayments) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmSalaryPayments)
                cbGiveSalaryPayments.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListSalaryPayments) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListSalaryPayments)
                cbGiveListSalaryPayments.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmMoneyWithdrawal) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmMoneyWithdrawal)
                cbGiveMoneyWithdrawal.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmVat) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmVat)
                cbGiveVat.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddNewBranch) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmAddNewBranch)
                cbGiveAddNewBranch.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmUpdateBranch) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmUpdateBranch)
                cbGiveUpdateBranch.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateUsers) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmAddUpdateUsers)
                cbGiveAddUpdateUser.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListUsers) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListUsers)
                cbGiveListUsers.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmUserDetails) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmUserDetails)
                cbGiveUserDetails.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListUsersTransaction) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListUsersTransaction)
                cbGiveListUserTransactions.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListEmployees) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListEmployees)
                cbGiveListEmployees.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmGeneralFundSupport) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmGeneralFundSupport)
                cbGiveGeneralFundSupport.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListGeneralFundSupporters) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListGeneralFundSupporters)
                cbGiveListGeneralFundSupports.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateEmployee) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmAddUpdateEmployee)
                cbGiveAddUpdateEmployee.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmAddUpdateMaintenance) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmAddUpdateMaintenance)
                cbGiveAddUpdateMaintenance.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmListMaintenanceTransactions) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmListMaintenanceTransactions)
                cbGiveListMaintenanceTransaction.Checked = true;

            if ((((int)clsGlobal.enPermissions.frmManagingGeneralFund) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmManagingGeneralFund)
                cbGiveManagingGeneralFund.Checked = true;


            if ((((int)clsGlobal.enPermissions.frmUpdateAmountSpent) & _User.GivePermissions) == (int)clsGlobal.enPermissions.frmUpdateAmountSpent)
                cbGiveUpdateAmountSpent.Checked = true;
            cbGiveAllPermissions.Checked = false;
        }
        private void _LoadData()
        {

            _User = clsUser.FindByUserID(_UserID);
            ctrlEmployeeCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            if(_User.UserID==clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("You cannot edit yourself","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                this.Close();
                return;
            }
            _LoadSetPermissions();
            _LoadSetPermissionsForGive();
            _Load_GivePermissions();
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrlEmployeeCardWithFilter1.LoadEmployeeInfo(_User.EmployeeID);
            if (clsGlobal.CurrentUser.IsAdmin)
                tabGivePermissions.Enabled =true;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmAddUpdateUsers))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _User.EmployeeID = ctrlEmployeeCardWithFilter1.EmployeeID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password =clsUtil.ComputeHash( txtPassword.Text.Trim());
            _User.IsActive = chkIsActive.Checked;
            _User.Permissions = _SetPermissions();
            _User.GivePermissions = _GivePermissions();
            if (_Mode == enMode.AddNew)
                _User.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_User.Save(clsGlobal.CurrentUser.UserID))
            {
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsUser.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.isUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
        }


        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlEmployeeCardWithFilter1.FilterFocus();
        }

        private void frmAddUpdateUser_Load_1(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcUserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tcUserInfo_Selecting(object sender, TabControlCancelEventArgs e)
        {
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSetPermissions_Click(object sender, EventArgs e)
        {
            tabSetPermissions.Enabled = true;
        }

        private void btnGivePermissions_Click(object sender, EventArgs e)
        {
            if ((((int)clsGlobal.enPermissions.All) & clsGlobal.CurrentUser.Permissions) == (int)clsGlobal.enPermissions.All)
                gbGivePermissions.Enabled = true;
            else
                gbGivePermissions.Enabled = false;
        }

        private void cbGiveAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if ((((int)clsGlobal.enPermissions.All) & clsGlobal.CurrentUser.Permissions) == (int)clsGlobal.enPermissions.All)
                gbGivePermissions.Enabled = !cbGiveAllPermissions.Checked;
        }

        private void cbSetAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            gbSetPermissions.Enabled = !cbSetAllPermissions.Checked;
        }

        private void cbAddUpdateUser_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tabSetPermissions.Enabled = true;
                tabGivePermissions.Enabled = true;
                tcUserInfo.SelectedIndex++;
                btnNext.Enabled = !((tcUserInfo.SelectedIndex + 1) == tcUserInfo.TabCount);
                btnBack.Enabled = true;
                return;
            }

            if (ctrlEmployeeCardWithFilter1.EmployeeID != -1)
            {

                if (clsUser.isUserExistForEmployeeID(ctrlEmployeeCardWithFilter1.EmployeeID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlEmployeeCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tabSetPermissions.Enabled = true;
                    tabGivePermissions.Enabled = true;
                    tcUserInfo.SelectedIndex++;
                    btnNext.Enabled = !((tcUserInfo.SelectedIndex + 1) == tcUserInfo.TabCount);
                    btnBack.Enabled = true;
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlEmployeeCardWithFilter1.FilterFocus();

            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            tcUserInfo.SelectedIndex--;
            btnBack.Enabled = !(tcUserInfo.SelectedIndex == 0);
            btnNext.Enabled = true;
        }
    }
}
