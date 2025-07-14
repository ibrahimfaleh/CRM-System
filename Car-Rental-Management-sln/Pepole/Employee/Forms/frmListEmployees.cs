using CarRental.Classes;
using CarRental.Users;
using CarRental_Business;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarRental.People.Employee
{
    public partial class frmListEmployees : Form
    {
        public delegate void DataBackEventHandler(object sender, int EmployeeID);
        public event DataBackEventHandler DataBack;
        private DataTable _dtEmployees;
        private int? _BranchID;
        public frmListEmployees()
        {
            InitializeComponent();
        }
        public frmListEmployees(int branchID)
        {
            InitializeComponent();
            _BranchID=branchID;
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
        private void _FillDepartmentNameInComboBox()
        {
            foreach (DataRow row in clsDepartment.GetAllDepartments().Rows)
            {
                cmbDepbartmennt.Items.Add(row["DepartmentName"]);
            }
            cmbDepbartmennt.Items.Add("All");

        }
        private void _EmployeesColumns()
        {
            if (_dtEmployees.Rows.Count > 0)
            {
                dgvListEmployees.DataSource = _dtEmployees;
                lblRecordsCount.Text = dgvListEmployees.Rows.Count.ToString();
                dgvListEmployees.Columns[0].HeaderText = "City";
                dgvListEmployees.Columns[0].Width = 200;

                dgvListEmployees.Columns[1].HeaderText = "Branch ID";
                dgvListEmployees.Columns[1].Width = 150;

                dgvListEmployees.Columns[2].HeaderText = "Street";
                dgvListEmployees.Columns[2].Width = 190;

                dgvListEmployees.Columns[3].HeaderText = "Department";
                dgvListEmployees.Columns[3].Width = 190;

                dgvListEmployees.Columns[4].HeaderText = "Employee ID";
                dgvListEmployees.Columns[4].Width = 150;

                dgvListEmployees.Columns[5].HeaderText = "Natioal No";
                dgvListEmployees.Columns[5].Width = 180;

                dgvListEmployees.Columns[6].HeaderText = "Full Naem";
                dgvListEmployees.Columns[6].Width = 200;

                dgvListEmployees.Columns[7].HeaderText = "Gendor";
                dgvListEmployees.Columns[7].Width = 100;

                dgvListEmployees.Columns[8].HeaderText = "Email";
                dgvListEmployees.Columns[8].Width = 150;

                dgvListEmployees.Columns[9].HeaderText = "Phone";
                dgvListEmployees.Columns[9].Width = 150;

                dgvListEmployees.Columns[10].HeaderText = "Monthly Salary";
                dgvListEmployees.Columns[10].Width = 200;

                dgvListEmployees.Columns[11].HeaderText = "Hire Date";
                dgvListEmployees.Columns[11].Width = 200;

                dgvListEmployees.Columns[12].HeaderText = "Exit Date";
                dgvListEmployees.Columns[12].Width = 200;

            }
        }
        private void _FilterEmployees()
        {
            string query = "";

            if (!cbSalary.Checked&&(txtFromSalary.TextLength>0)&&txtToSalary.TextLength>0)
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

            if (cmbBranches.Text != "All" && cmbBranches.Text != "")
                if (query != "")
                    query += " And (StreetName = '" + cmbBranches.Text.Trim() + "' )";
                else
                    query += "  StreetName = '" + cmbBranches.Text.Trim() + "' ";

            if (cmbDepbartmennt.Text != "All" && cmbDepbartmennt.Text != "")
                if (query != "")
                    query += " And (DepartmentName = '" + cmbDepbartmennt.Text + "' )";
                else
                    query += "  DepartmentName = '" + cmbDepbartmennt.Text + "' ";







            if (query != "")
            {
                if (_dtEmployees.Rows.Count < 1)
                    return;
                _dtEmployees.DefaultView.RowFilter = query;

            }
            else
                _dtEmployees.DefaultView.RowFilter = "";

        }
        private void _LoadData()
        {
            _FillDepartmentNameInComboBox();

            LoadCities();
            _dtEmployees = clsEmployee.GetAllEmployees();
            _EmployeesColumns();
        }
        private void _LoadData(int BranchID)
        {
            cmbBranches.Enabled = false;    
            cmbCityName.Enabled = false;
            _FillDepartmentNameInComboBox();
            LoadCities();
            _dtEmployees = clsEmployee.GetAllEmployees(BranchID);
            _EmployeesColumns();
        }
        private void frmListEmployees_Load(object sender, EventArgs e)
        {
            if (_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterEmployees();
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
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Employee ID" || cbFilterBy.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue_TextChanged(null, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtFromSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadBranches(cmbCityName.Text);
            _FilterEmployees();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frmAddUpdateEmployee = new frmAddUpdateEmployee((int)dgvListEmployees.CurrentRow.Cells[4].Value);
            frmAddUpdateEmployee.ShowDialog();
            if (_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ctrlEmployeeCardWithFilter1.cbFilterBy.Text = "Employee ID";
            frmAddUpdateUser.ctrlEmployeeCardWithFilter1.txtFilterValue.Text = dgvListEmployees.CurrentRow.Cells[4].Value.ToString();
            frmAddUpdateUser.ShowDialog();
            if (_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
                frmAddUpdateEmployee frmAddUpdateEmployee = new frmAddUpdateEmployee();
                frmAddUpdateEmployee.ShowDialog();
            frmListEmployees_Load(null,null);
        }
    }
}
