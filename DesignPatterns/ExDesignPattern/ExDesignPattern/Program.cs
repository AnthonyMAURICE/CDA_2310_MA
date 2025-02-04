using ClassLibrary;

namespace ExDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Integer(33), new Integer(33));
            int resultat1 = exp1.EvaluateItself();

            Expression exp2 = new Addition(new Integer(33), new Substraction(new Integer(33), new Integer(11)));
            int resultat2 = exp2.EvaluateItself();

            Console.WriteLine(exp1.Format() + " = " + resultat1);
            Console.WriteLine(exp2.Format() + " = " + resultat2);

        }
    }
}
