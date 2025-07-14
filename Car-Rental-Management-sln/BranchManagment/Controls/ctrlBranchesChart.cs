using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ctrlBranchesChart : UserControl
    {
        private DataTable dtBranches;
        private List<ctrlBranchChartWithBranchCard> _ListBranchCharts = new List<ctrlBranchChartWithBranchCard>();
        private short Year;
        public ctrlBranchesChart()
        {
            InitializeComponent();
        }

        private void ctrlBranchesChart_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {

                dtBranches = clsBranch.GetAllBranches();
                foreach (DataRow row in dtBranches.Rows)
                {
                    ctrlBranchChartWithBranchCard ctrlBranchChartWithBranchCard1 = new ctrlBranchChartWithBranchCard();
                    ctrlBranchChartWithBranchCard1.LoadBranchChart(Year, (int)row[0]);
                    ctrlBranchChartWithBranchCard1.BorderStyle = BorderStyle.FixedSingle;
                    _ListBranchCharts.Add(ctrlBranchChartWithBranchCard1);
                }
                guna2NumericUpDown1.Minimum = DateTime.Now.Year - 100;
                guna2NumericUpDown1.Maximum = DateTime.Now.Year + 100;
                guna2NumericUpDown1.Value = DateTime.Now.Year;
                Year = (short)guna2NumericUpDown1.Value;
                rbBranchChart.Checked = true;
            
        }
        public void LoadData(int BranchID)
        {
            dtBranches = new DataTable();
            dtBranches.Columns.Add("BranchID",typeof(int));
            dtBranches.Rows.Add(BranchID);
            foreach (DataRow row in dtBranches.Rows)
            {
                ctrlBranchChartWithBranchCard ctrlBranchChartWithBranchCard1 = new ctrlBranchChartWithBranchCard();
                ctrlBranchChartWithBranchCard1.LoadBranchChart(Year, (int)row[0]);
                ctrlBranchChartWithBranchCard1.BorderStyle = BorderStyle.FixedSingle;
                ctrlBranchChartWithBranchCard1.Anchor = AnchorStyles.Left;
                ctrlBranchChartWithBranchCard1.Anchor = AnchorStyles.Right;
                _ListBranchCharts.Add(ctrlBranchChartWithBranchCard1);
            }
            guna2NumericUpDown1.Minimum = DateTime.Now.Year - 100;
            guna2NumericUpDown1.Maximum = DateTime.Now.Year + 100;
            guna2NumericUpDown1.Value = DateTime.Now.Year;
            Year = (short)guna2NumericUpDown1.Value;
            rbBranchChart.Checked = true;

        }
        private void _LoadBranchChart()
        {
            short i = 0;
            foreach (DataRow row in dtBranches.Rows)
            {
                _ListBranchCharts[i].LoadBranchChart(Year, (int)row[0]);
                _ListBranchCharts[i].BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(_ListBranchCharts[i]);
                i++;
            }
        }
        private void _LoadBranchChartForNumOfRental()
        {
            short i = 0;
            foreach (DataRow row in dtBranches.Rows)
            {
                _ListBranchCharts[i].LoadBranchChartForNumOfRental(Year,(int)row[0]);
                _ListBranchCharts[i].BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(_ListBranchCharts[i]);
                i++;

            }
        }
        private void _LoadBranchChartForEarningsChart()
        {
            short i = 0;
            foreach (DataRow row in dtBranches.Rows)
            {
                _ListBranchCharts[i].LoadBranchChartForEarningsChart(Year,(int)row[0]);
                _ListBranchCharts[i].BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(_ListBranchCharts[i]);
                i++;

            }
        }
        private void _LoadBranchChartForExpenseChart()
        {
            short i = 0;
            foreach (DataRow row in dtBranches.Rows)
            {
                _ListBranchCharts[i].LoadBranchChartForExpenseChart(Year,(int)row[0]);
                _ListBranchCharts[i].BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(_ListBranchCharts[i]);
                i++;

            }
        }

        private void rbChartForExpenseChart_CheckedChanged(object sender, EventArgs e)
        {
            if(rbChartForExpenseChart.Checked) 
            {
                _LoadBranchChartForExpenseChart();
            }
        }

        private void rbBranchChartForEarningsChart_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBranchChartForEarningsChart.Checked) 
            {
                _LoadBranchChartForEarningsChart();
            }
        }

        private void rbBranchChartForNumOfRental_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBranchChartForNumOfRental.Checked)
            {
                _LoadBranchChartForNumOfRental();    
            }
        }

        private void rbBranchChart_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBranchChart.Checked) 
            {
                _LoadBranchChart();
            }
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Year=(short)guna2NumericUpDown1.Value;
            if (rbBranchChart.Checked)
            {
                _LoadBranchChart();
            }
            if (rbBranchChartForNumOfRental.Checked)
            {
                _LoadBranchChartForNumOfRental();
            }
            if (rbBranchChartForEarningsChart.Checked)
            {
                _LoadBranchChartForEarningsChart();
            }
            if (rbChartForExpenseChart.Checked)
            {
                _LoadBranchChartForExpenseChart();
            }
        }
    }
}
