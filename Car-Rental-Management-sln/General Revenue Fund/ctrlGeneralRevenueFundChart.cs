using CarRental_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.General_Revenue_Fund
{
    public partial class ctrlGeneralRevenueFundChart : UserControl
    {
        public ctrlGeneralRevenueFundChart()
        {
            InitializeComponent();
        }

        private void _RestDefaultValues()
        {
            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.Series.Add("s1");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            chart1.Series[0].IsValueShownAsLabel = true;

        }
        public void ChartOfAllSourcesOfIncome(int GeneralFundID)
        {
            _RestDefaultValues();
            chart1.Titles.Add("All Sources Of Income");

            clsGeneralRevenueFund General = clsGeneralRevenueFund.Find(GeneralFundID);
            if (General != null)
            {

                chart1.Series[0].Points.AddY(General.ActualProfits);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Actual Profits";

                chart1.Series[0].Points.AddY(General.ExpectedProfit);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Expected Profit";
                chart1.Series[0].Points.AddY(General.AnotherIncome);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Another Income";
                chart1.Series[0].Points.AddY(General.VehicleBreakdownRevenues);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Vehicle Breakdown Revenues";
                chart1.Series[0].Points.AddY(General.VehicleSales);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Vehicle Sales";
            }

        }
        public void ActualProfitsChartForBranches(int GeneralFundID)
        {
            _RestDefaultValues();
            chart1.Titles.Add("Actual Profits");
            clsGeneralRevenueFund General = clsGeneralRevenueFund.Find(GeneralFundID);
            if (General != null)
            {
                if (General.IsClosed)
                {
                    foreach (DataRow row in clsBranchChart.GetCharFromToYear((short)General.CreatedDate.Year, (short)General.ClosedDate?.Year).Rows)
                    {
                        chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = clsBranch.Find((int)row[1]).StreetName;;

                    }
                }
                else
                {
                    foreach (DataRow row in clsBranchChart.GetCharFromToYear((short)General.CreatedDate.Year, (short)DateTime.Now.Year).Rows)
                    {
                        chart1.Series[0].Points.AddY(row[6]);
                        chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = clsBranch.Find((int)row[1]).StreetName;;
                    }
                }
                chart1.Series[0].Points.AddY(General.ExpectedProfit);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Expected Profit";
                chart1.Series[0].Points.AddY(General.AnotherIncome);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Another Income";
                chart1.Series[0].Points.AddY(General.VehicleBreakdownRevenues);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Vehicle Breakdown Revenues";

            }

        }
        public void ExpectedProfitChartForBranches(int GeneralFundID)
        {
            _RestDefaultValues();
            chart1.Titles.Add(" Expected Profits");

            clsGeneralRevenueFund General = clsGeneralRevenueFund.Find(GeneralFundID);
            if (General != null)
            {
                if (General.IsClosed)
                {
                    foreach (DataRow row in clsBranchChart.GetCharFromToYear((short)General.CreatedDate.Year, (short)General.ClosedDate?.Year).Rows)
                    {

                        chart1.Series[0].Points.AddY(row["ExpectedNewProfits"]);

                        chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = clsBranch.Find((int)row[1]).StreetName;;

                    }
                }
                else
                {
                    foreach (DataRow row in clsBranchChart.GetCharFromToYear((short)General.CreatedDate.Year, (short)DateTime.Now.Year).Rows)
                    {
                        chart1.Series[0].Points.AddY(row[7]);
                        chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = clsBranch.Find((int)row[1]).StreetName;

                    }
                }

                chart1.Series[0].Points.AddY(General.ActualProfits);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Actual Profits";
                chart1.Series[0].Points.AddY(General.AnotherIncome);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Another Income";
                chart1.Series[0].Points.AddY(General.VehicleBreakdownRevenues);
                chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].LegendText = "Vehicle Breakdown Revenues";
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
