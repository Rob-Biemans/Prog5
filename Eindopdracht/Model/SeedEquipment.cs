using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class SeedEquipment : IEquipmentRepository
    {
        public List<Equipment> GetInventory(int ninjaId)
        {
            using (var context = new Entities())
            {
                List<Equipment> equipment = new List<Equipment>();
                return equipment;
            }
        }
        

        public List<Equipment> GetEquipments()
        {
            using (var context = new Entities())
            {
                return context.Equipments.ToList();
            }

            //var equipments = new List<Equipment>();

            //equipments.Add(new Equipment { Id = 1, Name = "Bronze", Price = 200, Category = 1, Agility = 1, Strenght = 1, Intelligence = 1 });
            //equipments.Add(new Equipment { Id = 2, Name = "Iron", Price = 800, Category = 1, Agility = 2, Strenght = 2, Intelligence = 2 });
            //equipments.Add(new Equipment { Id = 3, Name = "Gold", Price = 1200, Category = 1, Agility = 3, Strenght = 3, Intelligence = 3 });
            //equipments.Add(new Equipment { Id = 4, Name = "Platinum", Price = 1400, Category = 1, Agility = 4, Strenght = 4, Intelligence = 4 });

            //equipments.Add(new Equipment { Id = 5, Name = "Bronze", Price = 200, Category = 2, Agility = 1, Strenght = 1, Intelligence = 1 });
            //equipments.Add(new Equipment { Id = 6, Name = "Iron", Price = 800, Category = 2, Agility = 2, Strenght = 2, Intelligence = 2 });
            //equipments.Add(new Equipment { Id = 7, Name = "Gold", Price = 1200, Category = 2, Agility = 3, Strenght = 3, Intelligence = 3 });
            //equipments.Add(new Equipment { Id = 8, Name = "Platinum", Price = 1400, Category = 2, Agility = 4, Strenght = 4, Intelligence = 4 });

            //equipments.Add(new Equipment { Id = 9, Name = "Bronze", Price = 200, Category = 3, Agility = 1, Strenght = 1, Intelligence = 1 });
            //equipments.Add(new Equipment { Id = 10, Name = "Iron", Price = 800, Category = 3, Agility = 2, Strenght = 2, Intelligence = 2 });
            //equipments.Add(new Equipment { Id = 11, Name = "Gold", Price = 1200, Category = 3, Agility = 3, Strenght = 3, Intelligence = 3 });
            //equipments.Add(new Equipment { Id = 12, Name = "Platinum", Price = 1400, Category = 3, Agility = 4, Strenght = 4, Intelligence = 4 });

            //equipments.Add(new Equipment { Id = 13, Name = "Bronze", Price = 200, Category = 4, Agility = 1, Strenght = 1, Intelligence = 1 });
            //equipments.Add(new Equipment { Id = 14, Name = "Iron", Price = 800, Category = 4, Agility = 2, Strenght = 2, Intelligence = 2 });
            //equipments.Add(new Equipment { Id = 15, Name = "Gold", Price = 1200, Category = 4, Agility = 3, Strenght = 3, Intelligence = 3 });
            //equipments.Add(new Equipment { Id = 16, Name = "Platinum", Price = 1400, Category = 4, Agility = 4, Strenght = 4, Intelligence = 4 });

            //equipments.Add(new Equipment { Id = 17, Name = "Bronze", Price = 200, Category = 5, Agility = 1, Strenght = 1, Intelligence = 1 });
            //equipments.Add(new Equipment { Id = 18, Name = "Iron", Price = 800, Category = 5, Agility = 2, Strenght = 2, Intelligence = 2 });
            //equipments.Add(new Equipment { Id = 19, Name = "Gold", Price = 1200, Category = 5, Agility = 3, Strenght = 3, Intelligence = 3 });
            //equipments.Add(new Equipment { Id = 20, Name = "Platinum", Price = 1400, Category = 5, Agility = 4, Strenght = 4, Intelligence = 4 });

            //equipments.Add(new Equipment { Id = 21, Name = "Bronze", Price = 200, Category = 6, Agility = 1, Strenght = 1, Intelligence = 1 });
            //equipments.Add(new Equipment { Id = 22, Name = "Iron", Price = 800, Category = 6, Agility = 2, Strenght = 2, Intelligence = 2 });
            //equipments.Add(new Equipment { Id = 23, Name = "Gold", Price = 1200, Category = 6, Agility = 3, Strenght = 3, Intelligence = 3 });
            //equipments.Add(new Equipment { Id = 24, Name = "Platinum", Price = 1400, Category = 6, Agility = 4, Strenght = 4, Intelligence = 4 });

            //return equipments;
        }
    }
}
