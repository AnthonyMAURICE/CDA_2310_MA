
using System;

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

        public int Valeur { get => valeur; set => valeur = value; }

        public int CompareTo(De? other)
        {
            return this.Valeur.CompareTo(other.Valeur);
        }

        public void Jeter()
        {
            this.Valeur = Alea.Instance().Nouveau(1, this.nbeFaces);
        }
    }
}