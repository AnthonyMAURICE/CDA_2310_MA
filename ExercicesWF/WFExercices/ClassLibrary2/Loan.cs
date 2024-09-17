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
        private double monthLength;
        private double rate;
        private double nbRefund;
        private Periodicity periodicity;

        public Loan()
        {
            this.amount = 0;
            this.monthLength = 1;
            this.rate = 7;
            this.periodicity = Periodicity.Mensuelle;
        }

        public double Amount { get; set; }
        public double MonthLength { get; set; }
        public double Rate { get; set; }

        public void SetPeriodicity(int value)
        {
            this.periodicity = (Periodicity)value;
        }

        private double GetnbRefunds()
        {
            return this.monthLength / 4;
        }

        public static double Power(double timedRate, double nbeRefunds)
        {
            return (Math.Pow((1 + timedRate), -nbeRefunds));
        }

    }
}
