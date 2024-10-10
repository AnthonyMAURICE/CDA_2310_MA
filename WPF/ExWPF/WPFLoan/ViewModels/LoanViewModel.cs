using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WpfClassLibrary;

namespace WPFLoan.ViewModels
{
    public class LoanViewModel : INotifyPropertyChanged, IDataErrorInfo
    {

        private Loan loan = Loan.LoadData();
        private string name;
        private double amount;
        private double rate;
        private double refunds;
        private double calculatedRate;
        private int refundDivider;
        private int months;
        private int periodicity;


        public string this[string columnName] => throw new NotImplementedException();
        

        public string Error => throw new NotImplementedException();

        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Rate { get => rate; set => rate = value; }
        public double Refunds { get => refunds; set => refunds = value; }
        public double CalculatedRate { get => calculatedRate; set => calculatedRate = value; }
        public int RefundDivider { get => refundDivider; set => refundDivider = value; }
        public int Months { get => months; set => months = value; }
        public int Periodicity { get => periodicity; set => periodicity = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public LoanViewModel() 
        {
            this.name = loan.Name;
            this.amount = loan.Amount;
            this.rate = loan.Rate;
            this.refunds = loan.Refunds;
            this.months = loan.Months;
            this.refundDivider = loan.RefundDivider;
            this.periodicity = (int)loan.Periodicity;
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

        public void ControlAndSave()
        {
            if (Controls.CheckNameValidity(this.name))
            {
                loan.Name = this.name;
                loan.Amount = this.amount;
                loan.Rate = this.rate;
                loan.RefundDivider = this.refundDivider;
                loan.Refunds = this.refunds;
                loan.Months = this.months;
                loan.Periodicity = (int)Periodicity;
                loan.CalculatedRate = this.calculatedRate;
                loan.SaveData();
            }
        }

        string IDataErrorInfo.Error
        {
            get { throw new NotImplementedException(); }
        }

        public Loan Loan { get => loan; set => loan = value; }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (columnName == "Name")
                {
                    if (string.IsNullOrEmpty(Name))
                    {
                        result = "Un nom est requis";
                    }
                    else if (!Controls.CheckNameValidity(Name))
                    {
                        result = "Le nom est incorrect";
                    }
                    else
                    {
                        result = string.Empty;
                    }
                }
                if (columnName == "Amount")
                {
                    if (Amount == 0)
                    {
                        result = "Aucun montant entré";
                    }
                    else if (Amount < 0)
                    {
                        result = "Le montant est négatif";
                    }
                    else if (!Controls.CheckAmountValidity(Amount.ToString(), out double amount))
                    {
                        result = "Le montant est incorrect";
                    }
                    else
                    {
                        result = string.Empty;
                    }
                }
                return result;
            }
        }
    }
}
