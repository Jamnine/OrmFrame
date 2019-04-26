namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Specifies the view mode of a <see cref="RadScheduler"/> control.
    /// </summary>
    public enum SchedulerViewMode
    {
        /// <summary>
        /// A view that spans a single day. All day-events are displayed in a separate row on top.
        /// </summary>
        Day,

        /// <summary>
        /// A view that spans seven days. Each day is displayed as in <see cref="Day"/> mode and the
        /// current date is highlighted.
        /// </summary>
        Week,

        /// <summary>
        /// A view that spans a whole month. The current date is highlighted.
        /// </summary>
        Month,

        /// <summary>
        /// A view that spans user defined period of time. Each day is displayed as in <see cref="Day"/> mode and the 
        /// current date is highlighted.
        /// </summary>
        Timeline
    }
}