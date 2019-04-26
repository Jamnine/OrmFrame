using System;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	///     Provides data for the DateSelected and DisplayDateChanged events. 
	/// </summary>
	public class CalendarDateChangedEventArgs : RadRoutedEventArgs
	{
		internal CalendarDateChangedEventArgs(RoutedEvent routedEvent, object source, DateTime? removedDate, DateTime? addedDate)
			: base(routedEvent, source)
		{
			this.RemovedDate = removedDate;
			this.AddedDate = addedDate;
		}

		/// <summary>
		///     Gets the date to be newly displayed.
		/// </summary> 
		public DateTime? AddedDate
		{
			get;
			private set;
		}

		/// <summary>
		///     Gets the date that was previously displayed.
		/// </summary> 
		public DateTime? RemovedDate
		{
			get;
			private set;
		}
	}
}