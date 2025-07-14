using CarRental.Classes;
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
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using CarRental.Contacts.Forms;

namespace CarRental.company_information
{
    public partial class frmCompanyInformation : Form
    {
        public frmCompanyInformation()
        {
            InitializeComponent();
        }
        private void _LoadCompanyContactNumbers()
        {
            DataTable dt =clsCompanyContactNumber.GetAllCompanyContactNumbers();
            dgvCompanyContactNumbers.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgvCompanyContactNumbers.Columns[0].HeaderText = "Contact ID";
                dgvCompanyContactNumbers.Columns[0].Width = 100;

                dgvCompanyContactNumbers.Columns[1].HeaderText = "Number";
                dgvCompanyContactNumbers.Columns[1].Width = 250;

                dgvCompanyContactNumbers.Columns[2].HeaderText = "Type";
                dgvCompanyContactNumbers.Columns[2].Width = 150;
                lblRecordsCount.Text = dgvCompanyContactNumbers.Rows.Count.ToString();
            }
            else
                lblRecordsCount.Text = "0";
        }
        private void _LoadData()
        {
            txtCompanyName.Text = clsGlobal.CurrentCompany.Name;
            txtEmail.Text=clsGlobal.CurrentCompany.Email;
            _LoadCompanyLogo();
            _LoadCompanyContactNumbers();
        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbCompanyLogo.Load(selectedFilePath);
                llRemoveImage.Visible = true;
            }
        }
        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbCompanyLogo.ImageLocation = null;

            pbCompanyLogo.Image = Resources.photoEmpty1;

            llRemoveImage.Visible = false;
        }
        private void _LoadCompanyLogo()
        {
            pbCompanyLogo.Image = Resources.photoEmpty1;
            string ImagePath = clsGlobal.CurrentCompany.LogoPath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbCompanyLogo.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool _HandleCompanyLogo()
        {
            if (clsGlobal.CurrentCompany.LogoPath != pbCompanyLogo.ImageLocation)
            {
                if (clsGlobal.CurrentCompany.LogoPath != "")
                {
                    try
                    {
                        File.Delete(clsGlobal.CurrentCompany.LogoPath);
                    }
                    catch (IOException)
                    {

                    }
                }
                if (pbCompanyLogo.ImageLocation != null)
                {
                    string SourceImageFile = pbCompanyLogo.ImageLocation.ToString();

                    if (clsUtil.CopyLogoCompanyToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbCompanyLogo.ImageLocation = SourceImageFile;
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
        private void frmCompanyInformation_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleCompanyLogo())
                return;
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pbCompanyLogo.ImageLocation != null)
                clsGlobal.CurrentCompany.LogoPath = pbCompanyLogo.ImageLocation;
            clsGlobal.CurrentCompany.Name=txtCompanyName.Text;
            clsGlobal.CurrentCompany.Email=txtEmail.Text;   
            if(clsGlobal.CurrentCompany.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadData();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void addNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCompanyContactNumbers frmAddUpdateCompanyContactNumbers = new frmAddUpdateCompanyContactNumbers();
            frmAddUpdateCompanyContactNumbers.ShowDialog();
            _LoadCompanyContactNumbers();
        }
        private void updateNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCompanyContactNumbers frmAddUpdateCompanyContactNumbers = new frmAddUpdateCompanyContactNumbers((int)dgvCompanyContactNumbers.CurrentRow.Cells[0].Value);
            frmAddUpdateCompanyContactNumbers.ShowDialog();
            _LoadCompanyContactNumbers();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsCompanyContactNumber.DeleteCompanyContactNumber((int)dgvCompanyContactNumbers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadCompanyContactNumbers();
            }
            else
                MessageBox.Show("Not Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            frmAddUpdateCompanyContactNumbers frmAddUpdateContact = new frmAddUpdateCompanyContactNumbers();
            frmAddUpdateContact.ShowDialog();
            _LoadCompanyContactNumbers();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Items[1].Visible=(dgvCompanyContactNumbers.Rows.Count>0);
            contextMenuStrip1.Items[2].Visible=(dgvCompanyContactNumbers.Rows.Count>0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
