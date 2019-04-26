namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents time slot that have an appointment.
    /// </summary>
    public class AppointmentSlot
    {
        private readonly Occurrence occurrence;
        private readonly TimeSlot timeSlot;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentSlot"/> class.
        /// </summary>
        /// <param name="occurrence">The occurrence.</param>
        /// <param name="timeSlot">The time slot.</param>
        public AppointmentSlot(Occurrence occurrence, TimeSlot timeSlot)
        {
            this.occurrence = occurrence;
            this.timeSlot = timeSlot;
        }

        /// <summary>
        /// Gets the occurrence for this slot.
        /// </summary>
        /// <value>The occurrence.</value>
        public Occurrence Occurrence
        {
            get
            {
                return this.occurrence;
            }
        }

        /// <summary>
        /// Gets the time slot.
        /// </summary>
        /// <value>The time slot.</value>
        public TimeSlot TimeSlot
        {
            get
            {
                return this.timeSlot;
            }
        }
    }
}