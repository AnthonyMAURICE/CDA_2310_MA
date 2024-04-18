using ClassLibraryBouteille;

namespace Ex_Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bouteille bouteille1 = new Bouteille();
            Bouteille bouteille2 = new Bouteille(2500, 2000, false);
            Bouteille bouteille3 = new Bouteille(1000, 200, false);

            Console.WriteLine("Est ouverte : " + bouteille2.GetOpen());
            Console.WriteLine("Peut s'ouvrir : " + bouteille2.Open());
            Console.WriteLine("Est ouverte : " + bouteille2.GetOpen());
            Console.WriteLine("Peut s'ouvrir : " + bouteille2.Open());
            Console.WriteLine("Est ouverte : " + bouteille2.GetOpen());
        }
    }  
}