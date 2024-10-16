using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfClassLibrary.Persistence;

namespace WpfClassLibrary.Models
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

        public Loan()
        {
            this.loanName = "Placeholder";
            this.amount = 1;
            this.rate = 7;
            this.refunds = 1;
            this.refundDivider = 1;
            this.months = 1;
            this.periodicity = Periodicity.Mensuelle;
        }

        public Loan(SLoan sLoan)
        {
            this.loanName= sLoan.loanName;
            this.amount= sLoan.amount;
            this.rate = sLoan.rate;
            this.refunds = sLoan.refunds;
            this.refundDivider = sLoan.refundDivider;
            this.months = sLoan.months;
            this.periodicity= (Periodicity)sLoan.periodicity;
        }

        public double CalcRefunds(double rate, int refundDivider, double amount, int months)
        {

            return this.refunds = Math.Round(amount * (this.CalcRate(rate, refundDivider) / (1 - Math.Pow((1 + this.CalcRate(rate, refundDivider)), -(months / refundDivider)))), 2);
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
            dbPersistence.Insert(new SLoan(this));
        }
    }
}
