using CarRental.Classes;
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
    public partial class frmUserDetails : Form
    {
        private int _UserID;
        public frmUserDetails(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmUserDetails))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
            lblCountCreatedRentalBooking.Text =ctrlUserCard1.User.CountCreatedRentalBooking.ToString();
            lblTotalRentPayments.Text =ctrlUserCard1.User.TotalRentalIncome.ToString();
            ctrldgListUsersTransActions1.ShowUserDetailsVisible = false;
            ctrldgListUsersTransActions1.ctrldgListUsersTransActions_LoadByUserID(_UserID);
        }

        private void ctrldgListUsersTransActions1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void lable_Click(object sender, EventArgs e)
        {

        }
    }
}
