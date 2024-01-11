namespace Exercice_fonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string? saisie;
            string result = "";
            do
            {
                Console.WriteLine("Nombres de la suite de Fibonacci (entrez un nombre entier positif) : ");
                saisie = Console.ReadLine();
            } while (!int.TryParse(saisie, out number) || number <= 0);
            
            Console.WriteLine("Les " + number + " premiers nombres de la suite de Fibonacci sont : ");
            for (int i = 0; i < number; i++)
            {
                result += (FibonacciSecond(i).ToString() + "\n");
            }
            Console.WriteLine(result);
        }

        static long FibonacciSecond(int _number)
        {
            if (_number < 2)
            {
                return 1;
            }
            return (FibonacciSecond(_number - 1) + FibonacciSecond(_number - 2));
        }
        
        /*
        static string Fibonacci(int number)
        {
            int i = 0;
            long nombreSuivant;
            long nombrePrecedant = 0;
            long nombreCourant = 1;
            //Console.WriteLine("Entrez un nombre positif : ");
            //string temp = Console.ReadLine();
            //int.TryParse(temp, out number);
            string suite = "";

            if(number > 2)
            {
                while(i < number)
                {
                    nombreSuivant = nombrePrecedant + nombreCourant;
                    suite += "\n" + nombreSuivant;
                    nombrePrecedant = nombreCourant;
                    nombreCourant = nombreSuivant;
                    i++;
                }
            }
            else
            {
                number = 2;
            }

            return "Les " + number + " premiers nombres sont :\n" + suite;
            
        }*/
        /*
        public static void Fibonacci(int _number, int i, string _suite)
        {
            
        }
        */

        
    }
    
}