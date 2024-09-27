namespace LibraryCratesProd
{
    public class Crate
    {
        private bool isValid;
        private DateTime dateOfProduction;

        public Crate()
        {
            dateOfProduction = DateTime.Now;
        }

        public bool SetValidity()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 10);
            return random != 6;
        }

        public bool IsValid { get => isValid; }
        public DateTime DateOfProduction { get => dateOfProduction; }


    }
}
