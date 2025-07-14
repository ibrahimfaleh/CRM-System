using CarRental.Amounts_Spent.Salary_Payments;
using CarRental.Classes;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Vehicles
{
    public partial class femListOfVehicleSales : Form
    {
        private DataTable _dtVehicleSale;
        private int? _BranchID;
        public femListOfVehicleSales()
        {
            InitializeComponent();
        }
        public femListOfVehicleSales(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
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
        private void _LoadDataGridView()
        {
            dgv.DataSource = _dtVehicleSale;
            if (_dtVehicleSale.Columns.Count > 0)
            {
                dgv.Columns[0].HeaderText = "City Name";
                dgv.Columns[0].Width = 150;

                dgv.Columns[1].HeaderText = "Street Name";
                dgv.Columns[1].Width = 150;

                dgv.Columns[2].HeaderText = "Sale ID";
                dgv.Columns[2].Width = 80;

                dgv.Columns[3].HeaderText = "Vehicle ID";
                dgv.Columns[3].Width = 100;

                dgv.Columns[4].HeaderText = "Name";
                dgv.Columns[4].Width = 250;

                dgv.Columns[5].HeaderText = "Year";
                dgv.Columns[5].Width = 150;

                dgv.Columns[6].HeaderText = "Mileage";
                dgv.Columns[6].Width = 150;

                dgv.Columns[7].HeaderText = "Make";
                dgv.Columns[7].Width = 150;


                dgv.Columns[8].HeaderText = "Plat Number";
                dgv.Columns[8].Width = 150;


                dgv.Columns[9].HeaderText = "N.Of Rented";
                dgv.Columns[9].Width = 150;



                dgv.Columns[10].HeaderText = "T.Rental Income";
                dgv.Columns[10].Width = 150;

                dgv.Columns[11].HeaderText = "T.Maintenance Fees";
                dgv.Columns[11].Width = 150;


                dgv.Columns[12].HeaderText = "N.Of Maintenance";
                dgv.Columns[12].Width = 150;


                dgv.Columns[13].HeaderText = "Purchasing Price";
                dgv.Columns[13].Width = 180;

                dgv.Columns[14].HeaderText = "Purchasing Date";
                dgv.Columns[14].Width = 150;

                dgv.Columns[15].HeaderText = "Sale Date";
                dgv.Columns[15].Width = 150;

                dgv.Columns[16].HeaderText = "Price";
                dgv.Columns[16].Width = 150;

                dgv.Columns[17].HeaderText = "Description";
                dgv.Columns[17].Width = 200;

                dgv.Columns[18].HeaderText = "Payment Details";
                dgv.Columns[18].Width = 200;

                dgv.Columns[19].HeaderText = "Created By User ID";
                dgv.Columns[19].Width = 150;

                dgv.Columns[20].HeaderText = "Updated By User ID";
                dgv.Columns[20].Width = 150;

                dgv.Columns[21].HeaderText = "Updated Date";
                dgv.Columns[21].Width = 150;

                lblRecordsCount.Text = dgv.Rows.Count.ToString();
            }

        }
        private void _LoadData()
        {
            _dtVehicleSale = clsVehicleSale.GetAllVehicleSales();
            _LoadDataGridView();
            LoadCities();
        }
        private void _LoadData(int BranchID)
        {
            cmbCityName.Enabled = false;
            cmbBranches.Enabled = false;
            _dtVehicleSale = clsVehicle.GetAllVehicles(BranchID);
            _LoadDataGridView();

        }
        private void _FilterVehicleSales()
        {
            string query = "";

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


            if (!cbSalePrice.Checked && (txtFromSalePrice.TextLength > 0) && txtToSalePrice.TextLength > 0)
            {

                if (query != "")
                    query = "and (SalePrice >= " + txtFromSalePrice.Text + " And SalePrice <= " + txtToSalePrice.Text + " )";
                else
                    query = "SalePrice >= " + txtFromSalePrice.Text + " And SalePrice <= " + txtToSalePrice.Text;
            }


            if (!cbPurchasingSellingDate.Checked)
            {

                if (query != "")
                    query += " And (PurchasingDate >=  '" + dtpFromPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "'  And PurchasingDate <= '" + dtpToPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " PurchasingDate >=  '" + dtpFromPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "'  And PurchasingDate <= '" + dtpToPurchasingSellingDate.Value.ToString("dd-MM-yyyy") + "' ";
            }



            if (!cbSaleDate.Checked)
            {

                if (query != "")
                    query += " And (PurchasingDate >=  '" + dtpFromSaleDate.Value.ToString("dd-MM-yyyy") + "'  And PurchasingDate <= '" + dtpToSaleDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " PurchasingDate >=  '" + dtpFromSaleDate.Value.ToString("dd-MM-yyyy") + "'  And PurchasingDate <= '" + dtpToSaleDate.Value.ToString("dd-MM-yyyy") + "' ";
            }


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
                if (_dtVehicleSale.Rows.Count < 1)
                    return;
                _dtVehicleSale.DefaultView.RowFilter = query;

            }
            else
                _dtVehicleSale.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgv.Rows.Count.ToString();

        }

        private void cbSaleDate_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();
        }

        private void dtpToSaleDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void dtpFromSaleDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void cbSalePrice_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void txtToSalePrice_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void txtFromSalePrice_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

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

        private void txtToTotalRentalIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Vehicle ID" || cbFilterBy.Text == "Year")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dtpYear_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();
        }

        private void nudFromNumberRented_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();
        }

        private void nudToNumberRented_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void cbNumberRented_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void nudFromNumberMaintenance_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void nudToNumberMaintenance_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void cbNumberMaintenance_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void txtFromTotalRentalincome_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void txtToTotalRentalIncome_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void cbTotalRentalIncome_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void txtFromPurchasingSellingPrice_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void txtToPurchasingSellingPrice_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void cbPurchasingSellingPrice_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void dtpFromPurchasingSellingDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void dtpToPurchasingSellingDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void cbPurchasingSellingDate_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();
            _LoadBranches(cmbCityName.Text);
        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void femListOfVehicleSales_Load(object sender, EventArgs e)
        {
            if (_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellingVehicle frmSellingVehicle = new frmSellingVehicle((int)dgv.CurrentRow.Cells[2].Value);
            frmSellingVehicle.ShowDialog();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();
        }

        private void cbYear_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicleSales();

        }
    }
}
