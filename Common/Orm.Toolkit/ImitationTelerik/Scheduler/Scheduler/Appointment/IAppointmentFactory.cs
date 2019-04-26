namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Interface for a factory that can create appointments. To use in <see cref="RadScheduler"/> implement it in
    /// your custom appointment collection that you use as <see cref="RadScheduler.AppointmentsSource"/>.
    /// </summary>
    public interface IAppointmentFactory
    {
        /// <summary>
        /// Creates a new appointment. Implement this method in your custom appointment
        /// collection to create appointments of your custom appointment type.
        /// </summary>
        /// <returns>A new appointment.</returns>
        IAppointment CreateNewAppointment();
    }
}