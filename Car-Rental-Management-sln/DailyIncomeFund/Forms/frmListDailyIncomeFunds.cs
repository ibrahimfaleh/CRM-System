using CarRental.Classes;
using CarRental.Rental_Fund;
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
    public partial class frmListDailyIncomeFunds : Form
    {
        private int? _BranchID;
        public frmListDailyIncomeFunds()
        {
            InitializeComponent();
        }

        public frmListDailyIncomeFunds(int BranchID)
        {
            InitializeComponent();
            this._BranchID = BranchID;
        }

        private void frmListDailyIncomeFunds_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListDailyIncomeFunds))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (_BranchID == null)
                ctrldgvListDailyIncomeFunds1.LoadDailyIncomeFund();
            else
                ctrldgvListDailyIncomeFunds1.LoadDailyIncomeFund(_BranchID.Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentFromTheGeneralFundToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void ctrldgvListDailyIncomeFunds1_Load(object sender, EventArgs e)
        {

        }
    }
}
