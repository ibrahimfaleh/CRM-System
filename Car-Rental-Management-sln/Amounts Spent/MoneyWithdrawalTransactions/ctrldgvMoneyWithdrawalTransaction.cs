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

namespace CarRental.Amounts_Spent.Money_Withdrawal_Transactions
{
    public partial class ctrldgvMoneyWithdrawalTransaction : UserControl
    {
        private DataTable _dtMoneyWithdrawalTransaction;
        private int _GeneralRevenueFundID;


        public event Action<int> OnMoneyWithdrawalTransactionID;
        protected virtual void MoneyWithdrawalTransactionID(int PersonID)
        {
            Action<int> handler = OnMoneyWithdrawalTransactionID;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public ctrldgvMoneyWithdrawalTransaction()
        {
            InitializeComponent();
        }
        private void _MoneyWithdrawalTransactionColumns()
        {
            if (_dtMoneyWithdrawalTransaction.Rows.Count > 0)
            {
                dgvListMoneyWithdrawalTransactions.DataSource = _dtMoneyWithdrawalTransaction;
                lblRecordsCount.Text = dgvListMoneyWithdrawalTransactions.Rows.Count.ToString();
                dgvListMoneyWithdrawalTransactions.Columns[0].Width = 10;
                dgvListMoneyWithdrawalTransactions.Columns[1].HeaderText = "Transaction ID";
                dgvListMoneyWithdrawalTransactions.Columns[1].Width = 130;

                dgvListMoneyWithdrawalTransactions.Columns[2].HeaderText = "Amount Spent ID";
                dgvListMoneyWithdrawalTransactions.Columns[2].Width = 130;

                dgvListMoneyWithdrawalTransactions.Columns[3].HeaderText = "Full Name";
                dgvListMoneyWithdrawalTransactions.Columns[3].Width = 150;

                dgvListMoneyWithdrawalTransactions.Columns[4].HeaderText = "Total Amount";
                dgvListMoneyWithdrawalTransactions.Columns[4].Width = 150;


                dgvListMoneyWithdrawalTransactions.Columns[5].HeaderText = "Amount.V.B.R ";
                dgvListMoneyWithdrawalTransactions.Columns[5].Width = 150;

                dgvListMoneyWithdrawalTransactions.Columns[6].HeaderText = "Details";
                dgvListMoneyWithdrawalTransactions.Columns[6].Width = 250;

                dgvListMoneyWithdrawalTransactions.Columns[7].HeaderText = "Payment Details";
                dgvListMoneyWithdrawalTransactions.Columns[7].Width = 100;



                dgvListMoneyWithdrawalTransactions.Columns[8].HeaderText = "Created By User ID";
                dgvListMoneyWithdrawalTransactions.Columns[8].Width = 120;

                dgvListMoneyWithdrawalTransactions.Columns[9].HeaderText = "User Name";
                dgvListMoneyWithdrawalTransactions.Columns[9].Width = 150;

                dgvListMoneyWithdrawalTransactions.Columns[10].HeaderText = "Update By User ID";
                dgvListMoneyWithdrawalTransactions.Columns[10].Width = 120;


                dgvListMoneyWithdrawalTransactions.Columns[11].HeaderText = "User Name";
                dgvListMoneyWithdrawalTransactions.Columns[11].Width = 150;


                dgvListMoneyWithdrawalTransactions.Columns[12].HeaderText = "Date";
                dgvListMoneyWithdrawalTransactions.Columns[12].Width = 150;

                dgvListMoneyWithdrawalTransactions.Columns[13].HeaderText = "Update Date";
                dgvListMoneyWithdrawalTransactions.Columns[13].Width = 150;

            }
        }
        private void _Filter_MoneyWithdrawalTransaction()
        {
            string query = "";

            if (!cbAmount.Checked && (txtFromAmount.TextLength > 0) && txtToAmount.TextLength > 0)
                query = "TotalAmount >= " + txtFromAmount.Text + " And TotalAmount <= " + txtToAmount.Text;
            if (!cbDate.Checked)
            {
                if (query != "")
                    query += " And (Date >=  '" + dtpFromDate.Value.ToString("dd-MM-yyyy") + "'  And Date<= '" + dtpToDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " Date >=  '" + dtpFromDate.Value.ToString("dd-MM-yyyy") + "'  And Date <= '" + dtpToDate.Value.ToString("dd-MM-yyyy") + "' ";

            }
            if (txtFilterValue.Text.Length > 0)
            {
                switch (cbFilterBy.Text)
                {
                    case "Transaction ID":
                        if (query != "")
                            query += " And (MoneyWithdrawalTransactionsID = " + txtFilterValue.Text + ") ";
                        else
                            query += " MoneyWithdrawalTransactionsID = " + txtFilterValue.Text + " ";
                        break;

                    case "Full Name":
                        if (query != "")
                            query += " And (FullName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  FullName like '" + txtFilterValue.Text + "%' ";
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

            if (query != "")
            {
                if (_dtMoneyWithdrawalTransaction.Rows.Count < 1)
                    return;
                _dtMoneyWithdrawalTransaction.DefaultView.RowFilter = query;

            }
            else
                _dtMoneyWithdrawalTransaction.DefaultView.RowFilter = "";
            lblRecordsCount.Text=dgvListMoneyWithdrawalTransactions.Rows.Count.ToString();
        }
        public void LoadMoneyWithdrawalTransaction(int _GeneralRevenueFundID)
        {
            _dtMoneyWithdrawalTransaction = clsMoneyWithdrawalTransaction.GetAllMoneyWithdrawalTransactions(_GeneralRevenueFundID);
            _MoneyWithdrawalTransactionColumns();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Transaction ID" || cbFilterBy.Text == "Created By User ID" || cbFilterBy.Text == "Updated By User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _Filter_MoneyWithdrawalTransaction();
        }

        private void txtFromAmount_TextChanged(object sender, EventArgs e)
        {
            txtToAmount.Text= txtFromAmount.Text;
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

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnMoneyWithdrawalTransactionID != null)
                MoneyWithdrawalTransactionID((int)dgvListMoneyWithdrawalTransactions.CurrentRow.Cells[1].Value);
        }

        private void showCreatedUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dgvListMoneyWithdrawalTransactions.CurrentRow.Cells[8].Value);
            frm.ShowDialog();
        }

        private void showUpdatedUserDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvListMoneyWithdrawalTransactions.CurrentRow.Cells[10].Value.ToString() == "")
                return;
            frmUserDetails frm = new frmUserDetails((int)dgvListMoneyWithdrawalTransactions.CurrentRow.Cells[10].Value);
            frm.ShowDialog();
        }

        private void cbAmount_CheckedChanged(object sender, EventArgs e)
        {
            _Filter_MoneyWithdrawalTransaction();
        }
    }
}
