using CarRental.Classes;
using CarRental.Vehicles.Forms;
using CarRental_Business;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Vehicles
{
    public partial class frmListVehicels : Form
    {
        public delegate void DataBackEventHandler(object sender, int VehicleID);
        public event DataBackEventHandler DataBack;
        private static DataTable _dtVehicles;
        private int? _BranchID;
        public frmListVehicels(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
        }
        public frmListVehicels()
        {
            InitializeComponent();
        }
        private void LoadCities()
        {
            cmbCityName.Items.Clear();
            cmbCityName.Items.Add("All");
            foreach (DataRow row in clsCity.GetAllCities().Rows)
            {
                cmbCityName.Items.Add(row[1]);
            }

        }
        private void _LoadBranches(string CityName)
        {
            cmbBranches.Items.Clear();
            cmbBranches.Items.Add("All");
            if (CityName == "All")
                return;
            foreach (DataRow row in clsBranch.GetAllBranches(CityName).Rows)
            {
                cmbBranches.Items.Add(row[2]);
            }
        }
        private void _LoadDataGridViewForVehicleManagement()
        {
            dgvListVehicles.DataSource = _dtVehicles;
            if (_dtVehicles.Columns.Count > 0)
            {
                dgvListVehicles.Columns[0].HeaderText = "City Name";
                dgvListVehicles.Columns[0].Width = 150;

                dgvListVehicles.Columns[1].HeaderText = "Street Name";
                dgvListVehicles.Columns[1].Width = 150;

                dgvListVehicles.Columns[2].HeaderText = "Vehicle ID";
                dgvListVehicles.Columns[2].Width = 80;

                dgvListVehicles.Columns[3].HeaderText = "Name";
                dgvListVehicles.Columns[3].Width = 200;

                dgvListVehicles.Columns[4].HeaderText = "Year";
                dgvListVehicles.Columns[4].Width = 100;

                dgvListVehicles.Columns[5].HeaderText = "Mileage";
                dgvListVehicles.Columns[5].Width = 150;

                dgvListVehicles.Columns[6].HeaderText = "Make";
                dgvListVehicles.Columns[6].Width = 100;

                dgvListVehicles.Columns[7].HeaderText = "Model";
                dgvListVehicles.Columns[7].Width = 100;


                dgvListVehicles.Columns[8].HeaderText = "Body";
                dgvListVehicles.Columns[8].Width = 100;

                dgvListVehicles.Columns[9].HeaderText = "Drive";
                dgvListVehicles.Columns[9].Width = 150;

                dgvListVehicles.Columns[10].HeaderText = "Fule";
                dgvListVehicles.Columns[10].Width = 150;

                dgvListVehicles.Columns[11].HeaderText = "Plat Number";
                dgvListVehicles.Columns[11].Width = 150;

                dgvListVehicles.Columns[12].HeaderText = "Price Day";
                dgvListVehicles.Columns[12].Width = 150;

                dgvListVehicles.Columns[13].HeaderText = "Price Month";
                dgvListVehicles.Columns[13].Width = 150;

                dgvListVehicles.Columns[14].HeaderText = "N.Of Rented";
                dgvListVehicles.Columns[14].Width = 100;



                dgvListVehicles.Columns[15].HeaderText = "T.Rental Income";
                dgvListVehicles.Columns[15].Width = 150;

                dgvListVehicles.Columns[16].HeaderText = "T.Maintenance Fees";
                dgvListVehicles.Columns[16].Width = 150;


                dgvListVehicles.Columns[17].HeaderText = "N.Of Maintenance";
                dgvListVehicles.Columns[17].Width = 100;


                dgvListVehicles.Columns[18].HeaderText = "Purchasing Price";
                dgvListVehicles.Columns[18].Width = 180;

                dgvListVehicles.Columns[19].HeaderText = "Purchasing Date";
                dgvListVehicles.Columns[19].Width = 120;

                dgvListVehicles.Columns[20].HeaderText = "Active";
                dgvListVehicles.Columns[20].Width = 80;

                dgvListVehicles.Columns[21].HeaderText = "Available";
                dgvListVehicles.Columns[21].Width = 80;

                dgvListVehicles.Columns[22].HeaderText = "Sold";
                dgvListVehicles.Columns[22].Width = 80;

                dgvListVehicles.Columns[23].HeaderText = "Created By User ID";
                dgvListVehicles.Columns[23].Width = 100;

                dgvListVehicles.Columns[24].HeaderText = "Updated By User ID";
                dgvListVehicles.Columns[24].Width = 100;

                lblRecordsCount.Text = dgvListVehicles.Rows.Count.ToString();
            }

        }
        private void _LoadData()
        {
            _dtVehicles = clsVehicle.GetAllVehicles();
            LoadCities();
        }
        private void _LoadData(int BranchID)
        {
            cmbCityName.Enabled = false;
            cmbBranches.Enabled = false;
            _dtVehicles = clsVehicle.GetAllVehicles(BranchID);
        }
        private void frmListVehicels_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListVehicles))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            LoadAllData();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {


            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();


        }

        private void _FilterVehicles()
        {
            string query = "";

            if (!cbRentalPrice.Checked && (txtFromRentalPrice.TextLength > 0) && txtToRentalPrice.TextLength > 0 && cmbRentalPrice.Text != "")
            {
                switch (cmbRentalPrice.Text)
                {
                    case "Day":
                        query = "RentalPricePerDay >= " + txtFromRentalPrice.Text + " And RentalPricePerDay <= " + txtToRentalPrice.Text;
                        break;

                    case "Month":
                        query = "RentalPricePerMonth >= " + txtFromRentalPrice.Text + " And RentalPricePerMonth <= " + txtToRentalPrice.Text;

                        break;

                    case "Year":
                        query = "RentalPricePerYear >= " + txtFromRentalPrice.Text + " And RentalPricePerYear <= " + txtToRentalPrice.Text;

                        break;
                }
            }

            if (!cbNumberRented.Checked)
                if (query != "")
                    query += " And (NumberTimesRented>= " + nudFromNumberRented.Value + " And NumberTimesRented <= " + nudToNumberRented.Value + " )";
                else
                    query += "  NumberTimesRented>= " + nudFromNumberRented.Value + " And NumberTimesRented <= " + nudToNumberRented.Value;


            if (!cbYear.Checked)
                if (query != "")
                    query += " And (Year>= " + dtpYear.Value.ToString("yyyy") + " And Year <= " + dtpYear.Value.ToString("yyyy") + " )";
                else
                    query += "  Year>= " + dtpYear.Value.ToString("yyyy") + " And Year <= " + dtpYear.Value.ToString("yyyy");


            if (!cbNumberMaintenance.Checked)
                if (query != "")
                    query += " And (NumberTimesOfMaintenance>= " + nudFromNumberMaintenance.Value + " And NumberTimesOfMaintenance <= " + nudToNumberMaintenance.Value + " )";
                else
                    query += "  NumberTimesOfMaintenance>= " + nudFromNumberMaintenance.Value + " And NumberTimesOfMaintenance <= " + nudToNumberMaintenance.Value;

            if (!cbTotalRentalIncome.Checked)
                if (query != "")
                    query += " And (TotalRentalIncome>= " + txtFromTotalRentalincome.Text + " And TotalRentalIncome <= " + txtToTotalRentalIncome.Text + " )";
                else
                    query += "  TotalRentalIncome>= " + txtFromTotalRentalincome.Text + " And TotalRentalIncome <= " + txtToTotalRentalIncome.Text;

            if (!cbPurchasingSellingPrice.Checked && (txtFromPurchasingSellingPrice.TextLength > 0) && txtToPurchasingSellingPrice.TextLength > 0)
            {

                if (query != "")
                    query = "and (PurchasingPrice >= " + txtFromPurchasingSellingPrice.Text + " And PurchasingPrice <= " + txtToPurchasingSellingPrice.Text + " )";
                else
                    query = "PurchasingPrice >= " + txtFromPurchasingSellingPrice.Text + " And PurchasingPrice <= " + txtToPurchasingSellingPrice.Text;
            }

            if (!cbPurchasingSellingDate.Checked)
            {

                if (query != "")
                    query += " And (PurchasingDate >=  '" + dtpFromPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "'  And PurchasingDate <= '" + dtpToPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " PurchasingDate >=  '" + dtpFromPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "'  And PurchasingDate <= '" + dtpToPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "' ";
            }
            if (cbIsActive.Text != "All" && cbIsActive.Text != "")
                if (query != "")
                    query += " And (Active =  '" + cbIsActive.Text + "' )";
                else
                    query += " Active =  '" + cbIsActive.Text + " ' ";


            if (cmbCityName.Text != "All" && cmbCityName.Text != "")
                if (query != "")
                    query += " And (CityName = '" + cmbCityName.Text.Trim() + "' )";
                else
                    query += "  CityName = '" + cmbCityName.Text.Trim() + "' ";

            if (cmbBranches.Text != "All" && cmbBranches.Text != "")
                if (query != "")
                    query += " And (StreetName = '" + cmbBranches.Text.Trim() + "' )";
                else
                    query += "  StreetName = '" + cmbBranches.Text.Trim() + "' ";

            if (cmbSold.Text != "All" && cmbSold.Text != "")
                if (query != "")
                    query += " And (isSold = '" + cmbSold.Text.Trim() + "' )";
                else
                    query += "  isSold = '" + cmbSold.Text.Trim() + "' ";


            if (cbIsAvailableForRental.Text != "All" && cbIsAvailableForRental.Text != "")
                if (query != "")
                    query += " And (AvailableForRental =  '" + cbIsAvailableForRental.Text + "' )";
                else
                    query += " AvailableForRental =  '" + cbIsAvailableForRental.Text + "' ";
            if (txtFilterValue.Text != "")
            {
                switch (cbFilterBy.Text)
                {
                    case "Vehicle ID":
                        if (query != "")
                            query += " And (VehicleID= " + txtFilterValue.Text + " )";
                        else
                            query += "  VehicleID= " + txtFilterValue.Text;
                        break;
                    case "Name":
                        if (query != "")
                            query += " And (Name like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  Name like '" + txtFilterValue.Text + "%' ";
                        break;

                    case "Plate Number":
                        if (query != "")
                            query += " And (PlateNumber like '" + clsFormat.DeleteAllSpaceFromText(txtFilterValue.Text) + "%' )";
                        else
                            query += "  PlateNumber like '" + clsFormat.DeleteAllSpaceFromText(txtFilterValue.Text) + "%' ";
                        break;
                }
            }
            if (query != "")
            {
                if (_dtVehicles.Rows.Count < 1)
                    return;
                _dtVehicles.DefaultView.RowFilter = query;

            }
            else
                _dtVehicles.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListVehicles.Rows.Count.ToString();

        }
        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();


        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Vehicle ID" || cbFilterBy.Text == "Year")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDatilsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle((int)dgvListVehicles.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
            frmListVehicels_Load(null, null);
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, (int)dgvListVehicles.CurrentRow.Cells[1].Value);
            this.Close();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dgvListVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbIsAvailableForRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cmbPurchasingSellingDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbPurchasingSellingDate_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cmbPurchasingSellingPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbPurchasingSellingPrice_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }


        private void cbTotalRentalIncome_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void txtToPurchasingSellingPrice_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }


        private void tabTotalRentalIncome_Click(object sender, EventArgs e)
        {

        }

        private void txtToTotalRentalIncome_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void nudToNumberMaintenance_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbNumberMaintenance_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }


        private void txtToRentalPrice_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cmbRentalPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbRentalPrice_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void dtpYear_ValueChanged(object sender, EventArgs e)
        {
             _FilterVehicles();
        }

        private void cbYear_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void nudFromNumberMaintenance_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void txtFromTotalRentalincome_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void nudFromNumberRented_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void nudToNumberRented_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbNumberRented_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
            _LoadBranches(cmbCityName.Text);
        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cmbSold_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }
        private void LoadAllData()
        {
            if (_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
            _LoadDataGridViewForVehicleManagement();
        }
        private void frmListVehicels_Activated(object sender, EventArgs e)
        {
        }
    }
}