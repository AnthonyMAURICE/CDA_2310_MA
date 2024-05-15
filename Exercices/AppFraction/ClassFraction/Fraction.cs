using System.Collections;
using ClassFraction.Exceptions;

namespace ClassFraction
{
    public class Fraction : IComparable<Fraction>
    {
        private int numerateur;
        private int denominateur;

        public int GetNumerateur()
        {
            return numerateur;
        }

        private void SetNumerateur(int value)
        {
            numerateur = value;
        }

        public int GetDenominateur()
        {
            return denominateur;
        }

        private void SetDenominateur(int value)
        {
            denominateur = value;
        }

        public Fraction()
        {
            this.SetNumerateur(0);
            this.SetDenominateur(1);
        }

        public Fraction (Fraction _fraction)
        {
            this.SetNumerateur(_fraction.GetNumerateur());
            this.SetDenominateur(_fraction.GetDenominateur());
        }

        public Fraction(int _numerateur) : this(_numerateur, 1)
        {
            this.SetNumerateur(_numerateur);
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            this.SetNumerateur(_numerateur);
            this.SetDenominateur(_denominateur);
        }

        public override string ToString()
        {
            this.Reduire();
            double val = (double)this.GetNumerateur() / (double)this.GetDenominateur();
            bool isInteger = (double)((int)val) == (double)val;
            return isInteger ? val.ToString() : this.GetNumerateur() + "/" + this.GetDenominateur();
        }

        public void Oppose()
        {
            this.SetNumerateur(this.GetNumerateur() * -1);
        }

        public void Inverse()
        {   
            (this.GetNumerateur(), this.GetDenominateur()) = (this.GetDenominateur(), this.GetNumerateur());  
        }

        public int CompareTo(Fraction? other)
        {
            Fraction monThis = this;
            double calculatedMonThis = Calcul(monThis.GetNumerateur(), monThis.GetDenominateur());
            double calculatedOther = Calcul(other.GetNumerateur(), other.GetDenominateur());
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
            int a = this.GetNumerateur();
            int b = this.GetDenominateur();
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
            (this.GetNumerateur(), this.GetDenominateur()) = (this.GetNumerateur() / this.GetPgcd(), this.GetDenominateur() / this.GetPgcd());
            if(this.GetDenominateur() < 0)
            {
                this.SetNumerateur(this.GetNumerateur() * -1);
                this.SetDenominateur(this.GetDenominateur() * -1);
            }
            return this;    
        }

        private static Fraction FractionCalcul(int _newnumerateur, int _newdenominateur)
        {
            return new Fraction(_newnumerateur, _newdenominateur).Reduire();
        }

        public Fraction Plus(Fraction _autreFraction)
        {
            return FractionCalcul(this.GetNumerateur() * _autreFraction.GetDenominateur() + _autreFraction.GetNumerateur() * this.GetDenominateur(), this.GetDenominateur() * _autreFraction.GetDenominateur());
        }

        public Fraction Moins(Fraction _autreFraction)
        {
            return FractionCalcul(this.GetNumerateur() * _autreFraction.GetDenominateur() - _autreFraction.GetNumerateur() * this.GetDenominateur(), this.GetDenominateur() * _autreFraction.GetDenominateur());
        }

        public Fraction Multiplie(Fraction _autreFraction)
        {
            return FractionCalcul(this.GetNumerateur() * _autreFraction.GetNumerateur(), this.GetDenominateur() * _autreFraction.GetDenominateur());
        }

        public Fraction Divise(Fraction _autreFraction)
        {
            Fraction fraction = new Fraction(_autreFraction);
            fraction.Inverse();
            return this.Multiplie(fraction);
        }
    }  
}