using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClassLibrary;

namespace ExWPF.ViewModels
{
    public class ControlViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string name;

        private DateTime date;

        private string formatedDate;

        private double amount;

        private string zipcode;

        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
        public string FormatedDate { get => this.formatedDate; set => formatedDate = value; }

        public string Error => throw new NotImplementedException();


        public ControlViewModel()
        {
            this.name = "Placeholder";
            this.date = DateTime.Now;
            this.amount = 0;
            this.zipcode = "11111";
            this.FormatedDate = this.date.AddDays(1).ToShortDateString();
        }


        public bool Control(string _name, string _date, string _amount, string _zipcode)
        {
            if(Controls.CheckNameValidity(_name) && Controls.CheckDateValidity(_date, out DateTime dateFormated) && Controls.CheckAmountValidity(_amount, out double amount) && Controls.CheckZipCodeValidity(_zipcode)){
                Person newPerson = new(_name, dateFormated, amount, _zipcode);
                this.name = newPerson.Name;
                this.date = newPerson.Date;
                this.amount = newPerson.Amount;
                this.zipcode = newPerson.Zipcode;
                return true;
            }
            else
            {
                return false;
            }
        }

        #region IDataErrorInfo Members

        string IDataErrorInfo.Error
        {
            get { throw new NotImplementedException(); }
        }

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
                if (columnName == "FormatedDate")
                {
                    if (string.IsNullOrEmpty(FormatedDate))
                    {
                        result = "Une date est requise";
                    }
                    else if (!Controls.CheckDateValidity(FormatedDate, out DateTime _date))
                    {
                        result = "La date est incorrecte";
                    }
                    else if (!Controls.DateIsFuture(_date))
                    {
                        result = "La date doit être future";
                    }
                    else
                    {
                        result = string.Empty;
                    }
                }
                if (columnName == "Amount")
                { 
                    if(Amount == 0)
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
                if (columnName == "Zipcode")
                {
                    if (string.IsNullOrEmpty(Zipcode))
                    {
                        result = "Un code postal est requis";
                    }
                    else if (!Controls.CheckZipCodeValidity(Zipcode))
                    {
                        result = "Le code postal est incorrect";
                    }
                    else
                    {
                        result = string.Empty;
                    }
                }
                return result;
            }
        }
        #endregion
    }
}
