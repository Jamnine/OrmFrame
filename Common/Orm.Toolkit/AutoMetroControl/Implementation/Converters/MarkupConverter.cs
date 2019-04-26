using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Orm.Toolkit.Metro.Converters
{
    [MarkupExtensionReturnType(typeof(IValueConverter))]
    public abstract class MarkupConverter : MarkupExtension, IValueConverter
    {
        protected MarkupConverter()
        {
        }

        protected abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        protected abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return this.Convert(value, targetType, parameter, culture);
            }
            catch
            {
                return DependencyProperty.UnsetValue;
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return this.ConvertBack(value, targetType, parameter, culture);
            }
            catch
            {
                return DependencyProperty.UnsetValue;
            }
        }
    }
}
