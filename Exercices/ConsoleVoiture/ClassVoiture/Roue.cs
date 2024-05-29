using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVoiture
{
    internal class Roue
    {
        private double pressure;
        private WheelState wheelState;
        public Roue()
        {
            this.pressure = 2;
        }

        public Roue(double pressure)
        {
            this.pressure = pressure;
        }

        enum WheelState
        {
            Arrière,
            Arrêt,
            Avant
        }
    }


}
