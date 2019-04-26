namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    internal class AppointmentFactory : IAppointmentFactory
    {
        public IAppointment CreateNewAppointment()
        {
            return new Appointment();
        }
    }
}