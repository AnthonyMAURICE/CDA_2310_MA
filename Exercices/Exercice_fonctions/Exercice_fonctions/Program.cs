namespace Exercice_fonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int iterator = 2;
            string saisie;
            
            Console.WriteLine("Nombre à entrer : ");
            saisie = Console.ReadLine();
            int.TryParse(saisie, out number);
            int[] suiteFibo = new int[number];
            saisie = Fibonacci(number, iterator, suiteFibo);
            Console.WriteLine(saisie);
        }


        static string Fibonacci(int number, int iterator, int[] suiteFibo)
        {

            if (iterator < number)
            {
                if(iterator < 2)
                {
                    suiteFibo[0] = 0;
                    suiteFibo[1] = 1;
                }
                else
                {
                    suiteFibo[iterator] = suiteFibo[iterator - 1] + suiteFibo[iterator - 2];
                }
                
                Fibonacci(number, ++iterator, suiteFibo);
            }
            
            return string.Join(" ", suiteFibo);
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