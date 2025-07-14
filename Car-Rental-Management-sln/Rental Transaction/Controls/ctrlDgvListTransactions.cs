using CarRental.Classes;
using CarRental.Customers;
using CarRental.Users;
using CarRental.Vehicles;
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

namespace CarRental.Rental_Transaction
{
    public partial class ctrlDgvListTransactions : UserControl
    {
        public enum enMode { AllContracts = 1, ContractsByBranchID }
        private enMode _Mode;
        private int? _BranchID;
        private DataTable _dtRentalBooking;
        private bool _ShowUpdatedByUserIDVisible = true;
        private bool _ShowCreatedByUserIDVisible = true;
        private bool _ShowCustomerVisible = true;
        public bool ShowUpdatedByUserIDVisible
        {
            get
            {
                return _ShowUpdatedByUserIDVisible;
            }
            set
            {
                _ShowUpdatedByUserIDVisible = value;
                contextMenuStrip1.Items[2].Visible = _ShowUpdatedByUserIDVisible;
            }
        }
        public bool ShowCreatedByUserIDVisible
        {
            get
            {
                return _ShowCreatedByUserIDVisible;
            }
            set
            {
                _ShowCreatedByUserIDVisible = value;
                contextMenuStrip1.Items[1].Visible = _ShowCreatedByUserIDVisible;
            }
        }
        public bool ShowCustomerVisible
        {
            get
            {
                return _ShowCustomerVisible;
            }
            set
            {
                _ShowCustomerVisible = value;
                contextMenuStrip1.Items[3].Visible = _ShowCustomerVisible;
            }
        }
        public ctrlDgvListTransactions()
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
            foreach (DataRow row in clsBranch.GetAllBranches(CityName).Rows)
            {
                cmbBranches.Items.Add(row[2]);
            }
        }
        private void _FullColumnsListRentalTransaction()
        {
            dgv.DataSource = _dtRentalBooking;
            if (_dtRentalBooking.Rows.Count > 0)
            {
                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                dgv.Columns[0].HeaderText = "City Name";
                dgv.Columns[0].Width = 150;

                dgv.Columns[1].HeaderText = "Street Name";
                dgv.Columns[1].Width = 150;

                dgv.Columns[2].HeaderText = "Transaction ID";
                dgv.Columns[2].Width = 150;

                dgv.Columns[3].HeaderText = "Vehicle Name";
                dgv.Columns[3].Width = 150;

                dgv.Columns[4].HeaderText = "Model";
                dgv.Columns[4].Width = 150;

                dgv.Columns[5].HeaderText = "Year";
                dgv.Columns[5].Width = 100;

                dgv.Columns[6].HeaderText = "Plate Number";
                dgv.Columns[6].Width = 90;

                dgv.Columns[7].HeaderText = "Start Date";
                dgv.Columns[7].Width = 150;

                dgv.Columns[8].HeaderText = "Initial Days";
                dgv.Columns[8].Width = 100;

                dgv.Columns[9].HeaderText = "Initial Months";
                dgv.Columns[9].Width = 100;

                dgv.Columns[10].HeaderText = "Price Per Day";
                dgv.Columns[10].Width = 100;

                dgv.Columns[11].HeaderText = "Price Per Month";
                dgv.Columns[11].Width = 150;

                dgv.Columns[12].HeaderText = "Initial Total DueAmount";
                dgv.Columns[12].Width = 150;

                dgv.Columns[13].HeaderText = "Paid Initial Total DueAmount";
                dgv.Columns[13].Width = 150;

                dgv.Columns[14].HeaderText = "Actual Return Date";
                dgv.Columns[14].Width = 150;

                dgv.Columns[15].HeaderText = "Actual Rental Days";
                dgv.Columns[15].Width = 150;

                dgv.Columns[16].HeaderText = "Actual Rental Months";
                dgv.Columns[16].Width = 150;

                dgv.Columns[17].HeaderText = "Additional Hours";
                dgv.Columns[17].Width = 150;

                dgv.Columns[18].HeaderText = "Consumed Mileage";
                dgv.Columns[18].Width = 150;

                dgv.Columns[19].HeaderText = "Actual Total Due Amount";
                dgv.Columns[19].Width = 150;

                dgv.Columns[20].HeaderText = "Total Remaining";
                dgv.Columns[20].Width = 150;

                dgv.Columns[21].HeaderText = "Total Refunded Amount";
                dgv.Columns[21].Width = 150;

                dgv.Columns[22].HeaderText = "Customer ID";
                dgv.Columns[22].Width = 100;

                dgv.Columns[23].HeaderText = "Full Name";
                dgv.Columns[23].Width = 200;

                dgv.Columns[24].HeaderText = "NationalNo";
                dgv.Columns[24].Width = 100;

                dgv.Columns[25].HeaderText = "Created By User ID";
                dgv.Columns[25].Width = 100;

                dgv.Columns[26].HeaderText = "Update By User ID";
                dgv.Columns[26].Width = 100;

                dgv.Columns[27].HeaderText = "Status";
                dgv.Columns[27].Width = 100;
            }
        }
        public void ctrldgRentalBookingWithFalter_LoadByCustomerID(int CustomerID)
        {
            _dtRentalBooking = clsRentalTransaction.GetAllRentalTransactionByCustomerID(CustomerID);
            LoadCities();
            _FullColumnsListRentalTransaction();
        }
        public void ctrldgRentalBookingWithFalter_LoadByBranchID(int BranchID)
        {
            _dtRentalBooking = clsRentalTransaction.GetAllRentalTransactionByBranchID(BranchID);
            _FullColumnsListRentalTransaction();
            cmbBranches.Items.Clear();
            cmbCityName.Items.Clear();
            cmbCityName.Enabled = false;    
            cmbBranches.Enabled = false;    
        }
        public void ctrldgRentalBookingWithFalter_Load()
        {
            _dtRentalBooking = clsRentalTransaction.GetAllRentalTransaction();
            _FullColumnsListRentalTransaction();
            LoadCities();
        }
        private void _FilterListTransaction()
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

