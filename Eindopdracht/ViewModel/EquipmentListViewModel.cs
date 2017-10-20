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

namespace Eindopdracht.ViewModel
{
    public class EquipmentListViewModel : ViewModelBase
    {
        private AddEquipmentWindow _addEquipmentWindow;
        private OverviewCategoryWindow _overviewCategoryWindow;

        IEquipmentRepository equipmentRepository;

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
            equipmentRepository = new SeedEquipment();
            var equipmentList = equipmentRepository.GetEquipments().Select(e => new EquipmentViewModel(e));
            Equipments = new ObservableCollection<EquipmentViewModel>(equipmentList);

            ShowAddEquipmentCommand = new RelayCommand(ShowAddEquipment, CanShowAddEquipment);
            DeleteEquipmentCommand = new RelayCommand(DeleteEquipment);

            ShowEditEquipmentCommand = new RelayCommand(ShowEditEquipment);
            ShowViewEquipmentCommand = new RelayCommand(ShowViewEquipment);

            ShowViewCategoriesCommand = new RelayCommand(ShowViewCategory, CanShowViewCategory);
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
            Equipments.Remove(SelectedEquipment);
        }

        public void ShowEditEquipment()
        {
            var editEquipment = new EditEquipmentWindow();
            editEquipment.Show();
        }

        public void HideAddEquipment()
        {
            _addEquipmentWindow.Close();
        }

        public void ShowViewEquipment()
        {
            var viewEquipment = new ViewEquipmentWindow();
            viewEquipment.Show();
        }
    }
}
