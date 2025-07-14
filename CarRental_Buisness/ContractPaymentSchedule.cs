using CarRental_DataAccess;
using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace CarRental_Business
{
    public class clsContractPaymentSchedule
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enTypeObligation { InitialPayment = 1, FinalPayment = 2, FullPayment = 3, PartialPayments = 4, OnePaymentLater = 5 }
        public enum enSchedulingMethod { Basic = 1, Facilitator = 2, }
        public enum enPaymentStatus { Nothing = 1, Partial = 2, Full = 3 }
        public enum enReasonInActive { Reschedule = 1, ContractCancelled = 2, Deleted = 3 }
        public string GetSchedulingMethod
        {
            get
            {
                if (SchedulingMethod == (byte)enSchedulingMethod.Facilitator)
                    return "Facilitator";
                if (SchedulingMethod == (byte)enSchedulingMethod.Basic)
                    return "Basic";
                return "";
            }
        }
        public string GetPaymentStatus
        {
            get
            {
                if (PaymentStatus == (byte)enPaymentStatus.Nothing)
                    return "Nothing";
                if (PaymentStatus == (byte)enPaymentStatus.Partial)
                    return "Partial";
                if (PaymentStatus == (byte)enPaymentStatus.Full)
                    return "Full";
                return "";
            }
        }
        public string GetTypeObligation
        {
            get
            {
                if (TypeObligation == (byte)enTypeObligation.FullPayment)
                    return "Full Payment";
                if (TypeObligation == (byte)enTypeObligation.OnePaymentLater)
                    return "One Payment Later";
                if (TypeObligation == (byte)enTypeObligation.InitialPayment)
                    return "Initial Payment";
                if (TypeObligation == (byte)enTypeObligation.FinalPayment)
                    return "Final Payment";
                if (TypeObligation == (byte)enTypeObligation.PartialPayments)
                    return "Partial Payments";
                return "";
            }
        }
        public string GetReasonInActive
        {
            get
            {
                if (ReasonInActive == (byte)enReasonInActive.Deleted)
                    return "Deleted";
                if (ReasonInActive == (byte)enReasonInActive.Reschedule)
                    return "Reschedule";
                if (ReasonInActive == (byte)enReasonInActive.ContractCancelled)
                    return "Contract Cancelled";
                return "";
            }
        }

        public int ObligationID { get; set; }
        public int ApplicationID { get; set; }
        public Byte TypeObligation { get; set; }
        public Byte SchedulingMethod { get; set; }
        public double DeservedAmount { get; set; }
        public double AmountPaid { get; set; }
        public double RemainingAmount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public Byte PaymentStatus { get; set; }
        public int? PaymentByUserID { get; set; }
        public int? AmountSpentID { set; get; }
        public bool IsActive { get; set; }
        public byte? ReasonInActive { set; get; }
        public int? PartOfObligationID { set; get; }
        private clsContractPaymentSchedule(int ObligationID, int ApplicationID, Byte TypeObligation, Byte SchedulingMethod, double DeservedAmount, double AmountPaid, double RemainingAmount, DateTime DueDate,
            DateTime? PaymentDate, Byte PaymentStatus, int? PaymentByUserID, int? AmountSpentID, bool IsActive, Byte? ReasonInActive, int? partOfObligationID)
        {

            this.ObligationID = ObligationID;

            this.ApplicationID = ApplicationID;
            this.TypeObligation = TypeObligation;
            this.SchedulingMethod = SchedulingMethod;
            this.DeservedAmount = DeservedAmount;
            this.AmountPaid = AmountPaid;
            this.RemainingAmount = RemainingAmount;
            this.DueDate = DueDate;
            this.PaymentDate = PaymentDate;
            this.PaymentStatus = PaymentStatus;
            this.PaymentByUserID = PaymentByUserID;
            this.IsActive = IsActive;
            this.ReasonInActive = ReasonInActive;
            this.AmountSpentID = AmountSpentID;
            Mode = enMode.Update;
            PartOfObligationID = partOfObligationID;
        }
        public clsContractPaymentSchedule()

        {
            this.ObligationID = -1;
            this.ApplicationID = 0;
            this.TypeObligation = 1;
            this.SchedulingMethod = 1;
            this.DeservedAmount = 0;
            this.AmountPaid = 0;
            this.RemainingAmount = 0;
            this.DueDate = DateTime.Now;
            this.PaymentDate = null;
            this.PaymentStatus = 1;
            this.PaymentByUserID = null;
            this.IsActive = true;
            this.ReasonInActive = null;
            this.AmountSpentID = null;
            this.PartOfObligationID = null;
            Mode = enMode.AddNew;

        }
        private bool _AddNewContractObligation()
        {
            this.ObligationID = clsContractPaymentScheduleData.AddNewContractObligation(ApplicationID, TypeObligation, SchedulingMethod, DeservedAmount, AmountPaid, RemainingAmount, DueDate, PaymentDate, PaymentStatus, PaymentByUserID, AmountSpentID, IsActive, ReasonInActive,PartOfObligationID);
            return ObligationID != 0;
        }
        private bool _UpdateContractObligation()
        {
            return clsContractPaymentScheduleData.UpdateContractObligation(this.ObligationID,
                ApplicationID, TypeObligation, SchedulingMethod, DeservedAmount, AmountPaid,
                RemainingAmount, DueDate, PaymentDate, PaymentStatus, PaymentByUserID, AmountSpentID, 
                IsActive, ReasonInActive, PartOfObligationID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContractObligation())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateContractObligation())
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
        public static bool ClearingOldInstallments(int ApplicationID)
        {
           return clsContractPaymentScheduleData.ClearingOldInstallments(ApplicationID);
        }
        public static clsContractPaymentSchedule Find(int ObligationID)
        {


            int ApplicationID = 0;
            Byte TypeObligation = 0;
            Byte SchedulingMethod = 0;
            double DeservedAmount = 0;
            double AmountPaid = 0;
            double RemainingAmount = 0;
            DateTime DueDate = DateTime.Now;
            DateTime? PaymentDate = DateTime.Now;
            Byte PaymentStatus = 0;
            int? PaymentByUserID = null;
            int? AmountSpentID = null;
            bool IsActive = false;
            byte? ReasonInActive = null;
            int? PartOfObligationID = null;

            if (clsContractPaymentScheduleData.GetContractObligationInfoByID(ObligationID, ref ApplicationID, ref TypeObligation,
                ref SchedulingMethod, ref DeservedAmount, ref AmountPaid, ref RemainingAmount, ref DueDate, ref PaymentDate,
                ref PaymentStatus, ref PaymentByUserID, ref AmountSpentID, ref IsActive, ref ReasonInActive,ref PartOfObligationID))

                return new clsContractPaymentSchedule(ObligationID, ApplicationID, TypeObligation, SchedulingMethod,
                    DeservedAmount, AmountPaid, RemainingAmount, DueDate, PaymentDate, PaymentStatus,
                    PaymentByUserID, AmountSpentID, IsActive, ReasonInActive, PartOfObligationID);
            else
                return null;
        }
        public static bool isContractObligationExist(int ObligationID)
        {
            return clsContractPaymentScheduleData.IsContractObligationExist(ObligationID);
        }
        public static bool isContractExist(int ApplicationID)
        {
            return clsContractPaymentScheduleData.IsContractObligationExist(ApplicationID);
        }
        public static DataTable GetAllContractPaymentSchedules()
        {
            return clsContractPaymentScheduleData.GetAllContractPaymentSchedules();
        }
        public static DataTable GetAllContractPaymentSchedules(int ApplicationID)
        {
            return clsContractPaymentScheduleData.GetAllContractPaymentSchedules(ApplicationID);
        }
        public static DataTable GetAllInstallmentsDueThisMonth(short Year,byte Month,int BranchID)
        {
            return clsContractPaymentScheduleData.GetAllInstallmentsDueThisMonth(Year,Month,BranchID);
        }
        public static DataTable GetAllInstallmentsDueThisMonth(short Year, byte Month)
        {
            return clsContractPaymentScheduleData.GetAllInstallmentsDueThisMonth(Year, Month);
        }
        public static bool GenerateContractPaymentSchedules(DataTable dtContractPaymentSchedules, int ApplicationID, bool IsActive)
        {
            return clsContractPaymentScheduleData.GenerateContractPaymentSchedules(dtContractPaymentSchedules, ApplicationID, IsActive);
        }
        public static bool UpdateThePaymentScheduleAfterPayingOneInstallment(int ObligationID,int? PartOfObligationID)
        {
            clsContractPaymentSchedule schedule = clsContractPaymentSchedule.Find(ObligationID);
            if(schedule.TypeObligation==(byte)clsContractPaymentSchedule.enTypeObligation.InitialPayment||schedule.TypeObligation==(byte)clsContractPaymentSchedule.enTypeObligation.FinalPayment)
                return true;    
            return clsContractPaymentScheduleData.UpdateThePaymentScheduleAfterPayingOneInstallment(ObligationID, PartOfObligationID.Value);
        }
        public static DateTime? GetLstPaidInstallmentDateForPartialPayments(int ApplicationID)
        {
            return clsContractPaymentScheduleData.GetLstPaidInstallmentDateForPartialPayments(ApplicationID);
        }
        public static int? GetLstOrderPaidInstallmentForFinalPayment(int ApplicationID)
        {
            return clsContractPaymentScheduleData.GetLstOrderPaidInstallmentForFinalPayment(ApplicationID);
        }
        public static bool IsDueInstallmentDateForSchedulingMethodFacilitator(int ApplicationID,int ObligationID)
        {
            return clsContractPaymentScheduleData.IsDueInstallmentDateForSchedulingMethodFacilitator( ApplicationID,  ObligationID);
        }
        public static bool IsDueInstallmentDateForSchedulingMethodBasic(int ApplicationID, int ObligationID)
        {
            return clsContractPaymentScheduleData.IsDueInstallmentDateForSchedulingMethodBasic(ApplicationID, ObligationID);
        }
        public static bool HaveTheFinalPaymentInstallmentsBeenScheduled(int ApplicationID) 
        {
            return clsContractPaymentScheduleData.HaveTheFinalPaymentInstallmentsBeenScheduled(ApplicationID);
        }
    }
}
