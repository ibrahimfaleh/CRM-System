using CarRental.Classes;
using CarRental_Business;
using System.Windows.Forms;

namespace CarRental.Checks
{
    public partial class frmVehicleCheck : Form
    {
        public delegate void DataBackEventHandler(object sender, int VehicleCheckID);
        public delegate void DataBackEventHandlerCost(object sender, double TotalCost);
        public event DataBackEventHandler DataBack;
        public event DataBackEventHandlerCost DataBackCost;

        public enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        private int _VehicleCheckID;
        private clsVehicleCheck _VehicleCheck;
        private string _PlateNumber;
        public frmVehicleCheck(int VehicleCheckID)
        {
            InitializeComponent();
            _VehicleCheckID = VehicleCheckID;
            _Mode = enMode.Update;
        }
        public frmVehicleCheck(string PlateNumber)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _PlateNumber = PlateNumber;
        }
        private void _ResetDefaultValues()
        {
            _VehicleCheck = new clsVehicleCheck(); 
            txtFinalCheckID.Text = "";
            txtInitialCheck.Text = "";
            lblTitle.Text = "Add New Vehicle Check";
        }
        private void LoadData()
        {
            _VehicleCheck = clsVehicleCheck.Find(_VehicleCheckID);
            if (_VehicleCheck != null)
            {
                txtInitialCheck.Text = _VehicleCheck.InitialCheckID.ToString();
                if (_VehicleCheck.FinalCheckID.HasValue)
                    txtFinalCheckID.Text = _VehicleCheck.FinalCheckID.Value.ToString();
                lblTitle.Text = "Update Vehicle Check";
                llVehicleCheckID.Text = _VehicleCheck.VehicleCheckID.ToString();
                if(_VehicleCheck.Status==(byte)clsVehicleCheck.enStatus.InitialCheck)
                    txtInitialCheck.Focus();
                if (_VehicleCheck.Status == (byte)clsVehicleCheck.enStatus.FinalCheck)
                    txtFinalCheckID.Focus();
            }
            else
            {
                MessageBox.Show("Not Fund","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void frmVehicleCheck_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                LoadData();
        }

        private void DataBackInitialCheck(object sender ,int ID)
        {
            Form frm =(Form)sender;
            frm.Close();
            _VehicleCheck.InitialCheckID = ID;
            if(_VehicleCheck.Save())
            {
                _VehicleCheckID = _VehicleCheck.VehicleCheckID;
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _VehicleCheck.VehicleCheckID);
                frmVehicleCheck_Load(null,null);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void DataBackFinalCheckWithCost(object sender, int ID,double TotalCost)
        {
            Form frm = (Form)sender;
            frm.Close();
            _VehicleCheck.FinalCheckID = ID;
            if (_VehicleCheck.Save())
            {
                DataBackCost?.Invoke(this, TotalCost);
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmVehicleCheck_Load(null,null);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnAddUpdateInitialCheck_Click(object sender, System.EventArgs e)
        {
            if(_Mode==enMode.AddNew)
            {
                clsVehicle clsVehicle = clsVehicle.Find(clsFormat.DeleteAllSpaceFromText( _PlateNumber));

                if (clsVehicle == null)
                {
                    MessageBox.Show("Vehicle Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _VehicleCheck.VehicleID = clsVehicle.VehicleID;
            }
 
            if(_Mode == enMode.Update&&_VehicleCheck.Status==(byte)clsVehicleCheck.enStatus.InitialCheck)
            {
                frmAddUpdateInitialCheck frmAddUpdateInitialCheck = new frmAddUpdateInitialCheck(_VehicleCheck.InitialCheckID);
                frmAddUpdateInitialCheck.DataBack += DataBackInitialCheck;
                frmAddUpdateInitialCheck.ShowDialog();
            }
            else if(_Mode == enMode.AddNew) 
            {
                frmAddUpdateInitialCheck frmAddUpdateInitialCheck = new frmAddUpdateInitialCheck();
                frmAddUpdateInitialCheck.DataBack += DataBackInitialCheck;
                frmAddUpdateInitialCheck.ShowDialog();
            }
        }

        private void btnAddUpdateFinalCheck_Click(object sender, System.EventArgs e)
        {
            if (_Mode == enMode.Update&&_VehicleCheck.Status==(byte)clsVehicleCheck.enStatus.FinalCheck)
            {
                if(_VehicleCheck.FinalCheckID.HasValue)
                {
                    frmAddUpdateFinalCheck frmAddUpdateFinalCheck = new frmAddUpdateFinalCheck(_VehicleCheck.FinalCheckID.Value);
                    frmAddUpdateFinalCheck.DataBackFinalCheckWithCost += DataBackFinalCheckWithCost;
                    frmAddUpdateFinalCheck.ShowDialog();
                }
                else
                {
                    frmAddUpdateFinalCheck frmAddUpdateFinalCheck = new frmAddUpdateFinalCheck();
                    frmAddUpdateFinalCheck.DataBackFinalCheckWithCost += DataBackFinalCheckWithCost;
                    frmAddUpdateFinalCheck.ShowDialog();
                }

            }
        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                frmShowBookingCheckDetails frmShow = new frmShowBookingCheckDetails(_VehicleCheck.VehicleCheckID);
                frmShow.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();   
        }
    }
}
