using CarRental.Classes;
using System;
using System.Windows.Forms;

namespace CarRental.Users
{
    public partial class frmListUsersTransActions : Form
    {
        private int? _BranchID;
        public frmListUsersTransActions()
        {
            InitializeComponent();
        }
        public frmListUsersTransActions(int BranchID)
        {
            InitializeComponent();
            _BranchID = BranchID;
        }
        private void frmListUsersTransActions_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListUsersTransaction))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (_BranchID.HasValue)
                ctrldgListUsersTransActions1.ctrldgListUsersTransActions_LoadByBranchID(_BranchID.Value);
            else
                ctrldgListUsersTransActions1.ctrldgListUsersTransActions_Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
