using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Loan
    {
        private double amount;
        private double monthLength;
        private double rate;
        private double nbRefund;

        public Loan(double amount, double monthLength, double rate, double nbRefund)
        {
            this.amount = amount;
            this.monthLength = monthLength;
            this.rate = rate;    
            this.nbRefund = nbRefund;   
        }

        public double Amount { get { return amount; } }
        public double MonthLength { get { return monthLength; } }
        public double Rate { get { return rate; } }
        public double NbeRefund { get { return nbRefund; } }

        public static double Power(double timedRate, double nbeRefunds)
        {
            return (Math.Pow((1 + timedRate), -nbeRefunds));
        }

    }
}
