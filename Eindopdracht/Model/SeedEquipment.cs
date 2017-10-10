using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class SeedEquipment : IEquipmentRepository
    {
        public List<Equipment> GetEquipment()
        {
            var equipments = new List<Equipment>();

            equipments.Add(new Equipment { Id = 1, Name = "Madonna", Summary = "Holiday", NinjaId = 1 });
            equipments.Add(new Equipment { Id = 2, Name = "Prince", Summary = "1999", NinjaId = 1 });
            equipments.Add(new Equipment { Id = 3, Name = "Michael Jackson", Summary = "Billy Jean", NinjaId = 1 });
            equipments.Add(new Equipment { Id = 4, Name = "U2", Summary = "One", NinjaId = 1 });

            return equipments;
        }
    }
}
