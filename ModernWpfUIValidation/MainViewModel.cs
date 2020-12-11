using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ModernWpfUIValidation
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string shouldNotBeEmpty = string.Empty;
        public string ShouldNotBeEmpty
        {
            get => shouldNotBeEmpty;
            set
            {
                shouldNotBeEmpty = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShouldNotBeEmpty)));
            }
        }
    }
}
