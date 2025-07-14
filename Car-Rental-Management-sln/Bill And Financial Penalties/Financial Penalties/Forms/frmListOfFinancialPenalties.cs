using CarRental.FinancialPenaltyAndFines.Fines.Forms;
using CarRental.Users;
using CarRental_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Bill_And_Financial_Penalties.Financial_Penalties.Forms
{
    public partial class frmListOfFinancialPenalties : Form
    {
        private DataTable _dtFinancialPenalties;
        public frmListOfFinancialPenalties()
        {
            InitializeComponent();
        }
        private void _Loadtypes()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("All");
            foreach(DataRow row in clsPenaltyType.GetAllPenaltyTypes().Rows) 
            {
                cmbType.Items.Add(row[1]);
            }
        }
        private void _dgvColumnDesign()
        {
            if (_dtFinancialPenalties.Rows.Count > 0)
            {
                dgvListOfContracts.DataSource = _dtFinancialPenalties;
                dgvListOfContracts.Columns[0].HeaderText = "Penalty ID";
                dgvListOfContracts.Columns[0].Width = 100;

                dgvListOfContracts.Columns[1].HeaderText = "Type";
                dgvListOfContracts.Columns[1].Width = 150;

                dgvListOfContracts.Columns[2].HeaderText = "Cost";
                dgvListOfContracts.Columns[2].Width = 200;

                dgvListOfContracts.Columns[3].HeaderText = "Details";
                dgvListOfContracts.Columns[3].Width = 200;

                dgvListOfContracts.Columns[4].HeaderText = "Date";
                dgvListOfContracts.Columns[4].Width = 200;

                dgvListOfContracts.Columns[5].HeaderText = "Payment Status";
                dgvListOfContracts.Columns[5].Width = 200;

                dgvListOfContracts.Columns[6].HeaderText = "PaymentDate";
                dgvListOfContracts.Columns[6].Width = 200;

                dgvListOfContracts.Columns[7].HeaderText = "C.By UserID";
                dgvListOfContracts.Columns[7].Width = 150;

                dgvListOfContracts.Columns[8].HeaderText = "U.By User ID";
                dgvListOfContracts.Columns[8].Width = 150;

                dgvListOfContracts.Columns[9].HeaderText = "U.Date";
                dgvListOfContracts.Columns[9].Width = 150;
                lblRecordsCount.Text = _dtFinancialPenalties.Rows.Count.ToString();
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
        private void _FilterFinancialPenalties()
        {
            string query = "";

            if (cbCostFilter.Checked && (txtFromCost.Text != "") && txtToCost.Text != "")
                query = "Cost >= " + txtFromCost.Text + " And Cost <= " + txtToCost.Text;



            switch (cmbByDate.Text)
            {
                case "Created Date":
                    if (query != "")
                        query += " And ( Date >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  Date <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " Date >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And Date <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                case "Payment Date":
                    if (query != "")
                        query += " And ( PaymentDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  PaymentDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " PaymentDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And PaymentDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                case "Updated Date":
                    if (query != "")
                        query += " And ( UpdateDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  UpdateDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " UpdateDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And UpdateDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                default:

                    break;
            }

            if (txtFilterValue.Text.Length > 0)
            {
                switch (cmbFilterBy.Text)
                {
                    case "Penalty ID":
                        if (query != "")
                            query += " And (PenaltyID = " + txtFilterValue.Text + ") ";
                        else
                            query += " PenaltyID = " + txtFilterValue.Text + " ";
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
                    query += " And (PenaltyType = '" + cmbType.Text.Trim() + "' )";
                else
                    query += "  PenaltyType = '" + cmbType.Text.Trim() + "' ";


            if (cmbPaymentStatus.Text != "All" && cmbPaymentStatus.Text != "")
                if (query != "")
                    query += " And (PaymentStatus = '" + cmbPaymentStatus.Text + "' )";
                else
                    query += "  PaymentStatus = '" + cmbPaymentStatus.Text + "' ";

            if (query != "")
            {
                if (_dtFinancialPenalties.Rows.Count < 1)
                    return;
                _dtFinancialPenalties.DefaultView.RowFilter = query;

            }
            else
                _dtFinancialPenalties.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListOfContracts.Rows.Count.ToString();

        }
        private void _LoadData()
        {
            _ResetDefaultValues();
            _Loadtypes();
            _dtFinancialPenalties =clsFinancialPenaltie.GetAllFinancialPenalties();
            _dgvColumnDesign();
        }

        private void frmListOfFinancialPenalties_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void cmbByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cmbFilterBy.Text != "None");
            if (!txtFilterValue.Visible)
                txtFilterValue.Text = "";
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void txtFromCost_TextChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void cbCostFilter_CheckedChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void txtToCost_TextChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterFinancialPenalties();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateFinancialPenalty frmAddUpdateFinancialPenalty = new frmAddUpdateFinancialPenalty((int)dgvListOfContracts.CurrentRow.Cells[0].Value);
            frmAddUpdateFinancialPenalty.ShowDialog();
            this._LoadData();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails((int)dgvListOfContracts.CurrentRow.Cells[7].Value);
            frmUserDetails.ShowDialog();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails((int)dgvListOfContracts.CurrentRow.Cells[8].Value);
            frmUserDetails.ShowDialog();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateFinancialPenalty frmAddUpdateFinancialPenalty =new frmAddUpdateFinancialPenalty();
            frmAddUpdateFinancialPenalty.ShowDialog();
            this._LoadData();
        }
    }
}
