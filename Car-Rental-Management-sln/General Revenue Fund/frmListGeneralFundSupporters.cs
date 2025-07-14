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

namespace CarRental.General_Revenue_Fund
{
    public partial class frmListGeneralFundSupporters : Form
    {
        public frmListGeneralFundSupporters()
        {
            InitializeComponent();
        }

        private void frmGeneralFundSupporters_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmListGeneralFundSupporters))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrldgvGeneralFundSupportTransactions1.LoadGeneralFundSupportTransactions(clsGlobal.GeneralRevenueFundID);
        }
    }
}
