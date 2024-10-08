using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WpfClassLibrary
{
    public enum Periodicity
    {
        Mensuelle,
        Bimestrielle,
        Trimestrielle,
        Semestrielle,
        Annulelle,
        Jamais
    }
    public class Loan
    {
        private string name;
        private double amount;
        private double rate;
        private double refunds;
        private double calculatedRate;
        private int refundDivider;
        private int months;
        private int periodicity;
        private static readonly string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\loan\\save\\";

        public Loan()
        {
            this.name = "Placeholder";
            this.amount = 0;
            this.rate = 0;
            this.calculatedRate = 0;
            this.months = 1;
            this.refunds = 0;
            this.refundDivider = 1;
            this.Periodicity = 0;
        }

        public Loan(string _name, double _amount, double _rate, double _refunds)
        {
            this.name = _name;
            Amount = _amount;
            Rate = _rate;
            this.Refunds = _refunds;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public double Rate
        {
            get { return this.rate; }
            set { this.rate = value; }
        }

        public double Refunds
        {
            get { return this.refunds; }
            set { this.refunds = value; }
        }
        public double CalculatedRate
        {
            get { return this.calculatedRate; }
        }

        public int RefundDivider
        {
            get { return this.refundDivider; }
            set { this.refundDivider = value; }
        }

        public int Months
        {
            get { return this.months; }
            set { this.months = value; }
        }

        public int Periodicity
        {
            get { return this.periodicity; }
            set { this.periodicity = value; }
        }

        public void CalcRefunds()
        {
            this.CalcRate(this.refundDivider);
            this.refunds = Math.Round(this.amount * (this.calculatedRate / (1 - Math.Pow((1 + this.calculatedRate), -(this.months / this.refundDivider)))), 2);
        }

        public void CalcRate(int refundDivider)
        {
            this.calculatedRate = this.rate / 12 * refundDivider / 100;
        }

        public void SaveData()
        {
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            File.WriteAllText(savePath + "save.json", CreateJSon(), Encoding.UTF8);
        }

        private string CreateJSon()
        {
            string jsonSave = JsonSerializer.Serialize(this);

            return jsonSave;
        }

        public static Loan LoadData()
        {
            Loan loan = new();
            if (!File.Exists(Loan.savePath + "save.json"))
            {
                return loan;
            }
            else
            {
                string jsonLoad = File.ReadAllText(savePath + "save.json");
                return loan = JsonSerializer.Deserialize<Loan>(jsonLoad);
            }
        }
    }
}
