using CarRental.Classes;
using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.Rental_Fund.General_Revenue_Fund
{
    public partial class frmGeneralFundSupport : Form
    {
        private clsGeneralFundSupportTransaction _FundSupportTransaction;
        private clsGeneralRevenueFund _generalRevenueFund;
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _GeneralFundSupportID;
        public frmGeneralFundSupport()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmGeneralFundSupport(int GeneralFundSupportID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _GeneralFundSupportID = GeneralFundSupportID;
        }
        private void _RestDefaultValue()
        {
            lblTitle.Text = "Add New Support";
            txtAmount.Text = "";
            txtwithdrawalsDetails.Text = "";
        }
        private bool _UpdateGeneralFundSupportTransaction()
        {


            _FundSupportTransaction.Amount = double.Parse(txtAmount.Text);
            if (cmbPayment.Text == "Cash")
                _FundSupportTransaction.ePaymentDetails = clsGeneralFundSupportTransaction.enPaymentDetails.Cash;
            else
                _FundSupportTransaction.ePaymentDetails = clsGeneralFundSupportTransaction.enPaymentDetails.Transformation;
            _FundSupportTransaction.Details = txtwithdrawalsDetails.Text;
            _FundSupportTransaction.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
            _FundSupportTransaction.UpdateDate = DateTime.Now;

            return _FundSupportTransaction.Save();

        }
        private bool _AddNewGeneralFundSupportTransaction()
        {
            _FundSupportTransaction = new clsGeneralFundSupportTransaction();
            _FundSupportTransaction.Amount = double.Parse(txtAmount.Text);
            if (cmbPayment.Text == "Cash")
                _FundSupportTransaction.ePaymentDetails = clsGeneralFundSupportTransaction.enPaymentDetails.Cash;

            _FundSupportTransaction.Details = txtwithdrawalsDetails.Text;
            _FundSupportTransaction.Date = DateTime.Now;
            _FundSupportTransaction.GeneralRevenueFundID = clsGlobal.GeneralRevenueFundID;
            _FundSupportTransaction.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            return _FundSupportTransaction.Save();
        }
        private void _LoadData()
        {
            if ((_FundSupportTransaction = clsGeneralFundSupportTransaction.Find(_GeneralFundSupportID)) == null)
            {
                MessageBox.Show("Error loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblTitle.Text = "Update Support";

            txtAmount.Text = _FundSupportTransaction.Amount.ToString();
            txtwithdrawalsDetails.Text = _FundSupportTransaction.Details;
            if (_FundSupportTransaction.ePaymentDetails == clsGeneralFundSupportTransaction.enPaymentDetails.Cash)
                cmbPayment.Text = "Cash";
            else
                cmbPayment.Text = "Bank";
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGeneralFundSupport_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmGeneralFundSupport))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(clsGlobal.GeneralRevenueFundID);
            _RestDefaultValue();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _generalRevenueFund = clsGeneralRevenueFund.Find(clsGlobal.GeneralRevenueFundID);

            if (_Mode == enMode.Update && _FundSupportTransaction != null&&_generalRevenueFund.AnotherIncome>=_FundSupportTransaction.Amount)
            {
                if ((cmbPayment.Text == "Cash" && _generalRevenueFund.Cash <= _FundSupportTransaction.Amount) || (cmbPayment.Text == "Bank" && _generalRevenueFund.Bank <= _FundSupportTransaction.Amount))
                {
                    if(MessageBox.Show("Do you want to deposit money in the bank?", "The bank balance is insufficient", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
                    {
                        frmManagingGeneralFund generalFund = new frmManagingGeneralFund(_FundSupportTransaction.GeneralRevenueFundID);
                        generalFund.ShowDialog();
                    }
                }
                if (_FundSupportTransaction.ePaymentDetails == clsGeneralFundSupportTransaction.enPaymentDetails.Cash)
                    _generalRevenueFund.Cash -= _FundSupportTransaction.Amount;
                else
                    _generalRevenueFund.Bank -= _FundSupportTransaction.Amount;
                _generalRevenueFund.AnotherIncome -= _FundSupportTransaction.Amount;
                if (_UpdateGeneralFundSupportTransaction())
                {
                    if (_FundSupportTransaction.ePaymentDetails == clsGeneralFundSupportTransaction.enPaymentDetails.Cash)
                        _generalRevenueFund.Cash += _FundSupportTransaction.Amount;
                    else
                        _generalRevenueFund.Bank += _FundSupportTransaction.Amount;
                    _generalRevenueFund.AnotherIncome += _FundSupportTransaction.Amount;
                    _generalRevenueFund.Save();
                    _GeneralFundSupportID = _FundSupportTransaction.FundSupportTransactionID;
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGeneralFundSupport_Load(null, null);
                    return;
                }
            }
            if (_Mode == enMode.AddNew)
                if (_AddNewGeneralFundSupportTransaction())
                {
                    if (_FundSupportTransaction.ePaymentDetails == clsGeneralFundSupportTransaction.enPaymentDetails.Cash)
                        _generalRevenueFund.Cash += _FundSupportTransaction.Amount;
                    else
                        _generalRevenueFund.Bank += _FundSupportTransaction.Amount;
                    _generalRevenueFund.AnotherIncome += _FundSupportTransaction.Amount;
                    _GeneralFundSupportID = _FundSupportTransaction.FundSupportTransactionID;
                    _Mode = enMode.Update;
                    if(_generalRevenueFund.Save())
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGeneralFundSupport_Load(null, null);
                }
            else
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmGeneralFundSupport_Load(null, null);
        }
    }
}
