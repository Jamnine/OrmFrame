using System;
using System.Globalization;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal interface IDateTimeParser
	{
		DateTimeFormatInfo DateTimeFormat { get; set; }
		DateTimePickerFormat Format { get; set; }

		bool TryParse(string value, out DateTime result, DateTime current);
	}
}
