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

namespace CarRental.Rental_Transaction
{
    public partial class frmShowRentalTransActionInfo : Form
    {
        int _RentalTransActionID;
        public frmShowRentalTransActionInfo(int RentalTransActionID)
        {
            InitializeComponent();
            _RentalTransActionID = RentalTransActionID;
        }

        private void frmShowRentalTransActionInfo_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmShowRentalDetails))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlRentalTransactionDetails1.LoadRentalTransaction(_RentalTransActionID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
