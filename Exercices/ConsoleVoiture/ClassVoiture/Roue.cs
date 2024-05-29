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
        internal WheelState wheelState;
        public double Pressure { get => pressure; }
        public WheelState WheelTurn {get => wheelState; }

        public Roue()
        {
            this.pressure = 2;
            this.wheelState = WheelState.Arrêt;
        }

        public Roue(double pressure): this()
        {
            this.pressure = pressure;
        }

        internal enum WheelState
        {
            Arrière,
            Arrêt,
            Avant
        }
    }


}
