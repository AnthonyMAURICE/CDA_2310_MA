using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary
{
    public class Person
    {
        private string name;

        private DateTime date;

        private double amount;

        private string zipcode;

        public string Name { get { return name; } set { ValidateName(value); } }

        public DateTime Date { get { return date; } set { ValidateDate(value); } }

        public double Amount { get { return amount; } set { ValidateAmount(value); } }

        public string Zipcode { get { return zipcode; } set { ValidateZipCode(value); } }

        public Person()
        {
            this.name = "Placeholder";
            this.date = DateTime.Now;
            this.amount = 0;
            this.zipcode = "11111";
        }

        private void ValidateName(string value)
        {
            if (!Controls.CheckNameValidity(value))
            {
                throw new ValidationException("Nom invalide");
            }
            else
            {
                this.name = value;
            }
        }
        private void ValidateDate(DateTime value)
        {
            if (!Controls.DateIsFuture(value))
            {
                throw new Exception("La datedoit être dans le futur");
            }
            else
            {
                this.date = value;
            }
        }
        private void ValidateAmount(double value)
        {
            if (value <= 0)
            {
                throw new Exception("Montant invalide");
            }
            else
            {
                this.amount = value;
            }
        }
        private void ValidateZipCode(string value)
        {
            if (!Controls.CheckZipCodeValidity(value))
            {
                throw new ValidationException("Code Postal invalide");
            }
            else
            {
                this.zipcode = value;
            }
        }
    }
}
