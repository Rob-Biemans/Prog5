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
            AddEquipmentCommand = new RelayCommand(AddEquipment);
        }

        private void AddEquipment()
        {
            using (var context = new EntitiesEntities1())
            {
                context.Equipments.Add((Equipment)Equipment.ToModel());
                context.SaveChanges();
                this._equipmentList.HideAddEquipment();
            }
        }

        public bool CanAddEquipment()
        {
            return true;
        }
    }
}
