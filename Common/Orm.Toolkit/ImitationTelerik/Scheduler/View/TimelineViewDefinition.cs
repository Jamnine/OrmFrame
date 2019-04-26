using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents a definition of a view that shows customizable number of days as in day view mode.
    /// </summary>
    public class TimelineViewDefinition : MultidayViewDefinition
    {
        /// <summary>
        /// Identifies the <see cref="CustomTimeSlotLength"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="CustomTimeSlotLength"/> property.</returns>
        public static readonly DependencyProperty CustomTimeSlotLengthProperty =
            DependencyProperty.Register("CustomTimeSlotLength", typeof(DateTimeInterval), typeof(TimelineViewDefinition), new PropertyMetadata(DateTimeInterval.Zero, OnCustomTimeSlotLengthPropertyChanged));

        /// <summary>
        /// Identifies the <see cref="VisibleSlots"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="VisibleSlots"/> property.</returns>
        public static readonly DependencyProperty VisibleSlotsProperty =
            DependencyProperty.Register("VisibleSlots", typeof(int), typeof(TimelineViewDefinition), new PropertyMetadata(7, OnVisibleSlotsPropertyChanged));


        static TimelineViewDefinition()
        {
            VisibleDaysProperty.OverrideMetadata(typeof(TimelineViewDefinition), new PropertyMetadata(7));
            LargeChangeIntervalProperty.OverrideMetadata(
                typeof(TimelineViewDefinition), new PropertyMetadata(DateTimeInterval.FromDays(7)));
            SmallChangeIntervalProperty.OverrideMetadata(
                typeof(TimelineViewDefinition), new PropertyMetadata(DateTimeInterval.FromDays(1)));
            TimeSlotLengthProperty.OverrideMetadata(
                typeof(TimelineViewDefinition), new PropertyMetadata(TimeSpan.FromDays(1), OnTimeSlotLengthPropertyChanged));
        }

        /// <summary>
        /// Gets or sets the the custom time slot length.
        /// </summary>
        /// <value>The custom time slot length.</value>
        public DateTimeInterval CustomTimeSlotLength
        {
            get { return (DateTimeInterval)GetValue(CustomTimeSlotLengthProperty); }
            set { SetValue(CustomTimeSlotLengthProperty, value); }
        }

        /// <summary>
        /// Gets or sets the visible slots.
        /// </summary>
        /// <value>The visible slots.</value>
        public int VisibleSlots
        {
            get { return (int)GetValue(VisibleSlotsProperty); }
            set { SetValue(VisibleSlotsProperty, value); }
        }

        /// <summary>
        /// Gets or sets large change interval. It indicates date time interval with which current view will be
        /// increased or decreased. This is a dependency property.
        /// </summary>
        /// <value></value>
        /// <returns><see cref="DateTimeInterval"/> for large change. The default value is 7 days.</returns>
        public override DateTimeInterval LargeChangeInterval
        {
            get
            {
                return base.LargeChangeInterval;
            }
            set
            {
                base.LargeChangeInterval = value;
            }
        }

        /// <summary>
        /// Gets or sets visible days count for this view. It indicates how many dates this view will display.
        /// This is a dependency property.
        /// </summary>
        /// <returns>Visible days count for this view. The default value is 7.</returns>
        public override int VisibleDays
        {
            get
            {
                return base.VisibleDays;
            }
            set
            {
                base.VisibleDays = value;
			}
        }

        /// <summary>
        /// Gets or sets time slot length. This property indicates how long should be the time slots.
        /// This is a dependency property.
        /// </summary>
        /// <value></value>
        /// <returns>The length of the time slots. The default value is 30 minutes.</returns>
        public override TimeSpan TimeSlotLength
        {
            get
            {
                return base.TimeSlotLength;
            }
            set
            {
                base.TimeSlotLength = value;
            }
        }

        /// <summary>
        /// Generates the time slots from this definition.
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns>
        /// Time slots generated using this definition properties.
        /// </returns>
        public override IEnumerable<TimeSlot> GenerateTimeSlots(DateTime startDate)
        {
            if (this.CustomTimeSlotLength == DateTimeInterval.Zero)
            {
                TimeSpan ts = this.DayEndTime.Subtract(this.DayStartTime);
                var numberOfSlots = (int)Math.Ceiling(ts.TotalMinutes / this.TimeSlotLength.TotalMinutes);
				var hours = this.DayStartTime.Hours;
				if (this.TimeSlotLength.Hours != 0 && startDate.Hour != 0)
				{
					hours = this.DayStartTime.Hours + startDate.Hour;
				}
                var startTime = new DateTime(
                    startDate.Year,
                    startDate.Month,
                    startDate.Day,
                    hours,
                    this.DayStartTime.Minutes,
                    this.DayStartTime.Seconds);

                for (int j = 0; j < this.VisibleDays; j++)
                {
                    DateTime first = startTime.AddDays(j);
                    for (int i = 0; i < numberOfSlots; i++)
                    {
                        var timeSlot = new TimeSlot(first.AddTicks(i * this.TimeSlotLength.Ticks), this.TimeSlotLength);
                        yield return timeSlot;
                    }
                }
            }
            else
            {
                bool generateYears = this.CustomTimeSlotLength.Months != 0 && this.CustomTimeSlotLength.Months % 12 == 0;
                if (this.VisibleSlots <= 0) this.VisibleSlots = this.VisibleDays;
                if (this.CustomTimeSlotLength.Months > 0 && !generateYears)
                {
                    for (int j = 0; j < this.VisibleSlots; j++)
                    {
                        var timeSlot = new TimeSlot
                                        {
                                            Start = CalendarHelper.GetStartOfMonth(startDate.Year, startDate.Month),
                                            End = CalendarHelper.GetStartOfMonth(startDate.AddMonths(this.CustomTimeSlotLength.Months).Year,
                                                                                startDate.AddMonths(this.CustomTimeSlotLength.Months).Month)
                                        };

                        startDate = timeSlot.End;

                        yield return timeSlot;
                    }
                }
                else if (this.CustomTimeSlotLength.Weeks > 0)
                {
                    for (int j = 0; j < this.VisibleSlots; j++)
                    { 
                        var timeSlot = new TimeSlot();
                        timeSlot.Start = CalendarHelper.GetFirstDayOfWeek(startDate, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);
                        timeSlot.End = CalendarHelper.GetFirstDayOfWeek(timeSlot.Start.AddDays(7 * this.CustomTimeSlotLength.Weeks), CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);

                        startDate = timeSlot.End;

                        yield return timeSlot;
                    }
                }
                else if (this.CustomTimeSlotLength.Months == 12 && generateYears)
                {
                    for (int j = 0; j < this.VisibleSlots; j++)
                    {
                        var timeSlot = new TimeSlot();
                        timeSlot.Start = new DateTime(startDate.Year, 1, 1);
                        timeSlot.End = new DateTime(startDate.Year + (this.CustomTimeSlotLength.Months / 12), 1, 1);

                        startDate = timeSlot.End;

                        yield return timeSlot;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the group descriptions.
        /// </summary>
        /// <returns></returns>
        protected internal override IEnumerable<PropertyGroupDescription> GetGroupDescriptions()
        {
            // Use Start.Kind because we want all TimeSlots to be in 1 group (we assume that the DateTimeKind will always be the same)
            var description = new PropertyGroupDescription("Start.Kind");
            yield return description;
        }

		/// <summary>
		/// Called when [time slot length changed].
		/// </summary>
		protected override void OnTimeSlotLengthChanged()
		{
			this.OnViewDefinitionChanged(EventArgs.Empty);
		}

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "e")]
        private static void OnTimeSlotLengthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TimelineViewDefinition)d).OnTimeSlotLengthChanged();
        }

        private static void OnVisibleSlotsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TimelineViewDefinition)d).OnTimeSlotLengthChanged();
        }

        private static void OnCustomTimeSlotLengthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            (d as TimelineViewDefinition).OnViewDefinitionChanged(EventArgs.Empty);
        }
    }
}
