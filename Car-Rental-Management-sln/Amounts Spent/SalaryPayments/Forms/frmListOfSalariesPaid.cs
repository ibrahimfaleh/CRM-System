using CarRental.Classes;
using System;
using System.Windows.Forms;

namespace CarRental.Amounts_Spent.Salary_Payments
{
    public partial class frmListOfSalariesPaid : Form
    {
        public enum enMode { ShowByBranchID = 1, ShowAll = 2 }
        private enMode _mode;
        private int _BranchID;
        public frmListOfSalariesPaid(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
            _mode = enMode.ShowByBranchID;
        }
        public frmListOfSalariesPaid()
        {
            InitializeComponent();
            _mode = enMode.ShowAll;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListSalaryPayments_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListSalaryPayments))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if(_mode == enMode.ShowByBranchID)
                ctrldgvSalariesPaid1.LoadSalariesPaid(_BranchID);
            if (_mode == enMode.ShowAll)
                ctrldgvSalariesPaid1.LoadSalariesPaid();
        }
    }
}
