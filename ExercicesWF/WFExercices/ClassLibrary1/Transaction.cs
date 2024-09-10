namespace ClassWF
{
    public class Transaction
    {
        private string name;

        private DateTime date;

        private double amount;

        private string zipcode;

        public string Name { get { return name; } }

        public DateTime Date { get { return Date; } }

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
