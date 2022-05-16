using System.Diagnostics;
using WpfAppDependencyInjection.Version1.Base;

namespace WpfAppDependencyInjection
{
    public class MainWindowModel : WindowModelBase<MainWindow, MainWindowViewModel>
    {
        public MainWindowModel()
        {
            ViewModel.MyText = "Test text";
            ViewModel.ButtonClick = new RelayCommand(ButtonClick);
            ViewModel.ClosedCommand = new RelayCommand(Closed);
        }

        private void ButtonClick(object commandParameter)
        {
            Trace.WriteLine("Button is clicked");
            ViewModel.MyText = "The button was clicked";
        }

        private void Closed(object commandParameter)
        {
            Trace.WriteLine("Closed");
        }
    }
}