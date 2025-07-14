using CarRental.Checks;
using CarRental.Classes;
using CarRental.Vehicles;
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

namespace CarRental.Rental_Transaction
{
    public partial class ctrlRentalTransactionDetails : UserControl
    { 
        private clsRentalTransaction _rentalTransaction;
        private bool _PageRules;
        public int VehicleMileage { get { return ctrlShortDetailsVehicle1.SelectedVehicleInfo.Mileage; } }
        public clsRentalTransaction rentalTransactionSelected { get { return _rentalTransaction; } }
        private bool _VehicleEditeVisable;
        public bool VehicleEditeVisable 
        {
            set 
            {
                _VehicleEditeVisable = value;
                ctrlShortDetailsVehicle1.EditedVisible = _VehicleEditeVisable;
            }
            get
            {
                return _VehicleEditeVisable;
            }
        }
        public ctrlRentalTransactionDetails()
        {
            InitializeComponent();
        }
        public void DefaultValues()
        {
            lblActualTotalDueAmount.Text = string.Empty;
            lblAdditionalkilometerCharges.Text = string.Empty;
            lblFinalPaymentMethodID.Text = string.Empty;
            lblInitialPaymentMethodID.Text = string.Empty;
            lblPaidInitialTotalDueAmount.Text = string.Empty;
            lblTotalHourlyCharge.Text = string.Empty;
            lblTotalRefundedAmount.Text = string.Empty;
            lblTotalRemaining.Text = string.Empty;
            lblTransactionDate.Text = string.Empty;
            lblUpdatedTransactionDate.Text = string.Empty;
            lblUpdatedTransactionDate.Text=string.Empty;
            ctrlShortDetailsVehicle1.ResetVehicleInfo();
            ctrlCustomerCard1.ResetCustomerInfo();
            ctrlRentalBookingDetails2.ResetRentalBookingDetails();
            lblTax.Text = "";
            _rentalTransaction = null;
        }
        public void LoadRentalTransaction(int  transactionId)
        {
            if ((_rentalTransaction=clsRentalTransaction.Find(transactionId))!=null) 
            {
                ctrlShortDetailsVehicle1.ModeFind = ctrlShortDetailsVehicle.enModeFind.All;
                ctrlShortDetailsVehicle1.EditedVisible = false;  
                ctrlCustomerCard1.LoadCustomerInfo(_rentalTransaction.CustomerID);
                ctrlShortDetailsVehicle1.FindVehicle(_rentalTransaction.VehicleID);
                ctrlRentalBookingDetails2.LoadRentalBookingDetails(_rentalTransaction.BookingID);
                ctrlVehicleReturn1.LoadVehicleReturn(_rentalTransaction.ReturnID??-1);
                lblActualTotalDueAmount.Text=_rentalTransaction.ActualTotalDueAmount.ToString();   
                lblAdditionalkilometerCharges.Text=_rentalTransaction.AdditionalKilometerCharges.ToString();
                lblFinalPaymentMethodID.Text=_rentalTransaction.FinalPaymentMethodID.ToString();
                lblInitialPaymentMethodID.Text = clsPaymentMethod.Find( _rentalTransaction.InitialPaymentMethodID).PaymentMethod;
                lblPaidInitialTotalDueAmount.Text = _rentalTransaction.PaidInitialTotalDueAmount.ToString();
                lblTax.Text="%"+(_rentalTransaction.Vat*100-(100)).ToString();
                lblTotalHourlyCharge.Text=_rentalTransaction.TotalHourlyCharge.ToString();
                lblTotalRefundedAmount.Text = _rentalTransaction.TotalRefundedAmount.ToString();
                lblTotalRemaining.Text=_rentalTransaction.TotalRemaining.ToString();
                lblTransactionDate.Text= _rentalTransaction.TransactionDate.ToString("g");
                lblUpdatedTransactionDate.Text = _rentalTransaction.UpdatedTransactionDate.ToString();
                lblInitialTotalDueAmountAfterTax.Text = _rentalTransaction.InitialTotalDueAmountAfterTax.ToString();
                ctrlPrintContract1.LoadRentalBookingDetal(_rentalTransaction.TransactionID);
                ctrlPrintContract1.Enabled = true;
            }
            else
            {
                DefaultValues();
                MessageBox.Show("No Rental Booking with transactionId = " + transactionId.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void LoadRentalTransaction(string PlateNumber)
        {
            if ((_rentalTransaction = clsRentalTransaction.FindNewBooking(PlateNumber)) != null)
            {
                ctrlShortDetailsVehicle1.ModeFind = ctrlShortDetailsVehicle.enModeFind.All;
                ctrlShortDetailsVehicle1.EditedVisible = false;
                ctrlCustomerCard1.LoadCustomerInfo(_rentalTransaction.CustomerID);
                ctrlShortDetailsVehicle1.FindVehicle(_rentalTransaction.VehicleID);
                ctrlRentalBookingDetails2.LoadRentalBookingDetails(_rentalTransaction.BookingID);
                ctrlVehicleReturn1.LoadVehicleReturn(_rentalTransaction.ReturnID ?? -1);
                lblActualTotalDueAmount.Text = _rentalTransaction.ActualTotalDueAmount.ToString();
                lblAdditionalkilometerCharges.Text = _rentalTransaction.AdditionalKilometerCharges.ToString();
                lblFinalPaymentMethodID.Text = _rentalTransaction.FinalPaymentMethodID.ToString();
                lblInitialPaymentMethodID.Text = clsPaymentMethod.Find(_rentalTransaction.InitialPaymentMethodID).PaymentMethod;
                lblPaidInitialTotalDueAmount.Text = _rentalTransaction.PaidInitialTotalDueAmount.ToString();
                lblTax.Text = "%" + (_rentalTransaction.Vat * 100 - (100)).ToString();
                lblTotalHourlyCharge.Text = _rentalTransaction.TotalHourlyCharge.ToString();
                lblTotalRefundedAmount.Text = _rentalTransaction.TotalRefundedAmount.ToString();
                lblTotalRemaining.Text = _rentalTransaction.TotalRemaining.ToString();
                lblTransactionDate.Text = _rentalTransaction.TransactionDate.ToString("g");
                lblUpdatedTransactionDate.Text = _rentalTransaction.UpdatedTransactionDate.ToString();
                lblInitialTotalDueAmountAfterTax.Text = _rentalTransaction.InitialTotalDueAmountAfterTax.ToString();
                ctrlPrintContract1.LoadRentalBookingDetal(_rentalTransaction.TransactionID);
                ctrlPrintContract1.Enabled = true;
            }
            else
            {
                DefaultValues();
                MessageBox.Show("No Rental Booking with PlateNumber = " + PlateNumber, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
