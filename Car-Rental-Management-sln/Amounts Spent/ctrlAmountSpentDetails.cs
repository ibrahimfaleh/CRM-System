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

namespace CarRental.Amounts_Spent
{
    public partial class ctrlAmountSpentDetails : UserControl
    {
        public ctrlAmountSpentDetails()
        {
            InitializeComponent();
        }
        public void ResetDefaultValues()
        {
            lblAmountSpentID.Text = "??";
            lblAmountVBR.Text = "??";
            lblFromActualProfits.Text = "??";
            lblFromAnotherIncome.Text = "??";
            lblFromExpectedProfit.Text = "??";
            txtDetails.Text = "";
            lblFromVehicleSales.Text = "";
        }
        public void LoadData(int AmountSpentID)
        {
            clsAmountSpent amountSpent = clsAmountSpent.Find(AmountSpentID);
            ResetDefaultValues();
            if(amountSpent != null)
            {
                lblAmountSpentID.Text = amountSpent.AmountSpentID.ToString();
                lblAmountVBR.Text = amountSpent.FromVehicleBreakdownRevenues.ToString("0.00");
                lblFromActualProfits.Text = amountSpent.FromActualProfits.ToString("0.00");
                lblFromAnotherIncome.Text = amountSpent.FromAnotherIncome.ToString("0.00");
                lblFromExpectedProfit.Text = amountSpent.FromExpectedProfit.ToString("0.00");
                lblTotalAmount.Text = amountSpent.Amount.ToString("0.00");
                txtDetails.Text= amountSpent.Details.ToString();
                lblFromVehicleSales.Text = amountSpent.FromVehicleSales.ToString("0.00");
            }
            
        }
    }
}
