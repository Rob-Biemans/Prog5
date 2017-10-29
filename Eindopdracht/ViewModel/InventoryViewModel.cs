using GalaSoft.MvvmLight;
using Eindopdracht.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Eindopdracht.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.ViewModel
{
    public class InventoryViewModel : ViewModelBase
    {
        private Inventory _inventory;

        public int Id
        {
            get { return _inventory.Id; }
        }

        public int NinjaId
        {
            get { return _inventory.NinjaID; }
            set { _inventory.NinjaID = value; }
        }

        public int EquipmentId
        {
            get { return _inventory.EquipmentID; }
            set { _inventory.EquipmentID = value; }
        }

        internal object ToModel()
        {
            return _inventory;
        }

        public InventoryViewModel()
        {
            this._inventory = new Inventory();
        }

        public InventoryViewModel(int equipmentId, int ninjaId)
        {
            _inventory = new Inventory();
            EquipmentId = equipmentId;
            NinjaId = ninjaId;
        }
    }
}
