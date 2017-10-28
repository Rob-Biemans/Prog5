using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class SeedNinja : INinjaRepository
    {
        public List<Ninja> GetNinjas()
        {

            using (var context = new EntitiesEntities1())
            {
                return context.Ninjas.ToList();
            }
            //var ninjas = new List<Ninja>();

            //ninjas.Add(new Ninja { Id = 1, Name = "Rob", Currency = 10000 });
            //ninjas.Add(new Ninja { Id = 2, Name = "Daan", Currency = 10000 });
            //ninjas.Add(new Ninja { Id = 3, Name = "Piet", Currency = 10000 });
            //ninjas.Add(new Ninja { Id = 4, Name = "Ethiopie", Currency = 10000 });

            //return ninjas;
        }
    }
}
