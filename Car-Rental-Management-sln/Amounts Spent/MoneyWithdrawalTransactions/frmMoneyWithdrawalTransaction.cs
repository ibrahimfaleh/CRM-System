using CarRental.Classes;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.Amounts_Spent.Money_Withdrawal_Transactions
{
    public partial class frmMoneyWithdrawalTransaction : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _GeneralRevenueFundID;
        private int _MoneyWithdrawalTransactionID;
        private clsMoneyWithdrawalTransaction _MoneyWithdrawalTransaction;
        private double _Amount;
        private bool _IsAmountSpentSave = false;
        public frmMoneyWithdrawalTransaction()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _GeneralRevenueFundID = clsGlobal.GeneralRevenueFundID;
        }
        public frmMoneyWithdrawalTransaction(int MoneyWithdrawalTransactionID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _GeneralRevenueFundID = clsGlobal.GeneralRevenueFundID;
            _MoneyWithdrawalTransactionID = MoneyWithdrawalTransactionID;
        }
        private void _ResetDefaultValues()
        {
            _MoneyWithdrawalTransaction=new clsMoneyWithdrawalTransaction();
            lblTitle.Text = "Add New";
            btnSave.Text = "Money Withdrawal";
            ctrlAmountSpentDetails1.ResetDefaultValues();
        }
        private void _LoadData(int MoneyWithdrawalTransactionID)
        {
            if ((_MoneyWithdrawalTransaction = clsMoneyWithdrawalTransaction.Find(MoneyWithdrawalTransactionID)) != null)
            {
                btnSave.Text = "Update";
                _Mode=enMode.Update;
                lblTitle.Text = "Update";
                ctrlAmountSpentDetails1.LoadData(_MoneyWithdrawalTransaction.AmountSpentID);
            }
            else
            {
                _ResetDefaultValues();
                MessageBox.Show("Error loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void frmMoneyWithdrawalTransaction_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmMoneyWithdrawal))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(_GeneralRevenueFundID);
            ctrldgvMoneyWithdrawalTransaction1.LoadMoneyWithdrawalTransaction(_GeneralRevenueFundID);
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData(_MoneyWithdrawalTransactionID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _Mode = enMode.AddNew;
            frmMoneyWithdrawalTransaction_Load(null, null);
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
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
            Guna2TextBox Temp = (Guna2TextBox)sender;e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text+e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);;
        }
        private void DataBackEvent(object sender, int AmountSpentID, bool IsSave, double TotalAMount)
        {
            ctrlAmountSpentDetails1.LoadData(AmountSpentID);
            _MoneyWithdrawalTransaction.AmountSpentID = AmountSpentID;
            _IsAmountSpentSave = IsSave;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsGeneralRevenueFund fund = clsGeneralRevenueFund.Find(_GeneralRevenueFundID);
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (_Mode == enMode.AddNew)
            {
                if (_Amount > fund.TotalAmount)
                {
                    MessageBox.Show("The amount of vehicle breakdown revenue is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmAddUpdateAmountSpent fem1 = new frmAddUpdateAmountSpent(null,false);
                fem1.DataBack += DataBackEvent;
                fem1.ShowDialog();
            }
            if(_Mode==enMode.Update) 
            {
                frmAddUpdateAmountSpent fem1 = new frmAddUpdateAmountSpent(_MoneyWithdrawalTransaction.AmountSpentID);
                fem1.DataBack += DataBackEvent;
                fem1.ShowDialog();

            }


            if (_IsAmountSpentSave && _MoneyWithdrawalTransaction.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _IsAmountSpentSave = false;
                _MoneyWithdrawalTransactionID = _MoneyWithdrawalTransaction.MoneyWithdrawalTransactionsID;
                frmMoneyWithdrawalTransaction_Load(null, null);
            }



        }


        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }


        private void ctrldgvMoneyWithdrawalTransaction1_OnMoneyWithdrawalTransactionID(int obj)
        {
            _LoadData(obj);

        }
    }
}
