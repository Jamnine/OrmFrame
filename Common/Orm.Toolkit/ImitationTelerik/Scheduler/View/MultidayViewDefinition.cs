using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents definition of a view that shows multiple days as in day view mode.
    /// </summary>
    public abstract class MultidayViewDefinition : ViewDefinitionBase
    {
        /// <summary>
        /// Identifies the <see cref="DayEndTime"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="DayEndTime"/> property.</returns>
        public static readonly DependencyProperty DayEndTimeProperty =
            DependencyProperty.Register(
                "DayEndTime",
                typeof(TimeSpan),
                typeof(MultidayViewDefinition),
                new PropertyMetadata(TimeSpan.FromHours(24), OnDayStartEndTimePropertyChanged));

        /// <summary>
        /// Identifies the <see cref="DayStartTime"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="DayStartTime"/> property.</returns>
        public static readonly DependencyProperty DayStartTimeProperty =
            DependencyProperty.Register(
                "DayStartTime",
                typeof(TimeSpan),
                typeof(MultidayViewDefinition),
                new PropertyMetadata(TimeSpan.Zero, OnDayStartEndTimePropertyChanged));

        static MultidayViewDefinition()
        {
            TimeSlotLengthProperty.OverrideMetadata(
                typeof(MultidayViewDefinition), new PropertyMetadata(TimeSpan.FromMinutes(30)));
        }

        /// <summary>
        /// Gets or sets the time used to indicate the end of the day. This is a dependency property.
        /// </summary>
        /// <returns>The time that indicates the end of the day. The default value is 24 hours.</returns>  
        public virtual TimeSpan DayEndTime
        {
            get
            {
                return (TimeSpan)this.GetValue(DayEndTimeProperty);
            }
            set
            {
                this.SetValue(DayEndTimeProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the time used to indicate the start of the day. This is a dependency property.
        /// </summary>
        /// <returns>The time that indicates the start of the day. The default value is <see cref="TimeSpan.Zero"/>.</returns>  
        public virtual TimeSpan DayStartTime
        {
            get
            {
                return (TimeSpan)this.GetValue(DayStartTimeProperty);
            }
            set
            {
                this.SetValue(DayStartTimeProperty, value);
            }
        }

        // ReSharper disable RedundantOverridenMember

        /// <summary>
        /// Gets or sets time slot length. This property indicates how long should be the time slots.
        /// This is a dependency property.
        /// </summary>
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

        // ReSharper restore RedundantOverridenMember

        /// <summary>
        /// Generates the time slots from this definition.
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns>
        /// Time slots generated using this definition properties.
        /// </returns>
        public override IEnumerable<TimeSlot> GenerateTimeSlots(DateTime startDate)
        {
            TimeSpan ts = this.DayEndTime.Subtract(this.DayStartTime);
            var numberOfSlots = (int)Math.Ceiling(ts.TotalMinutes / this.TimeSlotLength.TotalMinutes);

            var startTime = new DateTime(
                startDate.Year,
                startDate.Month,
                startDate.Day,
                this.DayStartTime.Hours,
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

        /// <summary>
        /// Gets the group descriptions.
        /// </summary>
        /// <returns></returns>
        protected internal override IEnumerable<PropertyGroupDescription> GetGroupDescriptions()
        {
            var desriptions = new[]
            {
                new PropertyGroupDescription(TimeSlot.StartTimeDayDescription),
                new PropertyGroupDescription(TimeSlot.StartTimeHourDescription)
            };
            return desriptions;
        }

        private static void OnDayStartEndTimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            (d as MultidayViewDefinition).OnViewDefinitionChanged(EventArgs.Empty);
        }
    }
}