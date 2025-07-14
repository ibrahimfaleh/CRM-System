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

namespace CarRental.Rental_Transaction
{
    public partial class frmListRentalTransAction : Form
    {
        private int _BranchID;
        public enum enMode { ListRentalTransactions = 1, ListRentalTransactionByBranchID = 2 }
        private enMode _Mode;
        public frmListRentalTransAction()
        {
            InitializeComponent();
            _Mode = enMode.ListRentalTransactions;
        }
        public frmListRentalTransAction(int BranchID)
        {
            InitializeComponent();
            _Mode = enMode.ListRentalTransactionByBranchID;
            _BranchID = BranchID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmListTransAction_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListRentalTransactions))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if(_Mode==enMode.ListRentalTransactionByBranchID)
                ctrlDgvListTransactions1.ctrldgRentalBookingWithFalter_LoadByBranchID(_BranchID);
            if(_Mode==enMode.ListRentalTransactions)
                ctrlDgvListTransactions1.ctrldgRentalBookingWithFalter_Load();
        }

        private void btnAddNewBooking_Click(object sender, EventArgs e)
        {
            frmAddNewBooking frm = new frmAddNewBooking();
            frm.ShowDialog();
        }

        private void ctrlDgvListTransactions1_Load(object sender, EventArgs e)
        {

        }
    }
}
