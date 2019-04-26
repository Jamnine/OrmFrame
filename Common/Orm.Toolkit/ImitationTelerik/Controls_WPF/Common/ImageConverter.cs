using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Provides a type converter to convert Image objects from String representation.
    /// </summary>
    public class ImageConverter : TypeConverter
    {
        /// <summary>
        /// Overloaded. Returns whether this converter can convert an object of one type to the type of this converter.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
        /// <param name="sourceType">A Type that represents the type you wish to convert from.</param>
        /// <returns>true if this object can perform the conversion; otherwise, false.</returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == null)
            {
                throw new ArgumentNullException("sourceType");
            }

            return (sourceType == typeof(string)) || base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// Converts the given value object to a Image object.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides a format context.</param>
        /// <param name="culture">A CultureInfo that specifies the culture to which to convert.</param>
        /// <param name="value">The Object to convert.</param>
        /// <returns>An Object that represents the converted value.</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                Uri imageUri;
                if (Uri.TryCreate(Convert.ToString(value, culture), UriKind.RelativeOrAbsolute, out imageUri))
                {
                    return new Image() { Source = new BitmapImage(imageUri), Stretch = System.Windows.Media.Stretch.None };
                }

                return value;
            }

            return base.ConvertFrom(context, culture, value);
        }
    }
}