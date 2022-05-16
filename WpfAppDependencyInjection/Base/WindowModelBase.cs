using System;
using System.Windows;
using System.Windows.Input;

namespace WpfAppDependencyInjection
{
    public class WindowModelBase<TView, TViewModel>
        where TView : Window, new()
        where TViewModel : ViewModelBase, new()
    {
        private readonly TView _window;

        public WindowModelBase()
        {
            // Create the ViewModel.
            ViewModel = new TViewModel();

            // Create the Window and set the ViewModel.
            _window = new TView();
            // Set the DataContext to the ViewModel.
            _window.DataContext = ViewModel;

            // Attaching the Closed event to the ClosedCommand.
            _window.Closed += (s, e) => ViewModel.ClosedCommand?.Execute(null);
        }

        protected TViewModel ViewModel { get; }

        /// <summary>
        /// Show the window
        /// </summary>
        public void Show() => _window.Show();

        /// <summary>
        /// Show the window as dialog.
        /// </summary>
        public bool? ShowDialog() => _window.ShowDialog();

        /// <summary>
        /// Close the window.
        /// </summary>
        public void Close() => _window.Close();

    }
}
