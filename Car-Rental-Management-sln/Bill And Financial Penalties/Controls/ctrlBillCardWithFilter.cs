using CarRental_Business;
using System;
using System.Windows.Forms;

namespace CarRental.Bill.Controls
{
    public partial class ctrlBillCardWithFilter : UserControl
    {
        public event Action<int> OnBillSelected;
        protected virtual void PersonSelected(int BillID)
        {
            Action<int> handler = OnBillSelected;
            if (handler != null)
            {
                handler(BillID);
            }
        }
        public bool UpdateVisible { get { return ctrlBillCard1.UpdateVisible; } set { ctrlBillCard1.UpdateVisible = value; } }
        public clsBill Bill { get { return ctrlBillCard1.Bill; } }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            set { _FilterEnabled = value; gbSerch.Enabled = _FilterEnabled; }
            get { return _FilterEnabled; }
        }
        public ctrlBillCardWithFilter()
        {
            InitializeComponent();
        }
        private void _FindNaw()
        {
            if (txtSerch.Text != "")
                ctrlBillCard1.LoadData(int.Parse(txtSerch.Text));
            if (OnBillSelected != null && FilterEnabled&&ctrlBillCard1.Bill!=null)
                OnBillSelected(ctrlBillCard1.Bill.BillID);
        }
        public void ResetValues()
        {
            txtSerch.Text = string.Empty;
            ctrlBillCard1.ResetDefaultValues();
        }
        public void LoadData(int BillID)
        {
            txtSerch.Text=BillID.ToString();    
            _FindNaw();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _FindNaw();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pbFind_Click(object sender, EventArgs e)
        {
            _FindNaw();
        }
        private void DataBack(object sender, int BillID)
        {
            txtSerch.Text = BillID.ToString();
            _FindNaw();
        }
        private void pbAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateBills addUpdateBills = new frmAddUpdateBills();
            addUpdateBills.DataBack += DataBack;
            addUpdateBills.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}
