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
    public class ShopViewModel : ViewModelBase
    {
        private ViewNinjaWindow _ninjaWindow;

        private List<EquipmentViewModel> _showEquipment;
        private CategoryViewModel _selectedCategory;
        private EquipmentViewModel _selectedEquipment;
        private OverviewEquipmentWindow _overviewEquipmentWindow;
        private string _buyMessage;

        public NinjaViewModel Ninja { get; set; }
        public EquipmentListViewModel EquipmentList { get; set; }
        public CategoryListViewModel CategoryList { get; set; }
        public CategoryViewModel SelectedCategory
        {
            get { return _selectedCategory; }
            set { _selectedCategory = value; ShowEquipment = _selectedCategory.GetEquipment(); RaisePropertyChanged("SelectedCategory"); }
        }
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
        public ICommand ShowViewEquipmentCommand { get; set; }

        public ShopViewModel(NinjaViewModel selectedNinja, EquipmentListViewModel equipmentList, CategoryListViewModel categoryList)
        {
            this.Ninja = selectedNinja;
            this.NinjaEquipment = new ObservableCollection<EquipmentViewModel>(Ninja.GetEquipment().ToList());
            // FIx this
            this.EquipmentList = new EquipmentListViewModel(selectedNinja.GetEquipment());
            this.CategoryList = categoryList;
            this.BuyMessage = "Select an item in the list to purchase";

            BuyEquipmentCommand = new RelayCommand(BuyEquipment);
            SellEquipmentCommand = new RelayCommand(SellEquipment);
            SellAllEquipmentCommand = new RelayCommand(SellAllEquipment);

            ShowViewEquipmentCommand = new RelayCommand(ShowViewEquipment, CanShowViewEquipment);
        }

        public void ShowViewEquipment()
        {
            _overviewEquipmentWindow = new OverviewEquipmentWindow();
            _overviewEquipmentWindow.Show();
        }

        public bool CanShowViewEquipment()
        {
            return _overviewEquipmentWindow != null ? !_overviewEquipmentWindow.IsVisible : true;
        }

        private void SellAllEquipment()
        {
            Ninja.SellAllEquipment();
            NinjaEquipment.Clear();

            using (var context = new Entities())
            {
                var ninja = context.Ninjas.Find(Ninja.Id);
                ninja.Equipments.Clear();
                context.SaveChanges();
            }

            BuyMessage = "Items sold!";
        }

        private void SellEquipment()
        {
            
            if (SelectedEquipment == null)
                return;
                

            using (var context = new Entities())
            {
                var ninja = context.Ninjas.Find(Ninja.Id);
                var eq = context.Equipments.Find(SelectedEquipment.Id);
                ninja.Equipments.Remove(eq);
                context.SaveChanges();
            }
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
            return ShowEquipment;
        }


    }
}
