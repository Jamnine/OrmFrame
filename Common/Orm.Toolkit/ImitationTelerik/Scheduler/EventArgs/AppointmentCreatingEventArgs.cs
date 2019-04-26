using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Contains state information about the new appointment that is going to be created.
    /// </summary>
    public class AppointmentCreatingEventArgs : CancelRoutedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentCreatingEventArgs"/> class.
        /// </summary>
        public AppointmentCreatingEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentCreatingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event.</param>
        public AppointmentCreatingEventArgs(RoutedEvent routedEvent)
            : base(routedEvent)
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentCreatingEventArgs"/> class.
        /// </summary>
        /// <param name="routedEvent">The routed event identifier for this instance of
        /// the <see cref="RoutedEventArgs"/> class.</param>
        /// <param name="source">An alternate source that will be reported when the event is handled.
        /// This p repopulates the <see cref="RoutedEventArgs.Source"/> property.
        /// </param>


        public AppointmentCreatingEventArgs(RoutedEvent routedEvent, object source)
            : base(routedEvent, source)
        {
        }

        /// <summary>
        /// Gets or sets the newly created appointment. You can use this property to set your own
        /// appointment, otherwise <c>RadScheduler</c> infrastructure will be used for appointment
        /// creation.
        /// </summary>
        /// <value>The new appointment was created.</value>
        public IAppointment NewAppointment { get; set; }
    }
}