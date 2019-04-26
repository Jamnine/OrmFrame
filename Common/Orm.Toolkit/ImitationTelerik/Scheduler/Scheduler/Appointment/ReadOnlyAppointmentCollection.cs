using System.Collections.ObjectModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Read only observable collection of appointments.
    /// </summary>
    public class ReadOnlyAppointmentCollection : ReadOnlyObservableCollection<IAppointment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyAppointmentCollection"/> class.
        /// </summary>
        /// <param name="list">The <see cref="ObservableCollection{T}"/> with which to create this instance of the <see cref="ReadOnlyObservableCollection{T}"/> class.</param>
        public ReadOnlyAppointmentCollection(ObservableCollection<IAppointment> list) : base(list)
        {
        }
    }
}