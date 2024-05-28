using ClassLepidoptere;


namespace ConsoleLepidoptere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere lepi = new Lepidoptere();
            Console.WriteLine(lepi.ToString());
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.ToString());
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.ToString());
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.ToString());
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.ToString());
        }
    }
}