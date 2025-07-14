using CarRental.Checks;
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

namespace CarRental.Bookings
{
    public partial class ctrlRentalBookingDetails : UserControl
    {
        private clsRentalBooking _RentalBooking;
        private float _TaxValue;
        public ctrlRentalBookingDetails()
        {
            InitializeComponent();
        }
        public void ResetRentalBookingDetails()
        {
            lblStartDate.Text = string.Empty;
            lblEndDate.Text = string.Empty;
            lblRentalPricePerDay.Text = string.Empty;
            lblPickupLocation.Text = string.Empty;
            lblInitialTotalDueAmountAfterTax.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblInitialRentalDays.Text = string.Empty;
            lblInitialTotalDueAmount.Text = string.Empty;
            llBookingCheck.Enabled = false;
            lblRentalPricePerHours.Text = string.Empty;
            lblRentalPricePerMileage.Text = string.Empty;   
            lblPricePerMonth.Text = string.Empty;   
        }
        private void ctrlRentalBookingDetails_Load(object sender, EventArgs e)
        {

            
        }
        public void LoadRentalBookingDetails(int RentalBooking)
        {
             if ((_RentalBooking = clsRentalBooking.Find(RentalBooking))!=null)
            {
                _TaxValue = clsRentalTransaction.GetVatBayBookingID(_RentalBooking.BookingID);
                llBookingCheck.Enabled = true;
                lblStartDate.Text = _RentalBooking.RentalStartDate.ToString("g");
                lblEndDate.Text = _RentalBooking.RentalEndDate.ToString("g");
                lblRentalPricePerDay.Text = _RentalBooking.RentalPricePerDay.ToString();
                lblPickupLocation.Text = clsBranch.Find(_RentalBooking.PickupBranchID).StreetName;
                lblInitialTotalDueAmountAfterTax.Text= (_RentalBooking.InitialTotalDueAmount*_TaxValue).ToString("0.00");
                lblTax.Text = "%"+(_TaxValue*100-(100)).ToString();
                lblInitialRentalDays.Text = _RentalBooking.InitialRentalDays.ToString();
                lblInitialTotalDueAmount.Text = _RentalBooking.InitialTotalDueAmount.ToString();
                lblFreeKilometersCredit.Text = _RentalBooking.FreeKilometersCredit.ToString();
                lblRentalPricePerHours.Text=_RentalBooking.RentalPricePerHours.ToString();
                lblRentalPricePerMileage.Text = _RentalBooking.RentalPricePerMileage.ToString();
                lblPricePerMonth.Text=_RentalBooking.RentalPricePerMonth.ToString();
            }
        }

        private void llBookingCheck_Click(object sender, EventArgs e)
        {

                if (_RentalBooking != null)
                {
                    frmShowBookingCheckDetails frmShow = new frmShowBookingCheckDetails(_RentalBooking.VehicleCheckID);
                    frmShow.ShowDialog();
                }

        }

        private void llBookingCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
