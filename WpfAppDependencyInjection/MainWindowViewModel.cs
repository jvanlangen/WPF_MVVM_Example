using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WpfAppDependencyInjection
{
    public class NameCategory
    {
        public string Name { get; set; }
        public string Category { get; set; }
    }


    public class MainWindowViewModel : ViewModelBase
    {
        private ICommand _buttonClick;
        /// <summary>
        /// The Button click command.
        /// </summary>
        public ICommand ButtonClick
        {
            get => _buttonClick;
            set => SetField(ref _buttonClick, value);
        }

        private ICommand _addItemCommand;
        public ICommand AddItemCommand
        {
            get => _addItemCommand;
            set => SetField(ref _addItemCommand, value);
        }

        private string _myText;
        /// <summary>
        /// MyText string.
        /// </summary>
        public string MyText
        {
            get => _myText;
            set => SetField(ref _myText, value);
        }

        public ObservableCollection<NameCategory> Items { get; } = new();
    }
}