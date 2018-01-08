using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    interface INinjaRepository
    {
        ICollection<Ninja> GetNinjas();
    }
}
