using CarRental.Classes;
using CarRental_Business;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ctrlContractCard : UserControl
    {
        private clsContract _Contract;
        public clsContract SelectedContract { get { return _Contract; } }
        public double AmountOfEachPayment { private set; get; }
        public byte NumberOfMonthsForContract { private set; get; }
        public byte NumberOfYearsForContract { private set; get; }
        public ctrlContractCard()
        {
            InitializeComponent();
        }
        public void ResetDefaultValues()
        {
            llContractID.Text = "";
            lblCreatedDate.Text = "";
            lblUpdatedDate.Text = "";

            lblContractAmount.Text = "";
            lblInitialPayment.Text = "";
            lblFinalPayment.Text = "";

            lblInhowmanymonths.Text = "";
            lblPaymentEveryMonths.Text = "";
            lblPaymentEveryYears.Text = "";

            cbAllowingFinalpaymentInstallments.Checked = false;
            lblType.Text = "";
            lblMethodOfPayment.Text = "";
            lblStartDate.Text = "";
            lblEndDate.Text = "";
            lblDeferredPaymentDueDate.Text = "";
            lblTotalRemainingAmount.Text = "";
            lblAmountPaid.Text = "";
            lblStatus.Text = "";
            _Contract = null;
            guna2TabControl1.Enabled = false;
            lblAmountOfEachPayment.Text = "";
            lblNumberOfMonths.Text = "";
            lblNumberOfYears.Text = "";
        }
        private void _ContractDataProcessing()
        {
            if (_Contract != null)
            {
                NumberOfMonthsForContract = (byte)((_Contract.EndContract.Month - _Contract.StartContract.Month) + (_Contract.EndContract.Year - _Contract.StartContract.Year) * 12);
                NumberOfYearsForContract = (byte)(_Contract.EndContract.Year - _Contract.StartContract.Year);
            }
        }
        public void LoadData(int ContractID)
        {
            ResetDefaultValues();
            if (clsGlobal.IsBranchInformationAvailable)
                _Contract = clsContract.Find(ContractID, clsGlobal.Branch.BranchID);
            else
                _Contract = clsContract.Find(ContractID);
            if (_Contract != null)
            {
                _ContractDataProcessing();
                guna2TabControl1.Enabled = true;
                llContractID.Text = _Contract.ContractID.ToString();
                lblCreatedDate.Text = _Contract.CreatedDate.ToString("d");
                if (_Contract.UpdatedDate != null)
                {
                    lblUpdatedDate.Text = _Contract.UpdatedDate?.ToString("d");
                }
                lblContractAmount.Text = _Contract.ContractAmount.ToString();
                lblInitialPayment.Text = _Contract.InitialPayment.ToString();
                lblFinalPayment.Text = _Contract.FinalPayment.ToString();

                lblInhowmanymonths.Text = _Contract.NumberOfMonthsOfFinalPaymentInstallments.ToString();
                lblPaymentEveryMonths.Text = _Contract.PaymentEveryMonths.ToString();
                lblPaymentEveryYears.Text = _Contract.PaymentEveryYears.ToString();

                cbAllowingFinalpaymentInstallments.Checked = _Contract.AllowingFinalPaymentInstallments;
                lblType.Text = clsTypesContract.Find(_Contract.TypeID).Type;
                if ((byte)clsContract.enPaymentType.Partial == _Contract.PaymentType)
                    lblMethodOfPayment.Text = "Partial";
                if ((byte)clsContract.enPaymentType.Full == _Contract.PaymentType)
                    lblMethodOfPayment.Text = "Full";
                if ((byte)clsContract.enPaymentType.OnePaymentLater == _Contract.PaymentType)
                    lblMethodOfPayment.Text = "One Payment Later";
                lblStartDate.Text = _Contract.StartContract.ToString("d");
                lblEndDate.Text = _Contract.EndContract.ToString("d");
                if (_Contract.DeferredPaymentDueDate != null)
                    lblDeferredPaymentDueDate.Text = _Contract.DeferredPaymentDueDate?.ToString("d");
                lblTotalRemainingAmount.Text = _Contract.TotalRemainingAmount.ToString();
                lblAmountPaid.Text = _Contract.TotalAmountPaid.ToString();

                if ((byte)clsContract.enPaymentStatus.Partial == _Contract.PaymentStatus)
                    lblStatus.Text = "Partial";
                if ((byte)clsContract.enPaymentStatus.Full == _Contract.PaymentStatus)
                    lblStatus.Text = "Full";
                if ((byte)clsContract.enPaymentStatus.Nothing == _Contract.PaymentStatus)
                    lblStatus.Text = "Nothing";
                if (!(_Contract.PaymentType == (byte)clsContract.enPaymentType.OnePaymentLater || _Contract.PaymentType == (byte)clsContract.enPaymentType.Full))
                    if (_Contract.PaymentEveryMonths > 0)
                        AmountOfEachPayment = ((_Contract.ContractAmount - (_Contract.InitialPayment + _Contract.FinalPayment)) / NumberOfMonthsForContract * _Contract.PaymentEveryMonths);
                    else
                        AmountOfEachPayment = _Contract.ContractAmount/NumberOfYearsForContract * _Contract.PaymentEveryYears;
                lblAmountOfEachPayment.Text = AmountOfEachPayment.ToString("0.00");
                lblNumberOfMonths.Text = NumberOfMonthsForContract.ToString();
                lblNumberOfYears.Text = NumberOfYearsForContract.ToString();
            }
            else
            {
                MessageBox.Show("Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbAllowingFinalpaymentInstallments_CheckedChanged(object sender, System.EventArgs e)
        {

        }
    }
}
