using System;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents date time duration in days and/or months.
    /// </summary>
    [TypeConverter(typeof(DateTimeIntervalConverter))]
    public partial struct DateTimeInterval : IEquatable<DateTimeInterval>
    {
        /// <summary>
        ///  <see cref="DateTimeInterval"/> of zero duration.
        /// </summary>
        public static readonly DateTimeInterval Zero = new DateTimeInterval(0, 0, 0, 0);

		private readonly int hours; 
		private readonly int days;
        private readonly int months;
        private readonly int weeks;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeInterval"/> struct.
        /// </summary>
        /// <param name="days">The days.</param>
        /// <param name="months">The months.</param>
        public DateTimeInterval(int days, int months)
        {
            this.days = days;
            this.months = months;
			this.hours = 0;
            this.weeks = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeInterval"/> struct.
        /// </summary>
        /// <param name="days">The days.</param>
        /// <param name="months">The months.</param>
        /// <param name="weeks">The weeks.</param>
        public DateTimeInterval(int days, int months, int weeks)
        {
			this.hours = 0; 
			this.days = days;
            this.months = months;
            this.weeks = weeks;
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="DateTimeInterval"/> struct.
		/// </summary>
		/// <param name="hours">The hours.</param>
		/// <param name="days">The days.</param>
		/// <param name="months">The months.</param>
		/// <param name="weeks">The weeks.</param>
		public DateTimeInterval(int hours, int days, int months, int weeks)
		{
			this.hours = hours; 
			this.days = days;
			this.months = months;
			this.weeks = weeks;
		}

		/// <summary>
		/// Gets the hours.
		/// </summary>
		/// <value>The hours.</value>
		public int Hours
		{
			get
			{
				return this.hours;
			}
		}

        /// <summary>
        /// Gets the days.
        /// </summary>
        /// <value>The days.</value>
        public int Days
        {
            get
            {
                return this.days;
            }
        }

        /// <summary>
        /// Gets the months.
        /// </summary>
        /// <value>The months.</value>
        public int Months
        {
            get
            {
                return this.months;
            }
        }

        /// <summary>
        /// Gets the weeks.
        /// </summary>
        /// <value>The weeks.</value>
        internal int Weeks
        {
            get
            {
                return this.weeks;
            }
        }

        /// <summary>
        /// Creates a new <see cref="DateTimeInterval"/> initializing it with given <paramref name="days"/>.
        /// </summary>
        /// <param name="days">The days, which will be used to initialize the <see cref="DateTimeInterval"/>.</param>
        /// <returns>A new <see cref="DateTimeInterval"/>.</returns>
        public static DateTimeInterval FromDays(int days)
        {
            return new DateTimeInterval(days, 0);
        }

        /// <summary>
        /// Creates a new <see cref="DateTimeInterval"/> initializing it with given <paramref name="months"/>.
        /// </summary>
        /// <param name="months">The months, which will be used to initialize the <see cref="DateTimeInterval"/>.</param>
        /// <returns>A new <see cref="DateTimeInterval"/>.</returns>
        public static DateTimeInterval FromMonths(int months)
        {
            return new DateTimeInterval(0, months);
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="other">The other.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DateTimeInterval self, DateTimeInterval other)
        {
            return self.Equals(other);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="other">The other.</param>
        /// <returns>True if <paramref name="self"/> did not equals <paramref name="other"/>.</returns>
        public static bool operator !=(DateTimeInterval self, DateTimeInterval other)
        {
            return !self.Equals(other);
        }

        /// <summary>
        /// Constructs a new <see cref="DateTimeInterval"/> object from a string. The string should be in 
        /// format like this: <c>12d 12m</c>. 
        /// </summary>
        /// <param name="value">A string that specifies the interval.</param>
        /// <returns>A <see cref="DateTimeInterval"/> that corresponds to <paramref name="value"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> contains negative value.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="value"/> is not in the correct format. The string should be in format like 
        /// this: "<c>{i}d {i}m</c>" where {i} represents an <see cref="int"/> number.
        /// </exception>
        /// <exception cref="OverflowException">
        /// Given values for <see cref="Days"/> or <see cref="Months"/> in <paramref name="value"/> are less 
        /// than 0 and <see cref="int.MaxValue"/>.
        /// </exception>
        public static DateTimeInterval Parse(string value)
        {
            var parser = new Parser();
            return parser.Parse(value);
        }

        /// <summary>
        /// Constructs a new <see cref="DateTimeInterval"/> object from a string. The string should be in 
        /// format like this: <c>12d 12m</c>. 
        /// </summary>
        /// <param name="value">A string that specifies the interval.</param>
        /// <param name="interval">
        /// The <see cref="DateTimeInterval"/> that will be created if the parsing is successful. If it failed
        /// the value will be <see cref="Zero"/>. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>
        /// True if <paramref name="value"/> was converted successfully; otherwise false. This operator 
        /// returns false if <paramref name="value"/> is null, has an invalid format, or the given values for
        /// <see cref="Days"/> or <see cref="Months"/> are less than 0 and <see cref="int.MaxValue"/>.
        /// </returns>
        public static bool TryParse(string value, out DateTimeInterval interval)
        {
            var parser = new Parser();
            if (parser.TryParse(value, out interval))
            {
                return true;
            }

            interval = Zero;
            return false;
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">Another object to compare to.</param>
        /// <returns>
        /// True if <paramref name="obj"/> and this instance are the same type and represent the same value; otherwise, false.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is DateTimeInterval)) return false;

            return this.Equals((DateTimeInterval)obj);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that is the hash code for this instance.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return this.days.GetHashCode() ^ this.months.GetHashCode();
        }

        /// <summary>
        /// Indicates whether this instance and a specified <see cref="DateTimeInterval"/> are equal.
        /// </summary>
        /// <param name="other">Another <see cref="DateTimeInterval"/> to compare to.</param>
        /// <returns>
        /// True if <paramref name="other"/> and this instance are the same type and represent the same value; otherwise, false.
        /// </returns>
        public bool Equals(DateTimeInterval other)
        {
            return other.days == this.days && other.months == this.months && other.weeks == this.weeks;
        }

        /// <summary>
        /// Gets the approximate total days count for the specified <paramref name="calendar"/>.
        /// Uses <see cref="DateTime.Today"/>'s year for the calculate.
        /// </summary>
        /// <param name="calendar">The calendar object.</param>
        /// <returns>
        /// Total days that this <see cref="DateTimeInterval"/> represents for the given <paramref name="calendar"/>.
        /// </returns>
        public int GetApproximateTotalDays(System.Globalization.Calendar calendar)
        {
            int approximate = this.days;
            if (this.months > 0)
            {
                int monthsInYear = calendar.GetMonthsInYear(DateTime.Today.Year);
                int daysInYear = calendar.GetDaysInYear(DateTime.Today.Year);
                approximate += daysInYear / monthsInYear;
            }

            return approximate;
        }
    }
}
