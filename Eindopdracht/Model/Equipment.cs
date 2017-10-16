using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class Equipment
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Nullable<int> NinjaId { get; set; }

        public int Agility { get; set; }
        public int Strenght { get; set; }
        public int Intelligence { get; set; }

        public virtual Ninja Ninja { get; set; }
    }
}
