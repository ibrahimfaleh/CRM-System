using CarRental.Properties;
using CarRental_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using CarRental.Classes;
using Microsoft.AnalysisServices.Tabular;
using Guna.UI2.WinForms;
using System.Diagnostics.Eventing.Reader;

namespace CarRental.Checks
{
    public partial class frmAddUpdateInitialCheck : Form
    {
        public  delegate void DataBackEventHandler(object sender, int CheckID);
        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew=1, Update=2}
        protected enMode _Mode;
        protected int _CheckID;
        protected clsCheck _Check;
        public frmAddUpdateInitialCheck(int CheckID)
        {
            InitializeComponent();
            _CheckID = CheckID;
            _Mode = enMode.Update;
        }
        public frmAddUpdateInitialCheck()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        private  void _ResetDefaultValues()
        {
            _Check = new clsCheck();
            lblCheckDate.Text = "";
            txtFrontPart.Text = "";
            txtLeftPart.Text = "";
            txtRightPart.Text = "";
            txtRightPart.Text = "";
            txtUpperBody.Text = "";
            txtBag.Text = "";
            cbBackPart.Checked = false;
            cbFrontPart.Checked = false;
            cbUpperBody.Checked = false;
            cbLeftPart.Checked = false;
            cbRightPart.Checked = false;
            cbBag.Checked = false;
            pbFrontPart.Image = Resources.Car;
            pbRightPart.Image = Resources.Car;
            pbLeftPart.Image = Resources.Car;
            pbBackPart.Image = Resources.Car;
            pbUpperBody.Image = Resources.Car;
            pbBag.Image = Resources.Car;
            lblTitle.Text = "Add New Initial Check";
        }
        private  void _LoadData()
        {
            _Check = clsCheck.Find(_CheckID);
            if(_Check != null ) 
            {
                cbFrontPart.Checked = _Check.FrontPart;
                txtFrontPart.Text = _Check.FrontPartNote;
                pbFrontPart.Image = Resources.Car;
                string ImagePath = _Check.FrontPartImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbFrontPart.Load(ImagePath);

                cbRightPart.Checked = _Check.RightPart;
                txtRightPart.Text = _Check.RightNote;
                pbRightPart.Image = Resources.Car;
                ImagePath = _Check.RightPartImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbRightPart.Load(ImagePath);

                cbLeftPart.Checked = _Check.LeftPart;
                txtLeftPart.Text = _Check.LeftNote;
                pbLeftPart.Image = Resources.Car;
                ImagePath = _Check.LeftPartImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbLeftPart.Load(ImagePath);

                cbBackPart.Checked = _Check.BackPart;
                txtBackPart.Text = _Check.BackNote;
                pbBackPart.Image = Resources.Car;
                ImagePath = _Check.BackPartImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbBackPart.Load(ImagePath);

                cbUpperBody.Checked = _Check.UpperBody;
                txtUpperBody.Text = _Check.UpperBodyNote;
                pbUpperBody.Image = Resources.Car;
                ImagePath = _Check.UpperBodyImage;
                if (ImagePath != "")
                    if (File.Exists(ImagePath))
                        pbUpperBody.Load(ImagePath);

                cbBag.Checked = _Check.Bag;
                txtBag.Text = _Check.BagNote;
                pbBag.Image = Resources.Car;
                ImagePath = _Check.BagImage;

                if (ImagePath != "")

                    if (File.Exists(ImagePath))
                        pbBag.Load(ImagePath);

                lblCheckDate.Text = _Check.DateCheck.ToString("d");



                lblTitle.Text = "Update Initial Check";
            }
            else
            {
                MessageBox.Show("Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

        }
        private  void frmAddUpdateInitialCheck_Load(object sender, EventArgs e)
        {
            //if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmBookingCheck))
            //{
            //    MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //    return;
            //}
            _ResetDefaultValues();
            if(_Mode==enMode.Update)
                _LoadData();
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
        protected virtual void DataBackEvent()
        {
            DataBack?.Invoke(this, _Check.CheckID());
        }
        protected virtual  void btnSave_Click(object sender, EventArgs e)
        {
            if (!pbImageEmpty_Validating())
                return;
            if (!_HandleVehicleImage())
                return;
            _Check.FrontPartNote = txtFrontPart.Text.ToString().Trim();
            _Check.FrontPart = cbFrontPart.Checked;
            _Check.FrontPartImage = pbFrontPart.ImageLocation;

            _Check.RightNote = txtRightPart.Text.ToString().Trim();
            _Check.RightPart = cbRightPart.Checked;
            _Check.RightPartImage = pbRightPart.ImageLocation;


            _Check.LeftNote = txtLeftPart.Text.ToString().Trim();
            _Check.LeftPart = cbLeftPart.Checked;
            _Check.LeftPartImage = pbLeftPart.ImageLocation;


            _Check.BackNote = txtBackPart.Text.ToString().Trim();
            _Check.BackPart = cbBackPart.Checked;
            _Check.BackPartImage = pbBackPart.ImageLocation;


            _Check.UpperBodyNote = txtUpperBody.Text.ToString().Trim();
            _Check.UpperBody = cbUpperBody.Checked;
            _Check.UpperBodyImage = pbUpperBody.ImageLocation;


            _Check.BagNote = txtBag.Text.ToString().Trim();
            _Check.Bag = cbBag.Checked;
            _Check.BagImage = pbBag.ImageLocation;
            _Check.DateCheck = DateTime.Now;

            if (_Check.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _CheckID = _Check.CheckID();
                _Mode = enMode.Update;
                DataBackEvent();
                frmAddUpdateInitialCheck_Load(null, null);
            }else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void pbFrontPart_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            frmShowImage frm = new frmShowImage(pictureBox.ImageLocation);
            frm.Show();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        protected void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private bool pbImageEmpty_Validating()
        {
            if (pbFrontPart.ImageLocation ==null)
            {
                errorProvider1.SetError(pbFrontPart, "This field is required!");
                return false;
            }
            else
                errorProvider1.SetError(pbFrontPart, null);

            if (pbLeftPart.ImageLocation == null)
            {
                errorProvider1.SetError(pbLeftPart, "This field is required!");
                return false;
            }
            else
                errorProvider1.SetError(pbLeftPart, null);

            if (pbBackPart.ImageLocation == null)
            {
                errorProvider1.SetError(pbBackPart, "This field is required!");
                return false;
            }
            else
                errorProvider1.SetError(pbBackPart, null);

            if (pbBag.ImageLocation == null)
            {
                errorProvider1.SetError(pbBag, "This field is required!");
                return false;
            }
            else
                errorProvider1.SetError(pbBag, null);

            if (pbRightPart.ImageLocation == null)
            {
                errorProvider1.SetError(pbRightPart, "This field is required!");
                return false;
            }
            else
                errorProvider1.SetError(pbRightPart, null);

            if (pbUpperBody.ImageLocation == null)
            {
                errorProvider1.SetError(pbUpperBody, "This field is required!");
                return false;
            }
            else
                errorProvider1.SetError(pbUpperBody, null);

            return true;
        }
    }
}
