using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVoiture
{
    internal class Moteur
    {
        private int nbCylinders;
        private int powerBHP;
        private bool started;

        public int PowerBHP { get => powerBHP;}
        public int NbCylinders { get => nbCylinders;}
        public bool Started { get => started;}

        public Moteur()
        {
            this.nbCylinders = 3;
            this.powerBHP = 90;
            this.started = false;
        }

        public Moteur(int _nbCylinders, int _powerBHP)
        {
            this.nbCylinders = _nbCylinders;
            this.powerBHP = _powerBHP;
            this.started = false;
        }


        public bool Start()
        {
            bool canStart = !this.started;
            if (canStart)
            {
                this.started = true;
            }
            return canStart;
        }

        public bool Stop()
        {
            bool canStop = this.started;
            if (canStop)
            {
                this.started = false;
            }
            return canStop;
        }


    }
}
