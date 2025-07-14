using CarRental_DataAccess;
using System;
using System.Data;
using System.Diagnostics.Contracts;

namespace CarRental_Business
{
    public class clsContractPaymentSchedulingApplication
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enStatus { Completed=1,Canceled=2,New=3}
        private int _ApplicationID;
        public int ApplicationID { get { return _ApplicationID; } }
        public int ContractID { get; set; }
        public int CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte Status { set; get; }
        private clsContractPaymentSchedulingApplication(int ApplicationID, int ContractID,
            int CreatedByUserID, int? UpdatedByUserID, DateTime CreatedDate, DateTime? UpdatedDate,byte Status)
        {

            _ApplicationID = ApplicationID;

            this.ContractID = ContractID;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            this.CreatedDate = CreatedDate;
            this.UpdatedDate = UpdatedDate;
            this.Status = Status;
            Mode = enMode.Update;
        }
        public clsContractPaymentSchedulingApplication()

        {
            this._ApplicationID = -1;
            this.ContractID = -1;
            this.CreatedByUserID = -1;
            this.UpdatedByUserID = null;
            this.CreatedDate = DateTime.Now;
            this.UpdatedDate = null;
            this.Status = (byte)enStatus.New ;
            Mode = enMode.AddNew;

        }
        private bool _AddNewContractPaymentSchedulingApplication()
        {
            this._ApplicationID = clsContractPaymentSchedulingApplicationData.AddNewContractPaymentSchedulingApplication(ContractID, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate,Status);
            return _ApplicationID != 0;
        }
        private bool _UpdateContractPaymentSchedulingApplication()
        {
            return clsContractPaymentSchedulingApplicationData.UpdateContractPaymentSchedulingApplication(this._ApplicationID, ContractID, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate,Status);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContractPaymentSchedulingApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateContractPaymentSchedulingApplication())
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
        public static clsContractPaymentSchedulingApplication Find(int ApplicationID)
        {


            int ContractID = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime CreatedDate = DateTime.Now;
            DateTime? UpdatedDate = null;

            byte status =(byte) clsContractPaymentSchedulingApplication.enStatus.New;
            if (clsContractPaymentSchedulingApplicationData.GetContractPaymentSchedulingApplicationInfoByID(ApplicationID, ref ContractID, ref CreatedByUserID, ref UpdatedByUserID, ref CreatedDate, ref UpdatedDate,ref status))

                return new clsContractPaymentSchedulingApplication(ApplicationID, ContractID, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate ,status);
            else
                return null;
        }
        public static clsContractPaymentSchedulingApplication FindByContractID(int ContractID)
        {


            int ApplicationID = 0;
            int CreatedByUserID = 0;
            int? UpdatedByUserID = null;
            DateTime CreatedDate = DateTime.Now;
            DateTime? UpdatedDate = null;
            byte status = (byte)clsContractPaymentSchedulingApplication.enStatus.New;

            if (clsContractPaymentSchedulingApplicationData.GetContractPaymentSchedulingApplicationInfoByContractID(ref ApplicationID, ContractID, ref CreatedByUserID, ref UpdatedByUserID, ref CreatedDate, ref UpdatedDate, ref status))

                return new clsContractPaymentSchedulingApplication(ApplicationID, ContractID, CreatedByUserID, UpdatedByUserID, CreatedDate, UpdatedDate, status);
            else
                return null;
        }
        public static bool isContractPaymentSchedulingApplicationExist(int ApplicationID)
        {
            return clsContractPaymentSchedulingApplicationData.IsContractPaymentSchedulingApplicationExist(ApplicationID);
        }
        public static bool isContractPaymentSchedulingApplicationExistByContractID(int ContractID)
        {
            return clsContractPaymentSchedulingApplicationData.isContractPaymentSchedulingApplicationExistByContractID(ContractID);
        }
        public static DataTable GetAllContractPaymentSchedulingApplications()
        {
            return clsContractPaymentSchedulingApplicationData.GetAllContractPaymentSchedulingApplications();
        }
        public static DataTable GetAllContractPaymentSchedulingApplications(int BranchID)
        {
            return clsContractPaymentSchedulingApplicationData.GetAllContractPaymentSchedulingApplications(BranchID);
        }
    }
}
