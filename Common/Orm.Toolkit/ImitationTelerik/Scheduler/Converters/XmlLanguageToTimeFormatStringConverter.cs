using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Converts from <see cref="XmlLanguage"/> object's culture to time format <see cref="string"/>. 
    /// </summary>
    internal class XmlLanguageToTimeFormatStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var xmlLanguage = value as XmlLanguage;

            if (xmlLanguage == null)
            {
                return Binding.DoNothing;
            }



            var stringToReturn = String.Format(xmlLanguage.GetEquivalentCulture(), "{{0:{0}}}", xmlLanguage.GetEquivalentCulture().DateTimeFormat.ShortTimePattern.Replace(":mm", string.Empty));

            stringToReturn = stringToReturn.Replace(":H}", ":H }");

            return stringToReturn;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return Binding.DoNothing;

        }
    }
}
