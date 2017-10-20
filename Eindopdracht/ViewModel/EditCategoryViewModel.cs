using Eindopdracht.Model;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class EditCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditCategoryViewModel(CategoryViewModel selectedCategory)
        {
            this.Category = selectedCategory;
        }
    }
}
