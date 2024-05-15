
namespace QuatreVingtEtUn
{
    internal class De : IComparable<De>
    {
        private readonly int nbeFaces;
        private int valeur;

        public De()
        {
            nbeFaces = 6;
        }

        public De(int nbeFaces)
        {
            this.nbeFaces = nbeFaces;
        }

        public int Valeur { get { return valeur;}}

        public int CompareTo(De? other)
        {
            throw new NotImplementedException();
        }

        public void Jeter()
        {
            
        }
    }
}