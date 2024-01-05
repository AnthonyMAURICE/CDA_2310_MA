namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;


        }

        public static bool IsPrime(int _testNumber)
        {
            if(_testNumber < 2)
            {
               return false;
            }
            else
            {
                for (int i = 2; i < _testNumber; i++)
                {
                    if (_testNumber % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}