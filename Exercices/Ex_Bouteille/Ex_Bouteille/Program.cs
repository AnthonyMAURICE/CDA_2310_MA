using ClassLibraryBouteille;

namespace Ex_Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bouteille bouteille1 = new Bouteille();
            
            Bouteille bouteille3 = new Bouteille(1000);

            bouteille3.Ouvrir();
            bouteille3.Remplir(200);
            */
            Bouteille2 test = new Bouteille2(1000);
            test.QuantiteLiquideEnMl = 500;
            // test.EstOuverte = true;

            test.Remplir(200);

        }
    }  
}