using CarRental.Classes;
using CarRental.Vehicles.Forms;
using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.Vehicles
{
    public partial class ctrlVehicleWithFilter : UserControl
    {
        private ctrlShortDetailsVehicle.enModeFind _ModeFind;
        public ctrlShortDetailsVehicle.enModeFind ModeFind
        {
            set
            {
                _ModeFind = value;
                ctrlShortDetailsVehicle1.ModeFind=_ModeFind;
            }
            get 
            {
                return _ModeFind; 
            }   
        }

        public event Action<int> OnVehicleSelected;
        protected virtual void VehicleSelected(int PersonID)
        {
            Action<int> handler = OnVehicleSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        public ctrlVehicleWithFilter()
        {
            InitializeComponent();
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
                ctrlShortDetailsVehicle1.EditedVisible = _EditedVisible;
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

        public void ResetDefaultValues()
        {
            txtSearch.Text = "";
            FilterEnabled = true;
            cbFilterBy.SelectedIndex = 0;
            ctrlShortDetailsVehicle1.ResetVehicleInfo();
            txtSearch.Focus();
           
        }
        public void LoadVehicleInfo(int VehicleID)
        {

            cbFilterBy.SelectedIndex = 0;
            txtSearch.Text = VehicleID.ToString();
            FindNow();

        }
        public void LoadVehicleInfo(string PlateNumber)
        {

            cbFilterBy.SelectedIndex = 1;
            txtSearch.Text = PlateNumber.ToString();
            FindNow();

        }
        private void FindNow()
        {
            if (txtSearch.Text == "")
                return;
            switch (cbFilterBy.Text)
            {
                case "Vehicle ID":
                    ctrlShortDetailsVehicle1.FindVehicle(int.Parse(txtSearch.Text));

                    break;

                case "Plate Number":
                    ctrlShortDetailsVehicle1.FindVehicle(txtSearch.Text);
                    break;

                default:
                    break;
            }

            if (OnVehicleSelected != null && FilterEnabled&&ctrlShortDetailsVehicle1.SelectedVehicleInfo!=null)
                OnVehicleSelected(ctrlShortDetailsVehicle1.VehicleID);
        }
        public clsVehicle SelectedVehicle { get { return ctrlShortDetailsVehicle1.SelectedVehicleInfo; } }
        private void DataBack(object sender, int VehicleID)
        {
            frmSelectVehicle frm=(frmSelectVehicle)sender;
            frm.Close();
            txtSearch.Text = VehicleID.ToString();
            cbFilterBy.Text = "Vehicle ID";
            this.LoadVehicleInfo(VehicleID);
        }
        private void btnListVehicles_Click(object sender, EventArgs e)
        {
            if(this._ModeFind==ctrlShortDetailsVehicle.enModeFind.All|| this._ModeFind == ctrlShortDetailsVehicle.enModeFind.Available)
            {
                frmSelectVehicle frmSelectVehicle = new frmSelectVehicle(this._ModeFind);
                frmSelectVehicle.DataBack += DataBack;
                frmSelectVehicle.ShowDialog();

            }
            else
            {
                frmSelectVehicle frmSelectVehicle = new frmSelectVehicle(this._ModeFind, clsGlobal.Branch.BranchID);
                frmSelectVehicle.DataBack += DataBack;
                frmSelectVehicle.ShowDialog();
            }
;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindNow();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }
            if (cbFilterBy.Text == "VehicleID ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
