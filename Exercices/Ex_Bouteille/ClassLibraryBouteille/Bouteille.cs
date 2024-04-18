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

        // Pour les ajouts avec paramètres, vérification si la bouteille est ouverte et que ce paramètre (_volume) est supérieur à 0

        public bool AddQuantity(double _volume)
        {
            if (this.isOpen && _volume > 0)
            {
                if(this.quantityInML + _volume > this.capacityMaxInML) // Si le total quantité + volume est supérieur à la capacité
                {
                    this.quantityInML = this.capacityMaxInML; // on amène la quantité à la valeur de la capacité
                }
                else
                {
                    this.quantityInML += _volume; // sinon on fait l'addition comme prévu
                }
                return true;
            }
            else
            {
                return false; // return false si la bouteille ne peut être remplie
            }
        }

        public bool RemoveQuantity(double _volume)
        {
            if (this.isOpen && _volume > 0)
            {
                if (this.quantityInML - _volume < 0) // même principe à l'inverse pour la soustraction, si elle est inférieure à 0
                {
                    this.quantityInML = 0; // on considère la bouteille comme vide
                }
                else
                {
                    this.quantityInML -= _volume; // sinon on soustrait comme prévu
                }
                return true;
            }
            else
            {
                return false; // return false si la bouteille ne peut être vidée
            }
        }

        public bool FillBottle()
        {
            if(this.isOpen && this.quantityInML < this.capacityMaxInML) // Si le contenu est inférieur à la capacité totale
            {
                this.quantityInML = this.capacityMaxInML; // On amène la quantité à la valeur de la capacité
                return true;
            }
            else
            {
                return false; // return false si la bouteille ne peut être remplie
            }
        }
        
        public bool EmptyBottle()
        {
            if(this.isOpen && this.quantityInML > 0) // Si le contenu est supérieur à 0
            {
                this.quantityInML = 0; // le contenu est amené à 0
                return true;
            }
            else
            {
                return false; // return false si la bouteille ne peut être vidée
            }
        }
    }
}
