using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains methods and properties of a window.
	/// </summary>
	public interface IWindow
	{
		/// <summary>
		/// Gets or sets the window's title. This is a dependency property.
		/// </summary>
		/// <returns>A <see cref="string"/> that contains the window's title.</returns>
		string Title
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the icon of the window. This is a dependency property.
		/// </summary>
		/// <returns>An <see cref="ImageSource"/> that represents the window's icon.</returns>
		ImageSource Icon
		{
			get;
			set;
		}

		/// <summary>
		/// Activates the window and brings it to the foreground.
		/// </summary>
		void Activate();

		/// <summary>
		/// Opens the window.
		/// </summary>
		void Show();

		/// <summary>
		/// Manually closes the window.
		/// </summary>
		void Close();
	}
}