                switch (cmbBranches.Text)
                {
                    case "Day":
                        query = " >= " + txtFromRentalPrice.Text + " And RentalPricePerDay <= " + txtToRentalPrice.Text;
                        break;

                    case "Month":
                        query = "RentalPricePerMonth >= " + txtFromRentalPrice.Text + " And RentalPricePerMonth <= " + txtToRentalPrice.Text;

                        break;

                    case "Year":
                        query = "RentalPricePerYear >= " + txtFromRentalPrice.Text + " And RentalPricePerYear <= " + txtToRentalPrice.Text;

                        break;
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

            if (!cbRentalAmounts.Checked && cmbRentalAmounts.Text != "" && txtFromTotalRentalincome.Text != "" && txtToTotalRentalIncome.Text != "")
                switch (cmbRentalAmounts.Text)
                {
                    case "Initial Total Due Amount":
                        if (query != "")
                            query += " And (InitialTotalDueAmount>= " + txtFromTotalRentalincome.Text + " And InitialTotalDueAmount <= " + txtToTotalRentalIncome.Text + " )";
                        else
                            query += "  InitialTotalDueAmount>= " + txtFromTotalRentalincome.Text + " And InitialTotalDueAmount <= " + txtToTotalRentalIncome.Text;
                        break;

                    case "Paid Initial Total Due Amount":
                        if (query != "")
                            query += " And (PaidInitialTotalDueAmount>= " + txtFromTotalRentalincome.Text + " And PaidInitialTotalDueAmount <= " + txtToTotalRentalIncome.Text + " )";
                        else
                            query += "  PaidInitialTotalDueAmount>= " + txtFromTotalRentalincome.Text + " And PaidInitialTotalDueAmount <= " + txtToTotalRentalIncome.Text;
                        break;

                    case "Actual Total Due Amount":
                        if (query != "")
                            query += " And (ActualTotalDueAmount>= " + txtFromTotalRentalincome.Text + " And ActualTotalDueAmount <= " + txtToTotalRentalIncome.Text + " )";
                        else
                            query += "  ActualTotalDueAmount>= " + txtFromTotalRentalincome.Text + " And ActualTotalDueAmount <= " + txtToTotalRentalIncome.Text;
                        break;

                    case "Total Remaining":
                        if (query != "")
                            query += " And (TotalRemaining>= " + txtFromTotalRentalincome.Text + " And TotalRemaining <= " + txtToTotalRentalIncome.Text + " )";
                        else
                            query += "  TotalRemaining>= " + txtFromTotalRentalincome.Text + " And TotalRemaining <= " + txtToTotalRentalIncome.Text;
                        break;

                    case "Total Refunded Amount":
                        if (query != "")
                            query += " And (TotalRefundedAmount>= " + txtFromTotalRentalincome.Text + " And TotalRefundedAmount <= " + txtToTotalRentalIncome.Text + " )";
                        else
                            query += "  TotalRefundedAmount>= " + txtFromTotalRentalincome.Text + " And TotalRefundedAmount <= " + txtToTotalRentalIncome.Text;
                        break;
                }

            if (!cbRentalStatus.Checked)
                if (query != "")
                    query += " And (Status =  '" + cmbRentalStatus.Text + "' )";
                else
                    query += " Status =  '" + cmbRentalStatus.Text + " ' ";

            if (!cbNumberOfRentedDaysMonths.Checked && cmbNumberOfRentedDaysMonths.Text != "")
                switch (cmbNumberOfRentedDaysMonths.Text)
                {
                    case "Days":
                        if (query != "")
                            query += " And (ActualRentalDays>= " + nudFromNumberOfRentedDaysMonths.Value + " And ActualRentalDays <= " + nudToNumberOfRentedDaysMonths.Value + " )";
                        else
                            query += "  ActualRentalDays>= " + nudFromNumberOfRentedDaysMonths.Value + " And ActualRentalDays <= " + nudToNumberOfRentedDaysMonths.Value;
                        break;
                    case "Months":
                        if (query != "")
                            query += " And (ActualRentalMonths>= " + nudFromNumberOfRentedDaysMonths.Value + " And ActualRentalMonths <= " + nudToNumberOfRentedDaysMonths.Value + " )";
                        else
                            query += "  ActualRentalMonths>= " + nudFromNumberOfRentedDaysMonths.Value + " And ActualRentalMonths <= " + nudToNumberOfRentedDaysMonths.Value;
                        break;
                }

            if (txtFilterValue.Text != "")
            {
                switch (cbFilterBy.Text)
                {
                    case "Transaction ID":
                        if (query != "")
                            query += " And (TransactionID= " + txtFilterValue.Text + " )";
                        else
                            query += "  TransactionID= " + txtFilterValue.Text;
                        break;
                    case "Vehicle Name":
                        if (query != "")
                            query += " And (VehicleName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  VehicleName like '" + txtFilterValue.Text + "%' ";
                        break;

                    case "Plate Number":
                        if (query != "")
                            query += " And (PlateNumber like '" + clsFormat.DeleteAllSpaceFromText(txtFilterValue.Text) + "%' )";
                        else
                            query += "  PlateNumber like '" + clsFormat.DeleteAllSpaceFromText(txtFilterValue.Text) + "%' ";
                        break;
                    case "Full Name":
                        if (query != "")
                            query += " And (FullName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  FullName like '" + txtFilterValue.Text + "%' ";
                        break;
                }
            }
            if (query != "")
            {
                if (_dtRentalBooking.Rows.Count < 1)
                    return;
                _dtRentalBooking.DefaultView.RowFilter = query;

            }
            else
                _dtRentalBooking.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgv.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Transaction ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ctrldgRentalBookingWithFalter_Load(object sender, EventArgs e)
        {
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRentalTransActionInfo frm = new frmShowRentalTransActionInfo((int)dgv.CurrentRow.Cells[3].Value);
            frm.ShowDialog();
        }

        private void VehicleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiclesReturn frm = new frmVehiclesReturn((int)dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nudFromNumberRented_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ctrlDgvListTransactions_Load(object sender, EventArgs e)
        {

        }

        private void tabNumberOfDaysMonths_Click(object sender, EventArgs e)
        {

        }

        private void nudFromNumberOfRentedDaysMonths_ValueChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
            _FilterListTransaction();
        }

        private void cbYear_CheckedChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void dtpYear_ValueChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void nudToNumberOfRentedDaysMonths_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbNumberOfRentedDaysMonths_CheckedChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void txtFromTotalRentalincome_TextChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void dtpFromStartEndDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void rbEndDate_CheckedChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void cmbRentalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void cbRentalStatus_CheckedChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void txtFromRentalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbRentalAmounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void cbRentalAmounts_CheckedChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void showTransactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowRentalTransActionInfo frmShow = new frmShowRentalTransActionInfo((int)dgv.CurrentRow.Cells[2].Value);
            frmShow.ShowDialog();
        }

        private void showCreatedByUserIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgv.CurrentRow.Cells[25].Value);
            frmUser.ShowDialog();
        }

        private void showUpdatedByUserIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgv.CurrentRow.Cells[25].Value);
            frmUser.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgv.CurrentRow.Cells[25].Value.ToString() == "")
                contextMenuStrip1.Items[2].Visible = false;
        }

        private void showCustomerDetaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCustomerInfo frmShowCustomerInfo = new frmShowCustomerInfo((int)dgv.CurrentRow.Cells[22].Value);
            frmShowCustomerInfo.ShowDialog();
        }

        private void vehiclleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiclesReturn frm = new frmVehiclesReturn((int)dgv.CurrentRow.Cells[2].Value);
            frm.Show();

        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
        }

        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterListTransaction();
            _LoadBranches(cmbCityName.Text);
        }
    }
}