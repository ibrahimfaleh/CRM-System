using CarRental.Rental_Fund.General_Revenue_Fund;
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

namespace CarRental.General_Revenue_Fund
{
    public partial class ctrldgvGeneralFundSupportTransactions : UserControl
    {
        private DataTable _dtGeneralFundSupportTransactions;
        private int _GeneralRevenueFundID;


        public event Action<bool> OnUpdateGeneralFundSupportTransactions;
        protected virtual void GeneralFundSupportTransactions(bool IsUpdate)
        {
            Action<bool> handler = OnUpdateGeneralFundSupportTransactions;
            if (handler != null)
            {
                handler(IsUpdate);
            }
        }
        public ctrldgvGeneralFundSupportTransactions()
        {
            InitializeComponent();
        }

        private void _GeneralFundSupportTransactionsColumns()
        {
            if (_dtGeneralFundSupportTransactions.Rows.Count > 0)
            {
                dgvListGeneralFundSupportTransactionss.DataSource = _dtGeneralFundSupportTransactions;
                lblRecordsCount.Text = dgvListGeneralFundSupportTransactionss.Rows.Count.ToString();
                dgvListGeneralFundSupportTransactionss.Columns[0].Width = 1;
                dgvListGeneralFundSupportTransactionss.Columns[1].HeaderText = "Transaction ID";
                dgvListGeneralFundSupportTransactionss.Columns[1].Width = 130;


                    dgvListGeneralFundSupportTransactionss.Columns[2].HeaderText = "Full Name";
                    dgvListGeneralFundSupportTransactionss.Columns[2].Width = 150;

                    dgvListGeneralFundSupportTransactionss.Columns[3].HeaderText = "Amount";
                    dgvListGeneralFundSupportTransactionss.Columns[3].Width = 150;

                    dgvListGeneralFundSupportTransactionss.Columns[4].HeaderText = "Details";
                    dgvListGeneralFundSupportTransactionss.Columns[4].Width = 100;

                    dgvListGeneralFundSupportTransactionss.Columns[5].HeaderText = "Created By User ID";
                    dgvListGeneralFundSupportTransactionss.Columns[5].Width = 120;

                    dgvListGeneralFundSupportTransactionss.Columns[6].HeaderText = "User Name";
                    dgvListGeneralFundSupportTransactionss.Columns[6].Width = 150;

                    dgvListGeneralFundSupportTransactionss.Columns[7].HeaderText = "Update By User ID";
                    dgvListGeneralFundSupportTransactionss.Columns[7].Width = 120;


                    dgvListGeneralFundSupportTransactionss.Columns[8].HeaderText = "User Name";
                    dgvListGeneralFundSupportTransactionss.Columns[8].Width = 150;


                    dgvListGeneralFundSupportTransactionss.Columns[9].HeaderText = "Date";
                    dgvListGeneralFundSupportTransactionss.Columns[9].Width = 150;

                    dgvListGeneralFundSupportTransactionss.Columns[10].HeaderText = "Update Date";
                    dgvListGeneralFundSupportTransactionss.Columns[10].Width = 150;

                }
        }
        private void _Filter_GeneralFundSupportTransactions()
        {
            string query = "";

            if (!cbAmount.Checked && (txtFromAmount.TextLength > 0) && txtToAmount.TextLength > 0)
                query = "Amount >= " + txtFromAmount.Text + " And Amount <= " + txtToAmount.Text;
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
                            query += " And (GeneralFundSupportTransactionssID = " + txtFilterValue.Text + ") ";
                        else
                            query += " GeneralFundSupportTransactionssID = " + txtFilterValue.Text + " ";
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
                if (_dtGeneralFundSupportTransactions.Rows.Count < 1)
                    return;
                _dtGeneralFundSupportTransactions.DefaultView.RowFilter = query;

            }
            else
                _dtGeneralFundSupportTransactions.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListGeneralFundSupportTransactionss.Rows.Count.ToString();
        }
        public void LoadGeneralFundSupportTransactions(int _GeneralRevenueFundID)
        {
            _dtGeneralFundSupportTransactions = clsGeneralFundSupportTransaction.GetAllGeneralFundSupportTransactions(_GeneralRevenueFundID);
            _GeneralFundSupportTransactionsColumns();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Transaction ID" || cbFilterBy.Text == "Created By User ID" || cbFilterBy.Text == "Updated By User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _Filter_GeneralFundSupportTransactions();
        }

        private void txtFromAmount_TextChanged(object sender, EventArgs e)
        {
            txtToAmount.Text = txtFromAmount.Text;
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
            frmGeneralFundSupport frmGeneralFundSupport = new frmGeneralFundSupport((int)dgvListGeneralFundSupportTransactionss.CurrentRow.Cells[1].Value);
            frmGeneralFundSupport.ShowDialog();
            if (OnUpdateGeneralFundSupportTransactions != null)
                OnUpdateGeneralFundSupportTransactions(true);
        }

        private void showCreatedUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dgvListGeneralFundSupportTransactionss.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
        }

        private void showUpdatedUserDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvListGeneralFundSupportTransactionss.CurrentRow.Cells[7].Value.ToString() != "")
            {
                frmUserDetails frmUserDetails = new frmUserDetails((int)dgvListGeneralFundSupportTransactionss.CurrentRow.Cells[7].Value);
                frmUserDetails.ShowDialog();
            }
        }
    }
}
