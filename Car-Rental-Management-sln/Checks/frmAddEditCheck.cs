using CarRental.Classes;
using CarRental.Properties;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.IO;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CarRental.Checks
{
    public partial class frmAddEditCheck : Form
    {
        public delegate void DataBackEventHandler(object sender, int CheckID, double? TotalCharges);
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _VehicleCheckID;
        private clsVehicleCheck _BookingCheck;
        private int _VehicleID;
        private clsVehicle _vehicle;
        private clsCheck _Check;
        private int _CheckID;

        public frmAddEditCheck(int VehicleID)
        {
            InitializeComponent();
            //_VehicleID = VehicleID;
            //if ((_BookingCheck = clsVehicleCheck.FindByVehicleID(VehicleID)) == null)
            //{
            //    _Mode = enMode.AddNew;
            //    _BookingCheck = new clsVehicleCheck();
            //}
            //else if (_BookingCheck.Status == clsVehicleCheck.enStatus.AddNewFinalCheck)
            //    _Mode = enMode.AddNew;
            //else
            //    _Mode = enMode.Update;
        }
        private void _LoadCheckImage()
        {
            pbFrontPart.Image = Resources.Car;
            string ImagePath = _Check.FrontPartImage;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbFrontPart.Load(ImagePath);
            pbBackPart.Image = Resources.Car;
            ImagePath = _Check.BackPartImage;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbBackPart.Load(ImagePath);

            pbRightPart.Image = Resources.Car;
            ImagePath = _Check.RightPartImage;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbRightPart.Load(ImagePath);

            pbLeftPart.Image = Resources.Car;
            ImagePath = _Check.LeftPartImage;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbLeftPart.Load(ImagePath);

            pbUpperBody.Image = Resources.Car;
            ImagePath = _Check.UpperBodyImage;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbUpperBody.Load(ImagePath);

            pbBag.Image = Resources.Car;
            ImagePath = _Check.BagImage;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbBag.Load(ImagePath);
        }
        public void LoadDataByCheckID()
        {
            //if (_BookingCheck.Status == clsVehicleCheck.Status.UpdateInitialCheck)
            //{
            //    lblModeTitle.Text = "Update Initial Check";
            //    _CheckID = _BookingCheck.InitialCheckID;
            //    ctrlCheckDetails1.Enabled = false;
            //    gbtxtCost.Visible = false;
            //    ctrlCheckDetails1.LoadCheckInfo(_CheckID);
            //    txtBackPartFee.Text = "0";
            //    txtFrontPartFee.Text = "0";
            //    txtLeftPartFee.Text = "0";
            //    txtUpperBodyFee.Text = "0";
            //    txtBagFee.Text = "0";
            //    txtRightPartFee.Text = "0";

            //}
            //else
            //{
            //    lblModeTitle.Text = "Update Final Check";
            //    _CheckID = _BookingCheck.FinalCheckID ?? -1;
            //    ctrlCheckDetails1.LoadCheckInfo(_BookingCheck.InitialCheckID);
            //}
            if ((_Check = clsCheck.Find(_CheckID)) != null)
            {
                //_vehicle = clsVehicle.Find(_Check.VehicleID);
                //lblVehicleName.Text = _vehicle.Name;
                _LoadCheckImage();
                cbFrontPart.Checked = _Check.FrontPart;
                txtFrontPart.Text = _Check.FrontPartNote;
                txtFrontPartFee.Text = _Check.FrontPartFee.ToString();
                cbRightPart.Checked = _Check.RightPart;
                txtRightPart.Text = _Check.RightNote;
                txtRightPartFee.Text = _Check.RightPartFee.ToString();
                cbLeftPart.Checked = _Check.LeftPart;
                txtLeftPart.Text = _Check.LeftNote;
                txtLeftPartFee.Text = _Check.LeftPartFee.ToString();
                cbBackPart.Checked = _Check.BackPart;
                txtBackPart.Text = _Check.BackNote;
                txtBackPartFee.Text = _Check.BackPartFee.ToString();
                cbUpperBody.Checked = _Check.UpperBody;
                txtUpperBody.Text = _Check.UpperBodyNote;
                txtUpperBodyFee.Text = _Check.UpperBodyFee.ToString();
                cbBag.Checked = _Check.Bag;
                txtBag.Text = _Check.BagNote;
                txtBagFee.Text = _Check.BagFee.ToString();

            }
        }
        //private void _ResetDefaultValues()
        //{
        //    ctrlCheckDetails1.gbAndtxtTotalCostVisible = false;
        //    _Check = new clsCheck();
        //    //if (_BookingCheck.Status == clsVehicleCheck.Status.AddNewInitialCheck)
        //    //{
        //    //    lblModeTitle.Text = "Add New Initial Check";
        //    //    ctrlCheckDetails1.Enabled = false;
        //    //    gbtxtCost.Visible = false;
        //    //    txtBackPartFee.Text = "0";
        //    //    txtFrontPartFee.Text = "0";
        //    //    txtLeftPartFee.Text = "0";
        //    //    txtUpperBodyFee.Text = "0";
        //    //    txtBagFee.Text = "0";
        //    //    txtRightPartFee.Text = "0";
        //    //}
        //    //else if (_BookingCheck.Status == clsVehicleCheck.Status.AddNewFinalCheck)
        //    //{
        //    //    lblModeTitle.Text = "Add New Final Check";
        //    //    ctrlCheckDetails1.LoadCheckInfo(_BookingCheck.InitialCheckID);
        //    //}

        //    if ((_vehicle = clsVehicle.Find(_VehicleID)) == null)
        //    {
        //        this.Close();
        //        return;
        //    }
        //    lblVehicleName.Text = _vehicle.Name;
        //}

        private bool _ImagesIsEmpty()
        {
            if (pbFrontPart.ImageLocation == null) return false;
            if (pbRightPart.ImageLocation == null) return false;
            if (pbLeftPart.ImageLocation == null) return false;
            if (pbUpperBody.ImageLocation == null) return false;
            if (pbBag.ImageLocation == null) return false;
            if (pbBackPart.ImageLocation == null) return false;
            return true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditCheck_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmBookingCheck))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            //_ResetDefaultValues();
            if (_Mode == enMode.Update)
                LoadDataByCheckID();
        }
        private bool _HandleVehicleImage()
        {
            string SourceImageFile = "";
            if (_Check.FrontPartImage != pbFrontPart.ImageLocation)
            {
                if (_Check.FrontPartImage != null)
                {

                    try
                    {
                        File.Delete(_Check.FrontPartImage);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbFrontPart.ImageLocation != null)
                {
                    SourceImageFile = pbFrontPart.ImageLocation.ToString();

                    if (clsUtil.CopyImageChecksToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbFrontPart.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            if (_Check.RightPartImage != pbRightPart.ImageLocation)
            {
                if (_Check.RightPartImage != null)
                {

                    try
                    {
                        File.Delete(_Check.RightPartImage);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbRightPart.ImageLocation != null)
                {
                    SourceImageFile = pbRightPart.ImageLocation.ToString();

                    if (clsUtil.CopyImageChecksToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbRightPart.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            if (_Check.LeftPartImage != pbLeftPart.ImageLocation)
            {
                if (_Check.LeftPartImage != null)
                {

                    try
                    {
                        File.Delete(_Check.LeftPartImage);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbLeftPart.ImageLocation != null)
                {
                    SourceImageFile = pbLeftPart.ImageLocation.ToString();

                    if (clsUtil.CopyImageChecksToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbLeftPart.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            if (_Check.UpperBodyImage != pbLeftPart.ImageLocation)
            {
                if (_Check.UpperBodyImage != null)
                {

                    try
                    {
                        File.Delete(_Check.UpperBodyImage);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbUpperBody.ImageLocation != null)
                {
                    SourceImageFile = pbUpperBody.ImageLocation.ToString();

                    if (clsUtil.CopyImageChecksToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbUpperBody.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            if (_Check.BackPartImage != pbBackPart.ImageLocation)
            {
                if (_Check.BackPartImage != null)
                {

                    try
                    {
                        File.Delete(_Check.BackPartImage);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbBackPart.ImageLocation != null)
                {
                    SourceImageFile = pbBackPart.ImageLocation.ToString();

                    if (clsUtil.CopyImageChecksToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbBackPart.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            if (_Check.BagImage != pbBag.ImageLocation)
            {
                if (_Check.BagImage != null)
                {

                    try
                    {
                        File.Delete(_Check.BagImage);
                    }
                    catch (IOException)
                    {

                    }
                }

                if (pbBag.ImageLocation != null)
                {
                    SourceImageFile = pbBag.ImageLocation.ToString();

                    if (clsUtil.CopyImageChecksToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbBag.ImageLocation = SourceImageFile;
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

        private void dgvCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ImagesIsEmpty())
            {
                MessageBox.Show("Make Sure You Enter All Images", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandleVehicleImage())
                return;

            _Check.FrontPartNote = txtFrontPart.Text.ToString().Trim();
            _Check.FrontPart = cbFrontPart.Checked;
            _Check.FrontPartImage = pbFrontPart.ImageLocation;
            _Check.FrontPartFee = double.Parse(txtFrontPartFee.Text.ToString());

            _Check.RightNote = txtRightPart.Text.ToString().Trim();
            _Check.RightPart = cbRightPart.Checked;
            _Check.RightPartImage = pbRightPart.ImageLocation;
            _Check.RightPartFee = double.Parse(txtRightPartFee.Text.ToString());


            _Check.LeftNote = txtLeftPart.Text.ToString().Trim();
            _Check.LeftPart = cbLeftPart.Checked;
            _Check.LeftPartImage = pbLeftPart.ImageLocation;
            _Check.LeftPartFee = double.Parse(txtLeftPartFee.Text.ToString());


            _Check.BackNote = txtBackPart.Text.ToString().Trim();
            _Check.BackPart = cbBackPart.Checked;
            _Check.BackPartImage = pbBackPart.ImageLocation;
            _Check.BackPartFee = double.Parse(txtBackPartFee.Text.ToString());


            _Check.UpperBodyNote = txtUpperBody.Text.ToString().Trim();
            _Check.UpperBody = cbUpperBody.Checked;
            _Check.UpperBodyImage = pbUpperBody.ImageLocation;
            _Check.UpperBodyFee = double.Parse(txtUpperBodyFee.Text.ToString());


            _Check.BagNote = txtBag.Text.ToString().Trim();
            _Check.Bag = cbBag.Checked;
            _Check.BagImage = pbBag.ImageLocation;
            _Check.BagFee = double.Parse(txtBagFee.Text.ToString());
            _Check.DateCheck = DateTime.Now;
            if (!_Check.Save())
            {
                return;
            }
            else
                _CheckID = _Check.CheckID();

            //if (_Mode == enMode.AddNew)
            //{
            //    if (_BookingCheck.Status == clsVehicleCheck.Status.AddNewInitialCheck)
            //    {
            //        _BookingCheck.InitialCheckID = _Check.CheckID();
            //        _BookingCheck.Status = clsVehicleCheck.Status.UpdateInitialCheck;
            //    }
            //    else if (_BookingCheck.Status == clsVehicleCheck.Status.AddNewFinalCheck)
            //    {
            //        _BookingCheck.Status = clsVehicleCheck.Status.UpdateInitialCheck;

            //        _BookingCheck.FinalCheckID = _Check.CheckID();
            //    }
            //}


            if (_BookingCheck.Save())
            {

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                
                LoadDataByCheckID();
                //DataBack?.Invoke(this, _BookingCheck.VehicleCheckID(),_Check.TotalCharges);
            }
        }

        private void dgvCheck_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }




        private void dgvCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dgvCheck_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvCheck_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvCheck_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
        }

        private void dgvCheck_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvCheck_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvCheck_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCheck_CellToolTipTextChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbFrontPart.Load(selectedFilePath);
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbRightPart.Load(selectedFilePath);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbLeftPart.Load(selectedFilePath);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbBackPart.Load(selectedFilePath);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbUpperBody.Load(selectedFilePath);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbBag.Load(selectedFilePath);
            }
        }

        private void txtFrontPartFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValidatePositiveDoubleNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text+e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);;
        }

        private void txtFrontPartFee_Validating(object sender, CancelEventArgs e)
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

        private void pbFrontPart_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            frmShowImage frm = new frmShowImage(pictureBox.ImageLocation);
            frm.Show();
        }
    }
}