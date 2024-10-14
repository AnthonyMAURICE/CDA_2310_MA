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
        Annulelle
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
        public static readonly string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\loanWPF\\save\\";

        public Loan()
        {
            this.name = "Placeholder";
            this.amount = 1;
            this.rate = 0;
            this.refunds = 1;
            this.calculatedRate = 0;
            this.refundDivider = 1;
            this.months = 1;
            this.periodicity = 0;
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
            set { this.calculatedRate = value; }
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

        public double CalcRefunds(double rate, int refundDivider, double amount, int months)
        {
            this.CalcRate(rate, refundDivider);
            return this.refunds = Math.Round(amount * (this.calculatedRate / (1 - Math.Pow((1 + this.calculatedRate), -(months / refundDivider)))), 2);
        }

        private void CalcRate(double rate, int refundDivider)
        {
            this.calculatedRate = rate / 12 * refundDivider / 100;
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
            if (!File.Exists(Loan.savePath + "save.json"))
            {
                return new();
            }
            else
            {
                string jsonLoad = File.ReadAllText(savePath + "save.json");
                return JsonSerializer.Deserialize<Loan>(jsonLoad)!;
            }
        }
    }
}
