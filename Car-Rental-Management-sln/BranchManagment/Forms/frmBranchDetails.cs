using CarRental.Contract_Payment_Scheduling_Applications;
using CarRental.Maintenance_Management;
using CarRental.People.Employee;
using CarRental.Rental_Transaction;
using CarRental.Users;
using CarRental.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.BranchManagment.Forms
{
    public partial class frmBranchDetails : Form
    {
        private int _BranchID;
        public frmBranchDetails(int branchID)
        {
            InitializeComponent();
            _BranchID = branchID;
        }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmBranchDetails_Load(object sender, EventArgs e)
        {
            ctrlBranchCard1.LoadData(_BranchID);
            ctrlBranchStatistics1.LOadDateForBranchID(_BranchID);
        }
        private void btnDailyFunds_Click(object sender, EventArgs e)
        {
            frmListDailyIncomeFunds frmListDailyIncomeFunds = new frmListDailyIncomeFunds(_BranchID);
            frmListDailyIncomeFunds.ShowDialog();
        }
        private void btnMaintenanceTransactions_Click(object sender, EventArgs e)
        {
            frmListMaintenanceTransactions frmListMaintenanceTransactions = new frmListMaintenanceTransactions(_BranchID);
            frmListMaintenanceTransactions.ShowDialog();
        }
        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            frmListEmployees frm = new frmListEmployees(_BranchID);
            frm.ShowDialog();
        }
        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            frmListUsers frmListUsers = new frmListUsers(_BranchID);
            frmListUsers.ShowDialog();
        }
        private void btnShowVehicles_Click(object sender, EventArgs e)
        {
            frmListVehicels frm = new frmListVehicels(_BranchID); frm.ShowDialog();
        }
        private void btnShowRentalTransactions_Click(object sender, EventArgs e)
        {
            frmListRentalTransAction frm = new frmListRentalTransAction(_BranchID);
            frm.ShowDialog();
        }
        private void btnShowContracts_Click(object sender, EventArgs e)
        {
            frmListOfContracts frmListOfContracts = new frmListOfContracts(_BranchID);
            frmListOfContracts.ShowDialog();
        }
        private void btnBills_Click(object sender, EventArgs e)
        {
            frmListOfBills frmListOfBills = new frmListOfBills(_BranchID);
            frmListOfBills.ShowDialog();
        }
        private void btnContractPaymentSchedulingApplications_Click(object sender, EventArgs e)
        {
            frmListOfSchedulingApplication frm = new frmListOfSchedulingApplication(_BranchID);
            frm.ShowDialog();
        }
    }
}
