using System;
using System.Globalization;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Convert <see cref="DateTimeOffset"/> object to <see cref="DateTime"/>.
    /// </summary>
    [ValueConversion(typeof(DateTimeOffset), typeof(DateTime))]
    public class DateTimeOffsetToDateTimeConverter : IValueConverter
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static readonly DateTimeOffsetToDateTimeConverter Instance = new DateTimeOffsetToDateTimeConverter();

        /// <summary>
        /// Converts a value.
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
            if (value != null)
            {
                return ((DateTimeOffset)value).DateTime;
            }

            return new DateTime();
        }

        /// <summary>
        /// Do nothing when try to convert value back.
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
            if (value != null)
            {
                return new DateTimeOffset((DateTime)value);
            }
            return new DateTimeOffset();
        }
    }
}