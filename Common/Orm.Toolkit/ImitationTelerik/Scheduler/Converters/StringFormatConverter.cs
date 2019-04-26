using System;
using System.Globalization;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Converter that uses <c>String.Format</c> to format a value.
    /// </summary>
    public class StringFormatConverter : IMultiValueConverter, IValueConverter
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static readonly StringFormatConverter Instance = new StringFormatConverter();


        /// <summary>
        /// Converts source values to a value for the binding target. The data binding engine calls this method when it propagates the values from source bindings to the binding target.
        /// </summary>
        /// <param name="values">The array of values that the source bindings in the <see cref="MultiBinding"/> produces. The value <see cref="System.Windows.DependencyProperty.UnsetValue"/> indicates that the source binding has no value to provide for conversion.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value.If the method returns null, the valid null value is used.A return value of <see cref="System.Windows.DependencyProperty"/>.<see cref="System.Windows.DependencyProperty.UnsetValue"/> indicates that the converter did not produce a value, and that the binding will use the <see cref="System.Windows.Data.BindingBase.FallbackValue"/> if it is available, or else will use the default value.A return value of <see cref="System.Windows.Data.Binding"/>.<see cref="System.Windows.Data.Binding.DoNothing"/> indicates that the binding does not transfer the value or use the <see cref="System.Windows.Data.BindingBase.FallbackValue"/> or the default value.
        /// </returns>
        /// <exception cref="ArgumentException">If there is more than 1 value. First value should be formatting string.</exception>

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length == 0)
                return string.Empty;

            if (values.Length > 1)
            {
                var formatStirng = values[0] as string;
                if (formatStirng == null)
                    throw new ArgumentException(
                        "If there is more than 1 value. First value should be formatting string.");

                var par = new object[values.Length - 1];
                for (int i = 1; i < values.Length; i++)
                {
                    par[i - 1] = values[i];
                }

                return string.Format(culture, formatStirng, par);
            }

            return values[0].ToString();
        }

        /// <summary>
        /// Converts a binding target value to the source binding values.
        /// </summary>
        /// <param name="value">The value that the binding target produces.</param>
        /// <param name="targetTypes">The array of types to convert to. The array length indicates the number and types of values that are suggested for the method to return.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// An array of values that have been converted from the target value back to the source values.
        /// </returns>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var objArray = new object[targetTypes.Length];
            for (int i = 0; i < objArray.Length; i++)
            {

                objArray[i] = Binding.DoNothing;

            }
            return objArray;
        }

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
            var formatStirng = LocalizationManager.GetString(parameter.ToString());

            if (formatStirng != null)
            {
                return string.Format(culture, formatStirng, value);
            }

            return value.ToString();
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
            var objArray = new object();

                objArray = Binding.DoNothing;

            return objArray;
        }
    }
}