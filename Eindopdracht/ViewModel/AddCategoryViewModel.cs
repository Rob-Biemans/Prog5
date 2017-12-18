using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using GalaSoft.MvvmLight.Command;
using System;

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
            AddCategoryCommand = new RelayCommand<AddCategoryWindow>(AddCategory);
        }

        private void AddCategory(AddCategoryWindow window)
        {
            using (var context = new EntitiesEntities1())
            {
                context.Categories.Add((Category)Category.ToModel());
                context.SaveChanges();
            }
            window.Close();
            _CategoryList.OnChangeCollection();
        }

        public bool CanAddCategory()
        {
            return true;
        }
    }
}
