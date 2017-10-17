using GalaSoft.MvvmLight.Command;
using Eindopdracht.Model;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class AddEquipmentViewModel
    {
        private EquipmentListViewModel _equipmentList;

        public EquipmentViewModel Equipment { get; set; }

        public ICommand AddEquipmentCommand { get; set; }
        

        public AddEquipmentViewModel(EquipmentListViewModel EquipmentList)
        {
            this._equipmentList = EquipmentList;
            this.Equipment = new EquipmentViewModel();
            AddEquipmentCommand = new RelayCommand(AddEquipment, CanAddEquipment);
        }

        private void AddEquipment()
        {
            _equipmentList.Equipments.Add(Equipment);
            _equipmentList.HideAddEquipment();
        }

        public bool CanAddEquipment()
        {
            return true;
        }
    }
}
