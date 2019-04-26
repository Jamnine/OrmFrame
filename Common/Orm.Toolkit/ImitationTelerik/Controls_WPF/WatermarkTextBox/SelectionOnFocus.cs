
namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Specifies the selection modification when the control is focus.
	/// </summary>
	public enum SelectionOnFocus
	{
		/// <summary>
		/// Selection will not be modified.
		/// </summary>
		Unchanged,

		/// <summary>
		/// The whole text will be selected.
		/// </summary>
		SelectAll,

		/// <summary>
		/// The caret will be moved at the start of the text.
		/// </summary>
		CaretToBeginning,

		/// <summary>
		/// The caret will be moved at the end of the text.
		/// </summary>
		CaretToEnd
	}
}
