using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.Rental_Fund.General_Revenue_Fund
{
    public partial class ctrlGeneralRevenueFundIncomeDetails : UserControl
    {
        public clsGeneralRevenueFund GeneralRevenueFund { private set; get; }
        public ctrlGeneralRevenueFundIncomeDetails()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblBank.Text = "";
            lblCash.Text = "";
            lblTotalAmounts.Text = "";
            lblActualProfits.Text = "";
            lblVehicleBerakdownRevenues.Text = "";
            lblAnotherIncome.Text = "";
            lblExpectedProfit.Text = "";
            lblVehicleSales.Text = "";
        }
        public void LoadData(int GeneralRevenueFundID)
        {
            _ResetDefaultValues();
            clsGeneralRevenueFund generalRevenueFund = clsGeneralRevenueFund.Find(GeneralRevenueFundID);
            if (generalRevenueFund != null)
            {
                lblBank.Text = generalRevenueFund.Bank.ToString();
                lblCash.Text = generalRevenueFund.Cash.ToString();
                lblTotalAmounts.Text = generalRevenueFund.TotalAmount.ToString();
                lblActualProfits.Text = generalRevenueFund.ActualProfits.ToString();
                lblVehicleBerakdownRevenues.Text = generalRevenueFund.VehicleBreakdownRevenues.ToString();
                lblAnotherIncome.Text=generalRevenueFund.AnotherIncome.ToString();
                lblExpectedProfit.Text=generalRevenueFund.ExpectedProfit.ToString();
                GeneralRevenueFund=generalRevenueFund;
                lblVehicleSales.Text=generalRevenueFund.VehicleSales.ToString();
            }
        }
    }
}
