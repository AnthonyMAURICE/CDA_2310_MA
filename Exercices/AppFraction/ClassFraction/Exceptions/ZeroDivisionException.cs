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

        public static void ZeroException(int _denominateur)
        {
            if (_denominateur == 0)
            {
                throw new ZeroDivisionException("Le dénominateur d'une fraction ne peut être zéro !");
            }
        }
    }
}
