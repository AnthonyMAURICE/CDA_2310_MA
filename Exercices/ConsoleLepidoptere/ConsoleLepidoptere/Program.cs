using ClassLepidoptere;


namespace ConsoleLepidoptere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere lepi = new Lepidoptere();
            Console.WriteLine(lepi.ToString());
            Console.WriteLine("Peut se déplacer : " + lepi.SeDeplacer());
            Console.WriteLine("Peut évoluer : " + lepi.SeMetamorphoser());
            Console.WriteLine(lepi.ToString());
            Console.WriteLine("Peut se déplacer : " + lepi.SeDeplacer());
            Console.WriteLine("Peut évoluer : " + lepi.SeMetamorphoser());
            Console.WriteLine(lepi.ToString());
            Console.WriteLine("Peut se déplacer : " + lepi.SeDeplacer());
            Console.WriteLine("Peut évoluer : " + lepi.SeMetamorphoser());
            Console.WriteLine(lepi.ToString());
            Console.WriteLine("Peut se déplacer : " + lepi.SeDeplacer());
            Console.WriteLine("Peut évoluer : " + lepi.SeMetamorphoser());
            Console.WriteLine(lepi.ToString());
            Console.WriteLine("Peut se déplacer : " + lepi.SeDeplacer());
            Console.WriteLine("Peut évoluer : " + lepi.SeMetamorphoser());

        }
    }
}