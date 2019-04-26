using System.Windows.Automation.Peers;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// The AutomationPeer associated with the RadMenu class.
	/// </summary>
	public class RadMenuAutomationPeer : FrameworkElementAutomationPeer
	{
		/// <summary>
		/// Initializes a new instance of the RadMenuAutomationPeer class.
		/// Automation Peer for the RadMenu class.
		/// </summary>
		/// <param name="owner">The object that is associated with this AutomationPeer.</param>
		public RadMenuAutomationPeer(RadMenu owner)
			: base(owner)
		{
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
			return "RadMenu";
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
				nameCore = "Rad Menu";
			}
			return nameCore;
		}
	}
}
