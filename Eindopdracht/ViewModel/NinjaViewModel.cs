using GalaSoft.MvvmLight;
using Eindopdracht.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Eindopdracht.ViewModel
{
    class NinjaViewModel : ViewModelBase
    {
        public int Id
        {
            get { return _ninja.Currency; }
            set { _ninja.Currency = value; RaisePropertyChanged("Id"); }
        }

        public string Name {
            get { return _ninja.Name; }
            set { _ninja.Name = value; RaisePropertyChanged("Name"); }
        }

        public int Currency {
            get { return _ninja.Currency; }
            set { _ninja.Currency = value; RaisePropertyChanged("Currency"); }
        }

        private Ninja _ninja;

        public NinjaViewModel()
        {
            this._ninja = new Ninja();
        }

        public NinjaViewModel(Ninja ninja)
        {
            this._ninja = ninja;
        }
    }
}
