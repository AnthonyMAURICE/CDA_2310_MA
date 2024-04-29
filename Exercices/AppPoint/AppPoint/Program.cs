using ClassPoint;

namespace AppPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(10, 10);
            Point point2 = new Point(5, 10);

            Console.WriteLine(point1.ToString());
            Point newPoint = point1.SymetrieAxeAbscisse();
            Console.WriteLine(newPoint.ToString());
            Point newPoint2 = point1.SymetrieAxeOrdonees();
            Console.WriteLine(newPoint2.ToString());
            Point newPoint3 = point1.SymetrieOrigine();
            Console.WriteLine(newPoint3.ToString());
            point1.Deplacer(15, 5);
            Console.WriteLine(point1.ToString());
            point2.Permuter();
            Console.WriteLine(point2.ToString());
        }
    }
}