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

namespace CarRental.Contract_Payment_Scheduling_Applications
{
    public partial class frmListOfSchedulingApplication : Form
    {
        private int? _BranchID;
        private DataTable _dtApplications;
        public frmListOfSchedulingApplication()
        {
            InitializeComponent();
        }
        private void _LoadContractType()
        {
            foreach (DataRow row in clsTypesContract.GetAllTypesContracts().Rows)
            {
                cmbContractType.Items.Add(row[1]);
            }
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
        private void _ResetDefaultValues()
        {
            _LoadContractType();
            dtpFromDate.MinDate = DateTime.Now.AddYears(-50);
            dtpFromDate.MaxDate = DateTime.Now.AddYears(50);
            dtpToDate.MinDate = DateTime.Now.AddYears(-50);
            dtpToDate.MaxDate = DateTime.Now.AddYears(50);
        }
        private void _dgvColumnDesign()
        {
            if (_dtApplications.Columns.Count > 0)
            {
                dgv.DataSource = _dtApplications;

                dgv.Columns[0].HeaderText = "City Name";
                dgv.Columns[0].Width = 150;

                dgv.Columns[1].HeaderText = "Street Name";
                dgv.Columns[1].Width = 150;

                dgv.Columns[2].HeaderText = "Application ID";
                dgv.Columns[2].Width = 150;


                dgv.Columns[3].HeaderText = "Contract ID";
                dgv.Columns[3].Width = 150;

                dgv.Columns[4].HeaderText = "Contract Type";
                dgv.Columns[4].Width = 200;

                dgv.Columns[5].HeaderText = "Start Contract";
                dgv.Columns[5].Width = 180;

                dgv.Columns[6].HeaderText = "End Contract";
                dgv.Columns[6].Width = 180;

                dgv.Columns[7].HeaderText = "Contract Amount";
                dgv.Columns[7].Width = 200;


                dgv.Columns[8].HeaderText = "Number of Installments";
                dgv.Columns[8].Width = 200;

                dgv.Columns[9].HeaderText = "N.Of Installments Paid";
                dgv.Columns[9].Width = 200;

                dgv.Columns[10].HeaderText = "N.Of.R Installments";
                dgv.Columns[10].Width = 200;


                dgv.Columns[11].HeaderText = "T.Amount Paid";
                dgv.Columns[11].Width = 150;

                dgv.Columns[12].HeaderText = "T.Remaining.A";
                dgv.Columns[12].Width = 150;

                dgv.Columns[13].HeaderText = "Status";
                dgv.Columns[13].Width = 100;

                dgv.Columns[14].HeaderText = "C.By UserID";
                dgv.Columns[14].Width = 150;


                dgv.Columns[15].HeaderText = "U.By User ID";
                dgv.Columns[15].Width = 150;

                dgv.Columns[16].HeaderText = "C.Date";
                dgv.Columns[16].Width = 150;

                dgv.Columns[17].HeaderText = "U.Date";
                dgv.Columns[17].Width = 150;

                lblRecordsCount.Text = _dtApplications.Rows.Count.ToString();
            }
        }
        private void _FilterApplications()
        {
            string query = "";

            if (cbContractAmountFilter.Checked && (txtFromContractAmountt.Text != "") && txtToContractAmount.Text != "")
                query = "ContractAmount >= " + txtFromContractAmountt.Text + " And ContractAmount <= " + txtToContractAmount.Text;



            switch (cmbByDate.Text)
            {
                case "Created Date":
                    if (query != "")
                        query += " And ( CreatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  CreatedDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " CreatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And CreatedDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                case "Updated Date":
                    if (query != "")
                        query += " And ( UpdatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  UpdatedDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " UpdatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And UpdatedDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                case "Start Contract":
                    if (query != "")
                        query += " And ( StartContract >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  StartContract <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " StartContract >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And StartContract <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                case "End Contract":
                    if (query != "")
                        query += " And ( EndContract >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  EndContract <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " EndContract >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And EndContract <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
                    break;

                default:

                    break;
            }



            if (txtFilterValue.Text.Length > 0)
            {
                switch (cmbFilterBy.Text)
                {

                    case "Application ID":
                        if (query != "")
                            query += " And (ApplicationID = " + txtFilterValue.Text + ") ";
                        else
                            query += " ApplicationID = " + txtFilterValue.Text + " ";
                        break;

                    case "Contract ID":
                        if (query != "")
                            query += " And (ContractID = " + txtFilterValue.Text + ") ";
                        else
                            query += " ContractID = " + txtFilterValue.Text + " ";
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


            if (cmbStatus.Text != "All" && cmbStatus.Text != "")
                if (query != "")
                    query += " And (Status = '" + cmbStatus.Text + "' )";
                else
                    query += "  Status = '" + cmbStatus.Text + "' ";

            if (cmbContractType.Text != "All" && cmbContractType.Text != "")
                if (query != "")
                    query += " And (Type = '" + cmbContractType.Text + "' )";
                else
                    query += "  Type = '" + cmbContractType.Text + "' ";






            if (query != "")
            {
                if (_dtApplications.Rows.Count < 1)
                    return;
                _dtApplications.DefaultView.RowFilter = query;

            }
            else
                _dtApplications.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgv.Rows.Count.ToString();

        }
        private void _LoadData(int BranchID)
        {
            cmbCityName.Items.Clear();
            cmbBranches.Items.Clear();
            cmbCityName.Enabled = false;
            cmbBranches.Enabled = false;
            _dtApplications=clsContractPaymentSchedulingApplication.GetAllContractPaymentSchedulingApplications(BranchID);
            _dgvColumnDesign();
        }
        private void _LoadData()
        {
            LoadCities();
            _dtApplications = clsContractPaymentSchedulingApplication.GetAllContractPaymentSchedulingApplications();
            _dgvColumnDesign();
        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cmbFilterBy.Text != "None");
            _FilterApplications();
        }
        private void cmbContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCityName.Text == "All")
                cmbBranches.Text = "All";
            else
            _LoadBranches(cmbCityName.Text);

            _FilterApplications();
        }
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void cmbByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void txtFromContractAmountt_TextChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void txtToContractAmount_TextChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void cbContractAmountFilter_CheckedChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterApplications();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateContractPaymentScheduling frmAddUpdateContractPaymentScheduling = new frmAddUpdateContractPaymentScheduling((int)dgv.CurrentRow.Cells[2].Value);
            frmAddUpdateContractPaymentScheduling.ShowDialog();    
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentOfInstallments frm = new frmPaymentOfInstallments((int)dgv.CurrentRow.Cells[2].Value);
            frm.ShowDialog();

        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails userDetails = new frmUserDetails((int)dgv.CurrentRow.Cells[14].Value);
            userDetails.ShowDialog();   
        }
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails userDetails = new frmUserDetails((int)dgv.CurrentRow.Cells[15].Value);
            userDetails.ShowDialog();
        }
        private void frmListOfSchedulingApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
        }
    }
}
