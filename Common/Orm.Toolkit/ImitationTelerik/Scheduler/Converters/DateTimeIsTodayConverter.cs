using System;
using System.Globalization;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents converter that converts <see cref="DateTime"/> to a bool that 
    /// shows is today or not.
    /// </summary>
    [ValueConversion(typeof(TimeSlot), typeof(bool))]
    public class DateTimeIsTodayConverter : IValueConverter
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static readonly DateTimeIsTodayConverter Instance = new DateTimeIsTodayConverter();

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
        /// <exception cref="ArgumentException">The type of value have to be <see cref="DateTime"/>.</exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
			if (value == null)
			{
				return true;
			}
			if (!(value is TimeSlot) && !(value is DateTime))
            {
				throw new ArgumentException("The type of value have to be TimeSlot or DateTime.", "value");
            }

			if (value is TimeSlot)
			{
				return ((TimeSlot)value).Start.IsToday();
			}
			else
			{
				return ((DateTime)value).IsToday();
			}
        }

        /// <summary>
        /// Converts a value.
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

            return Binding.DoNothing;

        }
    }
}