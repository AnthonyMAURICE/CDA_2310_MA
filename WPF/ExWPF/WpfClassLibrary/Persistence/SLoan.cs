using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WpfClassLibrary.Models;

namespace WpfClassLibrary.Persistence
{
    public struct SLoan
    {
        public readonly int loanId;
        public string loanName;
        public double amount;
        public double rate;
        public double refunds;
        public int refundDivider;
        public int months;
        public Periodicity periodicity;

        public SLoan(Loan loan)
        {
            loanId = loan.LoanId;
            loanName = loan.LoanName;
            amount = loan.Amount;
            rate = loan.Rate;
            refunds = loan.Refunds;
            refundDivider = loan.RefundDivider;
            months = loan.Months;
            periodicity = loan.Periodicity;
        }

        public SLoan() 
        {
            this.loanName = "Placeholder";
            this.amount = 1;
            this.rate = 7;
            this.refunds = 1;
            this.refundDivider = 1;
            this.months = 1;
            this.periodicity = Periodicity.Mensuelle;
        }
    }
}
