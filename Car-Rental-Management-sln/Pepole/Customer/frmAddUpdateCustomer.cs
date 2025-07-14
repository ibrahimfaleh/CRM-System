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

namespace CarRental.Customers
{
    public partial class frmAddUpdateCustomer : Form
    {
        public delegate void DataBackEventHandler(object sender, int CustomerID);

        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _CustomerID = -1;
        clsCustomer _Customer;

        public frmAddUpdateCustomer()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _CustomerID = CustomerID;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Customer";
                this.Text = "Add New Customer";
                _Customer = new clsCustomer();

                tpLicenseNumber.Enabled = false;

                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update Customer";
                this.Text = "Update Customer";

                tpLicenseNumber.Enabled = true;
                btnSave.Enabled = true;


            }


        }

        private void _LoadData()
        {

            _Customer = clsCustomer.Find(_CustomerID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_Customer == null)
            {
                MessageBox.Show("No Customer with ID = " + _Customer, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            lblCustomerID.Text = _Customer.CustomerID().ToString();
            txtDriverLicenseNumber.Text =_Customer.DriverLicenseNumber.ToString();
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Customer.PersonID);
        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmAddUpdateCustomer))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Customer.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Customer.DriverLicenseNumber = txtDriverLicenseNumber.Text.Trim();


            if (_Customer.Save())
            {
                //change form mode to update.
                _Mode = enMode.Update;
                lblCustomerID.Text=_Customer.CustomerID().ToString();
                lblTitle.Text = "Update Customer";
                this.Text = "Update Customer";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Customer.CustomerID());
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }





        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLicenseNumber.Enabled = true;
                tcCustomerInfo.SelectedTab = tcCustomerInfo.TabPages["tpLicenseNumber"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)

            {

                if (clsCustomer.isCustomerExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a Customer, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tpLicenseNumber.Enabled = true;
                    tcCustomerInfo.SelectedTab = tcCustomerInfo.TabPages["tpLicenseNumber"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

            }

        }


        private void frmAddUpdateCustomer_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void txtDriverLicenseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDriverLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDriverLicenseNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDriverLicenseNumber, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDriverLicenseNumber, null);
            };
            if (_Mode == enMode.AddNew)
            {

                if (clsCustomer.isDriverLicenseNumberExist(txtDriverLicenseNumber.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtDriverLicenseNumber, "Driver License Number is used by another Customer");
                }
                else
                {
                    errorProvider1.SetError(txtDriverLicenseNumber, null);
                };
            }
        }

        private void txtDriverLicenseNumber_HideSelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
