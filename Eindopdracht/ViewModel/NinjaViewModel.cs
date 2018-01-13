using GalaSoft.MvvmLight;
using Eindopdracht.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Eindopdracht.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;

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


        public int InventoryID
        {
            get { return _inventoryID; }
            set { _inventoryID = value; RaisePropertyChanged("InventoryID"); }
        }
        public ICollection<Equipment> Inventory
        {
            get { return _ninja.Equipments; }
            set { _ninja.Equipments = value; }
        }

        private Ninja _ninja;
        private NinjaListViewModel _ninjalist;
        private int _strenght;
        private int _agility;
        private int _inteligence;
        private int _inventoryID;

        internal object ToModel()
        {
            return _ninja;
        }

        public NinjaViewModel()
        {
            this._ninja = new Ninja();
        }

        public ICollection<Equipment> Equipment
        {
            get { return _ninja.Equipments; }
            set { _ninja.Equipments = value; RaisePropertyChanged("Equipment"); }
        }

        public NinjaViewModel(Ninja ninja)
        {
            this._ninja = ninja;
            this._strenght = CalculateStrength();
            this._agility = CalculateAgility();
            this._inteligence = CalculateIntelligence();
            this._ninja.Currency = CalculateCurrency();
        }

        public NinjaViewModel(Ninja ninja, NinjaListViewModel ninjalist)
        {
            this._ninja = ninja;
            this._ninjalist = ninjalist;
            this._strenght = CalculateStrength();
            this._agility = CalculateAgility();
            this._inteligence = CalculateIntelligence();
            this._ninja.Currency = CalculateCurrency();
        }

        public int CalculateStrength()
        {
            int totalStrength = 0;
            _ninja.Equipments.ToList().ForEach(e => totalStrength += e.Strenght);
            return totalStrength;
        }

        public ObservableCollection<EquipmentViewModel> ConvertInventory()
        {
            ObservableCollection<EquipmentViewModel> collection = new ObservableCollection<EquipmentViewModel>();
            return collection;
        }

        internal void SellAllEquipment()
        {
            Inventory.Clear();
            Agility = CalculateAgility();
            Intelligence = CalculateIntelligence();
            Strength = CalculateStrength();
        }

        public int CalculateAgility()
        {
            int totalAgility = 0;
            _ninja.Equipments.ToList().ForEach(e => totalAgility += e.Agility);
            return totalAgility;
        }

        public void SellEquipment(EquipmentViewModel selectedEquipment)
        {
            Inventory.Remove(Inventory.Where(e => e.Id == selectedEquipment.Id).First());
            Agility = CalculateAgility();
            Intelligence = CalculateIntelligence();
            Strength = CalculateStrength();
        }

        public int CalculateIntelligence()
        {
            int totalIntelligence = 0;
            _ninja.Equipments.ToList().ForEach(e => totalIntelligence += e.Intelligence);
            return totalIntelligence;
        }
        public int CalculateCurrency()
        {
            int totalCurrency = _ninja.Currency;
            return totalCurrency;
        }

        public void AddEquipment(EquipmentViewModel equipment)
        {
            using (var context = new Entities())
            {
                var ninja = context.Ninjas.Find(_ninja.Id);
                var eq = context.Equipments.Find(equipment.Id);
                ninja.Equipments.Add(eq);
                context.SaveChanges();
            }

                Agility = CalculateAgility();
            Intelligence = CalculateIntelligence();
            Strength = CalculateStrength();
        }

        // Get Ninja's Equipment
        public ICollection<EquipmentViewModel> GetEquipment()
        {
            List<EquipmentViewModel> equipment = new List<EquipmentViewModel>();
            using (var context = new Entities())
            {
                context.Ninjas.Find(_ninja.Id).Equipments.ToList().ForEach(e => equipment.Add(new EquipmentViewModel(e)));
            }

            return equipment;
        }
    }
}
