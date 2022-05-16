using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace WpfAppDependencyInjection
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// As default Closed command which is called when the window was closed.
        /// </summary>
        public ICommand ClosedCommand { get; set; }

        /// <summary>Occurs when a property value changes.</summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Sets the value of a field.</summary>
        /// <typeparam name="T">The type of the field.</typeparam>
        /// <param name="field">     The field that is set.</param>
        /// <param name="value">     The value that is set.</param>
        /// <param name="memberName">Name of the calling member.</param>
        /// <returns><c>True</c> if the operation succeeded; otherwise <c>False</c>.</returns>
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string memberName = "")
        {
            if (field == null ? value == null : field.Equals(value))
                return false;

            field = value;
            NotifyPropertyChanged(memberName);
            return true;
        }

        /// <summary>Called when a property of this class or a child class is changed.</summary>
        /// <param name="propertyName">Name of the property that is changed.</param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}