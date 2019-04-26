using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// View model for <see cref="RecurrenceDialogWindow"/> class.
    /// </summary>
    public class RecurrenceDialogViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Default <see cref="MaxOccurrences"/> value.
        /// </summary>
        public static readonly int DefaultMaxOccurrences = 10;

        private int dayOfMonth;
        private DateTime end;
        private int interval;
        private int maxOccurrences;
        private int monthOfYear;
        private RecurrenceDays nthRecurrenceDay;
        private List<NameValueItem<RecurrenceDays>> nthRecurrenceDays;
        private RecurrenceRangeType recurrenceRangeType;
        private RecurrenceType recurrenceType;
        private DateTime recursUntil;
        private DateTime start;

        private WeekOfMonth weekOfMonth;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceDialogViewModel"/> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        internal RecurrenceDialogViewModel(IScheduler scheduler)
        {
            this.Scheduler = scheduler;
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The date of the month on which the event recurs (for example, the first
        /// day of the month, or the third to last day of the month).
        /// </summary>
        public int DayOfMonth
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

        /// <summary>The duration of the recurring event.</summary>
        public TimeSpan Duration
        {
            get
            {
                return this.end - this.start;
            }
            set
            {
                this.End = this.Start + value;
            }
        }

        /// <summary>
        /// The last date and time for the event to occur. Either this or Count may
        /// be used, but not both.
        /// </summary>
        public DateTime End
        {
            get
            {
                return this.end;
            }
            set
            {
                if (this.end != value)
                {
                    this.end = value;
                    this.OnPropertyChanged("End");
                }

                this.OnPropertyChanged("Duration");
            }
        }

        /// <summary>
        /// A number indicating how often this rule repeats, when combined with the frequency.
        /// </summary>
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
        /// Optional limit for the number of occurrences.
        /// </summary>
        /// <value></value>
        public int MaxOccurrences
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
        public int MonthOfYear
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
        /// Gets the names of months.
        /// </summary>
        /// <value>The names of months.</value>
        public IDictionary<int, string> NamesOfMonths { get; private set; }

        /// <summary>
        /// Gets or sets the nth recurrence day.
        /// </summary>
        /// <value>The nth recurrence day.</value>
        public RecurrenceDays NthRecurrenceDay
        {
            get
            {
                return this.nthRecurrenceDay;
            }
            set
            {
                if (this.nthRecurrenceDay != value)
                {
                    this.nthRecurrenceDay = value;
                    this.OnPropertyChanged("NthRecurrenceDay");
                }
            }
        }

        /// <summary>
        /// Gets the NTH recurrence days.
        /// </summary>
        /// <value>The NTH recurrence days.</value>
        public IList<NameValueItem<RecurrenceDays>> NthRecurrenceDays
        {
            get
            {
                return this.nthRecurrenceDays;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating the type of recurrence range.
        /// </summary>
        /// <value>The type of the recurrence range.</value>
        public RecurrenceRangeType RecurrenceRangeType
        {
            get
            {
                return this.recurrenceRangeType;
            }
            set
            {
                if (this.recurrenceRangeType != value)
                {
                    this.recurrenceRangeType = value;
                    if (this.recurrenceRangeType != RecurrenceRangeType.MaxOccurrences)
                    {
                        this.MaxOccurrences = DefaultMaxOccurrences;
                    }
                    this.OnPropertyChanged("RecurrenceRangeType");
                }
            }
        }

        /// <summary>
        /// Gets or sets the type of the recurrence.
        /// </summary>
        /// <value>The type of the recurrence.</value>
        public RecurrenceType RecurrenceType
        {
            get
            {
                return this.recurrenceType;
            }
            set
            {
                if (this.recurrenceType != value)
                {
                    this.recurrenceType = value;
                    this.OnPropertyChanged("RecurrenceType");
                }
            }
        }

        /// <summary>
        /// Optional end date for the recurring appointment.
        /// </summary>
        /// <value></value>
        public DateTime RecursUntil
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

        /// <summary>The start of the recurring event.</summary>
        public DateTime Start
        {
            get
            {
                return this.start;
            }
            set
            {
                if (this.start != value)
                {
                    TimeSpan diff = this.start - value;
                    this.start = value;
                    this.OnPropertyChanged("Start");
                    this.OnPropertyChanged("Duration");
                    if (diff.Days != 0)
                    {
                        this.RecursUntil = this.start.AddMonths(2).AddDays(2);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the week days.
        /// </summary>
        /// <value>The week days.</value>
        public IList<NameValueItem<RecurrenceDays>> WeekDays { get; private set; }

        /// <summary>
        /// Gets or sets the week of month.
        /// </summary>
        /// <value>The week of month.</value>
        public WeekOfMonth WeekOfMonth
        {
            get
            {
                return this.weekOfMonth;
            }
            set
            {
                if (this.weekOfMonth != value)
                {
                    this.weekOfMonth = value;
                    this.OnPropertyChanged("WeekOfMonth");
                }
            }
        }

        /// <summary>
        /// Gets the week of months.
        /// </summary>
        /// <value>The week of months.</value>
        public IList<NameValueItem<WeekOfMonth>> WeekOfMonths { get; private set; }

        /// <summary>
        /// Gets or sets the scheduler.
        /// </summary>
        /// <value>The scheduler.</value>
        internal IScheduler Scheduler { get; private set; }

        /// <summary>
        /// Creates the rule.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Not supported <see cref="RecurrenceType"/>.</exception>
        public IAppointment CreateRule()
        {
            var pattern = new RecurrencePattern();

            switch (this.RecurrenceType)
            {
                case RecurrenceType.Daily:
                    pattern.Interval = this.Interval;
                    pattern.DaysOfWeekMask = RecurrenceDays.EveryDay;
                    pattern.Frequency = RecurrenceFrequency.Daily;
                    break;
                case RecurrenceType.WeekDays:
                    pattern.Frequency = RecurrenceFrequency.Weekly;
                    pattern.DaysOfWeekMask = RecurrenceDays.WeekDays;
                    pattern.Interval = 1;
                    break;
                case RecurrenceType.Weekly:
                    pattern.Frequency = RecurrenceFrequency.Weekly;
                    pattern.Interval = this.Interval;
                    pattern.DaysOfWeekMask = this.GetRecurrenceDays();
                    pattern.FirstDayOfWeek = this.Scheduler.GetFirstDayOfWeekInUse();
                    break;
                case RecurrenceType.Monthly:
                    pattern.Frequency = RecurrenceFrequency.Monthly;
                    pattern.Interval = this.Interval;
                    pattern.DayOfMonth = this.DayOfMonth;
                    break;
                case RecurrenceType.MonthlyNth:
                    pattern.Frequency = RecurrenceFrequency.Monthly;
                    pattern.DayOrdinal = this.WeekOfMonth.ToInt32();
                    pattern.DaysOfWeekMask = this.NthRecurrenceDay;
                    pattern.Interval = this.Interval;
                    break;
                case RecurrenceType.Yearly:
                    pattern.Frequency = RecurrenceFrequency.Yearly;
                    pattern.MonthOfYear = this.MonthOfYear;
                    pattern.DayOfMonth = this.DayOfMonth;
                    break;
                case RecurrenceType.YearlyNth:
                    pattern.Frequency = RecurrenceFrequency.Yearly;
                    pattern.DayOrdinal = this.WeekOfMonth.ToInt32();
                    pattern.DaysOfWeekMask = this.NthRecurrenceDay;
                    pattern.MonthOfYear = this.MonthOfYear;
                    break;
                default:
                    throw new ArgumentException("RecurrenceType");
            }

            switch (this.RecurrenceRangeType)
            {
                case RecurrenceRangeType.NoEndDate:
                    break;
                case RecurrenceRangeType.MaxOccurrences:
                    pattern.MaxOccurrences = this.MaxOccurrences;
                    break;
                case RecurrenceRangeType.RepeatUntil:
                    pattern.RecursUntil = this.RecursUntil;
                    break;
            }
            if (!this.IsValidRecurrencePattern(pattern))
            {
                return null;
            }

            ////TODO: change result type
            return new Appointment
                       {
                           Start = this.Start,
                           End = this.Start + this.Duration,
                           RecurrenceRule = new RecurrenceRule(pattern)
                       };
        }

        /// <summary>
        /// Creates the view.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        /// <param name="appointment">The appointment.</param>
        /// <returns></returns>
        internal static RecurrenceDialogViewModel CreateView(IScheduler scheduler, IAppointment appointment)
        {
            var view = new RecurrenceDialogViewModel(scheduler);
            CultureInfo culture = scheduler.GetCultureInUse();

            DateTime start = appointment.Start;

            RecurrencePattern recurrencePattern = appointment.RecurrenceRule == null
                                                      ? new RecurrencePattern
                                                            {
                                                                Frequency = RecurrenceFrequency.Weekly,
                                                                Interval = 1,
                                                                DaysOfWeekMask =
                                                                    appointment.Start.DayOfWeek.GetRecurrenceDay(),
                                                                FirstDayOfWeek = scheduler.GetFirstDayOfWeekInUse(),
                                                            }
                                                      : appointment.RecurrenceRule.Pattern.Copy();

            view.Start = start;
            view.Duration = appointment.End - appointment.Start;
            view.MaxOccurrences = recurrencePattern.MaxOccurrences ?? DefaultMaxOccurrences;
            if (recurrencePattern.RecursUntil.HasValue)
            {
                view.RecursUntil = recurrencePattern.RecursUntil.Value;
            }
            view.RecurrenceRangeType = GetRangeType(recurrencePattern);

            view.Interval = recurrencePattern.Interval;
            view.RecurrenceType = GetTypeFromRule(recurrencePattern);
            view.DayOfMonth = recurrencePattern.DayOfMonth ?? culture.Calendar.GetDayOfMonth(start);
            view.NthRecurrenceDay = recurrencePattern.DaysOfWeekMask == RecurrenceDays.None
                                        ? start.DayOfWeek.GetRecurrenceDay()
                                        : recurrencePattern.DaysOfWeekMask;
            view.MonthOfYear = recurrencePattern.MonthOfYear ?? start.Month;
            view.WeekOfMonth = recurrencePattern.DayOrdinal.HasValue
                                   ? FromIntToWeekOfMonth(recurrencePattern.DayOrdinal.Value)
                                   : GetWeekOfMonth(start, view.DayOfMonth);
            view.WeekDays = CreateWeekDays(scheduler, view.NthRecurrenceDay);
            view.NamesOfMonths = CalendarHelper.GetNamesOfMonths(culture);
            view.WeekOfMonths = CreateWeekOfMonths();
            view.nthRecurrenceDays = CreateNthRecurrenceDays(scheduler);

            return view;
        }

        /// <summary>
        /// Raises the property changed.
        /// </summary>
        /// <param name="name">The name.</param>
        protected virtual void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private static List<NameValueItem<RecurrenceDays>> CreateNthRecurrenceDays(IScheduler scheduler)
        {
            var result = new List<NameValueItem<RecurrenceDays>>
                             {
                                 new NameValueItem<RecurrenceDays>(
                                     RecurrenceDays.EveryDay,
                                     LocalizationManager.GetString("EveryDay")),
                                 new NameValueItem<RecurrenceDays>(
                                     RecurrenceDays.WeekDays,
                                     LocalizationManager.GetString("WeekDays")),
                                 new NameValueItem<RecurrenceDays>(
                                     RecurrenceDays.WeekendDays,
                                      LocalizationManager.GetString("WeekendDays"))
                             };

            result.AddRange(CreateWeekDays(scheduler, RecurrenceDays.None));

            return result;
        }

        private static List<NameValueItem<RecurrenceDays>> CreateWeekDays(
            IScheduler scheduler,
            RecurrenceDays dayOfWeekMask)
        {
            var days = new List<NameValueItem<RecurrenceDays>>();
            IDictionary<DayOfWeek, string> namesOfDays = CalendarHelper.GetNamesOfDays(scheduler.GetCultureInUse());
            foreach (
                DayOfWeek dayOfWeek in
                    CalendarHelper.GetDaysOfWeekStartWithFirstDayOfWeek(scheduler.GetFirstDayOfWeekInUse()))
            {
                RecurrenceDays recurrenceDay = dayOfWeek.GetRecurrenceDay();
                var day = new NameValueItem<RecurrenceDays>(
                    recurrenceDay,
                    namesOfDays[dayOfWeek],
                    dayOfWeekMask.HasDay(recurrenceDay));
                days.Add(day);
            }

            return days;
        }

        private static List<NameValueItem<WeekOfMonth>> CreateWeekOfMonths()
        {
            var result = new List<NameValueItem<WeekOfMonth>>
                             {
                                 new NameValueItem<WeekOfMonth>(WeekOfMonth.First, LocalizationManager.GetString("First")),
                                 new NameValueItem<WeekOfMonth>(WeekOfMonth.Second, LocalizationManager.GetString("Second")),
                                 new NameValueItem<WeekOfMonth>(WeekOfMonth.Third, LocalizationManager.GetString("Third")),
                                 new NameValueItem<WeekOfMonth>(WeekOfMonth.Fourth, LocalizationManager.GetString("Fourth")),
                                 new NameValueItem<WeekOfMonth>(WeekOfMonth.Last, LocalizationManager.GetString("Last"))
                             };

            return result;
        }

        private static WeekOfMonth FromIntToWeekOfMonth(int dayOrdinal)
        {
            if (dayOrdinal < 0)
            {
                return WeekOfMonth.Last;
            }
            if (dayOrdinal > 4)
            {
                return WeekOfMonth.Fourth;
            }

            return (WeekOfMonth)dayOrdinal;
        }

        private static RecurrenceRangeType GetRangeType(RecurrencePattern range)
        {
            if (range.MaxOccurrences < Int32.MaxValue)
            {
                return RecurrenceRangeType.MaxOccurrences;
            }
            if (range.RecursUntil != null && range.RecursUntil != DateTime.MaxValue)
            {
                return RecurrenceRangeType.RepeatUntil;
            }

            return RecurrenceRangeType.NoEndDate;
        }

        private static RecurrenceType GetTypeFromRule(RecurrencePattern pattern)
        {
            switch (pattern.Frequency)
            {
                case RecurrenceFrequency.Daily:
                    return RecurrenceType.Daily;
                case RecurrenceFrequency.Weekly:
                    if (pattern.Interval == 1 && pattern.DaysOfWeekMask == RecurrenceDays.WeekDays)
                    {
                        return RecurrenceType.WeekDays;
                    }
                    return RecurrenceType.Weekly;
                case RecurrenceFrequency.Monthly:
                    if (pattern.DayOfMonth > 0)
                    {
                        return RecurrenceType.Monthly;
                    }
                    return RecurrenceType.MonthlyNth;
                case RecurrenceFrequency.Yearly:
                    if (pattern.DayOfMonth > 0)
                    {
                        return RecurrenceType.Yearly;
                    }
                    return RecurrenceType.YearlyNth;
            }

            return RecurrenceType.Weekly;
        }

        private static WeekOfMonth GetWeekOfMonth(DateTimeOffset date, int dayOfMonth)
        {
            int num = 1;
            var dateTime = new DateTime(date.Year, date.Month, 1);
            for (int i = 1; i < dayOfMonth; i++)
            {
                if (dateTime.DayOfWeek == date.DayOfWeek)
                {
                    num++;
                }
                dateTime = dateTime.AddDays(1.0);
            }
            return (WeekOfMonth)num;
        }

        private RecurrenceDays GetRecurrenceDays()
        {
            RecurrenceDays days = RecurrenceDays.None;

            foreach (var item in this.WeekDays)
            {
                if (item.IsSelected)
                {
                    days = days.AddDay(item.Value);
                }
            }

            return days;
        }

        private bool IsValidDuration(RecurrencePattern pattern)
        {
            int maxDays = pattern.GetMaxDaysDuration();
            if (this.Duration > TimeSpan.FromDays(maxDays))
            {
                return false;
            }

            return true;
        }

        private bool IsValidRecurrencePattern(RecurrencePattern pattern)
        {
            if (!RecurrencePattern.IsValidPattern(pattern))
            {
                return false;
            }
            if (this.Duration <= TimeSpan.Zero)
            {
                return false;
            }
            if (this.RecurrenceRangeType == RecurrenceRangeType.RepeatUntil && this.RecursUntil < this.Start)
            {
                return false;
            }

            if (!this.IsValidDuration(pattern))
            {
                return false;
            }

            switch (this.RecurrenceType)
            {
                case RecurrenceType.Monthly:
                    return this.DayOfMonth > 0 && this.DayOfMonth < 32;
                case RecurrenceType.Yearly:
                    int daysInMoth = DateTime.DaysInMonth(this.Start.Year, this.MonthOfYear);
                    return this.DayOfMonth <= daysInMoth && this.DayOfMonth > 0;
            }

            return true;
        }
    }
}