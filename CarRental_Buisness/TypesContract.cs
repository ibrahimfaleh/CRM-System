using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsTypesContract
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _TypeID;
        public int TypeID { get { return _TypeID; } }
        public string Type { get; set; }
        private clsTypesContract(int TypeID, string Type)
        {

            _TypeID = TypeID;

            this.Type = Type;
            Mode = enMode.Update;
        }
        public clsTypesContract()

        {
            this._TypeID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewTypesContract()
        {
            this._TypeID = clsTypesContractData.AddNewTypesContract(Type);
            return _TypeID != 0;
        }
        private bool _UpdateTypesContract()
        {
            return clsTypesContractData.UpdateTypesContract(this._TypeID, Type);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTypesContract())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateTypesContract())
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
        public static clsTypesContract Find(int TypeID)
        {


            string Type = "";


            if (clsTypesContractData.GetTypesContractInfoByID(TypeID, ref Type))

                return new clsTypesContract(TypeID, Type);
            else
                return null;
        }
        public static clsTypesContract Find(string  Type)
        {


            int TypeID = -1;


            if (clsTypesContractData.GetTypesContractInfoByType(ref TypeID,  Type))

                return new clsTypesContract(TypeID, Type);
            else
                return null;
        }
        public static bool isTypesContractExist(int TypeID)
        {
            return clsTypesContractData.IsTypesContractExist(TypeID);
        }
        public static DataTable GetAllTypesContracts()
        {
            return clsTypesContractData.GetAllTypesContracts();
        }
    }
}
