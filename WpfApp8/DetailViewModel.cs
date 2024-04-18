using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    internal class DetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }        

        private bool _option1;
        public bool Option1
        {
            get { return _option1; }
            set
            {
                _option1 = value;
                OnPropertyChanged(nameof(Option1));
            }
        }
    }
}
