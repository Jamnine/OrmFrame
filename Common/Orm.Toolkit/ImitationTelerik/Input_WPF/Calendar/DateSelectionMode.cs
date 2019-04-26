using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	/// Specifies the selection mode of the calendar.
	/// </summary>
	/// <see cref="RadCalendar.DisplayMode"/>
	public enum DateSelectionMode
	{
		/// <summary>
		/// The user is able to select Days. The calendar shows one or more months for choosing dates.
		/// </summary>
		Day = 0,

		/// <summary>
		/// The user is able to select Months. The calendar displays the months of one or more years.
		/// </summary>
		Month = 1,

		/// <summary>
		/// The user is able to select Years. The calendar displays one or more decades (10s) of years.
		/// </summary>
		Year = 2,
	}
}
