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
                //for (int i = 0; i < partie1.mancheCourante.Length; i++) { }

                Console.WriteLine(partie1.ToString());
            }

        }
    }
}