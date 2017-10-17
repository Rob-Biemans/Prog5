using Eindopdracht.Model;
using System.Windows.Input;

namespace Eindopdracht.ViewModel
{
    public class ViewNinjaViewModel
    {
        public NinjaViewModel Ninja { get; set; }

        public ViewNinjaViewModel(NinjaViewModel selectedNinja)
        {
            this.Ninja = selectedNinja;
        }
    }
}
