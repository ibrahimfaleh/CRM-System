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
using System.Windows.Forms.DataVisualization.Charting;

namespace CarRental
{
    public partial class ctrlAllBranchesInAChart : UserControl
    {
        private short _Year;
        public ctrlAllBranchesInAChart()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            guna2NumericUpDown1.Minimum = DateTime.Now.Year - 50;
            guna2NumericUpDown1.Maximum = DateTime.Now.Year + 50;
            guna2NumericUpDown1.Value = DateTime.Now.Year;
            _Year = (short)guna2NumericUpDown1.Value;
            rbEarnings.Checked = true;
        }
        private void _LoadBranchChartForNumOfRental()
        {
            ctrlBranchChart2.LoadBranchChartForNumOfRental(_Year);
            dgv.DataSource = ctrlBranchChart2.DataTable;
        }
        private void _LoadBranchChartForEarningsChart( )
        {
            ctrlBranchChart2.LoadBranchChartForEarningsChart(_Year);
            dgv.DataSource = ctrlBranchChart2.DataTable;

        }
        private void _LoadBranchChartForExpectedNewProfitsChart()
        {
            ctrlBranchChart2.LoadBranchChartForExpectedNewProfitsChart(_Year);
            dgv.DataSource = ctrlBranchChart2.DataTable;

        }
        private void _LoadBranchChartForExpenseContractAmountsChart( )
        {
            ctrlBranchChart2.LoadBranchChartForExpenseContractAmountsChart( _Year );
            dgv.DataSource = ctrlBranchChart2.DataTable;

        }
        private void _LoadBranchChartForTotalIncomeChart( )
        {
            ctrlBranchChart2.LoadBranchChartForTotalIncomeChart( _Year );
            dgv.DataSource = ctrlBranchChart2.DataTable;

        }
        private void _LoadBranchChartForExpenseSalaryPaymentsChart( )
        {
            ctrlBranchChart2.LoadBranchChartForExpenseSalaryPaymentsChart(_Year);
            dgv.DataSource = ctrlBranchChart2.DataTable;

        }

        private void LoadBranchChartForTotalAmountOfBillsPaid()
        {
            ctrlBranchChart2.LoadBranchChartForTotalAmountOfBillsPaid(_Year);
            dgv.DataSource = ctrlBranchChart2.DataTable;

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _Year = (short)guna2NumericUpDown1.Value;
            if (rbSalaryPayments.Checked)
                _LoadBranchChartForExpenseSalaryPaymentsChart();
            if (rbBranchChartForNumOfRental.Checked)
                _LoadBranchChartForNumOfRental();
            if (rbTotalIncomeChart.Checked)
                _LoadBranchChartForTotalIncomeChart();
            if (rbExpectedNewProfitsChart.Checked)
                _LoadBranchChartForExpectedNewProfitsChart();
            if (rbEarnings.Checked)
                _LoadBranchChartForEarningsChart();
            if (rbTotalBillPaidAmounts.Checked)
                LoadBranchChartForTotalAmountOfBillsPaid();
            if (rbTotalContractAmounts.Checked)
                _LoadBranchChartForExpenseContractAmountsChart();
        }

        private void rbSalaryPayments_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSalaryPayments.Checked)
                _LoadBranchChartForExpenseSalaryPaymentsChart();

        }

        private void rbBranchChartForNumOfRental_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBranchChartForNumOfRental.Checked)
                _LoadBranchChartForNumOfRental();
        }

        private void rbEarnings_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEarnings.Checked)
                _LoadBranchChartForEarningsChart();
        }

        private void rbTotalIncomeChart_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTotalIncomeChart.Checked)
                _LoadBranchChartForTotalIncomeChart();  
        }

        private void rbExpectedNewProfits_CheckedChanged(object sender, EventArgs e)
        {
            if(rbExpectedNewProfitsChart.Checked)
                _LoadBranchChartForExpectedNewProfitsChart();

        }

        private void rbTotalContractAmounts_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTotalContractAmounts.Checked)
                _LoadBranchChartForExpenseContractAmountsChart();
                
        }

        private void rbTotalBillPaidAmounts_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTotalBillPaidAmounts.Checked)
                LoadBranchChartForTotalAmountOfBillsPaid();
        }
    }
}
