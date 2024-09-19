using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Transaction
    {
        private readonly string name;

        private readonly DateTime date;

        private readonly double amount;

        private readonly string zipcode;

        public string Name { get { return name; } }

        public DateTime Date { get { return date; } }

        public double Amount { get { return amount; } }

        public string Zipcode { get { return zipcode; } }

        public Transaction(string name, DateTime date, double amount, string zipcode)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.zipcode = zipcode;
        }
    }
}
