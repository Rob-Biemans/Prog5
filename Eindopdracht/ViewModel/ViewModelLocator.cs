using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Eindopdracht.Model;

namespace Eindopdracht.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<NinjaListViewModel>();
            SimpleIoc.Default.Register<EquipmentListViewModel>();
            SimpleIoc.Default.Register<CategoryListViewModel>();
        }

        public NinjaListViewModel NinjaList
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NinjaListViewModel>();
            }
        }

        public EditNinjaViewModel UpdateNinja
        {
            get
            {
                return new EditNinjaViewModel(NinjaList.SelectedNinja);
            }
        }

        public AddNinjaViewModel AddNinja
        {
            get
            { 
                return new AddNinjaViewModel(this.NinjaList);
            }
        }

        public ViewNinjaViewModel ViewNinja
        {
            get
            {
                return new ViewNinjaViewModel(NinjaList.SelectedNinja);
            }
        }

        public EquipmentListViewModel EquipmentList
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EquipmentListViewModel>();
            }
        }

        public EditEquipmentViewModel UpdateEquipment
        {
            get
            {
                return new EditEquipmentViewModel(EquipmentList.SelectedEquipment);
            }
        }

        public AddEquipmentViewModel AddEquipment
        {
            get
            {
                return new AddEquipmentViewModel(this.EquipmentList);
            }
        }

        public ViewEquipmentViewModel ViewEquipment
        {
            get
            {
                return new ViewEquipmentViewModel(EquipmentList.SelectedEquipment);
            }
        }


        public CategoryListViewModel CategoryList
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CategoryListViewModel>();
            }
        }

        public EditCategoryViewModel UpdateCategory
        {
            get
            {
                return new EditCategoryViewModel(CategoryList.SelectedCategory);
            }
        }

        public AddCategoryViewModel AddCategory
        {
            get
            {
                return new AddCategoryViewModel(this.CategoryList);
            }
        }

    }
}
