using System;


using CalendarButton = Orm.Toolkit.Telerik.Windows.Controls.Calendar.CalendarButton;
using CalendarDateChangedEventArgs = Orm.Toolkit.Telerik.Windows.Controls.Calendar.CalendarDateChangedEventArgs;
using CalendarModeChangedEventArgs = Orm.Toolkit.Telerik.Windows.Controls.Calendar.CalendarModeChangedEventArgs;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents an input control for entering Dates.
	/// </summary>

    [Themable]

	public partial class RadDatePicker : RadDateTimePicker, IThemable
	{
		/// <summary>
		/// Initializes a new instance of the RadDatePicker class.
		/// </summary>
		public RadDatePicker()
		{
			// Becasue of Calendar:
			this.DisplayDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1, 0, 0, 0, 0);
			this.InputMode = InputMode.DatePicker;
		}
	}
}
