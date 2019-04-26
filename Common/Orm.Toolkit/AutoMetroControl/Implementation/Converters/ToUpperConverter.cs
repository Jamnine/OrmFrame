using System;
using System.Globalization;
using System.Windows.Data;

namespace Orm.Toolkit.Metro.Converters
{
    public class ToUpperConverter : MarkupConverter
    {
        protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value as string;
            if (str == null)
            {
                return value;
            }
            return str.ToUpper();
        }

        protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
