using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class EditEquipmentViewModel
    {
        public EquipmentViewModel Equipment { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditEquipmentViewModel(EquipmentViewModel selectedEquipment)
        {
            this.Equipment = selectedEquipment;
        }
    }
}
