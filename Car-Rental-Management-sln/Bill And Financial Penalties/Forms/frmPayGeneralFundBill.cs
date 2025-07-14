using CarRental.Classes;
using CarRental.Rental_Fund.General_Revenue_Fund;
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
    public partial class frmPayGeneralFundBill : Form
    {
        public struct stMembers
        {
            public int TransactionID;
            public clsGeneralFundBill GeneralFundBill;
            public DataTable dt;
        }
        private stMembers _Members;
        public frmPayGeneralFundBill()
        {
            InitializeComponent();
        }
        private void _dgvColumnDesign()
        {
            _Members.dt = clsGeneralFundBill.GetAllGeneralFundBills();
            if (_Members.dt.Rows.Count > 0)
            {
                dgvListOfContracts.DataSource = _Members.dt;

                dgvListOfContracts.Columns[0].HeaderText = "City Name";
                dgvListOfContracts.Columns[0].Width = 150;

                dgvListOfContracts.Columns[1].HeaderText = "Street Name";
                dgvListOfContracts.Columns[1].Width = 150;

                dgvListOfContracts.Columns[2].HeaderText = "Transaction ID";
                dgvListOfContracts.Columns[2].Width = 100;

                dgvListOfContracts.Columns[3].HeaderText = "Bill ID";
                dgvListOfContracts.Columns[3].Width = 150;

                dgvListOfContracts.Columns[4].HeaderText = "Cost";
                dgvListOfContracts.Columns[4].Width = 200;

                dgvListOfContracts.Columns[5].HeaderText = "Details";
                dgvListOfContracts.Columns[5].Width = 150;

                dgvListOfContracts.Columns[6].HeaderText = "C.Date";
                dgvListOfContracts.Columns[6].Width = 150;

                dgvListOfContracts.Columns[7].HeaderText = "Payment Status";
                dgvListOfContracts.Columns[7].Width = 100;

                dgvListOfContracts.Columns[8].HeaderText = "Payment Date";
                dgvListOfContracts.Columns[8].Width = 150;

                dgvListOfContracts.Columns[9].HeaderText = "Active";
                dgvListOfContracts.Columns[9].Width = 80;



                dgvListOfContracts.Columns[10].HeaderText = "C.By UserID";
                dgvListOfContracts.Columns[10].Width = 150;


                dgvListOfContracts.Columns[11].HeaderText = "U.By User ID";
                dgvListOfContracts.Columns[11].Width = 150;

                dgvListOfContracts.Columns[12].HeaderText = "U.Date";
                dgvListOfContracts.Columns[12].Width = 150;




                lblRecordsCount.Text = _Members.dt.Rows.Count.ToString();
            }
        }
        private void _ResetDefaultValues()
        {
            _dgvColumnDesign();
            ctrlBillCard1.ResetDefaultValues();
            lblTitle.Text = "Pay General Fund Bill New";
            btnPay.Text = "Pay";
        }
        private void _LoadData()
        {
            _Members.GeneralFundBill = clsGeneralFundBill.Find(_Members.TransactionID);
            if( _Members.GeneralFundBill != null )
            {
                ctrlBillCard1.LoadData(_Members.GeneralFundBill.BillID);
                if(_Members.GeneralFundBill.AmountSpentID.HasValue)
                {
                    lblTitle.Text = "Pay General Fund Bill Update";
                    btnPay.Text = "Update";
                }
            }
            else
            {
                MessageBox.Show("Error Loading Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void frmPayGeneralFundBill_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }
        private void DataBack(object sender,int AmountID,bool IsSave,double Amount)
        {
            if(IsSave)
            {
                _Members.GeneralFundBill.AmountSpentID = AmountID;
                if(_Members.GeneralFundBill.Save())
                {
                    ctrlBillCard1.Bill.IsPaid = true;
                    ctrlBillCard1.Bill.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
                    ctrlBillCard1.Bill.UpdatedDate=DateTime.Now;
                    ctrlBillCard1.Bill.Save();
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Members.TransactionID=_Members.GeneralFundBill.TransactionID;
                    _ResetDefaultValues();
                    _LoadData();
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(ctrlBillCard1.Bill==null)
            {
                return;
            }
            _Members.GeneralFundBill.BillID = ctrlBillCard1.Bill.BillID;
            if(_Members.GeneralFundBill.AmountSpentID.HasValue)
            {
                frmAddUpdateAmountSpent addUpdateAmountSpent = new frmAddUpdateAmountSpent(_Members.GeneralFundBill.AmountSpentID.Value);
                addUpdateAmountSpent.DataBack += DataBack;
                addUpdateAmountSpent.ShowDialog();
            }
            else
            {
                frmAddUpdateAmountSpent addUpdateAmountSpent = new frmAddUpdateAmountSpent(ctrlBillCard1.Bill.Cost, true);
                addUpdateAmountSpent.DataBack += DataBack;
                addUpdateAmountSpent.ShowDialog();
            }
        }
        private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Members.TransactionID = (int)dgvListOfContracts.CurrentRow.Cells[2].Value;
            btnPay.Text = "Pay";
            _LoadData();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsGeneralFundBill.DeleteGeneralFundBill((int)dgvListOfContracts.CurrentRow.Cells[2].Value))
            {
                MessageBox.Show("Deleted successfully", "",MessageBoxButtons.OK,MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
                MessageBox.Show("The deletion was not successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cmbFilterBy.Text != "None");
            if (!txtFilterValue.Visible)
                txtFilterValue.Text = "";
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string Filter = "";
            switch(cmbFilterBy.Text)
            {
                case "Bill ID":
                    Filter = "BillID = " + txtFilterValue.Text;
                    break;
            }
            if (txtFilterValue.Text == "")
                Filter = "";
            _Members.dt.DefaultView.RowFilter = Filter;
            lblRecordsCount.Text = dgvListOfContracts.Rows.Count.ToString();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
