using GalaSoft.MvvmLight;
using Eindopdracht.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Eindopdracht.View;
using System.Data.Entity;

namespace Eindopdracht.ViewModel
{
    public class CategoryListViewModel : ViewModelBase
    {
        private AddCategoryWindow _addCategoryWindow;

        ICategoriesRepository CategoryRepository;

        public ObservableCollection<CategoryViewModel> Categorys { get; set; }

        private CategoryViewModel _selectedCategory;

        public CategoryViewModel SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                base.RaisePropertyChanged();
            }
        }

        //Commands
        public ICommand ShowAddCategoryCommand { get; set; }
        public ICommand DeleteCategoryCommand { get; set; }
        public ICommand ShowEditCategoryCommand { get; set; }

        public CategoryListViewModel()
        {
            CategoryRepository = new SeedCategory();
            var CategoryList = CategoryRepository.GetCategories().Select(e => new CategoryViewModel(e));
            Categorys = new ObservableCollection<CategoryViewModel>(CategoryList);

            ShowAddCategoryCommand = new RelayCommand(ShowAddCategory, CanShowAddCategory);
            DeleteCategoryCommand = new RelayCommand(DeleteCategory);

            ShowEditCategoryCommand = new RelayCommand(ShowEditCategory);
        }

        public bool CanShowAddCategory()
        {
            return _addCategoryWindow != null ? !_addCategoryWindow.IsVisible : true;
        }

        public void ShowAddCategory()
        {
            _addCategoryWindow = new AddCategoryWindow();
            _addCategoryWindow.Show();
        }

        private void DeleteCategory()
        {
            using (var context = new EntitiesEntities1())
            {
                var category = (Category)_selectedCategory.ToModel();
                //Even aan entity framework laten weten dat we dingen hebben aangepast!
                context.Entry(category).State = EntityState.Modified;
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

        public void ShowEditCategory()
        {
            var editCategory = new EditCategoryWindow();
            editCategory.Show();
        }

        public void HideAddCategory()
        {
            _addCategoryWindow.Close();
        }

    }
}
