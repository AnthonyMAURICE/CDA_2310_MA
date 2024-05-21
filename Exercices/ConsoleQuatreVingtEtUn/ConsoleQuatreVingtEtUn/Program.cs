using QuatreVingtEtUn;
namespace ConsoleQuatreVingtEtUn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Partie partie1 = new Partie(3);
            partie1.NouvelleManche();
            partie1.LancerManche();
            Console.WriteLine(partie1.GetDiceValues());
            


        }
    }
}