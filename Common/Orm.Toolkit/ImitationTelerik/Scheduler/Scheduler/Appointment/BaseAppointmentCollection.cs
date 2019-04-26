using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Base class for a typical collection of appointments.
    /// </summary>
    /// <typeparam name="T"> The type of the custom appointment class. Should implement
    /// <see cref="IAppointment"/>. </typeparam>
    public abstract class BaseAppointmentCollection<T> : ObservableCollection<T>, IAppointmentFactory
        where T : IAppointment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAppointmentCollection{T}"/> class.
        /// </summary>
        protected BaseAppointmentCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAppointmentCollection{T}"/> class.
        /// </summary>
        /// <param name="appointments">The appointments.</param>
        protected BaseAppointmentCollection(IEnumerable<T> appointments) : base(appointments.ToList())
        {
        }


        /// <summary>
        /// Creates a new appointment. Implement this method in your custom appointment
        /// collection to create appointments of your custom appointment type. 
        /// </summary>
        /// <returns>A new appointment.</returns>
        public abstract IAppointment CreateNewAppointment();
    }
}