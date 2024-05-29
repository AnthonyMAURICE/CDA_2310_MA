﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLepidoptere
{
    internal class Larve : IStadeEvolution
    {

        private static Larve? larve;
        public Larve()
        {

        }

        public static Larve Maker()
        {
            larve ??= new Larve();
            return larve;
        }

        public bool SeDeplacer()
        {
            return true;
        }

        public IStadeEvolution SeMetamorphoser()
        {
            return Chrysalide.Maker();
        }
        public override string ToString()
        {
            return "Larve";
        }
    }
}
