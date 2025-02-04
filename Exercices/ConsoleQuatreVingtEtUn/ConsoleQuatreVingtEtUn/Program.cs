using QuatreVingtEtUn;
namespace ConsoleQuatreVingtEtUn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Partie partie1 = new Partie(3);
            while(partie1.AEncoreDesPointsAJouer() && partie1.AEncoreUneMancheAJouer())
            {
                Console.WriteLine("Manches restantes : " + partie1.NbeManches);
                partie1.NouvelleManche();
                partie1.LancerManche();
                Console.WriteLine("Premier Lancer : " + partie1.GetDiceValues());
                while(!partie1.MancheTerminee() && !partie1.MancheGagnee())
                {
                    Console.WriteLine("Relancer le dé 1 ? ((O)ui), le reste sera considéré comme un refus");
                    input = Console.ReadLine().ToLower();
                    bool first = input == "o";
                    Console.WriteLine("Relancer le dé 2 ? ((O)ui), le reste sera considéré comme un refus");
                    input = Console.ReadLine().ToLower();
                    bool second = input == "o";
                    Console.WriteLine("Relancer le dé 3 ? ((O)ui), le reste sera considéré comme un refus");
                    input = Console.ReadLine().ToLower();
                    bool third = input == "o";
                    partie1.LancerManche(first, second, third);
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