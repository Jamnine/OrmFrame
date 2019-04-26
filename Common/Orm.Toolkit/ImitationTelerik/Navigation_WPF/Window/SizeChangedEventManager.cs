using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A SizeChangedEventManager class.
	/// </summary>
	public class SizeChangedEventManager : WeakEventManager
	{
		private static SizeChangedEventManager CurrentManager
		{
			get
			{
				Type managerType = typeof(SizeChangedEventManager);
				var manager = (SizeChangedEventManager)GetCurrentManager(managerType);
				if (manager == null)
				{
					manager = new SizeChangedEventManager();
					SetCurrentManager(managerType, manager);
				}
				return manager;
			}
		} 

		/// <summary>
		/// Adds the listener.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="listener">The listener.</param>
		public static void AddListener(Window source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedAddListener(source, listener);
        }

		/// <summary>
		/// Removes the listener.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="listener">The listener.</param>
		public static void RemoveListener(Window source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedRemoveListener(source, listener);
        }

		/// <summary>
		/// When overridden in a derived class, starts listening for the event being managed. After <see cref="M:System.Windows.WeakEventManager.StartListening(System.Object)"/>  is first called, the manager should be in the state of calling <see cref="M:System.Windows.WeakEventManager.DeliverEvent(System.Object,System.EventArgs)"/> or <see cref="M:System.Windows.WeakEventManager.DeliverEventToList(System.Object,System.EventArgs,System.Windows.WeakEventManager.ListenerList)"/> whenever the relevant event from the provided source is handled.
		/// </summary>
		/// <param name="source">The source to begin listening on.</param>
        protected override void StartListening(object source)
        {
			var window = (Window)source;
			window.SizeChanged += this.OnSizeChanged;
        }

		/// <summary>
		/// When overridden in a derived class, stops listening on the provided source for the event being managed.
		/// </summary>
		/// <param name="source">The source to stop listening on.</param>
        protected override void StopListening(object source)
        {
			var window = (Window)source;
			window.SizeChanged -= this.OnSizeChanged;
        }


		/// <summary>
		/// Called when [size changed].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void OnSizeChanged(object sender, EventArgs e)
		{
			DeliverEvent(sender, e);
		}
    }
}
