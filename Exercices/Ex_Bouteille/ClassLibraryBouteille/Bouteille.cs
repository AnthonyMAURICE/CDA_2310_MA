using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private double quantityInML;
        private double capacityInMl;
        private bool isOpen;

        public Bouteille()
        {
            this.quantityInML = 1500;
            this.capacityInMl = 1500;
            this.isOpen = false;
        }

        public Bouteille(double _quantityInML, double _capaciteMaxEnML, bool _isOpen)
        {
            this.quantityInML = _quantityInML;
            this.capacityInMl = _capaciteMaxEnML;
            this.isOpen = _isOpen;
        }

        public bool GetOpen()
        {
            return this.isOpen;
        }

        public double GetQuantityInML()
        {
            return this.quantityInML;
        }

        public bool Close()
        {
            if (this.isOpen)
            {
                this.isOpen = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Open()
        {
            if (!this.isOpen)
            {
                this.isOpen = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddQuantity(double _volume)
        {
            if (this.isOpen && _volume > 0)
            {
                if(this.quantityInML + _volume > this.capacityInMl)
                {
                    this.quantityInML = this.capacityInMl; 
                }
                else
                {
                    this.quantityInML += _volume;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveQuantity(double _volume)
        {
            if (this.isOpen && _volume > 0)
            {
                if (this.quantityInML - _volume < 0)
                {
                    this.quantityInML = 0;
                }
                else
                {
                    this.quantityInML -= _volume;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FillBottle()
        {
            if(this.isOpen && this.quantityInML < this.capacityInMl)
            {
                this.quantityInML = this.capacityInMl;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool EmptyBottle()
        {
            if(this.isOpen && this.quantityInML > 0)
            {
                this.quantityInML = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
