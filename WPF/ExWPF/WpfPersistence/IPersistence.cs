using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPersistence
{
    internal interface IPersistence
    {
        public void Insert(SLoan sLoan);
        public SLoan Select();
    }
}
