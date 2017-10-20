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

        public CategoryViewModel(Category category)
        {
            _category = category;
        }

        public CategoryViewModel()
        {
            _category = new Category();
        }

    }
}
