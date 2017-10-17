using Eindopdracht.Model;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class ViewEquipmentViewModel
    {
        public EquipmentViewModel Equipment { get; set; }

        public ViewEquipmentViewModel(EquipmentViewModel selectedEquipment)
        {
            this.Equipment = selectedEquipment;
        }
    }
}
