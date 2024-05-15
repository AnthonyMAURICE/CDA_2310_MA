using System.Collections;
using ClassFraction.Exceptions;

namespace ClassFraction
{
    public class Fraction : IComparable<Fraction>
    {
        private int numerateur;
        private int denominateur;

        public int Numerateur { get => numerateur; set => numerateur = value; }
        public int Denominateur { get => denominateur; set => denominateur = value; }

        public Fraction()
        {
            this.Numerateur = 0;
            this.Denominateur = 1;
        }

        public Fraction (Fraction _fraction)
        {
            this.Numerateur = _fraction.Numerateur;
            this.Denominateur = _fraction.Denominateur;
        }

        public Fraction(int _numerateur) : this(_numerateur, 1)
        {
            this.Numerateur = _numerateur;
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            this.Numerateur = _numerateur;
            this.Denominateur = _denominateur;
        }

        public override string ToString()
        {
            this.Reduire();
            double val = (double)this.Numerateur / (double)this.Denominateur;
            bool isInteger = (double)((int)val) == (double)val;
            return isInteger ? val.ToString() : this.Numerateur + "/" + this.Denominateur;
        }

        public void Oppose()
        {
            this.Numerateur *= -1;
        }

        public void Inverse()
        {   
            (this.Numerateur, this.Denominateur) = (this.Denominateur, this.Numerateur);  
        }

        public int CompareTo(Fraction? other)
        {
            Fraction monThis = this;
            double calculatedMonThis = Calcul(monThis.Numerateur, monThis.Denominateur);
            double calculatedOther = Calcul(other.Numerateur, other.Denominateur);
            return calculatedMonThis.CompareTo(calculatedOther);
        }

        private static double Calcul(int _first, int _second)
        {
            return ((double)_first) / _second;
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
            int a = this.Numerateur;
            int b = this.Denominateur;
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

        private Fraction Reduire()
        {
            (this.Numerateur, this.Denominateur) = (this.Numerateur / this.GetPgcd(), this.Denominateur / this.GetPgcd());
            if(this.Denominateur < 0)
            {
                this.Numerateur *= -1;
                this.Denominateur *= -1;
            }
            return this;    
        }

        private static Fraction FractionCalcul(int _newnumerateur, int _newdenominateur)
        {
            return new Fraction(_newnumerateur, _newdenominateur).Reduire();
        }

        public Fraction Plus(Fraction _autreFraction)
        {
            return FractionCalcul(this.Numerateur * _autreFraction.Denominateur + _autreFraction.Numerateur * this.Denominateur, this.Denominateur * _autreFraction.Denominateur);
        }

        public Fraction Moins(Fraction _autreFraction)
        {
            return FractionCalcul(this.Numerateur * _autreFraction.Denominateur - _autreFraction.Numerateur * this.Denominateur, this.Denominateur * _autreFraction.Denominateur);
        }

        public Fraction Multiplie(Fraction _autreFraction)
        {
            return FractionCalcul(this.Numerateur * _autreFraction.Numerateur, this.Denominateur * _autreFraction.Denominateur);
        }

        public Fraction Divise(Fraction _autreFraction)
        {
            Fraction fraction = new Fraction(_autreFraction);
            fraction.Inverse();
            return this.Multiplie(fraction);
        }
    }  
}