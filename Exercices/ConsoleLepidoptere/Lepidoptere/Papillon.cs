using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLepidoptere
{
    internal class Papillon : IStadeEvolution
    {
        private string name;
        private static Papillon? papillon;

        public Papillon()
        {
            this.name = "Papillon";
        }

        public bool SeDeplacer()
        {
            return true;
        }

        public static Papillon Instancieur()
        {
            papillon ??= new Papillon();
            return papillon;
        }

        public IStadeEvolution SeMetamorphoser()
        {
            return Instancieur();
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}