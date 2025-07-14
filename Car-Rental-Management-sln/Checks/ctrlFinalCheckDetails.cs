using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Checks
{
    public partial class ctrlFinalCheckDetails : ctrlInitialCheckDetails
    {
        public ctrlFinalCheckDetails()
        {
            InitializeComponent();
        }
        private void _ResetDefaultValue()
        {
            txtBackPartCost.Text = "";
            txtBagCost.Text = "";
            txtFrontPartCost.Text = "";
            txtLeftPartCost.Text = "";
            txtUpperBodyCost.Text = "";
            txtRightPartCost.Text = "";
            txtTotalCost.Text = "";
        }
        public void LoadCheckInfo(int VehicleCheckID)
        {
            _ResetDefaultValue();
            base.LoadCheckInfo(VehicleCheckID);
            if(base._Check!=null) 
            {
                txtBackPartCost.Text = base._Check.BackPartFee.ToString();
                txtBagCost.Text = base._Check.BagFee.ToString();
                txtFrontPartCost.Text = base._Check.FrontPartFee.ToString();
                txtLeftPartCost.Text = base._Check.LeftPartFee.ToString();
                txtUpperBodyCost.Text = base._Check.UpperBodyFee.ToString();
                txtRightPartCost.Text = base._Check.RightPartFee.ToString();
                txtTotalCost.Text = base._Check.TotalCharges.ToString();
            }
        }
    }
}
