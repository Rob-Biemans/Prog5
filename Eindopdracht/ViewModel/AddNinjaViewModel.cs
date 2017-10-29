﻿using GalaSoft.MvvmLight.Command;
using Eindopdracht.Model;
using System.Windows.Input;
using System.Data.Entity;
using Eindopdracht.View;
using System;

namespace Eindopdracht.ViewModel
{
    public class AddNinjaViewModel
    {
        private NinjaListViewModel _ninjaList;

        public NinjaViewModel Ninja { get; set; }
        Random ran = new Random();

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
                var ninja = (Ninja)Ninja.ToModel();
                //Even aan entity framework laten weten dat we dingen hebben aangepast!
                context.Entry(ninja).State = EntityState.Added;
                ninja.Id = ran.Next(1, 1000000000);
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }

        public bool CanAddNinja()
        {
            return true;
        }
    }
}
