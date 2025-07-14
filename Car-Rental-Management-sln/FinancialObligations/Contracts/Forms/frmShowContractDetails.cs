using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.FinancialObligations.Contracts.Forms
{
    public partial class frmShowContractDetails : Form
    {
        private int _ContractID;
        public frmShowContractDetails(int ContractID)
        {
            InitializeComponent();
            _ContractID = ContractID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowContractDetails_Load(object sender, EventArgs e)
        {
            ctrlContractCard1.LoadData(_ContractID);
        }
    }
}
