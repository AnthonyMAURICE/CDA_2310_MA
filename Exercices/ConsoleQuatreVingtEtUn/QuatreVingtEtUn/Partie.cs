using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatreVingtEtUn
{
    public class Partie
    {
        private static readonly int nbePointsMancheGagnee = 30;
        private static readonly int nbePointsManchePerdue = 10;
        private int nbeManches;
        private int score;
        internal Manche mancheCourante;


        public Partie(int _nbeManche)
        {
            this.nbeManches = _nbeManche;
            this.score = nbeManches * 10;
        }
        
        public bool AEncoreUneMancheAJouer()
        {
            return nbeManches > 0;
        }

        public bool AEncoreDesPointsAJouer()
        {
            return this.score > 0;
        }
        public bool AGagneLaPartie()
        {
            return (!this.AEncoreUneMancheAJouer() && this.AEncoreDesPointsAJouer());
        }

        public void NouvelleManche()
        {
            mancheCourante = new Manche();
        }

        public override string ToString()
        {
            return "Score : " + this.score;
        }

        public void LancerManche()
        {
            mancheCourante.Lancer();
        }

        public void LancerManche(bool _first, bool _second, bool _third)
        {
            mancheCourante.Lancer(_first, _second, _third);
        }

        public string GetDiceValues()
        {
            string values = "Résultats : ";
            for(int i = 0; i < this.mancheCourante.Des.Count; i++)
            {
                values += this.mancheCourante.Des[i].Valeur + ", ";
            }
            return values;
        }

    }


}
