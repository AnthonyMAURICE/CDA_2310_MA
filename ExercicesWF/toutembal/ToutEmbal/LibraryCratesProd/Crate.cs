namespace LibraryCratesProd
{
    public class Crate
    {
        private bool isValid;
        private DateTime dateOfProduction;

        public Crate(bool _isValid)
        {
            this.isValid = _isValid;
            dateOfProduction = DateTime.Now;
        }

        public bool IsValid { get => isValid; }
        public DateTime DateOfProduction { get => dateOfProduction; }


    }
}
