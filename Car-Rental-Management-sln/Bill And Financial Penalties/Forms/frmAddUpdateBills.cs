using CarRental.Classes;
using CarRental.Properties;
using CarRental_Business;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddUpdateBills : Form
    {
        public delegate void DataBackEventHandler(object sender, int BillID);
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _BillID;
        private clsBill _Bill;
        public frmAddUpdateBills(int BillID)
        {
            InitializeComponent();
            _BillID = BillID;
            _Mode = enMode.Update;
        }
        public frmAddUpdateBills()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        private void _LoadBillTypes()
        {
            cmbType.Items.Clear();
            foreach(DataRow row in clsTypesOfBill.GetAllTypesOfBills().Rows) 
            {
                cmbType.Items.Add(row[1]);
            }
        }
        private void _ResetDefaultValues()
        {
            _LoadBillTypes();
            llRemoveImage.Visible= false;   
            _Bill = new clsBill();
            txtCost.Text = string.Empty;
            txtDetails.Text = string.Empty;
            lblTitle.Text = "Add New Bill";
            llBillID.Text = "???";
            pbBillImage.Image = Resources.bill;
        }
        private void _LoadData()
        {
            _Bill = clsBill.Find(_BillID);
            if(_Bill == null) 
            {

                MessageBox.Show("Not found", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblTitle.Text = "Update Bill";
            llBillID.Text = _Bill.BillID.ToString();
            txtCost.Text = _Bill.Cost.ToString();
            txtDetails.Text = _Bill.Details.ToString();
            cmbType.Text=clsTypesOfBill.Find(_Bill.TypeID).Type;  
            if (_Bill.ImagePath != "")
            {
                pbBillImage.ImageLocation = _Bill.ImagePath;

            }
            llRemoveImage.Visible = (_Bill.ImagePath != "");
        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbBillImage.Load(selectedFilePath);
                string x = pbBillImage.ImageLocation.ToString();
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbBillImage.ImageLocation = null;
            pbBillImage.Image = Resources.bill;

            llRemoveImage.Visible = false;
        }
        private bool _HandleBillImage()
        {

            if (_Bill.ImagePath != pbBillImage.ImageLocation)
            {
                if (_Bill.ImagePath != "")
                {

                    try
                    {
                        File.Delete(_Bill.ImagePath);
                    }
                    catch (IOException)
                    {
                    }
                }

                if (pbBillImage.ImageLocation != null)
                {
                    string SourceImageFile = pbBillImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageBillsToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbBillImage.ImageLocation = SourceImageFile;
                        _Bill.ImagePath = pbBillImage.ImageLocation.ToString(); 
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
            if(_Bill.IsPaid)
            {
                MessageBox.Show("It is not possible to modify, the invoice has been paid", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!clsGlobal.IsBranchInformationAvailable)
            {
                MessageBox.Show("The branch is not recognized", "Branch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(clsGlobal.CurrentUser.IsAdmin&&clsGeneralFundBill.isGeneralFundBillExistByBillID(_Bill.BillID))
            {
                MessageBox.Show("You cannot update, the bill is with the administrator", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            if (!_HandleBillImage())
                return;
            _Bill.Cost=double.Parse(txtCost.Text);
            _Bill.Details=txtDetails.Text;
            _Bill.TypeID = clsTypesOfBill.Find(cmbType.Text).TypeID;
            _Bill.BranchID = clsGlobal.Branch.BranchID;
            if(_Mode==enMode.AddNew)
            {
                _Bill.CreatedByUserID=clsGlobal.CurrentUser.UserID;
                _Bill.CreatedDate = DateTime.Now;
            }
            if (_Mode == enMode.Update)
            {
                _Bill.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
                _Bill.UpdatedDate = DateTime.Now;
            }
            if(_Bill.Save())
            {

                MessageBox.Show("Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode=enMode.Update;
                _BillID = _Bill.BillID;
                frmAddUpdateBills_Load(null,null);
                DataBack?.Invoke(sender, _Bill.BillID);
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

        private void frmAddUpdateBills_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode==enMode.Update)
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
    }
}
