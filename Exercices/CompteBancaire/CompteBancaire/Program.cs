using ClassCompteBancaire;

namespace AppCompte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Compte compte1 = new Compte(1, "Capi", 500, -200);
            Compte compte2 = new Compte(2, "Taliste", 1500, -100);
            Compte compte3 = new Compte(17, "Riche", 12500, -500);
            /* 
            compte1.Crediter(-50);

            compte2.Debiter(150);

            Console.WriteLine(compte1.Solde);
            Console.WriteLine(compte2.Solde);

            //compte1.Transferer(compte2, 750);
            compte2.Transferer(compte1, 750);

            Console.WriteLine(compte1.Solde);
            Console.WriteLine(compte2.Solde);
            Console.WriteLine(compte1.ToString());
            Console.WriteLine(compte2.Comparer(compte1));
            Console.WriteLine(compte1.Comparer(compte2));
           */


            Banque banque1 = new Banque("International Bank of Money", "Iles Caïmans");
            Console.WriteLine("Nombres de comptes : " + banque1.NbeCompte);

            Console.WriteLine(banque1.ToString());

            banque1.AjouteCompte(compte1.Numero, compte1.Nom, compte1.Solde, compte1.DecouvertAutorise);
            banque1.AjouteCompte(compte2.Numero, compte2.Nom, compte2.Solde, compte2.DecouvertAutorise);
            banque1.AjouteCompte(compte3.Numero, compte3.Nom, compte3.Solde, compte3.DecouvertAutorise);

            Console.WriteLine("Compte ayant le solde le plus élevé : \n" + banque1.CompteSup());
            Console.WriteLine("Nombres de comptes : " + banque1.NbeCompte);

            Console.WriteLine(banque1.RendCompte(1));
            Console.WriteLine(banque1.RendCompte(2));
            Console.WriteLine(banque1.RendCompte(17));
        }
    }
}