using Eindopdracht.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.ViewModel
{
    public class EquipmentViewModel : ViewModelBase
    {
        public int Id
        {
            get { return _equipment.Id; }
            set { _equipment.Id = value; RaisePropertyChanged("Id"); }
        }

        public string Category
        {
            get { return _equipment.Category; }
            set { _equipment.Category = value; RaisePropertyChanged("Category"); }
        }

        public string Name
        {
            get { return _equipment.Name; }
            set { _equipment.Name = value; RaisePropertyChanged("Name"); }
        }

        public int Price
        {
            get { return _equipment.Price; }
            set { _equipment.Price = value; RaisePropertyChanged("Price"); }
        }

        public int Agility
        {
            get { return _equipment.Agility; }
            set { _equipment.Agility = value; RaisePropertyChanged("Agility"); }
        }
        public int Strenght
        {
            get { return _equipment.Strenght; }
            set { _equipment.Strenght = value; RaisePropertyChanged("Strenght"); }
        }
        public int Intelligence
        {
            get { return _equipment.Intelligence; }
            set { _equipment.Intelligence = value; RaisePropertyChanged("Intelligence"); }
        }

        private Equipment _equipment;

        public EquipmentViewModel(Equipment equipment)
        {
            _equipment = equipment;
        }

        public EquipmentViewModel()
        {
            _equipment = new Equipment();
        }
    }
}
