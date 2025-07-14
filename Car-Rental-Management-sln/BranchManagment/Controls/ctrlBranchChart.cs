using CarRental_Business;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarRental
{
    public partial class ctrlBranchChart : UserControl
    {

        public DataTable DataTable = new DataTable();
        public ctrlBranchChart()
        {
            InitializeComponent();
        }
        public void LoadBranchChart(short Year, int BranchID)
        {
            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.Titles.Add("Last 6 years");
            chart1.Series.Add("NumberOfRentalBooking").LegendText = "Number Of Rental Booking";
            chart1.Series.Add("RentalNew").LegendText = "Rental Booking New";
            chart1.Series.Add("RentalCompleted").LegendText = "Rental Booking Completed";

            chart1.Series.Add("TotalRealProfitFromBranch").LegendText = "Total Real Profit";
            chart1.Series.Add("ExpectedNewProfits").LegendText = "Expected New Profits";
            chart1.Series.Add("TotalFinesForVehicleDamage").LegendText = "Total Fines For Vehicle Damage";
            chart1.Series.Add("TotalIncome").LegendText = "Total Income";

            chart1.Series.Add("SalaryPayments").LegendText = "Salary Payments";
            chart1.Series.Add("NumberOfBills").LegendText = "Number Of Bills";
            chart1.Series.Add("TotalBillAmounts").LegendText = "Total Bill Amounts";
            chart1.Series.Add("TotalBillPaidAmounts").LegendText = "Total Bill Paid Amounts";
            chart1.Series.Add("NumberOfContracts").LegendText = "Number Of Contracts";
            chart1.Series.Add("TotalContractAmounts").LegendText = "Total Contract Amounts";
            chart1.Series.Add("TotalContractPaidAmounts").LegendText = "Total Contract PaidAmounts";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[3].ChartType = SeriesChartType.Line;
            chart1.Series[4].ChartType = SeriesChartType.Line;
            chart1.Series[5].ChartType = SeriesChartType.Line;
            chart1.Series[6].ChartType = SeriesChartType.Line;
            chart1.Series[7].ChartType = SeriesChartType.Line;
            chart1.Series[8].ChartType = SeriesChartType.Line;
            chart1.Series[9].ChartType = SeriesChartType.Line;
            chart1.Series[10].ChartType = SeriesChartType.Line;
            chart1.Series[11].ChartType = SeriesChartType.Line;
            chart1.Series[12].ChartType = SeriesChartType.Line;
            chart1.Series[13].ChartType = SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[3].BorderWidth = 2;
            chart1.Series[4].BorderWidth = 2;
            chart1.Series[5].BorderWidth = 2;
            chart1.Series[6].BorderWidth = 2;
            chart1.Series[7].BorderWidth = 2;
            chart1.Series[8].BorderWidth = 2;
            chart1.Series[9].BorderWidth = 2;
            chart1.Series[10].BorderWidth = 2;
            chart1.Series[11].BorderWidth = 2;
            chart1.Series[12].BorderWidth = 2;
            chart1.Series[13].BorderWidth = 2;



            DataTable = clsBranchChart.GetChartLast6years(Year, BranchID);
            foreach (DataRow row in DataTable.Rows)
            {
                chart1.Series["SalaryPayments"].Points.AddXY(row[0], row[4]);
                chart1.Series["NumberOfRentalBooking"].Points.AddXY(row[0], row[5]);
                chart1.Series["RentalNew"].Points.AddXY(row[0], (int)(int.Parse(row[5].ToString()) - (-int.Parse(row[6].ToString()))));
                chart1.Series["RentalCompleted"].Points.AddXY(row[0], row[6]);
                chart1.Series["TotalRealProfitFromBranch"].Points.AddXY(row[0], row[7]);
                chart1.Series["ExpectedNewProfits"].Points.AddXY(row[0], row[8]);
                chart1.Series["TotalFinesForVehicleDamage"].Points.AddXY(row[0], row[9]);
                chart1.Series["TotalIncome"].Points.AddXY(row[0], row[10]);
                chart1.Series["NumberOfContracts"].Points.AddXY(row[0], row[11]);
                chart1.Series["TotalContractAmounts"].Points.AddXY(row[0], row[12]);
                chart1.Series["TotalContractPaidAmounts"].Points.AddXY(row[0], row[13]);
                chart1.Series["NumberOfBills"].Points.AddXY(row[0], row[14]);
                chart1.Series["TotalBillAmounts"].Points.AddXY(row[0], row[15]);
                chart1.Series["TotalBillPaidAmounts"].Points.AddXY(row[0], row[16]);
            }
        }
        public void LoadBranchChartForNumOfRental(short Year, int BranchID)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Number Of Rental Booking");
            chart1.Series.Clear();
            chart1.Series.Add("NumberOfRentalBooking").LegendText = "Number Of Rental Booking";
            chart1.Series.Add("RentalNew").LegendText = "Rental Booking New";
            chart1.Series.Add("RentalCompleted").LegendText = "Rental Booking Completed";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[1].IsValueShownAsLabel = true;
            chart1.Series[2].IsValueShownAsLabel = true;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].BorderWidth = 2;

            DataTable = clsBranchChart.GetChartLast6years(Year, BranchID);
            foreach (DataRow row in DataTable.Rows)
            {
                int NumberOfRentalBooking = int.Parse(row[5].ToString());
                int NumberOfRentalBookingCompleted = int.Parse(row[6].ToString());
                chart1.Series["NumberOfRentalBooking"].Points.AddXY(row[0], NumberOfRentalBooking);
                chart1.Series["RentalNew"].Points.AddXY(row[0], NumberOfRentalBooking - NumberOfRentalBookingCompleted);
                chart1.Series["RentalCompleted"].Points.AddXY(row[0], row[6]);
            }
        }
        public void LoadBranchChartForEarningsChart(short Year, int BranchID)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Earnings Chart");
            chart1.Series.Clear();
            chart1.Series.Add("TotalRealProfitFromBranch").LegendText = "Total Real Profit";
            chart1.Series.Add("ExpectedNewProfits").LegendText = "Expected New Profits";
            chart1.Series.Add("TotalFinesForVehicleDamage").LegendText = "Total Fines For Vehicle Damage";
            chart1.Series.Add("TotalIncome").LegendText = "Total Income";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[3].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[1].IsValueShownAsLabel = true;
            chart1.Series[2].IsValueShownAsLabel = true;
            chart1.Series[3].IsValueShownAsLabel = true;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[3].BorderWidth = 2;

            DataTable = clsBranchChart.GetChartLast6years(Year, BranchID);
            foreach (DataRow row in DataTable.Rows)
            {
                chart1.Series["TotalRealProfitFromBranch"].Points.AddXY(row[0], row[7]);
                chart1.Series["ExpectedNewProfits"].Points.AddXY(row[0], row[8]);
                chart1.Series["TotalFinesForVehicleDamage"].Points.AddXY(row[0], row[9]);
                chart1.Series["TotalIncome"].Points.AddXY(row[0], row[10]);

            }
        }
        public void LoadBranchChartForExpenseChart(short Year, int BranchID)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Expense Chart");
            chart1.Series.Clear();
            chart1.Series.Add("SalaryPayments").LegendText = "Salary Payments";
            chart1.Series.Add("NumberOfBills").LegendText = "Number Of Bills";
            chart1.Series.Add("TotalBillAmounts").LegendText = "Total Bill Amounts";
            chart1.Series.Add("TotalBillPaidAmounts").LegendText = "Total Bill Paid Amounts";
            chart1.Series.Add("NumberOfContracts").LegendText = "Number Of Contracts";
            chart1.Series.Add("TotalContractAmounts").LegendText = "Total Contract Amounts";
            chart1.Series.Add("TotalContractPaidAmounts").LegendText = "Total Contract PaidAmounts";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[3].ChartType = SeriesChartType.Line;
            chart1.Series[4].ChartType = SeriesChartType.Line;
            chart1.Series[5].ChartType = SeriesChartType.Line;
            chart1.Series[6].ChartType = SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[3].BorderWidth = 2;
            chart1.Series[4].BorderWidth = 2;
            chart1.Series[5].BorderWidth = 2;
            chart1.Series[6].BorderWidth = 2;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[1].IsValueShownAsLabel = true;
            chart1.Series[2].IsValueShownAsLabel = true;
            chart1.Series[3].IsValueShownAsLabel = true;
            chart1.Series[4].IsValueShownAsLabel = true;
            chart1.Series[5].IsValueShownAsLabel = true;
            chart1.Series[6].IsValueShownAsLabel = true;

            DataTable = clsBranchChart.GetChartLast6years(Year, BranchID);
            foreach (DataRow row in DataTable.Rows)
            {
                chart1.Series["NumberOfContracts"].Points.AddXY(row[0], row[11]);
                chart1.Series["TotalContractAmounts"].Points.AddXY(row[0], row[12]);
                chart1.Series["TotalContractPaidAmounts"].Points.AddXY(row[0], row[13]);
                chart1.Series["NumberOfBills"].Points.AddXY(row[0], row[14]);
                chart1.Series["TotalBillAmounts"].Points.AddXY(row[0], row[15]);
                chart1.Series["TotalBillPaidAmounts"].Points.AddXY(row[0], row[16]);
                chart1.Series["SalaryPayments"].Points.AddXY(row[0], row[4]);
            }
        }



        private void _LoadAllSeriesForChart()
        {
            chart1.Series.Clear();
            foreach (DataRow row in clsBranch.GetAllBranches().Rows)
            {
                chart1.Series.Add(row["BranchID"].ToString()).LegendText = row["StreetName"].ToString();
                chart1.Series[row["BranchID"].ToString()].ChartType = SeriesChartType.Line;
                chart1.Series[row["BranchID"].ToString()].BorderWidth = 2;
                chart1.Series[chart1.Series.Count - 1].IsValueShownAsLabel = true;
            }
        }
        public void LoadBranchChartForNumOfRental(short Year)
        {
            _LoadAllSeriesForChart();
            chart1.Titles.Clear();
            chart1.Titles.Add("Number Of Rental Booking");
            DataTable = clsBranchChart.GetChartLast6years(Year);
            foreach (DataRow row in DataTable.Rows)
            {
                chart1.Series[row["BranchID"].ToString()].Points.AddXY(row[0], row[5]);
            }
        }
        public void LoadBranchChartForEarningsChart(short Year)
        {
            _LoadAllSeriesForChart();

            chart1.Titles.Clear();
            chart1.Titles.Add("Earnings Chart");
            DataTable = clsBranchChart.GetChartLast6years(Year);
            foreach (DataRow row in DataTable.Rows)
            {

                chart1.Series[row["BranchID"].ToString()].Points.AddXY(row[0], row[7]);
            }
        }
        public void LoadBranchChartForExpectedNewProfitsChart(short Year)
        {
            _LoadAllSeriesForChart();

            chart1.Titles.Clear();
            chart1.Titles.Add("Expected Profits");
            DataTable = clsBranchChart.GetChartLast6years(Year);
            foreach (DataRow row in DataTable.Rows)
            {

                chart1.Series[row["BranchID"].ToString()].Points.AddXY(row[0], row[8]);

            }
        }
        public void LoadBranchChartForExpenseContractAmountsChart(short Year)
        {
            _LoadAllSeriesForChart();

            chart1.Titles.Clear();
            chart1.Titles.Add("Total Contract Amounts");
            DataTable = clsBranchChart.GetChartLast6years(Year);
            foreach (DataRow row in DataTable.Rows)
            {

                chart1.Series[row["BranchID"].ToString()].Points.AddXY(row[0], row[12]);
            }
        }
        public void LoadBranchChartForTotalIncomeChart(short Year)
        {
            _LoadAllSeriesForChart();

            chart1.Titles.Clear();
            chart1.Titles.Add("Total Income Chart");
            DataTable = clsBranchChart.GetChartLast6years(Year);
            foreach (DataRow row in DataTable.Rows)
            {
                chart1.Series[row["BranchID"].ToString()].Points.AddXY(row[0], row[10]);
            }
        }
        public void LoadBranchChartForExpenseSalaryPaymentsChart(short Year)
        {
            _LoadAllSeriesForChart();

            chart1.Titles.Clear();
            chart1.Titles.Add("Salary Payments Chart");
            DataTable = clsBranchChart.GetChartLast6years(Year);
            foreach (DataRow row in DataTable.Rows)
            {

                chart1.Series[row["BranchID"].ToString()].Points.AddXY(row[0], row[4]);
            }
        }
        public void LoadBranchChartForTotalAmountOfBillsPaid(short Year)
        {
            _LoadAllSeriesForChart();

            chart1.Titles.Clear();
            chart1.Titles.Add("Total Amount Of Bills Paid");
            DataTable = clsBranchChart.GetChartLast6years(Year);
            foreach (DataRow row in DataTable.Rows)
            {

                chart1.Series[row["BranchID"].ToString()].Points.AddXY(row[0], row[16]);
            }
        }
        private void chart1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
