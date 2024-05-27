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
        private static readonly int nbePointsManchePerdue = -10;
        private int nbeManches;
        private int score;
        internal Manche mancheCourante;

        public int NbeManches { get => nbeManches;}

        public Partie()
        {
            this.nbeManches = 3;
            this.score = 30;
        }

        public Partie(int _nbeManche)
        {
            this.nbeManches = _nbeManche;
            this.score = this.InitialScore();
        }
        
        private int InitialScore()
        {
            return this.nbeManches * 10;
        }

        public bool AEncoreUneMancheAJouer()
        {
            return this.nbeManches > 0;
        }

        public bool AEncoreDesPointsAJouer()
        {
            return this.score > 0;
        }
        public bool AGagneLaPartie() // détermine si la partie est gagnée, s'il n'y a plus de manches à jouer et que le score est positif
        {
            return (!this.AEncoreUneMancheAJouer() && this.AEncoreDesPointsAJouer());
        }

        public void NouvelleManche() // créé un nouvel objet Manche à chaque début de manche
        {
            this.mancheCourante = new Manche();
        }

        public override string ToString() // Retourne le score actuel
        {
            return "Score : " + this.score;
        }

        public void LancerManche() // correspond au premier lancer, de tous les dés
        {
            this.mancheCourante.Lancer();
        }

        public void LancerManche(bool _first, bool _second, bool _third) // seconde méthode de lancer, pour les suivants de la manche
        {
            this.mancheCourante.Lancer(_first, _second, _third); // 'true' et le dé est relancé, 'false' et il est conservé
        }

        public string GetDiceValues() // retourne la méthode ToString() de la classe Manche
        {
            return this.mancheCourante.ToString();
        }

        private void Scoring(bool won) // mets à jour le score
        {
            this.score += won ? nbePointsMancheGagnee : nbePointsManchePerdue;
        }

        public bool MancheTerminee() // contrôle si la manche est terminée et actualise le nombre de manches restantes ainsi que le score
        {
            bool finie = false; // initialisé à false...
            if(!this.mancheCourante.EncoreUnLancer() || this.MancheGagnee())
            {
                finie = true; // ...et ne passe à true que lorsque la manche est terminée, soit au dernier lancer, soit si la manche est gagnée
                this.Scoring(this.MancheGagnee());
                this.nbeManches--;
            } 
            return finie;
        }

        public bool MancheGagnee() // Appele la méthode de la classe Manche, pour déterminer si celle-ci est gagnée ou non
        {
            return this.mancheCourante.MancheGagnee();
        }
    }
}