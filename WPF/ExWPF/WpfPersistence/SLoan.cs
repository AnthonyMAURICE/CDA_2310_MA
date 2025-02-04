using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPersistence
{
    public record struct SLoan
    {
        public int loanId;
        public string loanName;
        public double amount;
        public double rate;
        public double refunds;
        public int refundDivider;
        public int months;
        public int periodicity;

    }

    public class Ref<Sloan>
    {
        private int loanId;
        private string loanName;
        private double amount;
        private double rate;
        private double refunds;
        private int refundDivider;
        private int months;
        private int periodicity;

        public int LoanId { get => loanId; set => loanId = value; }
        public string LoanName { get => loanName; set => loanName = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Rate { get => rate; set => rate = value; }
        public double Refunds { get => refunds; set => refunds = value; }
        public int RefundDivider { get => refundDivider; set => refundDivider = value; }
        public int Months { get => months; set => months = value; }
        public int Periodicity { get => periodicity; set => periodicity = value; }
    }
}
