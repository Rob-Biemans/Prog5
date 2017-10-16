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

            equipments.Add(new Equipment { ID = 1, name = "Bronze", price = 200, category = "Shoulders" });
            equipments.Add(new Equipment { ID = 2, name = "Iron", price = 800, category = "Shoulders" });
            equipments.Add(new Equipment { ID = 3, name = "Gold", price = 1200, category = "Shoulders" });
            equipments.Add(new Equipment { ID = 4, name = "Platinum", price = 1400, category = "Shoulders" });

            equipments.Add(new Equipment { ID = 1, name = "Bronze", price = 200, category = "Chest" });
            equipments.Add(new Equipment { ID = 2, name = "Iron", price = 800, category = "Chest" });
            equipments.Add(new Equipment { ID = 3, name = "Gold", price = 1200, category = "Chest" });
            equipments.Add(new Equipment { ID = 4, name = "Platinum", price = 1400, category = "Chest" });

            equipments.Add(new Equipment { ID = 1, name = "Bronze", price = 200, category = "Belt" });
            equipments.Add(new Equipment { ID = 2, name = "Iron", price = 800, category = "Belt" });
            equipments.Add(new Equipment { ID = 3, name = "Gold", price = 1200, category = "Belt" });
            equipments.Add(new Equipment { ID = 4, name = "Platinum", price = 1400, category = "Belt" });

            equipments.Add(new Equipment { ID = 1, name = "Bronze", price = 200, category = "Legs" });
            equipments.Add(new Equipment { ID = 2, name = "Iron", price = 800, category = "Legs" });
            equipments.Add(new Equipment { ID = 3, name = "Gold", price = 1200, category = "Legs" });
            equipments.Add(new Equipment { ID = 4, name = "Platinum", price = 1400, category = "Legs" });

            equipments.Add(new Equipment { ID = 1, name = "Bronze", price = 200, category = "Boots" });
            equipments.Add(new Equipment { ID = 2, name = "Iron", price = 800, category = "Boots" });
            equipments.Add(new Equipment { ID = 3, name = "Gold", price = 1200, category = "Boots" });
            equipments.Add(new Equipment { ID = 4, name = "Platinum", price = 1400, category = "Boots" });

            return equipments;
        }
    }
}
