using ClassLibraryBouteille;

namespace Ex_Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bouteille bouteille1 = new Bouteille();
            
            Bouteille bouteille3 = new Bouteille(1000, 200, false);

            bouteille3.Ouvrir();
            bouteille3.Remplir(200);
        }
    }  
}