using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsModel
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _ModelID;
        public int ModelID() { return _ModelID; }
        public string Model { get; set; }
        public clsMake MakeInfo;
        private clsModel(int ModelID, string Model)
        {

            _ModelID = ModelID;
            this.MakeInfo = clsMake.Find(ModelID);
            this.Model = Model;
            Mode = enMode.Update;
        }
        public clsModel()

        {
            this._ModelID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewModel()
        {
            this._ModelID = clsModelData.AddNewModel(Model);
            return _ModelID != 0;
        }
        private bool _UpdateModel()
        {
            return clsModelData.UpdateModel(this._ModelID, Model);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewModel())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateModel())
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
        public static clsModel Find(int ModelID)
        {


            string Model = "";


            if (clsModelData.GetModelInfoByID(ModelID, ref Model))

                return new clsModel(ModelID, Model);
            else
                return null;
        }
        public static bool isModelExist(int ModelID)
        {
            return clsModelData.IsModelExist(ModelID);
        }
        public static DataTable GetAllModels()
        {
            return clsModelData.GetAllModels();
        }
        public static DataTable GetAllModelsByMakeID(int MakeID)
        {
            return clsModelData.GetAllModelsByMakeID(MakeID);
        }
    }
}
