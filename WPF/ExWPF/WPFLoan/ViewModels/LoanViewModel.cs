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

        private readonly Loan loan = Loan.LoadData();
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
        public int RefundDivider { get => refundDivider; set => refundDivider = value; }
        public int Months { get => months; set => months = value; }
        public int Periodicity { get => periodicity; set => periodicity = value; }
        public Loan Loan { get => loan; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public LoanViewModel() 
        {
            this.name = loan.Name;
            this.amount = loan.Amount;
            this.rate = loan.Rate;
            this.refunds = loan.Refunds;
            this.months = loan.Months;
            this.refundDivider = loan.RefundDivider;
            this.periodicity = loan.Periodicity;
        }

        public LoanViewModel(Loan loan)
        {
            this.name = loan.Name;
            this.amount = loan.Amount;
            this.rate = loan.Rate;
            this.refunds = loan.Refunds;
            this.months = loan.Months;
            this.refundDivider = loan.RefundDivider;
            this.periodicity = loan.Periodicity;
        }


        public void Save()
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

        public void CalculateRefunds()
        {
            this.refunds = loan.CalcRefunds(this.rate, this.refundDivider, this.amount, this.months);
        }

        string IDataErrorInfo.Error
        {
            get { throw new NotImplementedException(); }
        }

        public LoanViewModel LoadAfterSave()
        {
            if (!File.Exists(Loan.savePath + "save.json"))
            {
                return this;
            }
            else
            {
                return new(this.loan);
            }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (columnName == "Name")
                {
                    result = Controls.ErrorName(this.name);
                }
                if (columnName == "Amount")
                {
                    result = Controls.ErrorAmount(this.amount.ToString());
                }
                return result;
            }
        }
    }
}
