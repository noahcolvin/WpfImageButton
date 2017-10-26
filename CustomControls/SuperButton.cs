using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CustomControls.Annotations;
using FontAwesome.WPF;

namespace CustomControls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomControls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomControls;assembly=CustomControls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:SuperButton/>
    ///
    /// </summary>
    public class SuperButton : Button, INotifyPropertyChanged
    {
        public static readonly DependencyProperty ButtonBackgroundProperty = DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(SuperButton));
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(FontAwesomeIcon), typeof(SuperButton));

        public Brush ButtonBackground
        {
            get => (Brush)GetValue(ButtonBackgroundProperty);
            set
            {
                SetValue(ButtonBackgroundProperty, value);
                OnPropertyChanged(nameof(ButtonBackground));
            }
        }

        public FontAwesomeIcon Icon
        {
            get => (FontAwesomeIcon)GetValue(IconProperty);
            set
            {
                SetValue(IconProperty, value);
                OnPropertyChanged(nameof(Icon));
            }
        }

        public Color IconBackgroundColor
        {
            set
            {
                var brush = new LinearGradientBrush
                {
                    StartPoint = new Point(0, 0),
                    EndPoint = new Point(1, 0)
                };
                brush.GradientStops.Add(new GradientStop(value, 0));
                brush.GradientStops.Add(new GradientStop(value, .3));
                brush.GradientStops.Add(new GradientStop(Colors.WhiteSmoke, .3));
                brush.GradientStops.Add(new GradientStop(Colors.WhiteSmoke, 1));

                ButtonBackground = brush;
            }
        }

        public Color MyColor => Colors.Orange;

        static SuperButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SuperButton), new FrameworkPropertyMetadata(typeof(SuperButton)));

            //MouseEnter += OnMouseEnter;
        }

        private void OnMouseEnter(object sender, MouseEventArgs mouseEventArgs)
        {
            Icon = FontAwesomeIcon.AddressBook;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
