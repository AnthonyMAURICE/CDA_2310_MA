using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }

    public class Bouteille2
    {
        private double quantiteLiquideEnMl;
        private double capaciteMaxEnMl;
        private bool estOuverte;

        public Bouteille2()
        {
            this.quantiteLiquideEnMl = 1500;
            this.capaciteMaxEnMl = 1500;
            this.estOuverte = false;
        }

        public Bouteille2(double _capaciteMaxEnMl, double _quantiteLiquideEnMl, bool _estOuverte)
        {
            this.quantiteLiquideEnMl = _quantiteLiquideEnMl;
            this.capaciteMaxEnMl = _capaciteMaxEnMl;
            this.estOuverte = _estOuverte;
        }

        public bool GetOpen()
        {
            return this.estOuverte;
        }

        public double GetquantiteLiquideEnMl()
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

        // méthode qui vérifie que le volume soit supérieur à 0, sinon envoit une exception
        static void PositiveNUmber(double _volumeToVerify)
        {
            if (_volumeToVerify <= 0)
            {
                throw new NegativeNumberException("Volume inférieur ou égal à 0 !");
            }
        }

        public bool Remplir(double _volume)
        {
            try
            {
                PositiveNUmber(_volume);
                if (this.estOuverte)
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
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }

        }

        public bool Vider(double _volume)
        {

            try
            {
                PositiveNUmber(_volume);
                if (this.estOuverte)
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
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
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
