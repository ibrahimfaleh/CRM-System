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

namespace CarRental
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private   void frmDashboard_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in clsBranch.GetAllBranches().Rows)
            {
                ctrlStatisticsWithBranchCard ctrlStatisticsWithName = new ctrlStatisticsWithBranchCard();
                ctrlStatisticsWithName.LoadData((int)row[0]);
                ctrlStatisticsWithName.BorderStyle = BorderStyle.FixedSingle;
                flpListContrlols.Controls.Add(ctrlStatisticsWithName);

            }
            ctrlBranchesChart1.LoadData();
            ctrlStatistics1.LOadDateSumAllBranches();
            lblNumberOfBrances.Text = ctrlStatistics1.NumberOfBranches.ToString();
            ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(2);
            ctrlAllBranchesInAChart1.LoadData();
            ctrlGeneralRevenueFundChart1.ChartOfAllSourcesOfIncome(2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabMain_Click(object sender, EventArgs e)
        {

        }
    }
}
