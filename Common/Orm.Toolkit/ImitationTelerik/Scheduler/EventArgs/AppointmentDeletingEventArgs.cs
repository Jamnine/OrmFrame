using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Contains state information about the appointment that is going to be deleted.
    /// </summary>
    public class AppointmentDeletingEventArgs : CancelRoutedEventArgs
    {
        private readonly IAppointment appointment;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentDeletingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="appointment">The appointment that will be deleted.</param>
        public AppointmentDeletingEventArgs(RoutedEvent routedEvent, IAppointment appointment) : base(routedEvent)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentDeletingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="source">The source.</param>
        /// <param name="appointment">The appointment that will be deleted.</param>
        public AppointmentDeletingEventArgs(RoutedEvent routedEvent, object source, IAppointment appointment)
            : base(routedEvent, source)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Gets the appointment that is going to be deleted.
        /// </summary>
        /// <value>The appointment that will be deleted.</value>
        public IAppointment Appointment
        {
            get
            {
                return this.appointment;
            }
        }
    }
}