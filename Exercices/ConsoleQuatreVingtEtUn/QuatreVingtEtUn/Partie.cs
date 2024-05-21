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

        public int Score { get => score; private set => score = value; }
        public int NbeManches { get => nbeManches; private set => nbeManches = value; }
        

        public Partie(int _nbeManche)
        {
            this.nbeManches = _nbeManche;
            this.Score = NbeManches * 10;
        }
        
        public bool AEncoreUneMancheAJouer()
        {
            return NbeManches > 0;
        }

        public bool AEncoreDesPointsAJouer()
        {
            return this.Score > 0;
        }
        public bool AGagneLaPartie()
        {
            return (!this.AEncoreUneMancheAJouer() && this.AEncoreDesPointsAJouer());
        }

        public void NouvelleManche()
        {
            this.mancheCourante = new Manche();
        }

        public override string ToString()
        {
            return "Score : " + this.Score;
        }

        public void LancerManche()
        {
            this.mancheCourante.Lancer();
        }

        public void LancerManche(bool _first, bool _second, bool _third)
        {
            this.mancheCourante.Lancer(_first, _second, _third);
        }

        public string GetDiceValues()
        {
            return this.mancheCourante.ToString();
        }

        private void Scoring(bool won)
        {
            this.Score += won ? 30 : -10;
        }

        public bool MancheGagnee()
        {
            this.Scoring(this.mancheCourante.MancheGagnee());
            return this.mancheCourante.MancheGagnee();
        }

        /*
         * Implémenter ici le code pour gérer les manches et appeler les fonctions des tours de chaque manche
         */
    }
}