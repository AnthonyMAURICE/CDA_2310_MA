using ClassCompteBancaire.ExceptionsCompte;

namespace ClassCompteBancaire
{
    public class Compte
    {
        private readonly int numero;
        private readonly string nom;
        private double solde;
        private int decouvertAutorise;

        public int Numero
        {
            get { return numero; } 
        }

        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public int DecouvertAutorise
        {
            get { return decouvertAutorise; }
            set { decouvertAutorise = value; }
        }

        public Compte()
        {
            this.numero = 0;
            this.nom = "Lambda";
            this.solde = 10;
            this.decouvertAutorise = -50;
        }

        public Compte(int _numero, string _nom, double _solde, int _decouvertAutorise)
        {
            this.numero = _numero;
            this.nom = _nom;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }

        public override string ToString()
        {
            return "Numéro : " + this.Numero + ", Nom : " + this.Nom + ", Solde : " + this.Solde + ", Découvert autorisé : " + this.DecouvertAutorise;
        }

        private void Operation(double _montant)
        {
            this.Solde += _montant;
        }

        public bool Crediter(double _montant)
        {
            try
            {
                ExceptionOverDecouvert.DecouvertDepasse(_montant, this.Solde, this.DecouvertAutorise);
                ExceptionNegative.CheckNegative(_montant);
                this.Operation(_montant);
                return true;
            }
            catch(ExceptionOverDecouvert ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
            catch(ExceptionNegative ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        public bool Debiter(double _montant)
        {
            try
            {
                if(_montant > 0)
                {
                    _montant *= -1;
                }
                ExceptionOverDecouvert.DecouvertDepasse(_montant, this.Solde, this.DecouvertAutorise);
                this.Operation(_montant);
                return true;
            }
            catch (ExceptionOverDecouvert ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
        }

        public bool Transferer(Compte _compte2, double _montant)
        {
            try
            {
                ExceptionOverDecouvert.DecouvertDepasse(_montant, this.Solde, this.DecouvertAutorise);
                this.Debiter(_montant);
                if (this.Debiter(_montant))
                {
                    _compte2.Crediter(_montant);
                }   
            }
            catch(ExceptionOverDecouvert ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                return false;
            }
  
            return true;
        }

        public string Comparer(Compte _compte2)
        {
            if(this.Solde > _compte2.Solde)
            {
                return "Supérieur";
            }
            else
            {
                return "Inférieur";
            }
        }
    }
}