using CarRental_DataAccess;
using System;
using System.Data;

namespace CarRental_Business
{
    public class clsCarRentalRule
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        private int _CarRentalRulesID;
        public int CarRentalRulesID { get { return _CarRentalRulesID; } }
        public Byte DownPaymentPercentageOfTotalDailyRent { get; set; }
        public Byte DownPaymentPercentageOfTotalMonthlyRent { get; set; }
        public Byte DownPaymentPercentageOfTotalAnnualRent { get; set; }
        public Boolean IsSolarMonths { get; set; }
        public string Rules { get; set; }
        public Byte? NumberOfDaysInMonthCustom { get; set; }
        private clsCarRentalRule(int CarRentalRulesID, Byte DownPaymentPercentageOfTotalDailyRent, Byte DownPaymentPercentageOfTotalMonthlyRent, Byte DownPaymentPercentageOfTotalAnnualRent, string Rules, bool isSolarMonths, byte? numberOfDaysInMonthCustom)
        {

            _CarRentalRulesID = CarRentalRulesID;

            this.DownPaymentPercentageOfTotalDailyRent = DownPaymentPercentageOfTotalDailyRent;
            this.DownPaymentPercentageOfTotalMonthlyRent = DownPaymentPercentageOfTotalMonthlyRent;
            this.DownPaymentPercentageOfTotalAnnualRent = DownPaymentPercentageOfTotalAnnualRent;
            this.Rules = Rules;
            Mode = enMode.Update;
            IsSolarMonths = isSolarMonths;
            NumberOfDaysInMonthCustom = numberOfDaysInMonthCustom;
        }
        private bool _UpdateCarRentalRule()
        {
            return clsCarRentalRuleData.UpdateCarRentalRule(DownPaymentPercentageOfTotalDailyRent, DownPaymentPercentageOfTotalMonthlyRent, DownPaymentPercentageOfTotalAnnualRent, Rules, IsSolarMonths, NumberOfDaysInMonthCustom);
        }
        public bool Save()
        {
            return this._UpdateCarRentalRule();
        }
        public static clsCarRentalRule GetCarRentalRuleInfo()
        {

            int CarRentalRulesID = 0;
            Byte DownPaymentPercentageOfTotalDailyRent = 0;
            Byte DownPaymentPercentageOfTotalMonthlyRent = 0;
            Byte DownPaymentPercentageOfTotalAnnualRent = 0;
            bool IsSolarMonths = false;
            string Rules = "";
            byte? NumberOfDaysInMonthCustom = null;


            if (clsCarRentalRuleData.GetCarRentalRuleInfo(ref CarRentalRulesID, ref DownPaymentPercentageOfTotalDailyRent, ref DownPaymentPercentageOfTotalMonthlyRent, ref DownPaymentPercentageOfTotalAnnualRent, ref Rules,ref IsSolarMonths,ref NumberOfDaysInMonthCustom))

                return new clsCarRentalRule(CarRentalRulesID, DownPaymentPercentageOfTotalDailyRent, DownPaymentPercentageOfTotalMonthlyRent, DownPaymentPercentageOfTotalAnnualRent, Rules, IsSolarMonths, NumberOfDaysInMonthCustom);
            else
                return null;
        }
    }
}
