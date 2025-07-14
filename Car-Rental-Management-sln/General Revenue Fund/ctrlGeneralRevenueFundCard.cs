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

namespace CarRental.General_Revenue_Fund
{
    public partial class ctrlGeneralRevenueFundCard : UserControl
    {
        public ctrlGeneralRevenueFundCard()
        {
            InitializeComponent();
        }
        private void _RestDefaultValues()
        {
            llGeneralID.Text = "";
            lblEndDate.Text = "";
            lblIsClosed.Text = "";
            lblStartDate.Text = "";
        }
        public void LoadData(int GeneralFundID)
        {
            _RestDefaultValues();
            clsGeneralRevenueFund generalRevenueFund ;
            generalRevenueFund = clsGeneralRevenueFund.Find(GeneralFundID);
            if(generalRevenueFund != null) 
            { 
                llGeneralID.Text=generalRevenueFund.GeneralRevenueFundID.ToString();
                lblStartDate.Text=generalRevenueFund.CreatedDate.ToString("d");
                if (generalRevenueFund.ClosedDate != null)
                    lblEndDate.Text = generalRevenueFund.ClosedDate?.ToString("d");
                if (generalRevenueFund.IsClosed)
                    lblIsClosed.Text = "Yeas";
                else
                    lblIsClosed.Text = "No";
            }
        }
    }
}
