using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using GalaSoft.MvvmLight.Command;

namespace Eindopdracht.ViewModel
{
    public class EditNinjaViewModel
    {
        public NinjaViewModel Ninja { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditNinjaViewModel(NinjaViewModel selectedNinja)
        {
            this.Ninja = selectedNinja;
            SaveCommand = new RelayCommand<EditNinjaWindow>(Save);
        }

        private void Save(EditNinjaWindow window)
        {
            using (var context = new EntitiesEntities1())
            {
                var ninja = Ninja.ToModel();

                context.Entry(ninja).State = EntityState.Modified;
                context.SaveChanges();
                window.Close();
            }

        }

    }
}
