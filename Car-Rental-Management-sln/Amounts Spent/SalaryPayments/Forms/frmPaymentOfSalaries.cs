using CarRental.Classes;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Amounts_Spent.Salary_Payments
{
    public partial class frmPaymentOfSalaries : Form
    {
        private DataTable _dtEmployeeSalaries;
        private double _TotalAmountOfSalaries;
        private double _FromVehicleBreakdownRevenues;
        private double _FromAnotherIncome;
        private double _FromActualProfits;
        private double _FromExpectedProfit;
        private double _FromVehicleSales;
        private int? _BranchID;
        private byte _PaymentDetails;
        public frmPaymentOfSalaries(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
        }
        public frmPaymentOfSalaries()
        {
            InitializeComponent();
        }
        private void _FillBranchesInComboBox()
        {
            foreach (DataRow row in clsBranch.GetAllBranches().Rows)
            {
                cmbBranch.Items.Add(row["StreetName"]);
            }
            cmbBranch.Items.Add("All");

        }
        private void _FillDepartmentNameInComboBox()
        {
            foreach (DataRow row in clsDepartment.GetAllDepartments().Rows)
            {
                cmbDepbartmennt.Items.Add(row["DepartmentName"]);
            }
            cmbDepbartmennt.Items.Add("All");

        }
        private void _EmployeesColumns()
        {
            if (_dtEmployeeSalaries.Rows.Count > 0)
            {
                _dtEmployeeSalaries.Columns.Add("PaymentAmount", typeof(float));
                _dtEmployeeSalaries.Columns.Add("FromVehicleBreakdownRevenues", typeof(float));
                _dtEmployeeSalaries.Columns.Add("FromActualProfits", typeof(float));
                _dtEmployeeSalaries.Columns.Add("FromAnotherIncome", typeof(float));
                _dtEmployeeSalaries.Columns.Add("FromExpectedProfit", typeof(float));
                _dtEmployeeSalaries.Columns.Add("FromVehicleSales",typeof(float));


                dgvListEmployeeSalaries.DataSource = _dtEmployeeSalaries;
                lblRecordsCount.Text = dgvListEmployeeSalaries.Rows.Count.ToString();
                dgvListEmployeeSalaries.Columns[0].Width = 1;
                dgvListEmployeeSalaries.Columns[1].HeaderText = "Employee ID";
                dgvListEmployeeSalaries.Columns[1].Width = 100;
                dgvListEmployeeSalaries.Columns[1].ReadOnly = true;

                dgvListEmployeeSalaries.Columns[2].HeaderText = "Full Name";
                dgvListEmployeeSalaries.Columns[2].Width = 150;
                dgvListEmployeeSalaries.Columns[2].ReadOnly = true;


                dgvListEmployeeSalaries.Columns[3].HeaderText = "NationalNo";
                dgvListEmployeeSalaries.Columns[3].Width = 150;
                dgvListEmployeeSalaries.Columns[3].ReadOnly = true;

                dgvListEmployeeSalaries.Columns[4].HeaderText = "Country Name";
                dgvListEmployeeSalaries.Columns[4].Width = 150;
                dgvListEmployeeSalaries.Columns[4].ReadOnly = true;

                dgvListEmployeeSalaries.Columns[5].HeaderText = "Branch";
                dgvListEmployeeSalaries.Columns[5].Width = 150;
                dgvListEmployeeSalaries.Columns[5].ReadOnly = true;

                dgvListEmployeeSalaries.Columns[6].HeaderText = "Department";
                dgvListEmployeeSalaries.Columns[6].Width = 100;
                dgvListEmployeeSalaries.Columns[6].ReadOnly = true;

                dgvListEmployeeSalaries.Columns[7].HeaderText = "Hire Date";
                dgvListEmployeeSalaries.Columns[7].Width = 150;
                dgvListEmployeeSalaries.Columns[7].ReadOnly = true;

                dgvListEmployeeSalaries.Columns[8].HeaderText = "Monthly Salary";
                dgvListEmployeeSalaries.Columns[8].Width = 150;
                dgvListEmployeeSalaries.Columns[8].ReadOnly = true;

                dgvListEmployeeSalaries.Columns[10].HeaderText = "Payment Amount";
                dgvListEmployeeSalaries.Columns[10].Width = 200;

                dgvListEmployeeSalaries.Columns[9].Visible = false;
                dgvListEmployeeSalaries.Columns[11].Visible = false;
                dgvListEmployeeSalaries.Columns[12].Visible = false;
                dgvListEmployeeSalaries.Columns[13].Visible = false;
                dgvListEmployeeSalaries.Columns[14].Visible = false;
                dgvListEmployeeSalaries.Columns[15].Visible = false;

            }
        }
        private void _FilterEmployees()
        {
            string query = "";

            if (!cbSalary.Checked && (txtFromSalary.TextLength > 0) && txtToSalary.TextLength > 0)
                query = "MonthlySalary >= " + txtFromSalary.Text + " And MonthlySalary <= " + txtToSalary.Text;
            if (!cbHireDate.Checked)
            {
                if (query != "")
                    query += " And (HireDate >=  '" + dtpFromHireDate.Value.ToString("dd-MM-yyyy") + "'  And HireDate<= '" + dtpToHireDate.Value.ToString("dd-MM-yyyy") + "'  )";
                else
                    query += " HireDate >=  '" + dtpFromHireDate.Value.ToString("dd-MM-yyyy") + "'  And HireDate <= '" + dtpToHireDate.Value.ToString("dd-MM-yyyy") + "' ";

            }
            if (txtFilterValue.Text.Length > 0)
            {
                switch (cbFilterBy.Text)
                {
                    case "Employee ID":
                        if (query != "")
                            query += " And (EmployeeID = " + txtFilterValue.Text + ") ";
                        else
                            query += " EmployeeID = " + txtFilterValue.Text + " ";
                        break;

                    case "Full Name":
                        if (query != "")
                            query += " And (FullName like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  FullName like '" + txtFilterValue.Text + "%' ";
                        break;

                    case "Phone":
                        if (query != "")
                            query += " And (Phone like '" + txtFilterValue.Text + "%' )";
                        else
                            query += "  Phone like '" + txtFilterValue.Text + "%' ";
                        break;

                    default:

                        break;

                }
            }

            if (cmbBranch.Text != "All" && cmbBranch.Text != "")
                if (query != "")
                    query += " And (StreetName = '" + cmbBranch.Text.Trim() + "' )";
                else
                    query += "  StreetName = '" + cmbBranch.Text.Trim() + "' ";

            if (cmbDepbartmennt.Text != "All" && cmbDepbartmennt.Text != "")
                if (query != "")
                    query += " And (DepartmentName = '" + cmbDepbartmennt.Text + "' )";
                else
                    query += "  DepartmentName = '" + cmbDepbartmennt.Text + "' ";







            if (query != "")
            {
                if (_dtEmployeeSalaries.Rows.Count < 1)
                    return;
                _dtEmployeeSalaries.DefaultView.RowFilter = query;

            }
            else
                _dtEmployeeSalaries.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListEmployeeSalaries.Rows.Count.ToString();

        }
        private void _DividingSalaryAmountsAccordingToSourcesOfGeneralFundIncome()
        {
            double TempFromVehicleBreakdownRevenues = _FromVehicleBreakdownRevenues;
            double TempFromActualProfits = _FromActualProfits;
            double TempFromExpectedProfit = _FromExpectedProfit;
            double TempFromAnotherIncome = _FromAnotherIncome;
            double TempFromVehicleSales = _FromVehicleSales;

            foreach (DataRow row in _dtEmployeeSalaries.Rows)
            {
                if (row["PaymentAmount"].ToString() == "")
                    continue;
                double Salary = double.Parse(row["PaymentAmount"].ToString());
                if (TempFromVehicleBreakdownRevenues > 0)
                {
                    if (Salary >= TempFromVehicleBreakdownRevenues)
                    {
                        row["FromVehicleBreakdownRevenues"] = TempFromVehicleBreakdownRevenues;
                        Salary -= TempFromVehicleBreakdownRevenues;
                        TempFromVehicleBreakdownRevenues = 0;
                        if(Salary==0)
                        continue;
                    }
                    else
                    {
                        row["FromVehicleBreakdownRevenues"] = Salary;
                        TempFromVehicleBreakdownRevenues -= Salary;
                        continue;
                    }
                }
                if (TempFromVehicleBreakdownRevenues == 0 && TempFromAnotherIncome > 0)
                {
                    if (Salary >= TempFromAnotherIncome)
                    {
                        row["FromAnotherIncome"] = TempFromAnotherIncome;
                        Salary -= TempFromAnotherIncome;
                        TempFromAnotherIncome = 0;   
                        if (Salary == 0)
                            continue;
                    }
                    else
                    {
                        row["FromAnotherIncome"] = Salary;
                        TempFromAnotherIncome -= Salary;
                        continue;
                    }
                }
                if (TempFromVehicleBreakdownRevenues == 0 && TempFromAnotherIncome == 0 && TempFromExpectedProfit > 0)
                {
                    if (Salary >= TempFromExpectedProfit)
                    {
                        row["FromExpectedProfit"] = TempFromExpectedProfit;
                        Salary -= TempFromExpectedProfit;
                        TempFromExpectedProfit = 0;
                        if (Salary == 0)
                            continue;
                    }
                    else
                    {
                        row["FromExpectedProfit"] = Salary;
                        TempFromExpectedProfit -= Salary;
                        continue;
                    }
                }
                if (TempFromVehicleBreakdownRevenues == 0 && TempFromAnotherIncome == 0 && TempFromExpectedProfit == 0 && TempFromActualProfits > 0)
                {
                    if (Salary >= TempFromActualProfits)
                    {
                        row["FromActualProfits"] = TempFromActualProfits;
                        Salary -= TempFromActualProfits;
                        TempFromActualProfits = 0;
                        if (Salary == 0)
                            continue;

                    }
                    else
                    {
                        row["FromActualProfits"] = Salary;
                        TempFromActualProfits -= Salary;
                        continue;
                    }
                }

                if (TempFromVehicleBreakdownRevenues == 0 && TempFromAnotherIncome == 0 && TempFromExpectedProfit == 0 && TempFromActualProfits ==0&TempFromVehicleSales>0)
                {
                    if (Salary >= TempFromVehicleSales)
                    {
                        row["FromVehicleSales"] = TempFromVehicleSales;
                        Salary-= TempFromVehicleSales;  
                        TempFromVehicleSales = 0;
                        if (Salary == 0)
                            continue;
                    }
                    else
                    {
                        row["FromVehicleSales"] = Salary;
                        TempFromVehicleSales -= Salary;
                    }
                }
            }

        }
        private void frmPaymentOfSalaries_Load(object sender, EventArgs e)
        {

            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmSalaryPayments))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _FillDepartmentNameInComboBox();
            _dtEmployeeSalaries = clsSalaryPayment.GetAllEmployeeSalaries();
            _EmployeesColumns();
            if (_BranchID.HasValue)
            {
                cmbBranch.Items.Add(clsBranch.Find(_BranchID ?? -1).StreetName);
                cmbBranch.SelectedIndex = 0;
            }
            else

                _FillBranchesInComboBox();
            lblDate.Text = DateTime.Now.ToString("g");
            ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(clsGlobal.GeneralRevenueFundID);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterEmployees();
            lblRecordsCount.Text = dgvListEmployeeSalaries.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
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
            if (cbFilterBy.Text == "Employee ID" || cbFilterBy.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterEmployees();
        }
        private void validatingNumber(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (Temp.Text.Length == 0)
                return;
            if (Temp.Text[Temp.Text.Length - 1] == '.')
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "The number is invalid!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            clsGeneralRevenueFund GeneralRevenueFund = clsGeneralRevenueFund.Find(clsGlobal.GeneralRevenueFundID);

            if (GeneralRevenueFund.TotalAmount < _TotalAmountOfSalaries)
            {
                if (MessageBox.Show("There is not enough balance. Do you want to deposit money into the general fund?", "The bank balance is insufficient", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmManagingGeneralFund managingGeneralFund = new frmManagingGeneralFund(clsGlobal.GeneralRevenueFundID);
                    managingGeneralFund.ShowDialog();
                    ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(clsGlobal.GeneralRevenueFundID);
                }
                return;
            }
            if (_FromAnotherIncome > (ctrlGeneralRevenueFundCardWithIncomeDetails1.GeneralRevenueFund.AnotherIncome))
            {
                MessageBox.Show("The balance of other income is insufficient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_FromVehicleBreakdownRevenues > (ctrlGeneralRevenueFundCardWithIncomeDetails1.GeneralRevenueFund.VehicleBreakdownRevenues))
            {
                MessageBox.Show("The vehicle breakdown credit is insufficient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_FromExpectedProfit > (ctrlGeneralRevenueFundCardWithIncomeDetails1.GeneralRevenueFund.ExpectedProfit))
            {
                MessageBox.Show("The vehicle Expected Profit credit is insufficient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_FromActualProfits > (ctrlGeneralRevenueFundCardWithIncomeDetails1.GeneralRevenueFund.ActualProfits))
            {
                MessageBox.Show("The vehicle Actual Profits credit is insufficient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_TotalAmountOfSalaries > GeneralRevenueFund.Bank && cmbPayment.Text == "Bank")
            {
                MessageBox.Show("There is not enough liquidity in the fund", "The bank balance is insufficient", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            if (_TotalAmountOfSalaries > GeneralRevenueFund.Cash && cmbPayment.Text == "Cash")
            {
                MessageBox.Show("There is not enough liquidity in the fund", "The Cash balance is insufficient", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            if ((_FromAnotherIncome + _FromExpectedProfit + _FromVehicleBreakdownRevenues + _FromActualProfits+_FromVehicleSales) != _TotalAmountOfSalaries)
            {
                MessageBox.Show("The amount of spending must be equal to the total salaries.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DividingSalaryAmountsAccordingToSourcesOfGeneralFundIncome();
            if ((cmbPayment.Text == "Cash" && GeneralRevenueFund.Cash < _TotalAmountOfSalaries) || (cmbPayment.Text == "Transformation" && GeneralRevenueFund.Bank < _TotalAmountOfSalaries))
            {
                if (MessageBox.Show("Do you want to deposit money in the bank?", "The bank balance is insufficient", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frmManagingGeneralFund managingGeneralFund = new frmManagingGeneralFund(clsGlobal.GeneralRevenueFundID);
                    managingGeneralFund.ShowDialog();
                    ctrlGeneralRevenueFundCardWithIncomeDetails1.LoadData(clsGlobal.GeneralRevenueFundID);
                }
                return;
            }
            if (cmbPayment.Text == "Cash")
            {
                _PaymentDetails = (byte)clsAmountSpent.enPaymentDetails.Cash;
                GeneralRevenueFund.Cash -= _TotalAmountOfSalaries;
            }
            else
            {
                _PaymentDetails = (byte)clsAmountSpent.enPaymentDetails.Transformation;
                GeneralRevenueFund.Bank -= _TotalAmountOfSalaries;
            }
            GeneralRevenueFund.VehicleBreakdownRevenues -= _FromVehicleBreakdownRevenues;
            GeneralRevenueFund.AnotherIncome -= _FromAnotherIncome;
            GeneralRevenueFund.ActualProfits -= _FromActualProfits;
            GeneralRevenueFund.ExpectedProfit -= _FromExpectedProfit;
            GeneralRevenueFund.VehicleSales -= _FromVehicleSales;
            if (clsSalaryPayment.PaymentOfSalaries(_dtEmployeeSalaries, clsGlobal.GeneralRevenueFundID, clsGlobal.CurrentUser.UserID, _PaymentDetails))
            {
                GeneralRevenueFund.Save();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dgvListEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dgvListEmployeeSalaries_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _TotalAmountOfSalaries = 0;
            foreach (DataRow row in _dtEmployeeSalaries.Rows)
            {
                if (row["PaymentAmount"].ToString() != "")
                    _TotalAmountOfSalaries += double.Parse(row["PaymentAmount"].ToString());
            }
            lblTotalAmountOfSalaries.Text = _TotalAmountOfSalaries.ToString();

        }

        private void txtFromSalary_TextChanged(object sender, EventArgs e)
        {
            _FilterEmployees();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterEmployees();
        }

        private void cmbDepbartmennt_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterEmployees();

        }
        private void _TotalAmount()
        {
            txtTotalAmount.Text = (_FromActualProfits + _FromAnotherIncome + _FromExpectedProfit + _FromVehicleBreakdownRevenues+ _FromVehicleSales).ToString();
        }
        private void txtFromExpectedProfit_TextChanged(object sender, EventArgs e)
        {
            if (txtFromExpectedProfit.Text != "")
                _FromExpectedProfit = double.Parse(txtFromExpectedProfit.Text);
            else
                _FromExpectedProfit = 0;
            _TotalAmount();
        }

        private void txtFromActualProfits_TextChanged(object sender, EventArgs e)
        {
            if (txtFromActualProfits.Text != "")
                _FromActualProfits = double.Parse(txtFromActualProfits.Text);
            else
                _FromActualProfits = 0;
            _TotalAmount();
        }

        private void txtAmountVBR_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountVBR.Text != "")
                _FromVehicleBreakdownRevenues = double.Parse(txtAmountVBR.Text);
            else
                _FromVehicleBreakdownRevenues = 0;
            _TotalAmount();
        }

        private void txtFromAnotherIncome_TextChanged(object sender, EventArgs e)
        {
            if (txtFromAnotherIncome.Text != "")
                _FromAnotherIncome = double.Parse(txtFromAnotherIncome.Text);
            else
                _FromAnotherIncome = 0;
            _TotalAmount();
        }

        private void txtFromExpectedProfit_Validating(object sender, CancelEventArgs e)
        {
            validatingNumber(sender, e);
            ValidateEmptyTextBox(sender, e);
        }

        private void txtFromExpectedProfit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void txtFromActualProfits_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void txtAmountVBR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void txtFromAnotherIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }

        private void txtFromVehicleSales_TextChanged(object sender, EventArgs e)
        {
            if (txtFromVehicleSales.Text != "")
                _FromVehicleSales = double.Parse(txtFromVehicleSales.Text);
            else
                _FromVehicleSales = 0;
            _TotalAmount();
        }
    }
}
