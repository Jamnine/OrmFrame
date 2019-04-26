using System;
using System.Globalization;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Defines basic methods and properties for a scheduler.
    /// </summary>
    public interface IScheduler
    {
        /// <summary>
        /// Occurs when <see cref="ActiveViewDefinition"/> changed.
        /// </summary>
        event EventHandler ActiveViewDefinitionChanged;

        /// <summary>
        /// Occurs when <see cref="SelectedViewStartDateChanged"/> changed.
        /// </summary>
        event EventHandler SelectedViewStartDateChanged;

        /// <summary>
        /// Gets the active view definition.
        /// </summary>
        /// <value>The active view definition.</value>
        ViewDefinitionBase ActiveViewDefinition { get; }
        
        /// <summary>
        /// Gets or sets the selected time slot.
        /// </summary>
        /// <value>The selected time slot.</value>
        TimeSlot SelectedTimeSlot { get; set; }
        
        /// <summary>
        /// Gets the culture in use.
        /// </summary>
        /// <returns></returns>
        CultureInfo GetCultureInUse();
        
        /// <summary>
        /// Gets the first day of week in use.
        /// </summary>
        /// <returns></returns>
        DayOfWeek GetFirstDayOfWeekInUse();

        /// <summary>
        /// Called when [selected view start date changed].
        /// </summary>
        void OnSelectedViewStartDateChanged();
    }
}