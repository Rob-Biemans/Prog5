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
using Eindopdracht.Repositories;

namespace Eindopdracht.ViewModel
{
    public class NinjaListViewModel : ViewModelBase
    {
        private AddNinjaWindow _addNinjaWindow;

        public ObservableCollection<NinjaViewModel> Ninjas { get; set; }

        private NinjaViewModel _selectedNinja;
        private NinjaRepository _ninjaRepository;

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

            //using (var context = new Entities())
            //{
            //    var ninjas = context.Ninjas.ToList();
            //    Ninjas = new ObservableCollection<NinjaViewModel>(ninjas.Select(n => new NinjaViewModel(n)));
            //}
            _ninjaRepository = new NinjaRepository();
            Ninjas = new ObservableCollection<NinjaViewModel>(_ninjaRepository.GetNinjas());

            ShowAddNinjaCommand = new RelayCommand(ShowAddNinja, CanShowAddNinja);
            DeleteNinjaCommand = new RelayCommand(DeleteNinja);

            ShowEditNinjaCommand = new RelayCommand(ShowEditNinja);
            ShowViewNinjaCommand = new RelayCommand(ShowViewNinja);

        }

        public void OnChangeCollection()
        {
            Ninjas.Clear();
            using (var context = new Entities())
            {
                context.Ninjas.ToList().ForEach(n => Ninjas.Add(new NinjaViewModel(n, this)));
            }
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
            using (var context = new Entities())
            {
                var ninja = (Ninja)_selectedNinja.ToModel();

                context.Entry(ninja).State = EntityState.Deleted;
                context.Ninjas.Remove(ninja);
                context.SaveChanges();
            }
            OnChangeCollection();
        }

        public void ShowEditNinja()
        {
            var editNinja = new EditNinjaWindow();
            editNinja.Show();
        }

        public void ShowViewNinja()
        {
            var viewNinja = new ViewNinjaWindow();
            viewNinja.Show();
        }
    }
}
