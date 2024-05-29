using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLepidoptere
{
    internal class Oeuf : IStadeEvolution
    {
        private static Oeuf? oeuf;
        public Oeuf()
        {

        }

        public static Oeuf Maker()
        {
            oeuf ??= new Oeuf();
            return oeuf;
        }

        public bool SeDeplacer()
        {
            return false;
        }

        public IStadeEvolution SeMetamorphoser()
        {
            return Larve.Maker();
        }

        public override string ToString()
        {
            return "Oeuf";
        }
    }
}