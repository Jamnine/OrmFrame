using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents definition of a view that shows 42 days in month view mode.
    /// </summary>
    public class MonthViewDefinition : ViewDefinitionBase
    {
        static MonthViewDefinition()
        {
            VisibleDaysProperty.OverrideMetadata(typeof(MonthViewDefinition), new PropertyMetadata(42));
            TimeSlotLengthProperty.OverrideMetadata(
                typeof(MonthViewDefinition), new PropertyMetadata(TimeSpan.FromDays(1)));
            SmallChangeIntervalProperty.OverrideMetadata(
                typeof(MonthViewDefinition), new PropertyMetadata(DateTimeInterval.FromDays(7)));
            LargeChangeIntervalProperty.OverrideMetadata(
                typeof(MonthViewDefinition), new PropertyMetadata(DateTimeInterval.FromMonths(1)));
        }

        // ReSharper disable RedundantOverridenMember
        // Added for changing the comment for default values

        /// <summary>
        /// Gets or sets large change interval. It indicates date time interval with which current view will be
        /// increased or decreased. This is a dependency property.
        /// </summary>
        /// <returns><see cref="DateTimeInterval"/> for large change. The default value is 1 month.</returns>
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
        /// Gets or sets small change interval. It indicates date time interval with which current view will be
        /// increased or decreased. This is a dependency property.
        /// </summary>
        /// <returns><see cref="DateTimeInterval"/> for small change. The default value is 7 days.</returns>
        public override DateTimeInterval SmallChangeInterval
        {
            get
            {
                return base.SmallChangeInterval;
            }
            set
            {
                base.SmallChangeInterval = value;
            }
        }

        /// <summary>
        /// Gets or sets time slot length. This property indicates how long should be the time slots.
        /// This is a dependency property.
        /// </summary>
        /// <returns>The length of the time slots. The default value is 1 day.</returns>
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
        /// Gets or sets visible days count for this view. It indicates how many dates this view will display.
        /// This is a dependency property.
        /// </summary>
        /// <value></value>
        /// <returns>Visible days count for this view. The default value is 42.</returns>
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
        /// Gets the group descriptions.
        /// </summary>
        /// <returns></returns>
        protected internal override IEnumerable<PropertyGroupDescription> GetGroupDescriptions()
        {
            var description = new PropertyGroupDescription(TimeSlot.StartTimeDescription);
            description.Converter = new DateToWeekConverter();
            description.StringComparison = StringComparison.Ordinal;

            yield return description;
        }

		/// <summary>
		/// Called when [time slot length changed].
		/// </summary>
		protected override void OnTimeSlotLengthChanged()
		{
			if (this.TimeSlotLength < TimeSpan.FromDays(1))
			{
				this.TimeSlotLength = TimeSpan.FromDays(1);
			}
			base.OnTimeSlotLengthChanged();
		}
    }
}