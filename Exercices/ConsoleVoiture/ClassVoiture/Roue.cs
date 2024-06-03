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
            this.wheelState = WheelState.Arret;
        }

        public Roue(double pressure): this()
        {
            this.pressure = pressure;
        }

        public void WheelSide(bool _onward, bool _moving)
        {
            if (_moving)
            {
                this.wheelState = _onward ? WheelState.Avant : WheelState.Arriere;
            }
            else
            {
                this.wheelState = WheelState.Arret;
            }
        }

        internal enum WheelState
        {
            Arriere,
            Arret,
            Avant
        }
    }


}
