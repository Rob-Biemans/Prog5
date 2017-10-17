using Eindopdracht.Model;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class EditNinjaViewModel
    {
        public NinjaViewModel Ninja { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditNinjaViewModel(NinjaViewModel selectedNinja)
        {
            this.Ninja = selectedNinja;
        }

    }
}
