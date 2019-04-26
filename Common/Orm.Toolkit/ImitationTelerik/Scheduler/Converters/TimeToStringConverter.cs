using System;
using System.Globalization;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents converter that converts <see cref="TimeSpan"/> to a <see cref="String" />.
    /// </summary>
    [ValueConversion(typeof(TimeSpan), typeof(string))]
    public class TimeToStringConverter : IValueConverter
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static readonly TimeToStringConverter Instance = new TimeToStringConverter();

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> value to a <see cref="String" /> one using the parameter to format it.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TimeSpan))
            {
                return string.Empty;
            }
            var span = (TimeSpan)value;
            var str = parameter as string;
            if (string.IsNullOrEmpty(str))
            {
                str = "T";
            }
            DateTime time = DateTime.Today + span;
            return time.ToString(str, culture);
        }

        /// <summary>
        /// Converts the <see cref="String" /> value back to the <see cref="TimeSpan"/> value using the parameter to parsed it.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime time;
            string val = value as string;
            if (val == null)
            {

                return Binding.DoNothing;

            }

            if (!DateTime.TryParse(val, culture, DateTimeStyles.AllowWhiteSpaces, out time))
            {
                var str = parameter as string;
                if (string.IsNullOrEmpty(str))
                {
                    str = "T";
                }
                if (!DateTime.TryParseExact(val, str, culture, DateTimeStyles.AllowWhiteSpaces, out time))
                {
                    return Binding.DoNothing;

                }
            }
            return time.TimeOfDay;
        }
    }
}