using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	///	Represents a selection control that allows you to select time from grid.
	/// </summary>
	public class DateTimePickerClock : RadClock
	{
		/// <summary>
		///	Initializes a new instance of the <see cref="T:Telerik.Windows.Controls.DateTimePickerClock"/> class.
		/// </summary>
		public DateTimePickerClock()
		{
			this.AddHandler(RadClock.MouseLeftButtonDownEvent, new MouseButtonEventHandler((s, e) => e.Handled = true), true);
		}

		/// <summary>
		///	Generates the items source.
		/// </summary>
		/// <returns>
        /// The collection that is used to generate the item source of the control.
        /// </returns>
		protected override System.Collections.IEnumerable GenerateItemsSource()
		{
			if (this.ItemsSource == null || !(this.ItemsSource is IEnumerable<TimeSpan>))
			{
				return base.GenerateItemsSource();
			}
			else
			{
				var currentTimeSpanCollection = this.ItemsSource as IEnumerable<TimeSpan>;

				var resultCollecetion = currentTimeSpanCollection.Where(t => t <= this.EndTime && t >= this.StartTime);
				return resultCollecetion;
			}
		}

		/// <summary>
		///	Occurs when SelectedTime property has changed.
		/// </summary>
		protected override void OnSelectedTimeChanged()
		{
			base.OnSelectedTimeChanged();

			this.Focus();
		}
	}
}
