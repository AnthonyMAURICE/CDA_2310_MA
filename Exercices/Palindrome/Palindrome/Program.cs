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
            bool palin = true;
            _test = _test.ToLower().Replace(" ", ""); // force la chaine de caractères en minuscules et supprime les espaces
            if(_test.Length > 1) // contrôle si la chaine fait plus d'un caractère
            {
                int i = 0;
                int j = _test.Length - 1;
                while(i < _test.Length / 2 && palin == true) // boucle sur la moitié de la chaine de caractères testée, tant que le booléen "palin" est à true
                {
                    if (!_test[i].Equals(_test[j])) // si non-correspondance trouvée, passe "palin" à false
                    {
                        palin = false;
                    }
                    i++;
                    j--;
                }
                return palin; // si aucune non-correspondance est trouvée, retourne "true"
            }
            else // sinon retourne "false"
            {
                palin =false;
                return palin;
            }
        }
    }
}