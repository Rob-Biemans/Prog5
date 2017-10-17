using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    public class Ninja
    {
        public Ninja()
        {
            this.Inventory = new List<Equipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Currency { get; set; }

        public virtual List<Equipment> Inventory { get; set; }
    }
}
