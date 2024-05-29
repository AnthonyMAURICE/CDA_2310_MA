using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLepidoptere
{
    internal class Chrysalide : IStadeEvolution
    {
        private static Chrysalide? chrysalide;
        private string name;

        public Chrysalide()
        {
            this.name = "Chrysalide";
        }

        public static Chrysalide Instancieur()
        {
            chrysalide ??= new Chrysalide();
            return chrysalide;
        }

        public bool SeDeplacer()
        {
            return false;
        }

        public IStadeEvolution SeMetamorphoser()
        {
            return Papillon.Instancieur();
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}