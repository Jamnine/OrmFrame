using System;
using System.Collections.Generic;
using System.Linq;

using Orm.Toolkit.ImitationTelerik;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{

    /// <summary>
    /// <see cref="RecurrenceDays"/> extensions methods.
    /// </summary>
    public static class RecurrenceDaysExtensions
    {
        /// <summary>
        /// Adds the day.
        /// </summary>
        /// <param name="recurrenceDays">The recurrence days.</param>
        /// <param name="dayToAdd">The day to add.</param>
        public static RecurrenceDays AddDay(this RecurrenceDays recurrenceDays, RecurrenceDays dayToAdd)
        {
            return recurrenceDays | dayToAdd;
        }

        /// <summary>
        /// Gets the day of week.
        /// </summary>
        /// <param name="recurrenceDays">The recurrence days.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"><paramref name="recurrenceDays"/></exception>
        public static DayOfWeek GetDayOfWeek(this RecurrenceDays recurrenceDays)
        {
            List<DayOfWeek> daysOfWeek = GetDaysOfWeek(recurrenceDays).ToList();

            if (daysOfWeek.Count != 1)
            {
                throw new ArgumentException(ExceptionsStrings.ContainsOnlyOneFlagValue, "recurrenceDays");
            }

            return daysOfWeek[0];
        }

        /// <summary>
        /// Gets the days of week.
        /// </summary>
        /// <param name="recurrenceDays">The recurrence days.</param>
        /// <returns></returns>
        public static IEnumerable<DayOfWeek> GetDaysOfWeek(this RecurrenceDays recurrenceDays)
        {
            var dayOfWeeks = new List<DayOfWeek>();
            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
            {
                if (recurrenceDays.HasDay(dayOfWeek))
                {
                    dayOfWeeks.Add(dayOfWeek);
                }
            }
            dayOfWeeks.Sort();

            return dayOfWeeks;
        }

        /// <summary>
        /// Gets the recurrence day.
        /// </summary>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"><c>dayOfWeek</c> is out of range.</exception>
        public static RecurrenceDays GetRecurrenceDay(this DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Friday:
                    return RecurrenceDays.Friday;
                case DayOfWeek.Monday:
                    return RecurrenceDays.Monday;
                case DayOfWeek.Saturday:
                    return RecurrenceDays.Saturday;
                case DayOfWeek.Sunday:
                    return RecurrenceDays.Sunday;
                case DayOfWeek.Thursday:
                    return RecurrenceDays.Thursday;
                case DayOfWeek.Tuesday:
                    return RecurrenceDays.Tuesday;
                case DayOfWeek.Wednesday:
                    return RecurrenceDays.Wednesday;
                default:
                    throw new ArgumentOutOfRangeException("dayOfWeek");
            }
        }

        /// <summary>
        /// Determines whether the specified recurrence days has day.
        /// </summary>
        /// <param name="recurrenceDays">The recurrence days.</param>
        /// <param name="dayToCompare">The day to compare.</param>
        /// <returns>
        /// 	<c>true</c> if the specified recurrence days has day; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasDay(this RecurrenceDays recurrenceDays, RecurrenceDays dayToCompare)
        {
            if ((recurrenceDays & dayToCompare) == dayToCompare)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified recurrence days has day.
        /// </summary>
        /// <param name="recurrenceDays">The recurrence days.</param>
        /// <param name="dayToCompare">The day to compare.</param>
        /// <returns>
        /// 	<c>true</c> if the specified recurrence days has day; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasDay(this RecurrenceDays recurrenceDays, DayOfWeek dayToCompare)
        {
            RecurrenceDays recurrenceDayToCompare = dayToCompare.GetRecurrenceDay();
            return recurrenceDays.HasDay(recurrenceDayToCompare);
        }
    }
}