using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Documents;
using WpfPersistence;
using WpfPersistence.Models;


namespace WpfClassLibrary
{
    public enum Periodicity
    {
        Mensuelle,
        Bimestrielle,
        Trimestrielle,
        Semestrielle,
        Annulelle
    }
    public partial class Loan
    {
        private readonly int loanId;
        private string loanName;
        private double amount;
        private double rate;
        private double refunds;
        private int refundDivider;
        private int months;
        private Periodicity periodicity;
        
        DbLoanContext _loanContext;
        public Loan()
        {
            loanName = "Placeholder";
            amount = 1;
            rate = 7;
            refunds = 1;
            refundDivider = 1;
            months = 1;
            periodicity = Periodicity.Mensuelle;
        }

        public Loan(SLoan sLoan)
        {
            loanName = sLoan.loanName;
            amount = sLoan.amount;
            rate = sLoan.rate;
            refunds = sLoan.refunds;
            refundDivider = sLoan.refundDivider;
            months = sLoan.months;
            periodicity = (Periodicity)sLoan.periodicity;
        }

        public int LoanId { get => loanId; }

        public string LoanName { get => loanName; set => loanName = value; }

        public double Amount { get => amount; set => amount = value; }

        public double Rate { get => rate; set => rate = value; }

        public double Refunds { get => refunds; set => refunds = value; }

        public int RefundDivider { get => refundDivider; set => refundDivider = value; }

        public int Months { get => months; set => months = value; }

        public Periodicity Periodicity { get => periodicity; set => periodicity = value; }


        public double CalcRefunds(double rate, int refundDivider, double amount, int months)
        {

            return refunds = Math.Round(amount * (CalcRate(rate, refundDivider) / (1 - Math.Pow(1 + CalcRate(rate, refundDivider), -(months / refundDivider)))), 2);
        }

        private double CalcRate(double rate, int refundDivider)
        {
            return rate / 12 * refundDivider / 100;
        }

        public static Loan GetLoanStruct()
        {
            DbPersistence dbPersistence = new DbPersistence();
            return new(dbPersistence.Select());
        }

        public void SaveData()
        {
            DbPersistence dbPersistence = new DbPersistence();
            SLoan sLoan = new()
            {
                loanName = this.LoanName,
                amount = this.Amount,
                refunds = this.Refunds,
                refundDivider = this.RefundDivider,
                months = this.Months,
                rate = this.Rate,
                periodicity = (int)this.Periodicity
            };
            dbPersistence.Insert(sLoan);
        }
    }
}
