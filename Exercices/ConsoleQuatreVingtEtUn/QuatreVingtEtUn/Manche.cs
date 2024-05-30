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
        internal List<De> des;

        public Manche()
        {
            this.nbeDesJoues = 3;
            this.nbeLancersRestant = nbeLancersMax;
            des = new List<De>();
        }

        public void Lancer()
        {
            for (int i = 0; i < this.nbeDesJoues; i++)
            {
                De de = new De();
                de.Jeter();
                des.Add(de);
            }
            this.Trier();
            this.nbeLancersRestant--;
        }

        public void Lancer(params bool[] desALancer) // méthode de lancer de dés
        {
            for(int i = 0; i < desALancer.Length; i++)
            {
                if (desALancer[i])
                {
                    des[i].Jeter();
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
            this.des.Sort();
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