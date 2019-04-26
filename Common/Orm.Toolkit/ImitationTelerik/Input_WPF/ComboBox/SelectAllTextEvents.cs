using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Specifies the names of the events that will automatically select the text in RadComboBox.
	/// </summary>
	[Flags]
	public enum SelectAllTextEvents
	{
		/// <summary>
		/// The text will never be selected.
		/// </summary>
		None = 0,

		/// <summary>
		/// The text will be selected when RadComboBox gets the focus.
		/// </summary>
		GotFocus = 1,

		/// <summary>
		/// The text will be selected when the dropdown is opened.
		/// </summary>
		DropDownOpen = 2,

		/// <summary>
		/// The text will be selected when the selection changes.
		/// </summary>
		SelectionChanged = 4,

		/// <summary>
		/// The text will be selected on all events.
		/// </summary>
		All = GotFocus | DropDownOpen | SelectionChanged
	}
}