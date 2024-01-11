namespace Exercice_Algo11_01_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 1, 8, 6, 14, 23, 25, 7, 42 };
            Console.WriteLine("Bienvenue dans le programme de calcul du tableau d'entier");
            Console.WriteLine("Moyenne des valeurs du tableau : " + Average(numbers)); // fonction de calcul de la moyenne
            PoweredGreater(numbers); // procédure qui affiche les valeurs demandées
        }

        public static double Average(int[] _numbers)
        {
            double average; 
            double sum = 0;
            for(int i = 0; i < _numbers.Length; i++) // boucle sur le tableau pour acquérir la somme des nombres de celui-ci
            {
                sum += _numbers[i];
            }
            average = sum / _numbers.Length; // calcul de la moyenne

            return average; // et retour de celle-ci
        }

        public static void PoweredGreater(int[] _numbers)
        {
            double poweredGreater;
            int temp = 0;

            for(int j = 0; j < _numbers.Length; j++) // boucle sur le tableau pour trouver la valeur la plus élevée
            {
                if(temp < _numbers[j]) // si la variable temporaire contient une valeur inférieure à celle trouvée dans le tableau
                {
                    temp = _numbers[j]; // elle en prend la valeur
                }
            }

            poweredGreater = Math.Pow(temp, 2); // puis est élevée au carré
            Console.WriteLine("Valeur la plus grande (" + temp + ") élevée au carré : " + poweredGreater);
        }
    }
}