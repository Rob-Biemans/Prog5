using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class Ninja
    {
        public Ninja()
        {
            this.inventory = new HashSet<Equipment>();
        }

        public int ID { get; set; }
        public string name { get; set; }
        public string skills { get; set; }
        public int currency { get; set; }

        public virtual ICollection<Equipment> inventory { get; set; }
    }
}
