using ClassPoint;

namespace AppPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();

            point1.SymetriqueAbscisse();
            Console.WriteLine(point1.ToString());
            point1.SymetriqueOrdonees();
            Console.WriteLine(point1.ToString());
            point1.SymetriqueOrigine();
            Console.WriteLine(point1.ToString());
            point1.Deplacer(15, 5);
            Console.WriteLine(point1.ToString());
            point1.Permuter();
            Console.WriteLine(point1.ToString());
        }
    }
}