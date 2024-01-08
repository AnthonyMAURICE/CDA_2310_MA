namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string chaineDeTest;
            Console.WriteLine("Saisissez la chaine de caractères à tester : ");
            chaineDeTest = Console.ReadLine();
            Console.WriteLine(IsPalindrome(chaineDeTest));
        }



        public static bool IsPalindrome(string _test)
        {
            _test = _test.ToLower().Replace(" ", ""); // force la chaine de caractères en minuscules et supprime les espaces
            if(_test.Length > 1) // contrôle si la chaine fait plus d'un caractère
            {
                int counter = _test.Length - 1; // compteur à partir de la fin de la chaine de caractères
                for(int i = 0; i < _test.Length; i++) // boucle sur la chaine de caractères
                {
                    if(_test[i] != _test[counter]) // si une non-correspondance est trouvée entre l'index "i" et "counter"
                    {
                        return false; // retourne "false" 
                    }
                    counter--; // décrémentation du compteur pour le passage suivant dans la boucle
                }
                return true; // si aucune non-correspondance est trouvée, retourne "true"
            }
            else // sinon retourne "false"
            {
                return false;
            }
        }
    }
}