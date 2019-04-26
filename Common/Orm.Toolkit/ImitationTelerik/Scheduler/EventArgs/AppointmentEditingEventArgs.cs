using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Contains state information about the appointment that is going to be edited.
    /// </summary>
    public class AppointmentEditingEventArgs : CancelRoutedEventArgs
    {
        private readonly IAppointment appointment;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentEditingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="appointment">The appointment.</param>
        public AppointmentEditingEventArgs(RoutedEvent routedEvent, IAppointment appointment) : base(routedEvent)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentEditingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="source">The source.</param>
        /// <param name="appointment">The appointment.</param>
        public AppointmentEditingEventArgs(RoutedEvent routedEvent, object source, IAppointment appointment)
            : base(routedEvent, source)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Gets the appointment that is going to be edited.
        /// </summary>
        /// <value>The appointment that will be edited.</value>
        public IAppointment Appointment
        {
            get
            {
                return this.appointment;
            }
        }

        /// <summary>
        /// Gets or sets the exception <see cref="Occurrence"/>. 
        /// </summary>
        /// <value>The exception occurence.</value>
        public Occurrence ExceptionOccurrence
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets or sets the <see cref="ExceptionAction"/>. Specifies what action is done to the Exception, if present.
        /// </summary>
        /// <value>The exception action.</value>
        public ExceptionAction ExceptionAction
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets or sets the <see cref="ExceptionAction"/>. Specifies what action is done to the Exception, if present.
        /// </summary>
        /// <value>The exception action.</value>
        public AppointmentEditAction AppointmentEditAction
        {
            get;
            internal set;
        }
    }
}