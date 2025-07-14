using CarRental.Amounts_Spent.Money_Withdrawal_Transactions;
using CarRental.Classes;
using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.Rental_Fund.General_Revenue_Fund
{
    public partial class frmManagingGeneralFund : Form
    {
        private int _GeneralRevenueFundID;
        public frmManagingGeneralFund(int GeneralRevenueFundID)
        {
            InitializeComponent();
            _GeneralRevenueFundID = GeneralRevenueFundID;
        }
        private void LoadData()
        {
                ctrldgvListDailyIncomeFunds1.LoadDailyIncomeFund();
                ctrldgvSalaryPayments1.LoadSalariesPaid();
        }
        private void frmManagingGeneralFund_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmManagingGeneralFund))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrldgvGeneralFundSupportTransactions1.LoadGeneralFundSupportTransactions(_GeneralRevenueFundID);
            ctrldgvMoneyWithdrawalTransaction1.LoadMoneyWithdrawalTransaction(_GeneralRevenueFundID);
            ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(_GeneralRevenueFundID);
            ctrlListMaintenanceTransactions1.LoadData();
            txtAmount.Text = "";
            LoadData();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Amount <1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            clsGeneralRevenueFund generalRevenueFund = clsGeneralRevenueFund.Find(_GeneralRevenueFundID);
            if (rbCashToBank.Checked)
            {
                generalRevenueFund.Cash -= double.Parse(txtAmount.Text);
                generalRevenueFund.Bank += double.Parse(txtAmount.Text);
            }
            if (rbBankToCash.Checked)
            {
                generalRevenueFund.Cash += double.Parse(txtAmount.Text);
                generalRevenueFund.Bank -= double.Parse(txtAmount.Text);
            }
            if (generalRevenueFund.Save())
            {

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmManagingGeneralFund_Load(null, null);

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void rbCashToBank_CheckedChanged(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        private void btnFundSupport_Click(object sender, EventArgs e)
        {
            frmGeneralFundSupport frmGeneralFundSupport = new frmGeneralFundSupport();
            frmGeneralFundSupport.ShowDialog();
            frmManagingGeneralFund_Load(null, null);
        }

        private void btnMoneyWithdrawal_Click(object sender, EventArgs e)
        {
            frmMoneyWithdrawalTransaction frm = new frmMoneyWithdrawalTransaction();
            frm.ShowDialog();
            frmManagingGeneralFund_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrldgvMoneyWithdrawalTransaction1_OnAmountSpentSelected(int obj)
        {
            this.frmManagingGeneralFund_Load(null, null);
        }

        private void ctrldgvGeneralFundSupportTransactions1_OnUpdateGeneralFundSupportTransactions(bool obj)
        {
            this.frmManagingGeneralFund_Load(null, null);
        }

        private void btnCloseGeneralFund_Click(object sender, EventArgs e)
        {
            if (ctrlGeneralRevenueFundCardWithIncomeDetails1.GeneralRevenueFund.IsClosed)
            {
                MessageBox.Show("This already closed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ctrlGeneralRevenueFundCardWithIncomeDetails1.GeneralRevenueFund.IsClosed = true;
                clsGeneralRevenueFund GeneralRevenueFund = new clsGeneralRevenueFund();
                GeneralRevenueFund.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                if (GeneralRevenueFund.Save())
                    clsGlobal.GeneralRevenueFundID = GeneralRevenueFund.GeneralRevenueFundID;

            }

        }
    }
}
