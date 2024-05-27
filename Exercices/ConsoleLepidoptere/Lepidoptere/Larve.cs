using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Larve : IStadeEvolution
    {
        public bool SeDeplacer()
        {
            return true;
        }

        public IStadeEvolution SeMetamorphoser()
        {
            throw new NotImplementedException();
        }
    }
}
