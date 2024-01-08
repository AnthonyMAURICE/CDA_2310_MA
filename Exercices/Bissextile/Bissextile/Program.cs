namespace Bissextile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Entrez une année : ");
            int annee = int.Parse(Console.ReadLine());
            Bissextile(annee);
        }

        public static bool Bissextile(int _annee)
        {
            if ((_annee % 4) == 0 && ((_annee % 100) != 0 || (_annee % 400) == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}