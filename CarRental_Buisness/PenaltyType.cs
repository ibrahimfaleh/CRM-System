using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsPenaltyType
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _TypeID;
        public int TypeID { get { return _TypeID; } }
        public string PenaltyType { get; set; }
        private clsPenaltyType(int TypeID, string PenaltyType)
        {

            _TypeID = TypeID;

            this.PenaltyType = PenaltyType;
            Mode = enMode.Update;
        }
        public clsPenaltyType()

        {
            this._TypeID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewPenaltyType()
        {
            this._TypeID = clsPenaltyTypeData.AddNewPenaltyType(PenaltyType);
            return _TypeID != 0;
        }
        private bool _UpdatePenaltyType()
        {
            return clsPenaltyTypeData.UpdatePenaltyType(this._TypeID, PenaltyType);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPenaltyType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdatePenaltyType())
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
        public static clsPenaltyType Find(int TypeID)
        {


            string PenaltyType = "";


            if (clsPenaltyTypeData.GetPenaltyTypeInfoByID(TypeID, ref PenaltyType))

                return new clsPenaltyType(TypeID, PenaltyType);
            else
                return null;
        }
        public static clsPenaltyType Find(string PenaltyType)
        {


            int TypeID = -1;


            if (clsPenaltyTypeData.GetPenaltyTypeInfoByPenaltyType(ref TypeID,  PenaltyType))

                return new clsPenaltyType(TypeID, PenaltyType);
            else
                return null;
        }
        public static bool isPenaltyTypeExist(int TypeID)
        {
            return clsPenaltyTypeData.IsPenaltyTypeExist(TypeID);
        }
        public static DataTable GetAllPenaltyTypes()
        {
            return clsPenaltyTypeData.GetAllPenaltyTypes();
        }
    }
}
