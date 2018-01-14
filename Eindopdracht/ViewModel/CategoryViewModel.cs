using Eindopdracht.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.ViewModel
{
    public class CategoryViewModel : ViewModelBase
    {
        public int Id
        {
            get { return _category.Id; }
            set { _category.Id = value; RaisePropertyChanged("Id"); }
        }

        public string Name
        {
            get { return _category.Name; }
            set { _category.Name = value; RaisePropertyChanged("Name"); }
        }

        private Category _category;
        private CategoryListViewModel _categoryList;

        public CategoryViewModel(Category category, CategoryListViewModel categorylist)
        {
            _category = category;
        }

        public CategoryViewModel(CategoryListViewModel categorylist)
        {
            _categoryList = categorylist;
        }

        public CategoryViewModel(Category category)
        {
            _category = category;
        }

        public Category ToModel()
        {
            return _category;
        }

        public CategoryViewModel()
        {
            _category = new Category();
        }

        public ICollection<Equipment> Equipments
        {
            get { return _category.Equipments; }
            set { _category.Equipments = value; }
        }

        public List<EquipmentViewModel> GetEquipment()
        {
            List<EquipmentViewModel> equipment = new List<EquipmentViewModel>();
            using (var context = new Entities())
            {
                context.Equipments.Where(e => e.CategoryID == _category.Id).ToList().ForEach(e => equipment.Add(new EquipmentViewModel(e)));
            }
            return equipment;
        }

    }
}
