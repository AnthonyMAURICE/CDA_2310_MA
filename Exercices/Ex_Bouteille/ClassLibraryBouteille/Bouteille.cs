using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


// version sans gestion des exceptions
namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private double quantiteLiquideEnMl;
        private double capaciteMaxEnMl;
        private bool estOuverte;

        public bool EstOuverte
        {
            get { return this.estOuverte;}
            set { estOuverte = value; }
        }

        public double QuantiteLiquideEnMl
        {
            get { return this.quantiteLiquideEnMl; }
            set { quantiteLiquideEnMl = value; }
        }

        public double CapaciteMaxEnMl
        {
            get { return this.capaciteMaxEnMl; }
            set { capaciteMaxEnMl = value; }
        }

        // les deux premiers constructeurs appellent au final le classique, evite les redondances et les oublis
        public Bouteille(): this(1000, false, 1000)
        {               
        }

        public Bouteille(double _capaciteMaxEnMl): this(_capaciteMaxEnMl, false, _capaciteMaxEnMl)
        {            
        }

        // Constructeur classique
        public Bouteille(double _capaciteMaxEnMl, bool _estOuverte,  double _quantiteLiquideEnMl)
        {
            this.capaciteMaxEnMl = _capaciteMaxEnMl;
            this.estOuverte = _estOuverte;
            this.quantiteLiquideEnMl = _quantiteLiquideEnMl;
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
            if (!this.EstOuverte)
            {
                this.EstOuverte = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remplir(double _volume)
        {
            if (this.EstOuverte && _volume > 0 && this.QuantiteLiquideEnMl < this.CapaciteMaxEnMl)
            {
                if (this.QuantiteLiquideEnMl + _volume > this.CapaciteMaxEnMl) // Si le total quantité + volume est supérieur à la capacité
                {
                    this.QuantiteLiquideEnMl = this.CapaciteMaxEnMl; // on amène la quantité à la valeur de la capacité
                }
                else
                {
                    this.QuantiteLiquideEnMl += _volume; // sinon on fait l'addition comme prévu
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

            if (this.EstOuverte && _volume > 0 && this.QuantiteLiquideEnMl > 0)
            {
                if (this.QuantiteLiquideEnMl - _volume < 0) // même principe à l'inverse pour la soustraction, si elle est inférieure à 0
                {
                    this.QuantiteLiquideEnMl = 0; // on considère la bouteille comme vide
                }
                else
                {
                    this.QuantiteLiquideEnMl -= _volume; // sinon on soustrait comme prévu
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
            this.Remplir(this.CapaciteMaxEnMl);
            return true;
        }
        
        public bool ViderTout()
        {
            this.Vider(this.CapaciteMaxEnMl);
            return true;
        }
    }
}