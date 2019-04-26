using System;
using System.Globalization;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal static class DateTimeExtensions
    {
        public static DateTime AddInterval(this DateTime date, DateTimeInterval dateTimeInterval)
        {
			return date.AddHours(dateTimeInterval.Hours).AddDays(dateTimeInterval.Days).AddDays(dateTimeInterval.Weeks * 7).AddMonths(dateTimeInterval.Months);
        }

        public static string GetShortMonthName(this DateTime dateTime, CultureInfo culture)
        {
            string s = dateTime.ToString("MMM", culture);
            if (s.Length > 3)
            {
                return s.Substring(0, 3);
            }

            return s;
        }

        public static bool IsToday(this DateTime dateTime)
        {
            DateTime today = DateTime.Today;
            return dateTime.Year == today.Year && dateTime.Month == today.Month && dateTime.Day == today.Day;
        }

        public static DateTime SubtractInterval(this DateTime dt, DateTimeInterval dateTimeInterval)
        {
            return dt.AddHours(-dateTimeInterval.Hours).AddDays(-dateTimeInterval.Days).AddDays(-dateTimeInterval.Weeks * 7).AddMonths(-dateTimeInterval.Months);
        }
    }
}