using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// The AutomationPeer associated with the RadContextMenu class.
	/// </summary>
	public class RadContextMenuAutomationPeer : FrameworkElementAutomationPeer, IExpandCollapseProvider
	{
		/// <summary>
		/// Initializes a new instance of the RadContextMenuAutomationPeer class.
		/// Automation Peer for the RadContextMenu class.
		/// </summary>
		/// <param name="owner">The object that is associated with this AutomationPeer.</param>
		public RadContextMenuAutomationPeer(RadContextMenu owner)
			: base(owner)
		{
		}

		/// <summary>
		/// Gets the state (expanded or collapsed) of the control.
		/// </summary>
		/// <value></value>
		/// <returns>
		/// The state (expanded or collapsed) of the control.
		/// </returns>
		public ExpandCollapseState ExpandCollapseState
		{
			get { return (this.Owner as RadContextMenu).IsOpen ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed; }
		}

		/// <summary>
		/// Hides all nodes, controls, or content that are descendants of the control.
		/// </summary>
		public void Collapse()
		{
			this.EnsureEnabled();

			(this.Owner as RadContextMenu).IsOpen = false;
		}

		/// <summary>
		/// Displays all child nodes, controls, or content of the control.
		/// </summary>
		public void Expand()
		{
			this.EnsureEnabled();

			(this.Owner as RadContextMenu).IsOpen = true;
		}

		/// <summary>
		/// Returns the control type for the UIElement associated with this AutomationPeer.
		/// This method is called by AutomationPeer.GetAutomationControlType.
		/// </summary>
		/// <returns>The AutomationControlType.Menu enumeration value.</returns>
		protected override AutomationControlType GetAutomationControlTypeCore()
		{
			return AutomationControlType.Menu;
		}

		/// <summary>
		/// Returns the name of the class associated with this AutomationPeer.
		/// This method is called by AutomationPeer.GetClassName.
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
			return "RadContextMenu";
		}

		/// <summary>
		/// Returns the text label of the FrameworkElement associated with this AutomationPeers.
		/// Called by AutomationPeer.GetName.
		/// </summary>
		/// <returns>A text label of the Element associated with this Automation Peer.</returns>
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore))
			{
				nameCore = "Rad Context Menu";
			}
			return nameCore;
		}

		private void EnsureEnabled()
		{
			if (!IsEnabled())
			{
				throw new ElementNotEnabledException();
			}
		}
	}
}
