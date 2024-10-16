using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPersistence
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
        public int periodicity;
    }
}
