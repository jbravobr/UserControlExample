using Prism.Mvvm;

namespace ViewAsComponentExample.ViewModels
{
    public class IndexPageViewModel : BindableBase
    {
        public string LabelText { get; set; }

        public IndexPageViewModel()
        {
            LabelText = "123";
        }
    }
}