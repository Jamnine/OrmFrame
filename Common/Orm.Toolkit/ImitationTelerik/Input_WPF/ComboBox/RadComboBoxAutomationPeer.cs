// Decide: Will we allow UIA initialization (SetValue)!
//#define IS_READONLY

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// 
	/// </summary>
	public class RadComboBoxAutomationPeer : SelectorAutomationPeer, IValueProvider, IExpandCollapseProvider
	{
		/// <summary>
		/// Initializes a new instance of the RadComboBoxAutomationPeer class.
		/// </summary>
		/// <param name="owner"></param>
		public RadComboBoxAutomationPeer(RadComboBox owner)
			: base(owner)
		{
		}

		/// <summary>
		/// IExpandCollapseProvider implementation.
		/// </summary>
		public ExpandCollapseState ExpandCollapseState
		{
			get
			{
				return this.OwnerAsRadComboBox().IsDropDownOpen
					? ExpandCollapseState.Expanded
					: ExpandCollapseState.Collapsed;
			}
		}

		/// <summary>
		/// IValueProvider implementation.
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
#if ! IS_READONLY

				RadComboBox owner = this.OwnerAsRadComboBox();
				if (owner.IsEnabled)
				{
					return !owner.IsEditable;
				}

#endif
				return true;
			}
		}

		/// <summary>
		/// IValueProvider implementation.
		/// </summary>
		public string Value
		{
			get
			{
				RadComboBox owner = this.OwnerAsRadComboBox();
				if (owner.SelectionBoxItem != null)
				{
					return RadComboBoxAutomationPeer.GetStringFromObject(owner.SelectionBoxItem);
				}
#if ! IS_READONLY
				if (!this.IsReadOnly)
				{
					return owner.Text;
				}
#endif
				return string.Empty;
			}
		}

		/// <summary>
		/// Gets a control pattern that is associated with this AutomationPeer.
		/// </summary>
		/// <param name="patternInterface">One of the enumeration values that indicates the control pattern.</param>
		/// <returns>The object that implements the pattern interface, or null.</returns>
		public override object GetPattern(PatternInterface patternInterface)
		{
			if (patternInterface == PatternInterface.Value)
			{
				return this;
			}
			if (patternInterface == PatternInterface.ExpandCollapse)
			{
				return this;
			}
			if (patternInterface == PatternInterface.Scroll)
			{
				return null;
			}
			return base.GetPattern(patternInterface);
		}

		/// <summary>
		/// IExpandCollapseProvider implementation.
		/// </summary>
		public void Collapse()
		{
			this.GuarantyEnabled();
			this.OwnerAsRadComboBox().IsDropDownOpen = false;
		}

		/// <summary>
		/// IExpandCollapseProvider implementation.
		/// </summary>
		public void Expand()
		{
			this.GuarantyEnabled();
			this.OwnerAsRadComboBox().IsDropDownOpen = true;
		}

		/// <summary>
		/// IValueProvider implementation.
		/// </summary>
		/// <param name="value"></param>
		public void SetValue(string value)
		{
#if ! IS_READONLY
			if (this.IsReadOnly)
			{
				throw new InvalidOperationException("Read-only ComboBox");
			}
			else
			{
				if (null == value)
				{
					throw new ArgumentNullException("value");
				}
				RadComboBox owner = this.OwnerAsRadComboBox();
				owner.Text = value;
			}
#else
			throw new InvalidOperationException(string.Empty);
#endif
		}


		internal void RaiseExpandCollapseAutomationEvent(bool oldValue, bool newValue)
		{
			this.RaisePropertyChangedEvent(ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty,
				oldValue ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed,
				newValue ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed);
		}

		/// <summary>
		/// When overridden in a derived class, creates a new instance of the <see cref="T:System.Windows.Automation.Peers.ItemAutomationPeer"/> for a data item in the <see cref="P:System.Windows.Controls.ItemsControl.Items"/> collection of this <see cref="T:System.Windows.Controls.ItemsControl"/>.
		/// </summary>
		/// <param name="item">The data item that is associated with this <see cref="T:System.Windows.Automation.Peers.ItemAutomationPeer"/>.</param>
		/// <returns></returns>
		protected override ItemAutomationPeer CreateItemAutomationPeer(object item)
		{

			return new RadComboBoxItemAutomationPeer(item as RadComboBoxItem, this);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationControlType GetAutomationControlTypeCore()
		{
			return AutomationControlType.ComboBox;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
			return "RadComboBox";
		}

		private static string GetStringFromObject(object workObject)
		{
			if (workObject == null)
			{
				return string.Empty;
			}
			var element = workObject as FrameworkElement;
			if (element != null)
			{
				return element.GetPlainText();
			}
			return workObject.ToString();
		}


		private RadComboBox OwnerAsRadComboBox()
		{
			RadComboBox comboBox = this.Owner as RadComboBox;
			if (null == comboBox)
			{
				throw new InvalidOperationException("The Owner have to be RadComboBox");
			}
			return comboBox;
		}

		private void GuarantyEnabled()
		{
			if (!this.IsEnabled())
			{
				throw new ElementNotEnabledException();
			}
		}
	}
}