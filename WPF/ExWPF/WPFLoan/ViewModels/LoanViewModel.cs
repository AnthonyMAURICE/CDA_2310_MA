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
    public class LoanViewModel : BaseViewModel
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

        public string Name { get => name; set
            {
                this.name = value;
                ValidateName(value);
                this.OnPropertyChanged();

            }
        }
        public double Amount
        {
            get => amount;
            set
            {
                this.amount = value;
                ValidateAmount(value.ToString());
                this.OnPropertyChanged();
            }
        }
        public double Rate { get => rate; set => rate = value; }
        public double Refunds { get => refunds; set => refunds = value; }
        public double CalculatedRate { get => calculatedRate; set => calculatedRate = value; }
        public int RefundDivider { get => refundDivider; set => refundDivider = value; }
        public int Months { get => months; set => months = value; }
        public int Periodicity { get => periodicity; set => periodicity = value; }
        public Loan Loan { get => loan; }

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

        public LoanViewModel(Loan loan)
        {
            this.name = loan.Name;
            this.amount = loan.Amount;
            this.rate = loan.Rate;
            this.refunds = (int)loan.Refunds;
            this.months = (int)loan.Months;
            this.refundDivider = (int)loan.RefundDivider;
            this.periodicity = (int)loan.Periodicity;
        }

        public void Save()
        {
            if (Controls.CheckNameValidity(this.name))
            {
                loan.Name = this.name;
                loan.Amount = this.amount;
                loan.Rate = this.rate;
                loan.RefundDivider = this.refundDivider;
                loan.Refunds = this.refunds;
                loan.Months = this.months;
                loan.Periodicity = (Periodicity)this.periodicity;
                loan.CalculatedRate = this.calculatedRate;
                loan.SaveData();
            }
        }

        public void CalculateRefunds()
        {
            this.refunds = loan.CalcRefunds(this.rate, this.refundDivider, this.amount, this.months);
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

        private void ValidateName(string texte)
        {
            ClearErrors(nameof(Name));
            if (string.IsNullOrWhiteSpace(texte))
            {
                AddError(nameof(Name), "Le Nom ne peut être vide");
            }
            if (!string.IsNullOrEmpty(texte) && (texte[0] != char.ToUpper(texte[0])))
            {
                AddError(nameof(Name), "La premier lettre du Nom doit etre une majuscule");
            }
            if (!Controls.CheckNameValidity(Name))
            {
                AddError(nameof(Name), Controls.ErrorName(Name));
            }   
        }

        private void ValidateAmount(string _amount)
        {
            ClearErrors(nameof(Amount));
            if (string.IsNullOrWhiteSpace(_amount))
            {
                AddError(nameof(Amount), "Le montant ne peut être vide");
            }
            if (!Controls.CheckAmountValidity(_amount, out _))
            {
                AddError(nameof(Amount), Controls.ErrorAmount(_amount));
            }
        }  
    }
}
