namespace Exercice_Barnabe
{
    public class Program
    {
        static void Main(string[] args)
        {
            double somme;

            Console.WriteLine("De combien d'argent dispose Barnabé ?");
            somme = double.Parse(Console.ReadLine());
            Console.WriteLine(Courses(somme) > 0 ? "Avec " + somme + ", Barbané a fait ses courses dans " + Courses(somme) + " magasins." : "Barnabé n'a pas l'argent suffisant pour faire ses courses.");
        }


        public static int Courses(double _somme)
        {
            int magasins = 0;
            
            if (_somme > 1) // contrôle que Barnabé a l'argent nécéssaire
            {
                while (_somme > 2) // boucle sur les cycles de courses de Barnabé, incrémentant à chaque fois le nombre de magasins visités
                {
                    magasins++;
                    _somme = _somme / 2 - 1; // calcul des "paiements" de Barnabé, soit la moitié de sa somme + 1 (ici en soustraction)
                }
                magasins++; // correspond à la dépense du solde s'il lui reste 2 ou moins
            }
            else
            {
                return 0; // retourne 0 s'il n'a pas d'argent
            }

            return magasins; // sinon retourne le nombre de magasins
        }

        
    }

}