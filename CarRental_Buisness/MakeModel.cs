using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsMakeModel
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _ModelID;
        public int ModelID() { return _ModelID; }
        public int MakeID { get; set; }
        public clsMake MakeInfo;
        public string ModelName { get; set; }
        private clsMakeModel(int ModelID, int MakeID, string ModelName)
        {

            _ModelID = ModelID;

            this.MakeID = MakeID;
            this.MakeInfo = clsMake.Find(MakeID);
            this.ModelName = ModelName;
            Mode = enMode.Update;
        }
        public clsMakeModel()

        {
            this._ModelID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewMakeModel()
        {
            this._ModelID = clsMakeModelData.AddNewMakeModel(MakeID, ModelName);
            return _ModelID != 0;
        }
        private bool _UpdateMakeModel()
        {
            return clsMakeModelData.UpdateMakeModel(this._ModelID, MakeID, ModelName);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMakeModel())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateMakeModel())
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
        public static clsMakeModel Find(int ModelID)
        {


            int MakeID = 0;
            string ModelName = "";


            if (clsMakeModelData.GetMakeModelInfoByID(ModelID, ref MakeID, ref ModelName))

                return new clsMakeModel(ModelID, MakeID, ModelName);
            else
                return null;
        }
        public static clsMakeModel Find(string ModelName)
        {

            int ModelID = -1;
            int MakeID = -1;


            if (clsMakeModelData.GetMakeModelInfoByModelName(ref ModelID, ref MakeID,  ModelName))

                return new clsMakeModel(ModelID, MakeID, ModelName);
            else
                return null;
        }
        public static bool isMakeModelExist(int ModelID)
        {
            return clsMakeModelData.IsMakeModelExist(ModelID);
        }
        public static DataTable GetAllMakeModels()
        {
            return clsMakeModelData.GetAllMakeModels();
        }
    }
}
