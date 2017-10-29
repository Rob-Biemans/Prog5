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
        private List<EquipmentViewModel> _showEquipment;
        private CategoryViewModel _selectedCategory;
        private EquipmentViewModel _selectedEquipment;
        private string _buyMessage;

        public NinjaViewModel Ninja { get; set; }
        public EquipmentListViewModel EquipmentList { get; set; }
        public CategoryListViewModel CategoryList { get; set; }
        //public CategoryViewModel SelectedCategory { get { return _selectedCategory; } set { _selectedCategory = value; CategoryEquipment = ShowCategoryEquipment(); } }
        public CategoryViewModel SelectedCategory { get { return _selectedCategory; } set { _selectedCategory = value; _showEquipment = ChangeEquipment(); } }
        public EquipmentViewModel SelectedEquipment
        {
            get { return _selectedEquipment; }
            set { _selectedEquipment = value; base.RaisePropertyChanged(); }
        }

        public string BuyMessage
        {
            get { return _buyMessage; }
            set { _buyMessage = value; base.RaisePropertyChanged(); }
        }
       

        public List<EquipmentViewModel> ShowEquipment
        {
            get { return _showEquipment; }
            set { _showEquipment = value; base.RaisePropertyChanged(); }
        }

        public ICommand ShowCategoryEquipmentCommand;
        public ICommand BuyEquipmentCommand { get; set; }

        public ViewShopViewModel(NinjaViewModel selectedNinja, EquipmentListViewModel equipmentList, CategoryListViewModel categoryList)
        {
            this.Ninja = selectedNinja;
            this.EquipmentList = equipmentList;
            this.CategoryList = categoryList;
            this.BuyMessage = "Select an item in the list to purchase";

            //ShowCategoryEquipmentCommand = new RelayCommand(ShowCategoryEquipment);
            BuyEquipmentCommand = new RelayCommand(BuyEquipment);
        }

        public void BuyEquipment()
        {
            if (Ninja.Currency - SelectedEquipment.Price >= 0) 
            {
                Ninja.AddEquipment(SelectedEquipment);
                Ninja.Currency -= SelectedEquipment.Price;
                BuyMessage = "Equipment Purchased!";
            }
            else
            {
                BuyMessage = "Insufficient Funds!";
            }
        }

        public void ShowCategoryEquipment()
        {
            return;
        }

        //public EquipmentListViewModel ShowCategoryEquipment()
        //{
        //    //return CategoryList.Categorys.Where(c => c.Id == SelectedCategory.Id);
        //}
        private List<EquipmentViewModel> ChangeEquipment()
        {
            //ShowEquipment.Equipments = new ObservableCollection<EquipmentViewModel>(EquipmentList.Equipments.Where(c => c.Id == SelectedCategory.Id));
            ShowEquipment = EquipmentList.Equipments.Where(e => e.Category == SelectedCategory.Id).ToList();
            return ShowEquipment;
        }

    }
}
