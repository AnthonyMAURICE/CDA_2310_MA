using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWinForm
{
    public class FormControls
    {
        private static DateTime date;
        private static double parsedAmount;

        public static bool CheckNameValidity(string name)
        {
            string namePattern = @"^\b([A-ZÀ-ÿ][-,a-z. ']+[ ]*)+";
            return (Regex.IsMatch(name, namePattern));
        }

        public static bool CheckAmountValidity(string amount, out double parsedAmount)
        {
            Double.TryParse(amount, out parsedAmount);
            return parsedAmount > 0;
        }

        public static bool CheckIfInt(string stringNumberToTest, out int parsedInt)
        {
            return int.TryParse(stringNumberToTest, out parsedInt);
        }

        public static bool CheckDateValidity(string stringDate, out DateTime date)
        {
            const string format = "dd/MM/yyyy";
            return DateTime.TryParseExact(stringDate, format, CultureInfo.CurrentCulture, style: 0, out date);
        }

        public static bool DateIsFuture(DateTime date) 
        {
            return date > DateTime.Now;
        }

        public static bool CheckZipCodeValidity(string zipcode)
        {
            string zipPattern = @"^(?:0[1-9]|[1-8]\d|9[0-8])\d{3}$";
            return (Regex.IsMatch(zipcode, zipPattern));
        }

        public static string ErrorName(string name)
        {
            if (name == "")
            {
                return "Saisissez un nom";
            }
            else if (name.Length > 30)
            {
                return "Nom trop long";
            }
            else
            {
                return !CheckNameValidity(name) ? "Format de nom incorrect" : string.Empty;
            }
        }

        public static string ErrorDate(string dateString)
        {
            return !CheckDateValidity(dateString, out date) ? "Format de date invalide" : string.Empty;
        }

        public static string FutureDate(DateTime date)
        {
            return !DateIsFuture(date) ? "La date doit être dans le futur" : string.Empty;
        }

        public static string ErrorAmount(string amount)
        {
            return !CheckAmountValidity(amount, out parsedAmount) ? "Le montant doit être un nombre supérieur à 0" : string.Empty;
        }

        public static string ErrorZipCode(string code)
        {
            if (code.Length != 5)
            {
                return "Un code postal doit comporter 5 caractères";
            }
            else
            {
                return !CheckZipCodeValidity(code) ? "Format de code postal invalide" : string.Empty;
            }

        }
    }
}
