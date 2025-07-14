using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsTypesOfBill
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _TypeID;
        public int TypeID { get { return _TypeID; } }
        public string Type { get; set; }
        private clsTypesOfBill(int TypeID, string Type)
        {

            _TypeID = TypeID;

            this.Type = Type;
            Mode = enMode.Update;
        }
        public clsTypesOfBill()

        {
            this._TypeID = -1;
            this.Type =string.Empty;
            Mode = enMode.AddNew;

        }
        private bool _AddNewTypesOfBill()
        {
            this._TypeID = clsTypesOfBillData.AddNewTypesOfBill(Type);
            return _TypeID != 0;
        }
        private bool _UpdateTypesOfBill()
        {
            return clsTypesOfBillData.UpdateTypesOfBill(this._TypeID, Type);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTypesOfBill())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateTypesOfBill())
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
        public static clsTypesOfBill Find(int TypeID)
        {


            string Type = "";


            if (clsTypesOfBillData.GetTypesOfBillInfoByID(TypeID, ref Type))

                return new clsTypesOfBill(TypeID, Type);
            else
                return null;
        }
        public static clsTypesOfBill Find(string Type)
        {
            int TypeID = -1;
            if (clsTypesOfBillData.GetTypesOfBillInfoByType(ref TypeID,  Type))

                return new clsTypesOfBill(TypeID, Type);
            else
                return null;
        }
        public static bool isTypesOfBillExist(int TypeID)
        {
            return clsTypesOfBillData.IsTypesOfBillExist(TypeID);
        }
        public static DataTable GetAllTypesOfBills()
        {
            return clsTypesOfBillData.GetAllTypesOfBills();
        }
    }
}
