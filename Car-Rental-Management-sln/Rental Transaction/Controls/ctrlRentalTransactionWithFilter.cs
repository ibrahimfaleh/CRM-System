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

namespace CarRental.Rental_Transaction.Controls
{
    public partial class ctrlRentalTransactionWithFilter : UserControl
    {
        public ctrlRentalTransactionWithFilter()
        {
            InitializeComponent();
        }
        public event Action<bool> OnRentalTransactionSelected;
        protected virtual void RentalTransactionSelected(bool IsSelected)
        {
            Action<bool> handler = OnRentalTransactionSelected;
            if (handler != null)
            {
                handler(IsSelected);
            }
        }
        private bool _VehicleEditedVisible = false;
        public bool VehicleEditedVisible
        {
            get
            {
                return _VehicleEditedVisible;
            }
            set
            {
                _VehicleEditedVisible = value;
                ctrlRentalTransactionDetails1.VehicleEditeVisable = _VehicleEditedVisible;
            }
        }
        private bool _FindEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FindEnabled;
            }
            set
            {
                _FindEnabled = value;
                gbFind.Enabled = _FindEnabled;
            }
        }

        private clsRentalTransaction _RentalTransaction;
        public clsRentalTransaction RentalTransaction { get {return _RentalTransaction; } }
        public void LoadRentalTransaction(int TransactionID)
        {

            cmbFindBy.SelectedIndex = 0;
            txtValue.Text = TransactionID.ToString();
            _FindNow();

        }
        private void _FindNow()
        {
            switch(cmbFindBy.Text) 
            {
                case "Transaction ID":
                    ctrlRentalTransactionDetails1.LoadRentalTransaction(int.Parse(txtValue.Text));
                    break;
                case "Plate Number":
                    ctrlRentalTransactionDetails1.LoadRentalTransaction(txtValue.Text); 
                    break;
            }
            _RentalTransaction = ctrlRentalTransactionDetails1.rentalTransactionSelected;
            if (OnRentalTransactionSelected != null && _RentalTransaction!=null&&gbFind.Enabled)
                OnRentalTransactionSelected(true);
            if (OnRentalTransactionSelected != null && _RentalTransaction == null && gbFind.Enabled)
                OnRentalTransactionSelected(false);

        }
        public void ResetDefalutValues()
        {
            ctrlRentalTransactionDetails1.DefaultValues();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtValue.Text!="")
            _FindNow();
        }
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
            if (cmbFindBy.Text == "Transaction ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
