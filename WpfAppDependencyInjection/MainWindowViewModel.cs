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
    }
}