using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;

namespace Eindopdracht.ViewModel
{
    public class EditEquipmentViewModel : ViewModelBase
    {
        public EquipmentViewModel Equipment { get; set; }
        private CategoryViewModel _selectedCategory;
        public CategoryViewModel SelectedCategory
        {
            get { return _selectedCategory; }
            set { _selectedCategory = value; RaisePropertyChanged("SelectedCategory"); }
        }

        public int CategoryId { get; set; }

        private ObservableCollection<CategoryViewModel> _categories;
        public ObservableCollection<CategoryViewModel> Categories
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
            _selectedCategory = new CategoryViewModel(selectedEquipment.Category);
            SaveCommand = new RelayCommand<EditEquipmentWindow>(Save);
            setCategories();
        }

        private void Save(EditEquipmentWindow window)
        {
            using (var context = new Entities())
            {
                var equipment = context.Equipments.Find(Equipment.Id);
                equipment.CategoryID = SelectedCategory.Id;
                equipment.Agility = Equipment.Agility;
                equipment.Intelligence = Equipment.Intelligence;
                equipment.Strenght = Equipment.Strenght;
                equipment.Price = Equipment.Price;
                equipment.Name = Equipment.Name;

                context.Entry(equipment).State = EntityState.Modified;
                context.SaveChanges();
                window.Close();
            }
        }

        private void setCategories()
        {
            _categories = new ObservableCollection<CategoryViewModel>();

            using (var context = new Entities())
            {
                context.Categories.ToList().ForEach(c => Categories.Add(new CategoryViewModel(c)));
            }
        }
    }
}
