using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Eindopdracht.Model;

namespace Eindopdracht.ViewModel
{
    class ViewModelLocator
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

    }
}
