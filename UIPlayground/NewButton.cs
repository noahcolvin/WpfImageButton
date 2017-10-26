using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using UIPlayground.Annotations;

namespace UIPlayground
{
    public class NewButton : Button, INotifyPropertyChanged
    {
        public static readonly DependencyProperty IconBackgroundColorProperty = DependencyProperty.Register("IconBackgroundColor", typeof(Brush), typeof(WpfImageButton));

        public Brush IconBackgroundColor
        {
            get => (Brush)GetValue(IconBackgroundColorProperty);
            set
            {
                SetValue(IconBackgroundColorProperty, value);
                OnPropertyChanged(nameof(IconBackgroundColor));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}