using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPFLoan.Models
{

    public enum Periodicity
    {
        Mensuelle,
        Bimestrielle,
        Trimestrielle,
        Semestrielle,
        Annulelle
    }
    public partial class Loan
    {

        public Loan()
        {
            this.loanName = "Placeholder";
            this.amount = 1;
            this.rate = 7;
            this.refunds = 1;
            this.refundDivider = 1;
            this.months = 1;
            this.periodicity = WPFLoan.Models.Periodicity.Mensuelle;
        }

        public double CalcRefunds(double rate, int refundDivider, double amount, int months)
        {

            return this.refunds = Math.Round(amount * (this.CalcRate(rate, refundDivider) / (1 - Math.Pow((1 + this.CalcRate(rate, refundDivider)), -(months / refundDivider)))), 2);
        }

        private double CalcRate(double rate, int refundDivider)
        {
            return rate / 12 * refundDivider / 100;
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
