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
    public partial class ctrlGeneralRevenueFundCardWithIncomeDetails : UserControl
    {
        public clsGeneralRevenueFund GeneralRevenueFund { private set; get; }
        public ctrlGeneralRevenueFundCardWithIncomeDetails()
        {
            InitializeComponent();
        }
        public void LoadData(int GeneralFundID)
        {
            ctrlGeneralRevenueFundCard1.LoadData(GeneralFundID);
            ctrlGeneralRevenueFundIncomeDetails1.LoadData(GeneralFundID);
            GeneralRevenueFund = ctrlGeneralRevenueFundIncomeDetails1.GeneralRevenueFund;
        }
    }
}
