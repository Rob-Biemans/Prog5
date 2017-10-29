using GalaSoft.MvvmLight;
using Eindopdracht.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Eindopdracht.ViewModel;
using System;
using System.Collections.ObjectModel;

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
        public List<Equipment> Inventory
        {
            get { return _ninja.Inventory; }
            set { _ninja.Inventory = value; }
        }

        private Ninja _ninja;
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

        public NinjaViewModel(Ninja ninja)
        {
            this._ninja = ninja;
            this._ninja.Inventory = new SeedEquipment().GetInventory(_ninja.Id);
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

        public ObservableCollection<EquipmentViewModel> ConvertInventory()
        {
            ObservableCollection<EquipmentViewModel> collection = new ObservableCollection<EquipmentViewModel>();
            Inventory.ForEach(i =>
            {
                collection.Add(new EquipmentViewModel(i));
            });
            return collection;
        }

        internal void SellAllEquipment()
        {
            Inventory.ForEach(e => {
                Currency += e.Price;
            });
            Inventory.Clear();
            Agility = CalculateAgility();
            Intelligence = CalculateIntelligence();
            Strength = CalculateStrength();
        }

        public int CalculateAgility()
        {
            int totalAgility = 0;
            this._ninja.Inventory.ForEach(e => totalAgility += e.Agility);
            return totalAgility;
        }

        public void SellEquipment(EquipmentViewModel selectedEquipment)
        {
            Inventory.RemoveAll(i => i.Id == selectedEquipment.Id);
            Agility = CalculateAgility();
            Intelligence = CalculateIntelligence();
            Strength = CalculateStrength();
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

        public void AddEquipment(EquipmentViewModel equipment)
        {
            Equipment newEquipment = new Equipment();
            newEquipment.Id = equipment.Id;
            newEquipment.Name = equipment.Name;
            newEquipment.Price = equipment.Price;
            newEquipment.Strenght = equipment.Strenght;
            newEquipment.Intelligence = equipment.Intelligence;
            newEquipment.Agility = equipment.Agility;
            
            Inventory.Add(newEquipment);
            Agility = CalculateAgility();
            Intelligence = CalculateIntelligence();
            Strength = CalculateStrength();
        }
    }
}
