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
        public string Name { get; set; }
        public string Summary { get; set; }
        public Nullable<int> NinjaId { get; set; }

        public virtual Ninja Ninja { get; set; }
    }
}
