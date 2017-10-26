using Eindopdracht.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class ViewShopViewModel : ViewModelBase
    {
        private EquipmentListViewModel _categoryEquipment;
        private CategoryViewModel _selectedCategory;

        public NinjaViewModel Ninja { get; set; }
        public EquipmentListViewModel EquipmentList { get; set; }
        public CategoryListViewModel CategoryList { get; set; }
        //public CategoryViewModel SelectedCategory { get { return _selectedCategory; } set { _selectedCategory = value; CategoryEquipment = ShowCategoryEquipment(); } }
        public CategoryViewModel SelectedCategory { get { return _selectedCategory; } set { _selectedCategory = value; _categoryEquipment = ChangeEquipment(); } }

       

        public EquipmentListViewModel CategoryEquipment
        {
            get { return _categoryEquipment; }
            set { _categoryEquipment = value; base.RaisePropertyChanged(); }
        }

        public ICommand ShowCategoryEquipmentÇommand;

        public ViewShopViewModel(NinjaViewModel selectedNinja, EquipmentListViewModel equipmentList, CategoryListViewModel categoryList)
        {
            this.Ninja = selectedNinja;
            this.EquipmentList = equipmentList;
            this.CategoryList = categoryList;

            ShowCategoryEquipmentÇommand = new RelayCommand(ShowCategoryEquipment);
        }

        public void ShowCategoryEquipment()
        {
            return;
        }

        //public EquipmentListViewModel ShowCategoryEquipment()
        //{
        //    //return CategoryList.Categorys.Where(c => c.Id == SelectedCategory.Id);
        //}
        private EquipmentListViewModel ChangeEquipment()
        {
            CategoryEquipment = new EquipmentListViewModel();
            CategoryEquipment.Equipments = new ObservableCollection<EquipmentViewModel>(EquipmentList.Equipments.Where(c => c.Id == SelectedCategory.Id));
            return CategoryEquipment;
        }

    }
}
