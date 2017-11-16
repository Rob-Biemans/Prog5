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
    public class NinjaListViewModel : ViewModelBase
    {
        private AddNinjaWindow _addNinjaWindow;

        INinjaRepository ninjaRepository;

        public ObservableCollection<NinjaViewModel> Ninjas { get; set; }

        private NinjaViewModel _selectedNinja;

        public NinjaViewModel SelectedNinja
        {
            get { return _selectedNinja; }
            set
            {
                _selectedNinja = value;
                base.RaisePropertyChanged();
            }
        }

        //Commands
        public ICommand ShowAddNinjaCommand { get; set; }
        public ICommand DeleteNinjaCommand { get; set; }
        public ICommand ShowEditNinjaCommand { get; set; }
        public ICommand ShowViewNinjaCommand { get; set; }
        public ICommand ShowViewEquipmentCommand { get; set; }

        public NinjaListViewModel()
        {
            ninjaRepository = new SeedNinja();

            using (var context = new EntitiesEntities1())
            {
                var ninjas = context.Ninjas.ToList();
                Ninjas = new ObservableCollection<NinjaViewModel>(ninjas.Select(n => new NinjaViewModel(n)));
            }

            ShowAddNinjaCommand = new RelayCommand(ShowAddNinja, CanShowAddNinja);
            DeleteNinjaCommand = new RelayCommand(DeleteNinja);

            ShowEditNinjaCommand = new RelayCommand(ShowEditNinja);
            ShowViewNinjaCommand = new RelayCommand(ShowViewNinja);

        }


        public bool CanShowViewEquipment()
        {
            return _addNinjaWindow != null ? !_addNinjaWindow.IsVisible : true;
        }

        public bool CanShowAddNinja()
        {
            return _addNinjaWindow != null ? !_addNinjaWindow.IsVisible : true;
        }

        public void ShowAddNinja()
        {
            _addNinjaWindow = new AddNinjaWindow();
            _addNinjaWindow.Show();
        }

        private void DeleteNinja()
        {
            using (var context = new EntitiesEntities1())
            {
                var ninja = (Ninja)_selectedNinja.ToModel();

                context.Entry(ninja).State = EntityState.Deleted;
                context.Ninjas.Remove(ninja);
                context.SaveChanges();
            }
        }

        public void ShowEditNinja()
        {
            var editNinja = new EditNinjaWindow();
            editNinja.Show();
        }

        public void HideAddNinja()
        {
            _addNinjaWindow.Close();
        }

        public void ShowViewNinja()
        {
            var viewNinja = new ViewNinjaWindow();
            viewNinja.Show();
        }
    }
}
