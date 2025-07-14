using CarRental.Classes;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.Rental_Fund
{
    public partial class frmDailyIncomeFund : Form
    {
        private int _DailyIncomeFundID;
        private clsDailyIncomeFund _DailyIncomeFund;
        public struct stAmountsPayBill
        {
            public double ExpectedProfit;
            public double ActualProfits;
            public double AmountVBR;
            public double Total { get { return ActualProfits + ExpectedProfit + AmountVBR; } }
        }
        private stAmountsPayBill _stAmountsPayBill;
        public frmDailyIncomeFund(int DailyIncomeFundID)
        {
            InitializeComponent();
            _DailyIncomeFundID = DailyIncomeFundID;
        }
        private void txtValidatePositiveDecimalNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            if (ctrlBillCardWithFilter1.Bill != null)
                return;
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }
        private void _CalculateOrIncomeStatus()
        {
            lblTotalRevenueDeficitOrSurplus.Text = _DailyIncomeFund.TotalRevenueDeficitOrSurplus.ToString();
            lblstatus.Text = _DailyIncomeFund.GetStatus;
            if (_DailyIncomeFund.Status == (byte)clsDailyIncomeFund.enStatus.Deficit)
            {
                lblstatus.ForeColor = Color.Red;
                return;
            }
            if (_DailyIncomeFund.Status == (byte)clsDailyIncomeFund.enStatus.Balanced)
            {
                lblstatus.ForeColor = Color.Green;
                return;
            }
            if (_DailyIncomeFund.Status == (byte)clsDailyIncomeFund.enStatus.Surplus)
            {
                lblstatus.ForeColor = Color.Orange;
                return;
            }
        }
        private void _ResetDefaultValues()
        {
            _stAmountsPayBill=new stAmountsPayBill();
            lblAmountVBR.Text = "";
            lblActualProfits.Text = "";
            ctrlBillCardWithFilter1.ResetValues();
            btnPay.Enabled = false;
            txtCost.Text = "";
            txtFromActualProfits.Text = "";
            txtAmountVBR.Text = "";
            txtFromExpectedProfit.Text = "";
            lblExpectedProfit.Text = "";
            lblSratDate.Text = "";
            tabBills.Enabled=true;
        }
        private void _FullDailyFundManagement()
        {
            _DailyIncomeFund = clsDailyIncomeFund.Find(_DailyIncomeFundID);
            if (_DailyIncomeFund == null)
            {
                MessageBox.Show("Error");
                this.Close();
                return;
            }
            lblSratDate.Text = _DailyIncomeFund.Date.ToString();
            lblStartAmount.Text = _DailyIncomeFund.StartAmount.ToString();
            if (_DailyIncomeFund.IsClose)
            {
                lblIsCLose.Text = "Yeas";
                tabBills.Enabled = false;
            }
            else
                lblIsCLose.Text = "No";
            lblTotalIncome.Text = _DailyIncomeFund.TotalIncome.ToString();
            lblTotalIncomeCashAmount.Text = _DailyIncomeFund.ExpectedCashAmount.ToString();
            lblTransformation.Text = _DailyIncomeFund.ExpectedTransformationAmount.ToString();
            lblActualProfits.Text = _DailyIncomeFund.ActualProfits.ToString();
            lblAmountVBR.Text = _DailyIncomeFund.VehicleBreakdownRevenues.ToString();
            lblExpectedProfit.Text = _DailyIncomeFund.ExpectedProfit.ToString();
            ctrlDgvDailyFundTransaction1.DailyFundTransactions_Load(_DailyIncomeFund.DailyIncomeFundID);
            txtFromExpectedProfit.Enabled = (_DailyIncomeFund.ExpectedProfit > 0);
            _CalculateOrIncomeStatus();
            txtTotalAvailableCashAmount.Text = "0";
            txtTotalAvailableTransformationAmount.Text = "0";

        }
        private void frmDailyFundManagement_Load(object sender, EventArgs e)
        {
            if(!clsGlobal.IsBranchInformationAvailable)
            {
                MessageBox.Show("You must log in to the branch","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmDailyIncomeFund))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _ResetDefaultValues();
            _FullDailyFundManagement();
        }
        private void btnFundClose_Click(object sender, EventArgs e)
        {
            if (_DailyIncomeFund.IsClose == true)
            {
                MessageBox.Show("Already closed");
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            clsGeneralRevenueFund GeneralRevenueFund = clsGeneralRevenueFund.Find(clsGlobal.GeneralRevenueFundID);
            if (_DailyIncomeFund.Date < clsDailyIncomeFund.GetStartDate(clsGlobal.Branch.CountHoursDailyIncomeFund)|| _DailyIncomeFund.Date.Day>DateTime.Now.Day)
            {
                _DailyIncomeFund.TotalAvailableCashAmount = double.Parse(txtTotalAvailableCashAmount.Text);
                _DailyIncomeFund.TotalAvailableTransformationAmount = double.Parse(txtTotalAvailableTransformationAmount.Text);
                _DailyIncomeFund.IsClose = true;
                _DailyIncomeFund.ClosedByUserID = clsGlobal.CurrentUser.UserID;
                GeneralRevenueFund.Cash += _DailyIncomeFund.TotalAvailableCashAmount-_DailyIncomeFund.StartAmount;
                GeneralRevenueFund.Bank += _DailyIncomeFund.TotalAvailableTransformationAmount;
                GeneralRevenueFund.VehicleBreakdownRevenues += _DailyIncomeFund.VehicleBreakdownRevenues;
                GeneralRevenueFund.ActualProfits += _DailyIncomeFund.ActualProfits;
                GeneralRevenueFund.ExpectedProfit += _DailyIncomeFund.ExpectedProfit;
                if (_DailyIncomeFund.Save())
                {
                    GeneralRevenueFund.Save();
                    MessageBox.Show("Data Save successfully");
                    frmDailyFundManagement_Load(null,null);
                }
            }
            else
            {
                MessageBox.Show((clsDailyIncomeFund.GetStartDate(clsGlobal.Branch.CountHoursDailyIncomeFund).AddHours(clsGlobal.Branch.CountHoursDailyIncomeFund) - DateTime.Now).ToString() + " hours left until closing");
            }
        }
        private void txtTotalAvailableCashAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalAvailableCashAmount.Text.Length > 0)
                _DailyIncomeFund.TotalAvailableCashAmount = double.Parse(txtTotalAvailableCashAmount.Text);
            else _DailyIncomeFund.TotalAvailableCashAmount = 0;
            _CalculateOrIncomeStatus();
        }
        private void txtTotalAvailableTransformationAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalAvailableTransformationAmount.Text.Length > 0)
                _DailyIncomeFund.TotalAvailableTransformationAmount = double.Parse(txtTotalAvailableTransformationAmount.Text);
            else _DailyIncomeFund.TotalAvailableTransformationAmount = 0;
            _CalculateOrIncomeStatus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ResetDefaultValuesForBill()
        {
            errorProviderPayBill.Clear();
            txtFromExpectedProfit.Text = "";
            txtAmountVBR.Text = "";
            txtCost.Text = "";
            txtFromActualProfits.Text = "";
            ctrlBillCardWithFilter1.ResetValues();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(_DailyIncomeFund.IsClose)
            {
                MessageBox.Show("Already closed");
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            clsDailyFundBill transaction = new clsDailyFundBill();
            transaction.DailyIncomeFundID = _DailyIncomeFund.DailyIncomeFundID;
            transaction.BillID = ctrlBillCardWithFilter1.Bill.BillID;
            transaction.PaidByUserID = clsGlobal.CurrentUser.UserID;
            transaction.FromExpectedProfit = _stAmountsPayBill.ExpectedProfit;
            transaction.ActualProfits = _stAmountsPayBill.ActualProfits;
            transaction.FromVehicleBreakdownRevenues = _stAmountsPayBill.AmountVBR;
            if (transaction.Save())
            {
                _DailyIncomeFund.ExpectedCashAmount -= ctrlBillCardWithFilter1.Bill.Cost;
                _DailyIncomeFund.VehicleBreakdownRevenues -= transaction.FromVehicleBreakdownRevenues;
                _DailyIncomeFund.ActualProfits -= transaction.ActualProfits;
                _DailyIncomeFund.ExpectedProfit -= transaction.FromExpectedProfit;
                _DailyIncomeFund.TotalAvailableCashAmount = 0;
                _DailyIncomeFund.TotalAvailableTransformationAmount = 0;
                _DailyIncomeFund.Save();
                ctrlBillCardWithFilter1.Bill.IsPaid = true;
                ctrlBillCardWithFilter1.Bill.PaymentDate = DateTime.Now;
                ctrlBillCardWithFilter1.Bill.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
                ctrlBillCardWithFilter1.Bill.Save();
                MessageBox.Show("Payment was made successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDailyFundManagement_Load(null, null);
            }
            else
                MessageBox.Show("Payment has not been made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ValidateEmptyTextBoxesForPayBill(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (ctrlBillCardWithFilter1.Bill == null)
            {
                errorProviderPayBill.SetError(Temp, null);
                return;
            }
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderPayBill.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProviderPayBill.SetError(Temp, null);
            }
        }
        private void txtFromExpectedProfit_Validating(object sender, CancelEventArgs e)
        {
            if (_DailyIncomeFund.ExpectedProfit < 0)
                return;
            ValidateEmptyTextBoxesForPayBill(sender, e);
            if (txtFromExpectedProfit.Text != ""&&_DailyIncomeFund.ExpectedProfit>=0)
                if (_stAmountsPayBill.ExpectedProfit > _DailyIncomeFund.ExpectedProfit)
                {
                    e.Cancel = true;
                    errorProviderPayBill.SetError(txtFromExpectedProfit, "The fund balance is insufficient");
                }
                else
                    errorProviderPayBill.SetError(txtFromExpectedProfit, null);
        }
        private void txtFromActualProfits_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBoxesForPayBill(sender, e);
            if (txtFromActualProfits.Text != "")
                if (_stAmountsPayBill.ActualProfits > _DailyIncomeFund.ActualProfits)
                {
                    e.Cancel = true;
                    errorProviderPayBill.SetError(txtFromActualProfits, "The fund balance is insufficient");
                }
                else
                    errorProviderPayBill.SetError(txtFromActualProfits, null);
        }
        private void txtAmountVBR_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBoxesForPayBill(sender, e);
            if (txtAmountVBR.Text != "")
                if (_stAmountsPayBill.AmountVBR > _DailyIncomeFund.VehicleBreakdownRevenues)
                {
                    e.Cancel = true;
                    errorProviderPayBill.SetError(txtAmountVBR, "The fund balance is insufficient");
                }
                else
                    errorProviderPayBill.SetError(txtAmountVBR, null);
        }
        private void ctrlBillCardWithFilter1_OnBillSelected(int obj)
        {
            if (ctrlBillCardWithFilter1.Bill == null)
                return;
            if(_DailyIncomeFund.TotalIncome<ctrlBillCardWithFilter1.Bill.Cost)
            {
                MessageBox.Show("The fund balance is insufficient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValuesForBill();

                return;
            }
            if (clsGeneralFundBill.isGeneralFundBillExistByBillID(ctrlBillCardWithFilter1.Bill.BillID))
                {
                    MessageBox.Show("This bill cannot be paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValuesForBill();
                return;
                }
            if (ctrlBillCardWithFilter1.Bill.IsPaid)
            {

                MessageBox.Show("This bill has been paid", "Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValuesForBill();
            }
            else
            {
                btnPay.Enabled = true;
                errorProvider1.Clear();
            }

        }
        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            if(ctrlBillCardWithFilter1.Bill==null) return;
            if (_stAmountsPayBill.Total != ctrlBillCardWithFilter1.Bill.Cost)
            {
                e.Cancel = true;
                errorProviderPayBill.SetError(txtCost, "The amount is not equal to " + ctrlBillCardWithFilter1.Bill.Cost);
            }
            else
                errorProviderPayBill.SetError(txtCost, null);
        }
        private void txtFromExpectedProfit_TextChanged(object sender, EventArgs e)
        {
            if (txtFromExpectedProfit.Text != "")
                _stAmountsPayBill.ExpectedProfit = double.Parse(txtFromExpectedProfit.Text);
            txtCost.Text = _stAmountsPayBill.Total.ToString();
        }
        private void txtFromActualProfits_TextChanged(object sender, EventArgs e)
        {
            if (txtFromActualProfits.Text != "")
                _stAmountsPayBill.ActualProfits = double.Parse(txtFromActualProfits.Text);
            txtCost.Text = _stAmountsPayBill.Total.ToString();
        }
        private void txtAmountVBR_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountVBR.Text != "")
                _stAmountsPayBill.AmountVBR = double.Parse(txtAmountVBR.Text);
            txtCost.Text = _stAmountsPayBill.Total.ToString();
        }
    }
}
