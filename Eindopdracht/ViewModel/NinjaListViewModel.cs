using GalaSoft.MvvmLight;
using Eindopdracht.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Eindopdracht.ViewModel
{
    class NinjaListViewModel : ViewModelBase
    {
        IEquipmentRepository equipmentRepository;

        public ObservableCollection<NinjaListViewModel> ninjas { get; set; }

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
    }
}
