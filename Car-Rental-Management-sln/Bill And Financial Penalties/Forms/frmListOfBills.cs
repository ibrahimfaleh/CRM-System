using CarRental.Classes;
using CarRental.Users;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmListOfBills : Form
    {
        public enum enMode { GetAll = 1, GetByBranchID = 2 }
        private enMode _Mode;
        private int _BranchID;
        private DataTable _dtBills;
        public frmListOfBills()
        {
            InitializeComponent();
            _Mode = enMode.GetAll;
        }
        public frmListOfBills(int BranchID)
        {
            InitializeComponent();
            _Mode = enMode.GetByBranchID;
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
        private void _LoadDataBulls()
        {
            _dtBills = clsBill.GetAllBills();
        }
        private void _LoadDataBulls(int BranchID)
        {
            _dtBills = clsBill.GetAllBills(BranchID);
        }
        private void _dgvColumnDesign()
        {
            if (_dtBills.Rows.Count > 0)
            {
                dgvListOfContracts.DataSource = _dtBills;
                dgvListOfContracts.Columns[0].HeaderText = "Branch ID";
                dgvListOfContracts.Columns[0].Width = 50;

                dgvListOfContracts.Columns[1].HeaderText = "City Name";
                dgvListOfContracts.Columns[1].Width = 150;

                dgvListOfContracts.Columns[2].HeaderText = "Street Name";
                dgvListOfContracts.Columns[2].Width = 150;

                dgvListOfContracts.Columns[3].HeaderText = "Bill ID";
                dgvListOfContracts.Columns[3].Width = 150;

                dgvListOfContracts.Columns[4].HeaderText = "Type";
                dgvListOfContracts.Columns[4].Width = 200;

                dgvListOfContracts.Columns[5].HeaderText = "Cost";
                dgvListOfContracts.Columns[5].Width = 200;

                dgvListOfContracts.Columns[6].HeaderText = "Details";
                dgvListOfContracts.Columns[6].Width = 200;

                dgvListOfContracts.Columns[7].HeaderText = "C.Date";
                dgvListOfContracts.Columns[7].Width = 150;

                dgvListOfContracts.Columns[8].HeaderText = "Payment Status";
                dgvListOfContracts.Columns[8].Width = 100;

                dgvListOfContracts.Columns[9].HeaderText = "Payment Date";
                dgvListOfContracts.Columns[9].Width = 200;

                dgvListOfContracts.Columns[10].HeaderText = "Active";
                dgvListOfContracts.Columns[10].Width = 100;



                dgvListOfContracts.Columns[11].HeaderText = "C.By UserID";
                dgvListOfContracts.Columns[11].Width = 150;



                dgvListOfContracts.Columns[12].HeaderText = "U.By User ID";
                dgvListOfContracts.Columns[12].Width = 150;

                dgvListOfContracts.Columns[13].HeaderText = "U.Date";
                dgvListOfContracts.Columns[13].Width = 150;




                lblRecordsCount.Text = _dtBills.Rows.Count.ToString();
            }
        }
        private void _ResetDefaultValues()
        {
            cmbPaymentStatus.SelectedIndex = 0;
            txtFilterValue.Text = "";
            dtpFromDate.MinDate = DateTime.Now.AddYears(-10);
            dtpFromDate.MaxDate = DateTime.Now.AddYears(10);
            dtpToDate.MinDate = DateTime.Now.AddYears(-10);
            dtpToDate.MaxDate = DateTime.Now.AddYears(10);
        }
        private void _FilterBills()
        {
            string query = "";

            if (cbCostFilter.Checked && (txtFromCost.Text != "") && txtToCost.Text != "")
                query = "Cost >= " + txtFromCost.Text + " And Cost <= " + txtToCost.Text;



            switch (cmbByDate.Text)
            {
                case "Created Date":
                    if (query != "")
                        query += " And ( CreatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  CreatedDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " CreatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And CreatedDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                case "Payment Date":
                    if (query != "")
                        query += " And ( PaymentDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  PaymentDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " PaymentDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And PaymentDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                case "Updated Date":
                    if (query != "")
                        query += " And ( UpdatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  UpdatedDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " UpdatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And UpdatedDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                default:

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
            if (txtFilterValue.Text.Length > 0)
            {
                switch (cmbFilterBy.Text)
                {
                    case "Bill ID":
                        if (query != "")
                            query += " And (BillID = " + txtFilterValue.Text + ") ";
                        else
                            query += " BillID = " + txtFilterValue.Text + " ";
                        break;

                    case "Created By User ID":
                        if (query != "")
                            query += " And (CreatedByUserID = " + txtFilterValue.Text + ") ";
                        else
                            query += " CreatedByUserID = " + txtFilterValue.Text + " ";
                        break;

                    case "Updated By User ID":
                        if (query != "")
                            query += " And (UpdatedByUserID = " + txtFilterValue.Text + ") ";
                        else
                            query += " UpdatedByUserID = " + txtFilterValue.Text + " ";
                        break;

                    default:

                        break;
                }
            }

            if (cmbType.Text != "All" && cmbType.Text != "")
                if (query != "")
                    query += " And (Type = '" + cmbType.Text.Trim() + "' )";
                else
                    query += "  Type = '" + cmbType.Text.Trim() + "' ";


            if (cmbPaymentStatus.Text != "All" && cmbPaymentStatus.Text != "")
                if (query != "")
                    query += " And (PaymentStatus = '" + cmbPaymentStatus.Text + "' )";
                else
                    query += "  PaymentStatus = '" + cmbPaymentStatus.Text + "' ";

            if (query != "")
            {
                if (_dtBills.Rows.Count < 1)
                    return;
                _dtBills.DefaultView.RowFilter = query;

            }
            else
                _dtBills.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListOfContracts.Rows.Count.ToString();

        }
        private void _LoadData()
        {
            LoadCities();   
            _LoadDataBulls();
            _dgvColumnDesign();
        }
        private void _LoadData(int BranchID)
        {
            cmbBranches.Items.Clear();
            cmbCityName.Items.Clear();
            cmbCityName.Enabled = false;    
            cmbBranches.Enabled = false;
            _LoadDataBulls(BranchID);
            _dgvColumnDesign();
        }
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterBills();
        }

        private void frmListOfBills_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.GetAll)
                _LoadData();
            if (_Mode == enMode.GetByBranchID)
                _LoadData(_BranchID);
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cmbFilterBy.Text != "None");
            if (!txtFilterValue.Visible)
                txtFilterValue.Text = "";
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBills();
        }

        private void txtFromCost_TextChanged(object sender, EventArgs e)
        {
            _FilterBills();

        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterBills();

        }

        private void txtToCost_TextChanged(object sender, EventArgs e)
        {
            _FilterBills();

        }

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterBills();

        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterBills();

        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterBills();

        }

        private void cmbByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterBills();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBills frmAddUpdateBills = new frmAddUpdateBills((int)dgvListOfContracts.CurrentRow.Cells[3].Value);
            frmAddUpdateBills.ShowDialog();
            frmListOfBills_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgvListOfContracts.CurrentRow.Cells[11].Value);
            frmUser.ShowDialog();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgvListOfContracts.CurrentRow.Cells[12].Value);
            frmUser.ShowDialog();
        }

        private void txtToCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbCostFilter_CheckedChanged(object sender, EventArgs e)
        {
            _FilterBills();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transferTheBillToTheAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsBill bill =clsBill.Find((int)dgvListOfContracts.CurrentRow.Cells[3].Value);
            if(bill == null)
            {
                MessageBox.Show("Not Fond", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            if(bill.IsPaid) 
            {
                MessageBox.Show("The paid Bill cannot be transferred","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!clsGeneralFundBill.isGeneralFundBillExistByBillID(bill.BillID))
            {
                if (MessageBox.Show("You cannot modify after transferring the invoice to the administrator", "transfer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                clsGeneralFundBill generalFundBill = new clsGeneralFundBill();
                generalFundBill.BillID = (int)dgvListOfContracts.CurrentRow.Cells[3].Value;
                if (generalFundBill.Save())
                {
                    MessageBox.Show("completed successfully", "transfer", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else
                {
                    MessageBox.Show("Not completed successfully", "transfer", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

                }
            }
            else
            {
                MessageBox.Show("Already transfer", "transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbBranches_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _FilterBills();
        }

        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterBills();
            _LoadBranches(cmbCityName.Text);
        }

        private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
