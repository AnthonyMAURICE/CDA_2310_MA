namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        public static bool IsPrime(int _testNumber)
        {
            bool isPrime;
            int i = 2;
            if(_testNumber < 2)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
                while(i < _testNumber && isPrime)
                {
                    if (_testNumber % i == 0)
                    {
                        isPrime = false;
                    }
                    i++;
                }  
            }
            return isPrime;
        }
    }
}