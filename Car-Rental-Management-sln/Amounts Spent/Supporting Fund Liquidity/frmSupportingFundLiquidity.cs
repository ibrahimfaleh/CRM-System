using CarRental.Classes;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental.Rental_Transaction;
using CarRental_Business;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace CarRental.Rental_Fund
{
    public partial class frmSupportingFundLiquidity : Form
    {
        private int _DailyIncomeFundTransactionID;
        private clsDailyIncomeFund _DailyIncomeFund;
        private clsDailyIncomeFundTransaction _DailyIncomeFundTransaction;
        public frmSupportingFundLiquidity(int DailyIncomeFundTransactionID)
        {
            InitializeComponent();
            _DailyIncomeFundTransactionID = DailyIncomeFundTransactionID;
        }

        private void frmSupportingFundLiquidity_Load(object sender, EventArgs e)
        {
            
            if (clsSupportingFundLiquidity.isSupportingFundLiquidityExistByDailyIncomeFundTransactionID(_DailyIncomeFundTransactionID))
            {
                MessageBox.Show("This movement is already supported , TransactionID = " + _DailyIncomeFundTransactionID);
                this.Close();
                return;
            }
            if ((_DailyIncomeFundTransaction = clsDailyIncomeFundTransaction.Find(_DailyIncomeFundTransactionID)) == null)
            {
                MessageBox.Show("No Transaction with TransactionID = "+_DailyIncomeFundTransactionID);
                this.Close();
                return;
            }
            _DailyIncomeFund = clsDailyIncomeFund.Find(_DailyIncomeFundTransaction.DailyIncomeFundID);
            if(_DailyIncomeFund==null)
            {
                MessageBox.Show("Error");
                this.Close();
                return;
            }
            if(_DailyIncomeFund.ExpectedCashAmount>=0)
            {
                MessageBox.Show("This transaction does not require support");
                this.Close();
                return;
            }
            ctrlRentalTransactionDetails1.LoadRentalTransaction(_DailyIncomeFundTransaction.TransactionID);

            if (ctrlRentalTransactionDetails1.rentalTransactionSelected == null)
            {
                MessageBox.Show("No Transaction with TransactionID = " + _DailyIncomeFundTransaction.TransactionID);
                this.Close();
                return;
            }
            txtAmount.Text= ctrlRentalTransactionDetails1.rentalTransactionSelected.TotalRemaining.ToString();
        }
        private void DataBack(object sender,int AmountSpentID, bool IsSave, double Amount)
        {
            clsSupportingFundLiquidity clsSupportingFundLiquidity = new clsSupportingFundLiquidity();
            clsSupportingFundLiquidity.AmountSpentID= AmountSpentID;
            clsSupportingFundLiquidity.DailyIncomeFundTransactionID = _DailyIncomeFundTransactionID;
            clsSupportingFundLiquidity.SupportStatus = true;
            if (clsSupportingFundLiquidity.Save())
            {
                clsAmountSpent amountSpent = clsAmountSpent.Find(AmountSpentID);
                _DailyIncomeFund.ExpectedProfit += amountSpent.FromExpectedProfit;
                _DailyIncomeFund.ExpectedCashAmount += Amount;
                _DailyIncomeFund.TotalAvailableCashAmount += Amount;
                _DailyIncomeFund.ActualProfits += amountSpent.FromActualProfits;
                _DailyIncomeFund.VehicleBreakdownRevenues += amountSpent.FromVehicleBreakdownRevenues;
                _DailyIncomeFund.Save();
                MessageBox.Show("Data Save successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else
                MessageBox.Show("The data was not saved successfully", "Saved",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupportingFundLiquidity_Click(object sender, EventArgs e)
        {
            frmAddUpdateAmountSpent frmAddUpdate = new frmAddUpdateAmountSpent((ctrlRentalTransactionDetails1.rentalTransactionSelected.TotalRemaining.Value*-1),true);
            frmAddUpdate.DataBack += DataBack;
            frmAddUpdate.ShowDialog();
        }
    }
}
