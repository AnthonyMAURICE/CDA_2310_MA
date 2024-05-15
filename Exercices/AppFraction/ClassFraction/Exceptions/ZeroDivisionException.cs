using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFraction.Exceptions
{
    public class ZeroDivisionException : Exception
    {
        public ZeroDivisionException(string message) : base(message) { }

        public static void ZeroException(Fraction _fraction)
        {
            if (_fraction.GetDenominateur() == 0)
            {
                throw new ZeroDivisionException("Le dénominateur d'une fraction ne peut être zéro !");
            }
        }
    }
}
