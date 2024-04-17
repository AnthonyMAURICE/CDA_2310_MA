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
        private double capacityMaxInML;
        private bool isOpen;

        public Bouteille()
        {
            this.quantityInML = 1500;
            this.capacityMaxInML = 1500;
            this.isOpen = false;
        }

        public Bouteille(double _quantityInML, double _capacityMaxInML, bool _isOpen)
        {
            this.quantityInML = _quantityInML;
            this.capacityMaxInML = _capacityMaxInML;
            this.isOpen = _isOpen;
        }

        public bool GetOpen()
        {
            return this.isOpen;
        }

        public double GetqQuantityInML()
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
                if(this.quantityInML + _volume > this.capacityMaxInML)
                {
                    this.quantityInML = this.capacityMaxInML; 
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
            if(this.isOpen && this.quantityInML < this.capacityMaxInML)
            {
                this.quantityInML = this.capacityMaxInML;
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
