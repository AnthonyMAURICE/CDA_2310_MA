using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// versions avec gestion de l'exception concernant le volume pour les méthodes d'ajout et de retrait
namespace ClassLibraryBouteille
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }

    class OpenenedBottleException : Exception
    {
        public OpenenedBottleException(string message) : base(message) { }
    } 

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

        // méthode qui vérifie que le volume soit supérieur à 0, sinon envoit une exception
        static void PositiveNumber(double _volumeToVerify)
        {
            if (_volumeToVerify <= 0)
            {
                throw new NegativeNumberException("Volume inférieur ou égal à 0 !");
            }
        }

        static void OpenedBottle(bool _open)
        {
            if (!_open)
            {
                throw new OpenenedBottleException("Bouteille Fermée.");
            }
        }

        public bool Remplir(double _volume)
        {
            try
            {
                OpenedBottle(this.EstOuverte);
                PositiveNumber(_volume);
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
        }

        public bool Vider(double _volume)
        {
            try
            {
                OpenedBottle(this.EstOuverte);
                PositiveNumber(_volume);
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
