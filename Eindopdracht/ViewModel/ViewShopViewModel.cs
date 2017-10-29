using Eindopdracht.Model;
using Eindopdracht.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class ViewShopViewModel : ViewModelBase
    {
        private ViewNinjaWindow _ninjaWindow;

        private List<EquipmentViewModel> _showEquipment;
        private CategoryViewModel _selectedCategory;
        private EquipmentViewModel _selectedEquipment;
        private string _buyMessage;

        public NinjaViewModel Ninja { get; set; }
        public EquipmentListViewModel EquipmentList { get; set; }
        public CategoryListViewModel CategoryList { get; set; }
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

        public ObservableCollection<EquipmentViewModel> NinjaEquipment { get; set; }

        public ICommand ShowCategoryEquipmentCommand;
        public ICommand BuyEquipmentCommand { get; set; }
        public ICommand SellEquipmentCommand { get; set; }
        public ICommand SellAllEquipmentCommand { get; set; }

        public ViewShopViewModel(NinjaViewModel selectedNinja, EquipmentListViewModel equipmentList, CategoryListViewModel categoryList)
        {
            this.Ninja = selectedNinja;
            this.NinjaEquipment = Ninja.ConvertInventory();
            this.EquipmentList = equipmentList;
            this.CategoryList = categoryList;
            this.BuyMessage = "Select an item in the list to purchase";

            BuyEquipmentCommand = new RelayCommand(BuyEquipment);
            SellEquipmentCommand = new RelayCommand(SellEquipment);
            SellAllEquipmentCommand = new RelayCommand(SellAllEquipment);
        }

        private void SellAllEquipment()
        {
            Ninja.SellAllEquipment();
            NinjaEquipment.Clear();
            List<InventoryViewModel> inventory = new List<InventoryViewModel>();
            Ninja.Inventory.ForEach(i => {
                using (var context = new EntitiesEntities1())
                {
                    Inventory row = (Inventory)new InventoryViewModel(i.Id, Ninja.Id).ToModel();
                    context.Inventories.Remove(row);
                    context.SaveChanges();
                }
            });
            
            BuyMessage = "Items sold!";
        }

        private void SellEquipment()
        {
            if (SelectedEquipment == null)
                return;
            Ninja.Currency += SelectedEquipment.Price;
            Ninja.SellEquipment(SelectedEquipment);
            NinjaEquipment.Remove(SelectedEquipment);
            BuyMessage = "Item sold!";
        }

        public void BuyEquipment()
        {
            if (SelectedEquipment == null)
                return;
            if (Ninja.Currency - SelectedEquipment.Price >= 0)
            {
                Ninja.AddEquipment(SelectedEquipment);
                
                Ninja.Currency -= SelectedEquipment.Price;
                NinjaEquipment.Add(SelectedEquipment);
                
                InventoryViewModel inventory = new InventoryViewModel(SelectedEquipment.Id, Ninja.Id);
                using (var context = new EntitiesEntities1())
                {
                    Inventory row = (Inventory)inventory.ToModel();
                    context.Inventories.Add(row);
                    context.SaveChanges();
                }
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
        

        private List<EquipmentViewModel> ChangeEquipment()
        {
            ShowEquipment = EquipmentList.Equipments.Where(e => e.Category == SelectedCategory.Id).ToList();
            return ShowEquipment;
        }


    }
}
