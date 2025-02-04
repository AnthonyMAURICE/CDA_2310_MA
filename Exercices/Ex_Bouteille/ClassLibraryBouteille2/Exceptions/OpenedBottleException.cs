using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBouteille
{
    public class OpenenedBottleException : Exception
    {
        public OpenenedBottleException(string message) : base(message) { }

        public static void OpenedBottle(bool _open)
        {
            if (!_open)
            {
                throw new OpenenedBottleException("Bouteille Fermée.");
            }
        }

    }
}
