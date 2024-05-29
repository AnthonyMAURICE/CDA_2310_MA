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
        private string name;

        public Oeuf()
        {
            this.name = "Oeuf";
        }

        public static Oeuf Instancieur()
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
            return Larve.Instancieur();
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}