using System;
using System.Globalization;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
	/// Represents converter that converts <see cref="TimeSlot"/> to a <see cref="String" />.
    /// </summary>
    [ValueConversion(typeof(TimeSlot), typeof(string))]
    public class TimeSlotToWeekConverter : IValueConverter
    {
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
		/// <exception cref="ArgumentException">The type of value have to be <see cref="TimeSlot"/>.</exception>
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			TimeSlot slot = value as TimeSlot;
			 culture = CultureInfo.CurrentCulture;
			if (LocalizationManager.DefaultCulture != null)
			{
				culture = LocalizationManager.DefaultCulture;
			}
			DateTime start = slot.Start;
			DateTime end = slot.End.AddMilliseconds(-1);
			string startString = start.ToString("d ", culture);

			if (start.Month != end.Month)
			{
				startString += start.GetShortMonthName(culture) + " ";
			}

			string endString = end.ToString("d ", culture) + end.GetShortMonthName(culture);
			return string.Concat(startString, "- ", endString);
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
			return String.Empty;
		}
	}
}