namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	/// Specifies the display mode of the calendar.
	/// </summary>
	/// <see cref="RadCalendar.DisplayMode"/>
	public enum DisplayMode
	{
		/// <summary>
		/// The calendar shows one or more months for choosing dates.
		/// </summary>
		MonthView = 0,

		/// <summary>
		/// The calendar displays the months of one or more years.
		/// </summary>
		YearView = 1,

		/// <summary>
		/// The calendar displays one or more decades (10s) of years.
		/// </summary>
		DecadeView = 2,

		/// <summary>
		/// The calendar displays one or more centuries.
		/// </summary>
		CenturyView = 3
	}
}