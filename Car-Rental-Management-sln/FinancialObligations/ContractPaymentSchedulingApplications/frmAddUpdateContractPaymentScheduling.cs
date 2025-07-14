using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace CarRental
{
    public partial class frmAddUpdateContractPaymentScheduling : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        private enum enTypePayment { Full = 1, Partial = 2 }
        private enTypePayment _TypePayment;
        private enMode _Mode;
        private int _ApplicationID;
        private clsContractPaymentSchedulingApplication _Application;
        private DataTable _dtContractObligations;
        private DataTable _dtOldContractObligations;
        private clsContractPaymentSchedule _InitialPayment;
        private clsContractPaymentSchedule _PaymentLater;
        private clsContractPaymentSchedule _FullPayment;
        private clsContractPaymentSchedule _FinalPayment;
        Dictionary<clsContractPaymentSchedule, List<clsContractPaymentSchedule>> _BasicPartial_FacilitatorPartial_Installments
    = new Dictionary<clsContractPaymentSchedule, List<clsContractPaymentSchedule>>();
        private List<clsContractPaymentSchedule> _listContractObligationForPartialPaymentsBase;
        private List<clsContractPaymentSchedule> _listContractObligationForPartialPaymentsChildren;
        private List<clsContractPaymentSchedule> _listContractObligationForFinalPayment;
        private List<clsContractPaymentSchedule> _BasicInstallments = new List<clsContractPaymentSchedule>();
        private List<clsContractPaymentSchedule> _FacilitatorInstallments = new List<clsContractPaymentSchedule>();
        List<clsContractPaymentSchedule> _FacilitatorInstallmentsForFinalPayments = new List<clsContractPaymentSchedule>();
        clsContractPaymentSchedule _OnePaymentLater = new clsContractPaymentSchedule();
        private byte _PaymentEveryMonths;
        private byte _NumberOfMonths;
        private double _TotalDueAmount;
        private byte _NumberOfPaidMonths;
        private bool _IsShowDialog;
        private DateTime? _LastPaidAmountForPartialPayments;
        void _generateOnePaymentLater()
        {
            _OnePaymentLater = _generateContractPaymentSchedule(
                ctrlContractDetailsWithFilter1.SelectedContract.DeferredPaymentDueDate.Value,
                ctrlContractDetailsWithFilter1.SelectedContract.ContractAmount,
                clsContractPaymentSchedule.enSchedulingMethod.Basic,
                clsContractPaymentSchedule.enTypeObligation.OnePaymentLater
                , null
                );
        }
        void _generateFullPayment()
        {
            _OnePaymentLater = _generateContractPaymentSchedule(
                ctrlContractDetailsWithFilter1.SelectedContract.StartContract,
                ctrlContractDetailsWithFilter1.SelectedContract.ContractAmount,
                clsContractPaymentSchedule.enSchedulingMethod.Basic,
                clsContractPaymentSchedule.enTypeObligation.FullPayment
                , null
                );
        }
        Dictionary<clsContractPaymentSchedule, List<clsContractPaymentSchedule>> _generateContractPaymentsSchedule(DateTime start, DateTime end, double amount,
            clsContractPaymentSchedule.enSchedulingMethod method, clsContractPaymentSchedule.enTypeObligation type, bool PayMonthly, int paymentEvery, int? PartOfObligationID)
        {

            Dictionary<clsContractPaymentSchedule, List<clsContractPaymentSchedule>> Basic_Facilitator_Installments
                        = new Dictionary<clsContractPaymentSchedule, List<clsContractPaymentSchedule>>();
            double AmountDueEachPayment;
            int DateDifference = (((end.Year - start.Year)*12) + (end.Month - start.Month));
            if (DateDifference > 0)
                AmountDueEachPayment = amount / (DateDifference / paymentEvery);
            else
                AmountDueEachPayment = amount;
            do
            {
                Basic_Facilitator_Installments.Add(_generateContractPaymentSchedule(start, AmountDueEachPayment, method, type, PartOfObligationID), new List<clsContractPaymentSchedule>());
                if (PayMonthly)
                    start = start.AddMonths(paymentEvery);
                else
                    start = start.AddYears(paymentEvery);
            }
            while (start < end);
            return Basic_Facilitator_Installments;
        }
        clsContractPaymentSchedule _generateContractPaymentSchedule(DateTime DueDate, double amount,
    clsContractPaymentSchedule.enSchedulingMethod method, clsContractPaymentSchedule.enTypeObligation type, int? PartOfObligationID)
        {
            clsContractPaymentSchedule paymentSchedule = new clsContractPaymentSchedule();
            paymentSchedule.TypeObligation = (byte)type;
            paymentSchedule.SchedulingMethod = (byte)method;
            paymentSchedule.AmountPaid = 0;
            paymentSchedule.DeservedAmount = amount;
            paymentSchedule.RemainingAmount = amount;
            paymentSchedule.DueDate = DueDate;
            paymentSchedule.PartOfObligationID = PartOfObligationID;
            return paymentSchedule;
        }
        byte _MaximumNumberOfChildren(DateTime DueDate)
        {
            return (byte)(DueDate.Month - _LastPaidAmountForPartialPayments.Value.Month);
        }
        void _generateFacilitatorInstallmentsForPartialPayments(clsContractPaymentSchedule BasicInstallment, byte NumberOfChildren)
        {
            
            DateTime DueDate = BasicInstallment.DueDate.AddMonths(-(NumberOfChildren-1));
            for (int i = 1; i < NumberOfChildren; i++)
            {
                _BasicPartial_FacilitatorPartial_Installments[BasicInstallment].Add(_generateContractPaymentSchedule(
                    DueDate
           , BasicInstallment.DeservedAmount / NumberOfChildren
           , clsContractPaymentSchedule.enSchedulingMethod.Facilitator
           , clsContractPaymentSchedule.enTypeObligation.PartialPayments
           , BasicInstallment.ObligationID
           ));
                DueDate = DueDate.AddMonths(1);
            }
        }
        void _generateFacilitatorInstallmentsForFirstPayment(clsContractPaymentSchedule paymentSchedule, byte NumberOfChildren)
        {
            byte MaximumNumberOfChildren = _MaximumNumberOfChildren(paymentSchedule.DueDate);
            _generateFacilitatorInstallmentsForPartialPayments(paymentSchedule
                , (byte)((MaximumNumberOfChildren < NumberOfChildren) ? MaximumNumberOfChildren : NumberOfChildren));
        }
        void _generateFacilitatorInstallmentsForPartialPayments(byte NumberOfChildren)
        {
            bool isFirstPayment = true;
            foreach (var item in _BasicPartial_FacilitatorPartial_Installments)
            {
                item.Value.Clear();
                if (item.Key.DueDate > (_LastPaidAmountForPartialPayments??ctrlContractDetailsWithFilter1.SelectedContract.StartContract) &&
                    item.Key.PaymentStatus
                    != (byte)clsContractPaymentSchedule.enPaymentStatus.Full)
                {
                    if (isFirstPayment)
                    {
                        _generateFacilitatorInstallmentsForFirstPayment(item.Key, NumberOfChildren);
                        isFirstPayment = false;
                        continue;
                    }
                }
                else
                    continue;
                _generateFacilitatorInstallmentsForPartialPayments(item.Key, NumberOfChildren);
            }
        }
        
        void _generateFacilitatorInstallmentsForFinalPayments()
        {
            if (ctrlContractDetailsWithFilter1.SelectedContract != null && ctrlContractDetailsWithFilter1.SelectedContract.AllowingFinalPaymentInstallments)
            {
                DateTime? due;
                int lastorder = clsContractPaymentSchedule.GetLstOrderPaidInstallmentForFinalPayment(_ApplicationID)??0;
                ++lastorder;
                due = ctrlContractDetailsWithFilter1.SelectedContract.EndContract;
                for (int i = lastorder; i < ctrlContractDetailsWithFilter1.SelectedContract.NumberOfMonthsOfFinalPaymentInstallments; i++)
                {
                    _FacilitatorInstallmentsForFinalPayments.Add(

                        _generateContractPaymentSchedule
                        (
                         due.Value
                         , ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment / ctrlContractDetailsWithFilter1.SelectedContract.NumberOfMonthsOfFinalPaymentInstallments
                         , clsContractPaymentSchedule.enSchedulingMethod.Facilitator
                         , clsContractPaymentSchedule.enTypeObligation.FinalPayment
                         , null

                        )
                        );
                    due = due.Value.AddMonths(1);

                }
                _FinalPayment.DueDate=due.Value;  
            }

        }
        void _generateInitialPayment(double inintialAmount)
        {
            if (inintialAmount > 0)
                _InitialPayment = _generateContractPaymentSchedule(
                    ctrlContractDetailsWithFilter1.SelectedContract.StartContract,
                    inintialAmount,
                    clsContractPaymentSchedule.enSchedulingMethod.Basic,
                    clsContractPaymentSchedule.enTypeObligation.InitialPayment,
                    null
                    );
        }
        void _generateFinalPayment(double finalAmount)
        {
            if (finalAmount > 0)
                _FinalPayment = _generateContractPaymentSchedule(
                    ctrlContractDetailsWithFilter1.SelectedContract.EndContract,
                    finalAmount,
                    clsContractPaymentSchedule.enSchedulingMethod.Basic,
                    clsContractPaymentSchedule.enTypeObligation.FinalPayment,
                    null
                    );
        }
        void _generatePartialPayments(double TotalPartialAmounts)
        {
            if (TotalPartialAmounts <= 0)
                return;

            _BasicPartial_FacilitatorPartial_Installments = (_generateContractPaymentsSchedule(
                (_LastPaidAmountForPartialPayments==null)?ctrlContractDetailsWithFilter1.SelectedContract.StartContract:_LastPaidAmountForPartialPayments.Value.AddYears(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears).AddMonths(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths),
                ctrlContractDetailsWithFilter1.SelectedContract.EndContract
                , TotalPartialAmounts
                , clsContractPaymentSchedule.enSchedulingMethod.Basic
                , clsContractPaymentSchedule.enTypeObligation.PartialPayments
                , true
                , (ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths > 0 ? ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths : ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears)
                , null
                ));
        }
        (double, double, double) _getInitialAmount_FinalAmount_TotalPartialAmounts()
        {
            double inintialAmount;
            double finalAmount;
            double TotalPartialAmounts;
            inintialAmount = ctrlContractDetailsWithFilter1.SelectedContract.InitialPayment - ctrlContractDetailsWithFilter1.SelectedContract.InitialAmountPaid;
            finalAmount = ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment - ctrlContractDetailsWithFilter1.SelectedContract.FinalAmountPaid;
            TotalPartialAmounts = ctrlContractDetailsWithFilter1.SelectedContract.TotalRemainingAmount - (inintialAmount + finalAmount);
            return (inintialAmount, TotalPartialAmounts, finalAmount);
        }
        void _generateAllPayments()
        {
            if (ctrlContractDetailsWithFilter1.SelectedContract == null)
                return;
            switch (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType)
            {
                case (byte)clsContract.enPaymentType.Partial:
                    (double, double, double) InitialAmount_FinalAmount_TotalPartialAmounts = _getInitialAmount_FinalAmount_TotalPartialAmounts();
                    _generateInitialPayment(InitialAmount_FinalAmount_TotalPartialAmounts.Item1);
                    _generatePartialPayments(InitialAmount_FinalAmount_TotalPartialAmounts.Item2);
                    _generateFinalPayment(InitialAmount_FinalAmount_TotalPartialAmounts.Item3);
                    break;

                case (byte)clsContract.enPaymentType.Full:
                    _generateFullPayment();

                    break;
                case (byte)clsContract.enPaymentType.OnePaymentLater:
                    _generateOnePaymentLater();
                    break;
            }

        }
        public frmAddUpdateContractPaymentScheduling(int ApplicationID, bool IsShowDialog)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            _Mode = enMode.Update;
            _IsShowDialog = IsShowDialog;
        }
        public frmAddUpdateContractPaymentScheduling()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        private void _ColumnsDesignForNewContractObligations()
        {
            dgvNewContractObligations.Columns[0].HeaderText = "Contract ID";
            dgvNewContractObligations.Columns[1].Visible = false;
            dgvNewContractObligations.Columns[2].HeaderText = "Type Obligation";
            dgvNewContractObligations.Columns[3].Visible = false;
            dgvNewContractObligations.Columns[4].HeaderText = "Scheduling Method";
            dgvNewContractObligations.Columns[5].HeaderText = "Deserved Amount";
            dgvNewContractObligations.Columns[6].HeaderText = "Amount Paid";
            dgvNewContractObligations.Columns[7].HeaderText = "Remaining Amount";
            dgvNewContractObligations.Columns[8].HeaderText = "Due Date";
            dgvNewContractObligations.Columns[9].HeaderText = "Payment Date";
            dgvNewContractObligations.Columns[10].Visible = false;
            dgvNewContractObligations.Columns[11].HeaderText = "Payment Status";

            dgvNewContractObligations.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNewContractObligations.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;


        }
        private void _LoadOldSchedulingInDataGridView()
        {
            _dtOldContractObligations = clsContractPaymentSchedule.GetAllContractPaymentSchedules(_ApplicationID);
            foreach (DataRow row in _dtOldContractObligations.Rows)
            {
                DateTime DueDate = DateTime.Parse(row[9].ToString());
                DateTime? PaymentDate = null;
                if (row[10].ToString() != "")
                    PaymentDate = DateTime.Parse(row[10].ToString());
                dgvOldContractObligations.Rows.Add(row[3], row[4], row[5], row[6], row[7], row[8], DueDate.ToString("d"), PaymentDate?.ToString("d"), row[11], row[13]);
                if (row["SchedulingMethod"].ToString() == "Basic")
                {
                    dgvOldContractObligations.Rows[dgvOldContractObligations.Rows.Count - 1].DefaultCellStyle.BackColor = Color.DimGray;
                    dgvOldContractObligations.Rows[dgvOldContractObligations.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
                if (row["PaymentStatus"].ToString() == "Full")
                {
                    dgvOldContractObligations.Rows[dgvOldContractObligations.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                    dgvOldContractObligations.Rows[dgvOldContractObligations.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
            }
            lblRecordCountOldContractObligations.Text = dgvOldContractObligations.Rows.Count.ToString();

        }
        void _WriteIn_dgv(clsContractPaymentSchedule paymentSchedule, Color ForColor, Color BachColor)
        {
            if (paymentSchedule == null)
                return;
            dgvNewContractObligations.Rows.Add(0, paymentSchedule.TypeObligation, paymentSchedule.GetTypeObligation
            , paymentSchedule.SchedulingMethod, paymentSchedule.GetSchedulingMethod, paymentSchedule.DeservedAmount,
            paymentSchedule.AmountPaid, paymentSchedule.RemainingAmount,
            paymentSchedule.DueDate.ToString("d"), paymentSchedule.PaymentDate?.ToString("d"), paymentSchedule.PaymentStatus,
            paymentSchedule.GetPaymentStatus);
            dgvNewContractObligations.Rows[dgvNewContractObligations.Rows.Count - 1].DefaultCellStyle.BackColor = BachColor;
            dgvNewContractObligations.Rows[dgvNewContractObligations.Rows.Count - 1].DefaultCellStyle.ForeColor = ForColor;

        }
        void _WriteInitialPaymentIn_Dgv()
        {
            if (_InitialPayment != null)
            {
                _WriteIn_dgv(_InitialPayment, Color.White, Color.DimGray);
            }
        }
        void _Write_FacilitatorInstallments(List<clsContractPaymentSchedule> paymentSchedules)
        {
            if (paymentSchedules.Count <= 0)
                return;
            paymentSchedules.ForEach(
                f =>
                {
                    _WriteIn_dgv(f, Color.Black, Color.White);
                });
        }
        void _WriteBaseAndChildrenInDataGridView()
        {
            foreach (var item in _BasicPartial_FacilitatorPartial_Installments)
            {
                _Write_FacilitatorInstallments(item.Value);
                _WriteIn_dgv(item.Key, Color.White, Color.DimGray);
            }

        }
        void _WriteFinalPayment()
        {
            if (_FinalPayment != null)
            {
                _WriteIn_dgv(_FinalPayment, Color.White, Color.DimGray);
            }
        }
        void _WriteFacilitatorInstallmentsForFinalPayments()
        {
            _FacilitatorInstallmentsForFinalPayments.ForEach(x=> _WriteIn_dgv(x,Color.Black,Color.White));
        }
        void _WriteAllPaymentsIn_dgv()
        {
            dgvNewContractObligations.Rows.Clear();
            _WriteInitialPaymentIn_Dgv();
            _WriteBaseAndChildrenInDataGridView();
            if(cbFinalPaymentInstallment.Checked)
                _WriteFacilitatorInstallmentsForFinalPayments();

            _WriteFinalPayment();

        }
        void _saveIniniatlPayment()
        {
            if (_InitialPayment != null)
            {
                _InitialPayment.IsActive = true;
                _InitialPayment.ApplicationID = _Application.ApplicationID;
                _InitialPayment.Save();
            }
        }
        void _saveFinalPayment()
        {
            if (cbFinalPaymentInstallment.Checked) ;
            _FacilitatorInstallmentsForFinalPayments.ForEach
                (x =>
                {
                    x.IsActive = true;
                    x.ApplicationID = _Application.ApplicationID;
                    x.Save();
                }
                );
            if (_FinalPayment != null)
            {
                _FinalPayment.IsActive = true;
                _FinalPayment.ApplicationID = _Application.ApplicationID;
                _FinalPayment.Save();
            }
        }
        void _saveOnePaymentLater()
        {
            if(_OnePaymentLater != null)
            {
                _OnePaymentLater.IsActive = true;
                _OnePaymentLater.ApplicationID = _Application.ApplicationID;
                _OnePaymentLater.Save();
            }
        }
        void _savePartialPayments()
        {
            foreach (var item in _BasicPartial_FacilitatorPartial_Installments)
            {
                item.Key.ApplicationID = _Application.ApplicationID;
                item.Key.Save();
                item.Value.ForEach(x =>
                {
                    x.PartOfObligationID = item.Key.ObligationID;
                    x.ApplicationID=_Application.ApplicationID; 
                    x.IsActive = true;
                    x.Save();
                });
            }
        }
        void _saveFullPayment()
        {
            if (_FullPayment != null)
            {
                _FullPayment.IsActive = true;
                _FullPayment.ApplicationID = _Application.ApplicationID;
                _FullPayment.Save();    
           
            }
        }


        private void _SaveNewScheduling()
        {
            if (_Mode == enMode.Update)
                if (!clsContractPaymentSchedule.ClearingOldInstallments(_Application.ApplicationID))
                {
                    MessageBox.Show("Failed to save installment schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            switch (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType)
            {
                case (byte)clsContract.enPaymentType.Partial:
                    _saveIniniatlPayment();
                    _savePartialPayments();
                    _saveFinalPayment();    
                    break;

                case (byte)clsContract.enPaymentType.Full:
                    _saveFullPayment();

                    break;
                case (byte)clsContract.enPaymentType.OnePaymentLater:
                    _saveOnePaymentLater();
                    break;
            }
        }
        private void _ResetDefaultValues()
        {
            nudNumberOfMonthspayContract.Minimum = 0;
            nudNumberOfMonthspayContract.Value = 0;

            lblRecordsCountNewContractObligations.Text = "0";
            lblRecordCountOldContractObligations.Text = "0";
            lbltitle.Text = "New Contract Payment Scheduling";
            _Application = new clsContractPaymentSchedulingApplication();
            cbFinalPaymentInstallment.Enabled = false;
            gbObligation.Enabled = false;
            btnSave.Enabled = true;
            _dtContractObligations = new DataTable();
            _dtOldContractObligations = new DataTable();
            dgvOldContractObligations.Rows.Clear();
            _TypePayment = enTypePayment.Partial;
            ctrlContractDetailsWithFilter1.ResetDefaultValues();
            _ColumnsDesignForNewContractObligations();

        }
        private void _LoadData()
        {
            _Application = clsContractPaymentSchedulingApplication.Find(_ApplicationID);
            if (_Application != null)
            {
                lbltitle.Text = "Update Contract Payment Scheduling";
                _LoadOldSchedulingInDataGridView();
                ctrlContractDetailsWithFilter1.FilterEnabled = false;
                ctrlContractDetailsWithFilter1.Find(_Application.ContractID);
                if (_Application.Status == (byte)clsContractPaymentSchedulingApplication.enStatus.Canceled || _Application.Status == (byte)clsContractPaymentSchedulingApplication.enStatus.Completed)
                {
                    gbObligation.Enabled = false;
                    btnSave.Enabled = false;
                    MessageBox.Show("This app has been canceled or completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _LastPaidAmountForPartialPayments = clsContractPaymentSchedule.GetLstPaidInstallmentDateForPartialPayments(_ApplicationID);
                _fillgbObligation();
                _generateAllPayments();
                _WriteAllPaymentsIn_dgv();
            }
        }
        public void frmContractObligation_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlContractDetailsWithFilter1.SelectedContract == null || _TypePayment == enTypePayment.Full)
                return;
            switch (cmbSchedulingMethod.Text)
            {
                case "Basic":
                    nudNumberOfMonthspayContractEnabled(false);
                    _generateAllPayments();
                    break;
                case "Facilitator":
                    nudNumberOfMonthspayContractEnabled(true);
                    _generateFacilitatorInstallmentsForPartialPayments((byte)nudNumberOfMonthspayContract.Value);
                    
                    break;
            }
            _WriteAllPaymentsIn_dgv();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void cbFinalPaymentInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFinalPaymentInstallment.Checked)
            {
                if (_FacilitatorInstallmentsForFinalPayments.Count == 0)
                    _generateFacilitatorInstallmentsForFinalPayments();
            }
            else
                _FinalPayment.DueDate = ctrlContractDetailsWithFilter1.SelectedContract.EndContract;
            _WriteAllPaymentsIn_dgv();
        }
        bool _SaveApplication()
        {
            if (_Mode == enMode.AddNew)
            {
                _Application.CreatedByUserID = 1;
                _Application.CreatedDate = DateTime.Now;
            }
            if (_Mode == enMode.Update)
            {
                _Application.UpdatedByUserID = 1;
                _Application.UpdatedDate = DateTime.Now;
            }
            _Application.ContractID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
            if (_Mode == enMode.Update && _IsShowDialog)
                if (MessageBox.Show("Do you really want to reschedule?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return false;
            return _Application.Save();
        }
        void _AfterSave()
        {
            _WriteAllPaymentsIn_dgv();
            _LoadOldSchedulingInDataGridView(); 
            lbltitle.Text = "Update";

        }
        public void btnSave_Click(object sender, EventArgs e)
        {
                if (_SaveApplication())
                {
                    _ApplicationID = _Application.ApplicationID;
                    _SaveNewScheduling();
                    _AfterSave();
                    _Mode = enMode.Update;

                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        void _fillgbObligation()
        {
            gbObligation.Enabled = true;
            cmbSchedulingMethod.SelectedIndex = 0;
            if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths > 0)
                nudNumberOfMonthspayContract.Maximum = ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths;
            else
                nudNumberOfMonthspayContract.Maximum = ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears * 12;
            rbIsMonthly.Enabled = ctrlContractDetailsWithFilter1.SelectedContract.AllowingFinalPaymentInstallments;
            cbFinalPaymentInstallment.Enabled=rbIsMonthly.Checked;  
        }
        private void ctrlContractDetailsWithFilter1_OnContractSelected(bool obj)
        {
            _dtContractObligations.Rows.Clear();
            if (obj)
            {
                _ColumnsDesignForNewContractObligations();
                if (clsContractPaymentSchedulingApplication.isContractPaymentSchedulingApplicationExistByContractID(ctrlContractDetailsWithFilter1.SelectedContract.ContractID))
                {
                    _Mode = enMode.Update;
                    _ApplicationID = clsContractPaymentSchedulingApplication.FindByContractID(ctrlContractDetailsWithFilter1.SelectedContract.ContractID).ApplicationID;
                    _LoadData();
                    return;
                }
                _fillgbObligation();

            }
        }
        private void lbltitleTransaction_Click(object sender, EventArgs e)
        {

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            _ApplicationID = -1;
            _Mode = enMode.AddNew;
            _ResetDefaultValues();
        }
        private void gbObligation_Enter(object sender, EventArgs e)
        {

        }
        private void nudNumberOfMonthspayContract_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumberOfMonthspayContract.Value == 0)
                return;
            _generateFacilitatorInstallmentsForPartialPayments((byte)nudNumberOfMonthspayContract.Value);
            _WriteAllPaymentsIn_dgv();
        }
        private void nudNumberOfMonthspayContractEnabled(bool Enabled)
        {
            if (Enabled)
            {
                nudNumberOfMonthspayContract.Enabled = true;
                nudNumberOfMonthspayContract.Value = nudNumberOfMonthspayContract.Maximum;
                nudNumberOfMonthspayContract.Minimum = 2;
            }
            else
            {
                nudNumberOfMonthspayContract.Minimum = 0;
                nudNumberOfMonthspayContract.Value = 0;
                nudNumberOfMonthspayContract.Enabled = false;
                _listContractObligationForPartialPaymentsChildren = new List<clsContractPaymentSchedule>();
            }
            txtPaymentBase.Enabled = nudNumberOfMonthspayContract.Enabled;
        }
    }
}