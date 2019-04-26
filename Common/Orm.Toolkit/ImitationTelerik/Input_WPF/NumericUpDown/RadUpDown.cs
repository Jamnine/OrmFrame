using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// RadUpDown exposes two repeat buttons for easily handling the RangeBase value.
	/// </summary>
	[DefaultProperty("Value")]
	[DefaultEvent("ValueChanged")]
	[TemplatePart(Name = "increase", Type = typeof(RepeatButton))]
	[TemplatePart(Name = "decrease", Type = typeof(RepeatButton))]
	public class RadUpDown : RadNumericUpDown
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RadUpDown"/> class.
		/// </summary>
		public RadUpDown()
		{
			this.ShowTextBox = false;
		}
	}
}