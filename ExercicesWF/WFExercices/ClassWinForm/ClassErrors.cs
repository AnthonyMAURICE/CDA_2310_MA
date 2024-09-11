using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassWinForm
{
    public class ClassErrors
    {
        public static string ErrorName(string name)
        {
            string namePattern = @"^\p{Lu}[a-zA-z,/.-]{0,30}$";
            if (name.Length == 0 || name == null)
            {
                return "Saisissez un nom";
            }
            else if (name.Length > 30)
            {
                return "Nom trop long";
            }
            else if (!Regex.IsMatch(name, namePattern))
            {
                return "Format de nom incorrect";
            }
            else
            {
                return string.Empty;
            }
        }

        public static string ErrorDate(string dateString)
        {
            string datePattern = @"^(3[01]|[12][0-9]|0?[1-9])(\/|-)(1[0-2]|0?[1-9])\2([0-9]{2})?[0-9]{2}$";
            if(!Regex.IsMatch(dateString, datePattern))
            {
                return "Format de date invalide";
            }
            else
            {
                return string.Empty;
            }
        }

        public static string FutureDate(DateTime date)
        {
            return date < DateTime.Now? "La date doit être dans le futur" : string.Empty;
        }

        public static string ErrorAmount(double amount)
        {
            return (amount <= 0) ? "Le montant doit être supérieur à 0" : string.Empty;
        }

        public static string ErrorZipCode(string code)
        {
            string zipPattern = @"^\d{5}$";
            if (code.Length != 5 || code == null)
            {
                return "Un code postal doit comporter 5 caractères";
            }
            else
            {
                return !Regex.IsMatch(code, zipPattern) ? "Format de code postal invalide" : string.Empty;
            }
            
        }
    }
}
