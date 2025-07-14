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
    public partial class frmShowCustomerInfo : Form
    {
        int _CustomerID;
        public frmShowCustomerInfo(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        private void frmShowCustomerInfo_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmShowCustomerDetails))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlCustomerCard1.LoadCustomerInfo(_CustomerID);
            if(ctrlCustomerCard1.SelectedCustomerInfo==null)
            {
                this.Close();
                return;
            }
            lblDays.Text =ctrlCustomerCard1.SelectedCustomerInfo.TotalActualRentalDays.ToString();
            lblKl.Text=ctrlCustomerCard1.SelectedCustomerInfo.TotalKilometersConsumed.ToString();
            lblTotalPayments.Text =ctrlCustomerCard1.SelectedCustomerInfo.TotalPayments.ToString();
            lblTotalVehiclesBreakdownPayments.Text = ctrlCustomerCard1.SelectedCustomerInfo.TotalVehiclesBreakdownPayments.ToString();
            lblTotalRentPayments.Text = ctrlCustomerCard1.SelectedCustomerInfo.TotalRentPayments.ToString();
            lblNumberOfRented.Text=ctrlCustomerCard1.SelectedCustomerInfo.NumberRentedTransActions.ToString();  
            ctrlDgvListTransactions1.ShowCustomerVisible = false;
            ctrlDgvListTransactions1.ctrldgRentalBookingWithFalter_LoadByCustomerID(_CustomerID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
