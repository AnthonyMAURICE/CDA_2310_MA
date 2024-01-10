namespace Exercice_fonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2, number;
            Console.WriteLine("Entrez un nombre positif : ");
            string temp = Console.ReadLine();
            try
            {
                number = int.Parse(temp);
                string suite = "";
                Console.WriteLine(Fibonacci(number, i, suite));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        
        public static string Fibonacci(int _number, int i, string _suite)
        {
            
            

            if (i < _number)
            {
                Fibonacci(_number, ++i, _suite);
            }
            return _suite;
        }

    }
}