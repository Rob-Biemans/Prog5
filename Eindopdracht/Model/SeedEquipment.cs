using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class SeedEquipment : IEquipmentRepository
    {
        public List<Equipment> GetEquipments()
        {
            var equipments = new List<Equipment>();

            equipments.Add(new Equipment { Id = 1, Name = "Bronze", Price = 200, Category = "Head" });
            equipments.Add(new Equipment { Id = 2, Name = "Iron", Price = 800, Category = "Head" });
            equipments.Add(new Equipment { Id = 3, Name = "Gold", Price = 1200, Category = "Head" });
            equipments.Add(new Equipment { Id = 4, Name = "Platinum", Price = 1400, Category = "Head" });

            equipments.Add(new Equipment { Id = 5, Name = "Bronze", Price = 200, Category = "Shoulders" });
            equipments.Add(new Equipment { Id = 6, Name = "Iron", Price = 800, Category = "Shoulders" });
            equipments.Add(new Equipment { Id = 7, Name = "Gold", Price = 1200, Category = "Shoulders" });
            equipments.Add(new Equipment { Id = 8, Name = "Platinum", Price = 1400, Category = "Shoulders" });

            equipments.Add(new Equipment { Id = 9, Name = "Bronze", Price = 200, Category = "Chest" });
            equipments.Add(new Equipment { Id = 10, Name = "Iron", Price = 800, Category = "Chest" });
            equipments.Add(new Equipment { Id = 11, Name = "Gold", Price = 1200, Category = "Chest" });
            equipments.Add(new Equipment { Id = 12, Name = "Platinum", Price = 1400, Category = "Chest" });

            equipments.Add(new Equipment { Id = 13, Name = "Bronze", Price = 200, Category = "Belt" });
            equipments.Add(new Equipment { Id = 14, Name = "Iron", Price = 800, Category = "Belt" });
            equipments.Add(new Equipment { Id = 15, Name = "Gold", Price = 1200, Category = "Belt" });
            equipments.Add(new Equipment { Id = 16, Name = "Platinum", Price = 1400, Category = "Belt" });

            equipments.Add(new Equipment { Id = 17, Name = "Bronze", Price = 200, Category = "Legs" });
            equipments.Add(new Equipment { Id = 18, Name = "Iron", Price = 800, Category = "Legs" });
            equipments.Add(new Equipment { Id = 19, Name = "Gold", Price = 1200, Category = "Legs" });
            equipments.Add(new Equipment { Id = 20, Name = "Platinum", Price = 1400, Category = "Legs" });

            equipments.Add(new Equipment { Id = 21, Name = "Bronze", Price = 200, Category = "Boots" });
            equipments.Add(new Equipment { Id = 22, Name = "Iron", Price = 800, Category = "Boots" });
            equipments.Add(new Equipment { Id = 23, Name = "Gold", Price = 1200, Category = "Boots" });
            equipments.Add(new Equipment { Id = 24, Name = "Platinum", Price = 1400, Category = "Boots" });

            return equipments;
        }
    }
}
