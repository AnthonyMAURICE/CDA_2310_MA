namespace ExceptionBouteille
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }

        public static void PositiveNumber(double _volumeToVerify)
        {
            if (_volumeToVerify <= 0)
            {
                throw new NegativeNumberException("Volume inférieur ou égal à 0 !");
            }
        }
    }
}