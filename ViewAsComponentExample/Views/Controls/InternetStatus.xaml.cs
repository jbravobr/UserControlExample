using Xamarin.Forms;

namespace ViewAsComponentExample.Views.Controls
{
    public partial class InternetStatus : ContentView
    {
        public InternetStatus()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty IsConnectedProperty = BindableProperty
            .Create("IsConnected", typeof(bool), typeof(InternetStatus), false);

        public bool IsConnected
        {
            get { return (bool)GetValue(IsConnectedProperty); }
            set { SetValue(IsConnectedProperty, value); }
        }
    }
}