using Eindopdracht.Model;
using Eindopdracht.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class ViewNinjaViewModel : ViewModelBase
    {
        private ShopWindow _shopWindow;

        public NinjaViewModel Ninja { get; set; }

        public ICommand ShowShopViewCommand { get; set; }

        public ViewNinjaViewModel(NinjaViewModel selectedNinja)
        {
            this.Ninja = selectedNinja;
            ShowShopViewCommand = new RelayCommand(ShowShop);
        }

        public void ShowShop()
        {
            _shopWindow = new ShopWindow();
            _shopWindow.Show();
        }
    }
}
