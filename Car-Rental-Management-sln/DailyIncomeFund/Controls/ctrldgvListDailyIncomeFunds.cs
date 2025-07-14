using CarRental.Rental_Fund;
using CarRental.Users;
using CarRental_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Daily_Income_Fund
{
    public partial class ctrldgvListDailyIncomeFunds : UserControl
    {
        private DataTable _dtDailyIncomeFund;
        public ctrldgvListDailyIncomeFunds()
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
        private void _ColumnDailyFundTransaction()
        {

            if (_dtDailyIncomeFund.Rows.Count > 0)
            {
                dgvListDailyIncomeFunds.DataSource = _dtDailyIncomeFund;
                lblRecordsCount.Text = dgvListDailyIncomeFunds.Rows.Count.ToString();

                dgvListDailyIncomeFunds.Columns[0].Width = 1;

                dgvListDailyIncomeFunds.Columns[1].HeaderText = "City Name";
                dgvListDailyIncomeFunds.Columns[1].Width = 180;


                dgvListDailyIncomeFunds.Columns[2].HeaderText = "Branch ID";
                dgvListDailyIncomeFunds.Columns[2].Width = 100;

                dgvListDailyIncomeFunds.Columns[3].HeaderText = "Street Name";
                dgvListDailyIncomeFunds.Columns[3].Width = 200;

                dgvListDailyIncomeFunds.Columns[4].HeaderText = "Daily Fund ID";
                dgvListDailyIncomeFunds.Columns[4].Width = 150;

                dgvListDailyIncomeFunds.Columns[5].HeaderText = "Total Income";
                dgvListDailyIncomeFunds.Columns[5].Width = 200;

                dgvListDailyIncomeFunds.Columns[6].HeaderText = "Actual Profits";
                dgvListDailyIncomeFunds.Columns[6].Width = 200;

                dgvListDailyIncomeFunds.Columns[7].HeaderText = "Expected Profit";
                dgvListDailyIncomeFunds.Columns[7].Width = 200;

                dgvListDailyIncomeFunds.Columns[8].HeaderText = "Vehicle.B.R";
                dgvListDailyIncomeFunds.Columns[8].Width = 200;

                dgvListDailyIncomeFunds.Columns[9].HeaderText = "Total Amount Of Support";
                dgvListDailyIncomeFunds.Columns[9].Width = 200;

                dgvListDailyIncomeFunds.Columns[10].HeaderText = "Revenue or Deficit Or Surplus";
                dgvListDailyIncomeFunds.Columns[10].Width = 200;

                dgvListDailyIncomeFunds.Columns[11].HeaderText = "Income Status";
                dgvListDailyIncomeFunds.Columns[11].Width = 90;

                dgvListDailyIncomeFunds.Columns[12].HeaderText = "Is Closed";
                dgvListDailyIncomeFunds.Columns[12].Width = 90;

                dgvListDailyIncomeFunds.Columns[13].HeaderText = "Date";
                dgvListDailyIncomeFunds.Columns[13].Width = 190;

                dgvListDailyIncomeFunds.Columns[14].HeaderText = "Closed By User ID";
                dgvListDailyIncomeFunds.Columns[14].Width = 150;
            }
        }
        public void LoadDailyIncomeFund()
        {
            _dtDailyIncomeFund = clsDailyIncomeFund.GetAllDailyIncomeFunds();
            _ColumnDailyFundTransaction();
            LoadCities();
        }
        public void LoadDailyIncomeFund(int BranchID)
        {
            _dtDailyIncomeFund = clsDailyIncomeFund.GetAllDailyIncomeFunds(BranchID);
            _ColumnDailyFundTransaction();
            cmbBranches.Items.Clear();
            cmbCityName.Items.Clear();
            cmbCityName.Enabled = false;
            cmbBranches.Enabled = false;

        }
        private void _FilterDailyIncomeFund()
        {
            string query = "";

            if (!cbIncome.Checked && (txtFromIncome.TextLength > 0) && txtToIncome.TextLength > 0)
                query = "TotalIncome >= " + txtFromIncome.Text + " And TotalIncome <= " + txtToIncome.Text;
            if (!cbDate.Checked)
            {
                if (query != "")
                    query += " And (Date >=  '" + dtpFromDate.Value.ToString("dd-MM-yyyy") + "'  And Date<= '" + dtpToDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " Date >=  '" + dtpFromDate.Value.ToString("dd-MM-yyyy") + "'  And Date <= '" + dtpToDate.Value.ToString("dd-MM-yyyy") + "' ";

            }

            if (!cbRevenueorDeficitOrSurplus.Checked && (txtFromRevenueorDeficitOrSurplus.TextLength > 0) && (txtToRevenueorDeficitOrSurplus.TextLength > 0))
                if (query != "")
                    query += " And (TotalRevenueDeficitOrSurplus >=  " + txtFromRevenueorDeficitOrSurplus.Text + "  And TotalRevenueDeficitOrSurplus<= " + txtToRevenueorDeficitOrSurplus.Text + "  )";
                else
                    query += " TotalRevenueDeficitOrSurplus >=  " + txtFromRevenueorDeficitOrSurplus.Text + "  And TotalRevenueDeficitOrSurplus <= " + txtToRevenueorDeficitOrSurplus.Text + " ";


            if (cmbIncomeStatus.Text != "All" && cmbIncomeStatus.Text != "")
                if (query != "")
                    query += " And (Status = '" + cmbIncomeStatus.Text.Trim() + "' )";
                else
                    query += "  Status = '" + cmbIncomeStatus.Text.Trim() + "' ";


            if (cmbIsClose.Text != "All" && cmbIsClose.Text != "")
                if (query != "")
                    query += " And (IsClosed = '" + cmbIsClose.Text.Trim() + "' )";
                else
                    query += "  IsClosed = '" + cmbIsClose.Text.Trim() + "' ";

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


            if (txtFilterValue.Text.Length > 0)
            {
                switch (cbFilterBy.Text)
                {
                    case "Closed By User ID":
                        if (query != "")
                            query += " And (ClosedByUserID = " + txtFilterValue.Text + ") ";
                        else
                            query += " ClosedByUserID = " + txtFilterValue.Text + " ";
                        break;
                }
            }

            if (query != "")
            {
                if (_dtDailyIncomeFund.Rows.Count < 1)
                    return;
                _dtDailyIncomeFund.DefaultView.RowFilter = query;

            }
            else
                _dtDailyIncomeFund.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListDailyIncomeFunds.Rows.Count.ToString();
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
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterDailyIncomeFund();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtFromAmount_TextChanged(object sender, EventArgs e)
        {
            txtToIncome.Text = txtFromIncome.Text;
        }
        private void txtToAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cbSalary_CheckedChanged(object sender, EventArgs e)
        {
            _FilterDailyIncomeFund();
        }
        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterDailyIncomeFund();

        }
        private void cmbIsClose_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterDailyIncomeFund();

        }
        private void cmbIncomeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterDailyIncomeFund();

        }
        private void txtFromRevenueorDeficitOrSurplus_TextChanged(object sender, EventArgs e)
        {
            txtToRevenueorDeficitOrSurplus.Text = txtFromRevenueorDeficitOrSurplus.Text;
        }
        private void paymentFromTheGeneralFundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDailyIncomeFund frmDailyIncomeFund = new frmDailyIncomeFund((int)dgvListDailyIncomeFunds.CurrentRow.Cells[4].Value);
            frmDailyIncomeFund.ShowDialog();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDailyIncomeDetails frm = new frmDailyIncomeDetails((int)dgvListDailyIncomeFunds.CurrentRow.Cells[4].Value);
            frm.ShowDialog();   
        }
        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvListDailyIncomeFunds.CurrentRow.Cells[14].Value.ToString()!="")
            {
                frmUserDetails frmUser = new frmUserDetails((int)dgvListDailyIncomeFunds.CurrentRow.Cells[14].Value);
                frmUser.ShowDialog();
            }

        }
        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterDailyIncomeFund();
            _LoadBranches(cmbCityName.Text);
        }
        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterDailyIncomeFund();
        }
    }
}
