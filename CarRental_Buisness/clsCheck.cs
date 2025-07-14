using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsCheck
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _CheckID;
        public int CheckID() { return _CheckID; }
        public DateTime DateCheck { get; set; }
        public Boolean FrontPart { get; set; }
        public string FrontPartImage { get; set; }
        public string FrontPartNote { get; set; }
        public double FrontPartFee { get; set; }
        public Boolean RightPart { get; set; }
        public string RightPartImage { get; set; }
        public string RightNote { get; set; }
        public double RightPartFee { get; set; }
        public Boolean LeftPart { get; set; }
        public string LeftPartImage { get; set; }
        public string LeftNote { get; set; }
        public double LeftPartFee { get; set; }
        public Boolean BackPart { get; set; }
        public string BackPartImage { get; set; }
        public string BackNote { get; set; }
        public double BackPartFee { get; set; }
        public Boolean UpperBody { get; set; }
        public string UpperBodyImage { get; set; }
        public string UpperBodyNote { get; set; }
        public double UpperBodyFee { get; set; }
        public Boolean Bag { get; set; }
        public string BagImage { get; set; }
        public string BagNote { get; set; }
        public double BagFee { get; set; }
        public double TotalCharges { get { return (this.FrontPartFee + this.RightPartFee + this.LeftPartFee + this.BackPartFee + this.UpperBodyFee + this.BagFee)+0; } }

        private clsCheck(int checkID, DateTime dateCheck, bool frontPart, string frontPartImage, string frontPartNote, double frontPartFee, bool rightPart, string rightPartImage, string rightNote,
            double rightPartFee, bool leftPart, string leftPartImage, string leftNote, double leftPartFee, bool backPart, string backPartImage, string backNote, double backPartFee,
            bool upperBody, string upperBodyImage, string upperBodyNote, double upperBodyFee, bool bag, string bagImage, string bagNote, double bagFee)
        {
            Mode = enMode.Update;
            _CheckID = checkID;
            DateCheck = dateCheck;
            FrontPart = frontPart;
            FrontPartImage = frontPartImage;
            FrontPartNote = frontPartNote;
            FrontPartFee = frontPartFee;
            RightPart = rightPart;
            RightPartImage = rightPartImage;
            RightNote = rightNote;
            RightPartFee = rightPartFee;
            LeftPart = leftPart;
            LeftPartImage = leftPartImage;
            LeftNote = leftNote;
            LeftPartFee = leftPartFee;
            BackPart = backPart;
            BackPartImage = backPartImage;
            BackNote = backNote;
            BackPartFee = backPartFee;
            UpperBody = upperBody;
            UpperBodyImage = upperBodyImage;
            UpperBodyNote = upperBodyNote;
            UpperBodyFee = upperBodyFee;
            Bag = bag;
            BagImage = bagImage;
            BagNote = bagNote;
            BagFee = bagFee;
        }
        public clsCheck()

        {
            this._CheckID = -1;
            Mode = enMode.AddNew;

        }
        private bool _AddNewCheck()
        {
            this._CheckID = clsChecData.AddNewCheck( DateCheck, FrontPart, FrontPartImage, FrontPartNote, FrontPartFee, RightPart, RightPartImage, RightNote, RightPartFee, LeftPart, LeftPartImage, LeftNote, LeftPartFee, BackPart, BackPartImage, BackNote, BagFee, UpperBody, UpperBodyImage, UpperBodyNote, UpperBodyFee, Bag, BagImage, BagNote, BagFee);
            return _CheckID != -1;
        }
        private bool _UpdateCheck()
        {
            return clsChecData.UpdateCheck
                (this._CheckID, DateCheck, FrontPart, FrontPartImage, FrontPartNote, FrontPartFee, RightPart, RightPartImage, RightNote, RightPartFee, LeftPart, LeftPartImage, LeftNote, LeftPartFee, BackPart, BackPartImage, BackNote, BackPartFee, UpperBody, UpperBodyImage, UpperBodyNote, UpperBodyFee, Bag, BagImage, BagNote, BagFee);
        }
        public bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCheck())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    if (_UpdateCheck())
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
        public static clsCheck Find(int CheckID)
        {


            DateTime DateCheck = DateTime.Now;
            Boolean FrontPart = false;
            string FrontPartImage = "";
            string FrontPartNote = "";
            Boolean RightPart = false;
            string RightPartImage = "";
            string RightNote = "";
            Boolean LeftPart = false;
            string LeftPartImage = "";
            string LeftNote = "";
            Boolean BackPart = false;
            string BackPartImage = "";
            string BackNote = "";
            Boolean UpperBody = false;
            string UpperBodyImage = "";
            string UpperBodyNote = "";
            Boolean Bag = false;
            string BagImage = "";
            string BagNote = "";
            double FrontPartFee = 0;
            double RightPartFee = 0;
            double LeftPartFee = 0;
            double BackPartFee = 0;
            double UpperBodyFee = 0;
            double BagFee = 0;


            if (clsChecData.GetCheckInfoByID(CheckID, ref DateCheck, ref FrontPart, ref FrontPartImage, ref FrontPartNote, ref FrontPartFee, ref RightPart, ref RightPartImage, ref RightNote, ref RightPartFee, ref LeftPart,
                ref LeftPartImage, ref LeftNote, ref LeftPartFee, ref BackPart, ref BackPartImage, ref BackNote, ref BackPartFee, ref UpperBody, ref UpperBodyImage, ref UpperBodyNote, ref UpperBodyFee, ref Bag, ref BagImage, ref BagNote, ref BagFee))

                return new clsCheck(CheckID, DateCheck, FrontPart, FrontPartImage, FrontPartNote, FrontPartFee, RightPart, RightPartImage, RightNote, RightPartFee, LeftPart, LeftPartImage,
                    LeftNote, LeftPartFee, BackPart, BackPartImage, BackNote, BackPartFee, UpperBody, UpperBodyImage, UpperBodyNote, UpperBodyFee, Bag, BagImage, BagNote, BagFee);
            else
                return null;
        }
        public static bool isChecExist(int CheckID)
        {
            return clsChecData.IsCheckExist(CheckID);
        }
        public static DataTable GetAllChecks()
        {


            return clsChecData.GetAllChecks();
        }
    }
}
