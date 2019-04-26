using System.Collections.Generic;
using System.Linq;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// A default appointment collection that can be used if no custom appointments are
    /// needed. This collection implements <see cref="IAppointmentFactory"/> and
    /// creates appointments of the default <see cref="Appointment"/> type. 
    /// </summary>
    public class DefaultAppointmentCollection : BaseAppointmentCollection<IAppointment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAppointmentCollection"/> class.
        /// </summary>
        public DefaultAppointmentCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAppointmentCollection"/> class.
        /// </summary>
        /// <param name="appointments">The appointments.</param>
        public DefaultAppointmentCollection(IEnumerable<IAppointment> appointments) : base(appointments.ToList())
        {
        }

        /// <summary>
        /// Creates a new appointment.
        /// </summary>
        /// <returns>A new appointment.</returns>
        public override IAppointment CreateNewAppointment()
        {
            return new Appointment();
        }
    }
}