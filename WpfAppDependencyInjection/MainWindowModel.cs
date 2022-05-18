using System;
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
            ViewModel.AddItemCommand = new RelayCommand(AddItem);

            // filling the ViewModel with some test data.
            ViewModel.MyText = "Test text";

            ViewModel.Items.Add(new NameCategory { Name = "This is an item", Category = "Household" });
            ViewModel.Items.Add(new NameCategory { Name = "This is another item", Category = "Work" });
        }

        private void AddItem(object commandParameter)
        {
            ViewModel.Items.Add(new NameCategory { Name = $"The current datetime is {DateTime.Now}", Category = "Dynamic" });
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