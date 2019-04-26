namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Specifies the state of (recurring) appointment.
    /// </summary>
    public enum RecurrenceState
    {
        /// <summary>
        /// Represents the main appointment, which holds the recurrence rule.
        /// </summary>
        Master = 0,

        /// <summary>
        /// Represents a single occurence of a recurring appointment.
        /// </summary>
        Occurrence = 1,

        /// <summary>
        /// Represents exceptional appointment - exception from the recurrence rule.
        /// </summary>
        Exception = 2
    }
}