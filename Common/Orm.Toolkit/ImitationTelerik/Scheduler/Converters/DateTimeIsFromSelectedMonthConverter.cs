using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Converter that is used in <see cref="RadScheduler"/> in month view mode to display different template 
    /// on dates that are not in the current month.
    /// </summary>
    public class DateTimeIsFromSelectedMonthConverter : IMultiValueConverter
    {
        /// <summary>
        /// Singleton instance for this converter.
        /// </summary>
        public static readonly DateTimeIsFromSelectedMonthConverter Instance =
            new DateTimeIsFromSelectedMonthConverter();

        /// <summary>
        /// Checks whether the given date is in the same month of the given scheduler.
        /// </summary>
        /// <param name="values">
        /// Values' length should be 2. First element should be the date to check. 
        /// The second element should be <see cref="DateTime"/>, which will be a selected date.
        /// </param>
        /// <param name="targetType">The type of the binding target property. This parameter is not used.</param>
        /// <param name="parameter">The converter parameter to use. This parameter is not used.</param>
        /// <param name="culture">The culture to use in the converter. This parameter is not used.</param>
        /// <returns>
        /// <c>True</c> if the date is in the month of the scheduler. otherwise <c>false</c>. If incorrect arguments
        /// are passed returns <see cref="DependencyProperty.UnsetValue"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException"><c>values</c> is null.</exception>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values");
            }

            if (values.Length != 2)
            {
                return DependencyProperty.UnsetValue;
            }

			if (!(values[0] is TimeSlot) && !(values[0] is DateTime))
            {
                return DependencyProperty.UnsetValue;
            }
			if (!(values[1] is TimeSlot) && !(values[1] is DateTime))
            {
                return DependencyProperty.UnsetValue;
            }

			var dateTime = DateTime.MinValue;
			var selectedDate = DateTime.MinValue;
			if (values[0] is TimeSlot)
			{
				dateTime = ((TimeSlot)values[0]).Start;
			}
			if (values[0] is DateTime)
			{
				dateTime = (DateTime)values[0];
			}
			if (values[1] is TimeSlot)
			{
				selectedDate = ((TimeSlot)values[1]).Start;
			}
			if (values[1] is DateTime)
			{
				selectedDate = (DateTime)values[1];
			}

            if (dateTime.Year == selectedDate.Year &&
                dateTime.Month == selectedDate.Month)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// This method is not implemented.
        /// </summary>
        /// <exception cref="NotImplementedException"><c>NotImplementedException</c>.</exception>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}