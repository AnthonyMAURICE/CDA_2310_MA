using ClassFraction;
using ClassFraction.Exceptions;

namespace AppFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(12, 7);
            Fraction fraction2 = new Fraction(9, 1);
            Fraction fraction3 = new Fraction(-22, 6);
            Fraction fraction4 = new Fraction(1, 9);
            Fraction fraction5 = new Fraction(120, -150);

            Console.WriteLine(fraction1.ToString());
            Console.WriteLine(fraction2.ToString());
            Console.WriteLine(fraction3.ToString());
            
            //fraction1.Oppose();
            fraction2.Inverse();

            Console.WriteLine(fraction1.ToString());
            Console.WriteLine(fraction2.ToString());

            Console.WriteLine(fraction2.SuperieureA(fraction1));
            Console.WriteLine(fraction2.EgaleA(fraction1));
            Console.WriteLine(fraction2.EgaleA(fraction4));
            Console.WriteLine(fraction5.ToString());

            Fraction fraction6 = fraction1.Plus(fraction2);
            Console.WriteLine(fraction6.ToString());

            Fraction fraction7 = fraction1.Moins(fraction2);
            Console.WriteLine(fraction7.ToString());

        }
    }
}