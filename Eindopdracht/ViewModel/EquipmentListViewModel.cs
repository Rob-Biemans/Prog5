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
    public class EquipmentListViewModel : ViewModelBase
    {
        private AddEquipmentWindow _addEquipmentWindow;
        private OverviewCategoryWindow _overviewCategoryWindow;

        public ObservableCollection<EquipmentViewModel> Equipments { get; set; }

        private EquipmentViewModel _selectedEquipment;

        public EquipmentViewModel SelectedEquipment
        {
            get { return _selectedEquipment; }
            set
            {
                _selectedEquipment = value;
                base.RaisePropertyChanged();
            }
        }

        //Commands
        public ICommand ShowAddEquipmentCommand { get; set; }
        public ICommand DeleteEquipmentCommand { get; set; }
        public ICommand ShowEditEquipmentCommand { get; set; }
        public ICommand ShowViewEquipmentCommand { get; set; }
        public ICommand ShowViewCategoriesCommand { get; set; }

        public EquipmentListViewModel()
        {

            using (var context = new EntitiesEntities1())
            {
                var equipments = context.Equipments.ToList();
                Equipments = new ObservableCollection<EquipmentViewModel>(equipments.Select(e => new EquipmentViewModel(e)));
            }

            ShowAddEquipmentCommand = new RelayCommand(ShowAddEquipment, CanShowAddEquipment);
            DeleteEquipmentCommand = new RelayCommand(DeleteEquipment);

            ShowEditEquipmentCommand = new RelayCommand(ShowEditEquipment);
            ShowViewEquipmentCommand = new RelayCommand(ShowViewEquipment);

            ShowViewCategoriesCommand = new RelayCommand(ShowViewCategory, CanShowViewCategory);
        }

        public void OnChangeCollection()
        {
            Equipments.Clear();
            using (var context = new EntitiesEntities1())
            {
                context.Equipments.ToList().ForEach(e => Equipments.Add(new EquipmentViewModel(e, this)));
            }
        }

        public void ShowViewCategory()
        {
            _overviewCategoryWindow = new OverviewCategoryWindow();
            _overviewCategoryWindow.Show();
        }

        public bool CanShowViewCategory()
        {
            return _overviewCategoryWindow != null ? !_overviewCategoryWindow.IsVisible : true;
        }

        public bool CanShowAddEquipment()
        {
            return _addEquipmentWindow != null ? !_addEquipmentWindow.IsVisible : true;
        }

        public void ShowAddEquipment()
        {
            _addEquipmentWindow = new AddEquipmentWindow();
            _addEquipmentWindow.Show();
        }

        private void DeleteEquipment()
        {
            using (var context = new EntitiesEntities1())
            {
                var equipment = (Equipment)_selectedEquipment.ToModel();

                context.Entry(equipment).State = EntityState.Deleted;
                context.Equipments.Remove(equipment);
                context.SaveChanges();
            }
            OnChangeCollection();
        }

        public void ShowEditEquipment()
        {
            var editEquipment = new EditEquipmentWindow();
            editEquipment.Show();
        }

        public void ShowViewEquipment()
        {
            var viewEquipment = new ViewEquipmentWindow();
            viewEquipment.Show();
        }
    }
}
