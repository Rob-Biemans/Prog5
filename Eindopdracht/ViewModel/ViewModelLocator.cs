using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Eindopdracht.Model;

namespace Eindopdracht.ViewModel
{
    public class ViewModelLocator
    {

        private NinjaListViewModel _ninjaList;
        private EquipmentListViewModel _equipmentList;
        private CategoryListViewModel _categoryList;

        public ViewModelLocator()
        {
            _ninjaList = new ViewModel.NinjaListViewModel();
            _equipmentList = new EquipmentListViewModel();
            _categoryList = new CategoryListViewModel();

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<NinjaListViewModel>();
            SimpleIoc.Default.Register<EquipmentListViewModel>();
            SimpleIoc.Default.Register<CategoryListViewModel>();
        }

        public NinjaListViewModel NinjaList
        {
            get
            {
                return _ninjaList;
            }
        }

        public EditNinjaViewModel UpdateNinja
        {
            get
            {
                return new EditNinjaViewModel(_ninjaList.SelectedNinja);
            }
        }

        public AddNinjaViewModel AddNinja
        {
            get
            { 
                return new AddNinjaViewModel(_ninjaList);
            }
        }

        public ViewNinjaViewModel ViewNinja
        {
            get
            {
                return new ViewNinjaViewModel(_ninjaList.SelectedNinja);
            }
        }

        public ShopViewModel ViewShop
        {
            get
            {
                return new ShopViewModel(_ninjaList.SelectedNinja, _equipmentList, _categoryList);
            }
        }

        public EquipmentListViewModel EquipmentList
        {
            get
            {
                return _equipmentList;
            }
        }

        public EditEquipmentViewModel UpdateEquipment
        {
            get
            {
                return new EditEquipmentViewModel(_equipmentList.SelectedEquipment);
            }
        }

        public AddEquipmentViewModel AddEquipment
        {
            get
            {
                return new AddEquipmentViewModel(_equipmentList);
            }
        }

        public ViewEquipmentViewModel ViewEquipment
        {
            get
            {
                return new ViewEquipmentViewModel(_equipmentList.SelectedEquipment);
            }
        }


        public CategoryListViewModel CategoryList
        {
            get
            {
                return _categoryList;
            }
        }

        public EditCategoryViewModel UpdateCategory
        {
            get
            {
                return new EditCategoryViewModel(_categoryList.SelectedCategory);
            }
        }

        public AddCategoryViewModel AddCategory
        {
            get
            {
                return new AddCategoryViewModel(_categoryList);
            }
        }

    }
}
