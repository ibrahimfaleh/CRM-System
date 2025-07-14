using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsVehicleCheck
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public enum enStatus { InitialCheck = 1, FinalCheck = 2, Completed = 3 }
        public int VehicleCheckID { private set; get; }
        public int InitialCheckID { get; set; }
        public int? FinalCheckID { get; set; }
        public byte Status { set; get; }    
        public int VehicleID { set; get; }
        private clsVehicleCheck(int vehicleCheckID, int InitialCheckID, int? FinalCheckID,byte Status,int VehicleID)
        {
            VehicleCheckID = vehicleCheckID;
           
            this.InitialCheckID = InitialCheckID;
            this.FinalCheckID = FinalCheckID;
            this.Status = Status;   
            this.VehicleID = VehicleID;
            Mode = enMode.Update;
        }
        public clsVehicleCheck()

        {
            this.VehicleCheckID = -1;
            this.InitialCheckID = -1;
            this.FinalCheckID = null;
            this.Status = 1;
            this.VehicleID = -1;
            Mode = enMode.AddNew;

        }
        private bool _AddNewVehicleCheck()
        {
            this.VehicleCheckID = clsVehicleCheckData.AddNewVehicleCheck(InitialCheckID, FinalCheckID,Status,VehicleID);
            return VehicleCheckID != -1;
        }
        private bool _UpdateVehicleCheck()
        {
            return clsVehicleCheckData.UpdateVehicleCheck(this.VehicleCheckID, InitialCheckID, FinalCheckID, Status, VehicleID);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleCheck())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateVehicleCheck())
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
        public static clsVehicleCheck Find(int VehicleCheckID)
        {


            int InitialCheckID = 0;
            int? FinalCheckID = null;
            byte Status = 0;
            int VehicleID = -1;

            if (clsVehicleCheckData.GetVehicleCheckInfoByID(VehicleCheckID, ref InitialCheckID, ref FinalCheckID,ref Status, ref VehicleID))

                return new clsVehicleCheck(VehicleCheckID, InitialCheckID, FinalCheckID, Status, VehicleID);
            else
                return null;
        }
        public static clsVehicleCheck FindByVehicleIDAndStatus(int VehicleID,byte Status)
        {
            int VehicleCheckID = 0;
            int InitialCheckID = 0;
            int? FinalCheckID = null;

            if (clsVehicleCheckData.GetVehicleCheckInfoByVehicleIDAndStatus( VehicleID, ref VehicleCheckID, ref InitialCheckID, ref FinalCheckID,  Status))

                return new clsVehicleCheck(VehicleCheckID, InitialCheckID, FinalCheckID,Status,VehicleID);
            else
                return null;
        }
        public static bool isVehicleCheckExist(int VehicleCheckID)
        {
            return clsVehicleCheckData.IsVehicleCheckExist(VehicleCheckID);
        }
        public static DataTable GetAllVehicleChecks()
        {
            return clsVehicleCheckData.GetAllVehicleChecks();
        }
    }
}
