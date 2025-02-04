using ExceptionBouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// versions avec gestion des exceptions concernant le volume pour les méthodes d'ajout et de retrait ainsi que l'ouverture de la bouteille
namespace ClassLibraryBouteille2
{

    public class Bouteille2
    {
        private double quantiteLiquideEnMl;
        private double capaciteMaxEnMl;
        private bool estOuverte;

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

        public Bouteille2() : this(1000, false, 1000)
        {
        }

        public Bouteille2(double _capaciteMaxEnMl) : this(_capaciteMaxEnMl, false, _capaciteMaxEnMl)
        {
        }

        // Constructeur classique
        public Bouteille2(double _capaciteMaxEnMl, bool _estOuverte, double _quantiteLiquideEnMl)
        {
            this.capaciteMaxEnMl = _capaciteMaxEnMl;
            this.estOuverte = _estOuverte;
            this.quantiteLiquideEnMl = _quantiteLiquideEnMl;
        }

        public bool Fermer()
        {
            if (this.EstOuverte)
            {
                this.EstOuverte = false;
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
            try
            {
                OpenenedBottleException.OpenedBottle(this.EstOuverte);
                FullBottleException.FullBottle(this.QuantiteLiquideEnMl, this.CapaciteMaxEnMl);
                NegativeNumberException.PositiveNumber(_volume);
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
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
            catch (OpenenedBottleException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
            catch(FullBottleException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        public bool Vider(double _volume)
        {
            try
            {
                OpenenedBottleException.OpenedBottle(this.EstOuverte);
                EmptyBottleException.EmptyBottle(this.QuantiteLiquideEnMl);
                NegativeNumberException.PositiveNumber(_volume);
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
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
            catch (OpenenedBottleException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
            catch(EmptyBottleException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        public bool RemplirTout()
        {
            return this.Remplir(this.CapaciteMaxEnMl - this.QuantiteLiquideEnMl);
        }

        public bool ViderTout()
        {
            return this.Vider(this.QuantiteLiquideEnMl);
        }
    }
}