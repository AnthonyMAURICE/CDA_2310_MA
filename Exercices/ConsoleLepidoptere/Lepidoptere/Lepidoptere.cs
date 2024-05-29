namespace ClassLepidoptere
{
    public class Lepidoptere
    {
        private IStadeEvolution actualState;

        private Lepidoptere(IStadeEvolution _actualState)
        {
            this.actualState = _actualState;
        }

        public Lepidoptere(): this(Oeuf.Maker()){

        }

        public bool SeMetamorphoser()
        {
            bool canEvolve;
            if(this.actualState == this.actualState.SeMetamorphoser())
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
            return "Lepidoptere au stade : " + this.actualState.ToString();
        }
    }
}