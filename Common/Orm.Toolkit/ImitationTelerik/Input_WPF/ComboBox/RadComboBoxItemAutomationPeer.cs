using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Input;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents a selectable item in a RadComboBox.
	/// </summary>
	public class RadComboBoxItemAutomationPeer :

		ListBoxItemAutomationPeer

	{

		/// <summary>
		/// Initializes a new instance of the <see cref="RadComboBoxItemAutomationPeer"/> class.
		/// </summary>
		/// <param name="owner">The owner.</param>
		/// <param name="selectorAutomationPeer">The selector automation peer.</param>
		public RadComboBoxItemAutomationPeer(RadComboBoxItem owner, SelectorAutomationPeer selectorAutomationPeer)
			: base(owner, selectorAutomationPeer)
		{
		}

		/// <summary>
		/// ISelectionItemProvider implementation.
		/// </summary>
		/// <summary>
		/// 
		/// </summary>
		/// <param name="patternInterface"></param>
		/// <returns></returns>
		public override object GetPattern(PatternInterface patternInterface)
		{
			if (patternInterface == PatternInterface.ScrollItem ||
				patternInterface == PatternInterface.SelectionItem)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		/// <summary>
		/// Implementation of IScrollItemProvider.ScrollIntoView().
		/// </summary>
		public void ScrollIntoView()
		{
			if (this.ItemsControlAutomationPeer != null)
			{
				RadComboBox owner = this.ItemsControlAutomationPeer.Owner as RadComboBox;
				if (owner != null)
				{
					owner.ScrollIntoView(this.Item);
				}
			}
		}

		internal void RaiseAutomationIsSelectedChanged(bool isSelected)
		{
			this.RaisePropertyChangedEvent(SelectionItemPatternIdentifiers.IsSelectedProperty, !isSelected, isSelected);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationControlType GetAutomationControlTypeCore()
		{
			return AutomationControlType.ListItem;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
			return "RadComboBoxItem";
		}
	}
}