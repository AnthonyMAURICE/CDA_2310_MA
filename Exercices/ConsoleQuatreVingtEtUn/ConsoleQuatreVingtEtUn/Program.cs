using QuatreVingtEtUn;
namespace ConsoleQuatreVingtEtUn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Partie partie1 = new Partie(3);
            while(partie1.Score > 0 && partie1.NbeManches > 0) // potentiellement, le check sur le score n'est pas essentiel, 10 par manche, -10 par perte
            {
                Console.WriteLine("Manches restantes : " + partie1.NbeManches);
                partie1.NouvelleManche();
                partie1.LancerManche();
                Console.WriteLine("Premier Lancer : " + partie1.GetDiceValues());
                while(!partie1.MancheTerminee() && !partie1.MancheGagnee())
                {
                    partie1.PreparerRelance();
                    Console.WriteLine("Lancer suivant : " + partie1.GetDiceValues());   
                }
                if (partie1.MancheGagnee())
                {
                    Console.WriteLine("Manche gagnée");
                }
                else
                {
                    Console.WriteLine("Manche perdue");
                }
                Console.WriteLine(partie1.ToString());
            }

            if (partie1.AGagneLaPartie())
            {
                Console.WriteLine("Partie gagnée !");
            }
            else
            {
                Console.WriteLine("Partie perdue !");
            }
        }
    }
}