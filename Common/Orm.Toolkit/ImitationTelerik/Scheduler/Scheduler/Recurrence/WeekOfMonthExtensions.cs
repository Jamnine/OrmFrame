namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// <see cref="WeekOfMonth"/> extensions methods.
    /// </summary>
    public static class WeekOfMonthExtensions
    {
        /// <summary>
        /// Convert a value to <see cref="int" />.
        /// </summary>
        /// <param name="weekOfMonth">The week of month.</param>
        /// <returns>Converted to int value.</returns>
        public static int ToInt32(this WeekOfMonth weekOfMonth)
        {
            if (weekOfMonth == WeekOfMonth.Last)
                return -1;

            return (int)weekOfMonth;
        }
    }
}