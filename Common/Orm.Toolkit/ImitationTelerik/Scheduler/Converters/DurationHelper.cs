using System;
using System.Globalization;
using System.Windows.Data;
using Orm.Toolkit.ImitationTelerik;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Converts a <see cref="TimeSpan"/> to a duration <see cref="string"/> and back.
    /// For example 0:30:00 to "30 minutes".
    /// </summary>
    internal static class DurationHelper
    {
        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to a duration <see cref="string"/>. For
        /// example 0:30:00 to "30 minutes".
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public static string TimeSpanToString(IFormatProvider provider, TimeSpan timeSpan)
        {
            //// discard miliseconds and seconds
            timeSpan = DiscardSecondsAndMilliseconds(timeSpan);

            bool halfDay = false;
            bool halfHour = false;

            if (timeSpan.Minutes == 30)
            {
                halfHour = true;
            }

            if (timeSpan.Hours == 12)
            {
                halfDay = true;
            }

            if ((timeSpan.Minutes != 0 && !halfHour) || timeSpan.IsZero())
            {
                return Minutes(timeSpan.TotalMinutes, provider);
            }

            if ((timeSpan.Hours != 0 && !halfDay) || halfHour)
            {
                return Hours(timeSpan.TotalHours, provider);
            }

            if (timeSpan.TotalDays % 3.5 == 0)
            {
                return Weeks(timeSpan.TotalDays / 7, provider);
            }

            return Days(timeSpan.TotalDays, provider);
        }

        /// <summary>
        /// Tries the convert from a <see cref="string"/> to a duration
        /// <see cref="TimeSpan"/>. For example "30 minutes" to 0:30:00.
        /// </summary>
        /// <param name="duration">The duration.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        /// True, if conversion is successful, otherwise - false.
        /// </returns>
        public static bool StringToTimeSpan(string duration, IFormatProvider provider, out TimeSpan result)
        {
            result = TimeSpan.Zero;
            string trimmed = duration.TrimStart(new[] { ' ' });

            int lastNumberIndex = -1;
            for (int i = trimmed.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(trimmed, i))
                {
                    lastNumberIndex = i;
                    break;
                }
            }

            if (lastNumberIndex == -1)
            {
                return false;
            }

            double durationNumber;
            bool parsed;

            if (lastNumberIndex == trimmed.Length - 1)
            {
                parsed = double.TryParse(trimmed, NumberStyles.Float, provider, out durationNumber);
            }
            else
            {
                parsed = double.TryParse(trimmed.Substring(0, lastNumberIndex + 1), NumberStyles.Float, provider, out durationNumber);
            }

            if (!parsed)
            {
                return false;
            }

            string durationWord = trimmed.Substring(lastNumberIndex + 1);

            if (durationWord.Length == 0)
            {
                result = TimeSpan.FromHours(durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            string trimmedDurationWord = durationWord.Trim();
            if (trimmedDurationWord.Length == 1)
            {
                char durationChar = trimmedDurationWord[0];

                if (durationChar == Strings.DurationHour[0])
                {
                    result = TimeSpan.FromHours(durationNumber);
                    result = DiscardSecondsAndMilliseconds(result);
                    return true;
                }

                if (durationChar == Strings.DurationHours[0])
                {
                    result = TimeSpan.FromHours(durationNumber);
                    result = DiscardSecondsAndMilliseconds(result);
                    return true;
                }

                if (durationChar == Strings.DurationMinute[0])
                {
                    result = TimeSpan.FromMinutes(durationNumber);
                    result = DiscardSecondsAndMilliseconds(result);
                    return true;
                }

                if (durationChar == Strings.DurationMinutes[0])
                {
                    result = TimeSpan.FromMinutes(durationNumber);
                    result = DiscardSecondsAndMilliseconds(result);
                    return true;
                }

                if (durationChar == Strings.DurationDays[0])
                {
                    result = TimeSpan.FromDays(durationNumber);
                    result = DiscardSecondsAndMilliseconds(result);
                    return true;
                }

                if (durationChar == Strings.DurationWeeks[0])
                {
                    result = TimeSpan.FromDays(7 * durationNumber);
                    result = DiscardSecondsAndMilliseconds(result);
                    return true;
                }

                return false;
            }

            if (durationWord.IndexOf(Strings.DurationHour, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromHours(durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            if (durationWord.IndexOf(Strings.DurationHours, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromHours(durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            if (durationWord.IndexOf(Strings.DurationMinute, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromMinutes(durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            if (durationWord.IndexOf(Strings.DurationMinutes, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromMinutes(durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            if (durationWord.IndexOf(Strings.DurationDay, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromDays(durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            if (durationWord.IndexOf(Strings.DurationDays, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromDays(durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            if (durationWord.IndexOf(Strings.DurationWeek, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromDays(7 * durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            if (durationWord.IndexOf(Strings.DurationWeeks, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                result = TimeSpan.FromDays(7 * durationNumber);
                result = DiscardSecondsAndMilliseconds(result);
                return true;
            }

            return false;
        }

        private static string Days(double days, IFormatProvider provider)
        {
            if (days == 1)
            {
				return string.Format(provider, "{0} {1}", days, LocalizationManager.GetString("DurationDay"));
            }

			return string.Format(provider, "{0} {1}", days, LocalizationManager.GetString("DurationDays"));
        }

        private static TimeSpan DiscardSecondsAndMilliseconds(TimeSpan timeSpan)
        {
            if (timeSpan.Milliseconds != 0)
            {
                timeSpan = timeSpan.RemoveMilliseconds(timeSpan.Milliseconds);
            }

            if (timeSpan.Seconds != 0)
            {
                timeSpan = timeSpan.RemoveSeconds(timeSpan.Seconds);
            }

            return timeSpan;
        }

        private static string Hours(double hours, IFormatProvider provider)
        {
            if (hours == 1)
            {
				return string.Format(provider, "{0} {1}", hours, LocalizationManager.GetString("DurationHour"));
            }

			return string.Format(provider, "{0} {1}", hours, LocalizationManager.GetString("DurationHours"));
        }

        private static string Minutes(double minutes, IFormatProvider provider)
        {
            if (minutes == 1)
            {
				return string.Format(provider, "{0} {1}", minutes, LocalizationManager.GetString("DurationMinute"));
            }

			return string.Format(provider, "{0} {1}", minutes, LocalizationManager.GetString("DurationMinutes"));
        }

        private static string Weeks(double weeks, IFormatProvider provider)
        {
            if (weeks == 1)
            {
				return string.Format(provider, "{0} {1}", weeks, LocalizationManager.GetString("DurationWeek"));
            }

			return string.Format(provider, "{0} {1}", weeks, LocalizationManager.GetString("DurationWeeks"));
        }
    }
}