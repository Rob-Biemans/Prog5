using GalaSoft.MvvmLight.Command;
using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using System;
using System.Reflection;

namespace Eindopdracht.ViewModel
{
    public class AddNinjaViewModel
    {
        private NinjaListViewModel _ninjaList;

        public NinjaViewModel Ninja { get; set; }

        public ICommand AddNinjaCommand { get; set; }

        public AddNinjaViewModel(NinjaListViewModel NinjaList)
        {
            this._ninjaList = NinjaList;
            this.Ninja = new NinjaViewModel();
            AddNinjaCommand = new RelayCommand<AddNinjaWindow>(AddNinja);
        }

        private void AddNinja(AddNinjaWindow window)
        {
            using (var context = new Entities())
            {
                context.Ninjas.Add((Ninja)Ninja.ToModel());
                context.SaveChanges();
            }
            window.Close();
            _ninjaList.OnChangeCollection();
        }

        public bool CanAddNinja()
        {
            return true;
        }
    }
}
