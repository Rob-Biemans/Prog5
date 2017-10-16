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

    }
}
