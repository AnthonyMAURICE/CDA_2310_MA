namespace Exercice_fonctions
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string? saisie;
            string results = "";
            do
            {
                Console.WriteLine("Nombres de la suite de Fibonacci (entrez un nombre entier positif) : ");
                saisie = Console.ReadLine();
            } while (!int.TryParse(saisie, out number) || number <= 0); // contrôle que la saisie est conforme, sinon boucle sur l'input
            
            Console.WriteLine("Les " + number + " premiers nombres de la suite de Fibonacci sont : ");
            for (int i = 0; i < number; i++) // boucle autant de fois que de nombres de la suite que l'on souhaite afficher
            {
                results += FibonacciSecond(i).ToString() + "\n"; // appelle la fonction de calcul de la suite, convertie en chaine de caractères
            }
            Console.WriteLine(results);
        }

        public static SortedDictionary<int, long> memo = new(); // dictionnaire stockant la suite au fur et à mesure

        static long FibonacciSecond(int _number)
        {
            long result;
            if(_number <= 1) // si le nombre est inférieur ou égal à 1, retourne le nombre courant (ici 1)
            {
                return _number;
            }
            else if (memo.ContainsKey(_number)) // si le nombre est déjà présent (en comparant "_number" et les clés du dictionnaire) dans le dictionnaire, retourne celui-ci
            {
                return memo[_number];
            }
            else
            {
                result = FibonacciSecond(_number - 1) + FibonacciSecond(_number - 2); // sinon rappelle la fonction pour calculer le nombre courant
                memo.Add(_number, result); // et l'ajoute au dictionnaire avec _number comme clé
                return result; // et retourne le résultat
            }
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
    }
}