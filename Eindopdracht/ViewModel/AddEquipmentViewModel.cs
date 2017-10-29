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
        Random ran = new Random();

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
                var equipment = (Equipment)Equipment.ToModel();
                //Even aan entity framework laten weten dat we dingen hebben aangepast!
                context.Entry(equipment).State = EntityState.Added;
                equipment.Id = ran.Next(1, 1000000000);
                context.Equipments.Add(equipment);
                context.SaveChanges();
            }
        }

        public bool CanAddEquipment()
        {
            return true;
        }
    }
}
