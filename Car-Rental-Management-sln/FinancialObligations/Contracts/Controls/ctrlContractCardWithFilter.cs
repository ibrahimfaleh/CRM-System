using CarRental_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ctrlContractCardWithFilter : UserControl
    {
        public event Action<bool> OnContractSelected;
        protected virtual void ContractSelected(bool IsFound)
        {
            Action<bool> handler = OnContractSelected;
            if (handler != null)
            {
                handler(IsFound);
            }
        }
        public double AmountOfEachPayment { get {  return ctrlContractDetails1.AmountOfEachPayment; } }    
        public byte NumberOfMonths { get { return ctrlContractDetails1.NumberOfMonthsForContract; } }
        public clsContract SelectedContract { get { return ctrlContractDetails1.SelectedContract; } }

        private bool _FilterEnabled = true;
        public bool FilterEnabled 
        {
            set 
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
            get 
            { 
                return _FilterEnabled;
            }
        }
        public ctrlContractCardWithFilter()
        {
            InitializeComponent();
        }
        
        public void ResetDefaultValues()
        {

            ctrlContractDetails1.ResetDefaultValues();
            txtFilterValue.Text = "";
            FilterEnabled = true;
            txtFilterValue.Focus();

        }
        public void Find(int contractID)
        {
            txtFilterValue.Text = contractID.ToString();
            ctrlContractDetails1.LoadData(contractID);
            if(OnContractSelected!=null&&_FilterEnabled) 
                OnContractSelected(ctrlContractDetails1.SelectedContract != null);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }
        private void DataBack(object sender, int ID)
        {
            ctrlContractDetails1.LoadData(ID);
        }
        private void btnListVehicles_Click(object sender, EventArgs e)
        {
            frmAddUpdateContract frm = new frmAddUpdateContract();
            frm.DataBackContractID += DataBack;
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFilterValue.Text != "")
                Find(int.Parse(txtFilterValue.Text));
        }

        private void ctrlContractDetails1_Load(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
