using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Contains state information about the appointment that has been added.
    /// </summary>
    public class AppointmentAddedEventArgs : RadRoutedEventArgs
    {
        private readonly IAppointment appointment;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentAddedEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="appointment">The appointment that has been added.</param>
        public AppointmentAddedEventArgs(RoutedEvent routedEvent, IAppointment appointment) : base(routedEvent)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentAddedEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="source">The source.</param>
        /// <param name="appointment">The appointment that has been added.</param>
        public AppointmentAddedEventArgs(RoutedEvent routedEvent, object source, IAppointment appointment)
            : base(routedEvent, source)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Gets the appointment that has been added.
        /// </summary>
        /// <value>The appointment that has been added.</value>
        public IAppointment Appointment
        {
            get
            {
                return this.appointment;
            }
        }
    }
}