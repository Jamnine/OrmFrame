using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Contains state information about the appointment that has been deleted.
    /// </summary>
    public class AppointmentDeletedEventArgs : RadRoutedEventArgs
    {
        private readonly IAppointment appointment;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentDeletedEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="appointment">The appointment that has been deleted.</param>
        public AppointmentDeletedEventArgs(RoutedEvent routedEvent, IAppointment appointment) : base(routedEvent)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentDeletedEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="source">The source.</param>
        /// <param name="appointment">The appointment that has been deleted.</param>
        public AppointmentDeletedEventArgs(RoutedEvent routedEvent, object source, IAppointment appointment)
            : base(routedEvent, source)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Gets the appointment that has been deleted.
        /// </summary>
        /// <value>The appointment that has been deleted.</value>
        public IAppointment Appointment
        {
            get
            {
                return this.appointment;
            }
        }
    }
}