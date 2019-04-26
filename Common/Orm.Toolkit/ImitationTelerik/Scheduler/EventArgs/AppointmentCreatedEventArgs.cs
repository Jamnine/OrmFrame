using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Contains state information about the appointment that has already been created.
    /// </summary>
    public class AppointmentCreatedEventArgs : RadRoutedEventArgs
    {
        private readonly IAppointment createdAppointment;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentCreatedEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="createdAppointment">The created appointment.</param>
        public AppointmentCreatedEventArgs(RoutedEvent routedEvent, IAppointment createdAppointment)
            : base(routedEvent)
        {
            this.createdAppointment = createdAppointment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentCreatedEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        /// <param name="source">The source.</param>
        /// <param name="createdAppointment">The created appointment.</param>
        public AppointmentCreatedEventArgs(RoutedEvent routedEvent, object source, IAppointment createdAppointment)
            : base(routedEvent, source)
        {
            this.createdAppointment = createdAppointment;
        }

        /// <summary>
        /// Gets the created appointment.
        /// </summary>
        /// <value>The appointment that has been created.</value>
        public IAppointment CreatedAppointment
        {
            get
            {
                return this.createdAppointment;
            }
        }
    }
}