using CarRental_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.People.Employee.Forms
{
    public partial class frmSelectEmployee : Form
    {
        public delegate void DataBackEventHandler(object sender,int EmployeeID);
        public event DataBackEventHandler DataBack;
        private int? _BranchID;
        private DataTable _dtEmployees;
        public frmSelectEmployee(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
        }
        private void _LoadColumns()
        {
            if(_dtEmployees.Columns.Count>0) 
            {
                dgv.DataSource = _dtEmployees;
                dgv.Columns[0].Width = 30;
                dgv.Columns[1].HeaderText = "Employee ID";
                dgv.Columns[1].Width = 170;
                dgv.Columns[2].HeaderText = "Full Name";
                dgv.Columns[2].Width=250;
            }
        }
        private void _LoadData()
        {
            if (_BranchID.HasValue)
            {
                _dtEmployees = clsEmployee.GetAllEmployeesForSelect(_BranchID.Value);
                _LoadColumns();
            }

            else
            {
                MessageBox.Show("You must log in to the branch", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmSelectEmployee_Load(object sender, EventArgs e)
        {
            _LoadData();
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
        private void _FilterEmployees()
        {
            string query = "";
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
                }
                if (query != "")
                {
                    if (_dtEmployees.Rows.Count < 1)
                        return;
                    _dtEmployees.DefaultView.RowFilter = query;

                }
                else
                    _dtEmployees.DefaultView.RowFilter = "";
            }
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Employee ID" || cbFilterBy.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterEmployees();
        }
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBack.Invoke(this, (int)dgv.CurrentRow.Cells[1].Value);
        }
        private void dgvListOfContracts_DoubleClick(object sender, EventArgs e)
        {
            DataBack.Invoke(this, (int)dgv.CurrentRow.Cells[1].Value);
        }
    }
}
