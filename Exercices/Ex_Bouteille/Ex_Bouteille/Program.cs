using ClassLibraryBouteille;
using ClassLibraryBouteille2;

namespace Ex_Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bouteille2 test = new Bouteille2(1000);
           
            test.EstOuverte = true;
            test.QuantiteLiquideEnMl = 0;
            test.Vider(250);
            test.RemplirTout();
            test.Remplir(250);

        }
    }  
}