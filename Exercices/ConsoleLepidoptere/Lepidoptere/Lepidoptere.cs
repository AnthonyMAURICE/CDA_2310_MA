namespace ClassLepidoptere
{
    public class Lepidoptere
    {
        private IStadeEvolution stadeCourant;

        private Lepidoptere(IStadeEvolution _stadeCourant)
        {
            this.stadeCourant = _stadeCourant;
        }

        public Lepidoptere(): this(Oeuf.Maker()){

        }

        public void SeMetamorphoser()
        {
            this.stadeCourant.SeMetamorphoser();
        }

        public bool SeDeplacer()
        {
            return this.stadeCourant.SeDeplacer();
        }

        public override string ToString()
        {
            return "Lepidoptere au stade : " + this.stadeCourant.ToString();
        }
    }
}