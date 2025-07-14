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

namespace CarRental
{
    public partial class ctrlCustomerCard : UserControl
    {
        private clsCustomer _Customer;

        private int _CustomerID = -1;

        public int CustomerID
        {
            get { return _CustomerID; }
        }
        private bool _EditedVisible = true;
        public bool EditedVisible
        {
            get
            {
                return _EditedVisible;
            }
            set
            {
                _EditedVisible = value;
                ctrlPersoneCard1.EditedVisible = _EditedVisible;
            }
        }
        public clsCustomer SelectedCustomerInfo
        {
            get { return _Customer; }
        }
        public ctrlCustomerCard()
        {
            InitializeComponent();
        }

        private void _FillCustomerInfo()
        {
            if (_Customer != null)
            {
                _CustomerID = _Customer.CustomerID();
                lblCustomerID.Text = _Customer.CustomerID().ToString();
                lblDriverLicenseNumber.Text = _Customer.DriverLicenseNumber;
                ctrlPersoneCard1.LoadPersonInfo(_Customer.PersonID);
            }
        }

        public void LoadCustomerInfo(int CustomerID)
        {
            _Customer = clsCustomer.Find(CustomerID);
            if (_Customer == null)
            {
                ResetCustomerInfo();
                MessageBox.Show("No Customer with CustomerID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillCustomerInfo();
        }
        public void LoadCustomerInfo(string Phone)
        {
            _Customer = clsCustomer.Find(Phone);
            if (_Customer == null)
            {
                ResetCustomerInfo();
                MessageBox.Show("No Customer with Phone = " + Phone.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillCustomerInfo();
        }

        public void ResetCustomerInfo()
        {
            lblCustomerID.Text = "????";
            lblDriverLicenseNumber.Text = "????";
            ctrlPersoneCard1.ResetPersonInfo();
        }

        private void ctrlPersoneCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
