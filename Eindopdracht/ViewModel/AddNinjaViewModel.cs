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
            AddNinjaCommand = new RelayCommand(AddNinja);
        }

        private void AddNinja()
        {
            using (var context = new EntitiesEntities1())
            {
                context.Ninjas.Add((Ninja)Ninja.ToModel());
                context.SaveChanges();
                this._ninjaList.HideAddNinja();
            }
        }

        public bool CanAddNinja()
        {
            return true;
        }
    }
}
