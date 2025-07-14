using CarRental.Users;
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
    public partial class ctrlUserCard : UserControl
    {
        int _UserID;
        public ctrlUserCard()
        {
            InitializeComponent();
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
                llEditUserInfo.Visible = _EditedVisible;
            }
        }
        private clsUser _User;
        public clsUser User { get { return _User; } }
        private void _ResetDefaultValues()
        {
            llEditUserInfo.Enabled = false;
            lblUserName.Text = "?????";
            lblIsActive.Text = "?????";
            lblUserID.Text = "?????";
            llEditUserInfo.Enabled = false;
        }
        public void LoadUserInfo(int UserID)
        {
            _ResetDefaultValues();
            _UserID = UserID;
            _User=clsUser.FindByUserID(_UserID);
            if (_User!=null)
            {
                llEditUserInfo.Enabled = true;  
                ctrlPersonInfo1.EditedVisible = false;
                ctrlPersonInfo1.LoadPersonInfo(_User.EmployeeInfo.PersonID);
                lblUserName.Text = _User.UserName;
                lblIsActive.Text = (_User.IsActive) ? "Active":"Not Active" ;
                lblUserID.Text = UserID.ToString();
            }else
            {
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void llEditUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateUser frm =new frmAddUpdateUser(_UserID);
            frm.ShowDialog();
        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
