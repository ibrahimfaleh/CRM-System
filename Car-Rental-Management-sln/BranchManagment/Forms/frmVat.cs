using CarRental.Classes;
using CarRental_Business;
using Guna.UI2.WinForms;
using Microsoft.AnalysisServices;
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
    public partial class frmVat : Form
    {
        private clsTax _Tax;
        public frmVat()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmVat_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessPermissions(clsGlobal.enPermissions.frmVat))
            {
                MessageBox.Show("You do not have permission to do so.", "permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _Tax = clsTax.GetVat();
            nudNumberOfIncomeFundsPerDay.Value = (int)((_Tax.Vat+0.0001 - 1) * 100);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Tax.Vat =(float)nudNumberOfIncomeFundsPerDay.Value/100 + 1;
            _Tax.TaxDetails="%"+nudNumberOfIncomeFundsPerDay.Value.ToString();
            if(_Tax.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
