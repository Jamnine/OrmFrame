using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents converter that converts null or empty string <see cref="object"/> 
    /// to Visibility values .
    /// </summary>
    public class NullToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts <see cref="object"/> to Visibility.
        /// </summary>
        /// <param name="value">The <see cref="object"/> that will be used for conversion.</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">This parameter is not used.</param>
        /// <param name="culture">This parameter is not used.</param>
        /// <returns>
        /// Visibility presentation of the object.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Visibility.Collapsed;
            }

            if (value is string)
            {
                if (string.IsNullOrEmpty((string)value))
                {
                    return Visibility.Collapsed;
                }
            }
            return Visibility.Visible;
        }

        /// <summary>
        /// This method is not implemented.
        /// </summary>
        /// <remarks>Throws <see cref="NotImplementedException"/>.</remarks>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}