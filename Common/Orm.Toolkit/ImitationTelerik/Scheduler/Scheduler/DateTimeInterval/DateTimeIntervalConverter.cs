using System;
using System.ComponentModel;
using System.Globalization;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Provides a type converter to convert <see cref="DateTimeInterval"/> objects to and from other representations.
    /// </summary>

    public partial class DateTimeIntervalConverter : TypeConverter
    {
        /// <summary>
        /// Gets a value indicating whether this converter can convert an object in the given 
        /// source type to a <see cref="DateTimeInterval"/> using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="sourceType">A <see cref="Type"/> that represents the type you want to convert from.</param>
        /// <returns>
        /// True if this converter can perform the conversion; otherwise, false.
        /// </returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType == typeof(string)) || base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// Converts the given object to a <see cref="DateTimeInterval"/>.
        /// </summary>
        /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="culture">An optional <see cref="CultureInfo"/>. If not supplied, the current culture is assumed.</param>
        /// <param name="value">The <see cref="object"/> to convert.</param>
        /// <returns>
        /// An <see cref="object"/> that represents the converted value.
        /// </returns>
        /// <exception cref="NotSupportedException">The conversion cannot be performed. </exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> contains negative value.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="value"/> is not in the correct format. The string should be in format like 
        /// this: "<c>{i}d {i}m</c>" where {i} represents an <see cref="int"/> number.
        /// </exception>
        /// <exception cref="OverflowException">
        /// Given values for <see cref="DateTimeInterval.Days"/> or <see cref="DateTimeInterval.Months"/> in <paramref name="value"/> are less 
        /// than 0 and <see cref="int.MaxValue"/>.
        /// </exception>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var str = value as string;
            if (str != null)
            {
                str = str.Trim();
                return DateTimeInterval.Parse(str);
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}