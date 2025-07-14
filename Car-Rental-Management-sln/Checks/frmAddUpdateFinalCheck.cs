using CarRental.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.Checks
{
    public partial class frmAddUpdateFinalCheck : frmAddUpdateInitialCheck
    {
        public delegate void DataBackEventHandlerFinalCheckWithCost(object sender,int id, double TotalCost);
        public event DataBackEventHandlerFinalCheckWithCost DataBackFinalCheckWithCost;
        public frmAddUpdateFinalCheck():base()
        {
            InitializeComponent();
        }
        public frmAddUpdateFinalCheck(int CheckID) :base(CheckID)
        {
            InitializeComponent();
        }
        private  void _ResetDefaultValues()
        {
            base.lblTitle.Text = "Add New Final Check";
            txtBackPartCost.Text = "";
            txtBagCost.Text = "";
            txtFrontPartCost.Text = "";
            txtLeftPartCost.Text = "";
            txtUpperBodyCost.Text = "";
            txtRightPartCost.Text = "";
            txtTotalCost.Text = "";
        }
        private  void _LoadData()
        {

            if (base._Check == null)
            {
                this.Close();
                return;
            }

            txtBackPartCost.Text = base._Check.BackPartFee.ToString();
            txtBagCost.Text = base._Check.BagFee.ToString();
            txtFrontPartCost.Text = base._Check.FrontPartFee.ToString();
            txtLeftPartCost.Text = base._Check.LeftPartFee.ToString();
            txtUpperBodyCost.Text = base._Check.UpperBodyFee.ToString();
            txtRightPartCost.Text = base._Check.RightPartFee.ToString();
            txtTotalCost.Text = base._Check.TotalCharges.ToString();
            base.lblTitle.Text = "Update Final Check";
        }
         private void frmAddUpdateFinalCheck_Load(object sender, EventArgs e)
        {
            this._ResetDefaultValues();
            if (base._Mode == frmAddUpdateInitialCheck.enMode.Update)
                this._LoadData();
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox Temp = (TextBox)sender; e.Handled = !clsValidatoin.ValidatePositiveDecimalNumbers(Temp.Text + e.KeyChar.ToString()) && !char.IsControl(e.KeyChar);
        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
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
        private void btnSave_Click_1(object sender, EventArgs e)
        {


        }

        protected override void DataBackEvent()
        {
            DataBackFinalCheckWithCost?.Invoke(this,_Check.CheckID(), _Check.TotalCharges);
        }
        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            base._Check.FrontPartFee = double.Parse(txtFrontPartCost.Text.ToString());
            base._Check.RightPartFee = double.Parse(txtRightPartCost.Text.ToString());
            base._Check.LeftPartFee = double.Parse(txtLeftPartCost.Text.ToString());
            base._Check.BackPartFee = double.Parse(txtBackPartCost.Text.ToString());
            base._Check.UpperBodyFee = double.Parse(txtUpperBodyCost.Text.ToString());
            base._Check.BagFee = double.Parse(txtBagCost.Text.ToString());
            base._Check.DateCheck = DateTime.Now;
            base.btnSave_Click(sender, e);
            frmAddUpdateFinalCheck_Load(null,null);
        }
    }
}
