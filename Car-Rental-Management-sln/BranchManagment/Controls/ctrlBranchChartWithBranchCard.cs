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
    public partial class ctrlBranchChartWithBranchCard : UserControl
    {
        public ctrlBranchChartWithBranchCard()
        {
            InitializeComponent();
        }
        public void LoadBranchChart(short Year ,int BranchID)
        {
            ctrlBranchCard1.LoadData(BranchID);
            ctrlBranchChart2.LoadBranchChart(Year,BranchID);
        }
        public void LoadBranchChartForNumOfRental(short Year, int BranchID)
        {
            ctrlBranchCard1.LoadData(BranchID);
            ctrlBranchChart2.LoadBranchChartForNumOfRental(Year, BranchID);
        }
        public void LoadBranchChartForEarningsChart(short Year, int BranchID)
        {
            ctrlBranchCard1.LoadData(BranchID);
            ctrlBranchChart2.LoadBranchChartForEarningsChart(Year, BranchID);
        }
        public void LoadBranchChartForExpenseChart(short Year, int BranchID)
        {
            ctrlBranchCard1.LoadData(BranchID);
            ctrlBranchChart2.LoadBranchChartForExpenseChart(Year, BranchID);
        }

    }
}
