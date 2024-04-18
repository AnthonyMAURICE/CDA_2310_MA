using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{

    public class Bouteille
    {
        private double quantiteLiquideEnMl;
        private double capaciteMaxEnMl;
        private bool estOuverte;
       
        public Bouteille()
        {
            this.quantiteLiquideEnMl = 1500;
            this.capaciteMaxEnMl = 1500;
            this.estOuverte = false;
        }

        public Bouteille(double _capaciteMaxEnMl, double _quantiteLiquideEnMl, bool _estOuverte)
        {
            this.quantiteLiquideEnMl = _quantiteLiquideEnMl;
            this.capaciteMaxEnMl = _capaciteMaxEnMl;
            this.estOuverte = _estOuverte;
        }

        public bool GetOpen()
        {
            return this.estOuverte;
        }

        public double GetQuantiteLiquideEnMl()
        {
            return this.quantiteLiquideEnMl;
        }

        public bool Fermer()
        {
            if (this.estOuverte)
            {
                this.estOuverte = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ouvrir()
        {
            if (!this.estOuverte)
            {
                this.estOuverte = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remplir(double _volume)
        {
            if (this.estOuverte && _volume > 0 && this.GetQuantiteLiquideEnMl() < this.capaciteMaxEnMl)
            {
                if (this.quantiteLiquideEnMl + _volume > this.capaciteMaxEnMl) // Si le total quantité + volume est supérieur à la capacité
                {
                    this.quantiteLiquideEnMl = this.capaciteMaxEnMl; // on amène la quantité à la valeur de la capacité
                }
                else
                {
                    this.quantiteLiquideEnMl += _volume; // sinon on fait l'addition comme prévu
                }
                return true;
            }
            else
            {
                return false; // return false si la bouteille ne peut être remplie
            }
        }
                

        public bool Vider(double _volume)
        {

            if (this.estOuverte && _volume > 0 && this.GetQuantiteLiquideEnMl() > 0)
            {
                if (this.quantiteLiquideEnMl - _volume < 0) // même principe à l'inverse pour la soustraction, si elle est inférieure à 0
                {
                    this.quantiteLiquideEnMl = 0; // on considère la bouteille comme vide
                }
                else
                {
                    this.quantiteLiquideEnMl -= _volume; // sinon on soustrait comme prévu
                }
                return true;
            }
            else
            {
                return false; // return false si la bouteille ne peut être vidée
            }
        }
        public bool RemplirTout()
        {
            this.Remplir(this.capaciteMaxEnMl);
            return true;
        }
        
        public bool ViderTout()
        {
            this.Vider(this.capaciteMaxEnMl);
            return true;
        }
    }
}
