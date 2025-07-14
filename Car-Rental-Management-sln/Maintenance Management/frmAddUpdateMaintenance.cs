using CarRental.Classes;
using CarRental.People.Employee.Forms;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental.Vehicles;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddUpdateMaintenanceTransaction : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode = enMode.AddNew;
        private int _MaintenanceID;
        private clsMaintenanceTransaction _MaintenanceTransaction;
        private bool _IsAmountSpentSave;
        public frmAddUpdateMaintenanceTransaction(int MaintenanceID)
        {
            InitializeComponent();
            _MaintenanceID = MaintenanceID;
            _Mode = enMode.Update;

        }
        public frmAddUpdateMaintenanceTransaction()
        {
            InitializeComponent();
        }
        private void _ResetValues()
        {
            _MaintenanceTransaction=new clsMaintenanceTransaction();
            lblTitle.Text = "Add New Maintenance";
            txtConsumedMileage.Text = "";
            txtCost.Text = "";
            txtDescription.Text = "";
            txtTransferredEmployeeID.Text = "";
            txtSelectReturnByEmployeeID.Text = "";
            txtSelectReturnByEmployeeID.Text = "";
            txtSelectReturnByEmployeeID.Text = "";
            lblTransferredDate.Text = "";
            lblReturnDate.Text = "";
            gbVehicleReturn.Enabled = false;
            lblStatus.Text = "New";
            llMaintenanceID.Text = "??";
            ctrlVehicleWithFilter1.ModeFind = ctrlShortDetailsVehicle.enModeFind.FindAvailableAndBranchID;
            ctrlVehicleWithFilter1.EditedVisible = false;
        }
        private void _LoadData()
        {
            _MaintenanceTransaction = clsMaintenanceTransaction.Find(_MaintenanceID);

            if (_MaintenanceTransaction != null)
            {
                ctrlVehicleWithFilter1.ModeFind = ctrlShortDetailsVehicle.enModeFind.AllByBranchID;
                ctrlVehicleWithFilter1.LoadVehicleInfo(_MaintenanceTransaction.VehicleID);
                btnSelectVehicleTransferredByEmployeeID.Enabled = false;
                lblTitle.Text = "Update Maintenance";
                lblTransferredDate.Text = _MaintenanceTransaction.MaintenanceDate.ToString("g");
                txtTransferredEmployeeID.Text = _MaintenanceTransaction.TransferredByEmployeeID.ToString();
                txtDescription.Text = _MaintenanceTransaction.Description.ToString();
                llCreatedByUserID.Text = _MaintenanceTransaction.CreatedByUserID.ToString();
                gbVehicleReturn.Enabled = true;
                btnSave.Text = "Pay And Save";
                llMaintenanceID.Text = _MaintenanceTransaction.MaintenanceID.ToString();
                if (_MaintenanceTransaction.IsCompleted)
                {
                    txtCost.ReadOnly = true;
                    txtNewMileage.ReadOnly = true;
                    btnSelectReturnByEmployeeID.Enabled = false;
                    lblStatus.Text = "Completed";
                    txtNewMileage.Text = _MaintenanceTransaction.NewMileage.ToString();
                    lblReturnDate.Text = _MaintenanceTransaction.ReturnDate.ToString();
                    txtSelectReturnByEmployeeID.Text = _MaintenanceTransaction.VehicleReturnByEmployeeID.ToString();
                    txtCost.Text = _MaintenanceTransaction.Cost.ToString();
                    llUpdateByUserID.Text = _MaintenanceTransaction.UpdatedByUserID.ToString();
                    txtConsumedMileage.Text = _MaintenanceTransaction.ConsumedMileage.ToString();
                    llAmountSpent.Text = _MaintenanceTransaction.AmountSpentID.ToString();
                    btnSave.Text = "Update";
                }
            }
            else
            {
                MessageBox.Show("No results found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataBacTransferredByEmployeeID(object sender, int EmployeeID)
        {
            Form form = (Form)sender;
            form.Close();
            _MaintenanceTransaction.TransferredByEmployeeID = EmployeeID;
            txtTransferredEmployeeID.Text = (EmployeeID.ToString());
        }
        private void DataBacReturnByEmployeeID(object sender, int EmployeeID)
        {
            Form form = (Form)sender;
            form.Close();
            _MaintenanceTransaction.VehicleReturnByEmployeeID = EmployeeID;
            txtSelectReturnByEmployeeID.Text = (EmployeeID.ToString());
        }
        private void DataBackAmountSpent(object sender, int AmountSpentID, bool IsSave, double TotalAmount)
        {
            _IsAmountSpentSave = IsSave;
            _MaintenanceTransaction.AmountSpentID = AmountSpentID;
            _MaintenanceTransaction.Cost = TotalAmount;
        }
        private void frmMaintenanceManagement_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmAddUpdateMaintenance))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _ResetValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Mode == enMode.Update)
                if (_AddUpdateAmountSpent())
                {
                    _MaintenanceTransaction.IsCompleted = true;
                    if (_AddUpdateMaiMaintenance())
                    {
                        MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _Mode = enMode.Update;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            else if (_AddUpdateMaiMaintenance())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _MaintenanceID = _MaintenanceTransaction.MaintenanceID;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_Mode == enMode.Update)
            {
                ctrlVehicleWithFilter1.SelectedVehicle.Save();
                _MaintenanceID = _MaintenanceTransaction.MaintenanceID;
                _IsAmountSpentSave = false;
                frmMaintenanceManagement_Load(null, null);
            }
        }
        private void btnSelectVehicleTransferredByEmployeeID_Click(object sender, EventArgs e)
        {
            frmSelectEmployee selectEmployee = new frmSelectEmployee(clsGlobal.Branch.BranchID);
            selectEmployee.DataBack += DataBacTransferredByEmployeeID;
            selectEmployee.ShowDialog();
        }
        private void btnSelectReturnByEmployeeID_Click(object sender, EventArgs e)
        {
            frmSelectEmployee selectEmployee = new frmSelectEmployee(clsGlobal.Branch.BranchID);
            selectEmployee.DataBack += DataBacReturnByEmployeeID;
            selectEmployee.ShowDialog();
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
        private bool _AddUpdateAmountSpent()
        {
            if (_MaintenanceTransaction.IsCompleted)
            {
                frmAddUpdateAmountSpent frm = new frmAddUpdateAmountSpent(_MaintenanceTransaction.AmountSpentID.Value);
                frm.DataBack += DataBackAmountSpent;
                frm.ShowDialog();
            }
            else
            {
                frmAddUpdateAmountSpent frm = new frmAddUpdateAmountSpent(double.Parse(txtCost.Text), true);
                frm.DataBack += DataBackAmountSpent;
                frm.ShowDialog();
            }
            return _IsAmountSpentSave;

        }
        private bool _AddUpdateMaiMaintenance()
        {
            if (_Mode == enMode.Update)
            {
                _MaintenanceTransaction.ReturnDate = DateTime.Now;
                _MaintenanceTransaction.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
                if (_MaintenanceTransaction.IsCompleted)
                {
                    _MaintenanceTransaction.NewMileage = int.Parse(txtNewMileage.Text);
                    ctrlVehicleWithFilter1.SelectedVehicle.IsAvailableForRental = true;
                    ctrlVehicleWithFilter1.SelectedVehicle.Mileage = _MaintenanceTransaction.NewMileage ?? 0;
                    if (_MaintenanceTransaction.Cost > 0)
                        ctrlVehicleWithFilter1.SelectedVehicle.NumberTimesOfMaintenance++;
                }
            }
            else if (_Mode == enMode.AddNew)
            {
                _MaintenanceTransaction.Mileage += ctrlVehicleWithFilter1.SelectedVehicle.Mileage;
                _MaintenanceTransaction.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _MaintenanceTransaction.MaintenanceDate = DateTime.Now;
                _MaintenanceTransaction.Description = txtDescription.Text;
                ctrlVehicleWithFilter1.SelectedVehicle.IsAvailableForRental = false;
            }
            return _MaintenanceTransaction.Save();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNewMileage_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMileage.Text != "")
                txtConsumedMileage.Text = (int.Parse(txtNewMileage.Text) - _MaintenanceTransaction.Mileage).ToString();
        }
        private void txtNewMileage_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
                ValidateEmptyTextBox(sender, e);
            if (txtNewMileage.Text.Length > 0)
            {
                Guna2TextBox Temp = (Guna2TextBox)sender;
                if (int.Parse(Temp.Text) < _MaintenanceTransaction.Mileage)
                {
                    errorProvider1.SetError(Temp, "Mileage is lower than expected!");
                }
                else
                    errorProvider1.SetError(Temp, null);
            }
        }
        private void txtSelectReturnByEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
                ValidateEmptyTextBox(sender, e);
        }
        private void txtNewMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }
        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.AddNew)
                return;
            if (string.IsNullOrEmpty(txtCost.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCost, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtCost, null);
            }
        }
        private void ctrlVehicleWithFilter1_OnVehicleSelected(int obj)
        {
            _MaintenanceTransaction.VehicleID = obj;
        }
        private void ctrlVehicleWithFilter1_Validating(object sender, CancelEventArgs e)
        {
            if(ctrlVehicleWithFilter1.SelectedVehicle==null)
            {
                e.Cancel = true;
                errorProvider1.SetError(ctrlVehicleWithFilter1, "Select a Vehicle");
            }
            else
                errorProvider1.SetError (ctrlVehicleWithFilter1, null);
        }
    }
}