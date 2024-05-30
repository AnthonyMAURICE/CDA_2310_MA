using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuatreVingtEtUn
{
    internal class Manche
    {
        private int nbeLancersRestant;
        private int nbeDesJoues;
        private readonly int nbeLancersMax = 3;
        internal List<De> des = new List<De>();

        public Manche()
        {
            this.nbeDesJoues = 3;
            this.nbeLancersRestant = nbeLancersMax;
        }

        public void Lancer(params bool[] desALancer) // méthode de lancer de dés
        {
            if (des.Count > 0) // pour le cas de ceux d'une même manche, si la liste n'est pas vide, ne relance que ceux sélectionnés par le joueur
            {
                for(int i = 0; i < desALancer.Length; i++)
                {
                    if (desALancer[i])
                    {
                        des[i].Jeter();
                    }
                }
            }
            else // sinon lance tous les dés, dans le cas d'un début de manche, et les ajoute à la liste
            {
                for(int i = 0; i < this.nbeDesJoues; i++)
                {
                    De de = new De();
                    de.Jeter();
                    des.Add(de);
                }
            }
            this.Trier();
            this.nbeLancersRestant--;
        }

        public bool MancheGagnee() // déclare la manche gagnée si 4, 2 et 1 se trouvent dans la liste
        {
            return (this.des.Any(x => x.Valeur == 4)) && (this.des.Any(x => x.Valeur == 2)) && (this.des.Any(x => x.Valeur == 1));
        }

        public bool EncoreUnLancer()
        {
            return this.nbeLancersRestant > 0;
        }
        
        private void Trier() // trie et inverse la liste de dés
        {
            this.des.Sort((x, y) => x.CompareTo(y));
            this.des.Reverse();
        }

        public override string ToString()
        {
            string diceResults = "Resultats : ";
            for(int i = 0; i < des.Count; i++)
            {
                diceResults += des[i].Valeur.ToString() + " ";
            }
            return diceResults;
        }
    }
}