using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsEmployee 
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _EmployeeID;
        public int EmployeeID { get { return _EmployeeID; } }
        public int PersonID { get; set; }
        public int DepartmentID { get; set; }
        public float MonthlySalary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int BranchID { set; get; }
        protected clsEmployee(int EmployeeID, int PersonID, int DepartmentID, float MonthlySalary, DateTime HireDate, DateTime? ExitDate, int BranchID)
        {

            _EmployeeID = EmployeeID;

            this.PersonID = PersonID;
            this.DepartmentID = DepartmentID;
            this.MonthlySalary = MonthlySalary;
            this.HireDate = HireDate;
            this.ExitDate = ExitDate;
            Mode = enMode.Update;
            this.BranchID = BranchID;
        }
        public clsEmployee()

        {
            this._EmployeeID = -1;

            Mode = enMode.AddNew;

        }
        private bool _AddNewEmployee()
        {
            this._EmployeeID = clsEmployeeData.AddNewEmployee(PersonID, DepartmentID, MonthlySalary, HireDate, ExitDate,BranchID);
            return _EmployeeID != 0;
        }
        private bool _UpdateEmployee()
        {
            return clsEmployeeData.UpdateEmployee(this._EmployeeID, PersonID, DepartmentID, MonthlySalary, HireDate, ExitDate, BranchID);
        }
        public  bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateEmployee())
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
        public new static clsEmployee Find(int EmployeeID)
        {


            int PersonID = 0;
            int DepartmentID = 0;
            float MonthlySalary = 0;
            DateTime HireDate = DateTime.Now;
            DateTime? ExitDate = null;
            int BranchID = 0;

            bool IsFound = clsEmployeeData.GetEmployeeInfoByID(EmployeeID, ref PersonID, ref DepartmentID, ref MonthlySalary, ref HireDate, ref ExitDate,ref BranchID);
            if(IsFound)
                return new clsEmployee(EmployeeID, PersonID, DepartmentID, MonthlySalary, HireDate, ExitDate, BranchID);
            else
                return null;
        }
        public new static clsEmployee Find(string  Phone)
        {
            int EmployeeID = 0;
            int PersonID = 0;
            int DepartmentID = 0;
            float MonthlySalary = 0;
            DateTime HireDate = DateTime.Now;
            DateTime? ExitDate = null;
            int BranchID = 0;

            bool IsFound = clsEmployeeData.GetEmployeeInfoByPhone(Phone,ref EmployeeID, ref PersonID, ref DepartmentID, ref MonthlySalary, ref HireDate, ref ExitDate,ref BranchID);
            if (IsFound)
                return new clsEmployee(EmployeeID, PersonID, DepartmentID, MonthlySalary, HireDate, ExitDate,BranchID);
            else
                return null;
        }
        
        public static clsEmployee FindByPersonID(int PersonID)
        {


            int EmployeeID = 0;
            int DepartmentID = 0;
            float MonthlySalary = 0;
            DateTime HireDate = DateTime.Now;
            DateTime? ExitDate = null;
            int BranchID = 0;

            bool IsFound = clsEmployeeData.GetEmployeeInfoByPersonID(ref EmployeeID, PersonID, ref DepartmentID, ref MonthlySalary, ref HireDate, ref ExitDate,ref BranchID);
            if (IsFound)
                return new clsEmployee(EmployeeID, PersonID, DepartmentID, MonthlySalary, HireDate, ExitDate,BranchID);
            else
                return null;
        }
        public static clsEmployee FindByNationalNo(string NationalNo)
        {


            int EmployeeID = 0;
            int PersonID = 0;
            int DepartmentID = 0;
            float MonthlySalary = 0;
            DateTime HireDate = DateTime.Now;
            DateTime? ExitDate = null;
            int BranchID = 0;

            bool IsFound = clsEmployeeData.GetEmployeeInfoByNationalNo(NationalNo,ref EmployeeID, ref PersonID, ref DepartmentID, ref MonthlySalary, ref HireDate, ref ExitDate,ref BranchID);
            if (IsFound)
                return new clsEmployee(EmployeeID, PersonID, DepartmentID, MonthlySalary, HireDate, ExitDate, BranchID);
            else
                return null;
        }
        public static bool isEmployeeExist(int EmployeeID)
        {
            return clsEmployeeData.IsEmployeeExist(EmployeeID);
        }
        public static bool isEmployeeExistForPersonID(int PersonID)
        {
            return clsEmployeeData.IsEmployeeExistForPersonID(PersonID);
        }
        public static DataTable GetAllEmployees()
        {
            return clsEmployeeData.GetAllEmployees();
        }
        public static DataTable GetAllEmployeesForSelect(int BranchID)
        {
            return clsEmployeeData.GetAllEmployeesForSelect(BranchID);
        }
        public static DataTable GetAllEmployees(int BranchID)
        {
            return clsEmployeeData.GetAllEmployees(BranchID);
        }
    }
}
