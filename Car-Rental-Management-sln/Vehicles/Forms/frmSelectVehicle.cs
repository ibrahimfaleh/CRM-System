using CarRental_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Vehicles.Forms
{
    public partial class frmSelectVehicle : Form
    {
        public delegate void DataBackEventHandler(object sender, int EmployeeID);
        public event DataBackEventHandler DataBack;
        private DataTable _dtVehicle;
        private int? _BranchID;
        private ctrlShortDetailsVehicle.enModeFind _Mode;
        public frmSelectVehicle(ctrlShortDetailsVehicle.enModeFind modeFind,int?BranchID=null)
        {
            InitializeComponent();
            _Mode = modeFind;
            _BranchID=BranchID;
        }
        private void _LoadColumns()
        {
            if (_dtVehicle.Columns.Count > 0)
            {
                dgv.DataSource = _dtVehicle;
                dgv.Columns[0].HeaderText = "Vehicle ID";
                dgv.Columns[0].Width = 100;

                dgv.Columns[1].HeaderText = "Name";
                dgv.Columns[1].Width = 200;

                dgv.Columns[2].HeaderText = "Year";
                dgv.Columns[2].Width = 100;

                dgv.Columns[3].HeaderText = "Mileage";
                dgv.Columns[3].Width = 190;

                dgv.Columns[4].HeaderText = "Price Per Day";
                dgv.Columns[4].Width = 190;

                dgv.Columns[5].HeaderText = "Price Per Month";
                dgv.Columns[5].Width = 190;
            }
        }
        private void _LoadData()
        {
            switch(_Mode)
            {
                case ctrlShortDetailsVehicle.enModeFind.All:
                    _dtVehicle=clsVehicle.GetAllVehiclesForSelect();
                    break;
                case ctrlShortDetailsVehicle.enModeFind.Available:
                    _dtVehicle = clsVehicle.GetAllVehiclesForSelect(true);
                    break;
                case ctrlShortDetailsVehicle.enModeFind.AllByBranchID:
                    if(_BranchID.HasValue)
                    _dtVehicle = clsVehicle.GetAllVehiclesForSelect(_BranchID.Value);
                    else
                        MessageBox.Show("You must log in to the branch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ctrlShortDetailsVehicle.enModeFind.FindAvailableAndBranchID:
                    if (_BranchID.HasValue)
                        _dtVehicle = clsVehicle.GetAllVehiclesForSelect(_BranchID.Value,true);
                    else
                        MessageBox.Show("You must log in to the branch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            _LoadColumns();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
        private void _FilterVehicle()
        {
            string query = "";
            if (txtFilterValue.Text.Length > 0)
            {
                switch (cbFilterBy.Text)
                {
                    case "Vehicle ID":
                        if (query != "")
                            query += " And (VehicleID = " + txtFilterValue.Text + ") ";
                        else
                            query += " VehicleID = " + txtFilterValue.Text + " ";
                        break;

                    case "Name":
                        if (query != "")
                            query += " And (Name like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  Name like '" + txtFilterValue.Text + "%' ";
                        break;
                }
                if (query != "")
                {
                    if (_dtVehicle.Rows.Count < 1)
                        return;
                    _dtVehicle.DefaultView.RowFilter = query;

                }
                else
                    _dtVehicle.DefaultView.RowFilter = "";
            }
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Vehicle ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicle();
        }
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBack.Invoke(this, (int)dgv.CurrentRow.Cells[0].Value);
        }
        private void dgvListOfContracts_DoubleClick(object sender, EventArgs e)
        {
            DataBack.Invoke(this, (int)dgv.CurrentRow.Cells[1].Value);
        }
        private void frmSelectVehicle_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
