using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents converter that converts width and height to a Rect.
    /// </summary>
    public class DimensionsToRectConverter : IMultiValueConverter
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static readonly DimensionsToRectConverter Instance = new DimensionsToRectConverter();


        /// <summary>
        /// Converts source values to a value for the binding target. The data binding engine calls this method when it propagates the values from source bindings to the binding target.
        /// </summary>
        /// <param name="values">The array of values that the source bindings in the <see cref="MultiBinding"/> produces. The value <see cref="DependencyProperty.UnsetValue"/> indicates that the source binding has no value to provide for conversion.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value.If the method returns null, the valid null value is used.A return value of <see cref="DependencyProperty"/>.<see cref="DependencyProperty.UnsetValue"/> indicates that the converter did not produce a value, and that the binding will use the <see cref="BindingBase.FallbackValue"/> if it is available, or else will use the default value.A return value of <see cref="Binding"/>.<see cref="Binding.DoNothing"/> indicates that the binding does not transfer the value or use the <see cref="BindingBase.FallbackValue"/> or the default value.
        /// </returns>

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double width = 0;
            double height = 0;
            if (values != null && values.Length == 2)
            {
                if (values[0] is double)
                {
                    width = (double)values[0];
                }
                if (values[1] is double)
                {
                    height = (double)values[1];
                }
            }

            return new Rect(0, 0, width, height);
        }

        /// <summary>
        /// Converts a binding target value to the source binding values.
        /// </summary>
        /// <returns>
        /// An array of values that have been converted from the target value back to the source values.
        /// </returns>
        /// <param name="value">The value that the binding target produces.</param>
        /// <param name="targetTypes">The array of types to convert to. The array length indicates the number and types of values that are suggested for the method to return.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new[] 
            { 

            Binding.DoNothing, Binding.DoNothing

            };
        }
    }
}