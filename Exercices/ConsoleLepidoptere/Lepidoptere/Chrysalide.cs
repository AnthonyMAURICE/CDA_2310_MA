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
        public Chrysalide()
        {

        }

        public static Chrysalide Maker()
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
            return Papillon.Maker();
        }
    }
}
