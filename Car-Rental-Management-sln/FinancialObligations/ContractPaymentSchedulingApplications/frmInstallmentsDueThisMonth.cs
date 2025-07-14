using CarRental.Classes;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental_Business;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.FinancialObligations.ContractPaymentSchedulingApplications
{
    public partial class frmInstallmentsDueThisMonth : Form
    {
        private clsContractPaymentSchedulingApplication _application;
        private short _Year = (short)DateTime.Now.Year;
        private byte _Month = (byte)DateTime.Now.Month;
        private DataTable _dtListInstallments;
        private clsContractPaymentSchedule _contractPaymentSchedule;
        private int? _BranchID;
        public frmInstallmentsDueThisMonth()
        {
            InitializeComponent();
        }
        public frmInstallmentsDueThisMonth(int? branchID)
        {
            InitializeComponent();
            _BranchID = branchID;
        }
        private void _LoadListInstallmentsInDataGridView()
        {
            foreach (DataRow row in _dtListInstallments.Rows)
            {
                dgvListInstallments.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11]);
                if (row["SchedulingMethod"].ToString() == "Basic")
                {
                    dgvListInstallments.Rows[dgvListInstallments.Rows.Count - 1].DefaultCellStyle.BackColor = Color.DimGray;
                    dgvListInstallments.Rows[dgvListInstallments.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
                if (row["PaymentStatus"].ToString() == "Full")
                {
                    dgvListInstallments.Rows[dgvListInstallments.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                    dgvListInstallments.Rows[dgvListInstallments.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            lblRecordsCount.Text = dgvListInstallments.Rows.Count.ToString();
        }
        private void DataBackAmountSpent(object sender, int AmountSpentID, bool IsSave, double TotalAmount)
        {
            if (IsSave)
            {
                clsContract contract = clsContract.Find(_application.ContractID);
                _contractPaymentSchedule.RemainingAmount = 0;
                _contractPaymentSchedule.AmountPaid += TotalAmount;
                _contractPaymentSchedule.PaymentByUserID = clsGlobal.CurrentUser.UserID;
                _contractPaymentSchedule.PaymentDate = DateTime.Now;
                _contractPaymentSchedule.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Full;
                _contractPaymentSchedule.AmountSpentID = AmountSpentID;
                if (_contractPaymentSchedule.Save())
                {
                    if (_contractPaymentSchedule.TypeObligation != (byte)clsContractPaymentSchedule.enTypeObligation.FinalPayment && _contractPaymentSchedule.TypeObligation 
                        != (byte)clsContractPaymentSchedule.enTypeObligation.InitialPayment)
                        clsContractPaymentSchedule.UpdateThePaymentScheduleAfterPayingOneInstallment(_contractPaymentSchedule.ObligationID, _contractPaymentSchedule.PartOfObligationID ?? null);
                    else if (_contractPaymentSchedule.TypeObligation == (byte)clsContractPaymentSchedule.enTypeObligation.InitialPayment)
                        contract.InitialAmountPaid=TotalAmount;
                    else if (_contractPaymentSchedule.TypeObligation == (byte)clsContractPaymentSchedule.enTypeObligation.FinalPayment)
                        contract.FinalAmountPaid = TotalAmount;

                    contract.TotalAmountPaid += TotalAmount;
                    contract.TotalRemainingAmount -= TotalAmount;
                    if (contract.TotalRemainingAmount == 0)
                    {
                        contract.PaymentStatus = (byte)clsContract.enPaymentStatus.Full;
                        _application.Status = (byte)clsContractPaymentSchedulingApplication.enStatus.Completed;
                    }
                    else
                        contract.PaymentStatus = (byte)clsContract.enPaymentStatus.Partial;
                    contract.Save();
                    _application.Save();
                    _contractPaymentSchedule = null;
                    dgvListInstallments.Rows.Clear();
                    _LoadListInstallmentsInDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Error: Payment has not been made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _application = null;

        }
        private void _LoadData()
        {
            _dtListInstallments = clsContractPaymentSchedule.GetAllInstallmentsDueThisMonth(_Year,_Month);
            _LoadListInstallmentsInDataGridView();
        }
        private void _LoadData(int BranchID)
        {
            _dtListInstallments = clsContractPaymentSchedule.GetAllInstallmentsDueThisMonth(_Year,_Month,BranchID);
            _LoadListInstallmentsInDataGridView();
        }
        private void frmInstallmentsDueThisMonth_Load(object sender, EventArgs e)
        {
            if(_BranchID.HasValue)
                _LoadData(_BranchID.Value);
            else
                _LoadData();
        }
        private void payNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _application = clsContractPaymentSchedulingApplication.Find((int)dgvListInstallments.CurrentRow.Cells[2].Value);
            _contractPaymentSchedule = clsContractPaymentSchedule.Find((int)dgvListInstallments.CurrentRow.Cells[3].Value);
            if (_contractPaymentSchedule == null)
                return;
            if (_contractPaymentSchedule.PaymentStatus == (byte)clsContractPaymentSchedule.enPaymentStatus.Full)
                return;
            frmAddUpdateAmountSpent frm = new frmAddUpdateAmountSpent(_contractPaymentSchedule.RemainingAmount, true);
            frm.DataBack += DataBackAmountSpent;
            frm.ShowDialog();
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStrip1.Items[0].Visible = (dgvListInstallments.CurrentRow.Cells[11].Value.ToString() != "Full");
        }
        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentOfInstallments frmPaymentOfInstallments = new frmPaymentOfInstallments((int)dgvListInstallments.CurrentRow.Cells[2].Value);
            frmPaymentOfInstallments.ShowDialog();
        }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
