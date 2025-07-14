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
    public partial class ctrlAllCustomerInformation : UserControl
    {
        public ctrlAllCustomerInformation()
        {
            InitializeComponent();
        }

        public void LoadCustomerAllInfo(int CustomerID) 
        {
            clsCustomer Customer;
            if ((Customer = clsCustomer.Find(CustomerID))!=null)
            {
                lblConsumedMileage.Text=Customer.TotalKilometersConsumed.ToString();
                lblGrossIncome.Text=Customer.TotalRentPayments.ToString();
                lblInitialDays.Text=Customer.TotalInitialRentalDays.ToString();
                lblTotalDaysRented.Text = Customer.TotalActualRentalDays.ToString();
                lblPaidInitialDueAmount.Text=Customer.PaidInitialTotalDueAmounts.ToString();
                lblTotalVehiclesBreakdownPayments.Text=Customer.TotalVehiclesBreakdownPayments.ToString() ;
                lblNumberRentedTransActions.Text=Customer.NumberRentedTransActions.ToString() ;
                lblTotalPayments.Text = Customer.TotalPayments.ToString() ;
                lblInitialTotalDueAmounts.Text=Customer.InitialTotalDueAmountsAfterTax.ToString() ;
                ctrlCustomerCard1.LoadCustomerInfo(CustomerID);
            }
            else
            {

            }
        }
        private void ctrlAllCustomerInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
