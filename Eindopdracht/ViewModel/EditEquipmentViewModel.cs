using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using GalaSoft.MvvmLight.Command;

namespace Eindopdracht.ViewModel
{
    public class EditEquipmentViewModel
    {
        public EquipmentViewModel Equipment { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditEquipmentViewModel(EquipmentViewModel selectedEquipment)
        {
            this.Equipment = selectedEquipment;
            SaveCommand = new RelayCommand<EditEquipmentWindow>(Save);
        }

        private void Save(EditEquipmentWindow window)
        {
            using (var context = new EntitiesEntities1())
            {
                var equipment = Equipment.ToModel();

                context.Entry(equipment).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
