using GalaSoft.MvvmLight;
using Eindopdracht.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Eindopdracht.Model
{
    public class NinjaViewModel : ViewModelBase
    {
        public int Id
        {
            get { return _ninja.Id; }
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

        public int Strength
        {
            get { return _strenght; }
            set { _strenght = value; RaisePropertyChanged("Strength"); }
        }

        public int Agility
        {
            get { return _agility; }
            set { _agility = value; RaisePropertyChanged("Agility"); }
        }

        public int Intelligence
        {
            get { return _inteligence; }
            set { _inteligence = value; RaisePropertyChanged("Intelligence"); }
        }

        public List<Equipment> Inventory
        {
            get { return _ninja.Inventory; }
            set { _ninja.Inventory = value; }
        }

        private Ninja _ninja;
        private int _strenght;
        private int _agility;
        private int _inteligence;

        public NinjaViewModel()
        {
            this._ninja = new Ninja();
        }

        public NinjaViewModel(Ninja ninja)
        {
            this._ninja = ninja;
            this._strenght = CalculateStrength();
            this._agility = CalculateAgility();
            this._inteligence = CalculateIntelligence();
            this._ninja.Currency = CalculateCurrency();
        }

        public int CalculateStrength()
        {
            int totalStrenght = 0;
            this._ninja.Inventory.ForEach(e => totalStrenght += e.Strenght);
            return totalStrenght;
        }

        public int CalculateAgility()
        {
            int totalAgility = 0;
            this._ninja.Inventory.ForEach(e => totalAgility += e.Agility);
            return totalAgility;
        }

        public int CalculateIntelligence()
        {
            int totalIntelligence = 0;
            this._ninja.Inventory.ForEach(e => totalIntelligence += e.Intelligence);
            return totalIntelligence;
        }

        public int CalculateCurrency()
        {
            int totalCurrency = _ninja.Currency;
            this._ninja.Inventory.ForEach(e => totalCurrency += e.Price);
            return totalCurrency;
        }
    }
}
