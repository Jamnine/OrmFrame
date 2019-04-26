using System;
using System.Windows;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Converts <see cref="AvailableViewModes" /> flags enum to Visibility according to different parameters representing view modes.
    /// </summary>
    public class AvailableViewModesToVisibilityConverter : IValueConverter
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
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var availableViewModes = (AvailableViewModes)value;
            string viewModeParameter = parameter.ToString();
            switch (viewModeParameter)
            {
                case "Month":
                    {
                        if (availableViewModes.HasFlag(AvailableViewModes.Month)) return Visibility.Visible;
                        else return Visibility.Collapsed;
                    }
                case "Week":
                    {
                        if (availableViewModes.HasFlag(AvailableViewModes.Week)) return Visibility.Visible;
                        else return Visibility.Collapsed;
                    }
                case "Day":
                    {
                        if (availableViewModes.HasFlag(AvailableViewModes.Day)) return Visibility.Visible;
                        else return Visibility.Collapsed;
                    }
                case "Timeline":
                    {
                        if (availableViewModes.HasFlag(AvailableViewModes.Timeline)) return Visibility.Visible;
                        else return Visibility.Collapsed;
                    }
                case "Null":
                    {
                        if (availableViewModes.HasFlag(AvailableViewModes.Null)) return Visibility.Collapsed;
                        else return Visibility.Collapsed;
                    }
                default: return Visibility.Visible;
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
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
