using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal static class OccurrenceExtensions
    {
        /// <summary>
        /// Determines whether this occurrence can be resized or moved. Recurring appointments 
        /// cannot be resized or moved. The same is true for recurrence rule exceptional appointments.
        /// </summary>
        /// <param name="occurrence">The occurrence.</param>
        /// <returns>
        /// 	<c>true</c> if this occurrence can be resized or moved; otherwise, <c>false</c>.
        /// </returns>
        internal static bool CanResizeOrMove(this Occurrence occurrence)
        {
            if (occurrence.State == RecurrenceState.Master)
            {
                return !occurrence.Master.IsRecurring();
            }

            return false;
        }
    }
}