namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Specifies different modes for appointment occurrences dialog window.
    /// </summary>
    public enum RecurrenceMode
    {
        /// <summary>
        /// None. 
        /// </summary>
        None = 0,

        /// <summary>
        /// Manipulate only the selected occurrence.
        /// </summary>
        Occurrence = 1,

        /// <summary>
        /// Manipulate the whole occurrence series (appointment's recurrence rule).
        /// </summary>
        Series = 2
    }
}