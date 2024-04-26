using ClassCompteBancaire;

namespace AppCompte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte type = new Compte();
            Compte compte1 = new Compte(1, "Capi", 500, -200);
            Compte compte2 = new Compte(2, "Taliste", 1500, -100);

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
        }
    }
}