using System;
using System.Diagnostics;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Provides class for appointment occurrence.
    /// </summary>
    [DebuggerDisplay("Occurrence ( {Start}-{End} )")]
    public class Occurrence : IDateSpan, IEquatable<Occurrence>
    {
        private DateTime end;
        private IAppointment exception;
        private IAppointment master;
        private RecurrenceState recurrenceState;

        private DateTime start;

        private Occurrence()
        {
        }

        /// <summary>
        /// Gets the appointment for this occurrence.
        /// </summary>
        /// <value>The appointment for this occurrence.</value>
        public IAppointment Appointment
        {
            get
            {
                if (this.State == RecurrenceState.Exception)
                {
                    return this.exception;
                }
                
                return this.master;
            }
        }

        /// <summary>
        /// Gets the end <see cref="DateTime"/> of the <see cref="IDateSpan"/>.
        /// </summary>
        /// <value>The end <see cref="DateTime"/>.</value>
        public DateTime End
        {
            get
            {
                return this.end;
            }
        }

        /// <summary>
        /// Gets the exception appointment for this occurrence. If this occurrence is not
        /// is not an exception, this property is <a>null</a>; otherwise this property is
        /// the same as the <see cref="Appointment"/> property.
        /// </summary>
        /// <value>The exception appointment.</value>
        public IAppointment Exception
        {
            get
            {
                return this.exception;
            }
        }

        /// <summary>
        /// Gets the master appointment for this occurrence. If this occurrence is an
        /// exception, this property is the master appointment for the exception; otherwise
        /// this property is the same as the <see cref="Appointment"/> property.
        /// </summary>
        /// <value>The master appointment.</value>
        public IAppointment Master
        {
            get
            {
                return this.master;
            }
        }

        /// <summary>
        /// Gets the start <see cref="DateTime"/> of the <see cref="IDateSpan"/>.
        /// </summary>
        /// <value>The start <see cref="DateTime"/>.</value>
        public DateTime Start
        {
            get
            {
                return this.start;
            }
        }

        /// <summary>
        /// Gets the recurrence state.
        /// </summary>
        /// <value>The state.</value>
        public RecurrenceState State
        {
            get
            {
                return this.recurrenceState;
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Occurrence"/> class with <see cref="RecurrenceState.Exception"/> state.
        /// </summary>
        /// <param name="master">The master.</param>
        /// <param name="exception">The exception.</param>
        /// <returns>New occurrence with with <see cref="RecurrenceState.Exception"/> state.</returns>
        public static Occurrence CreateException(IAppointment master, IAppointment exception)
        {
            return new Occurrence
                       {
                           master = master,
                           exception = exception,
                           start = exception.Start,
                           end = exception.End,
                           recurrenceState = RecurrenceState.Exception
                       };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Occurrence"/> class with <see cref="RecurrenceState.Master"/> state.
        /// </summary>
        /// <param name="master">The master.</param>
        /// <returns></returns>
        public static Occurrence CreateMaster(IAppointment master)
        {
            return new Occurrence
                       {
                           master = master,
                           start = master.Start,
                           end = master.End,
                           recurrenceState = RecurrenceState.Master
                       };
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Occurrence"/> class with <see cref="RecurrenceState.Occurrence"/> state.
        /// </summary>
        /// <param name="master">The master.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns>New occurrence with with <see cref="RecurrenceState.Occurrence"/> state.</returns>
        public static Occurrence CreateOccurrence(IAppointment master, DateTime start, DateTime end)
        {
            return new Occurrence
                       {
                           master = master,
                           start = start,
                           end = end,
                           recurrenceState = RecurrenceState.Occurrence
                       };
        }

        /// <summary>
        /// Determines whether the specified <see cref="Occurrence" /> is equal to the
        /// current <see cref="Occurrence" />.
        /// </summary>
        /// <returns>
        /// True if the specified <see cref="Occurrence" /> is equal to the current 
        /// <see cref="Occurrence" />; otherwise, false.
        /// </returns>
        /// <param name="obj">
        /// The <see cref="Occurrence" /> to compare with the current 
        /// <see cref="Occurrence" />. 
        /// </param>
        /// <exception cref="System.NullReferenceException">
        /// The <paramref name="obj" /> parameter is null.
        /// </exception><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Occurrence)) return false;
            return this.Equals((Occurrence)obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="Occurrence" />.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = this.recurrenceState.GetHashCode();
                result = (result * 397) ^ (this.master != null ? this.master.GetHashCode() : 0);
                result = (result * 397) ^ (this.exception != null ? this.exception.GetHashCode() : 0);
                result = (result * 397) ^ this.end.GetHashCode();
                result = (result * 397) ^ this.start.GetHashCode();
                return result;
            }
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same
        /// type.
        /// </summary>
        /// <param name="other">The obj.</param>
        /// <returns>
        /// True if the current object is equal to the <paramref name="other"/> parameter;
        /// otherwise, false.
        /// </returns>
        public bool Equals(Occurrence other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return
                (other.recurrenceState == this.recurrenceState) &&
                (other.master == this.master) &&
                (other.exception == this.exception) &&
                other.end.Equals(this.end) && other.start.Equals(this.start);
        }
    }
}