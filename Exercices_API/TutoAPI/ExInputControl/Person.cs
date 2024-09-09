using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExInputControl
{
    public class Person
    {
        private string name;

        private DateTime date;

        private double amount;

        private string zipcode;

        public Person(string name, DateTime date, double amount, string zipcode)
        {
            this.name = name;
            this.date = date;
            this.amount = amount;
            this.zipcode = zipcode;
        }
    }
}