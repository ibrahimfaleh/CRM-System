using CarRental.Classes;
using CarRental.Users;
using CarRental_Business;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRental.Maintenance_Management
{
    public partial class ctrlListMaintenanceTransactions : UserControl
    {
        public enum enMode { AllMaintenanceTransactions =1, MaintenanceTransactionsByBranchID =2}
        private enMode _Mode;
        private int _BranchID;
        private DataTable _dtListMaintenanceTransactions;
        public ctrlListMaintenanceTransactions()
        {
            InitializeComponent();
        }
        private void _LoadDataGridViewMaintenanceTransactions()
        {
            dgvListMaintenanceTransactions.DataSource = _dtListMaintenanceTransactions;

            if (dgvListMaintenanceTransactions.Rows.Count > 0)
            {

                dgvListMaintenanceTransactions.Columns[0].HeaderText = "City ID";
                dgvListMaintenanceTransactions.Columns[0].Width = 150;

                dgvListMaintenanceTransactions.Columns[1].HeaderText = "City Name";
                dgvListMaintenanceTransactions.Columns[1].Width = 150;

                dgvListMaintenanceTransactions.Columns[2].HeaderText = "Branch ID";
                dgvListMaintenanceTransactions.Columns[2].Width = 50;

                dgvListMaintenanceTransactions.Columns[3].HeaderText = "Street Name";
                dgvListMaintenanceTransactions.Columns[3].Width = 150;

                dgvListMaintenanceTransactions.Columns[4].HeaderText = "Maintenance ID";
                dgvListMaintenanceTransactions.Columns[4].Width = 70;

                dgvListMaintenanceTransactions.Columns[5].HeaderText = "Vehicle ID";
                dgvListMaintenanceTransactions.Columns[5].Width = 150;

                dgvListMaintenanceTransactions.Columns[6].HeaderText = "Transferred By EmployeeID";
                dgvListMaintenanceTransactions.Columns[6].Width = 150;

                dgvListMaintenanceTransactions.Columns[7].HeaderText = "Consumed Mileage";
                dgvListMaintenanceTransactions.Columns[7].Width = 150;

                dgvListMaintenanceTransactions.Columns[8].HeaderText = "Cost";
                dgvListMaintenanceTransactions.Columns[8].Width = 200;

                dgvListMaintenanceTransactions.Columns[9].HeaderText = "Maintenance Date";
                dgvListMaintenanceTransactions.Columns[9].Width = 200;

                dgvListMaintenanceTransactions.Columns[10].HeaderText = "Return Date";
                dgvListMaintenanceTransactions.Columns[10].Width = 200;

                dgvListMaintenanceTransactions.Columns[11].HeaderText = "Return By EmployeeID";
                dgvListMaintenanceTransactions.Columns[11].Width = 100;

                dgvListMaintenanceTransactions.Columns[12].HeaderText = "Created By UserID";
                dgvListMaintenanceTransactions.Columns[12].Width = 150;

                dgvListMaintenanceTransactions.Columns[13].HeaderText = "Updated By UserID";
                dgvListMaintenanceTransactions.Columns[13].Width = 150;

                dgvListMaintenanceTransactions.Columns[14].HeaderText = "Status";
                dgvListMaintenanceTransactions.Columns[14].Width = 150;

            }
            lblRecordsCount.Text = dgvListMaintenanceTransactions.Rows.Count.ToString();
        }

        public void LoadData()
        {
            _Mode = enMode.AllMaintenanceTransactions;
            _dtListMaintenanceTransactions=clsMaintenanceTransaction.GetAllMaintenanceTransactions();
            _LoadDataGridViewMaintenanceTransactions();
        }
        public void LoadData(int BranchID)
        {
            _BranchID = BranchID;   
            _Mode = enMode.MaintenanceTransactionsByBranchID;
            _dtListMaintenanceTransactions = clsMaintenanceTransaction.GetAllMaintenanceTransactions(BranchID);
            _LoadDataGridViewMaintenanceTransactions();
        }
        private void _FilterVehicles()
        {
            string query = "";

            if (!cbMaintenanceFees.Checked && (txtFromMaintenanceFees.TextLength > 0) && txtToMaintenanceFees.TextLength > 0)
            {
                query = "Cost >= " + txtFromMaintenanceFees.Text + " And Cost <= " + txtToMaintenanceFees.Text;
            }

            if (!cbStartDate.Checked)
            {

                if (query != "")
                    query += " And (MaintenanceDate >=  '" + dtpFromStartDate.Value.ToString("dd-MM-yyyy") + "'  And MaintenanceDate <= '" + dtpToStartDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " MaintenanceDate >=  '" + dtpFromStartDate.Value.ToString("dd-MM-yyyy") + "'  And MaintenanceDate <= '" + dtpToStartDate.Value.ToString("dd-MM-yyyy") + "' ";
            }
            if (cmbStatus.Text != "All" && cmbStatus.Text != "")
                if (query != "")
                    query += " And (Status =  '" + cmbStatus.Text + "' )";
                else
                    query += " Status =  '" + cmbStatus.Text + " ' ";


            if (txtFilterValue.Text != "")
            {
                switch (cbFilterBy.Text)
                {
                    case "Vehicle ID":
                        if (query != "")
                            query += " And (VehicleID= " + txtFilterValue.Text + " )";
                        else
                            query += "  VehicleID= " + txtFilterValue.Text;
                        break;

                    case "Plate Number":
                        if (query != "")
                            query += " And (PlateNumber like '" + clsFormat.DeleteAllSpaceFromText(txtFilterValue.Text) + "%' )";
                        else
                            query += "  PlateNumber like '" + clsFormat.DeleteAllSpaceFromText(txtFilterValue.Text) + "%' ";
                        break;
                    case "Transferred By Employee ID":
                        if (query != "")
                            query += " And (TransferredByEmployeeID= " + txtFilterValue.Text + " )";
                        else
                            query += "  TransferredByEmployeeID= " + txtFilterValue.Text;
                        break;
                    case "Transferred By Employee NationalNo":
                        if (query != "")
                            query += " And (TransferredByEmployeeNationalNo= " + txtFilterValue.Text + " )";
                        else
                            query += "  TransferredByEmployeeNationalNo= " + txtFilterValue.Text;
                        break;
                    case "Return By EmployeeID":
                        if (query != "")
                            query += " And (VehicleReturnByEmployeeID= " + txtFilterValue.Text + " )";
                        else
                            query += "  VehicleReturnByEmployeeID= " + txtFilterValue.Text;
                        break;
                    case "Return By Employee NationalNo":
                        if (query != "")
                            query += " And (ReturnByEmployeeNationalNo= " + txtFilterValue.Text + " )";
                        else
                            query += "  ReturnByEmployeeNationalNo= " + txtFilterValue.Text;
                        break;
                    case "Created By USer ID":
                        if (query != "")
                            query += " And (CreatedByUserID= " + txtFilterValue.Text + " )";
                        else
                            query += "  CreatedByUserID= " + txtFilterValue.Text;
                        break;
                    case "Created By User NationalNo":
                        if (query != "")
                            query += " And (CreatedByUserNationalNo= " + txtFilterValue.Text + " )";
                        else
                            query += "  CreatedByUserNationalNo= " + txtFilterValue.Text;
                        break;
                    case "Updated By User ID":
                        if (query != "")
                            query += " And (UpdatedByUserID= " + txtFilterValue.Text + " )";
                        else
                            query += "  UpdatedByUserID= " + txtFilterValue.Text;
                        break;
                    case "Updated By User NationalNo":
                        if (query != "")
                            query += " And (UpdatedByUserNationalNo= " + txtFilterValue.Text + " )";
                        else
                            query += "  UpdatedByUserNationalNo= " + txtFilterValue.Text;
                        break;

                }
            }


            if (query != "")
            {
                if (_dtListMaintenanceTransactions.Rows.Count < 1)
                    return;
                _dtListMaintenanceTransactions.DefaultView.RowFilter = query;

            }
            else
                _dtListMaintenanceTransactions.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListMaintenanceTransactions.Rows.Count.ToString();

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

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void ctrlListMaintenanceTransactions_Load(object sender, EventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvListMaintenanceTransactions.CurrentRow.Cells[14].Value.ToString()!="Completed")
            {
                guna2ContextMenuStrip1.Items[2].Visible = false;
                guna2ContextMenuStrip1.Items[4].Visible = false;
            }
            else
            {
                guna2ContextMenuStrip1.Items[2].Visible = true;
                guna2ContextMenuStrip1.Items[4].Visible = true;
            }
        }

        private void updateRetuenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMaintenanceTransaction frm =new frmAddUpdateMaintenanceTransaction((int)dgvListMaintenanceTransactions.CurrentRow.Cells[4].Value);
            frm.ShowDialog();
            if (_Mode == enMode.AllMaintenanceTransactions)
                _dtListMaintenanceTransactions = clsMaintenanceTransaction.GetAllMaintenanceTransactions();
            if (_Mode == enMode.MaintenanceTransactionsByBranchID)
                _dtListMaintenanceTransactions = clsMaintenanceTransaction.GetAllMaintenanceTransactions(_BranchID);

        }

        private void showEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showCreatedByUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dgvListMaintenanceTransactions.CurrentRow.Cells[14].Value);  
            frm.ShowDialog();
            if(_Mode==enMode.AllMaintenanceTransactions)
                _dtListMaintenanceTransactions=clsMaintenanceTransaction.GetAllMaintenanceTransactions();
            if (_Mode == enMode.MaintenanceTransactionsByBranchID)
                _dtListMaintenanceTransactions = clsMaintenanceTransaction.GetAllMaintenanceTransactions(_BranchID);
        }

        private void showUpdatedByUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dgvListMaintenanceTransactions.CurrentRow.Cells[16].Value);
            frm.ShowDialog();
            if (_Mode == enMode.AllMaintenanceTransactions)
                _dtListMaintenanceTransactions = clsMaintenanceTransaction.GetAllMaintenanceTransactions();
            if (_Mode == enMode.MaintenanceTransactionsByBranchID)
                _dtListMaintenanceTransactions = clsMaintenanceTransaction.GetAllMaintenanceTransactions(_BranchID);
        }

        private void cbMaintenanceFees_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void dtpFromStartDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void dtpToStartDate_ValueChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }

        private void cbStartDate_CheckedChanged(object sender, EventArgs e)
        {
            _FilterVehicles();
        }
    }
}
