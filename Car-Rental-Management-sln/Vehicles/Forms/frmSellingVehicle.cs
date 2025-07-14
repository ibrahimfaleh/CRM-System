using CarRental.Classes;
using CarRental.Vehicles;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmSellingVehicle : Form
    {

        public enum enMode { AddNew=1,Update=2};
        private enMode _Mode;
        private int _saleVehicleID;
        private clsVehicleSale _VehicleSale;
        public frmSellingVehicle(int saleVehicle)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _saleVehicleID = saleVehicle;
        }
        public frmSellingVehicle()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _ResetDefaultValues()
        {
            _VehicleSale = new clsVehicleSale();
            lblTitle.Text = "Add New Selling";
            txtDescription.Text = "";
            lblSellingDate.Visible = false;
            lblTitleSellingDate.Visible=false;
            lblTitleSellingID.Visible=false;
            llSellingID.Visible = false;

            ctrlVehicleWithFilter1.ModeFind = ctrlShortDetailsVehicle.enModeFind.Available;

            lblTitleCreatedByUserID.Visible=false;
            lblTitleUpdatedByUserID.Visible=false;
            lblTitleUpdatedDate.Visible=false;

            llCreatedByUserID.Visible=false;
            llUpdatedByUserID.Visible=false;
            lblUpdatedDate.Visible=false;
            txtPrice.Text = "";
        }
        private void _LoadData()
        {
            ctrlVehicleWithFilter1.ModeFind = ctrlShortDetailsVehicle.enModeFind.All;
            _VehicleSale = clsVehicleSale.Find(_saleVehicleID);
            if(_VehicleSale != null) 
            {
                lblTitle.Text = "Update Sale";
                lblSellingDate.Visible = true;
                lblTitleSellingDate.Visible = true;
                lblTitleSellingID.Visible = true;
                llSellingID.Visible = true;

                lblTitleCreatedByUserID.Visible = true;
                llCreatedByUserID.Visible = true;
                if( _VehicleSale.UpdatedByUserID!=null)
                {
                    lblTitleUpdatedByUserID.Visible = true;
                    lblTitleUpdatedDate.Visible = true;
                    llUpdatedByUserID.Visible = true;
                    lblUpdatedDate.Visible = true;
                    llUpdatedByUserID.Text = _VehicleSale.UpdatedByUserID.ToString();
                    lblUpdatedDate.Text=_VehicleSale.UpdatedDate?.ToString("d");    
                }

                llCreatedByUserID.Text= _VehicleSale.CreatedByUserID.ToString();
                txtPrice.Text= _VehicleSale.Price.ToString();
                txtDescription.Text = _VehicleSale.Description;
                lblSellingDate.Text=_VehicleSale.SaleDate.ToString("d");
                llSellingID.Text = _VehicleSale.SaleID.ToString();
                ctrlVehicleWithFilter1.FilterEnabled = false;

                ctrlVehicleWithFilter1.LoadVehicleInfo(_VehicleSale.VehicleID);
            }
            else
            {
                MessageBox.Show("Sale ID = "+ _saleVehicleID, " Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        private void validatingNumber(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (Temp.Text.Length == 0)
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmSellingVehicle_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode==enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!ctrlVehicleWithFilter1.SelectedVehicle.IsAvailableForRental&&_Mode==enMode.AddNew)
            {
                MessageBox.Show("Vehicle not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsGeneralRevenueFund fund = clsGeneralRevenueFund.Find(clsGlobal.GeneralRevenueFundID);
            if (_Mode == enMode.AddNew)
            {
                _VehicleSale.Price = double.Parse(txtPrice.Text);
                _VehicleSale.SaleDate = DateTime.Now;
                _VehicleSale.VehicleID = ctrlVehicleWithFilter1.SelectedVehicle.VehicleID;
                _VehicleSale.Description = txtDescription.Text;
                _VehicleSale.CreatedByUserID=clsGlobal.CurrentUser.UserID;
                if (cmbPaymentDetails.Text == "Cash")
                {
                    fund.Cash += _VehicleSale.Price;
                    _VehicleSale.PaymentDetails = (byte)clsVehicleSale.enPaymentDetails.Cash;
                }
                if (cmbPaymentDetails.Text == "Bank Transfer")
                {
                    fund.Bank += _VehicleSale.Price;
                    _VehicleSale.PaymentDetails = (byte)clsVehicleSale.enPaymentDetails.BankTransfer;
                }
                fund.VehicleSales += _VehicleSale.Price;
            }

            if(_Mode==enMode.Update)
            {
                if (_VehicleSale.PaymentDetails == (byte)clsVehicleSale.enPaymentDetails.Cash)
                {
                    fund.Cash -= _VehicleSale.Price;
                }
                if (_VehicleSale.PaymentDetails ==(byte)clsVehicleSale.enPaymentDetails.BankTransfer)
                { 
                    fund.Bank -= _VehicleSale.Price;
                }
                fund.VehicleSales -= _VehicleSale.Price;
                _VehicleSale.Price = double.Parse(txtPrice.Text);
                _VehicleSale.UpdatedDate = DateTime.Now;
                _VehicleSale.VehicleID = ctrlVehicleWithFilter1.SelectedVehicle.VehicleID;
                _VehicleSale.Description = txtDescription.Text;
                _VehicleSale.UpdatedByUserID=clsGlobal.CurrentUser.UserID;
                if (cmbPaymentDetails.Text == "Cash")
                {
                    fund.Cash += _VehicleSale.Price;
                    _VehicleSale.PaymentDetails = (byte)clsVehicleSale.enPaymentDetails.Cash;
                }
                if (cmbPaymentDetails.Text == "Bank Transfer")
                {
                    fund.Bank += _VehicleSale.Price;
                    _VehicleSale.PaymentDetails = (byte)clsVehicleSale.enPaymentDetails.BankTransfer;
                }
                fund.VehicleSales += _VehicleSale.Price;
            }
            if(_VehicleSale.Save())
            {
                ctrlVehicleWithFilter1.SelectedVehicle.IsSold = true;
                ctrlVehicleWithFilter1.SelectedVehicle.IsActive = false; 
                ctrlVehicleWithFilter1.SelectedVehicle.IsAvailableForRental = false;
                ctrlVehicleWithFilter1.FilterEnabled=false;
                ctrlVehicleWithFilter1.SelectedVehicle.Save();
                fund.Save();
                _saleVehicleID = _VehicleSale.SaleID;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                frmSellingVehicle_Load(null,null);
            }else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlVehicleWithFilter1_OnVehicleSelected(int obj)
        {
            if(ctrlVehicleWithFilter1.SelectedVehicle.IsSold)
            {
                _saleVehicleID = clsVehicleSale.FindByVehicleID(obj).SaleID;
                _Mode=enMode.Update;
                _LoadData();
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender,e);
            validatingNumber(sender,e);
        }

        private void ctrlVehicleWithFilter1_Validating(object sender, CancelEventArgs e)
        { 
            if (ctrlVehicleWithFilter1.SelectedVehicle==null)
            {
                e.Cancel = true;
                errorProvider1.SetError(ctrlVehicleWithFilter1, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(ctrlVehicleWithFilter1, null);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ctrlVehicleWithFilter1.ResetDefaultValues();
            _Mode = enMode.AddNew;
            frmSellingVehicle_Load(null,null);  
        }
    }
}
