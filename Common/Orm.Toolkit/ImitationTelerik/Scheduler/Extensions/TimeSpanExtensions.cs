using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Holds <see cref="TimeSpan"/> extension methods.
	/// </summary>
	public static class TimeSpanExtensions
	{
		/// <summary>
		/// Determines whether the specified <see cref="TimeSpan"/> is negative. It checks whether 
		/// the ticks count is less than zero.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <returns>
		/// 	<c>true</c> if the specified <see cref="TimeSpan"/> is negative; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNegative(this TimeSpan source)
		{
			return source.Ticks < 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="TimeSpan"/> is <see cref="TimeSpan.Zero"/>. It checks whether 
		/// the ticks count is zero.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <returns>
		/// 	<c>true</c> if the specified <see cref="TimeSpan"/> is zero; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsZero(this TimeSpan source)
		{
			return source.Ticks == 0;
		}

		/// <summary>
		/// Adds the milliseconds.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="milliseconds">The milliseconds.</param>
		/// <returns></returns>
		internal static TimeSpan AddMilliseconds(this TimeSpan timeSpan, double milliseconds)
		{
			return timeSpan.Add(TimeSpan.FromMilliseconds(milliseconds));
		}

		/// <summary>
		/// Adds the seconds.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="seconds">The seconds.</param>
		/// <returns></returns>
		internal static TimeSpan AddSeconds(this TimeSpan timeSpan, double seconds)
		{
			return timeSpan.Add(TimeSpan.FromSeconds(seconds));
		}

		/// <summary>
		/// Adds the minutes.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="minutes">The minutes.</param>
		/// <returns></returns>
		internal static TimeSpan AddMinutes(this TimeSpan timeSpan, double minutes)
		{
			return timeSpan.Add(TimeSpan.FromMinutes(minutes));
		}

		/// <summary>
		/// Adds the hours.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="hours">The hours.</param>
		/// <returns></returns>
		internal static TimeSpan AddHours(this TimeSpan timeSpan, double hours)
		{
			return timeSpan.Add(TimeSpan.FromHours(hours));
		}

		/// <summary>
		/// Adds the days.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="days">The days.</param>
		/// <returns></returns>
		internal static TimeSpan AddDays(this TimeSpan timeSpan, double days)
		{
			return timeSpan.Add(TimeSpan.FromDays(days));
		}

		/// <summary>
		/// Removes the milliseconds.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="milliseconds">The milliseconds.</param>
		/// <returns></returns>
		internal static TimeSpan RemoveMilliseconds(this TimeSpan timeSpan, double milliseconds)
		{
			return timeSpan.Add(TimeSpan.FromMilliseconds(-milliseconds));
		}

		/// <summary>
		/// Removes the seconds.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="seconds">The seconds.</param>
		/// <returns></returns>
		internal static TimeSpan RemoveSeconds(this TimeSpan timeSpan, double seconds)
		{
			return timeSpan.Add(TimeSpan.FromSeconds(-seconds));
		}

		/// <summary>
		/// Removes the minutes.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="minutes">The minutes.</param>
		/// <returns></returns>
		internal static TimeSpan RemoveMinutes(this TimeSpan timeSpan, double minutes)
		{
			return timeSpan.Add(TimeSpan.FromMinutes(-minutes));
		}

		/// <summary>
		/// Removes the hours.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="hours">The hours.</param>
		/// <returns></returns>
		internal static TimeSpan RemoveHours(this TimeSpan timeSpan, double hours)
		{
			return timeSpan.Add(TimeSpan.FromHours(-hours));
		}

		/// <summary>
		/// Removes the days.
		/// </summary>
		/// <param name="timeSpan">The time span.</param>
		/// <param name="days">The days.</param>
		/// <returns></returns>
		internal static TimeSpan RemoveDays(this TimeSpan timeSpan, double days)
		{
			return timeSpan.Add(TimeSpan.FromDays(-days));
		}
	}
}