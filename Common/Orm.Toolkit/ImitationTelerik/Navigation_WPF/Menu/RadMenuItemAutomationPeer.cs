using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using ElementNotEnabledException = System.Windows.Automation.ElementNotEnabledException;
using ExpandCollapsePatternIdentifiers = System.Windows.Automation.ExpandCollapsePatternIdentifiers;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// The AutomationPeer associated with the RadMenuItem class.
	/// </summary>
	public class RadMenuItemAutomationPeer
		: FrameworkElementAutomationPeer,
		IExpandCollapseProvider,
		IToggleProvider,
		IInvokeProvider
	{
		/// <summary>
		/// Initializes a new instance of the RadMenuItemAutomationPeer class.
		/// Automation Peer for the RadMenuItem class.
		/// </summary>
		/// <param name="owner">The object that is associated with this AutomationPeer.</param>
		public RadMenuItemAutomationPeer(RadMenuItem owner)
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
				RadMenuItem owner = this.OwnerAsRadMenuItem();
				if ((!owner.HasItems) ||
					(owner.Role == MenuItemRole.TopLevelItem) ||
					(owner.Role == MenuItemRole.SubmenuItem))
				{
					return ExpandCollapseState.LeafNode;
				}
				return owner.IsSubmenuOpen ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed;
			}
		}

		/// <summary>
		/// IToggleProvider implementation.
		/// </summary>
		public ToggleState ToggleState
		{
			get
			{
				return this.OwnerAsRadMenuItem().IsChecked ? ToggleState.On : ToggleState.Off;
			}
		}

		/// <summary>
		/// IInvokeProvider implementation.
		/// </summary>
		public void Invoke()
		{
			this.GuarantyEnabled();
			RadMenuItem owner = this.OwnerAsRadMenuItem();
			switch (owner.Role)
			{
				case MenuItemRole.TopLevelItem:
				case MenuItemRole.SubmenuItem:
					owner.HandleMouseUp(); ////2DO: switch to ClickItem();
					break;
				case MenuItemRole.TopLevelHeader:
				case MenuItemRole.SubmenuHeader:
					owner.HandleMouseDown(); ////2DO: switch to ClickHeader();
					break;
			}
		}

		/// <summary>
		/// Returns the control pattern for the UIElement that is associated with this AutomationPeer.
		/// </summary>
		/// <param name="patternInterface">One of the PatternInterface enum values.</param>
		/// <returns></returns>
		public override object GetPattern(PatternInterface patternInterface)
		{
			RadMenuItem owner = this.OwnerAsRadMenuItem();
			if (patternInterface == PatternInterface.Invoke)
			{
				if ((!owner.HasItems) &&
					(owner.Role == MenuItemRole.TopLevelItem ||
					 owner.Role == MenuItemRole.SubmenuItem))
				{
					return this;
				}
			}
			if (patternInterface == PatternInterface.ExpandCollapse)
			{
				if (owner.HasItems &&
					(owner.Role == MenuItemRole.TopLevelHeader ||
					 owner.Role == MenuItemRole.SubmenuHeader))
				{
					return this;
				}
			}
			if (patternInterface == PatternInterface.Toggle)
			{
				if (owner.IsCheckable)
				{
					return this;
				}
			}
			return null;
		}

		/// <summary>
		/// IExpandCollapseProvider implementation.
		/// </summary>
		public void Collapse()
		{
			this.GuarantyEnabled();
			RadMenuItem owner = this.OwnerAsRadMenuItem();
			if ((!owner.HasItems) ||
				((owner.Role != MenuItemRole.SubmenuHeader) &&
				(owner.Role != MenuItemRole.TopLevelHeader)))
			{
				throw new InvalidOperationException();
			}
			owner.CloseMenu();
		}

		/// <summary>
		/// IExpandCollapseProvider implementation.
		/// </summary>
		public void Expand()
		{
			this.GuarantyEnabled();
			RadMenuItem owner = this.OwnerAsRadMenuItem();
			if ((!owner.HasItems) ||
				((owner.Role != MenuItemRole.SubmenuHeader) &&
				(owner.Role != MenuItemRole.TopLevelHeader)))
			{
				throw new InvalidOperationException();
			}
			owner.OpenMenu();
		}

		/// <summary>
		/// IToggleProvider implementation.
		/// </summary>
		public void Toggle()
		{
			this.GuarantyEnabled();
			RadMenuItem owner = this.OwnerAsRadMenuItem();
			if (!owner.IsCheckable)
			{
				throw new InvalidOperationException();
			}
			owner.IsChecked = !owner.IsChecked;
			owner.ChangeVisualState(false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseExpandCollapseAutomationEvent(bool oldValue, bool newValue)
		{
			this.RaiseAutomationEvent(AutomationEvents.PropertyChanged);
			this.RaisePropertyChangedEvent(ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty,
				oldValue ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed,
				newValue ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed);
		}

		/// <summary>
		/// Returns the access key for the UIElement associated with this AutomationPeer.
		/// This method is called by AutomationPeer.GetAccessKey.
		/// </summary>
		/// <returns>The access key for the UIElement associated with this AutomationPeer.</returns>
		protected override string GetAccessKeyCore()
		{
			return string.Empty;
			////
			////2DO: uncomment the code bellow when Menu-Access-Key is implemented
			////
			////string accessKeyCore = base.GetAccessKeyCore();
			////if (!string.IsNullOrEmpty(accessKeyCore))
			////{
			////    RadMenuItem owner = this.OwnerAsRadMenuItem();
			////    if (owner.Role == MenuItemRole.TopLevelHeader ||
			////        owner.Role != MenuItemRole.TopLevelItem)
			////    {
			////        return ("Alt+" + accessKeyCore);
			////    }
			////}
			////return accessKeyCore;
		}

		/// <summary>
		/// Returns the control type for the UIElement associated with this AutomationPeer.
		/// This method is called by AutomationPeer.GetAutomationControlType.
		/// </summary>
		/// <returns>The AutomationControlType.MenuItem enumeration value.</returns>
		protected override AutomationControlType GetAutomationControlTypeCore()
		{
			return AutomationControlType.MenuItem;
		}

		/// <summary>
		/// Returns the name of the class associated with this AutomationPeer.
		/// This method is called by AutomationPeer.GetClassName.
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
			return "RadMenuItem";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			RadMenuItem owner = this.OwnerAsRadMenuItem();
			if (string.IsNullOrEmpty(nameCore))
			{
				if (owner.Header is string)
				{
					nameCore = (string)owner.Header;
				}
			}
			////2DO: uncomment the code bellow when Menu-Access-Key is implemented
			////if (!string.IsNullOrEmpty(nameCore))
			////{
			////    if (owner.Header is string)
			////    {
			////        nameCore = RemoveAccessKeyMarker(nameCore);
			////    }
			////}
			return nameCore;
		}

		/// <summary>
		/// Get the children collection of the UIElement associated with this AutomationPeers.
		/// This method is called by AutomationPeer.GetChildren.
		/// </summary>
		/// <returns>A list of child System.Windows.Automation.Peers.AutomationPeer elements.</returns>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
		protected override List<AutomationPeer> GetChildrenCore()
		{
			RadMenuItem owner = this.OwnerAsRadMenuItem();
			ItemCollection items = owner.Items;
			if (items.Count > 0)
			{
				List<AutomationPeer> list = new List<AutomationPeer>(items.Count);
				for (int i = 0; i < items.Count; i++)
				{
					UIElement element = owner.ItemContainerGenerator.ContainerFromIndex(i) as UIElement;
					if (element != null)
					{
						AutomationPeer peer = FrameworkElementAutomationPeer.FromElement(element);
						if (peer == null)
						{
							peer = FrameworkElementAutomationPeer.CreatePeerForElement(element);
						}
						if (peer != null)
						{
							list.Add(peer);
						}
					}
				}
				return list;
			}
			return null;
		}

		/// <summary>
		/// Returns a value that indicates whether the <see cref="T:System.Windows.UIElement"/> that is associated with this <see cref="T:System.Windows.Automation.Peers.FrameworkElementAutomationPeer"/> is understood by the end user as interactive. Optionally, the user might understand the <see cref="T:System.Windows.UIElement"/> as contributing to the logical structure of the control in the GUI. This method is called by <see cref="M:System.Windows.Automation.Peers.AutomationPeer.IsControlElement"/>.
		/// </summary>
		/// <returns>
		/// True if the element is interactive; otherwise, false.
		/// </returns>
		protected override bool IsControlElementCore()
		{
			return true;
		}

		private RadMenuItem OwnerAsRadMenuItem()
		{
			RadMenuItem menuItem = this.Owner as RadMenuItem;
			if (null == menuItem)
			{
				throw new InvalidOperationException("The Owner have to be RadMenuItem");
			}
			return menuItem;
		}

		private void GuarantyEnabled()
		{
			if (!IsEnabled())
			{
				throw new ElementNotEnabledException();
			}
		}

		////2DO: uncomment the method bellow when Menu-Access-Key is implemented
		////
		/////// <summary>
		/////// 
		/////// </summary>
		/////// <param name="data"></param>
		/////// <returns></returns>
		////public static string RemoveAccessKeyMarker(string data)
		////{
		////    if (!string.IsNullOrEmpty(data))
		////    {
		////        const char AccessKeyMarker = '_';
		////        int end = data.Length - 1;
		////        for (int i = 0; i < end; i += 2)
		////        {
		////            if (0 > (i = data.IndexOf(AccessKeyMarker, i)))
		////            {
		////                break;
		////            }
		////            if ((i < (end)) &&
		////                (data[i + 1] != AccessKeyMarker))
		////            {
		////                return data.Remove(i, 1);
		////            }
		////        }
		////    }
		////    return data;
		////}
	}
}