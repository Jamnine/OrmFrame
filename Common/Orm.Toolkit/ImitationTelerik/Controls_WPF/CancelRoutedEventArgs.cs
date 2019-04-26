using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Contains state information and event data associated with a cancelable routed event.
	/// </summary>
	public class CancelRoutedEventArgs : RadRoutedEventArgs
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CancelRoutedEventArgs"/> class.
		/// </summary>
		public CancelRoutedEventArgs()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CancelRoutedEventArgs"/> class.
		/// </summary>
		/// <param name="routedEvent">The routed event identifier.</param>
		public CancelRoutedEventArgs(RoutedEvent routedEvent)
			: base(routedEvent)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CancelRoutedEventArgs"/> class.
		/// </summary>
		/// <param name="routedEvent">The routed event identifier for this instance of the <see cref="T:System.Windows.RoutedEventArgs"/> class.</param>
		/// <param name="source">An alternate source that will be reported when the event is handled.</param>
		public CancelRoutedEventArgs(RoutedEvent routedEvent, object source)
			: base(routedEvent, source)
		{
		}

		/// <summary>
		/// Gets or sets a value indicating whether the event should be canceled.
		/// </summary>
		/// <value><c>True</c> if cancel; otherwise, <c>false</c>.</value>
		public bool Cancel
		{
			get; 
			set;
		}
	}
}