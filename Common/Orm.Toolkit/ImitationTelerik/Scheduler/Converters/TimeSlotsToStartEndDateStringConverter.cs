using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Converter that takes first start and end time of given <see cref="TimeSlot"/> collection and returns a <see cref="string"/> 
    /// representation of first and second date.
    /// </summary>
    [ValueConversion(typeof(IEnumerable), typeof(string))]
    public class TimeSlotsToStartEndDateStringConverter : IValueConverter
    {
        /// <summary>
        /// A singleton instance for this converter.
        /// </summary>
        public static readonly TimeSlotsToStartEndDateStringConverter Instance =
            new TimeSlotsToStartEndDateStringConverter();

        /// <summary>
        /// Converts a collection of <see cref="TimeSlot"/> to start end date string.
        /// </summary>
        /// <param name="value">The collection of time slots.</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">This parameter is not used.</param>
        /// <param name="culture">This parameter is not used.</param>
        /// <returns>
        /// A <see cref="string"/> created from the first time slot's <see cref="TimeSlot.Start"/> and 
        /// the last time slot's <see cref="TimeSlot.End"/> using "MMMd" as format string. The char '-' is
        /// used as a splitter between two dates.
        /// <remarks>
        /// If <paramref name="value"/> is not <see cref="IEnumerable{T}"/> of <see cref="TimeSlot"/> an empty string is returned.
        /// </remarks>
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var enumerable = value as IEnumerable;
            if (enumerable != null)
            {
                IEnumerable<TimeSlot> timeSlots;
                try
                {
                    timeSlots = enumerable.Cast<TimeSlot>().ToList();
                }
                catch (InvalidCastException)
                {
                    return string.Empty;
                }

                var group = new TimeSlotGroup(timeSlots);
                DateTime start = group.Start;
                DateTime end = group.End.AddMilliseconds(-1);
                string startString = start.ToString("d ", culture);

                if (start.Month != end.Month)
                {
                    startString += start.GetShortMonthName(culture) + " ";
                }

                string endString = end.ToString("d ", culture) + end.GetShortMonthName(culture);
                return string.Concat(startString, "- ", endString);
            }

            return string.Empty;
        }

        /// <summary>
        /// Throws <see cref="InvalidOperationException"/>, because this back conversion is invalid.
        /// </summary>
        /// <param name="value">This parameter is not used.</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">This parameter is not used.</param>
        /// <param name="culture">This parameter is not used.</param>
        /// <exception cref="InvalidOperationException"><c>InvalidOperationException</c>.</exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }
    }
}