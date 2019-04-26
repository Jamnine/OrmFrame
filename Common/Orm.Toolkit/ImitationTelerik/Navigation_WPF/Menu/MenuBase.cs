using System;
using System.ComponentModel;
using System.Windows;

using System.Windows.Controls;
using System.Windows.Controls.Primitives;

using System.Windows.Input;

using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Automation.Peers;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents a control that defines choices for users to select. 
	/// </summary>
	[StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(RadMenuItem))]
	[DefaultEvent("ItemClick")]
	public abstract class MenuBase : ItemsControl
	{
		/// <summary>
		/// Identifies the IconColumnWidth dependency property.
		/// </summary>
		public static readonly DependencyProperty IconColumnWidthProperty =
			DependencyProperty.Register("IconColumnWidth", typeof(double), typeof(MenuBase), new FrameworkPropertyMetadata(0d));

		/// <summary>
		/// Identifies the ClickToOpen dependency property.
		/// </summary>
		public static readonly DependencyProperty ClickToOpenProperty =
			DependencyProperty.Register("ClickToOpen", typeof(bool), typeof(MenuBase), null);

		/// <summary>
		/// Identifies the ShowDelay dependency property.
		/// </summary>
		public static readonly DependencyProperty ShowDelayProperty =
			DependencyProperty.Register("ShowDelay",
			typeof(Duration),
			typeof(MenuBase),
			new System.Windows.PropertyMetadata(new Duration(TimeSpan.FromMilliseconds(150))));

		/// <summary>
		/// Identifies the HideDelay dependency property.
		/// </summary>
		public static readonly DependencyProperty HideDelayProperty =
			DependencyProperty.Register("HideDelay",
			typeof(Duration),
			typeof(MenuBase),
			new System.Windows.PropertyMetadata(new Duration(TimeSpan.FromMilliseconds(250))));

		/// <summary>
		/// Identifies the NotifyOnHeaderClick dependency property.
		/// </summary>
		public static readonly DependencyProperty NotifyOnHeaderClickProperty =
			DependencyProperty.Register("NotifyOnHeaderClick", typeof(bool), typeof(MenuBase), null);

		internal static readonly RoutedEvent IsSelectedChangedEvent =
			EventManager.RegisterRoutedEvent("IsSelectedChanged",
			RoutingStrategy.Bubble,
			typeof(RadRoutedPropertyChangedEventHandler<bool>),
			typeof(MenuBase));

		private static readonly DependencyProperty IsLoadedProperty =
			DependencyProperty.Register("IsLoaded", typeof(bool), typeof(MenuBase), new PropertyMetadata(false));

		private RadMenuItem currentSelection;
		private bool mouseOverPopup;

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
		static MenuBase()
		{
			EventManager.RegisterClassHandler(typeof(MenuBase),
				IsSelectedChangedEvent,
				new RadRoutedPropertyChangedEventHandler<bool>(MenuBase.OnIsSelectedChanged));

			EventManager.RegisterClassHandler(typeof(MenuBase),
				RadMenuItem.ClickEvent,
				new RadRoutedEventHandler(OnItemClick));

			EventManager.RegisterClassHandler(typeof(MenuBase), Mouse.PreviewMouseDownOutsideCapturedElementEvent, new MouseButtonEventHandler(OnMouseDown), true);
			FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(MenuBase), new FrameworkPropertyMetadata(BooleanBoxes.TrueBox));
			InputMethod.IsInputMethodSuspendedProperty.OverrideMetadata(typeof(MenuBase), new FrameworkPropertyMetadata(BooleanBoxes.TrueBox, FrameworkPropertyMetadataOptions.Inherits));
			EventManager.RegisterClassHandler(typeof(MenuBase), Mouse.LostMouseCaptureEvent, new MouseEventHandler(MenuBase.OnLostMouseCapture));

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);

			if (this.IsKeyboardFocusWithin)
			{
				if (this.CurrentSelection == null)
				{
					this.CurrentSelection = Keyboard.FocusedElement as RadMenuItem;
				}
			}
			else
			{
				bool isDescendant = IsDescendant(this, System.Windows.Input.FocusManager.GetFocusedElement(this) as DependencyObject);
				if (!isDescendant)
				{
					if (Mouse.Captured == this)
					{
						Mouse.Capture(null);
					}

					if (this.CurrentSelection != null)
					{
						this.CurrentSelection = null;
					}
				}
			}
			this.InvokeMenuOpenedClosedAutomationEvent(this.IsKeyboardFocusWithin);
		}

		internal static bool IsDescendant(DependencyObject reference, DependencyObject node)
		{
			DependencyObject o = node;
			while (o != null)
			{
				if (o == reference)
				{
					return true;
				}
				FrameworkElement root = o as FrameworkElement;
				if (root != null && root.Parent is Popup)
				{
					Popup parent = root.Parent as Popup;
					o = parent;
					if (parent != null)
					{
						o = parent.Parent;
						if (o == null)
						{
							o = parent.PlacementTarget;
						}
					}
				}
				o = FindParent(o);
			}
			return false;
		}

		internal static DependencyObject FindParent(DependencyObject o)
		{
			DependencyObject reference = o as Visual;
			if (reference == null)
			{
				reference = o as Visual3D;
			}
			ContentElement element = (reference == null) ? (o as ContentElement) : null;
			if (element != null)
			{
				o = ContentOperations.GetParent(element);
				if (o != null)
				{
					return o;
				}
				FrameworkContentElement element2 = element as FrameworkContentElement;
				if (element2 != null)
				{
					return element2.Parent;
				}
			}
			else if (reference != null)
			{
				return VisualTreeHelper.GetParent(reference);
			}
			return null;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="MenuBase"/> class.
		/// </summary>
		/// TODO: DOC: Add summary, notes.
		protected MenuBase()
		{
			this.Loaded += new System.Windows.RoutedEventHandler(this.OnMenuLoaded);
		}

		/// <summary>
		/// Occurs when an item was clicked.
		/// </summary>
		public event RadRoutedEventHandler ItemClick;

		/// <summary>
		/// Gets or sets the time, in milliseconds, before displaying menu when the mouse cursor is over a submenu item.
		/// </summary>
		[TypeConverter(typeof(DurationConverter))]
		public Duration ShowDelay
		{
			get { return (Duration)GetValue(ShowDelayProperty); }
			set { SetValue(ShowDelayProperty, value); }
		}

		/// <summary>
		/// Gets or sets the time, in milliseconds, before closing menu when the mouse cursor leave a submenu item.
		/// </summary>
		[TypeConverter(typeof(DurationConverter))]
		public Duration HideDelay
		{
			get { return (Duration)GetValue(HideDelayProperty); }
			set { SetValue(HideDelayProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the ItemClick is raised when the user clicks on a item that has children.
		/// </summary>
		/// <value>
		/// True if the ItemClick event is raised when the user clicks on item that has children; otherwise, false.
		/// </value>
		public bool NotifyOnHeaderClick
		{
			get { return (bool)GetValue(NotifyOnHeaderClickProperty); }
			set { SetValue(NotifyOnHeaderClickProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether the child group opens upon clikcing a parent item.
		/// </summary>
		public bool ClickToOpen
		{
			get { return (bool)GetValue(ClickToOpenProperty); }
			set { SetValue(ClickToOpenProperty, value); }
		}

		/// <summary>
		/// Gets or sets the width of the column used to display the Icon.
		/// </summary>
		public double IconColumnWidth
		{
			get
			{
				return (double)this.GetValue(IconColumnWidthProperty);
			}
			set 
			{ 
				this.SetValue(IconColumnWidthProperty, value); 
			}
		}

		internal RadMenuItem CurrentSelection
		{
			get
			{
				return this.currentSelection;
			}
			set
			{
				if (this.currentSelection != null)
				{
					this.currentSelection.IsSelected = false;
				}
				this.currentSelection = value;
				if (this.currentSelection != null)
				{
					this.currentSelection.IsSelected = true;
				}
			}
		}

		internal bool MouseOverPopup
		{
			get
			{
				return this.mouseOverPopup;
			}
			set
			{
				this.mouseOverPopup = value;
			}
		}


		internal virtual void ForceCloseAll()
		{
			this.CloseAll();
		}



		internal virtual void CloseAll()
		{
			this.CurrentSelection = null;

			if (Mouse.Captured == this)
			{
				Mouse.Capture(null);
			}
			this.RestorePreviousFocus();

		}

		internal bool MenuNavigate(int index, int direction, bool open)
		{
			DependencyObject control = MenuBase.NavigateToItem(this, index, direction);

			if (control == null)
			{
				return false;
			}

			if (!this.SetCurrentSelection(control, open))
			{
				RadMenuItem item = control as RadMenuItem;
				if (item != null && item.IsSeparator)
				{
					int separatorIndex = this.ItemContainerGenerator.IndexFromContainer(item);
					control = MenuBase.NavigateToItem(this, separatorIndex + direction, direction);
					return this.SetCurrentSelection(control, open);
				}
			}
			else
			{
				return true;
			}

			return false;
		}

		internal static DependencyObject NavigateToItem(ItemsControl itemsControl, int index, int direction)
		{
			int coercedIndex = -1;
			UIElement container = null;
			int count = itemsControl.Items.Count - 1;

			if (itemsControl.Items.Count > index && index >= 0)
			{
				coercedIndex = index;
			}
			else if (index < 0)
			{
				coercedIndex = count;
			}
			else
			{
				coercedIndex = 0;
			}

			for (int i = 0; i < itemsControl.Items.Count; i++)
			{
				bool enabled = false;
				bool visible = false;

				container = itemsControl.ItemContainerGenerator.ContainerFromIndex(coercedIndex) as UIElement;

				if (container != null)
				{
					var control = container as System.Windows.Controls.Control;
					if (control != null)
					{
						enabled = control.IsEnabled && control.IsTabStop;
					}

					else
					{
						enabled = container.IsEnabled;
					}
					
					visible = container.IsVisible;

				}

				if (container == null || !enabled || !visible)
				{
					coercedIndex += direction;

					if (coercedIndex < 0)
					{
						coercedIndex = count;
					}
					if (coercedIndex > count)
					{
						coercedIndex = 0;
					}
				}
				else
				{
					break;
				}
			}

			return container;
		}

		/// <summary>
		/// Invoked when keyboard key is pressed while the element has focus.
		/// </summary>
		/// <param name="e">The KeyEventArgs that contains the event data.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.Key == Key.Escape)
			{
				this.CloseAll();
				e.Handled = true;
			}
		}

		/// <summary>
		/// Creates or identifies the element that is used to display the given item.
		/// </summary>
		/// <returns></returns>
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new RadMenuItem();
		}

		/// <summary>
		/// Determines if the specified item is (or is eligible to be) its own container.
		/// </summary>
		/// <param name="item">The item to check.</param>
		/// <returns>
		/// True if the item is (or is eligible to be) its own container; otherwise, false.
		/// </returns>
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is RadMenuItem;
		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);

			StyleManager.SetThemeFromParent(element, this);

			RadMenuItem menuItem = element as RadMenuItem;
			if (menuItem != null)
			{
				menuItem.Menu = this;
				menuItem.UpdateRole();
			}
		}

		/// <summary>
		/// Clear the Menu property.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void ClearContainerForItemOverride(DependencyObject element, object item)
		{
			base.ClearContainerForItemOverride(element, item);

			RadMenuItem menuItem = element as RadMenuItem;
			if (menuItem != null)
			{
				menuItem.Menu = null;
			}
		}

		/// <summary>
		/// Raises the ItemClick event.
		/// </summary>
		/// <param name="args">The RadRoutedEventArgs instance containing the event data.</param>
		protected virtual void OnItemClick(RadRoutedEventArgs args)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, args);
			}
		}

		/// <summary>
		/// Called when a MenuBase is loaded.
		/// </summary>
		/// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnLoaded(System.Windows.RoutedEventArgs e)
		{
			this.SetValue(IsLoadedProperty, true);
		}

		private static void OnIsSelectedChanged(object sender, RadRoutedPropertyChangedEventArgs<bool> e)
		{
			RadMenuItem originalSource = e.OriginalSource as RadMenuItem;
			if (originalSource != null)
			{
				MenuBase menu = (MenuBase)sender;
				if (e.NewValue)
				{
					if ((menu.CurrentSelection != originalSource) && (originalSource.ParentItem == null))
					{
						bool submenuOpen = false;
						if (menu.CurrentSelection != null)
						{
							submenuOpen = menu.CurrentSelection.IsSubmenuOpen;
							menu.CurrentSelection.CloseMenu();
						}

						menu.CurrentSelection = originalSource;
						if ((menu.CurrentSelection != null) && submenuOpen)
						{
							MenuItemRole role = menu.CurrentSelection.Role;
							if (((role == MenuItemRole.SubmenuHeader) || (role == MenuItemRole.TopLevelHeader)) && (menu.CurrentSelection.IsSubmenuOpen != submenuOpen))
							{
								if (submenuOpen)
								{
									menu.CurrentSelection.OpenMenu();
								}
								else
								{
									menu.CurrentSelection.CloseMenu();
								}
							}
						}
					}
				}
				else if (menu.CurrentSelection == originalSource)
				{
					menu.CurrentSelection = null;
				}
				e.Handled = true;
			}
		}

		private static void OnItemClick(object sender, RadRoutedEventArgs args)
		{
			(sender as MenuBase).OnItemClick(args);
		}


		private static void OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			var menu = sender as MenuBase;

			if ((Mouse.Captured == menu) && (e.OriginalSource == menu))
			{
				System.Diagnostics.Debug.WriteLine(true);

				menu.ForceCloseAll();
			}
		}

		private static void OnLostMouseCapture(object sender, MouseEventArgs e)
		{
			var menu = sender as MenuBase;
			if (Mouse.Captured != menu)
			{
				if (e.OriginalSource == menu)
				{
					bool isDescendant = IsDescendant(menu, Mouse.Captured as DependencyObject);

					if (Mouse.Captured == null || !isDescendant)
					{
						menu.ForceCloseAll();
						e.Handled = true;
					}
				}
				else if (IsDescendant(menu, e.OriginalSource as DependencyObject))
				{
					if (Mouse.Captured == null)
					{
						Mouse.Capture(menu, CaptureMode.SubTree);
						e.Handled = true;
					}
				}
				else
				{
					menu.ForceCloseAll();
				}
			}
		}

		private void OnMenuLoaded(object sender, System.Windows.RoutedEventArgs e)
		{
			this.OnLoaded(e);
		}

		private bool SetCurrentSelection(DependencyObject control, bool open)
		{
			RadMenuItem menuItem = control as RadMenuItem;
			if (menuItem != null && !menuItem.IsSeparator)
			{
				this.CurrentSelection = menuItem;
				menuItem.FocusOrSelect();
				menuItem.ChangeVisualState(true);
				if (open)
				{
					menuItem.OpenSubmenuWithKeyboard();
				}

				return true;
			}

			return false;
		}

        private void RestorePreviousFocus()
        {
            if (this.IsKeyboardFocusWithin)
            {
                Keyboard.Focus(null);
				FocusManager.SetFocusedElement(this, null);
            }
            DependencyObject parent = this.Parent;
            if (parent != null)
            {
                DependencyObject focusScope = FocusManager.GetFocusScope(parent);
                if (focusScope != null)
                {
                    IInputElement focusedElement = FocusManager.GetFocusedElement(focusScope);
                    if (this.ElementIsWithin(focusedElement))
                    {
                        FocusManager.SetFocusedElement(focusScope, null);
                    }
                }
            }
        }

		private void InvokeMenuOpenedClosedAutomationEvent(bool open)
		{
			AutomationEvents automationEvent = open ? AutomationEvents.MenuOpened : AutomationEvents.MenuClosed;
			if (AutomationPeer.ListenerExists(automationEvent))
			{
				System.Windows.Threading.DispatcherOperationCallback method = null;
				AutomationPeer peer = UIElementAutomationPeer.CreatePeerForElement(this);
				if (peer != null)
				{
					if (open)
					{
						if (method == null)
						{
							method = delegate(object param)
							{
								peer.RaiseAutomationEvent(automationEvent);
								return null;
							};
						}
						this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Input, method, null);
					}
					else
					{
						peer.RaiseAutomationEvent(automationEvent);
					}
				}
			}
		}

		private bool ElementIsWithin(IInputElement element)
		{
			DependencyObject parent;
			if (element == this)
			{
				return true;
			}
			for (RadMenuItem item = element as RadMenuItem; item != null; item = parent as RadMenuItem)
			{
				parent = item.Parent;
				if (parent == null)
				{
					parent = ItemsControl.ItemsControlFromItemContainer(item);
				}
				if (parent == this)
				{
					return true;
				}
			}
			return false;
		}

	}
}
