using Prism.Mvvm;
using Microsoft.Practices.Unity;
using Plugin.Connectivity.Abstractions;

namespace ViewAsComponentExample
{
    public class BaseViewModel : BindableBase
    {
        public bool InternetConnStatus { get; set; } = false;

        public BaseViewModel()
        {
            Plugin.Connectivity.CrossConnectivity.Current.ConnectivityChanged += (object sender, ConnectivityChangedEventArgs e) =>
             {
                 if (App._container != null)
                 {
                     var userDialogs = App._container.Resolve<Acr.UserDialogs.IUserDialogs>();
                     if (userDialogs != null)
                         userDialogs.Alert($"Novo status de internet: {e.IsConnected}");
                 }


                 InternetConnStatus = e.IsConnected;
             };
        }
    }
}