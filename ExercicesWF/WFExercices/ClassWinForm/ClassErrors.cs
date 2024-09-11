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
                return !FormControls.CheckNameValidity(name)? "Format de nom incorrect" : string.Empty;
            }
        }

        public static string ErrorDate(string dateString)
        {
            return !FormControls.CheckDateValidity(dateString)? "Format de date invalide" : string.Empty;
        }

        public static string FutureDate(DateTime date)
        {
            return !FormControls.DateIsFuture(date)? "La date doit être dans le futur" : string.Empty;
        }

        public static string ErrorAmount(double amount)
        {
            return !FormControls.CheckAmountValidity(amount)? "Le montant doit être supérieur à 0" : string.Empty;
        }

        public static string ErrorZipCode(string code)
        {
            if (code.Length != 5)
            {
                return "Un code postal doit comporter 5 caractères";
            }
            else
            {
                return !FormControls.CheckZipCodeValidity(code)? "Format de code postal invalide" : string.Empty;
            }
            
        }
    }
}
