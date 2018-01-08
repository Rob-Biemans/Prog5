using Eindopdracht.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Repositories
{
    public class NinjaRepository
    {
        public NinjaRepository()
        {

        }

        public ICollection<NinjaViewModel> GetNinjas()
        {
            List<NinjaViewModel> ninjas = new List<NinjaViewModel>();
            using (var context = new Entities())
            {
                context.Ninjas.ToList().ForEach(n => ninjas.Add(new NinjaViewModel(n)));
            }
            return ninjas;
        }
    }
}
