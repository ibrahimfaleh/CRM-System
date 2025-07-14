using CarRental.Classes;
using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.People.Employee
{
    public partial class frmAddUpdateEmployee : Form
    {
        public delegate void DataBackEventHandler(object sender, int CustomerID);

        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew=1,Update=2}
        private enMode _Mode;
        private clsEmployee _Employee;
        private int _EmployeeID;
        public frmAddUpdateEmployee(int employeeID)
        {
            InitializeComponent();
            _EmployeeID = employeeID;
            _Mode = enMode.Update;
        }
        public frmAddUpdateEmployee()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _Employee = new clsEmployee();
        }
        private void LoadCities()
        {
            cmbCityName.Items.Clear();
            foreach (DataRow row in clsCity.GetAllCities().Rows)
            {
                cmbCityName.Items.Add(row[1]);
            }
        }
        private void _LoadDepartemnts()
        {
            cmbDepartemnt.Items.Clear();    
            foreach(DataRow row in clsDepartment.GetAllDepartments().Rows)
            {
                cmbDepartemnt.Items.Add(row[1]);
            }
        }
        private void _LoadBranches(string CityName)
        {
            cmbBranch.Items.Clear();
            foreach (DataRow row in clsBranch.GetAllBranches(CityName).Rows)
            {
                cmbBranch.Items.Add(row[2]);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tabEmployeeInfo.Enabled = true;
                tabAddUpdateEmployee.SelectedIndex++;
                return;
            }

            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {

                if (clsEmployee.isEmployeeExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a Employee, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tabEmployeeInfo.Enabled = true;
                    tabAddUpdateEmployee.SelectedIndex++;

                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabAddUpdateEmployee.SelectedIndex--;
        }
        private void _FillBranchesInComboBox()
        {
            foreach (DataRow row in clsBranch.GetAllBranches().Rows)
            {
                cmbBranch.Items.Add(row["StreetName"]);
            }
        }
        private void _FillDepartmentNameInComboBox()
        {
            foreach (DataRow row in clsDepartment.GetAllDepartments().Rows)
            {
                cmbDepartemnt.Items.Add(row["DepartmentName"]);
            }
        }
        private void _LoadData()
        {
            _Employee = clsEmployee.Find(_EmployeeID);
            lblTitle.Text = "Update Employee";
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            if (_Employee == null)
            {
                MessageBox.Show("No Employee with ID = " + _EmployeeID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            clsBranch branch=clsBranch.Find(_Employee.BranchID);
            cmbCityName.Text = clsCity.Find(branch.CityID).CityName;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Employee.PersonID);
            tabEmployeeInfo.Enabled = true;
            lblEmployeeID.Text=_Employee.EmployeeID.ToString();
            txtMonthlySalary.Text = _Employee.MonthlySalary.ToString();
            dtpHireDate.Value = _Employee.HireDate;
            if (_Employee.ExitDate != null)
                dtpExitDate.Value = _Employee.ExitDate??DateTime.Now;
            else
                tsIsExit.Checked = false;
            cmbBranch.Text = branch.StreetName;
            cmbDepartemnt.Text =clsDepartment.Find (_Employee.DepartmentID).DepartmentName;
        }

        private void _ResetDefaultValues()
        {
            _FillBranchesInComboBox();
            _FillDepartmentNameInComboBox();
            dtpExitDate.MaxDate = DateTime.Now.AddYears(50);
            dtpExitDate.MinDate = DateTime.Now.AddYears(-50);
            dtpHireDate.MaxDate = DateTime.Now.AddYears(50);
            dtpHireDate.MinDate = DateTime.Now.AddYears(-50);
            lblTitle.Text = "Add New Employee";
            if(clsGlobal.IsBranchInformationAvailable) 
            {
                cmbCityName.Items.Clear();
                cmbBranch.Items.Clear();
                cmbBranch.Enabled = false;
                cmbCityName.Enabled = false;
                cmbBranch.Items.Add(clsGlobal.Branch.StreetName);
                cmbCityName.Items.Add(clsGlobal.Branch.City.CityName);
                cmbBranch.SelectedIndex =0;
                cmbCityName.SelectedIndex = 0;


            }
            else
                LoadCities();
            txtMonthlySalary.Text = "";
            dtpHireDate.Value = DateTime.Now;
            dtpExitDate.Value = DateTime.Now;
            cmbDepartemnt.Items.Clear();
            tabEmployeeInfo.Enabled = false;
            _LoadDepartemnts();
        }
        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Employee.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Employee.DepartmentID = clsDepartment.Find(cmbDepartemnt.Text).DepartmentID;
            _Employee.MonthlySalary=float.Parse(txtMonthlySalary.Text);
            _Employee.BranchID=clsBranch.Find(cmbBranch.Text).BranchID; 
            if (tsIsExit.Checked)
                _Employee.ExitDate = dtpExitDate.Value;
            else
                _Employee.ExitDate = null;
            _Employee.HireDate = dtpHireDate.Value;
            if(_Employee.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                _EmployeeID = _Employee.EmployeeID;
                frmAddUpdateEmployee_Load(null,null);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsIsExit_CheckedChanged(object sender, EventArgs e)
        {
            if(tsIsExit.Checked)
            {
                lbltitleExitDate.Visible = true;
                dtpExitDate.Visible = true;
            }
            else
            {

                lbltitleExitDate.Visible = false;
                dtpExitDate.Visible = false;
            }
        }

        private void txtMonthlySalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text+e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);;
        }

        private void txtMonthlySalary_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {

        }
        private void tabAddUpdateEmployee_Selecting(object sender, TabControlCancelEventArgs e)
        {
            btnNext.PerformClick();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDepartemnt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBranch_Validating(object sender, CancelEventArgs e)
        {
            ComboBox Temp = (ComboBox)sender;
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void cmbCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!clsGlobal.IsBranchInformationAvailable)
            _LoadBranches(cmbCityName.Text);
        }
    }
}
