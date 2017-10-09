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
            this.Inventory = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Skills { get; set; }

        public virtual ICollection<Equipment> Inventory { get; set; }
    }
}
