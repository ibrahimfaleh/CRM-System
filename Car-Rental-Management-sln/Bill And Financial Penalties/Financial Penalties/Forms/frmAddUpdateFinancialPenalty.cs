using CarRental.Classes;
using CarRental.Properties;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.FinancialPenaltyAndFines.Fines.Forms
{
    public partial class frmAddUpdateFinancialPenalty : Form
    {
        public delegate void DataBackEventHandler(object sender, int FinancialPenaltyID);
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _FinancialPenaltyID;
        private clsFinancialPenaltie _FinancialPenalty;
        public frmAddUpdateFinancialPenalty()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateFinancialPenalty(int FinancialPenaltyID)
        {
            InitializeComponent();
            _FinancialPenaltyID=FinancialPenaltyID;
            _Mode = enMode.Update;
        }
        private void _LoadFinancialPenaltyTypes()
        {
            cmbType.Items.Clear();
            foreach (DataRow row in clsPenaltyType.GetAllPenaltyTypes().Rows)
            {
                cmbType.Items.Add(row[1]);
            }
        }
        private void _ResetDefaultValues()
        {
            _LoadFinancialPenaltyTypes();
            llRemoveImage.Visible = false;
            _FinancialPenalty = new clsFinancialPenaltie();
            txtCost.Text = string.Empty;
            txtDetails.Text = string.Empty;
            lblTitle.Text = "Add New FinancialPenalty";
            llFinancialPenaltyID.Text = "???";
            pbImage.Image = Resources.bill;
        }
        private void _LoadData()
        {
            _FinancialPenalty = clsFinancialPenaltie.Find(_FinancialPenaltyID);
            if (_FinancialPenalty == null)
            {

                MessageBox.Show("Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblTitle.Text = "Update FinancialPenalty";
            llFinancialPenaltyID.Text = _FinancialPenalty.PenaltyID.ToString();
            txtCost.Text = _FinancialPenalty.Cost.ToString();
            txtDetails.Text = _FinancialPenalty.Details.ToString();
            cmbType.Text = clsPenaltyType.Find(_FinancialPenalty.TypeID).PenaltyType;
            if (_FinancialPenalty.ImagePath != "")
            {
                pbImage.ImageLocation = _FinancialPenalty.ImagePath;

            }
            llRemoveImage.Visible = (_FinancialPenalty.ImagePath != "");
        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbImage.Load(selectedFilePath);
                string x = pbImage.ImageLocation.ToString();
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbImage.ImageLocation = null;
            pbImage.Image = Resources.bill;

            llRemoveImage.Visible = false;
        }
        private bool _HandleFinancialPenaltyImage()
        {

            if (_FinancialPenalty.ImagePath != pbImage.ImageLocation)
            {
                if (_FinancialPenalty.ImagePath != "")
                {

                    try
                    {
                        File.Delete(_FinancialPenalty.ImagePath);
                    }
                    catch (IOException)
                    {
                    }
                }

                if (pbImage.ImageLocation != null)
                {
                    string SourceImageFile = pbImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageFinancialPenaltyToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbImage.ImageLocation = SourceImageFile;
                        _FinancialPenalty.ImagePath = pbImage.ImageLocation.ToString();
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
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (_FinancialPenalty.IsPaid)
            {
                MessageBox.Show("It is not possible to modify, the invoice has been paid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandleFinancialPenaltyImage())
                return;
            _FinancialPenalty.Cost = double.Parse(txtCost.Text);
            _FinancialPenalty.Details = txtDetails.Text;
            _FinancialPenalty.TypeID = clsPenaltyType.Find(cmbType.Text).TypeID;
            if (_Mode == enMode.AddNew)
            {
                _FinancialPenalty.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _FinancialPenalty.Date = DateTime.Now;
            }
            if (_Mode == enMode.Update)
            {
                _FinancialPenalty.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
                _FinancialPenalty.UpdateDate = DateTime.Now;
            }
            if (_FinancialPenalty.Save())
            {

                MessageBox.Show("Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _FinancialPenaltyID = _FinancialPenalty.PenaltyID;
                frmAddUpdateFinancialPenaltys_Load(null, null);
                DataBack?.Invoke(sender, _FinancialPenalty.PenaltyID);
            }
            else
                MessageBox.Show("Not saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(txtCost.Text + e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbType.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbType, "This field is required!");
            }
            else
                errorProvider1.SetError(cmbType, null);

        }

        private void txtCost_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCost.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCost, "This field is required!");
            }
            else
                errorProvider1.SetError(txtCost, null);
        }

        private void frmAddUpdateFinancialPenaltys_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDetails_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDetails.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDetails, "This field is required!");
            }
            else
                errorProvider1.SetError(txtDetails, null);
        }

        private void frmAddUpdateFinancialPenalty_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
                _LoadData();
        }

        private void DataBackAmountSpentID(object sender,int AmountSpentID,bool isSave,double Amount)
        {
            frmAddUpdateAmountSpent frm = (frmAddUpdateAmountSpent)sender;
            frm.Close();
            if(isSave)
            {
                _FinancialPenalty.AmountSpentID = AmountSpentID;
                _FinancialPenalty.IsPaid = true;
                if (_FinancialPenalty.Save())
                {

                    MessageBox.Show("Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Update;
                    _FinancialPenaltyID = _FinancialPenalty.PenaltyID;
                    frmAddUpdateFinancialPenaltys_Load(null, null);
                    DataBack?.Invoke(sender, _FinancialPenalty.PenaltyID);
                }
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(_FinancialPenalty.AmountSpentID.HasValue) 
            {
                frmAddUpdateAmountSpent frmAddUpdateAmountSpent = new frmAddUpdateAmountSpent(_FinancialPenalty.AmountSpentID.Value);
                frmAddUpdateAmountSpent.ShowDialog();
            }
            else
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmAddUpdateAmountSpent frmAddUpdateAmountSpent = new frmAddUpdateAmountSpent(double.Parse(txtCost.Text),true);
                frmAddUpdateAmountSpent.DataBack += DataBackAmountSpentID;
                frmAddUpdateAmountSpent.ShowDialog();
                  
            }
        }
    }
}
