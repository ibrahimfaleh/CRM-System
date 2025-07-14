using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.People.Employee
{
    public partial class ctrlEmployeeCard : UserControl
    {

        private clsEmployee _Employee;

        private int _EmployeeID = -1;

        public int EmployeeID
        {
            get { return _EmployeeID; }
        }
        private bool _EditedVisible = true;
        public bool EditedVisible
        {
            get
            {
                return _EditedVisible;
            }
            set
            {
                _EditedVisible = value;
                llEditEmployee.Visible = _EditedVisible;
            }
        }
        public clsEmployee SelectedEmployeeInfo
        {
            get { return _Employee; }
        }

        public ctrlEmployeeCard()
        {
            InitializeComponent();
        }


        private void _FillEmployeeInfo()
        {
            if (_Employee != null)
            {
                llEditEmployee.Enabled = true;
                ctrlPersonCard1.EditedVisible = false;
                _EmployeeID = _Employee.EmployeeID;
                llEmployeeID.Text = _Employee.EmployeeID.ToString();
                llDepartmenID.Text = _Employee.DepartmentID.ToString();
                lblMonthlySalary.Text = _Employee.MonthlySalary.ToString();
                lblHireDate.Text = _Employee.HireDate.ToString();
                if (_Employee.ExitDate != null)
                {
                    lblExitDate.Visible = true;
                    lblExitDate.Text = _Employee.ExitDate.ToString();
                }
                ctrlPersonCard1.LoadPersonInfo(_Employee.PersonID);
            }
        }
        private void _ResetDefaultValues()
        {
            llEditEmployee.Enabled = false;
            llEmployeeID.Text = "????";
            llDepartmenID.Text = "????";
            lblMonthlySalary.Text = "????";
            lblHireDate.Text = "????";
            lblExitDate.Visible = false;
            lblExitDate.Text = "????";
        }
        public void LoadEmployeeInfo(int EmployeeID)
        {
            _Employee = clsEmployee.Find(EmployeeID);
            if (_Employee == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("No Employee with EmployeeID = " + EmployeeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillEmployeeInfo();
        }
        public void LoadEmployeeInfo(string  PhoneNumber)
        {
            _Employee = clsEmployee.Find(PhoneNumber);
            if (_Employee == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("No Employee with Phone Number = " + PhoneNumber, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillEmployeeInfo();
        }
        public void LoadEmployeeInfoByNationalNo(string NationalNo)
        {
            _Employee = clsEmployee.FindByNationalNo(NationalNo);
            if (_Employee == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("No Employee with NationalNo = " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillEmployeeInfo();
        }
        private void llEditEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateEmployee frmAddUpdateEmployee = new frmAddUpdateEmployee(_Employee.EmployeeID);
            frmAddUpdateEmployee.ShowDialog();
            this.LoadEmployeeInfo(_Employee.EmployeeID);
        }
    }
}
