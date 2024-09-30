namespace LibraryCratesProd
{
    public class Crate
    {
        private bool isValid;
        private readonly DateTime dateOfProduction;

        public Crate()
        {
            dateOfProduction = DateTime.Now;
        }

        public void SetValidity()
        {
            Random rnd = new();
            int random = rnd.Next(1, 10);
            this.isValid = (random != 6);
        }

        public bool IsValid { get => isValid; }
        public DateTime DateOfProduction { get => dateOfProduction; }


    }
}
