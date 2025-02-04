using ClassCompteBancaire;
namespace ClassBanque
{
    public class Banque
    {
        private int nbeCompte;
        private readonly string nom;
        private string ville;
        private List<Compte> comptes;

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
            this.nom = _nom;
            this.ville = _ville;
        }

        private void AjouteCompte(Compte _compte)
        {
            this.comptes.Add(_compte);
        }

        public void AjouteCompte(int _num, string _nom, double _solde, int _decouvertAutorise)
        {
            AjouteCompte(new Compte(_num, _nom, _solde, _decouvertAutorise));
        }

        

    }

    
}