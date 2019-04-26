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
	public class TimeSlotToStringConverter : IMultiValueConverter
	{
		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="values">The values produced by the binding source.</param>
		/// <param name="targetType">The type of the binding target property.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>
		/// A converted value. If the method returns null, the valid null value is used.
		/// </returns>
		/// <exception cref="ArgumentException">The type of value have to be <see cref="TimeSlot"/>.</exception>
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			TimeSlot slot = values[1] as TimeSlot;
			if (slot != null)
			{
				return String.Format(LocalizationManager.DefaultCulture, (string)values[0], slot.Start);
			}
			return String.Empty;
		}

		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="value">The value that is produced by the binding target.</param>
		/// <param name="targetTypes">The types to convert to.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>
		/// A converted value. If the method returns null, the valid null value is used.
		/// </returns>
		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}