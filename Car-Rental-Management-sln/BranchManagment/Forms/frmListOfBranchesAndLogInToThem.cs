using CarRental.BranchManagment.Forms;
using CarRental.Classes;
using CarRental.Rental_Transaction.Rental_Settings;
using CarRental_Business;
using Guna.UI2.WinForms;
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
    public partial class frmListOfBranchesAndLogInToThem : Form
    {
        public delegate void DataBackEventHandler(object sender, int BranchID);
        public event DataBackEventHandler DataBack;
        private DataTable _dtBranches;
        frmAdministration _frmAdministration;
        public enum enMode { Select , Login}
        enMode _Mode = enMode.Select;
        public frmListOfBranchesAndLogInToThem(frmAdministration administration)
        {
            InitializeComponent();
            _frmAdministration = administration;
            _Mode = enMode.Login;
        }
        public frmListOfBranchesAndLogInToThem()
        {
            InitializeComponent();
        }
        private void _LoadCities()
        {
            foreach (DataRow row in clsCity.GetAllCities().Rows)
            {
                cmbCities.Items.Add(row[1]);
            }
        }
        private void _LoadDataTableFormBranches()
        {
            _dtBranches = clsBranch.GetAllBranches();
            if (_dtBranches.Columns.Count>0)
            {
                dgvListOfBranches.DataSource = _dtBranches;
                dgvListOfBranches.Columns[0].HeaderText = "Branch ID";
                dgvListOfBranches.Columns[0].Width = 100;

                dgvListOfBranches.Columns[1].HeaderText = "City Name";
                dgvListOfBranches.Columns[1].Width = 150;

                dgvListOfBranches.Columns[2].HeaderText = "Street Name";
                dgvListOfBranches.Columns[2].Width = 200;

                dgvListOfBranches.Columns[3].HeaderText = "Branch Location";
                dgvListOfBranches.Columns[3].Width = 150;

                dgvListOfBranches.Columns[4].HeaderText = "N.of daily income Boxes";
                dgvListOfBranches.Columns[4].Width = 170;

                dgvListOfBranches.Columns[5].HeaderText = "Start Amount";
                dgvListOfBranches.Columns[5].Width = 135;

                dgvListOfBranches.Columns[6].HeaderText = "Is Public";
                dgvListOfBranches.Columns[6].Width = 100;
                lblRecordsCount.Text=_dtBranches.Rows.Count.ToString(); 
            }
        }
        private void _ResetDefaultValues()
        {
            lblTitle.Text = "List Of Branches";
            _LoadCities();
            _LoadDataTableFormBranches();
            contextMenuStrip1.Items[0].Visible = false;
            contextMenuStrip1.Items[1].Visible = false;
            contextMenuStrip1.Items[2].Visible = true;
            contextMenuStrip1.Items[3].Visible = true;
        }
        private void _LoadDataForModeLogin()
        {
            lblTitle.Text = "List Of Branches And Log In To Them";
            contextMenuStrip1.Items[0].Visible = true;
            contextMenuStrip1.Items[1].Visible = true;
            contextMenuStrip1.Items[2].Visible = true;
            contextMenuStrip1.Items[3].Visible = false;
        }
        private void frmListOfBranchesAndLogInToThem_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode==enMode.Login)
                _LoadDataForModeLogin();

        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilterBy.Text!="None")
                txtFilterValue.Visible = true;
            else
                txtFilterValue.Visible = false;
            string Filter = "";
            if (txtFilterValue.Text != "")
                switch (cmbFilterBy.Text)
                {
                    case "Branch ID":
                        Filter = " BranchID= " + txtFilterValue.Text + " ";
                        break;
                    case "Branch Manager ID":
                        Filter = " BranchManagerID= " + txtFilterValue.Text + " ";
                        break;
                }
            if (cmbCities.Text != "All")
            {
                if (Filter != "")
                    Filter += " And CityName = '" + cmbCities.Text + "' ";
                else
                    Filter += "  CityName = '" + cmbCities.Text + "' ";
            }

            _dtBranches.DefaultView.RowFilter = Filter;

            lblRecordsCount.Text=dgvListOfBranches.Rows.Count.ToString();   
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmAdministration.Hide();
            frmMain frmMain = new frmMain(_frmAdministration, (int)dgvListOfBranches.CurrentRow.Cells[0].Value);
            frmMain.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranchManagment frm = new frmBranchManagment((int)dgvListOfBranches.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbFilterBy.Text=="Branch ID")
            e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers( e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(sender, (int)dgvListOfBranches.CurrentRow.Cells[0].Value);
            this.Close();
            
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranchDetails frmBranchDetails = new frmBranchDetails((int)dgvListOfBranches.CurrentRow.Cells[0].Value);
            frmBranchDetails.ShowDialog();  
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmBranchManagment frmBranchManagment = new frmBranchManagment();
            frmBranchManagment.ShowDialog();
            frmListOfBranchesAndLogInToThem_Load(null,null);
        }

        private void frmListOfBranchesAndLogInToThem_Shown(object sender, EventArgs e)
        {

        }
    }
}
