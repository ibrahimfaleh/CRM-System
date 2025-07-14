using CarRental.Classes;
using CarRental.Users;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddUpdateContract : Form
    {
        public delegate void DataBackEventHandler(object sender, int ContractID);
        public event DataBackEventHandler DataBackContractID;
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _ContractID;
        private clsContract _Contract;
        public frmAddUpdateContract()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateContract(int ContractID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ContractID = ContractID;
        }
        private void _LoadComboBox()
        {
            cmbTypeContract.Items.Clear();
            foreach (DataRow row in clsTypesContract.GetAllTypesContracts().Rows)
            {
                cmbTypeContract.Items.Add(row["Type"].ToString());
            }
        }
        private void _ResetDefaultValues()
        {
            _Contract = new clsContract();
            lblPaymenStatus.Text = "";
            lblNumberOfMonths.Text = "0";
            lblNumberOfYears.Text = "0";
            lblTotalAmountPaid.Text = "0";
            txtContractAmount.Text = "";
            txtFinalPayment.Text = "";
            txtInitialPayment.Text = "";
            lblTitle.Text = "Add Contract";
            nudNumberOfMonthsOfFinalPaymentInstallments.Value = 0;
            nudPaymentEveryMonths.Value = 0;
            nudPaymentEveryYears.Value = 0;
            cbAllowingFinalpaymentInstallments.Checked = false;
            dtpEndContract.Value = DateTime.Now.AddMonths(1);
            _LoadComboBox();
            cmbTypeContract.SelectedIndex = 0;
            cmbMethodPayment.SelectedIndex = 0;

            llContractID.Visible = false;
            llCreatedByUserID.Visible = false;
            llUpdatedByUserID.Visible = false;
            lblCreatedDate.Visible = false;
            lblUpdatedDate.Visible = false;

            lblTitleCreatedByUserId.Visible = false;
            lblTitleUpdatebyUserId.Visible = false;
            lblTitleCreatedDate.Visible = false;
            lblTitleUpdatedDate.Visible = false;
            lblTitleContractID.Visible = false;

            if (clsGlobal.IsBranchInformationAvailable)
            {
                btnSelectBranchID.Enabled = false;
                _Contract.BranchID = clsGlobal.Branch.BranchID;
            }
            else
            {
                btnSelectBranchID.Enabled = true;
            }
        }
        private void _LoadData()
        {
            _Contract = clsContract.Find(_ContractID);
            if (_Contract != null)
            {
                if (clsGlobal.IsBranchInformationAvailable)
                {
                    if (clsGlobal.Branch.BranchID != _Contract.BranchID)
                    {
                        MessageBox.Show("The contract cannot be modified and the branch cannot be recognized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    btnSelectBranchID.Enabled = false;
                }
                else
                    btnSelectBranchID.Enabled = true;
                if (_Contract.PaymentStatus == (byte)clsContract.enPaymentStatus.Full)
                    btnSelectBranchID.Enabled = false;

                txttBranchID.Text = _Contract.BranchID.ToString();
                lblTitleContractID.Visible = true;
                llContractID.Visible = true;
                llContractID.Text = _Contract.ContractID.ToString();

                llCreatedByUserID.Visible = true;
                lblTitleCreatedByUserId.Visible = true;
                llCreatedByUserID.Text = _Contract.CreatedByUserID.ToString();

                lblTitleCreatedDate.Visible = true;
                lblCreatedDate.Visible = true;
                lblCreatedDate.Text = _Contract.CreatedDate.ToString("d");
                if (_Contract.UpdatedDate != null)
                {
                    lblUpdatedDate.Text = _Contract.UpdatedDate?.ToString("d");
                    llUpdatedByUserID.Text = _Contract.UpdatedByUserID.ToString();
                    lblUpdatedDate.Visible = true;
                    lblTitleUpdatedDate.Visible = true;
                    llUpdatedByUserID.Visible = true;
                    lblTitleUpdatebyUserId.Visible = true;
                }
                lblTitle.Text = "Update Contract";
                lblPaymenStatus.Text = _Contract.GetPaymentStatus;
                lblTotalAmountPaid.Text = _Contract.TotalAmountPaid.ToString();
                _LoadComboBox();
                dtpStartContract.Value = _Contract.StartContract;
                dtpEndContract.Value = _Contract.EndContract;
                txtContractAmount.Text = _Contract.ContractAmount.ToString();
                txtInitialPayment.Text = _Contract.InitialPayment.ToString();
                txtFinalPayment.Text = _Contract.FinalPayment.ToString();
                clsContractPaymentSchedulingApplication app = clsContractPaymentSchedulingApplication.FindByContractID(_Contract.ContractID);
                if(app != null) 
                {
                    txtInitialPayment.Enabled = !(_Contract.InitialPayment==_Contract.InitialAmountPaid);
                    txtFinalPayment.Enabled = !(_Contract.FinalAmountPaid == _Contract.FinalPayment);
                }
                nudNumberOfMonthsOfFinalPaymentInstallments.Value = (int)_Contract.NumberOfMonthsOfFinalPaymentInstallments;
                nudPaymentEveryMonths.Value = (int)_Contract.PaymentEveryMonths;
                nudPaymentEveryYears.Value = (int)_Contract.PaymentEveryYears;
                cbAllowingFinalpaymentInstallments.Enabled = txtFinalPayment.Enabled;
                nudNumberOfMonthsOfFinalPaymentInstallments.Enabled = cbAllowingFinalpaymentInstallments.Enabled;
                cbAllowingFinalpaymentInstallments.Checked = _Contract.AllowingFinalPaymentInstallments;
                cmbTypeContract.Text = clsTypesContract.Find(_Contract.TypeID).Type;
                if (_Contract.PaymentType == (byte)clsContract.enPaymentType.Partial)
                    cmbMethodPayment.Text = "Partial";
                if (_Contract.PaymentType == (byte)clsContract.enPaymentType.OnePaymentLater)
                    cmbMethodPayment.Text = "One Payment Later";
                if (_Contract.PaymentType == (byte)clsContract.enPaymentType.Full)
                    cmbMethodPayment.Text = "Full";
                if (_Contract.DeferredPaymentDueDate != null)
                    dtpDeferredPaymentDueDate.Value = _Contract.DeferredPaymentDueDate ?? dtpDeferredPaymentDueDate.Value;
                if (clsGlobal.IsBranchInformationAvailable)
                {
                    btnSelectBranchID.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Error loading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void rbContractInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void ValidateEmptyComboBox(object sender, CancelEventArgs e)
        {
            Guna2ComboBox Temp = (Guna2ComboBox)sender;
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

        private void txtContractAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void txtContractAmount_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
            validatingNumber(sender, e);
            if (txtContractAmount.Text != "")
                if (txtContractAmount.Text[txtContractAmount.Text.Length - 1] != '.')
                    _Contract.ContractAmount = double.Parse(txtContractAmount.Text);
            if (_Contract.ContractAmount < _Contract.TotalAmountPaid)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContractAmount, "The contract value cannot be less than the total amount paid");
            }
            else
            {
                errorProvider1.SetError(txtContractAmount, null);
            }
        }
        private bool _IsInitialAndFinalPaymentLessOrEqualContractAmount()
        {
            return ( _Contract.FinalPayment + _Contract.InitialPayment<= _Contract.ContractAmount);
        }
        private void txtInitialPayment_Validating(object sender, CancelEventArgs e)
        {
            if (gbContractInfo.Enabled)
                ValidateEmptyTextBox(sender, e);
            validatingNumber(sender, e);
            if (!_IsInitialAndFinalPaymentLessOrEqualContractAmount())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtInitialPayment, "The total contract amount must be greater than or equal to both payments");
            }
            else
            {
                errorProvider1.SetError(txtInitialPayment, null);
            }
        }

        private void txtFinalPayment_Validating(object sender, CancelEventArgs e)
        {
            if (gbContractInfo.Enabled)
                ValidateEmptyTextBox(sender, e);
            validatingNumber(sender, e);
            if (!_IsInitialAndFinalPaymentLessOrEqualContractAmount())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFinalPayment, "The total contract amount must be greater than or equal to both payments");
            }
            else
            {
                errorProvider1.SetError(txtFinalPayment, null);
            }
        }

        private void nudNumberOfMonthsOfFinalPaymentInstallments_Validating(object sender, CancelEventArgs e)
        {
            if (cbAllowingFinalpaymentInstallments.Checked)
            {
                if (nudNumberOfMonthsOfFinalPaymentInstallments.Value == 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(nudNumberOfMonthsOfFinalPaymentInstallments, "Enter the number of months");
                }
                else
                    errorProvider1.SetError(nudNumberOfMonthsOfFinalPaymentInstallments, null);

            }
        }

        private void frmAddUpdateContract_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Contract.PaymentStatus == (Byte)clsContract.enPaymentStatus.Full)
            {
                MessageBox.Show("It is not possible to modify a contract that has been paid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _Contract.ContractAmount = double.Parse(txtContractAmount.Text);
            _Contract.TotalRemainingAmount = _Contract.ContractAmount - _Contract.TotalAmountPaid;
            _Contract.StartContract = dtpStartContract.Value;
            _Contract.EndContract = dtpEndContract.Value;
            if (_Mode == enMode.AddNew)
            {
                _Contract.CreatedDate = DateTime.Now;
                _Contract.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            if (_Mode == enMode.Update)
            {
                _Contract.UpdatedDate = DateTime.Now;
                _Contract.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            _Contract.InitialPayment = double.Parse(txtInitialPayment.Text);
            _Contract.FinalPayment = double.Parse(txtFinalPayment.Text);
            
            _Contract.PaymentEveryMonths = (byte)nudPaymentEveryMonths.Value;
            _Contract.PaymentEveryYears = (byte)nudPaymentEveryYears.Value;
            _Contract.NumberOfMonthsOfFinalPaymentInstallments = (byte)nudNumberOfMonthsOfFinalPaymentInstallments.Value;
            _Contract.AllowingFinalPaymentInstallments = cbAllowingFinalpaymentInstallments.Checked;
            _Contract.PaymentStatus = (byte)clsContract.enPaymentStatus.Nothing;
            _Contract.TypeID = clsTypesContract.Find(cmbTypeContract.Text).TypeID;
            switch (cmbMethodPayment.Text)
            {
                case "Partial":
                    _Contract.PaymentType = (byte)clsContract.enPaymentType.Partial;
                    break;
                case "Full":
                    _Contract.PaymentType = (byte)clsContract.enPaymentType.Full;
                    break;
                case "One Payment Later":
                    _Contract.PaymentType = (byte)clsContract.enPaymentType.OnePaymentLater;
                    break;
            }
            if (Math.Round( _Contract.ContractAmount,3) == Math.Round( _Contract.TotalAmountPaid,3))
            {
                _Contract.PaymentStatus = (byte)clsContract.enPaymentStatus.Full;
                _Contract.TotalRemainingAmount = 0;
            }
            if (_Contract.Save())
            {
                DataBackContractID?.Invoke(this, _Contract.ContractID);
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _ContractID = _Contract.ContractID;
                clsContractPaymentSchedulingApplication app = clsContractPaymentSchedulingApplication.FindByContractID(_ContractID);
                if(app!=null)
                {
                    if (_Contract.PaymentStatus == (byte)clsContract.enPaymentStatus.Full)
                    {
                        clsContractPaymentSchedule.ClearingOldInstallments(app.ApplicationID);
                        app.Status = (byte)clsContractPaymentSchedulingApplication.enStatus.Completed;
                        app.Save();
                    }
                    else
                    {
                        frmAddUpdateContractPaymentScheduling addUpdateContractPaymentScheduling = new frmAddUpdateContractPaymentScheduling(app.ApplicationID,false);
                        addUpdateContractPaymentScheduling.frmContractObligation_Load(null,null);    
                        addUpdateContractPaymentScheduling.btnSave_Click(null,null);
                    }
                }
                frmAddUpdateContract_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMethodPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMethodPayment.Text.ToLower() == "one payment later" || cmbMethodPayment.Text.ToLower() == "full")
                gbContractInfo.Enabled = false;
            else
                gbContractInfo.Enabled = true;
            if (cmbMethodPayment.Text.ToLower() == "one payment later")
                dtpDeferredPaymentDueDate.Enabled = true;
            else
                dtpDeferredPaymentDueDate.Enabled = false;
            if (gbContractInfo.Enabled)
            {
                if (_Mode == enMode.Update)
                {
                    txtInitialPayment.Text = _Contract.InitialPayment.ToString();
                    txtFinalPayment.Text = _Contract.FinalPayment.ToString();
                    cbAllowingFinalpaymentInstallments.Checked = _Contract.AllowingFinalPaymentInstallments;
                    nudNumberOfMonthsOfFinalPaymentInstallments.Value = _Contract.NumberOfMonthsOfFinalPaymentInstallments;
                    nudPaymentEveryMonths.Value = _Contract.PaymentEveryMonths;
                    nudPaymentEveryYears.Value = _Contract.PaymentEveryYears;
                }

            }
            else
            {
                txtInitialPayment.Text = "0";
                txtFinalPayment.Text = "0";
                cbAllowingFinalpaymentInstallments.Checked = false;
                nudNumberOfMonthsOfFinalPaymentInstallments.Value = 0;
                nudPaymentEveryMonths.Value = 0;
                nudPaymentEveryYears.Value = 0;
            }
        }

        private void cbAllowingFinalpaymentInstallments_CheckedChanged(object sender, EventArgs e)
        {

            if (cbAllowingFinalpaymentInstallments.Checked)
            {
                nudNumberOfMonthsOfFinalPaymentInstallments.Enabled = true;

            }
            else
            {
                nudNumberOfMonthsOfFinalPaymentInstallments.Value = 0;
                nudNumberOfMonthsOfFinalPaymentInstallments.Enabled = false;
                errorProvider1.SetError(nudNumberOfMonthsOfFinalPaymentInstallments, null);
            }
        }

        private void dtpStartContract_ValueChanged(object sender, EventArgs e)
        {
            dtpEndContract.MinDate = dtpStartContract.Value.AddDays(1);
            dtpDeferredPaymentDueDate.MinDate = dtpEndContract.Value;

        }

        private void dtpStartContract_Validating(object sender, CancelEventArgs e)
        {
        }

        private void nudPaymentEveryMonths_Validating(object sender, CancelEventArgs e)
        {
            if (!nudPaymentEveryMonths.Enabled)
                return;
            if (nudPaymentEveryMonths.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudPaymentEveryMonths, "Enter the number of months");
                return;
            }
            else
                errorProvider1.SetError(nudPaymentEveryMonths, null);
            if (nudPaymentEveryMonths.Maximum % nudPaymentEveryMonths.Value != 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudPaymentEveryMonths, "The number of months is not divisible by this number");
            }
            else
                errorProvider1.SetError(nudPaymentEveryMonths, null);
        }

        private void nudPaymentEveryYears_Validating(object sender, CancelEventArgs e)
        {
            if (!nudPaymentEveryYears.Enabled)
                return;
            if (nudPaymentEveryYears.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudPaymentEveryYears, "Enter the number of months");
            }
            else
                errorProvider1.SetError(nudPaymentEveryYears, null);
        }
        private void nudPaymentEveryYearsAndnudPaymentEveryMonthsEnabled()
        {
            if (_Contract.InitialPayment + _Contract.FinalPayment >= _Contract.ContractAmount)
            {
                nudPaymentEveryMonths.Enabled = false;
                nudPaymentEveryYears.Enabled = false;
                nudPaymentEveryMonths.Value = 0;
                nudPaymentEveryYears.Value = 0;
                errorProvider1.SetError(nudPaymentEveryYears, null);
                errorProvider1.SetError(nudPaymentEveryMonths, null);
            }
            else
            {
                nudPaymentEveryYears.Enabled = (dtpEndContract.Value.Year > dtpStartContract.Value.Year && dtpStartContract.Value.Month == dtpEndContract.Value.Month && nudPaymentEveryMonths.Value == 0);
                nudPaymentEveryMonths.Maximum = ((dtpEndContract.Value).Month - dtpStartContract.Value.Month) + (dtpEndContract.Value.Year - dtpStartContract.Value.Year) * 12;
                nudPaymentEveryYears.Maximum = dtpEndContract.Value.Year - dtpStartContract.Value.Year;
                nudPaymentEveryMonths.Enabled = (nudPaymentEveryYears.Value == 0);
            }
            if (!nudPaymentEveryYears.Enabled)
                errorProvider1.SetError(nudPaymentEveryYears, null);
            if (!nudPaymentEveryMonths.Enabled)
                errorProvider1.SetError(nudPaymentEveryMonths, null);
        }
        private void txtFinalPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtFinalPayment.Text != "")
                _Contract.FinalPayment = double.Parse(txtFinalPayment.Text);
            else
                _Contract.FinalPayment = 0;
            nudPaymentEveryYearsAndnudPaymentEveryMonthsEnabled();
            cbAllowingFinalpaymentInstallments.Enabled = _Contract.FinalPayment > 0 && _IsInitialAndFinalPaymentLessOrEqualContractAmount();
            if (!cbAllowingFinalpaymentInstallments.Enabled)
                cbAllowingFinalpaymentInstallments.Checked = false;
        }

        private void txtInitialPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPaymentEveryYears_ValueChanged(object sender, EventArgs e)
        {
            nudPaymentEveryYearsAndnudPaymentEveryMonthsEnabled();
        }

        private void nudPaymentEveryMonths_ValueChanged(object sender, EventArgs e)
        {
            nudPaymentEveryYearsAndnudPaymentEveryMonthsEnabled();
        }

        private void dtpEndContract_ValueChanged(object sender, EventArgs e)
        {
            nudPaymentEveryYearsAndnudPaymentEveryMonthsEnabled();
            lblNumberOfYears.Text = nudPaymentEveryYears.Maximum.ToString();
            lblNumberOfMonths.Text = nudPaymentEveryMonths.Maximum.ToString();
        }

        private void llCreatedByUserID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails(int.Parse(llCreatedByUserID.Text));
            frmUser.ShowDialog();
        }

        private void llUpdatedByUserID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llUpdatedByUserID.Text == "")
                return;
            frmUserDetails frmUser = new frmUserDetails(int.Parse(llUpdatedByUserID.Text));
            frmUser.ShowDialog();
        }
        private void DataBack(object sender, int BranchID)
        {
            _Contract.BranchID = BranchID;
            txttBranchID.Text = BranchID.ToString();
        }
        private void btnSelectBranchID_Click(object sender, EventArgs e)
        {
            frmListOfBranchesAndLogInToThem frmListOf = new frmListOfBranchesAndLogInToThem();
            frmListOf.DataBack += DataBack;
            frmListOf.ShowDialog();

        }

        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e); ;
        }

        private void nudDPP_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtContractAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
