using CarRental.Classes;
using CarRental.Properties;
using CarRental.Vehicles.Forms;
using CarRental_Business;
using System;
using System.IO;
using System.Windows.Forms;
using static CarRental.Vehicles.ctrlVehicleWithFilter;

namespace CarRental.Vehicles
{

    public partial class ctrlShortDetailsVehicle : UserControl
    {
        public enum enModeFind { All = 1, AllByBranchID = 2, FindAvailableAndBranchID = 3, Available = 4 }
        public enModeFind ModeFind { set; get; }
        public event Action<bool> OnVehicleSelected;
        protected virtual void VehicleSelected(bool IsSelected)
        {
            Action<bool> handler = OnVehicleSelected;
            if (handler != null)
            {
                handler(IsSelected);
            }
        }
        private clsVehicle _Vehicle;

        private int _VehicleID;

        public int VehicleID
        {
            get { return _VehicleID; }
        }

        public clsVehicle SelectedVehicleInfo
        {
            get { return _Vehicle; }
        }
        private bool _EditedVisible = false;
        public bool EditedVisible
        {
            get
            {
                return _EditedVisible;
            }
            set
            {
                _EditedVisible = value;
                llEditeVehicle.Visible = _EditedVisible;
            }
        }
        public void ResetVehicleInfo()
        {

            pbVehicleImage.Image = Resources.Car;
            llEditeVehicle.Visible = false;
            lblBodie.Text = string.Empty;
            lblDriveType.Text = string.Empty;
            lblName.Text = string.Empty;
            lblMileage.Text = string.Empty;
            lblPlateNumber.Text = string.Empty;
            lblRentalPeicePerDay.Text = string.Empty;
            lblRentalPricePerMileage.Text = string.Empty;
            lblYear.Text = string.Empty;
            lblVehicleID.Text = string.Empty;
            cbIsActive.Checked = false;
            lblTitleModel.Text = string.Empty;
            lblRentalPricePerHours.Text = string.Empty;
            cbIsAvailableForRental.Checked = false;
            lblPriceBerMonth.Text = string.Empty;   
            _Vehicle = null;

        }
        public ctrlShortDetailsVehicle()
        {
            InitializeComponent();
        }
        public void FindVehicle(int VehicleID)
        {
            switch (ModeFind)
            {
                case enModeFind.All:
                    _Vehicle = clsVehicle.Find(VehicleID);
                    break;
                case enModeFind.AllByBranchID:
                    _Vehicle = clsVehicle.Find(VehicleID,clsGlobal.Branch.BranchID);
                    break;
                case enModeFind.Available:
                    _Vehicle = clsVehicle.Find(VehicleID,true);
                    break;
                case enModeFind.FindAvailableAndBranchID:
                    _Vehicle = clsVehicle.Find(VehicleID,clsGlobal.Branch.BranchID, true);
                    break;
            }
            _LoadVehicle();
        }
        public void FindVehicle(string  PlateNumber)
        {
            switch (ModeFind)
            {
                case enModeFind.All:
                    _Vehicle = clsVehicle.Find(PlateNumber);
                    break;
                case enModeFind.AllByBranchID:
                    _Vehicle = clsVehicle.Find(PlateNumber,clsGlobal.Branch.BranchID);
                    break;
                case enModeFind.Available:
                    _Vehicle = clsVehicle.Find(PlateNumber, true);
                    break;
                case enModeFind.FindAvailableAndBranchID:
                    _Vehicle = clsVehicle.Find(PlateNumber,clsGlobal.Branch.BranchID, true);
                    break;
            }
            _LoadVehicle();
        }
        private void _LoadVehicle()
        {

            if (_Vehicle == null)
            {
                ResetVehicleInfo();
                MessageBox.Show("Vehicle not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _VehicleID = VehicleID;
            _FillVehicleInfo();
            if (OnVehicleSelected != null)
                if (this.SelectedVehicleInfo != null)
                    OnVehicleSelected(true);
                else
                    OnVehicleSelected(true);
        }
        private void _LoadVehicleImage()
        {
            pbVehicleImage.Image = Resources.Car;
            string ImagePath = _Vehicle.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbVehicleImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _FillVehicleInfo()
        {
            if (_Vehicle != null)
            {
                lblPriceBerMonth.Text = _Vehicle.RentalPricePerMonth.ToString();
                _VehicleID = _Vehicle.VehicleID;
                llEditeVehicle.Visible = true;
                lblVehicleID.Text = _Vehicle.VehicleID.ToString();
                lblName.Text = _Vehicle.Name;
                lblMileage.Text = _Vehicle.Mileage.ToString();
                lblBodie.Text = _Vehicle.BodieInfo.BodyName;
                lblDriveType.Text = _Vehicle.DriveTypeInfo.DriveTypeName;
                lblPlateNumber.Text = clsFormat.ConvertTextIntoLetters(_Vehicle.PlateNumber);
                lblRentalPeicePerDay.Text = _Vehicle.RentalPricePerDay.ToString();
                lblTitleModel.Text = _Vehicle.MakeModelInfo.ModelName;
                lblRentalPricePerMileage.Text = _Vehicle.RentalPricePerMileage.ToString();
                cbIsActive.Checked = _Vehicle.IsActive;
                cbIsAvailableForRental.Checked = _Vehicle.IsAvailableForRental;
                lblYear.Text = _Vehicle.Year.ToString();
                lblRentalPricePerHours.Text = _Vehicle.RentalPricePerHours.ToString();
                _LoadVehicleImage();
            }
        }
        private void ctrlShortDetailsVehicle_Load(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void llEditeVehicle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle(_VehicleID);
            frm.ShowDialog();
            FindVehicle(_VehicleID);
        }

        private void cbIsActive_Click(object sender, EventArgs e)
        {
            cbIsActive.Checked = _Vehicle.IsActive;
        }

        private void cbIsAvailableForRental_Click(object sender, EventArgs e)
        {
            cbIsAvailableForRental.Checked = _Vehicle.IsAvailableForRental;
        }
    }
}
