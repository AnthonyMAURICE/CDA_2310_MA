using System.Collections;
using ClassFraction.Exceptions;

namespace ClassFraction
{
    public class Fraction : IComparable<Fraction>
    {
        private int numerateur;
        private int denominateur;

        public int Numerateur { get => this.numerateur; private set => this.numerateur = value; }
        public int Denominateur { get => this.denominateur; private set => this.denominateur = value; }

        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }

        public Fraction (Fraction _fraction)
        {
            this.numerateur = _fraction.numerateur;
            this.denominateur = _fraction.denominateur;
        }

        public Fraction(int _numerateur) : this(_numerateur, 1)
        {
            this.numerateur = _numerateur;
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        public override string ToString()
        {
            return this.numerateur + "/" + this.denominateur;
        }

        public void Oppose()
        {
            this.numerateur *= -1;
        }

        public void Inverse()
        {   
            (this.numerateur, this.denominateur) = (this.denominateur, this.numerateur);  
        }

        public int CompareTo(Fraction? other)
        {
            Fraction first = this;
            double calculatedFirst = first.Calcul();
            double calculatedOther = other.Calcul();
            return calculatedFirst.CompareTo(calculatedOther);
        }

        private double Calcul()
        {
            return ((double)numerateur) / denominateur;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1.CompareTo(f2) == -1;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return (f1.CompareTo(f2) == 1);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return (f1.CompareTo(f2) == 0);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1.CompareTo(f2) != 0);
        }

        public bool SuperieureA(Fraction _other)
        {
            return this > _other;
        }

        public bool EgaleA(Fraction _other)
        {
            return this == _other;
        }

        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }

        private void Reduire()
        {
            int pgcd = this.GetPgcd();
            (this.numerateur, this.denominateur) = (this.numerateur / pgcd, this.denominateur / pgcd);
            if(this.denominateur < 0) // condition pour la gestion du signe de la fraction
            {
                this.numerateur *= -1;
                this.denominateur *= -1;
            }
        }

        private static Fraction FractionCalcul(int _newnumerateur, int _newdenominateur)
        {
            return new Fraction(_newnumerateur, _newdenominateur);
        }

        public Fraction Plus(Fraction _autreFraction)
        {
            return FractionCalcul(this.numerateur * _autreFraction.denominateur + _autreFraction.numerateur * this.denominateur, this.denominateur * _autreFraction.denominateur);
        }

        public Fraction Moins(Fraction _autreFraction)
        {
            return FractionCalcul(this.numerateur * _autreFraction.denominateur - _autreFraction.numerateur * this.denominateur, this.denominateur * _autreFraction.denominateur);
        }

        public Fraction Multiplie(Fraction _autreFraction)
        {
            return FractionCalcul(this.numerateur * _autreFraction.numerateur, this.denominateur * _autreFraction.denominateur);
        }

        public Fraction Divise(Fraction _autreFraction)
        {
            Fraction fraction = new Fraction(_autreFraction);
            fraction.Inverse();
            return this.Multiplie(fraction);
        }
    }  
}