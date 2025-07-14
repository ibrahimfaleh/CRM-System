using CarRental.Rental_Transaction;
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

namespace CarRental.Rental_Fund
{
    public partial class ctrlDgvDailyFundTransaction : UserControl
    {
        private DataTable _dtDailyFundTransaction;
        private DataTable _dtSupportingFundLiquidity;
        private DataTable _dtPaidBills;
        private bool _SupportingFundLiquidityStripMenuItem = true;
        public bool SupportingFundLiquidityStripMenuItem
        {
            get
            {
                return _SupportingFundLiquidityStripMenuItem;
            }
            set
            {
                _SupportingFundLiquidityStripMenuItem = value;
                contextMenuStrip1.Items[1].Enabled = _SupportingFundLiquidityStripMenuItem;
            }
        }
        public ctrlDgvDailyFundTransaction()
        {
            InitializeComponent();
        }
        private void _ColumnDailyFundTransaction()
        {
            if (_dtDailyFundTransaction.Rows.Count > 0)
            {

                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                dgv.Columns[0].HeaderText = "IncomeFund Transaction ID";
                dgv.Columns[0].Width = 200;

                dgv.Columns[1].HeaderText = "DailyIncome Fund ID";
                dgv.Columns[1].Width = 200;

                dgv.Columns[2].HeaderText = "Rental TransAction ID";
                dgv.Columns[2].Width = 200;

                dgv.Columns[3].HeaderText = "Amount";
                dgv.Columns[3].Width = 200;

                dgv.Columns[4].HeaderText = "Payment Details";
                dgv.Columns[4].Width = 200;

                dgv.Columns[5].HeaderText = "Transaction Date";
                dgv.Columns[5].Width = 200;

            }
        }
        private void _ColumnBills()
        {
            if (_dtPaidBills.Rows.Count > 0)
            {

                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                dgv.Columns[0].HeaderText = "Transaction ID";
                dgv.Columns[0].Width = 130;

                dgv.Columns[1].HeaderText = "Bill ID";
                dgv.Columns[1].Width = 100;

                dgv.Columns[2].HeaderText = "Cost";
                dgv.Columns[2].Width = 150;

                dgv.Columns[3].HeaderText = "From Expected Profit";
                dgv.Columns[3].Width = 200;

                dgv.Columns[4].HeaderText = "Actual Profits";
                dgv.Columns[4].Width = 150;

                dgv.Columns[5].HeaderText = "From V.B.R";
                dgv.Columns[5].Width = 150;

                dgv.Columns[6].HeaderText = "Paid By User ID";
                dgv.Columns[6].Width = 150;

            }
        }
        private void _ColumnSupportingFundLiquidity()
        {
            if (_dtSupportingFundLiquidity.Rows.Count > 0)
            {

                lblRecordsCount.Text = dgv.Rows.Count.ToString();
                dgv.Columns[0].HeaderText = "Supporting ID";
                dgv.Columns[0].Width = 200;

                dgv.Columns[1].HeaderText = "IncomeFund Transaction ID";
                dgv.Columns[1].Width = 200;

                dgv.Columns[2].HeaderText = "DailyIncome Fund ID";
                dgv.Columns[2].Width = 200;

                dgv.Columns[3].HeaderText = "Rental TransAction ID";
                dgv.Columns[3].Width = 200;

                dgv.Columns[4].HeaderText = "Amount";
                dgv.Columns[4].Width = 200;

                dgv.Columns[5].HeaderText = "Payment Details";
                dgv.Columns[5].Width = 200;

                dgv.Columns[6].HeaderText = "Transaction Date";
                dgv.Columns[6].Width = 200;

            }
        }
        private void _LoadDailyFundTransaction()
        {
            dgv.Columns.Clear();
            dgv.DataSource = _dtDailyFundTransaction;
            _ColumnDailyFundTransaction();
        }
        private void _LoadSupportingFundLiquidity()
        {
            dgv.Columns.Clear();
            dgv.DataSource= _dtSupportingFundLiquidity;
            _ColumnSupportingFundLiquidity();
        }
        private void _LoadBills()
        {
            dgv.Columns.Clear();
            dgv.DataSource = _dtPaidBills;
            _ColumnBills();
        }
        public void DailyFundTransactions_Load(int DailyIncomeFundID)
        {
            _dtDailyFundTransaction=clsDailyIncomeFundTransaction.GetAllDailyIncomeFundTransactions(DailyIncomeFundID);
            _dtSupportingFundLiquidity = clsSupportingFundLiquidity.GetAllSupportingFundsLiquidity(DailyIncomeFundID);
            _dtPaidBills = clsDailyFundBill.GetAllDailyFundBills(DailyIncomeFundID);
            if(rbDailyFundTransaction.Checked)
                _LoadDailyFundTransaction();
            if(rbSupportingFundLiquidity.Checked)
                _LoadSupportingFundLiquidity();
            if (rbBills.Checked)
                _LoadBills();
        }

        private void dgv_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            contextMenuStrip1.Items[1].Visible = (float.Parse(dgv.CurrentRow.Cells[3].Value.ToString())) < 0;
        }
        private void rbDailyFundTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDailyFundTransaction.Checked)
            {
                _LoadDailyFundTransaction();
                contextMenuStrip1.Items[1].Visible = false;
            }

        }
        private void rbSupportingFundLiquidity_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSupportingFundLiquidity.Checked)
                _LoadSupportingFundLiquidity();
            contextMenuStrip1.Items[1].Visible = false;
        }
        private void rbBills_CheckedChanged(object sender, EventArgs e)
        {
            if( rbBills.Checked)    
                _LoadBills();
            contextMenuStrip1.Items[1].Visible = false;

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rbSupportingFundLiquidity.Checked)
            {
                frmShowRentalTransActionInfo frm = new frmShowRentalTransActionInfo((int)dgv.CurrentRow.Cells[3].Value);
                frm.ShowDialog();
            }
            if (rbDailyFundTransaction.Checked)
            {
                frmShowRentalTransActionInfo frm = new frmShowRentalTransActionInfo((int)dgv.CurrentRow.Cells[2].Value);
                frm.ShowDialog();
            }
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupportingFundLiquidity frm = new frmSupportingFundLiquidity((int)dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
