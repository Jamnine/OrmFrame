using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal static class TimeExtensions
	{
		public static TimeSpan? GetTimeOfDay(this DateTime? nullable)
		{
			if (nullable == null)
			{
				return null;
			}
			return nullable.Value.TimeOfDay;
		}

		public static DateTime GetDateTime(this TimeSpan span)
		{
			var now = DateTime.Now;
			return new DateTime(now.Year, now.Month, now.Day, span.Hours, span.Minutes, span.Seconds, span.Milliseconds);
		}
	}
}
