using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBouteille
{
    public class EmptyBottleException : Exception
    {
        public EmptyBottleException(string message) : base(message) { }

        public static void EmptyBottle(double _quantiteLiquideEnMl)
        {
            if (_quantiteLiquideEnMl <= 0)
            {
                throw new EmptyBottleException("La bouteille est déjà vide");
            }
        }
    }
}
