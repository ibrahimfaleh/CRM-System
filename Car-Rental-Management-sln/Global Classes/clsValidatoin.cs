using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Classes
{
    public  class  clsValidatoin
    {

        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }
        public static bool ValidatePlateCharacters(string PlateCharacters)
        {
            var pattern = @"^[a-z-' ']*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(PlateCharacters);
        }



        public static bool ValidateNumbers(string Number)
        {
            var pattern = "^-?[0-9]\\d*?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }
        public static bool ValidatePositiveNumbers(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }


        public static bool ValidatePositiveDecimalNumbers(string Number)
        {
            var pattern = @"^-?[0-9]*\d(?:\.[0-9]*)?$";
            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }
        public static bool ValidateDecimalNumber(string Number)
        {
            var pattern = "^-?[0-9]\\d*(\\.\\d+)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

    }
}
