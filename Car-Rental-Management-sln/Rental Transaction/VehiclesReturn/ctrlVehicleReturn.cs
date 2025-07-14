using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.Rental_Transaction.VehiclesReturn
{
    public partial class ctrlVehicleReturn : UserControl
    {
        clsVehicleReturn _VehicleReturn;
        public ctrlVehicleReturn()
        {
            InitializeComponent();
        }
        private void _DefaultValues()
        {
            lblActualRentalDays.Text = "?????";
            lblActualReturnDate.Text = "?????"; 
            lblAdditionalCharges.Text = "?????";
            lblAdditionalHours.Text = "?????";
            lblAdditionalKilometer.Text = "?????";
            lblConsumedMileage.Text = "?????";
            lblMileage.Text = "?????";
        }
        public void LoadVehicleReturn(int VehicleReturnID)
        {
            if ((_VehicleReturn = clsVehicleReturn.Find(VehicleReturnID)) != null)
            {
                lblActualRentalDays.Text = _VehicleReturn.ActualRentalDays.ToString();
                lblActualReturnDate.Text = _VehicleReturn.ActualReturnDate.ToString("g");
                lblAdditionalCharges.Text = _VehicleReturn.AdditionalCharges.ToString();
                lblAdditionalHours.Text = _VehicleReturn.AdditionalHours.ToString();
                lblAdditionalKilometer.Text = _VehicleReturn.AdditionalKilometer.ToString();
                lblConsumedMileage.Text = _VehicleReturn.ConsumedMileage.ToString();
                lblMileage.Text = _VehicleReturn.Mileage.ToString();
            }
            else
                _DefaultValues();
        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ctrlVehicleReturn_Load(object sender, EventArgs e)
        {

        }
    }
}
