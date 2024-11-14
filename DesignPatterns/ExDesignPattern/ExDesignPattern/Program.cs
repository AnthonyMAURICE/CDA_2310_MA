using ClassLibrary;

namespace ExDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Digit(33), new Digit(33));
            int resultat1 = exp1.EvaluateItself();

            Expression exp2 = new Addition(new Digit(33), new Substraction(new Digit(33), new Digit(11)));
            int resultat2 = exp2.EvaluateItself();

            Console.WriteLine(exp1.Format() + " = " + resultat1);
            Console.WriteLine(exp2.Format() + " = " + resultat2);

        }
    }
}
