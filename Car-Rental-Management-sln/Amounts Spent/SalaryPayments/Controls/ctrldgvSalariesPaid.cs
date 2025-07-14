using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental.Users;
using CarRental_Business;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CarRental.Amounts_Spent.Salary_Payments
{
    public partial class ctrldgvSalariesPaid : UserControl
    {
        private DataTable _dtSalariesPaid;
        private int? _BranchID;
        public ctrldgvSalariesPaid()
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
        public void LoadSalariesPaid()
        {
            _FillDepartmentNameInComboBox();
            _dtSalariesPaid = clsSalaryPayment.GetAllSalariesPaid();
            cmbBranches.Items.Clear();
            _SalariesPaidColumns();
            LoadCities();
        }
        public void LoadSalariesPaid(int BranchID)
        {
            _BranchID= BranchID;
            _dtSalariesPaid = clsSalaryPayment.GetAllSalariesPaid(_BranchID.Value);
            _FillDepartmentNameInComboBox();
            cmbCityName.Items.Clear();
            cmbBranches.Items.Clear();
            cmbCityName.Enabled = false;
            cmbBranches.Enabled = false;
            _SalariesPaidColumns();
        }
        private void _FillDepartmentNameInComboBox()
        {
            foreach (DataRow row in clsDepartment.GetAllDepartments().Rows)
            {
                cmbDepbartmennt.Items.Add(row["DepartmentName"]);
            }
            cmbDepbartmennt.Items.Add("All");

        }
        private void _SalariesPaidColumns()
        {
            if (_dtSalariesPaid.Rows.Count > 0)
            {
                dgvListSalariesPaid.DataSource = _dtSalariesPaid;
                lblRecordsCount.Text = dgvListSalariesPaid.Rows.Count.ToString();

                dgvListSalariesPaid.Columns[0].HeaderText = "City";
                dgvListSalariesPaid.Columns[0].Width = 190;

                dgvListSalariesPaid.Columns[1].HeaderText = "Street";
                dgvListSalariesPaid.Columns[1].Width = 190;

                dgvListSalariesPaid.Columns[2].HeaderText = "Department";
                dgvListSalariesPaid.Columns[2].Width = 150;

                dgvListSalariesPaid.Columns[3].HeaderText = "Employee ID";
                dgvListSalariesPaid.Columns[3].Width = 100;


                dgvListSalariesPaid.Columns[4].HeaderText = "NationalNo";
                dgvListSalariesPaid.Columns[4].Width = 150;

                dgvListSalariesPaid.Columns[5].HeaderText = "Full Name";
                dgvListSalariesPaid.Columns[5].Width = 220;

                dgvListSalariesPaid.Columns[6].HeaderText = "Gendor";
                dgvListSalariesPaid.Columns[6].Width = 90;

                dgvListSalariesPaid.Columns[7].HeaderText = "Hire Date";
                dgvListSalariesPaid.Columns[7].Width = 250;

                dgvListSalariesPaid.Columns[8].HeaderText = "Exit Date";
                dgvListSalariesPaid.Columns[8].Width = 250;


                dgvListSalariesPaid.Columns[9].HeaderText = "Monthly Salary";
                dgvListSalariesPaid.Columns[9].Width = 200;


                dgvListSalariesPaid.Columns[10].HeaderText = "Paid Amount";
                dgvListSalariesPaid.Columns[10].Width = 200;

                dgvListSalariesPaid.Columns[11].HeaderText = "Deducted Amount";
                dgvListSalariesPaid.Columns[11].Width = 200;


                dgvListSalariesPaid.Columns[12].HeaderText = "Amount Spent ID";
                dgvListSalariesPaid.Columns[12].Width = 100;

                dgvListSalariesPaid.Columns[13].HeaderText = "P.By UserID";
                dgvListSalariesPaid.Columns[13].Width = 100;

                dgvListSalariesPaid.Columns[14].HeaderText = "U.By UserID";
                dgvListSalariesPaid.Columns[14].Width = 100;

                dgvListSalariesPaid.Columns[15].HeaderText = "Payment Date";
                dgvListSalariesPaid.Columns[15].Width = 250;

                dgvListSalariesPaid.Columns[16].HeaderText = "Updated Date";
                dgvListSalariesPaid.Columns[16].Width = 250;

            }
        }
        private void _FilterSalariesPaid()
        {
            string query = "";

            if (!cbSalary.Checked && (txtFromSalary.TextLength > 0) && txtToSalary.TextLength > 0)
                query = "MonthlySalary >= " + txtFromSalary.Text + " And MonthlySalary <= " + txtToSalary.Text;
            if (!cbHireDate.Checked)
            {
                if (query != "")
                    query += " And (HireDate >=  '" + dtpFromHireDate.Value.ToString("dd-MM-yyyy") + "'  And HireDate<= '" + dtpToHireDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " HireDate >=  '" + dtpFromHireDate.Value.ToString("dd-MM-yyyy") + "'  And HireDate <= '" + dtpToHireDate.Value.ToString("dd-MM-yyyy") + "' ";

            }
            if (!cbExitDate.Checked)
            {
                if (query != "")
                    query += " And ( ExitDate >=  '" + dtpFromExitDate.Value.ToString("dd-MM-yyyy") + "'  And  ExitDate <='" + dtpToExitDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " ExitDate >=  '" + dtpFromExitDate.Value.ToString("dd-MM-yyyy") + "'  And ExitDate <= '" + dtpToExitDate.Value.ToString("dd-MM-yyyy") + "' ";

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
                switch (cbFilterBy.Text)
                {
                    case "Employee ID":
                        if (query != "")
                            query += " And (EmployeeID = " + txtFilterValue.Text + ") ";
                        else
                            query += " EmployeeID = " + txtFilterValue.Text + " ";
                        break;

                    case "Full Name":
                        if (query != "")
                            query += " And (FullName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  FullName like '" + txtFilterValue.Text + "%' ";
                        break;

                    case "Phone":
                        if (query != "")
                            query += " And (Phone like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  Phone like '" + txtFilterValue.Text + "%' ";
                        break;

                    default:

                        break;

                }
            }

            if (cmbDepbartmennt.Text != "All" && cmbDepbartmennt.Text != "")
                if (query != "")
                    query += " And (DepartmentName = '" + cmbDepbartmennt.Text + "' )";
                else
                    query += "  DepartmentName = '" + cmbDepbartmennt.Text + "' ";







            if (query != "")
            {
                if (_dtSalariesPaid.Rows.Count < 1)
                    return;
                _dtSalariesPaid.DefaultView.RowFilter = query;

            }
            else
                _dtSalariesPaid.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListSalariesPaid.Rows.Count.ToString();

        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Employee ID" || cbFilterBy.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtFromSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void ctrldgvSalariesPaid_Load(object sender, EventArgs e)
        {

        }
        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterSalariesPaid();
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterSalariesPaid();
        }
        private void cmbBranch_TextChanged(object sender, EventArgs e)
        {
            _FilterSalariesPaid();
        }
        private void txtFromSalary_TextChanged(object sender, EventArgs e)
        {
            txtToSalary.Text = txtFromSalary.Text;
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
        private void cmbDepbartmennt_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterSalariesPaid();
        }
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateAmountSpent addUpdateAmountSpent = new frmAddUpdateAmountSpent((int)dgvListSalariesPaid.CurrentRow.Cells[12].Value);
            addUpdateAmountSpent.ShowDialog();

        }
        private void showCreatedUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dgvListSalariesPaid.CurrentRow.Cells[13].Value);
            frm.ShowDialog();
        }
        private void showUpdatedUserDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgvListSalariesPaid.CurrentRow.Cells[14].Value);
            frmUser.ShowDialog();
        }
        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadBranches(cmbCityName.Text);
            _FilterSalariesPaid();
        }

        private void ctrldgvSalariesPaid_Load_1(object sender, EventArgs e)
        {

        }
    }
}
