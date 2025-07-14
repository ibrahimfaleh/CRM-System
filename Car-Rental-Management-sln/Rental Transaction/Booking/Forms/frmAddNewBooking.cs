using CarRental.Checks;
using CarRental.Classes;
using CarRental.Vehicles;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace CarRental
{
    public partial class frmAddNewBooking : Form
    {
        private bool IsVehicleCheck = false;
        private clsRentalTransaction _RentalTransaction = new clsRentalTransaction();
        private int _CustomerID;
        public frmAddNewBooking()
        {
            InitializeComponent();
        }
        private void _FillPaymentDetailsInComboBox()
        {
            foreach (DataRow row in clsPaymentMethod.GetAllPaymentMethods().Rows)
            {
                cmPayMentDetails.Items.Add(row["PaymentMethod"]);
            }
        }

        private void _FillPaymentDetailsTap()
        {
            lblStartDate.Text = _RentalTransaction.RentalStartDate.ToString("g");
            lblEndDate.Text = _RentalTransaction.RentalEndDate.ToString("g");
            lblInitialRentalDays.Text = _RentalTransaction.InitialRentalDays.ToString();
            lblTax.Text = clsGlobal.Tax.TaxDetails.ToString();
            lblInitialTotalDueAmount.Text = _RentalTransaction.InitialTotalDueAmount.ToString();
            lblInitialTotalDueAmountAfterTax.Text = _RentalTransaction.InitialTotalDueAmountAfterTax.ToString("0.00");
            lblRentalPricePerDay.Text = _RentalTransaction.RentalPricePerDay.ToString();
            lblInitialRentalMonths.Text = _RentalTransaction.InitialRentalMonths.ToString();
            lblRentalPricePerMonth.Text = _RentalTransaction.RentalPricePerMonth.ToString();
        }
        private void _ResetDefaultValues()
        {
            tsMonthly.Checked = false;
            lblStartDate.Text = "???????";
            lblEndDate.Text = "???????";
            lblInitialRentalDays.Text = "???????";
            lblInitialTotalDueAmount.Text = "???????";
            lblTax.Text = "???????";
            lblInitialTotalDueAmount.Text = "???????";
            lblInitialTotalDueAmountAfterTax.Text = "???????";
            lblPickupLocation.Text = "???????";
            lblInitialRentalMonths.Text = "???????";
            lblInitialRentalMonths.Text = "???????";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tapInitialPaymentMethodID.Enabled)
                _FillPaymentDetailsTap();
            btnBack.Visible = true;
            tabShoseVehicle.Enabled = true;
            TabTransAcitonBooking.SelectedIndex++;
            btnNext.Visible = TabTransAcitonBooking.SelectedIndex < TabTransAcitonBooking.TabCount - 1;
        }

        private void LoadBookingInfo()
        {
            _SetRentDetailsToShowTheAmountDue();
            txtNumberOfDaysInMonths.Text = _RentalTransaction.NumberDaysOfCustomMonth.ToString();
            txtInitialTotalDueAmount.Text = _RentalTransaction.InitialTotalDueAmount.ToString();
            txtInitialTotalDueAmountAfterTax.Text = _RentalTransaction.InitialTotalDueAmountAfterTax.ToString("0.00");
            txtInitialRental.Text = _RentalTransaction.InitialRentalDays.ToString();
        }

        private void frmAddNewBooking_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.IsBranchInformationAvailable)
            {
                MessageBox.Show("You must log in to the branch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmAddNewRentalBooking))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlVehicleWithFilter1.ModeFind = ctrlShortDetailsVehicle.enModeFind.FindAvailableAndBranchID;
            _FillPaymentDetailsInComboBox();
            _ResetDefaultValues();
            tabCustomerInfo.Enabled = false;
            tabBookingInfo.Enabled = false;
            tapInitialPaymentMethodID.Enabled = false;
        }

        private void txtValidatePositiveDecimalNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);

        }
        private void txtValidatePositiveNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void ValidateEmptyTextBoxGuna2(object sender, CancelEventArgs e)
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
        private void ComboBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            //ComboBox comboBox = sender as ComboBox;
            //if (string.IsNullOrEmpty(Temp.Text.Trim()))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(Temp, "This field is required!");
            //}
            //else
            //{
            //    errorProvider1.SetError(Temp, null);
            //}
        }
        private void TabBookingInfo_Click(object sender, EventArgs e)
        {

        }

        private void TabCustomerInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            TabTransAcitonBooking.SelectedIndex--;
            btnBack.Visible = TabTransAcitonBooking.SelectedIndex > 0;
            btnNext.Visible = TabTransAcitonBooking.SelectedIndex < TabTransAcitonBooking.TabCount - 1;
        }

        private void btnShoseVehicle_Click(object sender, EventArgs e)
        {
            //SelectedVehicle
        }


        private void tabBookingInfo_Click_1(object sender, EventArgs e)
        {

        }


        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (ctrlVehicleWithFilter1.SelectedVehicle == null)
                return;
            LoadBookingInfo();
        }

        private void DataBackEventCheckID(object sender, int VehicleCheckID)
        {
            _RentalTransaction.VehicleCheckID = VehicleCheckID;
            IsVehicleCheck = true;
            txtCheckID.Text = VehicleCheckID.ToString();
            btnAddInitialCheck.Text = "Update Initial Check";
        }

        private void btnAddInitialCheck_Click(object sender, EventArgs e)
        {
            if (IsVehicleCheck)
            {
                frmVehicleCheck frm = new frmVehicleCheck(_RentalTransaction.VehicleCheckID);
                frm.DataBack += DataBackEventCheckID;
                frm.ShowDialog();
            }
            else
            {
                frmVehicleCheck frm = new frmVehicleCheck(ctrlVehicleWithFilter1.SelectedVehicle.PlateNumber);
                frm.DataBack += DataBackEventCheckID;
                frm.ShowDialog();
            }
        }
        void _SetRentDetailsToShowTheAmountDue()
        {
            if (ctrlVehicleWithFilter1.SelectedVehicle != null)
            {

                _RentalTransaction.Vat = clsGlobal.Tax.Vat;
                _RentalTransaction.RentalPricePerDay = ctrlVehicleWithFilter1.SelectedVehicle.RentalPricePerDay;
                _RentalTransaction.RentalPricePerMonth = ctrlVehicleWithFilter1.SelectedVehicle.RentalPricePerMonth;
                _RentalTransaction.RentalEndDate = dtpEndDate.Value;
                _RentalTransaction.IsMonthly = tsMonthly.Checked;
                if (!clsGlobal.CurrentCarRentalRule.IsSolarMonths)
                    _RentalTransaction.NumberDaysOfCustomMonth = clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom ?? 0;
                else
                    _RentalTransaction.NumberDaysOfCustomMonth = 0;
            }
        }
        void _setRentalBooking()
        {
            _RentalTransaction.VehicleID = ctrlVehicleWithFilter1.SelectedVehicle.VehicleID;
            _RentalTransaction.PickupBranchID = ctrlVehicleWithFilter1.SelectedVehicle.BranchID;
            _RentalTransaction.BookingStatus = (byte)clsRentalBooking.enRentalBookingStatus.New;
            _RentalTransaction.InitialPaymentMethodID = clsPaymentMethod.Find(cmPayMentDetails.Text).PaymentMethodID;
            _RentalTransaction.TransactionDate = DateTime.Now;
            _RentalTransaction.CustomerID = _CustomerID;
            _RentalTransaction.FreeKilometersCredit = short.Parse(txtFreeKilometersCredit.Text);
            _RentalTransaction.PaidInitialTotalDueAmount = double.Parse(txtPaidInitialTotalDueAmount.Text);
            _RentalTransaction.RentalPricePerMileage = ctrlVehicleWithFilter1.SelectedVehicle.RentalPricePerMileage;
            _RentalTransaction.RentalPricePerHours = ctrlVehicleWithFilter1.SelectedVehicle.RentalPricePerHours;
            _RentalTransaction.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            ctrlVehicleWithFilter1.SelectedVehicle.IsAvailableForRental = false;
            _RentalTransaction.BranchID = ctrlVehicleWithFilter1.SelectedVehicle.BranchID;
        }
        void _SaveFinancialTransaction()
        {

            clsDailyIncomeFundTransaction incomeFundTransaction = new clsDailyIncomeFundTransaction();
            clsDailyIncomeFund DailyIncomeFund = clsDailyIncomeFund.GetDailyIncomeFundToDaye((float)clsGlobal.Branch.AmountSpentInfo.Amount, clsGlobal.Branch.CountHoursDailyIncomeFund, clsGlobal.Branch.BranchID);
            incomeFundTransaction.TransactionID = _RentalTransaction.TransactionID;
            incomeFundTransaction.DailyIncomeFundID = DailyIncomeFund.DailyIncomeFundID;
            incomeFundTransaction.Save();
            if (cmPayMentDetails.Text == "Cash")
                DailyIncomeFund.ExpectedCashAmount += _RentalTransaction.PaidInitialTotalDueAmount;
            if (cmPayMentDetails.Text == "Transformation" || cmPayMentDetails.Text == "Mada Pay")
                DailyIncomeFund.ExpectedTransformationAmount += _RentalTransaction.PaidInitialTotalDueAmount;
            DailyIncomeFund.ExpectedProfit += _RentalTransaction.PaidInitialTotalDueAmount;
            DailyIncomeFund.Save();
        }
        void _SaveVehicleCheck()
        {
            clsVehicleCheck clsVehicleCheck = clsVehicleCheck.Find(_RentalTransaction.VehicleCheckID);
            clsVehicleCheck.Status = (byte)clsVehicleCheck.enStatus.FinalCheck;
            clsVehicleCheck.Save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_RentalTransaction.InitialRentalDays < 1 && _RentalTransaction.InitialRentalMonths < 1)
            {
                MessageBox.Show("Initial Days <  1", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _setRentalBooking();
            if (_RentalTransaction.Save())
            {
                _SaveFinancialTransaction();
                _SaveVehicleCheck();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlVehicleWithFilter1.SelectedVehicle.Save();
                TabTransAcitonBooking.Enabled = false;
                ctrlPrintContract1.LoadRentalBookingDetal(_RentalTransaction.TransactionID);
                ctrlPrintContract1.Enabled = true;
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrlCustomerCardWithFilter1_OnCustomerSelected(bool obj)
        {
            btnSave.Visible = obj;
            tapInitialPaymentMethodID.Enabled = obj;
            if (obj)
                _CustomerID = ctrlCustomerCardWithFilter1.SelectedCustomerInfo.CustomerID();
            _FillPaymentDetailsTap();
        }

        private void txtInitialRentalDays_Validating(object sender, CancelEventArgs e)
        {

        }


        private void TabTransAcitonBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNext.Visible = TabTransAcitonBooking.SelectedIndex < TabTransAcitonBooking.TabCount - 1;
            btnBack.Visible = TabTransAcitonBooking.SelectedIndex > 0;
            if (tapInitialPaymentMethodID.Enabled)
                _FillPaymentDetailsTap();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tapInitialPaymentMethodID_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ctrlVehicleWithFilter1.SelectedVehicle == null)
                return;
            if (tsMonthly.Checked)
            {
                gbMonthlyCustomRent.Visible = true;
                dtpEndDate.Enabled = false;
                numericUpDown1_ValueChanged(null, null);
            }
            else
            {

                dtpEndDate.Enabled = true;
                gbMonthlyCustomRent.Visible = false;
                dtpEndDate.MinDate = _RentalTransaction.RentalStartDate.AddDays(1);
                dtpEndDate.Value = _RentalTransaction.RentalStartDate.AddDays(1);
            }
            _RentalTransaction.IsMonthly = tsMonthly.Checked;
            LoadBookingInfo();
        }

        private void label20_Click(object sender, EventArgs e)
        {


        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentCarRentalRule.IsSolarMonths)
                dtpEndDate.Value = DateTime.Now.AddMonths((short)(NUDNumberOfMonths.Value));
            else
                dtpEndDate.Value = DateTime.Now.AddDays((short)(NUDNumberOfMonths.Value * clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom));
        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void txtInitialTotalDueAmountAfterTax_TextChanged(object sender, EventArgs e)
        {
        }

        private void ctrlVehicleWithFilter1_OnVehicleSelected(int obj)
        {
            if (obj < 1)
                return;
            clsVehicleCheck clsVehicleCheck = clsVehicleCheck.FindByVehicleIDAndStatus(ctrlVehicleWithFilter1.SelectedVehicle.VehicleID, (byte)clsVehicleCheck.enStatus.InitialCheck);
            if (clsVehicleCheck == null)
                IsVehicleCheck = false;
            else
            {
                IsVehicleCheck = true;
                _RentalTransaction.VehicleCheckID = clsVehicleCheck.VehicleCheckID;
            }
            tabBookingInfo.Enabled = true;
            tabCustomerInfo.Enabled = true;
            btnNext.Visible = true;
            txtRentalPricePerDay.Text = ctrlVehicleWithFilter1.SelectedVehicle.RentalPricePerDay.ToString();
            txtPricePerMonth.Text = ctrlVehicleWithFilter1.SelectedVehicle.RentalPricePerMonth.ToString();
            btnAddInitialCheck.Text = "Add New Initial Check";
            _ResetDefaultValues();

            LoadBookingInfo();
            lblPickupLocation.Text = clsBranch.Find(ctrlVehicleWithFilter1.SelectedVehicle.BranchID).StreetName;
        }

        private void txtInitialRental_TextChanged(object sender, EventArgs e)
        {
            if (txtInitialRental.Text != "" && !tsMonthly.Checked)
                LoadBookingInfo();
        }
        private void txtPaidInitialTotalDueAmount_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBoxGuna2(sender, e);
            if (txtPaidInitialTotalDueAmount.Text != "")
            {
                _RentalTransaction.PaidInitialTotalDueAmount = double.Parse(txtPaidInitialTotalDueAmount.Text);
                if (tsMonthly.Checked)
                {
                    if (_RentalTransaction.PaidInitialTotalDueAmount < (_RentalTransaction.InitialTotalDueAmountAfterTax / (100.0 / clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalMonthlyRent)))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtPaidInitialTotalDueAmount, "The amount must not be less than " + (_RentalTransaction.InitialTotalDueAmountAfterTax / (100.0 / clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalMonthlyRent)).ToString("0.00"));
                        return;
                    }
                    else
                        errorProvider1.SetError(txtPaidInitialTotalDueAmount, null);
                }
                else if (_RentalTransaction.PaidInitialTotalDueAmount < (_RentalTransaction.InitialTotalDueAmountAfterTax / (100.0 / clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalDailyRent)))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPaidInitialTotalDueAmount, "The amount must not be less than " + (_RentalTransaction.InitialTotalDueAmountAfterTax / (100.0 / clsGlobal.CurrentCarRentalRule.DownPaymentPercentageOfTotalDailyRent)).ToString("0.00"));
                    return;
                }
                else
                    errorProvider1.SetError(txtPaidInitialTotalDueAmount, null);
                if (_RentalTransaction.PaidInitialTotalDueAmount > _RentalTransaction.InitialTotalDueAmountAfterTax)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPaidInitialTotalDueAmount, "The entered amount is greater than the required amount.");
                }
                else
                    errorProvider1.SetError(txtPaidInitialTotalDueAmount, null);
            }
        }

        private void txtFreeKilometersCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);

        }
    }
}
