using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Model
{
    class SeedCategory : ICategoriesRepository
    {
        public List<Category> GetCategories()
        {
            using (var context = new Entities())
            {
                return context.Categories.ToList();
            }
            //var categories = new List<Category>();

            //categories.Add(new Category { Id = 1, Name = "Helm" });
            //categories.Add(new Category { Id = 2, Name = "Shoulders" });
            //categories.Add(new Category { Id = 3, Name = "Chest" });
            //categories.Add(new Category { Id = 4, Name = "Belt" });
            //categories.Add(new Category { Id = 5, Name = "Legs" });
            //categories.Add(new Category { Id = 6, Name = "Boots" });

            //return categories;
        }
    }
}
