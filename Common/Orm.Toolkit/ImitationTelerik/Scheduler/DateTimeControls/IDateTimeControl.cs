using System;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents date time picker control.
    /// </summary>
    public interface IDateTimeControl
    {
        /// <summary>
        /// Occurs when <see cref="SelectedDateTime"/> is changed.
        /// </summary>
        event RoutedPropertyChangedEventHandler<DateTime?> SelectedDateTimeChanged;

        /// <summary>
        /// Gets or sets the selected date time.
        /// </summary>
        /// <value>The selected date time.</value>
        DateTime? SelectedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the time items start.
        /// </summary>
        /// <value>The time items start.</value>
        TimeSpan TimePickerStartTime { get; set; }
    }
}