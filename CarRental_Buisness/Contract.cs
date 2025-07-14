using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsContract
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enPaymentStatus { Partial = 1, Full = 2, Nothing = 3 }
        public enum enPaymentType { Partial = 1,Full = 2,OnePaymentLater = 3}
        private int _ContractID;
        public int ContractID { get { return _ContractID; } }
        public int BranchID { get; set; }
        public DateTime StartContract { get; set; }
        public DateTime EndContract { get; set; }
        public int TypeID { get; set; }
        public double ContractAmount { get; set; }
        public double InitialPayment { get; set; }
        public double FinalPayment { get; set; }
        public Byte PaymentType { get; set; }
        public double InitialAmountPaid {  get; set; }
        public double FinalAmountPaid { get; set; }

        public string GetPaymentType
        {
            get
            {
                if (PaymentType == (byte)enPaymentType.Partial)
                    return "Partial";
                if (PaymentType == (byte)enPaymentType.OnePaymentLater)
                    return "One Payment Later";
                if (PaymentType == (byte)enPaymentType.Full)
                    return "Full";
                return "";
            }
        }
        public Byte PaymentEveryYears { get; set; }
        public Byte PaymentEveryMonths { get; set; }
        public double TotalAmountPaid { get; set; }
        public double TotalRemainingAmount { get; set; }
        public DateTime? DeferredPaymentDueDate { set; get; }
        public Boolean AllowingFinalPaymentInstallments { get; set; }
        public Byte NumberOfMonthsOfFinalPaymentInstallments { get; set; }
        public Byte PaymentStatus { get; set; }
        public string GetPaymentStatus
        {
            get 
            {
                if (PaymentStatus == (Byte)enPaymentStatus.Partial)
                    return "Partial";
                if (PaymentStatus == (Byte)enPaymentStatus.Full)
                    return "Full";
                if (PaymentStatus == (Byte)enPaymentStatus.Nothing)
                    return "Nothing";
                return "";
            }
        }
        public int CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { set; get; }
        private clsContract(int ContractID, int BranchID, DateTime StartContract, DateTime EndContract, int TypeID, double ContractAmount, 
            double InitialPayment, double FinalPayment, Byte PaymentType, Byte PaymentEveryYears, Byte PaymentEveryMonths,
            double TotalAmountPaid, double TotalRemainingAmount,DateTime? DeferredPaymentDueDate, Boolean AllowingFinalPaymentInstallments,
            Byte NumberOfMonthsOfFinalPaymentInstallments, Byte PaymentStatus, int CreatedByUserID, int? UpdatedByUserID, DateTime CreatedDate, DateTime? UpdatedDate,bool IsActive,double InitialAmountPaid,double FinalAmountPaid)
        {
            _ContractID = ContractID;

            this.BranchID = BranchID;
            this.StartContract = StartContract;
            this.EndContract = EndContract;
            this.TypeID = TypeID;
            this.ContractAmount = ContractAmount;
            this.InitialPayment = InitialPayment;
            this.FinalPayment = FinalPayment;
            this.PaymentType = PaymentType;
            this.PaymentEveryYears = PaymentEveryYears;
            this.PaymentEveryMonths = PaymentEveryMonths;
            this.TotalAmountPaid = TotalAmountPaid;
            this.TotalRemainingAmount = TotalRemainingAmount;
            this.AllowingFinalPaymentInstallments = AllowingFinalPaymentInstallments;
            this.NumberOfMonthsOfFinalPaymentInstallments = NumberOfMonthsOfFinalPaymentInstallments;
            this.PaymentStatus = PaymentStatus;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            this.CreatedDate = CreatedDate;
            this.UpdatedDate = UpdatedDate;
            this.DeferredPaymentDueDate = DeferredPaymentDueDate;
            this.IsActive = IsActive;
            this.InitialAmountPaid = InitialAmountPaid;
            this.FinalAmountPaid = FinalAmountPaid;
            Mode = enMode.Update;
        }
        public clsContract()

        {
            _ContractID = -0;

            this.BranchID = 0;
            this.StartContract = DateTime.Now;
            this.EndContract = DateTime.Now;
            this.TypeID = 0;
            this.ContractAmount = 0;
            this.InitialPayment = 0;
            this.FinalPayment = 0;
            this.PaymentType = 0;
            this.PaymentEveryYears = 0;
            this.PaymentEveryMonths = 0;
            this.TotalAmountPaid = 0;
            this.TotalRemainingAmount = 0;
            this.AllowingFinalPaymentInstallments = false;
            this.NumberOfMonthsOfFinalPaymentInstallments = 0;
            this.PaymentStatus = 3;
            this.CreatedByUserID = 0;
            this.UpdatedByUserID = null;
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = null;
            this.DeferredPaymentDueDate = null;
            this.IsActive = true;
            this.InitialPayment = 0;
            this.FinalPayment = 0;
            Mode = enMode.AddNew;

        }
        private bool _AddNewContract()
        {
            this._ContractID = clsContractData.AddNewContract(BranchID, StartContract, EndContract, TypeID, ContractAmount, InitialPayment, FinalPayment, PaymentType, PaymentEveryYears, PaymentEveryMonths, TotalAmountPaid, TotalRemainingAmount, DeferredPaymentDueDate, AllowingFinalPaymentInstallments,
                NumberOfMonthsOfFinalPaymentInstallments, PaymentStatus, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate,InitialAmountPaid,FinalAmountPaid);
            return _ContractID != 0;
        }
        private bool _UpdateContract()
        {
            return clsContractData.UpdateContract(this._ContractID, BranchID, StartContract, EndContract, TypeID, ContractAmount, InitialPayment,
                FinalPayment, PaymentType, PaymentEveryYears, PaymentEveryMonths, TotalAmountPaid, TotalRemainingAmount, DeferredPaymentDueDate,
                AllowingFinalPaymentInstallments, NumberOfMonthsOfFinalPaymentInstallments, PaymentStatus, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate, IsActive, InitialAmountPaid, FinalAmountPaid);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContract())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateContract())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }
        public static clsContract Find(int ContractID)
        {


            int BranchID = 0;
            DateTime StartContract = DateTime.Now;
            DateTime EndContract = DateTime.Now;
            int TypeID = 0;
            double ContractAmount = 0;
            double InitialPayment = 0;
            double FinalPayment = 0;
            Byte PaymentType = 0;
            Byte PaymentEveryYears = 0;
            Byte PaymentEveryMonths = 0;
            double TotalAmountPaid = 0;
            double TotalRemainingAmount = 0;
            Boolean AllowingFinalPaymentInstallments = false;
            Byte NumberOfMonthsOfFinalPaymentInstallments = 0;
            Byte PaymentStatus = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime CreatedDate = DateTime.Now;
            DateTime? UpdatedDate = null;
            DateTime? DeferredPaymentDueDate=null;
            double InitialAmountPaid = 0;
            double FinalAmountPaid = 0;
            bool IsActive = false;
            if (clsContractData.GetContractInfoByID(ContractID, ref BranchID, ref StartContract, ref EndContract, ref TypeID, ref ContractAmount, ref InitialPayment, ref FinalPayment, ref PaymentType, ref PaymentEveryYears, ref PaymentEveryMonths, ref TotalAmountPaid, ref TotalRemainingAmount,ref DeferredPaymentDueDate, ref AllowingFinalPaymentInstallments, 
                ref NumberOfMonthsOfFinalPaymentInstallments, ref PaymentStatus, ref CreatedByUserID, 
                ref UpdatedByUserID, ref CreatedDate, ref UpdatedDate,ref IsActive,ref InitialAmountPaid,ref FinalAmountPaid))

                return new clsContract(ContractID, BranchID, StartContract, EndContract, TypeID, ContractAmount, InitialPayment,
                    FinalPayment, PaymentType, PaymentEveryYears, PaymentEveryMonths, TotalAmountPaid, TotalRemainingAmount, 
                    DeferredPaymentDueDate, AllowingFinalPaymentInstallments, NumberOfMonthsOfFinalPaymentInstallments, PaymentStatus, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate, IsActive,InitialAmountPaid,FinalAmountPaid);
            else
                return null;
        }
        public static clsContract Find(int ContractID,int BranchID)
        {


            DateTime StartContract = DateTime.Now;
            DateTime EndContract = DateTime.Now;
            int TypeID = 0;
            double ContractAmount = 0;
            double InitialPayment = 0;
            double FinalPayment = 0;
            Byte PaymentType = 0;
            Byte PaymentEveryYears = 0;
            Byte PaymentEveryMonths = 0;
            double TotalAmountPaid = 0;
            double TotalRemainingAmount = 0;
            Boolean AllowingFinalPaymentInstallments = false;
            Byte NumberOfMonthsOfFinalPaymentInstallments = 0;
            Byte PaymentStatus = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime CreatedDate = DateTime.Now;
            DateTime? UpdatedDate = null;
            DateTime? DeferredPaymentDueDate = null;
            bool IsActive = false;
            double InitialAmountPaid = 0;
            double FinalAmountPaid = 0;
            if (clsContractData.GetContractInfoByID(ContractID,ref BranchID, ref StartContract, ref EndContract, 
                ref TypeID, ref ContractAmount, ref InitialPayment, ref FinalPayment,
                ref PaymentType, ref PaymentEveryYears, ref PaymentEveryMonths, ref TotalAmountPaid, 
                ref TotalRemainingAmount, ref DeferredPaymentDueDate, ref AllowingFinalPaymentInstallments, 
                ref NumberOfMonthsOfFinalPaymentInstallments, ref PaymentStatus, ref CreatedByUserID, ref UpdatedByUserID, ref CreatedDate, ref UpdatedDate,ref IsActive,ref InitialAmountPaid,ref FinalAmountPaid))

                return new clsContract(ContractID, BranchID, StartContract, EndContract, TypeID, ContractAmount, InitialPayment, FinalPayment, PaymentType, PaymentEveryYears,
                    PaymentEveryMonths, TotalAmountPaid, TotalRemainingAmount, DeferredPaymentDueDate, AllowingFinalPaymentInstallments, NumberOfMonthsOfFinalPaymentInstallments,
                    PaymentStatus, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate, IsActive,InitialAmountPaid,FinalAmountPaid);
            else
                return null;
        }
        public static bool isContractExist(int ContractID)
        {
            return clsContractData.IsContractExist(ContractID);
        }
        public static DataTable GetAllContracts()
        {
            return clsContractData.GetAllContracts();
        }
        public static DataTable GetAllContracts(int BranchID)
        {
            return clsContractData.GetAllContracts(BranchID);
        }
    }
}
