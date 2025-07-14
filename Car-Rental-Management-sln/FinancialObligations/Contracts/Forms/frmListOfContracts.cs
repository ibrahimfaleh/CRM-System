using CarRental.Classes;
using CarRental.FinancialObligations.Contracts.Forms;
using CarRental.Users;
using CarRental_Business;
using Guna.UI2.WinForms;
using Microsoft.AnalysisServices.Tabular;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmListOfContracts : Form
    {
        public enum enMode { AllContracts=1,ContractsByBranchID}
        private enMode _Mode;
        private DataTable _dtContracts;
        private int? _BranchID;
        public frmListOfContracts()
        {
            InitializeComponent();
            _Mode = enMode.AllContracts;
        }
        public frmListOfContracts(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
            _Mode = enMode.ContractsByBranchID;
        }
        private void _LoadContractType()
        {
            foreach(DataRow row in clsTypesContract.GetAllTypesContracts().Rows)
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
        private void _LoadDataTableFromContracts(int BranchID)
        {
            _dtContracts=clsContract.GetAllContracts(BranchID);
        }
        private void _LoadDataTableFromContracts()
        {
            _dtContracts = clsContract.GetAllContracts();
        }
        private void _ResetDefaultValues()
        {
            _LoadContractType();
            dtpFromDate.MinDate=DateTime.Now.AddYears(-50);
            dtpFromDate.MaxDate=DateTime.Now.AddYears(50);
            dtpToDate.MinDate = DateTime.Now.AddYears(-50);
            dtpToDate.MaxDate = DateTime.Now.AddYears(50);
        }
        private void _LoadData(int BranchID)
        {
            _LoadDataTableFromContracts(BranchID);
            _dgvColumnDesign();
            clsBranch branch = clsBranch.Find(BranchID);
            cmbBranches.Items.Clear();
            cmbBranches.Items.Add(branch.StreetName);
            cmbCityName.Items.Add(branch.City.CityName);
            cmbBranches.SelectedIndex = 0;
            cmbCityName.SelectedIndex = 0;

        }
        private void _LoadData()
        {
            LoadCities();
            _LoadDataTableFromContracts();
            _dgvColumnDesign();
        }
        private void _dgvColumnDesign()
        {
            if (_dtContracts.Columns.Count > 0)
            {
                dgvListOfContracts.DataSource = _dtContracts;
                dgvListOfContracts.Columns[0].HeaderText = "Branch ID";
                dgvListOfContracts.Columns[0].Width = 50;

                dgvListOfContracts.Columns[1].HeaderText = "City Name";
                dgvListOfContracts.Columns[1].Width = 150;

                dgvListOfContracts.Columns[2].HeaderText = "Street Name";
                dgvListOfContracts.Columns[2].Width = 150;

                dgvListOfContracts.Columns[3].HeaderText = "Contract ID";
                dgvListOfContracts.Columns[3].Width = 150;

                dgvListOfContracts.Columns[4].HeaderText = "Contract Type";
                dgvListOfContracts.Columns[4].Width = 200;

                dgvListOfContracts.Columns[5].HeaderText = "Start Contract";
                dgvListOfContracts.Columns[5].Width = 180;

                dgvListOfContracts.Columns[6].HeaderText = "End Contract";
                dgvListOfContracts.Columns[6].Width = 180;

                dgvListOfContracts.Columns[7].HeaderText = "Contract Amount";
                dgvListOfContracts.Columns[7].Width = 200;

                dgvListOfContracts.Columns[8].HeaderText = "Initial Payment";
                dgvListOfContracts.Columns[8].Width = 200;

                dgvListOfContracts.Columns[9].HeaderText = "Final Payment";
                dgvListOfContracts.Columns[9].Width = 200;

                dgvListOfContracts.Columns[10].HeaderText = "Payment Type";
                dgvListOfContracts.Columns[10].Width = 150;

                dgvListOfContracts.Columns[11].HeaderText = "T.Amount Paid";
                dgvListOfContracts.Columns[11].Width = 150;

                dgvListOfContracts.Columns[12].HeaderText = "T.Remaining.A";
                dgvListOfContracts.Columns[12].Width = 150;

                dgvListOfContracts.Columns[13].HeaderText = "C.By UserID";
                dgvListOfContracts.Columns[13].Width = 150;

                dgvListOfContracts.Columns[14].HeaderText = "C.Date";
                dgvListOfContracts.Columns[14].Width = 150;

                dgvListOfContracts.Columns[15].HeaderText = "U.By User ID";
                dgvListOfContracts.Columns[15].Width = 150;

                dgvListOfContracts.Columns[16].HeaderText = "U.Date";
                dgvListOfContracts.Columns[16].Width = 150;

                dgvListOfContracts.Columns[17].HeaderText = "Payment Status";
                dgvListOfContracts.Columns[17].Width = 150;

                dgvListOfContracts.Columns[18].HeaderText = "Active";
                dgvListOfContracts.Columns[18].Width = 100;

                lblRecordsCount.Text = _dtContracts.Rows.Count.ToString();
            }
        }
        private void _FilterContracts()
        {
            string query = "";

            if (cbContractAmountFilter.Checked && (txtFromContractAmountt.Text!="") && txtToContractAmount.Text!="")
                query = "ContractAmount >= " + txtFromContractAmountt.Text + " And ContractAmount <= " + txtToContractAmount.Text;



            switch (cmbByDate.Text)
            {
                case "Created Date":
                    if (query != "")
                        query += " And ( CreatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And  CreatedDate <='" + dtpToDate.Value.ToString("MM-yyyy") + "'  )";
                    else
                        query += " CreatedDate >=  '" + dtpFromDate.Value.ToString("MM-yyyy") + "'  And CreatedDate <= '" + dtpToDate.Value.ToString("MM-yyyy") + "' ";
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

            if (cmbActive.Text != "All" && cmbActive.Text != "")
                if (query != "")
                    query += " And (Active = '" + cmbActive.Text + "' )";
                else
                    query += "  Active = '" + cmbActive.Text + "' ";

            if (cmbPaymentStatus.Text != "All" && cmbPaymentStatus.Text != "")
                if (query != "")
                    query += " And (PaymentStatus = '" + cmbPaymentStatus.Text + "' )";
                else
                    query += "  PaymentStatus = '" + cmbPaymentStatus.Text + "' ";

            if (cmbContractType.Text != "All" && cmbContractType.Text != "")
                if (query != "")
                    query += " And (Type = '" + cmbContractType.Text + "' )";
                else
                    query += "  Type = '" + cmbContractType.Text + "' ";






            if (query != "")
            {
                if (_dtContracts.Rows.Count < 1)
                    return;
                _dtContracts.DefaultView.RowFilter = query;

            }
            else
                _dtContracts.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListOfContracts.Rows.Count.ToString();

        }

        private void txtFromContractAmountt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void frmListOfContracts_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.AllContracts)
                _LoadData();
            if (_Mode == enMode.ContractsByBranchID)
                _LoadData(_BranchID.Value);
        }

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cmbFilterBy.Text != "None");
            _FilterContracts();
        }

        private void cbContractAmountFilter_CheckedChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void txtToContractAmount_TextChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void txtFromContractAmountt_TextChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void cmbContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterContracts();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract  frm = new frmAddUpdateContract((int)dgvListOfContracts.CurrentRow.Cells[3].Value);
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgvListOfContracts.CurrentRow.Cells[13].Value);
            frmUser.ShowDialog();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvListOfContracts.CurrentRow.Cells[15].Value.ToString()!="")
            {
                frmUserDetails frmUser = new frmUserDetails((int)dgvListOfContracts.CurrentRow.Cells[15].Value);
                frmUser.ShowDialog();
            }

        }

        private void cmbByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterContracts();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterContracts();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterContracts();
        }

        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterContracts();
            if (_Mode == enMode.ContractsByBranchID)
                return;
            _LoadBranches(cmbCityName.Text);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowContractDetails frmShowContractDetails = new frmShowContractDetails((int)dgvListOfContracts.CurrentRow.Cells[3].Value);
            frmShowContractDetails.ShowDialog();    

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract frmAddUpdateContract = new frmAddUpdateContract();
            frmAddUpdateContract.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract frmAddUpdateContract = new frmAddUpdateContract();
            frmAddUpdateContract.ShowDialog();  
            frmListOfContracts_Load(null,null);
        }
    }
}
