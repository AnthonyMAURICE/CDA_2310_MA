using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Loan
    {
        public enum Periodicity
        {
            Mensuelle,
            Bimestrielle,
            Trimestrielle,
            Semestrielle,
            Annulelle,
            Jamais
        }
        private double amount;
        private double rate;
        private double refunds;
        private Periodicity periodicity;

        public Loan()
        {
            this.amount = 0;
            this.rate = 7;
            this.periodicity = Periodicity.Mensuelle;
        }

        public double Amount {
            get { return this.amount; } 
            set { this.amount = value; }
        }

        public double Rate
        {
            get { return this.rate; }
            set { this.rate = value; }
        }

        public double Refunds
        {
            get { return this.refunds; }
        }

        public void SetPeriodicity(int value)
        {
            this.periodicity = (Periodicity)value;
        }

        public void CalcRefunds(double nbeRefunds)
        {
            refunds = this.amount * (this.rate / (1- Math.Pow((1 + this.rate), -nbeRefunds)));
        }


    }
}
