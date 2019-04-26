using System;
using System.Globalization;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents converter, which converts <see cref="Enum"/> types to and from a
    /// boolean value using the given parameter.
    /// </summary>
    /// <remarks>
    /// The <see cref="Enum"/> can be with <see cref="FlagsAttribute"/>. Characters: ',' or ';' 
    /// can be used to split multiple values passed in the given parameter.
    /// </remarks>
    [ValueConversion(typeof(Enum), typeof(bool))]
    public class EnumToBooleanConverter : IValueConverter
    {
        /// <summary>
        /// Converts a <see cref="Enum"/> value to a Boolean one if it is one from the 
        /// specified in the <paramref name="parameter"/> values.
        /// </summary>
        /// <param name="value">The <see cref="Enum"/> value .</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">
        /// One or more values, which will be check for equality 
        /// against the passed <paramref name="value"/>.Characters: ',' or ';' can be used to split 
        /// multiple values.
        /// </param>
        /// <param name="culture">This parameter is not used.</param>
        /// <returns>
        /// A boolean value indicating whether the given <paramref name="value"/> is one from the specified in 
        /// the <paramref name="parameter"/>. Returns null if the <paramref name="value"/> or 
        /// <paramref name="parameter"/> are <c>null</c>.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is Enum))
            {
                return false;
            }
            if (parameter == null)
            {
                return false;
            }

            foreach (Enum paramValue in ParseObjectToEnum(value.GetType(), parameter))
            {
                if (value.Equals(paramValue))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Converts the Boolean value back to the first <see cref="Enum"/> value passed in the 
        /// <paramref name="parameter"/>.
        /// </summary>
        /// <param name="value">The Boolean value.</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">
        /// One or more <see cref="Enum"/> values. The first one will be return if the <paramref name="value"/> 
        /// is <c>true</c>.
        /// </param>
        /// <param name="culture">This parameter is not used.</param>
        /// <returns>
        /// First <see cref="Enum"/> value from the <paramref name="parameter"/> if the <paramref name="value"/> is <c>true</c>,
        /// otherwise <see cref="Binding.DoNothing"/>.
         /// </returns>

       
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                Enum[] parsedValues = ParseObjectToEnum(targetType, parameter);
                if (parsedValues.Length > 0)
                {
                    return parsedValues[0];
                }
            }

            return Binding.DoNothing;

        }

        /// <summary>
        /// Parses the object to enum.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">parameter</exception>
        private static Enum[] ParseObjectToEnum(Type enumType, object value)
        {
            var enumValue = value as Enum;
            if (enumValue != null)
            {
                return new[] { enumValue };
            }

            var str = value as string;
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("parameter");
            }

            string[] strArray = str.Split(new[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var enumArray = new Enum[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                enumArray[i] = (Enum)Enum.Parse(enumType, strArray[i], true);
            }

            return enumArray;
        }
    }
}