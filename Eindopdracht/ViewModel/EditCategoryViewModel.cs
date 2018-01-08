using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using GalaSoft.MvvmLight.Command;

namespace Eindopdracht.ViewModel
{
    public class EditCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditCategoryViewModel(CategoryViewModel selectedCategory)
        {
            this.Category = selectedCategory;
            SaveCommand = new RelayCommand<EditCategoryWindow>(Save);
        }

        private void Save(EditCategoryWindow window)
        {
            using (var context = new Entities())
            {
                var category = Category.ToModel();

                context.Entry(category).State = EntityState.Modified;
                context.SaveChanges();
                window.Close();
            }

        }


    }
}
