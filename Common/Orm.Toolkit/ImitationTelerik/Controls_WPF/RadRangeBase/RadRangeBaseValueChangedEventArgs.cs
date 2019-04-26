using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// EventArgs used when <see cref="RadRangeBase"/> changes its value.
	/// </summary>
	public class RadRangeBaseValueChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RadRangeBaseValueChangedEventArgs"/> class.
		/// </summary>
		public RadRangeBaseValueChangedEventArgs(Nullable<double> oldValue, Nullable<double> newValue)
			: base()
		{
			this.OldValue = oldValue;
			this.NewValue = newValue;
		}

		/// <summary>
		/// Gets or sets the old value.
		/// </summary>
		/// <value>The old value.</value>
		public Nullable<double> OldValue
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the new value.
		/// </summary>
		/// <value>The new value.</value>
		public Nullable<double> NewValue
		{
			get;
			set;
		}
	}
}