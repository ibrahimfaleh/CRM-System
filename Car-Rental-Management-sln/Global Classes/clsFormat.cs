using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CarRental.Classes
{
    public class clsFormat
    {
        public static string DateToShort(DateTime Dt1)
        {
            
            return Dt1.ToString("dd/MMM/yyyy");
        } 
        public static string ConvertTextIntoLetters(string text) 
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in text)
            {
                sb.Append(item).Append(' ');
            }
            return sb.ToString().Trim();
        }
        public static string ReturnNumbersFromText(string text) 
        {

            StringBuilder numbers = new StringBuilder();
            text = Regex.Replace(text, @"\s", string.Empty);
            foreach (string s1 in Regex.Split(text, @"\D+"))
            {
                numbers.Append(s1);
            }
            return numbers.ToString();
        }
        public static string ReturnsCharactersFromText(string text) 
        {
            StringBuilder characters = new StringBuilder();
            text = Regex.Replace(text, @"\s", string.Empty);
            foreach (string s1 in Regex.Split(text, @"\d+"))
            {
                characters.Append(s1);
            }
            return characters.ToString();   

        }
        public static string DeleteAllSpaceFromText(string text) 
        {
            return Regex.Replace(text, @"\s", string.Empty);
        }
    }
}
