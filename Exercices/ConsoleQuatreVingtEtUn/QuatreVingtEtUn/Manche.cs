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
        private readonly int nbeLancersMax = 3;
        internal De[] des = new De[3];
        internal De[] tempDe = new De[3];
        internal readonly int[] toFind = { 4, 2, 1 };

        public Manche()
        {
            this.nbeLancersRestant = nbeLancersMax;
        }

        public int NbeLancersMax { get => nbeLancersMax;}

        public int NbeLancersRestant { get => nbeLancersRestant;}

        public void Lancer(params bool[] desALancer)
        {
            if (des[0] != null && des[1] != null && des[2] != null)
            {
                for(int i = 0; i < desALancer.Length; i++)
                {
                    if (desALancer[i])
                    {
                        des[i].Jeter();
                    }
                }
            }
            else
            {
                for(int i = 0; i < 3; i++)
                {
                    De de = new De();
                    de.Jeter();
                    des[i] = de;
                }
                
            }
            this.Trier();
            this.nbeLancersRestant--;
        }

        public bool MancheGagnee()
        {
            return (this.des.Any(x => x.Valeur == 4)) && (this.des.Any(x => x.Valeur == 2)) && (this.des.Any(x => x.Valeur == 1));
        }

        public bool EncoreUnLancer()
        {
            return this.nbeLancersRestant > 0;
        }
        
        public void Trier()
        {
            Array.Sort(this.des);
            Array.Reverse(this.des);
        }

        public override string ToString()
        {
            string diceResults = "Resultats : ";
            for(int i = 0; i < des.Length; i++)
            {
                diceResults += des[i].Valeur.ToString() + " ";
            }
            return diceResults;
        }

        public Manche MancheEnCours()
        {
            return this;
        }
    }
}