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
using System.Xml.Linq;

namespace CarRental.Customers
{
    public partial class frmListCustomers : Form
    {
        private DataTable dtCustomer;
        public frmListCustomers()
        {
            InitializeComponent();
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            dtCustomer = clsCustomer.GetAllCustomers();
            dgvCustomers.DataSource = dtCustomer;
            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
            if (dtCustomer.Rows.Count > 0)
            {
                dgvCustomers.Columns[0].HeaderText = "City Name";
                dgvCustomers.Columns[0].Width = 150;

                dgvCustomers.Columns[1].HeaderText = "Customer ID";
                dgvCustomers.Columns[1].Width = 100;

                dgvCustomers.Columns[2].HeaderText = "Person ID";
                dgvCustomers.Columns[2].Width = 100;

                dgvCustomers.Columns[3].HeaderText = "Full Name";
                dgvCustomers.Columns[3].Width = 250;

                dgvCustomers.Columns[4].HeaderText = "NationalNo";
                dgvCustomers.Columns[4].Width = 200;

                dgvCustomers.Columns[5].HeaderText = "Email";
                dgvCustomers.Columns[5].Width = 200;

                dgvCustomers.Columns[6].HeaderText = "Phone";
                dgvCustomers.Columns[6].Width = 150;

                dgvCustomers.Columns[7].HeaderText = "Gendor";
                dgvCustomers.Columns[7].Width = 150;

                dgvCustomers.Columns[8].HeaderText = "Driver License Number";
                dgvCustomers.Columns[8].Width = 200;

                dgvCustomers.Columns[9].HeaderText = "N.Of Times Rented";
                dgvCustomers.Columns[9].Width = 150;

                dgvCustomers.Columns[10].HeaderText = "Total Payments";
                dgvCustomers.Columns[10].Width = 200;

                dgvCustomers.Columns[11].HeaderText = "Gross profit";
                dgvCustomers.Columns[11].Width = 200;

                dgvCustomers.Columns[12].HeaderText = "Total.V.B";
                dgvCustomers.Columns[12].Width = 200;

                dgvCustomers.Columns[13].HeaderText = "Total Days";
                dgvCustomers.Columns[13].Width = 150;

                dgvCustomers.Columns[14].HeaderText = "Total Kilometers Consumed";
                dgvCustomers.Columns[14].Width = 200;
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "Customer ID":
                    FilterColumn = "CustomerID";
                    break;

                case "Name":
                    FilterColumn = "FullName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                dtCustomer.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "CustomerID")

                dtCustomer.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                dtCustomer.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();

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
            if (cbFilterBy.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCustomerInfo frm = new frmShowCustomerInfo((int)dgvCustomers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer((int)dgvCustomers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsCustomer.DeleteCustomer((int)dgvCustomers.CurrentRow.Cells[1].Value))
            {
                MessageBox.Show("Deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListCustomers_Load(null,null);
            }
            else
                MessageBox.Show("The deletion was not successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddNEw_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frmAddUpdateCustomer = new frmAddUpdateCustomer();
            frmAddUpdateCustomer.ShowDialog();
            frmListCustomers_Load(null, null);
        }
    }
}
