using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Chrysalide : IStadeEvolution
    {
        public bool SeDeplacer()
        {
            return false;
        }

        public IStadeEvolution SeMetamorphoser()
        {
            throw new NotImplementedException();
        }
    }
}
