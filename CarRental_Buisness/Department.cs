using CarRental_DataAccess;
using System.Data;

namespace CarRental_Business
{
    public class clsDepartment
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _DepartmentID;
        public int DepartmentID { get { return _DepartmentID; } }
        public string DepartmentName { get; set; }
        protected clsDepartment(int DepartmentID, string DepartmentName)
        {

            _DepartmentID = DepartmentID;

            this.DepartmentName = DepartmentName;
            Mode = enMode.Update;
        }
        public clsDepartment()

        {
            this._DepartmentID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewDepartment()
        {
            this._DepartmentID = clsDepartmentData.AddNewDepartment(DepartmentName);
            return _DepartmentID != 0;
        }
        private bool _UpdateDepartment()
        {
            return clsDepartmentData.UpdateDepartment(this._DepartmentID, DepartmentName);
        }
        public virtual bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDepartment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateDepartment())
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
        public  static clsDepartment  Find(int DepartmentID)
        {


            string DepartmentName = "";


            if (clsDepartmentData.GetDepartmentInfoByID(DepartmentID, ref DepartmentName))

                return new clsDepartment(DepartmentID, DepartmentName);
            else
                return null;
        }


        public static clsDepartment Find(string  DepartmentName)
        {


            int DepartmentID = -1;

            if (clsDepartmentData.GetDepartmentInfoByDepartmentName(ref DepartmentID,  DepartmentName))

                return new clsDepartment(DepartmentID, DepartmentName);
            else
                return null;
        }


        public static bool isDepartmentExist(int DepartmentID)
        {
            return clsDepartmentData.IsDepartmentExist(DepartmentID);
        }
        public static DataTable GetAllDepartments()
        {
            return clsDepartmentData.GetAllDepartments();
        }
    }
}
