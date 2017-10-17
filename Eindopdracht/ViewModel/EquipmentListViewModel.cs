using Eindopdracht.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.ViewModel
{
    public class EquipmentListViewModel : ViewModelBase
    {
        IEquipmentRepository equipmentRepository;

        public ObservableCollection<EquipmentViewModel> Equipment { get; set; }

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

        public EquipmentListViewModel()
        {
            equipmentRepository = new SeedEquipment();
            var equipmentList = equipmentRepository.GetEquipment().Select(e => new EquipmentViewModel(e));
            Equipment = new ObservableCollection<EquipmentViewModel>(equipmentList);
        }
    }
}
