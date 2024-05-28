using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLepidoptere
{
    internal interface IStadeEvolution
    {
        IStadeEvolution SeMetamorphoser();
        bool SeDeplacer();
    }
}
