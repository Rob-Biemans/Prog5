using GalaSoft.MvvmLight.Command;
using Eindopdracht.Model;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class AddCategoryViewModel
    {
        private CategoryListViewModel _CategoryList;

        public CategoryViewModel Category { get; set; }

        public ICommand AddCategoryCommand { get; set; }

        public AddCategoryViewModel(CategoryListViewModel CategoryList)
        {
            this._CategoryList = CategoryList;
            this.Category = new CategoryViewModel();
            AddCategoryCommand = new RelayCommand(AddCategory, CanAddCategory);
        }

        private void AddCategory()
        {
            _CategoryList.Categorys.Add(Category);
            _CategoryList.HideAddCategory();
        }

        public bool CanAddCategory()
        {
            return true;
        }
    }
}
