using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        double capaciteMaxEnMl;
        double quantiteLiquideEnMl;
        bool estOuverte;

        public bool EstOuverte
        {
            get { return this.estOuverte; }
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

        public Bouteille(double _capaciteLiquideEnMl)
        {
            this.capaciteMaxEnMl = _capaciteLiquideEnMl;
            this.quantiteLiquideEnMl = _capaciteLiquideEnMl;
            this.estOuverte = false;
        }
        public Bouteille() : this(1000) { }
        public bool Fermer()
        {
            if (this.estOuverte)
            {
                this.estOuverte = false;
                return true;
            }
            return false;
        }
        public bool Ouvrir()
        {
            if (!this.estOuverte)
            {
                this.estOuverte = true;
                return true;
            }
            return false;
        }
        public bool Remplir(double _quantiteLiquideEnMl)
        {
            if (_quantiteLiquideEnMl < 0 //quantité donnée négative = échec
                || !this.estOuverte //bouteille fermée = échec
                || this.quantiteLiquideEnMl == this.capaciteMaxEnMl) //bouteille déjà pleine = échec
            { return false; }
            double total = _quantiteLiquideEnMl + this.quantiteLiquideEnMl;
            if (total > capaciteMaxEnMl) { this.quantiteLiquideEnMl = this.capaciteMaxEnMl; }
            else { this.quantiteLiquideEnMl = total; }
            return true;
        }
        public bool Vider(double _quantiteLiquideEnMl)
        {
            if (_quantiteLiquideEnMl < 0 //quantité donnée négative = échec
                || !this.estOuverte //bouteille fermée = échec
                || this.quantiteLiquideEnMl == 0) //bouteille déjà vide = échec
            { return false; }
            double total = this.quantiteLiquideEnMl - _quantiteLiquideEnMl;
            if (total < 0) { this.quantiteLiquideEnMl = 0; }
            else { this.quantiteLiquideEnMl = total; }
            return true;
        }
        public bool RemplirTout()
        {
            return Remplir(this.capaciteMaxEnMl);
        }
        public bool ViderTout()
        {
            return Vider(this.capaciteMaxEnMl);
        }
    }
}
