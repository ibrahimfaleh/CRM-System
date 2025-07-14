using CarRental.Classes;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.Rental_Fund.General_Revenue_Fund
{
    public partial class frmAddUpdateAmountSpent : Form
    {
        public delegate void DataBackEventHandler(object sender, int AmountSpentID, bool IsSave, double TotalAMount);
        public event DataBackEventHandler DataBack;
        private int _AmountSpentID;
        private clsAmountSpent _AmountSpent;
        private clsGeneralRevenueFund _GeneralRevenueFund;
        private double _FromVehicleBreakdownRevenues;
        private double _FromAnotherIncome;
        private double _FromActualProfits;
        private double _FromExpectedProfit;
        private double _FromVehicleSales;
        private double? _NotMoreThan;
        private bool _ObligatedToPayFullAmount;
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;

        public frmAddUpdateAmountSpent(int AmountSpentID)
        {
            InitializeComponent();
            _AmountSpentID = AmountSpentID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateAmountSpent( double? notMoreThan, bool obligatedToPayFullAmount)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _NotMoreThan = notMoreThan;
            _ObligatedToPayFullAmount = obligatedToPayFullAmount;
        }
        private void _RestDefaultValue()
        {
            _AmountSpent = new clsAmountSpent();
            _AmountSpent.ObligatedToPayFullAmount = _ObligatedToPayFullAmount;
            _AmountSpent.NotMoreThan = _NotMoreThan;    
            txtAmount.Text = "0";
            txtwithdrawalsDetails.Text = "";
            lbltitleTransaction.Text = "Add New";
            txtAmountVBR.Text = "";
            txtFromActualProfits.Text = "";
            txtFromAnotherIncome.Text = "";
            txtFromExpectedProfit.Text = "";
            txtFromVehicleSales.Text = "";
            lblNotMoreThan.Visible = false;
            lblTitleNotMoreThan.Visible=false;
            if(_NotMoreThan.HasValue) 
            {
                lblNotMoreThan.Visible = true;
                lblTitleNotMoreThan.Visible = true;
                lblNotMoreThan.Text= _AmountSpent.NotMoreThan.ToString();
            }

            if(!clsGlobal.IsGeneralFundAvailable)
            {
                btnSave.Enabled = false;
                MessageBox.Show("General fund not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(clsGlobal.GeneralRevenueFundID);
        }
        private void _UpdateAmountSpent()
        {

            if (_AmountSpent == null) return;
            if (_AmountSpent.PaymentDetails == clsAmountSpent.enPaymentDetails.Cash)
            {
                _GeneralRevenueFund.Cash += _AmountSpent.Amount;
            }
            else
            {
                _GeneralRevenueFund.Bank += _AmountSpent.Amount;

            }
            _GeneralRevenueFund.VehicleBreakdownRevenues += _AmountSpent.FromVehicleBreakdownRevenues;
            _GeneralRevenueFund.ActualProfits += _AmountSpent.FromActualProfits;
            _GeneralRevenueFund.ExpectedProfit += _AmountSpent.FromExpectedProfit;
            _GeneralRevenueFund.AnotherIncome += _AmountSpent.FromAnotherIncome;
            _GeneralRevenueFund.VehicleSales += _AmountSpent.FromVehicleSales;
            _AmountSpent.Amount = double.Parse(txtAmount.Text);
            if (cmbPayment.Text == "Cash")
                _AmountSpent.PaymentDetails = clsAmountSpent.enPaymentDetails.Cash;
            else
                _AmountSpent.PaymentDetails = clsAmountSpent.enPaymentDetails.Transformation;
            _AmountSpent.Details = txtwithdrawalsDetails.Text;
            _AmountSpent.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
            _AmountSpent.UpdateDate = DateTime.Now;
            _AmountSpent.FromVehicleBreakdownRevenues = _FromVehicleBreakdownRevenues;
            _AmountSpent.FromAnotherIncome = _FromAnotherIncome;
            _AmountSpent.FromActualProfits = _FromActualProfits;
            _AmountSpent.FromExpectedProfit = _FromExpectedProfit;
            _AmountSpent.FromVehicleSales= _FromVehicleSales;

            _GeneralRevenueFund.VehicleBreakdownRevenues -= _FromVehicleBreakdownRevenues;
            _GeneralRevenueFund.ActualProfits -= _FromActualProfits;
            _GeneralRevenueFund.ExpectedProfit -= _FromExpectedProfit;
            _GeneralRevenueFund.AnotherIncome -= _FromAnotherIncome;
            _GeneralRevenueFund.VehicleSales -= _FromVehicleSales;
            if ((cmbPayment.Text == "Cash" && _GeneralRevenueFund.Cash < _AmountSpent.Amount) || (cmbPayment.Text == "Transformation" && _GeneralRevenueFund.Bank < _AmountSpent.Amount))
            {
                if (MessageBox.Show("Do you want to deposit money in the bank?", "The bank balance is insufficient", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmManagingGeneralFund generalFund = new frmManagingGeneralFund(_AmountSpent.GeneralRevenueFundID);
                    generalFund.ShowDialog();
                }
                return;
            }
            if (_AmountSpent.PaymentDetails == clsAmountSpent.enPaymentDetails.Cash)
            {
                _GeneralRevenueFund.Cash -= _AmountSpent.Amount;
            }
            else
            {
                _GeneralRevenueFund.Bank -= _AmountSpent.Amount;

            }

            if (_AmountSpent.Save() && _GeneralRevenueFund.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAddUpdateAmountSpent_Load(null, null);
                DataBack?.Invoke(this, _AmountSpent.AmountSpentID, true, _AmountSpent.Amount);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void _LoadData()
        {
            if ((_AmountSpent = clsAmountSpent.Find(_AmountSpentID)) == null)
            {
                MessageBox.Show("Error loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblPreviousAmount.Text = _AmountSpent.Amount.ToString();
            txtwithdrawalsDetails.Text = _AmountSpent.Details;
            txtAmount.Text = _AmountSpent.Amount.ToString();

            txtFromActualProfits.Text = _AmountSpent.FromActualProfits.ToString();
            txtFromExpectedProfit.Text = _AmountSpent.FromExpectedProfit.ToString();
            txtFromAnotherIncome.Text = _AmountSpent.FromAnotherIncome.ToString();
            txtFromVehicleSales.Text=_AmountSpent.FromVehicleSales.ToString();
            txtAmountVBR.Text=_AmountSpent.FromVehicleBreakdownRevenues.ToString();
            if (_NotMoreThan.HasValue)
            {
                lblNotMoreThan.Visible = true;
                lblTitleNotMoreThan.Visible = true;
                lblNotMoreThan.Text = _AmountSpent.NotMoreThan.ToString();
            }
            if (_AmountSpent.PaymentDetails == clsAmountSpent.enPaymentDetails.Cash)
                cmbPayment.Text = "Cash";
            else
                cmbPayment.Text = "Transformation";
            txtAmountVBR.Text = _AmountSpent.FromVehicleBreakdownRevenues.ToString();
            lbltitleTransaction.Text = "Update";
            _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateAmountSpent_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmUpdateAmountSpent))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _RestDefaultValue();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private bool _IsAmountsAvailable(ref string ErrorMessage)
        {
            if (_FromAnotherIncome > (_GeneralRevenueFund.AnotherIncome + _AmountSpent.FromAnotherIncome))
            {
                ErrorMessage = "The balance of other income is insufficient.";
                return false;

            }
            if (_FromVehicleBreakdownRevenues > (_GeneralRevenueFund.VehicleBreakdownRevenues + _AmountSpent.FromVehicleBreakdownRevenues))
            {
                ErrorMessage = "The vehicle breakdown credit is insufficient.";
                return false;
            }

            if (_FromExpectedProfit > (_GeneralRevenueFund.ExpectedProfit + _AmountSpent.FromExpectedProfit))
            {
                ErrorMessage = "The vehicle Expected Profit credit is insufficient.";
                return false;
            }

            if (_FromActualProfits > (_GeneralRevenueFund.ActualProfits + _AmountSpent.FromActualProfits))
            {
                ErrorMessage = "The vehicle Actual Profits credit is insufficient.";
                return false;
            }
            if (_FromVehicleSales > (_GeneralRevenueFund.VehicleSales + _AmountSpent.FromVehicleSales))
            {
                ErrorMessage = "The vehicle Actual Profits credit is insufficient.";
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _GeneralRevenueFund = clsGeneralRevenueFund.Find(clsGlobal.GeneralRevenueFundID);
            string ErrorMessage = "";
            if (!_IsAmountsAvailable(ref ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "not available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Update)
            {
                _UpdateAmountSpent();
                return;
            }

            if (cmbPayment.Text == "Cash")
                _AmountSpent.PaymentDetails = clsAmountSpent.enPaymentDetails.Cash;
            _AmountSpent.Amount = double.Parse(txtAmount.Text);
            if ((cmbPayment.Text == "Cash" && _GeneralRevenueFund.Cash < _AmountSpent.Amount) || (cmbPayment.Text == "Transformation" && _GeneralRevenueFund.Bank < _AmountSpent.Amount))
            {
                if (MessageBox.Show("Do you want to deposit money in the bank?", "The bank balance is insufficient", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmManagingGeneralFund managingGeneralFund = new frmManagingGeneralFund(clsGlobal.GeneralRevenueFundID);
                    managingGeneralFund.ShowDialog();
                    ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(clsGlobal.GeneralRevenueFundID);
                }
                return;
            }
            _AmountSpent.Details = txtwithdrawalsDetails.Text;
            _AmountSpent.Date = DateTime.Now;
            _AmountSpent.GeneralRevenueFundID = clsGlobal.GeneralRevenueFundID;
            _AmountSpent.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _AmountSpent.FromVehicleBreakdownRevenues = _FromVehicleBreakdownRevenues;
            _AmountSpent.FromActualProfits = _FromActualProfits;
            _AmountSpent.FromExpectedProfit = _FromExpectedProfit;
            _AmountSpent.FromAnotherIncome = _FromAnotherIncome;
            _AmountSpent.FromVehicleSales = _FromVehicleSales;  

            _GeneralRevenueFund.VehicleBreakdownRevenues -= _FromVehicleBreakdownRevenues;
            _GeneralRevenueFund.ActualProfits -= _FromActualProfits;
            _GeneralRevenueFund.ExpectedProfit -= _FromExpectedProfit;
            _GeneralRevenueFund.AnotherIncome -= _FromAnotherIncome;
            _GeneralRevenueFund.VehicleSales -= _FromVehicleSales;  
            if (_AmountSpent.Save())
            {
                if (_AmountSpent.PaymentDetails == clsAmountSpent.enPaymentDetails.Cash)
                {
                    _GeneralRevenueFund.Cash -= _AmountSpent.Amount;
                }
                else
                {
                    _GeneralRevenueFund.Bank -= _AmountSpent.Amount;

                }
                _GeneralRevenueFund.Save();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _AmountSpentID = _AmountSpent.AmountSpentID;
                DataBack?.Invoke(this, _AmountSpent.AmountSpentID, true, _AmountSpent.Amount);
                frmAddUpdateAmountSpent_Load(null, null);
            }

            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void validatingNumber(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (Temp.Text == "")
                return;
            if (Temp.Text[Temp.Text.Length - 1] == '.')
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "The number is invalid!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
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

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void lbltitleTransaction_Click(object sender, EventArgs e)
        {

        }

        private void txtFromAnotherIncome_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
            validatingNumber(sender, e);
            if(_AmountSpent.ObligatedToPayFullAmount)
            {
                if(_AmountSpent.NotMoreThan.HasValue)
                {
                    if (double.Parse(txtAmount.Text)!=_AmountSpent.NotMoreThan)
                    {
                        e.Cancel=true;
                        errorProvider1.SetError(txtAmount, "The amount must be equal to "+ _AmountSpent.NotMoreThan);
                    }else
                        errorProvider1.SetError(txtAmount, null);
                }
            }
            if (_AmountSpent.NotMoreThan.HasValue&&!_AmountSpent.ObligatedToPayFullAmount)
            {
                if (double.Parse(txtAmount.Text) > _AmountSpent.NotMoreThan)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtAmount, "The amount must be less than  " + _AmountSpent.NotMoreThan);
                }
                else
                    errorProvider1.SetError(txtAmount, null);
            }
        }
        private void _TotalAmount()
        {

            txtAmount.Text = (_FromExpectedProfit + _FromAnotherIncome + _FromVehicleBreakdownRevenues + _FromActualProfits+_FromVehicleSales).ToString();

        }
        private void txtFromExpectedProfit_TextChanged(object sender, EventArgs e)
        {
            if (txtFromExpectedProfit.Text != "")
                _FromExpectedProfit = double.Parse(txtFromExpectedProfit.Text);
            else
                _FromExpectedProfit = 0;
            _TotalAmount();
        }

        private void txtFromActualProfits_TextChanged(object sender, EventArgs e)
        {
            if (txtFromActualProfits.Text != "")
                _FromActualProfits = double.Parse(txtFromActualProfits.Text);
            else
                _FromActualProfits = 0;
            _TotalAmount();
        }

        private void txtAmountVBR_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountVBR.Text != "")
                _FromVehicleBreakdownRevenues = double.Parse(txtAmountVBR.Text);
            else
                _FromVehicleBreakdownRevenues = 0;
            _TotalAmount();
        }

        private void txtFromAnotherIncome_TextChanged(object sender, EventArgs e)
        {
            if (txtFromAnotherIncome.Text != "")
                _FromAnotherIncome = double.Parse(txtFromAnotherIncome.Text);
            else
                _FromAnotherIncome = 0;
            _TotalAmount();
        }

        private void txtFromVehicleSales_Validating(object sender, CancelEventArgs e)
        {
            validatingNumber(sender, e);
            ValidateEmptyTextBox(sender, e);
        }

        private void txtFromVehicleSales_TextChanged(object sender, EventArgs e)
        {
            if (txtFromVehicleSales.Text != "")
                _FromVehicleSales = double.Parse(txtFromVehicleSales.Text);
            else
                _FromAnotherIncome = 0;
            _TotalAmount();
        }
    }
}
