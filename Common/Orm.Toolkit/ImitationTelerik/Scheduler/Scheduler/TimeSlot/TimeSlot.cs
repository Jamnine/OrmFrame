using System;
using System.ComponentModel;
using System.Globalization;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents a time slot.
    /// </summary>
    public class TimeSlot : IDateSpan, IEquatable<TimeSlot>, INotifyPropertyChanged
    {
        internal const string StartTimeDayDescription = "Start.Day";
        internal const string StartTimeDescription = "Start";
        internal const string StartTimeHourDescription = "Start.Hour";

        private DateTime endTime;
        private DateTime startTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot"/> class.
        /// </summary>
        public TimeSlot()
        {
            this.Start = DateTime.MinValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot"/> class.
        /// </summary>
        /// <param name="startTime">The start time.</param>
        /// <param name="duration">The duration.</param>
        public TimeSlot(DateTime startTime, TimeSpan duration) : this()
        {
            this.Start = startTime;
            this.End = startTime + duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot"/> class.
        /// </summary>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        public TimeSlot(DateTime startTime, DateTime endTime)
            : this()
        {
            this.Start = startTime;
            this.End = endTime;
        }

		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// End time value is before <see cref="Start"/>
        /// </exception>
        /// <value>The end time.</value>
        public DateTime End
        {
            get
            {
                return this.endTime;
            }
            set
            {
                if (value < this.startTime)
                {
                    //throw new ArgumentOutOfRangeException("value");
                }

                this.endTime = value;
            }
        }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>The start time.</value>
        public DateTime Start
        {
            get
            {
                return this.startTime;
            }
            set
            {
                this.startTime = value;

				this.OnPropertyChanged("Start");
            }
        }

        /// <summary>
        /// Gets the formatted start date.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)")]
        public string FormattedStart
        {
            get
            {
				return String.Format(this.ParentView.Scheduler.GetCultureInUse(), this.ParentView.Scheduler.DayHeaderFormat, this.startTime);
            }
        }

          /// <summary>
        /// Gets the formatted start date.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)")]
        public string MonthFormattedStart
        {
            get
            {
				  return String.Format(this.ParentView.Scheduler.GetCultureInUse(), this.ParentView.Scheduler.MonthHeaderFormat, this.startTime);
            }
        }

        /// <summary>
        /// Gets the time slot start day.
        /// </summary>
        /// <value>The time slot start day.</value>
        public int TimeSlotStartDay
        {
            get
            {
                return this.startTime.Day;
            }
        }

        /// <summary>
        /// Gets the formatted start date.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)")]
        public string FormattedMonthName
        {
            get;
            set;
        }

        public string TimeIndicatorMin
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>The start time.</value>
		public string FormattedDayStart
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>The start time.</value>
        public string FormattedTimelineStart
        {
            get
            {
                return String.Format(this.ParentView.Scheduler.GetCultureInUse(), this.ParentView.Scheduler.TimelineHeaderFormat, this.startTime);
            }
        }

        /// <summary>
        /// Gets or sets the ParentView.
        /// </summary>
        /// <value>The ParentView.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public TimeSlotCollectionView ParentView
        {
            get;
            set;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="TimeSlot"/>.
        /// </summary>
        /// <returns>
        /// True if the specified object is equal to the current <see cref="TimeSlot"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="TimeSlot"/>. </param>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			var timeSlot = obj as TimeSlot;
			if (timeSlot == null) return false;
			return this.Equals(timeSlot);
		}

		/// <summary>
		/// Serves as a hash function for a particular type. 
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="TimeSlot"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked
			{
				int result = this.startTime.GetHashCode();
				result = (result * 397) ^ this.endTime.GetHashCode();
				return result;
			}
		}

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current <see cref="object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents the current <see cref="object"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "Start: {0}, End: {1}", this.startTime, this.endTime);
        }

        /// <summary>
        /// Indicates whether the specified <see cref="TimeSlot"/> is equal to another <see cref="TimeSlot"/>.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// True if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        public bool Equals(TimeSlot other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.startTime.Equals(this.startTime) && other.endTime.Equals(this.endTime);
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
    }
}