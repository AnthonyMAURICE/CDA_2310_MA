using ClassLepidoptere;


namespace ConsoleLepidoptere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterator = 0;
            Lepidoptere lepi = new Lepidoptere();
            do
            {
                Console.WriteLine(lepi.ToString());
                Console.WriteLine((lepi.SeDeplacer()) ? ("Peut se déplacer") : ("Ne peut pas se déplacer"));
                if (!lepi.SeMetamorphoser())
                {
                    Console.WriteLine("Ne peut évoluer davantage");
                    iterator++;
                }
                else
                {
                    Console.WriteLine("Peut encore évoluer");
                }
            } while (iterator < 2);

        }
    }
}