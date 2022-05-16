using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WpfAppDependencyInjection
{
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

        private string _myText;
        /// <summary>
        /// MyText string.
        /// </summary>
        public string MyText
        {
            get => _myText;
            set => SetField(ref _myText, value);
        }


        public class NameCategory
        {
            public string Name { get; set; }
            public string Category { get; set; }
        }

        public ObservableCollection<NameCategory> Items { get; } = new();
    }
}