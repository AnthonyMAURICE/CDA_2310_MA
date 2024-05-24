namespace Lepidoptere
{
    public class Lepidoptere
    {
        private IStadeEvolution stadeCourant;

        public Lepidoptere()
        {

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