using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatreVingtEtUn
{
    public class Manche
    {
        private int nbeLancersRestant;
        private readonly int nbeLancersMax;
        private List<De>des = new List<De>();
        private static List<int>toFind = new List<int>() {1, 2, 4};

        public Manche()
        {
            nbeLancersRestant = 3;
            nbeLancersMax = 3;
        }


        public void Lancer(params int[] desALancer)
        {
            if(des.Count != 0)
            {
                foreach(int relance in desALancer)
                {
                    des[relance-1].Jeter();
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
            des.Sort();
        }

        public bool MancheGagnee()
        {
            bool win = true;
            if (nbeLancersRestant == 0)
            {
                win = false;
            }
            else
            {
                for(int i = 0; i < des.Count; i++)
                {
                    if (des[i].Valeur != toFind[i])
                    {
                        win = false;
                    }
                }
            }
            return win;
        }
    }
}
