using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A RecurrenceRuleChangedEventManager class.
	/// </summary>
	public class RecurrenceRuleChangedEventManager : WeakEventManager
	{
		private static RecurrenceRuleChangedEventManager CurrentManager
		{
			get
			{
				Type managerType = typeof(RecurrenceRuleChangedEventManager);
				var manager = (RecurrenceRuleChangedEventManager)GetCurrentManager(managerType);
				if (manager == null)
				{
					manager = new RecurrenceRuleChangedEventManager();
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
		public static void AddListener(IAppointment source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedAddListener(source, listener);
        }

		/// <summary>
		/// Removes the listener.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="listener">The listener.</param>
		public static void RemoveListener(IAppointment source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedRemoveListener(source, listener);
        }

		/// <summary>
		/// When overridden in a derived class, starts listening for the event being managed. After <see cref="M:System.Windows.WeakEventManager.StartListening(System.Object)"/>  is first called, the manager should be in the state of calling <see cref="M:System.Windows.WeakEventManager.DeliverEvent(System.Object,System.EventArgs)"/> or <see cref="M:System.Windows.WeakEventManager.DeliverEventToList(System.Object,System.EventArgs,System.Windows.WeakEventManager.ListenerList)"/> whenever the relevant event from the provided source is handled.
		/// </summary>
		/// <param name="source">The source to begin listening on.</param>
        protected override void StartListening(object source)
        {
			var app = (IAppointment)source;
			app.RecurrenceRuleChanged += this.OnRecurrenceRuleChanged;
        }

		/// <summary>
		/// When overridden in a derived class, stops listening on the provided source for the event being managed.
		/// </summary>
		/// <param name="source">The source to stop listening on.</param>
        protected override void StopListening(object source)
        {
			var app = (IAppointment)source;
			app.RecurrenceRuleChanged -= this.OnRecurrenceRuleChanged;
        }

		/// <summary>
		/// Called when [recurrence rule changed].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void OnRecurrenceRuleChanged(object sender, EventArgs e)
		{
			DeliverEvent(sender, e);
		}
    }
}
