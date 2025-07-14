using CarRental.Classes;
using CarRental.Properties;
using CarRental_Business;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.Bill.Controls
{
    public partial class ctrlBillCard : UserControl
    {

        private clsBill _Bill;
        public clsBill Bill { get { return _Bill; } }
        private bool _llUpdateVisible = false;
        public bool UpdateVisible
        {
            set
            {
                _llUpdateVisible = value;
                llUpdate.Visible = _llUpdateVisible;
            }
            get { return _llUpdateVisible; }
        }
        public void ResetDefaultValues()
        {
            _Bill = null;
            lblCost.Text = string.Empty;
            txtDetails.Text = string.Empty;
            llBillID.Text = string.Empty;
            lblCreatedDate.Text = string.Empty;
            lblType.Text = string.Empty;
            lblUpdatedDate.Text = string.Empty;
            pbBillImage.Image = Resources.bill;
            lblStatus.Text = string.Empty;  
        }
        public void LoadData(int BillID)
        {
            ResetDefaultValues();
            if((!clsGlobal.IsBranchInformationAvailable)&&clsGlobal.CurrentUser.IsAdmin)
            _Bill = clsBill.Find(BillID);
            else if(clsGlobal.IsBranchInformationAvailable)
                _Bill = clsBill.Find(BillID,clsGlobal.Branch.BranchID);

            if (_Bill != null)
            {
                lblCost.Text = _Bill.Cost.ToString();
                lblCreatedDate.Text = _Bill.CreatedDate.ToString("d");
                lblUpdatedDate.Text = _Bill.UpdatedDate?.ToString("d");
                txtDetails.Text = _Bill.Details.ToString();
                llBillID.Text = _Bill.BillID.ToString();
                lblType.Text = clsTypesOfBill.Find(_Bill.TypeID).Type;
                if (_Bill.ImagePath != "")
                {
                    pbBillImage.ImageLocation = _Bill.ImagePath;

                }
                if(_Bill.IsPaid)
                {
                    lblStatus.Text = "Paid";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Unpaid";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            else
                MessageBox.Show("Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public ctrlBillCard()
        {
            InitializeComponent();
        }

        private void llUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Bill != null)
            {
                frmAddUpdateBills addUpdateBills = new frmAddUpdateBills(_Bill.BillID);
                addUpdateBills.ShowDialog();
            }
        }

        private void pbBillImage_Click(object sender, System.EventArgs e)
        {
            if (_Bill != null)
                if (_Bill.ImagePath == null)
                    return;

            frmShowImage frmShow = new frmShowImage(_Bill.ImagePath);
            frmShow.ShowDialog();
        }
    }
}
