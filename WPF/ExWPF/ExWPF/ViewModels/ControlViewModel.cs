using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWPF.ViewModels
{
    public class ControlViewModel : INotifyPropertyChanged
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
    }
}
