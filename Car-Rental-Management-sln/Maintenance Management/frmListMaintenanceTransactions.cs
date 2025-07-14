using CarRental.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Maintenance_Management
{
    public partial class frmListMaintenanceTransactions : Form
    {
        private ctrlListMaintenanceTransactions.enMode _Mode;
        private int _BranchID;
        public frmListMaintenanceTransactions(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
            _Mode = ctrlListMaintenanceTransactions.enMode.MaintenanceTransactionsByBranchID;
        }

        public frmListMaintenanceTransactions()
        {
            InitializeComponent();
            _Mode = ctrlListMaintenanceTransactions.enMode.AllMaintenanceTransactions;

        }
        private void frmListMaintenanceTransactions_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListMaintenanceTransactions))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (_Mode== ctrlListMaintenanceTransactions.enMode.MaintenanceTransactionsByBranchID)
                ctrlListMaintenanceTransactions1.LoadData(_BranchID);
            if (_Mode == ctrlListMaintenanceTransactions.enMode.AllMaintenanceTransactions)
                ctrlListMaintenanceTransactions1.LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaintenanceTransaction frm = new frmAddUpdateMaintenanceTransaction();  
            frm.ShowDialog();
            this.frmListMaintenanceTransactions_Load(null,null);
        }
    }
}
