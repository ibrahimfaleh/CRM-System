using CarRental.Classes;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Rental_Transaction.Rental_Settings
{
    public partial class frmBranchManagment : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _BranchID;
        private clsBranch _branch;
        public frmBranchManagment()
        {
            InitializeComponent();
            this._BranchID = -1;
            _Mode = enMode.AddNew;
        }
        public frmBranchManagment(int BranchID)
        {
            InitializeComponent();
            this._BranchID = BranchID;
            _Mode = enMode.Update;
        }
        private void _FullComboBoxCities()
        {
            foreach(DataRow row in clsCity.GetAllCities().Rows) 
            {
                cmbCities.Items.Add(row[1]);
            }
        }
        private void txtNumberOfDaysMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar); ;
        }

        private void txtEmpty_Validating(object sender, CancelEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsTypeOfMonth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _branch.CountDailyIncomeFundPerDay = (byte)nudNumberOfIncomeFundsPerDay.Value;
            _branch.StreetName=txtStreetName.Text;
            _branch.BranchLocation=txtLocation.Text;
            _branch.CityID = clsCity.Find(cmbCities.Text).CityID();
            _branch.IsPublic=cbIsPublic.Checked;    
            if (_branch.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsGlobal.Branch = clsBranch.Find(clsGlobal.CurrentUser.EmployeeInfo.BranchID);
            }
        }

        private void _LoadData()
        {
            if ((_branch = clsBranch.Find(_BranchID)) == null)
            {
                MessageBox.Show("There was an error loading branch data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblMode.Text = "Update";
            txtStreetName.Text = _branch.StreetName;
            txtLocation.Text = _branch.BranchLocation;
            cmbCities.Text = clsCity.Find(_branch.CityID).CityName;
            txtStartAmount.Text = _branch.AmountSpentInfo.Amount.ToString();
            nudNumberOfIncomeFundsPerDay.Value = _branch.CountDailyIncomeFundPerDay;
            cbIsPublic.Checked = _branch.IsPublic;
            btnAddStartAmount.Text = "Update Start Amount";
        }
        private void _ResetDefaultValues()
        {
            _branch = new clsBranch();  
            _FullComboBoxCities();
            lblMode.Text = "Add New";
            txtLocation.Text = "";
            txtStreetName.Text = "???";
            txtStartAmount.Text = "";
            nudNumberOfIncomeFundsPerDay.Value = 1;
            cbIsPublic.Checked = false;
            btnAddStartAmount.Text="Add Start Amount";

        }
        private void frmCarRentalOperationsManagement_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmUpdateBranch))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void tsTypeOfMonth_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void nudNumberOfIncomeFundsPerDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataBack(object sender, int AmountSpentID, bool IsSave, double TotalAMount)
        {
            _branch.AmountSpentID = AmountSpentID;
            txtStartAmount.Text =TotalAMount.ToString();
        }
        private void txtStartAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCities_Validating(object sender, CancelEventArgs e)
        {
            Guna2ComboBox Temp = (Guna2ComboBox)sender;
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

        private void btnAddStartAmount_Click(object sender, EventArgs e)
        {
            if(_branch.AmountSpentID.HasValue) 
            {
                frmAddUpdateAmountSpent frmAddUpdateAmount = new frmAddUpdateAmountSpent(_branch.AmountSpentID.Value);
                frmAddUpdateAmount.DataBack += DataBack;
                frmAddUpdateAmount.ShowDialog();
            }
            else
            {
                frmAddUpdateAmountSpent frmAddUpdateAmount = new frmAddUpdateAmountSpent(null, false);
                frmAddUpdateAmount.DataBack += DataBack;
                frmAddUpdateAmount.ShowDialog();
            }

        }
    }
}
