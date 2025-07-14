using CarRental.Checks;
using CarRental.Classes;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.Vehicles
{
    public partial class frmVehiclesReturn : Form
    {
        private int? _RentalTransactionID;
        private byte _TotalRentalMonths;
        private short _TotalRentalDays;

        public frmVehiclesReturn()
        {
            InitializeComponent();
        }
        public frmVehiclesReturn(int RentalTransActionID)
        {
            InitializeComponent();
            _RentalTransactionID = RentalTransActionID;
        }
        private void _ResetDefalutValues()
        {
            ctrlRentalTransactionWithFilter1.VehicleEditedVisible = false;
            txtActualRentalDays.Text = "";
            txtActualRentalMonths.Text = "";
            txtActualReturnDate.Text = "";
            txtAdditionalCharges.Text = "";
            txtAdditionalhours.Text = "";
            txtAdditionalkilometer.Text = "";
            txtNewMileage.Text = "";
            txtTotalRemaining.Text = "";
            txtConsumedMileage.Text = "";
            txtAdditionalkilometerCharges.Text = "";
            txtTotalHourlyCharge.Text = "";
            lblActualTotalDueAmount.Text = "0";
            lblPaidInitialTotalDueAmount.Text = "0";
            lblTotalRefundedAmount.Text = "0";
            lblTotalRemaining.Text = "0";
        }
        private void _FinalCalculation()
        {

            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualTotalDueAmount = ((ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalDays * ctrlRentalTransactionWithFilter1.RentalTransaction.RentalPricePerDay * ctrlRentalTransactionWithFilter1.RentalTransaction.Vat) + ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalCharges +
                (ctrlRentalTransactionWithFilter1.RentalTransaction.RentalPricePerMonth * (ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalMonths * clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom)) + ctrlRentalTransactionWithFilter1.RentalTransaction.AdditionalKilometerCharges + ctrlRentalTransactionWithFilter1.RentalTransaction.TotalHourlyCharge ?? 0);

            ctrlRentalTransactionWithFilter1.RentalTransaction.ActualTotalDueAmount = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualTotalDueAmount;
            ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining = (ctrlRentalTransactionWithFilter1.RentalTransaction.ActualTotalDueAmount - ctrlRentalTransactionWithFilter1.RentalTransaction.PaidInitialTotalDueAmount);
            txtTotalRemaining.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining?.ToString("0.00");
            lblActualTotalDueAmount.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.ActualTotalDueAmount?.ToString("0.00");
            lblPaidInitialTotalDueAmount.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.PaidInitialTotalDueAmount.ToString("0.00");
            lblTotalRemaining.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining?.ToString("0.00");
            if (ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining < 0)
                lblTotalRefundedAmount.Text = (ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRefundedAmount = (ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining * -1))?.ToString("0.00");
            else
                lblTotalRefundedAmount.Text = (ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRefundedAmount = 0)?.ToString("0.00");

            cmbPayMentDetails.Enabled = (ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining >= 0);
        }
        private void _LoadData()
        {

            ctrlRentalTransactionWithFilter1.LoadRentalTransaction(_RentalTransactionID.Value);
            ctrlRentalTransactionWithFilter1.VehicleEditedVisible = false;
            ctrlRentalTransactionWithFilter1.FilterEnabled = false;
            _FillVehicleReturn();
            _FinalCalculation();
        }
        private void _FillVehicleReturn()
        {
            DateTime Temp = DateTime.Now;
            Temp = Temp.AddHours(-Temp.Hour);
            Temp = Temp.AddHours(ctrlRentalTransactionWithFilter1.RentalTransaction.RentalStartDate.Hour);
            Temp = Temp.AddDays(-1);
            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualReturnDate = DateTime.Now;
            if (ctrlRentalTransactionWithFilter1.RentalTransaction.IsMonthly)
            {
                if (clsGlobal.CurrentCarRentalRule.IsSolarMonths && (ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalMonths = (byte)(DateTime.Now.Month - ctrlRentalTransactionWithFilter1.RentalTransaction.RentalStartDate.Month)) > 0)
                    ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalDays = (short)(byte)((DateTime.Now.AddDays(-ctrlRentalTransactionWithFilter1.RentalTransaction.RentalStartDate.Day).Day));
                _TotalRentalDays = (short)(DateTime.Now - ctrlRentalTransactionWithFilter1.RentalTransaction.RentalStartDate).TotalDays;
                if (!clsGlobal.CurrentCarRentalRule.IsSolarMonths && _TotalRentalDays >= clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom)
                {
                    ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalMonths = (byte)(_TotalRentalDays / clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom);
                    ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalDays = (short)(_TotalRentalDays % clsGlobal.CurrentCarRentalRule.NumberOfDaysInMonthCustom);
                }
                else
                    ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalDays = (short)(DateTime.Now - ctrlRentalTransactionWithFilter1.RentalTransaction.RentalStartDate).TotalDays;


            }
            else
                ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalDays = (short)(DateTime.Now - ctrlRentalTransactionWithFilter1.RentalTransaction.RentalStartDate).TotalDays;
            txtActualRentalDays.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalDays.ToString();
            txtActualReturnDate.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualReturnDate.ToString("g");
            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalHours = (byte)(DateTime.Now - Temp).Hours;
            txtActualRentalMonths.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ActualRentalMonths.ToString();
            txtAdditionalhours.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalHours.ToString();
            txtTotalHourlyCharge.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.TotalHourlyCharge.ToString();
        }
        private void frmVehiclesReturn_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmVehicleReturn))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _ResetDefalutValues();
            if (_RentalTransactionID.HasValue)
            {

                if (!clsGlobal.IsBranchInformationAvailable)
                {
                    MessageBox.Show("The branch cannot be identified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                _LoadData();
                if ((!clsBranch.Find(ctrlRentalTransactionWithFilter1.RentalTransaction.BranchID).IsPublic) && ctrlRentalTransactionWithFilter1.RentalTransaction.BranchID != clsGlobal.Branch.BranchID)
                {
                    MessageBox.Show("he vehicle cannot be returned at this branch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                if (ctrlRentalTransactionWithFilter1.RentalTransaction.BookingStatus == (byte)clsRentalBooking.enRentalBookingStatus.Completed)
                {
                    btnReturn.Enabled = false;
                }
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewMileage_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMileage.Text != "")
            {
                ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.Mileage = int.Parse(txtNewMileage.Text);
                ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ConsumedMileage = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.Mileage - ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleInfo.Mileage;
                if (ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ConsumedMileage > ctrlRentalTransactionWithFilter1.RentalTransaction.FreeKilometersCredit)
                    ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalKilometer = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ConsumedMileage - ctrlRentalTransactionWithFilter1.RentalTransaction.FreeKilometersCredit;
                else
                    ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalKilometer = 0;

                txtAdditionalkilometerCharges.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.AdditionalKilometerCharges.ToString();
                txtConsumedMileage.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ConsumedMileage.ToString();
                txtAdditionalkilometer.Text = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalKilometer.ToString();
                _FinalCalculation();

            }
            else txtConsumedMileage.Text = "";
        }

        private void DataBackCost(object sender, double TotalCost)
        {
            btnAddUpdateFinallyCheck.Text = "Update Initial Check";
            txtAdditionalCharges.Text = TotalCost.ToString();
            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalCharges = TotalCost;
            _FinalCalculation();

        }
        private void btnAddUpdateFinallyCheck_Click(object sender, EventArgs e)
        {

            frmVehicleCheck frm = new frmVehicleCheck(ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleCheckID);
            frm.DataBackCost += DataBackCost;
            frm.ShowDialog();
        }

        private void txtValidatePositiveNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);

        }
        private void ComboBoxEmpty_Validating(object sender, CancelEventArgs e)
        {

            ComboBox Temp = (ComboBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void ValidateEmptyTextBoxGuna2(object sender, CancelEventArgs e)
        {

            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else if (int.Parse(Temp.Text) < ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleInfo.Mileage)
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "Mileage is lower than expected!");
            }
            else
                errorProvider1.SetError(Temp, null);


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (ctrlRentalTransactionWithFilter1.RentalTransaction.BookingStatus == (byte)clsRentalBooking.enRentalBookingStatus.Completed)
            {
                MessageBox.Show("The application has already been completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Are You Sure Of All the Data? , You cannot edit after saving ", "Vehicle Return ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlRentalTransactionWithFilter1.RentalTransaction.DropOffBranchID = clsGlobal.Branch.BranchID;
            ctrlRentalTransactionWithFilter1.RentalTransaction.UpdatedTransactionDate = DateTime.Now;
            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleInfo.IsAvailableForRental = true;
            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleInfo.Mileage = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.Mileage;
            ctrlRentalTransactionWithFilter1.RentalTransaction.BookingStatus = (Byte)clsRentalBooking.enRentalBookingStatus.Completed;
            ctrlRentalTransactionWithFilter1.RentalTransaction.FinalPaymentMethodID = null;
            ctrlRentalTransactionWithFilter1.RentalTransaction.UpdateByUserID = clsGlobal.CurrentUser.UserID;
            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleCheckInfo.Status = (byte)clsVehicleCheck.enStatus.Completed;
            ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleInfo.BranchID = clsGlobal.Branch.BranchID;
            if (ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.Save())
                if (ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleInfo.Save())
                    if ((ctrlRentalTransactionWithFilter1.RentalTransaction.ReturnID = ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.ReturnID) > -1 && ctrlRentalTransactionWithFilter1.RentalTransaction.Save())
                    {
                        ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleCheckInfo.Save();
                        clsDailyIncomeFundTransaction incomeFundTransaction = new clsDailyIncomeFundTransaction();
                        clsDailyIncomeFund DailyIncomeFund = clsDailyIncomeFund.GetDailyIncomeFundToDaye((float)clsGlobal.Branch.AmountSpentInfo.Amount, clsGlobal.Branch.CountHoursDailyIncomeFund, clsGlobal.Branch.BranchID);
                        incomeFundTransaction.TransactionID = ctrlRentalTransactionWithFilter1.RentalTransaction.TransactionID;
                        incomeFundTransaction.DailyIncomeFundID = DailyIncomeFund.DailyIncomeFundID;
                        incomeFundTransaction.Save();
                        if (ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining > 0)
                        {
                            ctrlRentalTransactionWithFilter1.RentalTransaction.FinalPaymentMethodID = clsPaymentMethod.Find(cmbPayMentDetails.Text).PaymentMethodID;
                            if (cmbPayMentDetails.Text.ToLower() == "cash")
                                DailyIncomeFund.ExpectedCashAmount += ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining.Value;
                            if (cmbPayMentDetails.Text.ToLower() == "mada pay")
                                DailyIncomeFund.ExpectedTransformationAmount += ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining.Value;

                        }
                        else
                        {
                            DailyIncomeFund.ExpectedCashAmount += ctrlRentalTransactionWithFilter1.RentalTransaction.TotalRemaining.Value;

                        }
                        DailyIncomeFund.ExpectedProfit += (0 - ctrlRentalTransactionWithFilter1.RentalTransaction.PaidInitialTotalDueAmount);
                        DailyIncomeFund.ActualProfits += (ctrlRentalTransactionWithFilter1.RentalTransaction.ActualTotalDueAmount.Value - ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalCharges);
                        DailyIncomeFund.VehicleBreakdownRevenues += ctrlRentalTransactionWithFilter1.RentalTransaction.VehicleReturnInfo.AdditionalCharges;
                        DailyIncomeFund.Save();
                        MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewMileage.ReadOnly = true;
                    }
                    else
                        MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cmbBayMentDetails_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPayMentDetails.Enabled)
            {
                ComboBox Temp = (ComboBox)sender;
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

        }


        private void txtCheckID_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else

                errorProvider1.SetError(Temp, null);

        }

        private void txtAdditionalCharges_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdditionalCharges.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAdditionalCharges, "This field is required");
            }
            else
                errorProvider1.SetError(txtAdditionalCharges, null);

        }

        private void ctrlRentalTransactionWithFilter1_OnRentalTransactionSelected(bool obj)
        {
            _ResetDefalutValues();

            if (obj)
            {
                if (!clsGlobal.IsBranchInformationAvailable)
                {
                    MessageBox.Show("The branch cannot be identified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                if (clsGlobal.Branch.BranchID != ctrlRentalTransactionWithFilter1.RentalTransaction.BranchID)
                    if (!clsGlobal.Branch.IsPublic||!clsBranch.Find(ctrlRentalTransactionWithFilter1.RentalTransaction.BranchID).IsPublic) 
                {
                    MessageBox.Show("he vehicle cannot be returned at this branch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlRentalTransactionWithFilter1.ResetDefalutValues();
                    return;
                }
                if (ctrlRentalTransactionWithFilter1.RentalTransaction.BookingStatus == (byte)clsRentalBooking.enRentalBookingStatus.Completed)
                {
                    btnReturn.Enabled = false;
                }
                _FillVehicleReturn();
                _FinalCalculation();
            }

        }
    }
}
