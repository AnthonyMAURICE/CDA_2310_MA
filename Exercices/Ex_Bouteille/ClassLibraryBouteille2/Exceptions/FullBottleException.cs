using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBouteille
{
    public class FullBottleException : Exception
    {
        public FullBottleException(string message) : base(message) { }

        public static void FullBottle(double _quantiteLiquideEnMl, double _capaciteEnMl)
        {
            if (_quantiteLiquideEnMl >= _capaciteEnMl)
            {
                throw new FullBottleException("La bouteille est déjà pleine");
            }
        }
    }
}
