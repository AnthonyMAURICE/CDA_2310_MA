using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWinForm
{
    public class FormControls
    {       
        public static bool CheckNameValidity(string name)
        {
            string namePattern = @"^\p{Lu}[a-zA-z,/.-]{0,30}$";
            return (Regex.IsMatch(name, namePattern));
        }

        public static bool CheckAmountValidity(double amount)
        {
            return amount > 0;
        }

        public static bool CheckDateValidity(string date)
        {
            string timePattern = @"^(3[01]|[12][0-9]|0?[1-9])(\/|-)(1[0-2]|0?[1-9])\2([0-9]{2})?[0-9]{2}$";
            return Regex.IsMatch(date, timePattern);
        }

        public static bool DateIsFuture(DateTime date) 
        {
            return date > DateTime.Now;
        }

        public static bool CheckZipCodeValidity(string zipcode)
        {
            string zipPattern = @"^\d{5}$";
            return (Regex.IsMatch(zipcode, zipPattern));
        }

    }
}
