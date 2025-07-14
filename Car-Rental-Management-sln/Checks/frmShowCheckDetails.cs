using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.Checks
{
    public partial class frmShowBookingCheckDetails : Form
    {
        private clsVehicleCheck _Check;
        private int _VehicleCheckID;
        public frmShowBookingCheckDetails(int VehicleCheckID)
        {
            InitializeComponent();
            _VehicleCheckID = VehicleCheckID;
        }

        private void frmShowBookingCheckDetails_Load(object sender, EventArgs e)
        {
            if ((_Check = clsVehicleCheck.Find(_VehicleCheckID)) == null)
                this.Close();
            ctrlInitialCheckDetails1.LoadCheckInfo(_Check.InitialCheckID);
            if(_Check.FinalCheckID.HasValue)
            ctrlFinalCheckDetails1.LoadCheckInfo(_Check.FinalCheckID.Value);
            else
                ctrlFinalCheckDetails1.Enabled= false;  

        }

        private void ctrlInitialCheckDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
