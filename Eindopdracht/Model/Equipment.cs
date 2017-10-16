using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class Equipment
    {
        public int ID { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public Nullable<int> ninjaID { get; set; }

        public int agility { get; set; }
        public int strenght { get; set; }
        public int intelligence { get; set; }

        public virtual Ninja ninja { get; set; }
    }
}
