namespace ClassLepidoptere
{
    public class Lepidoptere
    {
        private IStadeEvolution actualState;

        private Lepidoptere(IStadeEvolution _actualState)
        {
            this.actualState = _actualState;
        }

        public Lepidoptere(): this(Oeuf.Instancieur()){

        }

        public bool SeMetamorphoser()
        {
            if (this.actualState.GetType().Name == "Papillon")
            {
                return false;
            }
            else
            {
                this.actualState = this.actualState.SeMetamorphoser();
                return true;
            }
        }

        public bool SeDeplacer()
        {
            return this.actualState.SeDeplacer();
        }

        public override string ToString()
        {
            return "Lépidoptère au stade : " + this.actualState.ToString();
        }
    }
}