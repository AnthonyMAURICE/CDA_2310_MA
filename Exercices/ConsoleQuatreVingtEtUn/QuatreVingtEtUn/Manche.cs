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
        private List<De> des = new List<De>();
        private static readonly List<int>toFind = new List<int>() {1, 2, 4};

        public Manche()
        {
            this.nbeLancersRestant = nbeLancersMax;
        }

        public List<De> Des { get { return this.des; } }

        public int NbeLancersMax { get => nbeLancersMax;}

        public int NbeLancersRestant { get => nbeLancersRestant;}

        public void Lancer(params bool[] desALancer)
        {
            if(des.Count != 0)
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
                    des.Add(de);
                }
            }
            this.nbeLancersRestant--;
            this.Trier();
        }

        public bool MancheGagnee()
        {
            bool win = true;
            this.Trier();
            for (int i = 0; i < des.Count; i++)
            {
                if (des[i].Valeur != toFind[i])
                {
                    win = false;
                }
            }
            return win;
        }

        public bool EncoreUnLancer()
        {
            return this.nbeLancersRestant > 0;
        }

        private void Trier()
        {
            this.des.Sort();
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

        public Manche MancheEnCours()
        {
            return this;
        }
    }
}
