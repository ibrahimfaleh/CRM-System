using CarRental.Classes;
using CarRental_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Users
{
    public partial class frmListUsers : Form
    {
        DataTable _dtAllUsers;
        private int? _BranchID;
        public frmListUsers()
        {
            InitializeComponent();
        }
        public frmListUsers(int BranchID)
        {
            InitializeComponent();
            this._BranchID = BranchID;
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
        private void _LoadColumns()
        {
            dgvUsers.DataSource = _dtAllUsers;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            if (_dtAllUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "City ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "Branch ID";
                dgvUsers.Columns[1].Width = 100;

                dgvUsers.Columns[2].HeaderText = "City Name";
                dgvUsers.Columns[2].Width = 250;

                dgvUsers.Columns[3].HeaderText = "Branch Name";
                dgvUsers.Columns[3].Width = 250;

                dgvUsers.Columns[4].HeaderText = "Employee ID";
                dgvUsers.Columns[4].Width = 100;

                dgvUsers.Columns[5].HeaderText = "Person ID";
                dgvUsers.Columns[5].Width = 100;

                dgvUsers.Columns[6].HeaderText = "User ID";
                dgvUsers.Columns[6].Width = 100;


                dgvUsers.Columns[7].HeaderText = "Full Name";
                dgvUsers.Columns[7].Width = 250;

                dgvUsers.Columns[8].HeaderText = "Gendor";
                dgvUsers.Columns[8].Width = 150;

                dgvUsers.Columns[9].HeaderText = "User Name";
                dgvUsers.Columns[9].Width = 150;



                dgvUsers.Columns[10].HeaderText = "Is Active";
                dgvUsers.Columns[10].Width = 100;
            }
        }
        private  void _LoadData()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            LoadCities();
            _LoadColumns();
        }
        private void _LoadData(int BranchID)
        {
            cmbBranches.Enabled = false;
            cmbCityName.Enabled = false;
            _dtAllUsers = clsUser.GetAllUsers(BranchID);
            LoadCities();
            _LoadColumns();
        }
        private void frmListUser_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListUsers))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FilterUsers()
        {
            string query = "";
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
                    case "User ID":
                        if (query != "")
                            query += " And (UserID = " + txtFilterValue.Text + ") ";
                        else
                            query += " UserID = " + txtFilterValue.Text + " ";
                        break;

                    case "User Name":
                        if (query != "")
                            query += " And (UserName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  UserName like '" + txtFilterValue.Text + "%' ";
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

            if (cbIsActive.Text != "All" && cbIsActive.Text != "")
                if (query != "")
                    query += " And (Active = '" + cbIsActive.Text.Trim() + "' )";
                else
                    query += "  Active = '" + cbIsActive.Text.Trim() + "' ";

            if (query != "")
            {
                if (_dtAllUsers.Rows.Count < 1)
                    return;
                _dtAllUsers.DefaultView.RowFilter = query;

            }
            else
                _dtAllUsers.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();

        }


        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
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
            if (cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
            if (_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
        }

        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dgvUsers.CurrentRow.Cells[6].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadBranches(cmbCityName.Text);
            _FilterUsers();
        }

        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterUsers();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterUsers();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterUsers();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[6].Value);
            frmAddUpdateUser.ShowDialog();
        }
    }
}
