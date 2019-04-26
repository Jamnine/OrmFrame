using System;
using System.Windows.Data;
using System.Windows.Media;
using Orm.Toolkit.Telerik.Windows.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Orm.Toolkit.Telerik.Windows.Controls.QuickStart
{
    /// <summary>
    /// Telerik QuickStart Framework element background changer.
    /// </summary>
    public static class ThemeAwareBackgroundBehavior
    {
        /// <summary>
        /// Identifies the IsEnabled attached property.
        /// </summary>
        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(ThemeAwareBackgroundBehavior), new PropertyMetadata(OnIsEnabledPropertyChanged));

        /// <summary>
        /// Returns a bool that specifies whether the behavior is enabled or not.
        /// </summary>
        public static bool GetIsEnabled(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsEnabledProperty);
        }

        /// <summary>
        /// Writes the TextPath attached property to the specified element.
        /// </summary>
        public static void SetIsEnabled(DependencyObject obj, bool value)
        {
            obj.SetValue(IsEnabledProperty, value);
        }

        private static void OnIsEnabledPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            DependencyProperty backgroundProperty = null;

            var control = d as Control;
            var border = d as Border;
            FrameworkElement element = null;
            if (control != null)
            {
                backgroundProperty = Control.BackgroundProperty;
                element = control;
            }
            else if (border != null)
            {
                backgroundProperty = Border.BackgroundProperty;
                element = border;
            }

            if (backgroundProperty != null)
            {
                RoutedEventHandler elementLoaded = null;
                elementLoaded = (object sender, RoutedEventArgs e) =>
                     {
                         element.Loaded -= elementLoaded;

                         FrameworkElement parentUserControl = element.ParentOfType<UserControl>();

                         if (parentUserControl != null && parentUserControl.DataContext != null)
                         {
                             var dataContext = parentUserControl.DataContext;
                             var dataContextType = dataContext.GetType();
                             if (dataContextType.GetProperty("SelectedTheme") == null)
                             {
                                 parentUserControl = parentUserControl.Parent as FrameworkElement;
                             }
                             element.SetBinding(backgroundProperty, new Binding("DataContext.SelectedTheme") { Source = parentUserControl, Converter = new TransparentThemeBackgroundConverter(), ConverterParameter = (Brush)d.GetValue(backgroundProperty), Mode = BindingMode.TwoWay });
                         }
                     };
                element.Loaded += elementLoaded;
            }
        }

        internal class TransparentThemeBackgroundConverter : IValueConverter
        {
            Random random = new Random();

            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                var theme = value as Theme;
                if (theme.GetType() == typeof(TransparentTheme))
                {
                    return new ImageBrush() { ImageSource = new BitmapImage(GetImageUri()), Stretch = Stretch.UniformToFill };
                }
                if (parameter == null)
                {
                    return DependencyProperty.UnsetValue;
                }
                return parameter;
            }

            private Uri GetImageUri()
            {

                return new Uri(string.Format("pack://application:,,,/Telerik.Windows.QuickStartTheme;component/images/bg0{0}.jpg", random.Next(1, 7)), UriKind.RelativeOrAbsolute);

            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                return value;
            }
        }
    }
}