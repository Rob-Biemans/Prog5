using GalaSoft.MvvmLight.Command;
using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using System;

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
            AddEquipmentCommand = new RelayCommand<AddEquipmentWindow>(AddEquipment);
        }

        private void AddEquipment(AddEquipmentWindow window)
        {
            using (var context = new EntitiesEntities1())
            {
                context.Equipments.Add((Equipment)Equipment.ToModel());
                context.SaveChanges();
            }
            window.Close();
            _equipmentList.OnChangeCollection();
        }

        public bool CanAddEquipment()
        {
            return true;
        }
    }
}
