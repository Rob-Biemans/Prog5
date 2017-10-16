using GalaSoft.MvvmLight.Command;
using Eindopdracht.Model;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class AddNinjaViewModel
    {
        private NinjaListViewModel _ninjaList;

        public NinjaViewModel Ninja { get; set; }

        public ICommand AddNinjaCommand { get; set; }

        public AddNinjaViewModel(NinjaListViewModel NinjaList)
        {
            this._ninjaList = NinjaList;
            this.Ninja = new NinjaViewModel();
            AddNinjaCommand = new RelayCommand(AddNinja, CanAddNinja);
        }

        private void AddNinja()
        {
            _ninjaList.Ninjas.Add(Ninja);
            _ninjaList.HideAddNinja();
        }

        public bool CanAddNinja()
        {
            return true;
        }
    }
}
