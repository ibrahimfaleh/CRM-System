using CarRental.Classes;
using CarRental.Rental_Transaction;
using CarRental_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Users
{
    public partial class ctrldgListUsersTransActions : UserControl
    {
        private int? _UserID = null;
        private int _BranchID;
        private DataTable _dtTransActionsUsers;
        private DataTable _dtTransactionOnCreatedUsers;
        private DataTable _dtTransactionOnUpdatedUsers;
        public ctrldgListUsersTransActions()
        {
            InitializeComponent();
        }
        private bool _ShowUserDetailsVisible = true;
        public bool ShowUserDetailsVisible
        {
            set
            {
                _ShowUserDetailsVisible = value;
                guna2ContextMenuStrip1.Items[1].Visible = _ShowUserDetailsVisible;
            }
            get
            { return _ShowUserDetailsVisible; }
        }



        private void _FullComboBoxRentalTransaction()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.Add("None");
            cbFilterBy.Items.Add("User ID");
            cbFilterBy.Items.Add("UserName");
            cbFilterBy.Items.Add("Transaction ID");
            cbFilterBy.Items.Add("Full Name");
            cbFilterBy.SelectedIndex = 0;
        }
        private void _FullComboBoxTransactionOnCreatedUsers()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.Add("None");
            cbFilterBy.Items.Add("User ID");
            cbFilterBy.Items.Add("UserName");
            cbFilterBy.Items.Add("Created User ID");
            cbFilterBy.Items.Add("Created UserName");
            cbFilterBy.SelectedIndex = 0;
        }
        private void _FullComboBoxTransactionOnUpdatedUsers()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.Add("None");
            cbFilterBy.Items.Add("Update ID");
            cbFilterBy.Items.Add("Updated By User ID");
            cbFilterBy.Items.Add("Updated By UserName");
            cbFilterBy.Items.Add("User ID");
            cbFilterBy.Items.Add("UserName");
            cbFilterBy.SelectedIndex = 0;
        }



        private void _RentalTransactionColumns()
        {
            if (_dtTransActionsUsers.Rows.Count > 0)
            {

                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                dgv.Columns[0].Width = 1;
                dgv.Columns[1].HeaderText = "User ID";
                dgv.Columns[1].Width = 150;

                dgv.Columns[2].HeaderText = "UserName";
                dgv.Columns[2].Width =200;

                dgv.Columns[3].HeaderText = "TransAction ID";
                dgv.Columns[3].Width = 150;

                dgv.Columns[4].HeaderText = "Full Name";
                dgv.Columns[4].Width = 250;

                dgv.Columns[5].HeaderText = "TransAction Type";
                dgv.Columns[5].Width = 200;

                dgv.Columns[6].HeaderText = "Created Date";
                dgv.Columns[6].Width = 200;

            }
        }
        private void _TransactionOnCreatedUsersColumns()
        {
            if (_dtTransactionOnCreatedUsers.Rows.Count > 0)
            {

                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                dgv.Columns[0].Width = 1;
                dgv.Columns[1].HeaderText = "User ID";
                dgv.Columns[1].Width = 150;

                dgv.Columns[2].HeaderText = "UserName";
                dgv.Columns[2].Width = 150;

                dgv.Columns[3].HeaderText = "Created UserID";
                dgv.Columns[3].Width = 150;

                dgv.Columns[4].HeaderText = "Created UserName";
                dgv.Columns[4].Width = 150;

                dgv.Columns[5].HeaderText = "Created Date";
                dgv.Columns[5].Width = 250;
            }
        }
        private void _TransactionOnUpdatedUsersColumns()
        {
            if (_dtTransactionOnUpdatedUsers.Rows.Count > 0)
            {

                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                dgv.Columns[0].Width = 1;
                dgv.Columns[1].HeaderText = "Updated ID";
                dgv.Columns[1].Width = 150;

                dgv.Columns[2].HeaderText = "Updated By User ID";
                dgv.Columns[2].Width = 150;

                dgv.Columns[3].HeaderText = "Updated By UserName";
                dgv.Columns[3].Width = 150;

                dgv.Columns[4].HeaderText = "User ID";
                dgv.Columns[4].Width = 150;

                dgv.Columns[5].HeaderText = "UserName";
                dgv.Columns[5].Width = 150;

                dgv.Columns[6].HeaderText = "Is Updated UserName";
                dgv.Columns[6].Width = 150;

                dgv.Columns[7].HeaderText = "Is Updated PassWord";
                dgv.Columns[7].Width = 150;

                dgv.Columns[8].HeaderText = "Is Updated Active";
                dgv.Columns[8].Width = 150;

                dgv.Columns[9].HeaderText = "Updated Date";
                dgv.Columns[9].Width = 200;
            }
        }





        private void _FilterRentalTransaction()
        {
            string FilterByIncomeStatus = "";
            string FilterColumn = "";
                switch (cbFilterBy.Text)
                {
                    case "Transaction ID":
                        FilterColumn = "TransactionID";
                        break;
                    case "User ID":
                        FilterColumn = "UserID";
                        break;

                    case "Full Name":
                        FilterColumn = "FullName";
                        break;

                    case "UserName":
                        FilterColumn = "UserName";
                        break;

                    default:
                        FilterColumn = "None";
                        break;

                }

                switch (cbTransAcionType.Text)
                {
                    case "All":
                        FilterByIncomeStatus = "'Created Rental Booking' Or 1>0)";
                        break;

                    case "Rental Booking":
                        FilterByIncomeStatus = "'Created Rental Booking')";
                        break;

                    case "Created User":
                        FilterByIncomeStatus = "'Created User')";
                        break;
                    case "Vehicle Return":
                        FilterByIncomeStatus = "'Vehicle Return')";
                        break;

                }
                if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
                {
                    if (_dtTransActionsUsers.Rows.Count < 1)
                        return;
                    _dtTransActionsUsers.DefaultView.RowFilter = string.Format("( TransActionType ={0} ", FilterByIncomeStatus.Trim());

                    lblRecordsCount.Text = dgv.Rows.Count.ToString();
                    return;
                }


                if (FilterColumn == "TransactionID" || FilterColumn == "UserID")

                    _dtTransActionsUsers.DefaultView.RowFilter = string.Format("[{0}] = {1} and (TransActionType ={2} ", FilterColumn, txtFilterValue.Text.Trim(), FilterByIncomeStatus.Trim());
                else
                    _dtTransActionsUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'and (TransActionType ={2}", FilterColumn, txtFilterValue.Text.Trim(), FilterByIncomeStatus.Trim());
        }
        private void _FilterTransactionOnUpdatedUsers()
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "Update ID":
                    FilterColumn = "UpdateID";
                    break;
                case "Updated By User ID":
                    FilterColumn = "UpdatedByUserID";
                    break;

                case "Updated By UserName":
                    FilterColumn = "UpdatedByUserName";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtTransactionOnUpdatedUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UpdateID" || FilterColumn == "UserID" || FilterColumn == "UpdatedByUserID")

                _dtTransactionOnUpdatedUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}  ", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtTransactionOnUpdatedUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
        }
        private void _FilterTransactionOnCreatedUsers()
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "Created User ID":
                    FilterColumn = "CreatedUserID";
                    break;

                case "Created UserName":
                    FilterColumn = "CreatedUserName";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtTransactionOnCreatedUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UpdateID" || FilterColumn == "UserID" || FilterColumn == "CreatedUserID")

                _dtTransactionOnCreatedUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}  ", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtTransactionOnCreatedUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
        }





        private void _LoadTransactionOnCreatedUsers()
        {
            guna2ContextMenuStrip1.Items[0].Visible = false;
            guna2ContextMenuStrip1.Items[2].Visible = true;
            guna2ContextMenuStrip1.Items[3].Visible = false;

            dgv.Columns.Clear();
            dgv.Columns.Add("null", "");
            dgv.DataSource = _dtTransactionOnCreatedUsers;
            _FullComboBoxTransactionOnCreatedUsers();
            _TransactionOnCreatedUsersColumns();
        }
        private void _LoadTransactionOnUpdatedUsers()
        {
            guna2ContextMenuStrip1.Items[0].Visible = false;
            guna2ContextMenuStrip1.Items[3].Visible = true;
            guna2ContextMenuStrip1.Items[2].Visible = false;
            dgv.Columns.Clear();
            dgv.Columns.Add("null", "");
            dgv.DataSource = _dtTransactionOnUpdatedUsers;
            _FullComboBoxTransactionOnUpdatedUsers();
            _TransactionOnUpdatedUsersColumns();
        }
        private void _LoadRentalTransaction()
        {
            guna2ContextMenuStrip1.Items[0].Visible = true;
            guna2ContextMenuStrip1.Items[2].Visible = false;
            guna2ContextMenuStrip1.Items[3].Visible = false;
            dgv.Columns.Clear();
            dgv.Columns.Add("null", "");
            dgv.DataSource = _dtTransActionsUsers;
            _FullComboBoxRentalTransaction();
            _RentalTransactionColumns();
        }




        public void ctrldgListUsersTransActions_LoadByBranchID(int BranchID)
        {
            _BranchID = BranchID;
            _dtTransactionOnCreatedUsers = clsUser.GetTransactionOnCreatedUsersByBranchID(BranchID);
            _dtTransActionsUsers = clsUser.GetRentalTransActionsUsersByBranchID(BranchID);
            _dtTransactionOnUpdatedUsers = clsUser.GetTransactionOnUpdatedUsersByBranchID(BranchID);
            if (rbRentalTransaction.Checked)
                _LoadRentalTransaction();
            if (rbTransactionOnCreatedUsers.Checked)
                _LoadTransactionOnCreatedUsers();
            if (rbTransactionOnUpdatedUsers.Checked)
                _LoadTransactionOnUpdatedUsers();
        }
        public void ctrldgListUsersTransActions_LoadByUserID(int UserID)
        {
            _UserID = UserID;
            _dtTransActionsUsers = clsUser.GetRentalTransActionsUsersByUserID(UserID);
            _dtTransactionOnCreatedUsers = clsUser.GetTransactionOnCreatedUsersByUserID(UserID);
            _dtTransactionOnUpdatedUsers = clsUser.GetTransactionOnUpdatedUsersByUserID(UserID);
            if (rbRentalTransaction.Checked)
                _LoadRentalTransaction();
            if (rbTransactionOnCreatedUsers.Checked)
                _LoadTransactionOnCreatedUsers();
            if (rbTransactionOnUpdatedUsers.Checked)
                _LoadTransactionOnUpdatedUsers();
        }

        public void ctrldgListUsersTransActions_Load()
        {
            _dtTransActionsUsers = clsUser.GetRentalTransActionsUsers();
            _dtTransactionOnCreatedUsers = clsUser.GetTransactionOnCreatedUsers();
            _dtTransactionOnUpdatedUsers = clsUser.GetTransactionOnUpdatedUsers();
            if (rbRentalTransaction.Checked)
                _LoadRentalTransaction();
            if (rbTransactionOnCreatedUsers.Checked)
                _LoadTransactionOnCreatedUsers();
            if (rbTransactionOnUpdatedUsers.Checked)
                _LoadTransactionOnUpdatedUsers();
        }




        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (rbRentalTransaction.Checked)
                _FilterRentalTransaction();
            if (rbTransactionOnUpdatedUsers.Checked)
                _FilterTransactionOnUpdatedUsers();
            if(rbTransactionOnCreatedUsers.Checked)
                _FilterTransactionOnCreatedUsers();


            lblRecordsCount.Text = dgv.Rows.Count.ToString();

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
            if (cbFilterBy.Text == "Transaction ID" || cbFilterBy.Text == "User ID"||cbFilterBy.Text=="Created By User ID"|| cbFilterBy.Text == "Updated By User ID" || cbFilterBy.Text == "Updated On User ID" || cbFilterBy.Text == "Updated ID")
                e.Handled = !clsValidatoin.ValidatePositiveNumbers(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }




        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser;
            if (rbTransactionOnUpdatedUsers.Checked)
                frmUser = new frmUserDetails((int)dgv.CurrentRow.Cells[2].Value);
            else
                frmUser = new frmUserDetails((int)dgv.CurrentRow.Cells[1].Value);

            frmUser.ShowDialog();
        }

        private void showDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Cells[5].Value.ToString() == "CreatedUser")
            {
                frmUserDetails frmUser = new frmUserDetails((int)dgv.CurrentRow.Cells[1].Value);
                frmUser.ShowDialog();
            }
            else
            {
                frmShowRentalTransActionInfo frm = new frmShowRentalTransActionInfo((int)dgv.CurrentRow.Cells[3].Value);
                frm.ShowDialog();
            }

        }

        private void showUpdatedUserDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgv.CurrentRow.Cells[4].Value);
            frmUser.ShowDialog();
        }

        private void showCreatedUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUser = new frmUserDetails((int)dgv.CurrentRow.Cells[3].Value);
            frmUser.ShowDialog();
        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_UserID == null)
                ctrldgListUsersTransActions_LoadByBranchID(_BranchID);
            else
                ctrldgListUsersTransActions_LoadByUserID(_UserID.Value);
        }



        private void rbRentalTransaction_Click(object sender, EventArgs e)
        {
            _LoadRentalTransaction();
        }

        private void rbTransactionOnUpdatedUsers_Click(object sender, EventArgs e)
        {
            _LoadTransactionOnUpdatedUsers();
        }

        private void rbTransactionOnCreatedUsers_Click(object sender, EventArgs e)
        {
            _LoadTransactionOnCreatedUsers();
        }

        private void rbRentalTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRentalTransaction.Checked)
            {
                _LoadRentalTransaction();
                cbTransAcionType.Enabled = true;
            }
            else
                cbTransAcionType.Enabled = false;


        }

        private void rbTransactionOnUpdatedUsers_CheckedChanged(object sender, EventArgs e)
        {

            if (rbTransactionOnUpdatedUsers.Checked)
                _LoadTransactionOnUpdatedUsers();
        }

        private void rbTransactionOnCreatedUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTransactionOnCreatedUsers.Checked)
                _LoadTransactionOnCreatedUsers();
        }

        private void ctrldgListUsersTransActions_Load(object sender, EventArgs e)
        {

        }
    }
}
