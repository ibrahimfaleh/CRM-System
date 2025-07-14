using CarRental.Customers;
using CarRental.People;
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
    public partial class ctrlCustomerCardWithFilter : UserControl
    {

        public event Action<bool> OnCustomerSelected;
        protected virtual void VehicleSelected(bool IsSelected)
        {
            Action<bool> handler = OnCustomerSelected;
            if (handler != null)
            {
                handler(IsSelected);
            }
        }


        private bool _ShowAddCustomer = true;
        public bool ShowAddCustomer
        {
            get
            {
                return _ShowAddCustomer;
            }
            set
            {
                _ShowAddCustomer = value;
                btnAddNewCustomer.Visible = _ShowAddCustomer;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public ctrlCustomerCardWithFilter()
        {
            InitializeComponent();
        }


        public int CustomerID
        {
            get { return ctrlCustomerCard1.CustomerID; }
        }

        public clsCustomer SelectedCustomerInfo
        {
            get { return ctrlCustomerCard1.SelectedCustomerInfo; }
        }

        public void LoadCustomerInfo(int CustomerID)
        {

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = CustomerID.ToString();
            FindNow();

        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Customer ID":
                    ctrlCustomerCard1.LoadCustomerInfo(int.Parse(txtFilterValue.Text));

                    break;

                case "Phone Number":
                    ctrlCustomerCard1.LoadCustomerInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnCustomerSelected != null && FilterEnabled)
                if(this.SelectedCustomerInfo!=null)
                    OnCustomerSelected(true);
                else OnCustomerSelected(false);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }


        private void ctrlCustomerCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();

        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;
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

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm1 = new frmAddUpdateCustomer();
            frm1.DataBack += DataBackEvent;
            frm1.ShowDialog();

        }

        private void DataBackEvent(object sender, int CustomerID)
        {

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = CustomerID.ToString();
            ctrlCustomerCard1.LoadCustomerInfo(CustomerID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
            if (cbFilterBy.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);



        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            FindNow();
        }

        private void ctrlCustomerCard1_Load(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
