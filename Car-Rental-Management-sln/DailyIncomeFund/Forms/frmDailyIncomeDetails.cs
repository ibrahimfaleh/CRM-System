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

namespace CarRental.Daily_Income_Fund
{
    public partial class frmDailyIncomeDetails : Form
    {
        private int _DailyIncomeID;
        public frmDailyIncomeDetails(int dailyIncomeID)
        {
            InitializeComponent();
            _DailyIncomeID = dailyIncomeID;
        }

        private void frmDailyIncomeDetails_Load(object sender, EventArgs e)
        {
            ctrlDgvDailyFundTransaction1.SupportingFundLiquidityStripMenuItem = false;
            clsDailyIncomeFund _DailyIncomeFund = clsDailyIncomeFund.Find(_DailyIncomeID);
            if (_DailyIncomeFund == null)
            {
                MessageBox.Show("Error");
                this.Close();
                return;
            }
            lblStartAmount.Text = _DailyIncomeFund.StartAmount.ToString();
            if (_DailyIncomeFund.IsClose)
                lblIsCLose.Text = "Yeas";
            else
                lblIsCLose.Text = "No";
            lblTotalIncome.Text = _DailyIncomeFund.TotalIncome.ToString();
            lblTotalIncomeCashAmount.Text = _DailyIncomeFund.ExpectedCashAmount.ToString();
            lblTransformation.Text = _DailyIncomeFund.ExpectedTransformationAmount.ToString();
            ctrlDgvDailyFundTransaction1.DailyFundTransactions_Load(_DailyIncomeFund.DailyIncomeFundID);
            txtTotalAvailableCashAmount.Text = _DailyIncomeFund.TotalAvailableCashAmount.ToString();
            txtTotalAvailableTransformationAmount.Text=_DailyIncomeFund.TotalAvailableTransformationAmount.ToString();
            lblTotalRevenueDeficitOrSurplus.Text = _DailyIncomeFund.TotalRevenueDeficitOrSurplus.ToString();
            lblStatus.Text = _DailyIncomeFund.GetStatus;  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
