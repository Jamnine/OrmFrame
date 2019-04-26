using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Provides a type converter to convert <see cref="DateTimeInterval"/> objects to and from other representations.
    /// </summary>
    public partial class DateTimeIntervalConverter
    {
        /// <summary>
        /// Returns whether this converter can convert the object to the specified type, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context.</param>
        /// <param name="destinationType">A <see cref="T:System.Type"/> that represents the type you want to convert to.</param>
        /// <returns>
        /// True if this converter can perform the conversion; otherwise, false.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="destinationType"/> is null.</exception>
        /// <exception cref="FormatException">	<paramref name="destinationType"/> is not a valid value for the target type. </exception>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType == typeof(InstanceDescriptor)) || base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// Converts the given object to another type.
        /// </summary>
        /// <param name="context">A formatter context.</param>
        /// <param name="culture">The culture into which <paramref name="value"/> will be converted.</param>
        /// <param name="value">The object to convert.</param>
        /// <param name="destinationType">The type to convert the object to.</param>
        /// <returns>The converted object.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="destinationType"/> is null.</exception>
        public override object ConvertTo(
            ITypeDescriptorContext context,
            CultureInfo culture,
            object value,
            Type destinationType)
        {
            if (destinationType == null)
            {
                throw new ArgumentNullException("destinationType");
            }
            if ((destinationType == typeof(InstanceDescriptor)) && (value is DateTimeInterval))
            {
                MethodInfo method = typeof(DateTimeInterval).GetMethod("Parse", new[] { typeof(string) });
                if (method != null)
                {
                    return new InstanceDescriptor(method, new object[] { value.ToString() });
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
