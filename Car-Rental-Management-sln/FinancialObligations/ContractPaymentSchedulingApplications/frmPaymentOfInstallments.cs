using CarRental.Classes;
using CarRental.Rental_Fund.General_Revenue_Fund;
using CarRental_Business;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmPaymentOfInstallments : Form
    {
        clsContractPaymentSchedulingApplication _application;
        private DataTable _dtListInstallments;
        private int _ApplicationID;
        clsContractPaymentSchedule _contractPaymentSchedule;
        public frmPaymentOfInstallments(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }
        private void _LoadListInstallmentsInDataGridView()
        {
            _dtListInstallments = clsContractPaymentSchedule.GetAllContractPaymentSchedules(_ApplicationID);
            foreach (DataRow row in _dtListInstallments.Rows)
            {
                DateTime DueDate = DateTime.Parse(row[9].ToString());
                DateTime? PaymentDate=null;
                if (row[10].ToString()!="")
                    PaymentDate = DateTime.Parse(row[10].ToString());
                dgvListInstallments.Rows.Add(row[3], row[4], row[5], row[6], row[7], row[8], DueDate.ToString("d"), PaymentDate?.ToString("d"), row[11], row[13]);
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
                _contractPaymentSchedule.PaymentByUserID=clsGlobal.CurrentUser.UserID;
                _contractPaymentSchedule.PaymentDate = DateTime.Now;    
                _contractPaymentSchedule.PaymentStatus =(byte)clsContractPaymentSchedule.enPaymentStatus.Full;
                _contractPaymentSchedule.AmountSpentID = AmountSpentID;
                if(_contractPaymentSchedule.Save())
                {
                    if (_contractPaymentSchedule.TypeObligation != (byte)clsContractPaymentSchedule.enTypeObligation.FinalPayment && _contractPaymentSchedule.TypeObligation != (byte)clsContractPaymentSchedule.enTypeObligation.InitialPayment)
                        clsContractPaymentSchedule.UpdateThePaymentScheduleAfterPayingOneInstallment(_contractPaymentSchedule.ObligationID, _contractPaymentSchedule.PartOfObligationID ?? -1);
                    else if (_contractPaymentSchedule.TypeObligation == (byte)clsContractPaymentSchedule.enTypeObligation.InitialPayment)
                        contract.InitialAmountPaid = TotalAmount;
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


        }
        private void _LoadData()
        {
            _application = clsContractPaymentSchedulingApplication.Find(_ApplicationID);
            if (_application == null)
            {
                MessageBox.Show("Error: loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            llApplicationID.Text = _application.ApplicationID.ToString();
            ctrlContractDetails1.LoadData(_application.ContractID);
            _LoadListInstallmentsInDataGridView();
        }

        private void frmPaymentOfInstallments_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void payNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
             _contractPaymentSchedule = clsContractPaymentSchedule.Find((int)dgvListInstallments.CurrentRow.Cells[0].Value);
            if (_contractPaymentSchedule == null)
                return;
            if (_contractPaymentSchedule.PaymentStatus == (byte)clsContractPaymentSchedule.enPaymentStatus.Full)
                return;
            if(_contractPaymentSchedule.DueDate>DateTime.Now)
            {
                MessageBox.Show("You can pay after "+(_contractPaymentSchedule.DueDate-DateTime.Now).TotalDays+" days","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(clsContractPaymentSchedule.IsDueInstallmentDateForSchedulingMethodBasic(_ApplicationID, _contractPaymentSchedule.ObligationID))
            {
                MessageBox.Show("previous payments must be paid.", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddUpdateAmountSpent frm = new frmAddUpdateAmountSpent(_contractPaymentSchedule.DeservedAmount- _contractPaymentSchedule.AmountPaid, true);
            frm.DataBack += DataBackAmountSpent;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStrip1.Items[0].Visible = (dgvListInstallments.CurrentRow.Cells[8].Value.ToString() != "Full");
            contextMenuStrip1.Items[1].Visible = (dgvListInstallments.CurrentRow.Cells[8].Value.ToString() == "Full"&& dgvListInstallments.CurrentRow.Cells[9].Value.ToString() != "");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListInstallments.CurrentRow.Cells[9].Value.ToString() == "")
                return;
            frmAddUpdateAmountSpent frmAddUpdateAmountSpent = new frmAddUpdateAmountSpent((int)dgvListInstallments.CurrentRow.Cells[9].Value);
            frmAddUpdateAmountSpent.ShowDialog();
        }

        private void llApplicationID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateContractPaymentScheduling frmAddUpdateContractPaymentScheduling = new frmAddUpdateContractPaymentScheduling(_application.ApplicationID,true);
            frmAddUpdateContractPaymentScheduling.ShowDialog();
            frmPaymentOfInstallments_Load(null,null);
        }
    }
}
