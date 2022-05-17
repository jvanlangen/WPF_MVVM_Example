using System.Diagnostics;
using WpfAppDependencyInjection.Version1.Base;

namespace WpfAppDependencyInjection
{
    public class MainWindowModel : WindowModelBase<MainWindow, MainWindowViewModel>
    {
        public MainWindowModel()
        {
            // capture commands
            ViewModel.ButtonClick = new RelayCommand(ButtonClick);
            ViewModel.ClosedCommand = new RelayCommand(Closed);

            ViewModel.MyText = "Test text";

            ViewModel.Items.Add(new NameCategory { Name = "This is an item", Category = "Red" });
            ViewModel.Items.Add(new NameCategory { Name = "This is another item", Category = "Blue" });
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