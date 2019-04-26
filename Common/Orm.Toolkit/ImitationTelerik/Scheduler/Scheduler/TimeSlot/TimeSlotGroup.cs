using System;
using System.Collections.Generic;
using System.Globalization;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents a group of <see cref="TimeSlot"/>.
    /// </summary>
    public class TimeSlotGroup : TimeSlot
    {
        private readonly TimeSlotCollection timeSlots;
        private RadScheduler scheduler;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlotGroup"/> class
        /// adding the given time slots.
        /// </summary>
        /// <param name="timeSlots">The time slots that will be added to the group.</param>
        public TimeSlotGroup(IEnumerable<TimeSlot> timeSlots)
        {
            this.timeSlots = new TimeSlotCollection(timeSlots);
            if (this.timeSlots.Count > 0)
            {
                this.Start = this.timeSlots[0].Start;
                this.End = this.timeSlots[0].End;

                for (int i = 1; i < this.timeSlots.Count; i++)
                {
                    TimeSlot slot = this.timeSlots[i];

                    if (this.Start > slot.Start)
                    {
                        this.Start = slot.Start;
                    }

                    if (this.End < slot.End)
                    {
                        this.End = slot.End;
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlotGroup"/> class.
        /// </summary>
        /// <param name="startTime">The start time.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="timeSlots">The time slots.</param>
        public TimeSlotGroup(
            DateTime startTime,
            TimeSpan duration,
            TimeSlotCollection timeSlots)
            : base(startTime, duration)
        {
            this.timeSlots = timeSlots;
        }

        /// <summary>
        /// Gets the time slots.
        /// </summary>
        /// <value>The time slots.</value>
        public TimeSlotCollection TimeSlots
        {
            get
            {
                return this.timeSlots;
            }
        }

        /// <summary>
        /// Gets the period between start and end date of a week.
        /// </summary>
        /// <value>The DateTimePeriod.</value>
        public string DateTimePeriod
        {
            get
            {
                CultureInfo culture = CultureInfo.CurrentCulture;
                if (LocalizationManager.DefaultCulture != null)
                {
                    culture = LocalizationManager.DefaultCulture;
                }
                DateTime start = this.Start;
                DateTime end = this.End.AddMilliseconds(-1);
                string startString = start.ToString("d ", culture);

                if (start.Month != end.Month)
                {
                    startString += start.GetShortMonthName(culture) + " ";
                }

                string endString = end.ToString("d ", culture) + end.GetShortMonthName(culture);
                return string.Concat(startString, "- ", endString);
            }
        }

        /// <summary>
        /// Gets the Scheduler.
        /// </summary>
        /// <value>The Scheduler.</value>
        public RadScheduler Scheduler
        {
            get
            {
                return (RadScheduler)this.scheduler;
            }
            set
            {
                this.scheduler = value;
            }
        }
    }
}