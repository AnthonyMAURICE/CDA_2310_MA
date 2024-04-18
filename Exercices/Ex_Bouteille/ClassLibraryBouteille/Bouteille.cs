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
    public class Bouteille
    {
        private double quantityInML;
        private double capacityMaxInML;
        private bool isOpen;
        static double verifiedVolume;

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

        static double PositiveNUmber(double _volumeToVerify)
        {
            if(_volumeToVerify <= 0)
            {
                throw new NegativeNumberException("Volume inférieur ou égal à 0 !");
            }
            return _volumeToVerify;
        }

        // Pour les ajouts avec paramètres, vérification si la bouteille est ouverte et que ce paramètre (_volume) est supérieur à 0

        public bool AddQuantity(double _volume)
        {
            verifiedVolume = PositiveNUmber(_volume);
            try
            {
                if (this.isOpen)
                {
                    if (this.quantityInML + verifiedVolume > this.capacityMaxInML) // Si le total quantité + volume est supérieur à la capacité
                    {
                        this.quantityInML = this.capacityMaxInML; // on amène la quantité à la valeur de la capacité
                    }
                    else
                    {
                        this.quantityInML += verifiedVolume; // sinon on fait l'addition comme prévu
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

        public bool RemoveQuantity(double _volume)
        {
            verifiedVolume = PositiveNUmber(_volume);
            try
            {
                if (this.isOpen)
                {
                    if (this.quantityInML - verifiedVolume < 0) // même principe à l'inverse pour la soustraction, si elle est inférieure à 0
                    {
                        this.quantityInML = 0; // on considère la bouteille comme vide
                    }
                    else
                    {
                        this.quantityInML -= verifiedVolume; // sinon on soustrait comme prévu
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

        public bool FillBottle()
        {
            this.AddQuantity(this.capacityMaxInML);
            return true;
        }
        
        public bool EmptyBottle()
        {
            this.RemoveQuantity(this.capacityMaxInML);
            return true;
        }
    }
}
