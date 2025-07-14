using CarRental_Business;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
        private clsContractPaymentSchedule _ContractObligationForInitialPayment;
        private clsContractPaymentSchedule _ContractObligationForOnePaymentLater;
        private clsContractPaymentSchedule _ContractObligationForFullPayment;
        private List<clsContractPaymentSchedule> _listContractObligationForPartialPaymentsBase;
        private List<clsContractPaymentSchedule> _listContractObligationForPartialPaymentsChildren;
        private List<clsContractPaymentSchedule> _listContractObligationForPartialPayments;
        private List<clsContractPaymentSchedule> _listContractObligationForFinalPayment;


        public frmAddUpdateContractPaymentScheduling(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            _Mode = enMode.Update;
        }
        public frmAddUpdateContractPaymentScheduling()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        private void _generateChildrenForTheBasicPremiums(byte NumberOfChildrenPerPremium)
        {
            if (ctrlContractDetailsWithFilter1 == null || _listContractObligationForPartialPaymentsBase == null)
                return;
            _listContractObligationForPartialPaymentsChildren = new List<clsContractPaymentSchedule>();
            DateTime StartDate = ctrlContractDetailsWithFilter1.SelectedContract.StartContract;
            byte Number = 0;
            for (byte i = 0; i < _listContractObligationForPartialPaymentsBase.Count; i++)
            {
                for (byte j = 1; j < NumberOfChildrenPerPremium; j++)
                {
                    StartDate = StartDate.AddMonths(1);
                    if (Number < _listContractObligationForPartialPaymentsBase.Count)
                        if (StartDate == _listContractObligationForPartialPaymentsBase[Number].DueDate)
                        {
                            StartDate = StartDate.AddMonths(1);
                            Number++;
                        }
                    clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();
                    contractObligation.TypeObligation = _listContractObligationForPartialPaymentsBase[0].TypeObligation;
                    contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Facilitator;
                    contractObligation.DeservedAmount = Math.Round((_listContractObligationForPartialPaymentsBase[i].DeservedAmount / NumberOfChildrenPerPremium), 3);
                    contractObligation.RemainingAmount = contractObligation.DeservedAmount;
                    contractObligation.DueDate = StartDate;
                    contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
                    _listContractObligationForPartialPaymentsChildren.Add(contractObligation);

                }

            }
        }
        private void _generateOnePaymentLater()
        {
            _listContractObligationForPartialPaymentsBase = new List<clsContractPaymentSchedule>();
            if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType == (byte)clsContract.enPaymentType.OnePaymentLater)
            {
                clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();

                contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
                contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.OnePaymentLater;
                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
                contractObligation.DeservedAmount = ctrlContractDetailsWithFilter1.AmountOfEachPayment;
                contractObligation.RemainingAmount = contractObligation.DeservedAmount;
                contractObligation.DueDate = ctrlContractDetailsWithFilter1.SelectedContract.DeferredPaymentDueDate ?? DateTime.Now;
                contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
                _listContractObligationForPartialPaymentsBase.Add(contractObligation);
            }
        }
        private void _generateFullPayment()
        {
            if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType == (byte)clsContract.enPaymentType.Full)
            {
                clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();

                contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
                contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.FullPayment;
                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
                contractObligation.DeservedAmount = ctrlContractDetailsWithFilter1.SelectedContract.ContractAmount;
                contractObligation.RemainingAmount = ctrlContractDetailsWithFilter1.SelectedContract.ContractAmount;
                contractObligation.DueDate = ctrlContractDetailsWithFilter1.SelectedContract.StartContract;
                contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
                _ContractObligationForFullPayment = contractObligation;
            }
        }
        private void _GenerateDataColumnsForNewContractObligations()
        {
            _dtContractObligations = new DataTable();
            _dtContractObligations.Columns.Add("ContractID", typeof(int));
            _dtContractObligations.Columns.Add("TypeObligation", typeof(int));
            _dtContractObligations.Columns.Add("TypeObligationStr", typeof(string));
            _dtContractObligations.Columns.Add("SchedulingMethod", typeof(int));
            _dtContractObligations.Columns.Add("SchedulingMethodStr", typeof(string));
            _dtContractObligations.Columns.Add("DeservedAmount", typeof(double));
            _dtContractObligations.Columns.Add("AmountPaid", typeof(double));
            _dtContractObligations.Columns.Add("RemainingAmount", typeof(double));
            _dtContractObligations.Columns.Add("DueDate", typeof(string));
            _dtContractObligations.Columns.Add("PaymentDate", typeof(string));
            _dtContractObligations.Columns.Add("PaymentStatus", typeof(int));
            _dtContractObligations.Columns.Add("PaymentStatusStr", typeof(string));

        }
        private void _ColumnsDesignForNewContractObligations()
        {
            _GenerateDataColumnsForNewContractObligations();
            dgvNewContractObligations.DataSource = _dtContractObligations;
            if (_dtContractObligations.Columns.Count > 0)
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

        }
        private void _LoadOldSchedulingInDataGridView()
        {
            _dtOldContractObligations = clsContractPaymentSchedule.GetAllContractPaymentSchedules(_ApplicationID);
            foreach (DataRow row in _dtOldContractObligations.Rows)
            {
                dgvOldContractObligations.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
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
        private void _LoadNewSchedulingInDataGridView()
        {
            _dtContractObligations.Rows.Clear();
            dgvNewContractObligations.DataSource = _dtContractObligations;
            _ColumnsDesignForNewContractObligations();
            short RowIndex = 0;
            if (_ContractObligationForInitialPayment != null)
            {

                _WriteIn_dtContractObligations(_ContractObligationForInitialPayment);
                RowIndex = (short)dgvNewContractObligations.RowCount;
                _ForAndBackColorRecordDataGridView(ref dgvNewContractObligations, --RowIndex, Color.White, Color.DimGray);

            }
            if (_listContractObligationForPartialPaymentsBase != null)
                _WriteBaseAndChildrenInDataGridView();
            if (_listContractObligationForFinalPayment != null)
            {
                for (short i = 0; i < _listContractObligationForFinalPayment.Count; i++)
                {
                    _WriteIn_dtContractObligations(_listContractObligationForFinalPayment[i]);
                    if (_listContractObligationForFinalPayment[i].SchedulingMethod == (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic)
                    {
                        RowIndex = (short)dgvNewContractObligations.RowCount;
                        _ForAndBackColorRecordDataGridView(ref dgvNewContractObligations, --RowIndex, Color.White, Color.DimGray);
                    }
                }
            }
            if (_ContractObligationForFullPayment != null)
            {
                _WriteIn_dtContractObligations(_ContractObligationForFullPayment);
                RowIndex = (short)dgvNewContractObligations.RowCount;
                _ForAndBackColorRecordDataGridView(ref dgvNewContractObligations, --RowIndex, Color.White, Color.DimGray);
            }
            if (_ContractObligationForOnePaymentLater != null)
            {
                _WriteIn_dtContractObligations(_ContractObligationForOnePaymentLater);
                RowIndex = (short)dgvNewContractObligations.RowCount;
                _ForAndBackColorRecordDataGridView(ref dgvNewContractObligations, --RowIndex, Color.White, Color.DimGray);
            }
            lblRecordsCountNewContractObligations.Text = _dtContractObligations.Rows.Count.ToString();
        }
        private void _ForAndBackColorRecordDataGridView(ref Guna2DataGridView dgv, short RowIndex, Color ForColor, Color BachColor)
        {
            dgv.Rows[RowIndex].DefaultCellStyle.BackColor = BachColor;
            dgv.Rows[RowIndex].DefaultCellStyle.ForeColor = ForColor;
        }
        private void _WriteIn_dtContractObligations(clsContractPaymentSchedule contractObligation)
        {
            if (contractObligation == null)
                return;
            _dtContractObligations.Rows.Add(0, contractObligation.TypeObligation, contractObligation.GetTypeObligation
            , contractObligation.SchedulingMethod, contractObligation.GetSchedulingMethod, contractObligation.DeservedAmount,
            contractObligation.AmountPaid, contractObligation.RemainingAmount,
            contractObligation.DueDate.ToString("d"), contractObligation.PaymentDate?.ToString("d"), contractObligation.PaymentStatus,
            contractObligation.GetPaymentStatus);
        }
        private void _WriteBaseAndChildrenInDataGridView()
        {
            if (_listContractObligationForPartialPaymentsBase == null && _listContractObligationForPartialPaymentsChildren == null) return;
            byte Number = 0;
            short RowIndex = 0;
            if (_listContractObligationForPartialPaymentsChildren != null)
                for (byte i = 0; i < _listContractObligationForPartialPaymentsChildren.Count; i++)
                {
                    if (Number < _listContractObligationForPartialPaymentsBase.Count)
                        if (_listContractObligationForPartialPaymentsChildren[i].DueDate > _listContractObligationForPartialPaymentsBase[Number].DueDate)
                        {
                            _WriteIn_dtContractObligations(_listContractObligationForPartialPaymentsBase[Number]);
                            RowIndex = ((short)dgvNewContractObligations.RowCount);
                            _ForAndBackColorRecordDataGridView(ref dgvNewContractObligations, --RowIndex, Color.White, Color.DimGray);
                            Number++;
                        }
                    _WriteIn_dtContractObligations(_listContractObligationForPartialPaymentsChildren[i]);
                    RowIndex = ((short)dgvNewContractObligations.RowCount);
                    _ForAndBackColorRecordDataGridView(ref dgvNewContractObligations, --RowIndex, Color.Black, Color.White);
                }

            for (; Number < _listContractObligationForPartialPaymentsBase.Count; Number++)
            {
                _WriteIn_dtContractObligations(_listContractObligationForPartialPaymentsBase[Number]);
                RowIndex = ((short)dgvNewContractObligations.RowCount);
                _ForAndBackColorRecordDataGridView(ref dgvNewContractObligations, --RowIndex, Color.White, Color.DimGray);
            }
        }
        private void _GenerateInitialPaymentObligation()
        {
            if (_TypePayment == enTypePayment.Full || _Application.IsInitialPaymentPaid)
                return;
            if (ctrlContractDetailsWithFilter1.SelectedContract.InitialPayment > 0)
            {
                clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();

                contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
                contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.InitialPayment;
                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
                contractObligation.DeservedAmount = ctrlContractDetailsWithFilter1.SelectedContract.InitialPayment;
                contractObligation.RemainingAmount = ctrlContractDetailsWithFilter1.SelectedContract.InitialPayment;
                contractObligation.DueDate = ctrlContractDetailsWithFilter1.SelectedContract.StartContract;
                contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
                _ContractObligationForInitialPayment = contractObligation;
            }
        }
        private void _GeneratePartialPaymentsObligationForBasic()
        {
            if (_TypePayment == enTypePayment.Full)
                return;
            _listContractObligationForPartialPaymentsBase = new List<clsContractPaymentSchedule>();
            DateTime TempStartDate = ctrlContractDetailsWithFilter1.SelectedContract.StartContract;
            DateTime TempEndDate = ctrlContractDetailsWithFilter1.SelectedContract.EndContract;
            while (TempEndDate > TempStartDate)
            {
                clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();
                if (rbIsMonthly.Checked)
                {
                    TempStartDate = TempStartDate.AddMonths(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths);
                    contractObligation.DeservedAmount = Math.Round(ctrlContractDetailsWithFilter1.AmountOfEachPayment, 3);
                }
                else

                {
                    TempStartDate = TempStartDate.AddYears(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears);
                    contractObligation.DeservedAmount = Math.Round(ctrlContractDetailsWithFilter1.AmountOfEachPayment, 3);
                }
                contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
                contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.PartialPayments;
                contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
                contractObligation.RemainingAmount = contractObligation.DeservedAmount;
                contractObligation.DueDate = TempStartDate;
                _listContractObligationForPartialPaymentsBase.Add(contractObligation);
            }
        }
        //private void _GeneratePartialPaymentsObligationForBasic3()
        //{
        //    if (_TypePayment == enTypePayment.Full)
        //        return;
        //    _listContractObligationForPartialPayments = new List<clsContractPaymentSchedule>();
        //    DateTime TempStartDate = ctrlContractDetailsWithFilter1.SelectedContract.StartContract;
        //    DateTime TempEndDate = ctrlContractDetailsWithFilter1.SelectedContract.EndContract;
        //    while (TempEndDate > TempStartDate)
        //    {
        //        clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();
        //        if (rbIsMonthly.Checked)
        //        {
        //            TempStartDate = TempStartDate.AddMonths(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths);
        //            contractObligation.DeservedAmount = Math.Round((ctrlContractDetailsWithFilter1.DeservedAmount / ctrlContractDetailsWithFilter1.NumberOfMonthsForContract) * ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths, 3);
        //        }
        //        else

        //        {
        //            TempStartDate = TempStartDate.AddYears(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears);
        //            contractObligation.DeservedAmount = Math.Round(ctrlContractDetailsWithFilter1.DeservedAmount / 12, 3);
        //        }
        //        contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
        //        contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.PartialPayments;
        //        contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
        //        contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
        //        contractObligation.DueDate = TempStartDate;
        //        _listContractObligationForPartialPayments.Add(contractObligation);
        //    }
        //}
        //private void _GeneratePartialPaymentsObligationForFacilitator9999()
        //{
        //    if (_TypePayment == enTypePayment.Full)
        //        return;
        //    _listContractObligationForPartialPayments = new List<clsContractPaymentSchedule>();
        //    DateTime TempStartDate = ctrlContractDetailsWithFilter1.SelectedContract.StartContract;
        //    DateTime TempEndDate = ctrlContractDetailsWithFilter1.SelectedContract.EndContract;
        //    DateTime PaymentBasic;
        //    PaymentBasic = ctrlContractDetailsWithFilter1.SelectedContract.StartContract.AddMonths(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths);
        //    PaymentBasic = PaymentBasic.AddYears(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears);


        //    while (TempEndDate > TempStartDate)
        //    {
        //        clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();
        //        contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
        //        contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.PartialPayments;
        //        contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
        //        TempStartDate = TempStartDate.AddMonths(1);
        //        if (rbIsMonthly.Checked)
        //        {
        //            if (PaymentBasic.Month == TempStartDate.Month)
        //            {
        //                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
        //                contractObligation.DeservedAmount = Math.Round((ctrlContractDetailsWithFilter1.DeservedAmount / ctrlContractDetailsWithFilter1.NumberOfMonthsForContract) * ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths, 3);
        //                contractObligation.RemainingAmount = contractObligation.DeservedAmount;
        //                contractObligation.DueDate = TempStartDate;
        //                _listContractObligationForPartialPayments.Add(contractObligation);
        //                PaymentBasic = PaymentBasic.AddMonths(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths);
        //            }
        //            else
        //            {
        //                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Facilitator;
        //                contractObligation.DeservedAmount = Math.Round(ctrlContractDetailsWithFilter1.DeservedAmount / ctrlContractDetailsWithFilter1.NumberOfMonthsForContract, 3);
        //                contractObligation.RemainingAmount = contractObligation.DeservedAmount;
        //                contractObligation.DueDate = TempStartDate;
        //                _listContractObligationForPartialPayments.Add(contractObligation);
        //            }
        //        }
        //        else
        //        {
        //            if (PaymentBasic == TempStartDate)
        //            {
        //                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
        //                contractObligation.DeservedAmount = Math.Round(ctrlContractDetailsWithFilter1.DeservedAmount / ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears, 3);
        //                contractObligation.RemainingAmount = contractObligation.DeservedAmount;
        //                contractObligation.DueDate = TempStartDate;
        //                _listContractObligationForPartialPayments.Add(contractObligation);
        //                PaymentBasic = PaymentBasic.AddYears(ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears);
        //            }
        //            else
        //            {
        //                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Facilitator;
        //                contractObligation.DeservedAmount = Math.Round(ctrlContractDetailsWithFilter1.DeservedAmount / ctrlContractDetailsWithFilter1.NumberOfMonthsForContract, 3);
        //                contractObligation.RemainingAmount = ctrlContractDetailsWithFilter1.DeservedAmount * contractObligation.DeservedAmount;
        //                contractObligation.DueDate = TempStartDate;
        //                _listContractObligationForPartialPayments.Add(contractObligation);
        //            }
        //        }

        //    }
        //}
        //private void _GeneratePartialPaymentsObligationForCustomFacilitator99999()
        //{
        //    if (_TypePayment == enTypePayment.Full)
        //        return;
        //    _listContractObligationForPartialPayments = new List<clsContractPaymentSchedule>();
        //    DateTime TempStartDate = ctrlContractDetailsWithFilter1.SelectedContract.StartContract;
        //    for (byte i = 0; i < nudNumberOfMonthspayContract.Value; i++)
        //    {
        //        TempStartDate = TempStartDate.AddMonths(1);
        //        clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();
        //        contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
        //        contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.PartialPayments;
        //        contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
        //        contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Facilitator;
        //        contractObligation.DeservedAmount = Math.Round(ctrlContractDetailsWithFilter1.DeservedAmount / (byte)nudNumberOfMonthspayContract.Value, 3);
        //        contractObligation.RemainingAmount = contractObligation.DeservedAmount;
        //        contractObligation.DueDate = TempStartDate;
        //        _listContractObligationForPartialPayments.Add(contractObligation);

        //    }
        //}
        private void _GenerateFinalPartialPaymentObligation()
        {
            if (_TypePayment == enTypePayment.Full || ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment == 0 || _Application.IsFinalPaymentPaid)
                return;
            clsContractPaymentSchedule contractObligation = new clsContractPaymentSchedule();
            contractObligation.ApplicationID = ctrlContractDetailsWithFilter1.SelectedContract.ContractID;
            contractObligation.TypeObligation = (byte)clsContractPaymentSchedule.enTypeObligation.FinalPayment;
            contractObligation.PaymentStatus = (byte)clsContractPaymentSchedule.enPaymentStatus.Nothing;
            _listContractObligationForFinalPayment = new List<clsContractPaymentSchedule>();
            if (!cbFinalPaymentInstallment.Checked)
            {
                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
                contractObligation.DeservedAmount = ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment;
                contractObligation.RemainingAmount = ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment;
                contractObligation.DueDate = ctrlContractDetailsWithFilter1.SelectedContract.EndContract;
                _listContractObligationForFinalPayment.Add(contractObligation);
                return;
            }
            byte NumberOfMonths = ctrlContractDetailsWithFilter1.SelectedContract.NumberOfMonthsOfFinalPaymentInstallments;
            DateTime TempStartDate = ctrlContractDetailsWithFilter1.SelectedContract.EndContract;
            DateTime TempEndDate = TempStartDate.AddMonths(NumberOfMonths);
            double DeservedAmountForEveryMonth = ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment / NumberOfMonths;
            while (TempEndDate > TempStartDate)
            {
                TempStartDate = TempStartDate.AddMonths(1);
                contractObligation.SchedulingMethod = (byte)clsContractPaymentSchedule.enSchedulingMethod.Basic;
                contractObligation.DeservedAmount = DeservedAmountForEveryMonth;
                contractObligation.RemainingAmount = DeservedAmountForEveryMonth;
                contractObligation.DueDate = TempStartDate;
                _listContractObligationForFinalPayment.Add(contractObligation);
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
            if (_ContractObligationForInitialPayment != null)
            {
                _ContractObligationForInitialPayment.IsActive = true;
                _ContractObligationForInitialPayment.ApplicationID = _Application.ApplicationID;
                _ContractObligationForInitialPayment.Save();
            }
            byte Num = 0;
            for (byte i = 0; i < _listContractObligationForPartialPaymentsBase.Count; i++)
            {
                _listContractObligationForPartialPaymentsBase[i].IsActive = true;
                _listContractObligationForPartialPaymentsBase[i].ApplicationID=_Application.ApplicationID;
                if (!_listContractObligationForPartialPaymentsBase[i].Save())
                {
                    MessageBox.Show("Failed to save installment schedule", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(_listContractObligationForPartialPaymentsChildren!=null)
                for (byte j = 1; j < nudNumberOfMonthspayContract.Value; j++)
                {
                    _listContractObligationForPartialPaymentsChildren[Num].IsActive = true;
                    _listContractObligationForPartialPaymentsChildren[Num].ApplicationID = _Application.ApplicationID;
                    _listContractObligationForPartialPaymentsChildren[Num].PartOfObligationID = _listContractObligationForPartialPaymentsBase[i].ObligationID;
                    _listContractObligationForPartialPaymentsChildren[Num].Save();
                        Num++;
                }
            }
            if (_listContractObligationForFinalPayment != null)
            {
                for (byte i = 0; i < _listContractObligationForFinalPayment.Count; i++)
                {
                    _listContractObligationForFinalPayment[i].IsActive = true;
                    _listContractObligationForFinalPayment[i].ApplicationID = _Application.ApplicationID;
                    _listContractObligationForFinalPayment[i].Save();
                }

            }
        }
        private void _ContractDataProcessing()
        {
            if (ctrlContractDetailsWithFilter1.SelectedContract != null)
            {
                rbIsMonthly.Checked = (ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths > ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears);
                if (rbIsMonthly.Checked)
                    nudNumberOfMonthspayContract.Maximum = (ctrlContractDetailsWithFilter1.NumberOfMonthsForContract / (ctrlContractDetailsWithFilter1.NumberOfMonthsForContract / ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths));
                else if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType == (byte)clsContract.enPaymentType.OnePaymentLater)

                    nudNumberOfMonthspayContract.Maximum = (byte)((ctrlContractDetailsWithFilter1.SelectedContract.DeferredPaymentDueDate.Value.Month - ctrlContractDetailsWithFilter1.SelectedContract.StartContract.Month) + ((ctrlContractDetailsWithFilter1.SelectedContract.DeferredPaymentDueDate.Value.Year - ctrlContractDetailsWithFilter1.SelectedContract.StartContract.Year) * 12));
                else
                    nudNumberOfMonthspayContract.Maximum = 12;

                ctrlContractDetailsWithFilter1.AmountOfEachPayment = ctrlContractDetailsWithFilter1.SelectedContract.ContractAmount -
                   (ctrlContractDetailsWithFilter1.SelectedContract.InitialPayment + ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment) -
                   ctrlContractDetailsWithFilter1.SelectedContract.TotalAmountPaid;
                if (_Application.IsInitialPaymentPaid)
                    ctrlContractDetailsWithFilter1.AmountOfEachPayment += ctrlContractDetailsWithFilter1.SelectedContract.InitialPayment;
                if (_Application.IsFinalPaymentPaid)
                    ctrlContractDetailsWithFilter1.AmountOfEachPayment += ctrlContractDetailsWithFilter1.SelectedContract.FinalPayment;
                if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths + ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears > 0)
                    ctrlContractDetailsWithFilter1.AmountOfEachPayment = (ctrlContractDetailsWithFilter1.AmountOfEachPayment / (ctrlContractDetailsWithFilter1.NumberOfMonthsForContract / (ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryMonths + ctrlContractDetailsWithFilter1.SelectedContract.PaymentEveryYears)));
                if (nudNumberOfMonthspayContract.Enabled)
                {
                    nudNumberOfMonthspayContract.Value = nudNumberOfMonthspayContract.Maximum;
                    txtAmountDueEachMonth.Text = (ctrlContractDetailsWithFilter1.AmountOfEachPayment / ctrlContractDetailsWithFilter1.NumberOfMonthsForContract).ToString("0.000");
                    nudNumberOfMonthspayContract.Minimum = 2;
                }
            }
        }
        private void _ResetDefaultValues()
        {
            nudNumberOfMonthspayContract.Minimum = 0;
            nudNumberOfMonthspayContract.Value = 0;
            txtAmountDueEachMonth.Text = "0";

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
                if(_Application.Status==(byte)clsContractPaymentSchedulingApplication.enStatus.Canceled|| _Application.Status == (byte)clsContractPaymentSchedulingApplication.enStatus.Completed) 
                {
                    gbObligation.Enabled=false;
                    btnSave.Enabled=false;
                    MessageBox.Show("This app has been canceled or completed","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _ContractDataProcessing();
                if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType == (byte)clsContract.enPaymentType.Full)
                {
                    _TypePayment = enTypePayment.Full;
                    gbObligation.Enabled = false;
                }
                else
                {
                    cmbSchedulingMethod.SelectedIndex = 0;
                    gbObligation.Enabled = true;
                }
                cbFinalPaymentInstallment.Enabled = ctrlContractDetailsWithFilter1.SelectedContract.AllowingFinalPaymentInstallments;
                cbFinalPaymentInstallment.Checked = ctrlContractDetailsWithFilter1.SelectedContract.AllowingFinalPaymentInstallments;
                if (_TypePayment == enTypePayment.Full)
                {
                    _generateFullPayment();
                    _generateOnePaymentLater();
                    _LoadNewSchedulingInDataGridView();
                }
                if (_TypePayment == enTypePayment.Partial)
                {
                    _GenerateInitialPaymentObligation();
                    if (!ctrlContractDetailsWithFilter1.SelectedContract.AllowingFinalPaymentInstallments)
                    {
                        _GenerateFinalPartialPaymentObligation();
                        _LoadNewSchedulingInDataGridView();
                    }
                }
            }
        }
        private void frmContractObligation_Load(object sender, EventArgs e)
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
                    txtPaymentBase.Text = ctrlContractDetailsWithFilter1.AmountOfEachPayment.ToString();
                    nudNumberOfMonthspayContractEnabled(false);
                    if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType == (byte)clsContract.enPaymentType.OnePaymentLater)
                        _generateOnePaymentLater();
                    else
                        _GeneratePartialPaymentsObligationForBasic();
                    _LoadNewSchedulingInDataGridView();
                    break;
                case "Facilitator":
                    nudNumberOfMonthspayContractEnabled(true);
                    _generateChildrenForTheBasicPremiums((byte)nudNumberOfMonthspayContract.Value);
                    _LoadNewSchedulingInDataGridView();
                    break;
            }
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
            _GenerateFinalPartialPaymentObligation();
            _LoadNewSchedulingInDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgv.DataSource = _dtContractObligations;
            if (dgvNewContractObligations.Rows.Count > 0)
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
                if (_Mode == enMode.Update)
                    if (MessageBox.Show("Do you really want to reschedule?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;
                if (_Application.Save())
                {
                    _SaveNewScheduling();
                    _ApplicationID = _Application.ApplicationID;
                    _Mode = enMode.Update;
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmContractObligation_Load(null, null);
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ctrlContractDetailsWithFilter1_OnContractSelected(bool obj)
        {
            _dtContractObligations.Rows.Clear();
            if (obj)
            {
                if (clsContractPaymentSchedulingApplication.isContractPaymentSchedulingApplicationExistByContractID(ctrlContractDetailsWithFilter1.SelectedContract.ContractID))
                {
                    _Mode = enMode.Update;
                    _ApplicationID = clsContractPaymentSchedulingApplication.FindByContractID(ctrlContractDetailsWithFilter1.SelectedContract.ContractID).ApplicationID;
                    _LoadData();
                    return;
                }
                _ContractDataProcessing();
                if (ctrlContractDetailsWithFilter1.SelectedContract.PaymentType == (byte)clsContract.enPaymentType.Full ||
                    ctrlContractDetailsWithFilter1.SelectedContract.PaymentType == (byte)clsContract.enPaymentType.OnePaymentLater)
                {
                    _TypePayment = enTypePayment.Full;
                    _generateFullPayment();
                    _generateOnePaymentLater();
                    _LoadNewSchedulingInDataGridView();
                    return;
                }
                gbObligation.Enabled = obj;
                _GenerateInitialPaymentObligation();
                _GenerateFinalPartialPaymentObligation();
                cmbSchedulingMethod.SelectedIndex = 0;
                _GenerateFinalPartialPaymentObligation();
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
            txtAmountDueEachMonth.Text = (ctrlContractDetailsWithFilter1.AmountOfEachPayment / (byte)nudNumberOfMonthspayContract.Value).ToString("0.00");
            _generateChildrenForTheBasicPremiums((byte)nudNumberOfMonthspayContract.Value);

            _LoadNewSchedulingInDataGridView();
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
                txtAmountDueEachMonth.Text = "";
                _listContractObligationForPartialPaymentsChildren = new List<clsContractPaymentSchedule>();
            }
            txtPaymentBase.Enabled = nudNumberOfMonthspayContract.Enabled;
        }
    }
}