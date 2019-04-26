using System;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Provides class for recurrence rule exceptions.
    /// </summary>
    public class ExceptionOccurrence
    {
        /// <summary>
        /// Gets or sets the exception appointment.
        /// </summary>
        /// <value>The appointment.</value>
        public IAppointment Appointment { get; set; }

        /// <summary>
        /// Gets or sets the exception date.
        /// </summary>
        /// <value>The exception date.</value>
        public DateTime ExceptionDate { get; set; }

        /// <summary>
        /// 	<b>Deep</b> copies this instance.
        /// </summary>
        /// <returns>
        /// A <b>deep</b> copy of the current object.
        /// </returns>
        public ExceptionOccurrence Copy()
        {
            var exception = new ExceptionOccurrence();
            exception.CopyFrom(this);
            return exception;
        }

        /// <summary>
        /// Copies from.
        /// </summary>
        /// <param name="other">The other.</param>
        public void CopyFrom(ExceptionOccurrence other)
        {
            if (this.GetType().FullName != other.GetType().FullName)
                throw new ArgumentException("Invalid type");

            this.ExceptionDate = other.ExceptionDate;
            if (other.Appointment != null)
                this.Appointment = other.Appointment.Copy();
        }
    }
}