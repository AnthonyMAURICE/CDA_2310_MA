using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfClassLibrary
{
    public class BaseViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {

        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string? propertyName)
        {
            if (!string.IsNullOrEmpty(propertyName) && _errorsByPropertyName.ContainsKey(propertyName))
            {
                return _errorsByPropertyName[propertyName];
            }
            return new List<object>();
        }
        public bool HasErrors
        {
            get
            {
                return _errorsByPropertyName.Any();
            }
        }


        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            this.OnPropertyChanged(nameof(HasErrors));
        }


        protected void AddError(string propertyName, string error)
        {
            if (!_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName[propertyName] = new List<string>();
            }
            if (!_errorsByPropertyName[propertyName].Contains(error))
            {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        protected void ClearErrors(string propertyName)
        {
            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }
    }
}

