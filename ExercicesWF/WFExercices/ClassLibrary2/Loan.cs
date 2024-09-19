using ClassWinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibrary2
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
        private Periodicity periodicity;

        public Loan()
        {
            this.name = "Placeholder";
            this.amount = 0;
            this.rate = 7;
            this.periodicity = Periodicity.Mensuelle;
        }

        public double Amount {
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
        }

        public void SetPeriodicity(int value)
        {
            this.periodicity = (Periodicity)value;
        }

        public void CalcRefunds(double nbeRefunds)
        {
            this.refunds = this.amount * (this.rate / (1- Math.Pow((1 + this.rate), -nbeRefunds)));
        }

        public void CalcRate(string tag, int refundDivider)
        {
            FormControls.CheckAmountValidity(tag, out double parsedRate);
            this.rate = parsedRate / 12 * refundDivider / 100;
        }

        public bool SaveData()
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\loan\\save\\save.json";
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            File.WriteAllText(savePath, CreateJSon(), Encoding.UTF8);
            return true;
        }

        private string CreateJSon()
        {
            string jsonSave = JsonSerializer.Serialize(this);

            return jsonSave;
        }
    }
}
