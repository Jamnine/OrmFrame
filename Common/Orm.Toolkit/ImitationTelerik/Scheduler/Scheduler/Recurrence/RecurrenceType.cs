namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Determines the types of recurrent appointments. 
    /// </summary>
    public enum RecurrenceType
    {
        /// <summary>
        /// Recurs every day.
        /// </summary>
        Daily,

        /// <summary>
        /// Recurs every weekday (workday).
        /// </summary>
        WeekDays,

        /// <summary>
        /// Recurs every week.
        /// </summary>
        Weekly,

        /// <summary>
        /// Recurs every month.
        /// </summary>
        Monthly,

        /// <summary>
        /// Recurs every nth day of nth month.
        /// </summary>
        MonthlyNth,

        /// <summary>
        /// Recurs every year.
        /// </summary>
        Yearly,

        /// <summary>
        /// Recurs every nth dat of some month.
        /// </summary>
        YearlyNth
    }
}