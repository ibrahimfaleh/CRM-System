using CarRental.Classes;
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

namespace CarRental.Contacts.Forms
{
    public partial class frmAddUpdateCompanyContactNumbers : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _ContactID;
        private clsCompanyContactNumber _Contact;
        public frmAddUpdateCompanyContactNumbers(int ContactId)
        {
            InitializeComponent();
            _ContactID = ContactId;
            _Mode = enMode.Update;
        }
        public frmAddUpdateCompanyContactNumbers()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        private void _ResetDefaultValues()
        {
            lblTitle.Text = "Add New Contact Number";
            _Contact = new clsCompanyContactNumber();
            txtNumber.Text = "";
            cmbType.SelectedIndex = 0;
        }
        private void _LoadData()
        {
            _Contact = clsCompanyContactNumber.Find(_ContactID);
            if( _Contact != null )
            {
                lblTitle.Text = "Update Contact Number";
                txtNumber.Text = _Contact.Number;
                cmbType.Text = _Contact.GetTypeName;
            }
            else
            {
                MessageBox.Show("Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddUpdateContact_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
                _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Contact.CompanyID = clsGlobal.CurrentCompany.CompanyID;
            _Contact.Number = txtNumber.Text;
            switch(cmbType.Text)
            {
                case "Phone":
                    _Contact.Type = (byte)clsCompanyContactNumber.enType.Phone;
                    break;
                case "Telephone":
                    _Contact.Type = (byte)clsCompanyContactNumber.enType.Telephone;
                    break;
                case "Fax":
                    _Contact.Type = (byte)clsCompanyContactNumber.enType.Fax;
                    break;
            }
            if(_Contact.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ContactID = _Contact.ContactNumberID;
                _Mode=enMode.Update;
                frmAddUpdateContact_Load(null,null);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNumber, "Write Number");
            }
            else
                errorProvider1.SetError(txtNumber, null);
        }
    }
}
