using QuatreVingtEtUn;
namespace ConsoleQuatreVingtEtUn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Partie partie1 = new Partie(3);

            while(partie1.Score > 0 && partie1.NbeManches > 0)
            {
                partie1.NouvelleManche();
                partie1.LancerManche();
                Console.WriteLine(partie1.GetDiceValues());



                if (partie1.MancheGagnee())
                {
                    Console.WriteLine("Manche gagnée");
                    partie1.Scoring(true);
                }
                else
                {
                    Console.WriteLine("Manche perdue");
                    partie1.Scoring(false);

                }
                Console.WriteLine(partie1.ToString());
            }
        }
    }
}