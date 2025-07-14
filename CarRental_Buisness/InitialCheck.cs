using CarRental_DataAccess;
using System.Data;
using System;

namespace CarRental_Business
{
     public  class clsInitialCheck
    {        public enum enMode  {AddNew=1,Update=2}
        public enMode Mode = enMode.AddNew;
        private int _InitialCheckID;
        public int InitialCheckID() { return _InitialCheckID; }
        public  int CheckID { get; set; }
        private clsInitialCheck( int InitialCheckID,  int CheckID )
        {
            
             _InitialCheckID = InitialCheckID;

 this.CheckID = CheckID;  
   Mode = enMode.Update;        }
        public clsInitialCheck()

        {
            this._InitialCheckID = -1;
                     
Mode = enMode.AddNew;

        }
        private bool _AddNewInitialCheck() 
        {
            this._InitialCheckID = clsInitialCheckData.AddNewInitialCheck( CheckID);
            return _InitialCheckID != 0;
        }
        private  bool _UpdateInitialCheck() 
        {
            return clsInitialCheckData.UpdateInitialCheck(this._InitialCheckID,  CheckID);
        }
        public  bool Save()

        {
            switch(Mode) 
            {
                case enMode.AddNew:
                    if (_AddNewInitialCheck())
                    {
                        Mode = enMode.Update;
                        return true; 
                    }
                    else { return false; }
                case enMode.Update:
                    if(_UpdateInitialCheck())
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
        public static clsInitialCheck Find(int InitialCheckID)
        {

             
 int CheckID = 0;
            
            
          if (clsInitialCheckData.GetInitialCheckInfoByID(InitialCheckID  ,ref CheckID))

             return new clsInitialCheck(InitialCheckID, CheckID);
          else
                return null;
        }
        public static bool isInitialCheckExist(int InitialCheckID) 
        {
            return clsInitialCheckData.IsInitialCheckExist(InitialCheckID);
        }
        public static DataTable GetAllInitialChecks() 
        {
            return clsInitialCheckData.GetAllInitialChecks();
        }
}
}
