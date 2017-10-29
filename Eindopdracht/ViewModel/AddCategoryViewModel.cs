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
        Random ran = new Random();

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
                var category = (Category)Category.ToModel();
                //Even aan entity framework laten weten dat we dingen hebben aangepast!
                context.Entry(category).State = EntityState.Added;
                category.Id = ran.Next(1, 1000000000);
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public bool CanAddCategory()
        {
            return true;
        }
    }
}
