using CarRental_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.People.Employee
{
    public partial class ctrlEmployeeCardWithFilter : UserControl
    {
        public event Action<bool> OnEmployeeSelected;
        protected virtual void VehicleSelected(bool IsSelected)
        {
            Action<bool> handler = OnEmployeeSelected;
            if (handler != null)
            {
                handler(IsSelected);
            }
        }
        private bool _ShowAddEmployee = true;
        public bool ShowAddEmployee
        {
            get
            {
                return _ShowAddEmployee;
            }
            set
            {
                _ShowAddEmployee = value;
                btnAddNewEmployee.Visible = _ShowAddEmployee;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public ctrlEmployeeCardWithFilter()
        {
            InitializeComponent();
        }




        public int EmployeeID
        {
            get { return ctrlEmployeeCard1.EmployeeID; }
        }

        public clsEmployee SelectedEmployeeInfo
        {
            get { return ctrlEmployeeCard1.SelectedEmployeeInfo; }
        }

        public void LoadEmployeeInfo(int EmployeeID)
        {

            cbFilterBy.Text = "Employee ID";
            txtFilterValue.Text = EmployeeID.ToString();
            FindNow();

        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Employee ID":
                    ctrlEmployeeCard1.LoadEmployeeInfo(int.Parse(txtFilterValue.Text));

                    break;
                case "Phone Number":
                    ctrlEmployeeCard1.LoadEmployeeInfo(txtFilterValue.Text);
                    break;
                case "NationalNo":
                    ctrlEmployeeCard1.LoadEmployeeInfoByNationalNo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnEmployeeSelected != null && FilterEnabled)
                if (this.SelectedEmployeeInfo != null)
                    OnEmployeeSelected(true);
                else OnEmployeeSelected(false);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }


        private void ctrlEmployeeCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();

        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;
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

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm1 = new frmAddUpdateEmployee();
            frm1.DataBack += DataBackEvent;
            frm1.ShowDialog();

        }

        private void DataBackEvent(object sender, int EmployeeID)
        {

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = EmployeeID.ToString();
            ctrlEmployeeCard1.LoadEmployeeInfo(EmployeeID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }





        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
            if (cbFilterBy.Text == "Employee ID" || cbFilterBy.Text == "NationalNo")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            FindNow();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_Validating_1(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;
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

        private void ctrlEmployeeCardWithFilter_Load_1(object sender, EventArgs e)
        {

            if(cbFilterBy.Text=="Employee ID")
                this.btnFind.PerformClick();
        }
    }
}
