using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>Provides the class for recurrence pattern.</summary>
    [Serializable]
    public class RecurrencePattern : INotifyPropertyChanged
    {
        internal static readonly int MaxMonthlyDays = 28;
        internal static readonly int MaxWeeklyDays = 7;
        internal static readonly int MaxYearlyDays = 336;

        private int? dayOfMonth;
        private int? dayOrdinal;
        private RecurrenceDays daysOfWeekMask;
        private DayOfWeek firstDayOfWeek;
        private RecurrenceFrequency frequency;
        private int interval;
        private int? maxOccurrences;
        private int? monthOfYear;
        private DateTime? recursUntil;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrencePattern"/> class.
        /// </summary>
        public RecurrencePattern()
        {
            this.dayOfMonth = null;
            this.daysOfWeekMask = RecurrenceDays.None;
            this.frequency = RecurrenceFrequency.None;
            this.interval = 1;
            this.monthOfYear = null;
            this.dayOrdinal = null;

            this.recursUntil = null;
            this.maxOccurrences = null;
            this.firstDayOfWeek = DayOfWeek.Monday;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrencePattern"/> class.
        /// </summary>
        /// <param name="dayOfMonth">The day of month.</param>
        /// <param name="daysOfWeekMask">The days of week mask.</param>
        /// <param name="frequency">The frequency.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="monthOfYear">The month of year.</param>
        /// <param name="dayOrdinal">The week of month.</param>
        public RecurrencePattern(
            int? dayOfMonth,
            RecurrenceDays daysOfWeekMask,
            RecurrenceFrequency frequency,
            int interval,
            int? monthOfYear,
            int? dayOrdinal)
            : this()
        {
            this.dayOfMonth = dayOfMonth;
            this.daysOfWeekMask = daysOfWeekMask;
            this.frequency = frequency;
            this.interval = interval;
            this.monthOfYear = monthOfYear;
            this.dayOrdinal = dayOrdinal;
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the day of month.
        /// </summary>
        /// <value>The day of month.</value>
        public int? DayOfMonth
        {
            get
            {
                return this.dayOfMonth;
            }
            set
            {
                if (this.dayOfMonth != value)
                {
                    this.dayOfMonth = value;
                    this.OnPropertyChanged("DayOfMonth");
                }
            }
        }

        /// <summary>
        /// Gets or sets the day ordinal.
        /// </summary>
        /// <value>The day ordinal.</value>
        public int? DayOrdinal
        {
            get
            {
                return this.dayOrdinal;
            }
            set
            {
                if (this.dayOrdinal != value)
                {
                    this.dayOrdinal = value;
                    this.OnPropertyChanged("WeekOfMonth");
                }
            }
        }

        /// <summary>
        /// Gets or sets the days of week mask.
        /// </summary>
        /// <value>The days of week mask.</value>
        public RecurrenceDays DaysOfWeekMask
        {
            get
            {
                return this.daysOfWeekMask;
            }
            set
            {
                if (this.daysOfWeekMask != value)
                {
                    this.daysOfWeekMask = value;
                    this.OnPropertyChanged("DaysOfWeekMask");
                }
            }
        }

        /// <summary>Gets or sets the day on which the week starts.</summary>
        /// <value>
        ///     This property is only meaningful when <see cref="RecurrenceFrequency"/> is set
        ///     to <see cref="RecurrenceFrequency.Weekly"/> and <see cref="Interval"/> is greater than 1.
        /// </value>
        public DayOfWeek FirstDayOfWeek
        {
            get
            {
                return this.firstDayOfWeek;
            }
            set
            {
                if (this.firstDayOfWeek != value)
                {
                    this.firstDayOfWeek = value;
                    this.OnPropertyChanged("FirstDayOfWeek");
                }
            }
        }

        /// <summary>
        /// Gets or sets the frequency.
        /// </summary>
        /// <value>The frequency.</value>
        public RecurrenceFrequency Frequency
        {
            get
            {
                return this.frequency;
            }
            set
            {
                if (this.frequency != value)
                {
                    this.frequency = value;
                    this.OnPropertyChanged("Frequency");
                }
            }
        }

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        /// <value>The interval.</value>
        public int Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                if (this.interval != value)
                {
                    this.interval = value;
                    this.OnPropertyChanged("Interval");
                }
            }
        }

        /// <summary>
        /// Optional limit for the number of occurrences. Defaults to no limit
        /// (Int32.MaxInt).
        /// </summary>
        public int? MaxOccurrences
        {
            get
            {
                return this.maxOccurrences;
            }
            set
            {
                if (this.maxOccurrences != value)
                {
                    this.maxOccurrences = value;
                    this.OnPropertyChanged("MaxOccurrences");
                }
            }
        }

        /// <summary>
        /// Gets or sets the month of year.
        /// </summary>
        /// <value>The month of year.</value>
        public int? MonthOfYear
        {
            get
            {
                return this.monthOfYear;
            }
            set
            {
                if (this.monthOfYear != value)
                {
                    this.monthOfYear = value;
                    this.OnPropertyChanged("MonthOfYear");
                }
            }
        }

        /// <summary>
        /// Optional end date for the recurring appointment. Defaults to no end date
        /// (<see cref="DateTime"/>.MaxValue).
        /// </summary>
        /// <value>The recurs until.</value>
        public DateTime? RecursUntil
        {
            get
            {
                return this.recursUntil;
            }
            set
            {
                if (this.recursUntil != value)
                {
                    this.recursUntil = value;
                    this.OnPropertyChanged("RecursUntil");
                }
            }
        }

        /// <summary>
        /// 	<b>Deep</b> copies this instance.
        /// </summary>
        /// <returns>
        /// A <b>deep</b> copy of the current object.
        /// </returns>
        public RecurrencePattern Copy()
        {
            var rule = new RecurrencePattern();
            rule.CopyFrom(this);
            return rule;
        }

        /// <summary>
        /// Copies from.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <exception cref="ArgumentException">Invalid type</exception>
        public void CopyFrom(RecurrencePattern other)
        {
            if (this.GetType().FullName != other.GetType().FullName)
            {
                throw new ArgumentException("Invalid type");
            }

            this.Frequency = other.Frequency;
            this.Interval = other.Interval;
            this.DayOrdinal = other.DayOrdinal;
            this.DayOfMonth = other.DayOfMonth;
            this.DaysOfWeekMask = other.DaysOfWeekMask;
            this.MonthOfYear = other.MonthOfYear;

            this.RecursUntil = other.RecursUntil;
            this.MaxOccurrences = other.MaxOccurrences;
        }

        /// <summary>
        /// Gets the first occurrence.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        public DateTime? GetFirstOccurrence(DateTime start)
        {
            IEnumerator<DateTime> enumerator = this.GetOccurrences(start).GetEnumerator();
            if (enumerator.MoveNext())
            {
                return enumerator.Current;
            }

            return null;
        }

        /// <summary>
        /// Gets the occurrences.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        public IEnumerable<DateTime> GetOccurrences(DateTime start)
        {
            return this.GetOccurrences(start, DateTime.MinValue, DateTime.MaxValue);
        }

        /// <summary>
        /// Gets the occurrences.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public IEnumerable<DateTime> GetOccurrences(DateTime start, DateTime from, DateTime to)
        {
            int candidateIndex = 0;
            int occurrencesCount = 0;

            DateTime endDate = this.RecursUntil ?? DateTime.MaxValue;

            if (to < endDate)
            {
                endDate = to;
            }
            int maximumOccurrences = this.MaxOccurrences ?? Int32.MaxValue;

            while (occurrencesCount < maximumOccurrences)
            {
                DateTime nextStart = this.GetNextDate(start, candidateIndex++);

                if (endDate < nextStart)
                {
                    yield break;
                }

                if (!this.MatchPattern(start, nextStart))
                {
                    continue;
                }

                occurrencesCount++;

                if (nextStart < from)
                {
                    continue;
                }
                yield return nextStart;
            }
        }

        /// <summary>
        /// Determines whether pattern is valid.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns>
        /// 	<c>True</c> if pattern is valid; otherwise, <c>false</c>.
        /// </returns>
        internal static bool IsValidPattern(RecurrencePattern pattern)
        {
            if (pattern.MaxOccurrences.HasValue && pattern.MaxOccurrences.Value <= 0)
            {
                return false;
            }

            if (pattern.Interval <= 0)
            {
                return false;
            }

            switch (pattern.Frequency)
            {
                case RecurrenceFrequency.None:
                case RecurrenceFrequency.Secondly:
                case RecurrenceFrequency.Minutely:
                case RecurrenceFrequency.Hourly:
                    return false;
                case RecurrenceFrequency.Daily:
                {
                    if (pattern.DaysOfWeekMask == RecurrenceDays.None || pattern.DayOfMonth.HasValue ||
                        pattern.MonthOfYear.HasValue || pattern.DayOrdinal.HasValue)
                    {
                        return false;
                    }
                    break;
                }
                case RecurrenceFrequency.Weekly:
                    break;
                case RecurrenceFrequency.Monthly:
                    if (pattern.DayOfMonth.HasValue && pattern.DayOfMonth.Value == 0)
                    {
                        return false;
                    }
                    break;
                case RecurrenceFrequency.Yearly:
                {
                    if (!pattern.MonthOfYear.HasValue || pattern.MonthOfYear <= 0 ||
                        (pattern.DayOfMonth.HasValue && pattern.DayOfMonth.Value == 0))
                    {
                        return false;
                    }
                    break;
                }
                default:
                    break;
            }

            return true;
        }

        internal int GetMaxDaysDuration()
        {
            switch (this.Frequency)
            {
                case RecurrenceFrequency.None:
                case RecurrenceFrequency.Secondly:
                case RecurrenceFrequency.Minutely:
                case RecurrenceFrequency.Hourly:
                    return 0;
                case RecurrenceFrequency.Daily:
                    return this.Interval;
                case RecurrenceFrequency.Weekly:
                    return this.GetMaxWeeklyDaysDuration();
                case RecurrenceFrequency.Monthly:
                    return this.Interval * MaxMonthlyDays;
                case RecurrenceFrequency.Yearly:
                    return this.Interval * MaxYearlyDays;
                default:
                    return 0;
            }
        }

        internal int GetMaxWeeklyDaysDuration()
        {
            List<DayOfWeek> daysOfWeek = this.DaysOfWeekMask.GetDaysOfWeek().ToList();
            if (daysOfWeek.Count == 0)
            {
                return 0;
            }
            if (daysOfWeek.Count == 1)
            {
                return MaxWeeklyDays * this.Interval;
            }

            int maxWeeklyDays = MaxWeeklyDays;
            for (int i = 1; i < daysOfWeek.Count(); i++)
            {
                int diff = (int)daysOfWeek[i] - (int)daysOfWeek[i - 1];
                if (diff < maxWeeklyDays)
                {
                    maxWeeklyDays = diff;
                }
            }
            if (this.Interval == 1)
            {
                int diffLastFirst = (int)daysOfWeek.First() - (int)daysOfWeek.Last() + MaxWeeklyDays;
                if (diffLastFirst < maxWeeklyDays)
                {
                    maxWeeklyDays = diffLastFirst;
                }
            }

            return maxWeeklyDays;
        }

        /// <summary>
        /// Matches the day of week mask.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="daysOfWeekMask">The days of week mask.</param>
        /// <returns></returns>
        protected static bool MatchDayOfWeekMask(DateTime start, RecurrenceDays daysOfWeekMask)
        {
            if (daysOfWeekMask == RecurrenceDays.None)
            {
                return true;
            }

            return daysOfWeekMask.HasDay(start.DayOfWeek.GetRecurrenceDay());
        }

        /// <summary>
        /// Matches the day ordinal.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="dayOrdinal">The day ordinal.</param>
        /// <param name="daysOfWeekMask">The days of week mask.</param>
        /// <returns></returns>
        protected static bool MatchDayOrdinal(DateTime date, int? dayOrdinal, RecurrenceDays daysOfWeekMask)
        {
            if (!dayOrdinal.HasValue)
            {
                return true;
            }

            return (0 < dayOrdinal)
                       ? MatchDayOrdinalPositive(date, dayOrdinal.Value, daysOfWeekMask)
                       : MatchDayOrdinalNegative(date, dayOrdinal.Value, daysOfWeekMask);
        }

        /// <summary>
        /// Gets the next date when the rule can match.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="index">The index from the start.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Invalid <see cref="RecurrenceFrequency"/></exception>
        protected DateTime GetNextDate(DateTime start, int index)
        {
            switch (this.Frequency)
            {
                case RecurrenceFrequency.Daily:
                    return start.AddDays(index * this.Interval);
                case RecurrenceFrequency.Weekly:
                    return start.AddDays(index);
                case RecurrenceFrequency.Monthly:
                    return start.AddDays(index);
                case RecurrenceFrequency.Yearly:
                {
                    DateTime next = start;
                    int month = this.MonthOfYear.Value;

                    if (next.Month != month)
                    {
                        int year = next.Month < month ? next.Year : next.Year + 1;
                        next = new DateTime(year, month, 1, next.Hour, next.Minute, next.Second);
                    }

                    for (int i = 0; i < index; i++)
                    {
                        int year = next.Year + 1;
                        next = next.AddDays(1);

                        if (next.Month != month)
                        {
                            next = new DateTime(year, month, 1, next.Hour, next.Minute, next.Second);
                        }
                    }

                    return next;
                }
                default:
                    throw new ArgumentException("Invalid RecurrenceFrequency");
            }
        }

        /// <summary>
        /// Matches the pattern for a date.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="dateTime">The date to match.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Invalid <see cref="RecurrenceFrequency"/></exception>
        protected bool MatchPattern(DateTime start, DateTime dateTime)
        {
            switch (this.Frequency)
            {
                case RecurrenceFrequency.Daily:
                    return MatchDayOfWeekMask(dateTime, this.DaysOfWeekMask);
                case RecurrenceFrequency.Weekly:
                {
                    if (this.GetWeekIndex(start, dateTime) % this.Interval != 0)
                    {
                        return false;
                    }

                    if (this.DaysOfWeekMask == RecurrenceDays.None)
                    {
                        return start.DayOfWeek == dateTime.DayOfWeek;
                    }

                    return MatchDayOfWeekMask(dateTime, this.DaysOfWeekMask);
                }
                case RecurrenceFrequency.Monthly:
                {
                    if ((GetMonthIndex(start, dateTime) % this.Interval) != 0)
                    {
                        return false;
                    }

                    return this.MatchYearlyPattern(dateTime);
                }
                case RecurrenceFrequency.Yearly:
                {
                    return this.MatchYearlyPattern(dateTime);
                }
                default:
                    throw new ArgumentException("Invalid RecurrenceFrequency");
            }
        }

        /// <summary>
        /// Called when some of property was changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private static int GetMonthIndex(DateTime start, DateTime dateTime)
        {
            return start.Month - dateTime.Month;
        }

        private static bool MatchDayOrdinalNegative(DateTime date, int dayOrdinal, RecurrenceDays dayOfWeekMask)
        {
            DateTime currentDate = CalendarHelper.GetEndOfMonth(date.Year, date.Month);
            int current = 0;
            while (date < currentDate)
            {
                if (MatchDayOfWeekMask(currentDate, dayOfWeekMask))
                {
                    current--;
                }

                currentDate = currentDate.AddDays(-1);
            }

            return current == dayOrdinal;
        }

        private static bool MatchDayOrdinalPositive(
            DateTime date,
            int dayOrdinal,
            RecurrenceDays dayOfWeekMask)
        {
            DateTime currentDate = CalendarHelper.GetStartOfMonth(date.Year, date.Month);
            int current = 0;
            while (currentDate <= date)
            {
                if (MatchDayOfWeekMask(currentDate, dayOfWeekMask))
                {
                    current++;
                }

                currentDate = currentDate.AddDays(1);
            }

            return current == dayOrdinal;
        }

        private int GetWeekIndex(DateTime start, DateTime current)
        {
            DateTime firstWeekStart = CalendarHelper.GetFirstDayOfWeek(start, this.FirstDayOfWeek);
            TimeSpan fromStart = current.Subtract(firstWeekStart);

            return fromStart.Days / 7;
        }

        private bool MatchYearlyPattern(DateTime dateTime)
        {
            int dayOfMonth1 = this.DayOfMonth ?? 0;
            if (this.DayOfMonth.HasValue && dayOfMonth1 < 0)
            {
                int daysInMonth = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
                dayOfMonth1 = daysInMonth + dayOfMonth1 + 1;
                if (dayOfMonth1 <= 0)
                {
                    return false;
                }
            }
            if (dayOfMonth1 > 0 && dateTime.Day != dayOfMonth1)
            {
                return false;
            }

            if (!MatchDayOfWeekMask(dateTime, this.DaysOfWeekMask))
            {
                return false;
            }

            if (!MatchDayOrdinal(dateTime, this.DayOrdinal, this.DaysOfWeekMask))
            {
                return false;
            }

            return true;
        }
    }
}