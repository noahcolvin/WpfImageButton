using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using UIPlayground.Annotations;

namespace UIPlayground
{
    /// <summary>
    /// Interaction logic for WpfImageButton.xaml
    /// </summary>
    public partial class WpfImageButton : INotifyPropertyChanged
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

        public WpfImageButton()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
