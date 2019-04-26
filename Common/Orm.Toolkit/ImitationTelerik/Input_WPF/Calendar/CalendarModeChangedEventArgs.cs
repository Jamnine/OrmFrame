using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	/// The EventArgs of the RadCalendar.DisplayModeChanged event. 
	/// </summary> 
	public class CalendarModeChangedEventArgs : RadRoutedEventArgs
	{
		/// <summary>
		/// Initializes a new instance of the CalendarModeChangedEventArgs class.
		/// </summary> 
		/// <param name="oldMode">Previous value of the property, prior to the event being raised.</param>
		/// <param name="newMode">Current value of the property at the time of the event.</param>
		/// <param name="routedEvent">The routed event.</param>
		/// <param name="source">The source that raised the event.</param>
		public CalendarModeChangedEventArgs(RoutedEvent routedEvent, object source, DisplayMode oldMode, DisplayMode newMode)
			: base(routedEvent, source)
		{
			this.OldMode = oldMode;
			this.NewMode = newMode;
		}

		/// <summary> 
		///     Gets the new mode of the Calendar.
		/// </summary>
		public DisplayMode NewMode
		{
			get;
			private set;
		}

		/// <summary> 
		///     Gets the previous mode of the Calendar.
		/// </summary>
		public DisplayMode OldMode
		{
			get;
			private set;
		}
	}
}