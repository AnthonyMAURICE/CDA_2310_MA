using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompteBancaire.ExceptionsCompte
{
    public class ExceptionNegative : Exception
    {
        public ExceptionNegative(string message) : base(message) { }

        public static void CheckNegative(double _montant)
        {
            if(_montant < 0)
            {
                throw new ExceptionNegative("Vous ne pouvez créditer un montant négatif");
            }
        }
    }
}
