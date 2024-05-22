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

        public override string ToString() // Retourne le score actuel
        {
            return "Score : " + this.Score;
        }

        public void LancerManche() // correspond au premier lancer, de tous les dés
        {
            this.mancheCourante.Lancer();
        }

        private void LancerManche(bool _first, bool _second, bool _third) // seconde méthode de lancer, pour les suivants de la manche
        {
            this.mancheCourante.Lancer(_first, _second, _third);
        }

        public void PreparerRelance() // méthode de séléction des dés à relancer, avec détection des 1, 2 et 4
        {
            bool first = true;
            bool second = true;
            bool third = true;
            //si les booléens sont à true, le dé sera relancé, sinon il sera conservé
            if(this.mancheCourante.Des.Any(x => x.Valeur == 1))
            {
                this.mancheCourante.Des[0].Valeur = 1;
                first = false;
            }
            if (this.mancheCourante.Des.Any(x => x.Valeur == 2))
            {
                this.mancheCourante.Des[1].Valeur = 2;
                second = false;
            }
            if (this.mancheCourante.Des.Any(x => x.Valeur == 4))
            {
                this.mancheCourante.Des[2].Valeur = 4;
                third = false;
            }

            this.LancerManche(first, second, third);
        }

        public string GetDiceValues() // retourne la méthode ToString() de la classe Manche
        {
            return this.mancheCourante.ToString();
        }

        public void Scoring(bool won) // mets à jour le score
        {
            this.score += won ? 30 : -10;
        }

        public bool MancheTerminee()
        {
            bool finie = false;
            if(!this.mancheCourante.EncoreUnLancer() || this.mancheCourante.MancheGagnee())
            {
                finie = true;
                this.nbeManches--;
            }
            return finie;
        }

        public bool MancheGagnee()
        {
            return this.mancheCourante.MancheGagnee();
        }
    }
}