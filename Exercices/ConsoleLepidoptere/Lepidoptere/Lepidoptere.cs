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
            bool canEvolve;
            if(this.actualState.ToString() == "Papillon")
            {
                canEvolve = false;
            }
            else
            {
                this.actualState = this.actualState.SeMetamorphoser();
                canEvolve = true;
            }
            return canEvolve;
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