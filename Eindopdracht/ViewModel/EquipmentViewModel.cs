using Eindopdracht.Model;
using Eindopdracht.ViewModel;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
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

        internal object ToModel()
        {
            return _equipment;
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
        private EquipmentListViewModel _equipmentlist;

        public EquipmentViewModel()
        {
            _equipment = new Equipment();
        }

        public EquipmentViewModel(Equipment equipment)
        {
            _equipment = equipment;
        }

        public EquipmentViewModel(Equipment equipment, EquipmentListViewModel equipmentlist)
        {
            _equipment = equipment;
            _equipmentlist = equipmentlist;
        }

    }
}
