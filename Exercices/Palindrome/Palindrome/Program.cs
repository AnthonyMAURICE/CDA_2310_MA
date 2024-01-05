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
            _test = _test.ToLower().Replace(" ", "");
            if(_test.Length > 0)
            {
                int counter = _test.Length - 1;
                for(int i = 0; i < _test.Length; i++)
                {
                    if(_test[i] != _test[counter])
                    {
                        return false;   
                    }
                    counter--;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}