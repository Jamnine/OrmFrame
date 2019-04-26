using System;
using System.Windows;
using System.Windows.Controls;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{

    using RadRoutedEventArgs = RoutedEventArgs;
    using RadRoutedEventHandler = RoutedEventHandler;

    /// <summary>
    /// Represents the appointment dialog window.
    /// </summary>
    public interface IAppointmentDialogWindow
    {
        /// <summary>
        /// Occurs when the appointment is saved.
        /// </summary>
        event RoutedEventHandler AppointmentSaved;

        /// <summary>
        /// Occurs before the appointment is saved.
        /// </summary>
        event EventHandler<AppointmentSavingEventArgs> AppointmentSaving;

        /// <summary>
        /// Occurs when the window is about to be closed.
        /// </summary> 
        event RoutedEventHandler Closed;

        /// <summary>
        /// Occurs when the parent appointment is edited.
        /// </summary>
        event RoutedEventHandler EditParentAppointment;

        /// <summary>
        /// Gets or sets the Occurrence property. The default value is null.
        /// This is a dependency property.
        /// </summary>
        Occurrence Occurrence { get; set; }

        /// <summary>
        /// Identifies the <see cref="IScheduler"/> property.
        /// </summary>
        IScheduler Scheduler { get; set; }

        /// <summary>
        /// Identifies the <see cref="Style"/> of the window.
        /// </summary>
        Style Style { get; set; }

        /// <summary>
        /// Gets or sets the view mode of the window. This is a dependency property.
        /// </summary>
        /// <returns>The current view mode of the window. The default value is <see cref="AppointmentViewMode.Add"/>.</returns>  
        AppointmentViewMode ViewMode { get; set; }

		/// <summary>
		/// Gets or sets the recurrence mode.
		/// </summary>
		/// <value>The recurrence mode.</value>
		RecurrenceMode RecurrenceMode { get; set; }

        /// <summary>
        /// Manually closes the window.
        /// </summary>
        void Close();

        /// <summary>
        /// Opens the window.
        /// </summary>
        void Show();
    }
}
