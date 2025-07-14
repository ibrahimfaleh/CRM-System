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

namespace CarRental.Users
{
    public partial class ctrlUserAllInfo : UserControl
    {
        public ctrlUserAllInfo()
        {
            InitializeComponent();
        }
        private bool _llEnabled = true;
        public bool llEnabled
        {
            set
            {
                _llEnabled = value;
                llCountTransActions.Enabled = _llEnabled;
                llCreatedByUserID.Enabled = _llEnabled;
                llCreatedRental.Enabled = _llEnabled;
                llVehicleReturn.Enabled = _llEnabled;
            }
            get
            { return _llEnabled; }
        }
        public void LoadAllUserInfo(int userId)
        {
            clsUser user;
            if((user = clsUser.FindByUserID(userId))!=null)
            {
                lblTotalRentalTransActions.Text=user.TotalRentalIncome.ToString();
                llCreatedByUserID.Text=user.CreatedByUserID.ToString(); 
                llCreatedRental.Text=user.CountCreatedRentalBooking.ToString();
                llCreatedUsers.Text=user.CountCreatedUsers.ToString();
                llVehicleReturn.Text=user.CountVehiclesReturn.ToString();
                llCountTransActions.Text=user.CountTransActions.ToString();
                ctrlUserCard1.LoadUserInfo(userId);
            }
            else
            {
                llEnabled = false;
                lblTotalRentalTransActions.Text = "?????";
                llCreatedByUserID.Text = "?????";
                llCreatedRental.Text = "?????";
                llCreatedUsers.Text = "?????";
                llVehicleReturn.Text = "?????";
                llCountTransActions.Text = "?????";
            }
        }
        private void ctrlUserAllInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
