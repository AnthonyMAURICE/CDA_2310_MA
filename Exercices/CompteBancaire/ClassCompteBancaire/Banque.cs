using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompteBancaire
{
    public class Banque
    {
        //private Compte[] comptesArray = new Compte[500];
        private int nbeCompte;
        private readonly string nom;
        private string ville;
        private List<Compte> Comptes = new List<Compte>();

        public int NbeCompte
        {
            get { return nbeCompte; }
            set { nbeCompte = value; }
        }

        public string Nom
        {
            get { return nom; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public Banque(string _nom, string _ville)
        {
            this.NbeCompte = 0;
            this.nom = _nom;
            this.ville = _ville;
        }

        private void AjouteCompte(Compte _compte)
        {
            this.Comptes.Add(_compte);
            this.nbeCompte++;
            
        }

        public void AjouteCompte(int _num, string _nom, double _solde, int _decouvertAutorise)
        {

            AjouteCompte(new Compte(_num, _nom, _solde, _decouvertAutorise));
        }

        public override string ToString()
        {
            return "Nom de la banque : " +  this.Nom + "\nVille : " + this.Ville;
        }

        public Compte CompteSup()
        {
            this.Comptes.Sort((x, y) => x.Solde.CompareTo(y.Solde));
            return this.Comptes[this.Comptes.Count - 1];
        }

        public Compte? RendCompte(int _num)
        {
            for(int i = 0; i < this.Comptes.Count; i++)
            {
                if (this.Comptes[i].Numero == _num)
                {
                    return this.Comptes[i];
                } 
            }
            return null;
        }
    }
}
