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

namespace CarRental
{
    public partial class ctrlBranchCard : UserControl
    {
        public ctrlBranchCard()
        {
            InitializeComponent();
        }
        private void _RestDefaultValues()
        {
            llBranchID.Text = "??";
            lblStreetName.Text = "";
            lblCityName.Text = "";
            lblIsPublic.Text = "";
        }
        public void LoadData(int BranchID)
        {
            clsBranch Branch = clsBranch.Find(BranchID);
            if(Branch == null) 
            {
                _RestDefaultValues();
            }
            else
            {
                lblCityName.Text =clsCity.Find(Branch.CityID).CityName;
                lblStreetName.Text = Branch.StreetName;
                llBranchID.Text=Branch.BranchID.ToString();
                if(Branch.IsPublic)
                lblIsPublic.Text = "Yes";
                else
                    lblIsPublic.Text = "No";
            }

        }
    }
}
