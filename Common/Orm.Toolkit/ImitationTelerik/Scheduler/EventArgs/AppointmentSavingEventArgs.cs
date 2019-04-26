using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Contains state information about the appointment that is going to be saved.
    /// </summary>
    public class AppointmentSavingEventArgs : CancelRoutedEventArgs
    {
        private readonly IAppointment appointment;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentSavingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="appointment">The appointment.</param>
        public AppointmentSavingEventArgs(RoutedEvent routedEvent, IAppointment appointment)
            : base(routedEvent)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentSavingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="source">The source.</param>
        /// <param name="appointment">The appointment.</param>
        public AppointmentSavingEventArgs(RoutedEvent routedEvent, object source, IAppointment appointment)
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
    }
}