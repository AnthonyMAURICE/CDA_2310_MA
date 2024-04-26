using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompteBancaire.ExceptionsCompte
{
    public class ExceptionOverDecouvert : Exception
    {
        public ExceptionOverDecouvert(string message) : base(message) { }
        public static void DecouvertDepasse(double _montant, double _solde, int _decouvert)
        {
            if(_montant + _solde < _decouvert)
            {
                throw new ExceptionOverDecouvert("Découvert dépassé ! Opération annulée");
            }
        }
    }
}
