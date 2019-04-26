using System;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Extension methods for <see cref="IDateSpan"/> interface.
    /// </summary>
    public static class DateSpanExtensions
    {
        /// <summary>
        /// Determines whether <see cref="DateSpan"/> contains another <see cref="DateSpan"/>.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="other">The other.</param>
        /// <returns>
        /// 	<c>true</c> if contains another <see cref="DateSpan"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool Contains(this IDateSpan source, IDateSpan other)
        {
            return source.Start <= other.Start && source.End >= other.End;
        }

        /// <summary>
        /// Determines whether <see cref="DateSpan"/> contains <see cref="DateTime"/>.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="date">The date.</param>
        /// <returns>
        /// 	<c>true</c> if contains date; otherwise, <c>false</c>.
        /// </returns>
        public static bool Contains(this IDateSpan source, DateTime date)
        {
            return source.Start <= date && date < source.End;
        }

        /// <summary>
        /// Gets the duration of the specified date span.
        /// </summary>
        /// <param name="dateSpan">The date span.</param>
        /// <returns>Duration of the date span as devision of end and start.</returns>
        public static TimeSpan Duration(this IDateSpan dateSpan)
        {
            return dateSpan.End - dateSpan.Start;
        }

        /// <summary>
        /// <c>Intersectses</c> the with.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="other">The other.</param>
        /// <returns></returns>
        public static bool IntersectsWith(this IDateSpan source, IDateSpan other)
        {
            return (other.Start <= source.Start && source.Start < other.End) ||
                   (source.Start <= other.Start && other.Start < source.End);
        }

        /// <summary>
        /// Adds the interval.
        /// </summary>
        /// <param name="dateSpan">The date span.</param>
        /// <param name="dateTimeInterval">The date time interval.</param>
        /// <returns></returns>
        public static TimeSlot AddInterval(this IDateSpan dateSpan, DateTimeInterval dateTimeInterval)
        {
            return new TimeSlot(
				dateSpan.Start.AddHours(dateTimeInterval.Hours).AddDays(dateTimeInterval.Days).AddMonths(dateTimeInterval.Months),
				dateSpan.End.AddHours(dateTimeInterval.Hours).AddDays(dateTimeInterval.Days).AddMonths(dateTimeInterval.Months));
        }

        /// <summary>
        /// Subtracts the interval.
        /// </summary>
        /// <param name="dateSpan">The date span.</param>
        /// <param name="dateTimeInterval">The date time interval.</param>
        /// <returns></returns>
        public static TimeSlot SubtractInterval(this IDateSpan dateSpan, DateTimeInterval dateTimeInterval)
        {
            return new TimeSlot(
                dateSpan.Start.AddDays(-dateTimeInterval.Days).AddMonths(-dateTimeInterval.Months),
                dateSpan.End.AddDays(-dateTimeInterval.Days).AddMonths(-dateTimeInterval.Months));
        }

        /// <summary>
        /// Validates the specified date span.
        /// </summary>
        /// <param name="dateSpan">The date span.</param>
        /// <returns></returns>
        public static bool Validate(this IDateSpan dateSpan)
        {
            return (dateSpan.Start != DateTime.MinValue) &&
                   (dateSpan.End != DateTime.MaxValue) &&
                   dateSpan.Start <= dateSpan.End;
        }
    }
}