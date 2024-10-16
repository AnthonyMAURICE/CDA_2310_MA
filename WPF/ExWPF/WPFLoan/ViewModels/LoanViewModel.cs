using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfClassLibrary;
using WPFLoan.Models;

namespace WPFLoan.ViewModels
{
    public class LoanViewModel : BaseViewModel
    {

        private WPFLoan.Models.Loan loan = WPFLoan.Models.Loan.LoadData();
        private string name;
        private double amount;
        private double rate;
        private double refunds;
        private int refundDivider;
        private int months;
        private int periodicity;

        public WPFLoan.Models.DbLoanContext DbLoanContext { get; set; }

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
        public int RefundDivider { get => refundDivider; set => refundDivider = value; }
        public int Months { get => months; set => months = value; }
        public int Periodicity { get => periodicity; set => periodicity = value; }
        public Loan Loan
        {
            get
            {
                return loan;
            }
        }

        public LoanViewModel() 
        {
            this.name = Loan.LoanName;
            this.amount = Loan.Amount;
            this.rate = Loan.Rate;
            this.refunds = Loan.Refunds;
            this.months = Loan.Months;
            this.refundDivider = Loan.RefundDivider;
            this.periodicity = (int)Loan.Periodicity;
        }

        public LoanViewModel(Loan loan)
        {
            this.name = loan.LoanName;
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
                loan.LoanName = this.name;
                loan.Amount = this.amount;
                loan.Rate = this.rate;
                loan.RefundDivider = this.refundDivider;
                loan.Refunds = this.refunds;
                loan.Months = this.months;
                loan.Periodicity = (Periodicity)this.periodicity;
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
        
        public void SaveInDb()
        {
            try
            {
                loan.SaveDataInDB();
            }
            catch (Exception ex) 
            {
                string messageBoxText = ex.Message;
                string caption = "Warning !";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }

        public void LoadFromDb() 
        {
            try
            {
                loan = loan.LoadDataFromDB();
                this.name = loan.LoanName;
                this.amount = loan.Amount;
                this.rate = loan.Rate;
                this.refunds = (int)loan.Refunds;
                this.months = (int)loan.Months;
                this.refundDivider = (int)loan.RefundDivider;
                this.periodicity = (int)loan.Periodicity;
            }
            catch (Exception ex)
            {
                string messageBoxText = ex.Message;
                string caption = "Warning !";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }
    }
}
