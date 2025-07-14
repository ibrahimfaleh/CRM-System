using CarRental.Classes;
using CarRental.Properties;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CarRental.Vehicles.Forms
{
    public partial class frmAddUpdateVehicle : Form
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;
        private int _VehicleID;
        private string _PlateNumber;
        private bool _IsAmountSpentCompleted;
        private clsVehicle _Vehicle;
        public frmAddUpdateVehicle()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateVehicle(string PlatNumber)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PlateNumber = PlatNumber;
        }
        public frmAddUpdateVehicle(int VehicleID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _VehicleID = VehicleID;
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
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }
        private void _ResetDefaultValues()
        {
            dtptxtPurchasing.MinDate = DateTime.Now.AddYears(-10);
            dtptxtPurchasing.MaxDate = DateTime.Now;
            lblMode.Text = "Add New Vehicle";
            btnPurchase.Text = "Purchase";
            _Vehicle = new clsVehicle();
            _FillMakesInComoboBox();
            _FillFuelTypesInComoboBox();
            _FillDriveTypesInComoboBox();
            _FillBodiesInComoboBox();
        }
        private void _FillMakesInComoboBox()
        {

            foreach (DataRow row in clsMake.GetAllMakes().Rows)
            {
                cmbMake.Items.Add(row["Make"]);
            }
        }
        private void _FillModelsInComoboBox(int MakeID)
        {
            cmbModel.Items.Clear();
            foreach (DataRow row in clsModel.GetAllModelsByMakeID(MakeID).Rows)
            {
                cmbModel.Items.Add(row["ModelName"]);
            }
        }
        private void _FillFuelTypesInComoboBox()
        {

            foreach (DataRow row in clsFuleType.GetAllFuleTypes().Rows)
            {
                cmbFuelType.Items.Add(row["FuleType"]);
            }
        }
        private void _FillBodiesInComoboBox()
        {

            foreach (DataRow row in clsBodie.GetAllBodies().Rows)
            {
                cmbBodies.Items.Add(row["BodyName"]);
            }
        }
        private void _FillDriveTypesInComoboBox()
        {

            foreach (DataRow row in clsDriveType.GetAllDriveTypes().Rows)
            {
                cmbDriveTypes.Items.Add(row["DriveTypeName"]);
            }
        }
        private void _LoadVehicleImage()
        {
            pbVehicleImage.Image = Resources.Car;
            string ImagePath = _Vehicle.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbVehicleImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _LoadData()
        {
            if (_PlateNumber != null)
                _Vehicle = clsVehicle.Find(_PlateNumber);
            else
                _Vehicle = clsVehicle.Find(_VehicleID);
            if (_Vehicle == null)
            {
                MessageBox.Show("Vehicle Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            dtptxtPurchasing.MinDate = _Vehicle.AmountSpentInfo.Date;
            btnPurchase.Text = "Update Purchase";
            txtPurchasingPrice.Text = _Vehicle.AmountSpentInfo.Amount.ToString();
            llVehicleID.Text = _Vehicle.VehicleID.ToString();
            cmbFuelType.Text = _Vehicle.FuelTypeInfo.FuleType;
            cmbMake.Text = _Vehicle.MakeModelInfo.MakeInfo.Make;
            cmbBodies.Text = _Vehicle.BodieInfo.BodyName;
            cmbDriveTypes.Text = _Vehicle.DriveTypeInfo.DriveTypeName;
            _FillModelsInComoboBox(_Vehicle.MakeModelInfo.MakeInfo.MakeID());
            cmbModel.Text = _Vehicle.MakeModelInfo.ModelName;
            lblMode.Text = "Update Vehicle";
            txtPlateChar.Text = clsFormat.ConvertTextIntoLetters(clsFormat.ReturnsCharactersFromText(_Vehicle.PlateNumber));
            txtPlateNumber.Text = clsFormat.ConvertTextIntoLetters(clsFormat.ReturnNumbersFromText(_Vehicle.PlateNumber));
            txtRentalPricePerMileage.Text = _Vehicle.RentalPricePerMileage.ToString();
            txtVehiclName.Text = _Vehicle.Name;
            txtYear.Text = _Vehicle.Year.ToString();
            txtMileage.Text = _Vehicle.Mileage.ToString();
            txtRentalPricePerDay.Text = _Vehicle.RentalPricePerDay.ToString();
            cbIsAvailableForRental.Checked = _Vehicle.IsAvailableForRental;
            cbIsActive.Checked = _Vehicle.IsActive;
            llRemoveImage.Visible = (_Vehicle.ImagePath != DBNull.Value.ToString());
            txtRentalPricePerYear.Text = _Vehicle.RentalPricePerYear.ToString();
            txtRentalPricePerMonth.Text = _Vehicle.RentalPricePerMonth.ToString();
            txtRentalPricePerHour.Text = _Vehicle.RentalPricePerHours.ToString();
            _LoadVehicleImage();
            if (!_Vehicle.IsAvailableForRental)
            {
                txtMileage.Enabled = false;
                txtPlateChar.Enabled = false;
                txtPlateNumber.Enabled = false;
                cbIsActive.Enabled = false;
            }
        }
        private void frmAddUpdateVehicle_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();

        }
        private bool _HandleVehicleImage()
        {
            if (_Vehicle.ImagePath != pbVehicleImage.ImageLocation)
            {
                if (_Vehicle.ImagePath != "")
                {

                    try
                    {
                        File.Delete(_Vehicle.ImagePath);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbVehicleImage.ImageLocation != null)
                {
                    string SourceImageFile = pbVehicleImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageVehiclesToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbVehicleImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataBackAmountSpent(object sender, int AmountSpentID, bool IsSave, double TotalAmount)
        {
            _IsAmountSpentCompleted = IsSave;
            if (IsSave)
            {
                _Vehicle.AmountSpentID = AmountSpentID;
                txtPurchasingPrice.Text = TotalAmount.ToString();
            }
        }
        private void txtValidatePositiveNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);

        }
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtRentalPricePerDay_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (Temp.Text != "")
            {
                double Value = double.Parse(Temp.Text);
                guna2TextBox1.Text = (Value * clsGlobal.Tax.Vat).ToString("0.00");
                lblAfterTax.Text = Temp.Tag.ToString();
            }
        }
        private void cbIsActive_Click(object sender, EventArgs e)
        {
            cbIsAvailableForRental.Checked = cbIsActive.Checked;
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update || _IsAmountSpentCompleted)
            {
                btnPurchase.Text = "Update Purchase";
                frmAddUpdateAmountSpent frmAddUpdate = new frmAddUpdateAmountSpent(_Vehicle.AmountSpentID);
                frmAddUpdate.DataBack += DataBackAmountSpent;
                frmAddUpdate.ShowDialog();
            }
            else if (_Mode == enMode.AddNew)
            {
                frmAddUpdateAmountSpent frmAddUpdate = new frmAddUpdateAmountSpent(null, false);
                frmAddUpdate.DataBack += DataBackAmountSpent;
                frmAddUpdate.ShowDialog();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandleVehicleImage())
                return;

            _Vehicle.UpdateByUserID = clsGlobal.CurrentUser.UserID;
            StringBuilder sbPlateNumber = new StringBuilder();
            _Vehicle.Name = txtVehiclName.Text.Trim();
            _Vehicle.ModelID = clsMakeModel.Find(cmbModel.Text.ToString()).ModelID();
            _Vehicle.FuelTypeID = clsFuleType.Find(cmbFuelType.Text.ToString()).ID();
            _Vehicle.Mileage = int.Parse(txtMileage.Text);
            _Vehicle.RentalPricePerMileage = float.Parse(txtRentalPricePerMileage.Text);
            _Vehicle.Year = int.Parse(txtYear.Text);
            sbPlateNumber.Append(clsFormat.DeleteAllSpaceFromText(txtPlateChar.Text)).Append(clsFormat.DeleteAllSpaceFromText(txtPlateNumber.Text));
            _Vehicle.PlateNumber = sbPlateNumber.ToString();
            _Vehicle.RentalPricePerDay = float.Parse(txtRentalPricePerDay.Text);
            _Vehicle.IsAvailableForRental = cbIsAvailableForRental.Checked;
            _Vehicle.DriveTypeID = clsDriveType.Find(cmbDriveTypes.Text).DriveTypeID();
            _Vehicle.BodyID = clsBodie.Find(cmbBodies.Text).BodyID();
            _Vehicle.IsActive = cbIsActive.Checked;
            _Vehicle.RentalPricePerHours = float.Parse(txtRentalPricePerHour.Text);
            _Vehicle.RentalPricePerYear = double.Parse(txtRentalPricePerYear.Text);
            _Vehicle.RentalPricePerMonth = float.Parse(txtRentalPricePerMonth.Text);
            if (pbVehicleImage.ImageLocation != null)
                _Vehicle.ImagePath = pbVehicleImage.ImageLocation;
            else
                _Vehicle.ImagePath = "";

            if (_Vehicle.Save())
            {
                llVehicleID.Text = _Vehicle.VehicleID.ToString();
                _Mode = enMode.Update;
                _VehicleID = _Vehicle.VehicleID;
                _LoadData();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbVehicleImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
            }
        }
        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbVehicleImage.ImageLocation = null;

            pbVehicleImage.Image = Resources.Car;

            llRemoveImage.Visible = false;
        }
        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBoxGuna2(sender,e);
            if (txtYear.Text != "")
                if (txtYear.Text[0] == '0')
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtYear, "invalid number!");
                }
                else
                {
                    errorProvider1.SetError(txtYear, null);
                }
        }
    }
}
