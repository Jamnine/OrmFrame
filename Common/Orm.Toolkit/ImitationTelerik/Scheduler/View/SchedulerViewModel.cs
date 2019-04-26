using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents and holds data for the view of the scheduler.
    /// </summary>
    public class SchedulerViewModel : INotifyPropertyChanged
    {
        private readonly SingleMonthWeekViewDefinition allDayActiveViewDefinition;
        private readonly TimeSlotCollectionView allDayTimeSlotsView;
        private readonly TimeSlotCollectionView dayTimeSlotsView;
        private readonly IScheduler scheduler;
        private ViewDefinitionBase activeViewDefinition;
        private string displayInterval;
        private DateTime startDate;
        private DateTime visibleRangeEnd;
        private DateTime visibleRangeStart;
        private bool isGrouped;

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel"/> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        /// <exception cref="ArgumentNullException">scheduler</exception>
        internal SchedulerViewModel(IScheduler scheduler)
        {
            if (scheduler == null)
            {
                throw new ArgumentNullException("scheduler");
            }
            this.scheduler = scheduler;
            scheduler.ActiveViewDefinitionChanged += this.OnViewModeChanged;

            this.dayTimeSlotsView = new TimeSlotCollectionView();
            this.dayTimeSlotsView.Scheduler = this.Scheduler as RadScheduler;
            this.activeViewDefinition = scheduler.ActiveViewDefinition;
            this.activeViewDefinition.ViewDefinitionChanged += this.OnViewDefinitionChanged;

            this.allDayTimeSlotsView = new TimeSlotCollectionView();
            this.allDayActiveViewDefinition = new SingleMonthWeekViewDefinition(this.activeViewDefinition);
            this.allDayTimeSlotsView.GroupDescriptions.AddRange(this.allDayActiveViewDefinition.GroupDescriptions);

            scheduler.SelectedTimeSlot = new TimeSlot(DateTime.Today, TimeSpan.FromDays(1));
            this.startDate = this.GetStartDateForViewDefinition(
                this.activeViewDefinition,
                scheduler.SelectedTimeSlot.Start);

            this.RecreateTimeSlots();
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets all day time slots view.
        /// </summary>
        /// <value>All day time slots view.</value>
        public TimeSlotCollectionView AllDayTimeSlotsView
        {
            get
            {
                return this.allDayTimeSlotsView;
            }
        }

        /// <summary>
        /// Gets or sets the display interval.
        /// </summary>
        /// <value>The display interval.</value>
        public string DisplayInterval
        {
            get
            {
                return this.displayInterval;
            }
            set
            {
                if (this.displayInterval != value)
                {
                    this.displayInterval = value;
                    this.OnPropertyChanged("DisplayInterval");
                }
            }
        }

        /// <summary>
        /// Gets or sets the time slots view.
        /// </summary>
        /// <value>The time slots view.</value>
        public TimeSlotCollectionView TimeSlotsView
        {
            get
            {
                return this.dayTimeSlotsView;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is grouped.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance is grouped; otherwise, <c>false</c>.
        /// </value>
        public bool IsGrouped
        {
            get
            {
                return this.isGrouped;
            }
            internal set
            {
                if (this.isGrouped != value)
                {
                    this.isGrouped = value;
                    this.OnPropertyChanged("IsGrouped");
                }
            }
        }

        internal IScheduler Scheduler
        {
            get
            {
                return this.scheduler;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
				if (this.startDate != value)
				{
					this.startDate = value;
					this.RecreateTimeSlots();
					this.Scheduler.OnSelectedViewStartDateChanged();
				}
            }
        }

        internal DateTime VisibleRangeEnd
        {
            get
            {
                return this.visibleRangeEnd;
            }
            set
            {
                if (this.visibleRangeEnd != value)
                {
                    this.visibleRangeEnd = value;
                    this.OnPropertyChanged("VisibleRangeEnd");
                }
            }
        }

        internal DateTime VisibleRangeStart
        {
            get
            {
                return this.visibleRangeStart;
            }
            set
            {
                if (this.visibleRangeStart != value)
                {
                    this.visibleRangeStart = value;
                    this.OnPropertyChanged("VisibleRangeStart");
                }
            }
        }

        /// <summary>
        /// Gets the start date for view definition.
        /// </summary>
        /// <param name="definition">The definition.</param>
        /// <param name="selectedDate">The selected date.</param>
        /// <returns></returns>
        public DateTime GetStartDateForViewDefinition(ViewDefinitionBase definition, DateTime selectedDate)
        {
            if (definition is MonthViewDefinition)
            {
                return this.scheduler.FirstDayOfFirstWeekOfMonthForVisibleDate(selectedDate);
            }
            if (definition is WeekViewDefinition)
            {
                return this.scheduler.FirstDayOfWeekForVisibleDate(selectedDate);
            }
            if (definition is TimelineViewDefinition)
            {
				var delta = DateTimeInterval.FromDays((this.scheduler.SelectedTimeSlot.Start - this.visibleRangeStart).Days % definition.VisibleDays);
				if (this.scheduler.SelectedTimeSlot.Start < this.visibleRangeEnd && this.scheduler.SelectedTimeSlot.Start > this.visibleRangeStart)
				{	
					return selectedDate.SubtractInterval(delta);
				}
            }
            return selectedDate;
        }

        internal void DecreaseViewDates(DateTimeInterval interval)
        {
            this.scheduler.SelectedTimeSlot = this.scheduler.SelectedTimeSlot.SubtractInterval(interval);
            
            if (interval.Months == 0 || (this.activeViewDefinition is TimelineViewDefinition && interval.Months > 0 && interval.Days == 0))
            {
                this.StartDate = this.StartDate.SubtractInterval(interval);
            }
            else
            {
                this.StartDate = this.GetStartDateForViewDefinition(this.activeViewDefinition, this.scheduler.SelectedTimeSlot.Start);
            }
        }

        internal void IncreaseViewDates(DateTimeInterval interval)
        {
            this.scheduler.SelectedTimeSlot = this.scheduler.SelectedTimeSlot.AddInterval(interval);
            if (interval.Months == 0)
            {
                this.StartDate = this.StartDate.AddInterval(interval);
            }
            else
            {
                this.StartDate = this.GetStartDateForViewDefinition(this.activeViewDefinition, this.scheduler.SelectedTimeSlot.Start);
            }
        }

        internal void InvalidateDisplayInterval()
        {
            if (this.TimeSlotsView.Count > 0)
            {
                this.DisplayInterval = TimeSlotCollectionViewToString(
                    this.TimeSlotsView.First().Start,
                    this.TimeSlotsView.Last().End,
                    this.scheduler);
            }
        }

        /// <summary>
        /// Called when some property changed.
        /// </summary>
        /// <param name="name">The name.</param>
        protected void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private static TimeSlot GetSelectedTimeSlotForViewDefinition(ViewDefinitionBase definition, TimeSlot slot)
        {
            if (definition is MonthViewDefinition)
            {
                return new TimeSlot(
                    new DateTime(slot.Start.Year, slot.Start.Month, slot.Start.Day),
                    TimeSpan.FromDays(1));
            }
            if (definition is WeekViewDefinition)
            {
                return new TimeSlot(
                    new DateTime(slot.Start.Year, slot.Start.Month, slot.Start.Day),
                    TimeSpan.FromDays(1));
            }
            return slot;
        }

        private static string TimeSlotCollectionViewToString(DateTime start, DateTime end, IScheduler scheduler)
        {
            CultureInfo culture = scheduler.GetCultureInUse();
            end = end.AddMilliseconds(-1);
            if (scheduler.ActiveViewDefinition is MonthViewDefinition)
            {
                start = CalendarHelper.GetLastDayOfWeek(start, scheduler.GetFirstDayOfWeekInUse());
                end = CalendarHelper.GetFirstDayOfWeek(end, scheduler.GetFirstDayOfWeekInUse());

                string s = end.ToString("yyyy MMM", culture);
                if (start.Year != end.Year)
                {
                    return start.ToString("yyyy MMM", culture) + " - " + s;
                }
                if (start.Month != end.Month)
                {
                    return start.ToString("MMM", culture) + " - " + s;
                }

                return s;
            }
            if (scheduler.ActiveViewDefinition is WeekViewDefinition ||
                scheduler.ActiveViewDefinition is TimelineViewDefinition)
            {
                string s = start.ToString("yyyy MMM  d ");
				if (start.Date == end.Date)
				{
					s = start.ToString("yyyy MMM d", culture);
					return s;
				}
                if (start.Year != end.Year)
                {
                    s = start.ToString("yyyy MMM d", culture);
                }
                else if (start.Month != end.Month)
                {
                    s = start.ToString("MMM  d ", culture);
                }

                return  s + " -" + end.ToString(" d");
            }
            if (scheduler.ActiveViewDefinition is DayViewDefinition)
            {
                return start.ToString(culture.DateTimeFormat.LongDatePattern, culture);
            }

            return string.Empty;
        }

        private void OnViewDefinitionChanged(object sender, EventArgs e)
        {
            this.RecreateTimeSlots();
        }

        private void OnViewModeChanged(object sender, EventArgs e)
        {
            ViewDefinitionBase newDefinition = this.scheduler.ActiveViewDefinition;
            if (this.activeViewDefinition != newDefinition)
            {
                this.startDate = this.GetStartDateForViewDefinition(newDefinition, this.scheduler.SelectedTimeSlot.Start);
                this.activeViewDefinition.ViewDefinitionChanged -= this.OnViewDefinitionChanged;
                this.activeViewDefinition = this.scheduler.ActiveViewDefinition;
                this.allDayActiveViewDefinition.ActiveViewDefinition = this.activeViewDefinition;
                this.activeViewDefinition.ViewDefinitionChanged += this.OnViewDefinitionChanged;
                TimeSlot selectedTimeSlot = GetSelectedTimeSlotForViewDefinition(
                    newDefinition,
                    this.scheduler.SelectedTimeSlot);
                this.RecreateTimeSlots();
                this.scheduler.SelectedTimeSlot = selectedTimeSlot;
            }
        }

        private void RecreateAllDayTimeSlots()
        {
            using (this.allDayTimeSlotsView.DeferRefresh())
            {
                this.allDayTimeSlotsView.Clear();
                this.allDayTimeSlotsView.AddRange(this.allDayActiveViewDefinition.GenerateTimeSlots(this.StartDate));
            }

            this.allDayTimeSlotsView.RaiseTimeSlotsUpdated();
        }

        private void RecreateNotAllDayTimeSlots()
        {
            using (this.dayTimeSlotsView.DeferRefresh())
            {
                this.dayTimeSlotsView.Clear();
                this.RefreshNotAllDayGroupDesriptions();

                IEnumerable<TimeSlot> slots = this.activeViewDefinition.GenerateTimeSlots(this.StartDate);
                this.dayTimeSlotsView.AddRange(slots);
            }

            this.dayTimeSlotsView.RaiseTimeSlotsUpdated();
        }

        private void RecreateTimeSlots()
        {   
            if (this.activeViewDefinition is MonthViewDefinition)
            {
                this.activeViewDefinition.ViewDefinitionChanged -= this.OnViewDefinitionChanged;
                this.activeViewDefinition.VisibleDays =
				    this.scheduler.GetDaysInMonthView(this.scheduler.SelectedTimeSlot.Start);
                this.activeViewDefinition.ViewDefinitionChanged += this.OnViewDefinitionChanged;
            }
            else if (this.activeViewDefinition is DayViewDefinition || this.activeViewDefinition is WeekViewDefinition)
            {
                this.RecreateAllDayTimeSlots();
            }

            this.RecreateNotAllDayTimeSlots();

            this.InvalidateDisplayInterval();
            this.SetVisibleRangeDates();
        }

        private void RefreshNotAllDayGroupDesriptions()
        {
            this.dayTimeSlotsView.GroupDescriptions.Clear();
            this.dayTimeSlotsView.GroupDescriptions.AddRange(this.activeViewDefinition.GroupDescriptions);

            for (int index = 0; index < this.dayTimeSlotsView.GroupDescriptions.Count; index++)
            {
                var description = (PropertyGroupDescription)this.dayTimeSlotsView.GroupDescriptions[index];
                PropertyGroupDescription newDescription = this.activeViewDefinition.GroupDescriptions[index];

                description.PropertyName = newDescription.PropertyName;
                description.Converter = newDescription.Converter;

                if (description.Converter != null)
                {
                    ((ISchedulerConverter)description.Converter).Scheduler = this.scheduler;
                }
            }
        }

        private void SetVisibleRangeDates()
        {
            DateTime start = DateTime.MinValue;
            DateTime end = DateTime.MinValue;

            if (this.TimeSlotsView.Count > 0)
            {
                start = this.TimeSlotsView.First().Start;
                end = this.TimeSlotsView.Last().End;
            }

            this.VisibleRangeEnd = end;
            this.VisibleRangeStart = start;
        }
    }
}
