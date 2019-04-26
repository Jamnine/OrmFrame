using System;
using System.Globalization;
using System.Linq;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal abstract class DateParserBase : IDateTimeParser
	{
		public DateParserBase()
		{
			this.DateTimeFormat = new DateTimeFormatInfo();
		}

		public string Separator
		{
			get
			{

				return this.DateTimeFormat.DateSeparator;

			}
		}

		public DateTimeFormatInfo DateTimeFormat { get; set; }

		public DateTimePickerFormat Format { get; set; }

		public static DateTime MergeDateAndTime(DateTime date, DateTime time)
		{
			return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second, time.Millisecond);
		}

		public abstract bool TryParse(string value, out DateTime result, DateTime current);
	}
}
