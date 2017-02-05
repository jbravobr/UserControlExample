using Microsoft.Practices.Unity;
using Prism.Unity;
using Acr.UserDialogs;

using ViewAsComponentExample.Views;

namespace ViewAsComponentExample
{
    public class App : PrismApplication
    {
        public static IUnityContainer _container;

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("HomePage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<HomePage>();

            Container.RegisterType(typeof(IConnectivityFunctions), typeof(ConnectivityFunctions));
            Container.RegisterInstance(UserDialogs.Instance);

            _container = Container;
        }
    }
}