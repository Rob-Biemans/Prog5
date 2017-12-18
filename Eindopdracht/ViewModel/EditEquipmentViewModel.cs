using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;

namespace Eindopdracht.ViewModel
{
    public class EditEquipmentViewModel
    {
        public EquipmentViewModel Equipment { get; set; }

        private ObservableCollection<string> _categories;
        public ObservableCollection<string> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
            }
        }

        public ICommand SaveCommand { get; set; }

        public EditEquipmentViewModel(EquipmentViewModel selectedEquipment)
        {
            this.Equipment = selectedEquipment;
            SaveCommand = new RelayCommand<EditEquipmentWindow>(Save);
            setCategories();
        }

        private void Save(EditEquipmentWindow window)
        {
            using (var context = new EntitiesEntities1())
            {
                var equipment = Equipment.ToModel();

                context.Entry(equipment).State = EntityState.Modified;
                context.SaveChanges();
                window.Close();
            }
        }

        private void setCategories()
        {
            _categories = new ObservableCollection<string>();

            using (var context = new EntitiesEntities1())
            {
                context.Categories.ToList().ForEach(c => Categories.Add(c.Name));
            }
        }
    }
}
