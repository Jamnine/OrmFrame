using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

using MenuPlacementMode = System.Windows.Controls.Primitives.PlacementMode;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents a context menu control that enables you to hierarchically organize elements with associated event handlers.
	/// </summary>
	[StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(RadMenuItem))]
	[DefaultProperty("IsOpen")]
	[DefaultEvent("Opened")]
	public class RadContextMenu : MenuBase
	{
		/// <summary>
		/// Identifies the AttachOnHandledEvents dependency property.
		/// </summary>
		public static readonly DependencyProperty AttachOnHandledEventsProperty =
			DependencyProperty.Register("AttachOnHandledEvents", typeof(bool), typeof(RadContextMenu), new PropertyMetadata(false, OnAttachOnHandledEventsChanged));

		/// <summary>
		/// Identifies the IsOpen dependency property.
		/// </summary>
		public static readonly DependencyProperty IsOpenProperty =
			DependencyProperty.Register("IsOpen",
			typeof(bool),
			typeof(RadContextMenu),
			new System.Windows.PropertyMetadata(false, RadContextMenu.OnIsOpenChanged));

		/// <summary>
		/// Identifies the StaysOpen dependency property.
		/// </summary>
		public static readonly DependencyProperty StaysOpenProperty =
			DependencyProperty.Register("StaysOpen", typeof(bool), typeof(RadContextMenu), null);

		/// <summary>
		/// Identifies the PlacementRectangle dependency property.
		/// </summary>
		public static readonly DependencyProperty PlacementRectangleProperty =
			DependencyProperty.Register("PlacementRectangle",
			typeof(Rect),
			typeof(RadContextMenu),
			new System.Windows.PropertyMetadata(Rect.Empty));

		/// <summary>
		/// Identifies the PlacementTarget dependency property
		/// </summary>
		public static readonly DependencyProperty PlacementTargetProperty =
			DependencyProperty.Register("PlacementTarget", typeof(UIElement), typeof(RadContextMenu), null);

		/// <summary>
		/// Identifies the Placement dependency property.
		/// </summary>
		public static readonly DependencyProperty PlacementProperty;

		/// <summary>
		/// Identifies the HorizontalOffset dependency property.
		/// </summary>
		public static readonly DependencyProperty HorizontalOffsetProperty =
			DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(RadContextMenu), null);

		/// <summary>
		/// Identifies the VerticalOffset dependency property.
		/// </summary>
		public static readonly DependencyProperty VerticalOffsetProperty =
			DependencyProperty.Register("VerticalOffset", typeof(double), typeof(RadContextMenu), null);

		/// <summary>
		/// Identifies the ModifierKey dependency property.
		/// </summary>
		public static readonly DependencyProperty ModifierKeyProperty =
			DependencyProperty.Register("ModifierKey",
			typeof(ModifierKeys),
			typeof(RadContextMenu),
			new PropertyMetadata(ModifierKeys.None));

		/// <summary>
		/// Identifies the EventName dependency property.
		/// </summary>
		public static readonly DependencyProperty EventNameProperty =
			DependencyProperty.Register("EventName",
			typeof(string),
			typeof(RadContextMenu),
			new System.Windows.PropertyMetadata("MouseRightButtonUp", OnEventNameChanged));

		/// <summary>
		/// Identifies the InheritDataContext dependency property
		/// </summary>
		public static readonly DependencyProperty InheritDataContextProperty =
			DependencyProperty.Register("InheritDataContext", typeof(bool), typeof(RadContextMenu), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the RadContextMenu attached property.
		/// </summary>
		public static

 new

 readonly DependencyProperty ContextMenuProperty =
			DependencyProperty.RegisterAttached("ContextMenu",
			typeof(FrameworkElement),
			typeof(RadContextMenu),
			new System.Windows.PropertyMetadata(OnContextMenuChanged));

		/// <summary>
		/// Identifies the Closed routed event.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly RoutedEvent ClosedEvent =
			EventManager.RegisterRoutedEvent("Closed",
			RoutingStrategy.Bubble,
			typeof(RoutedEventHandler),
			typeof(RadContextMenu));

		/// <summary>
		/// Identifies the Opened routed event.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly RoutedEvent OpenedEvent =
			EventManager.RegisterRoutedEvent("Opened",
			RoutingStrategy.Bubble,
			typeof(RoutedEventHandler),
			typeof(RadContextMenu));

		/// <summary>
		/// Identifies the InsideContextMenu attached property.
		/// </summary>
		internal static readonly DependencyProperty InsideContextMenuProperty =
			DependencyProperty.RegisterAttached("InsideContextMenu", typeof(bool), typeof(RadContextMenu), null);

		private static MenuPlacementMode menuPlacementDefault =

 MenuPlacementMode.MousePoint;


		private static MethodInfo methodInfo = typeof(RadContextMenu).GetMethod("OnEventTriggered", BindingFlags.NonPublic | BindingFlags.Static);

		private Popup rootPopup;


		private FrameworkElement elementWithContextMenu;
		private Point? mousePosition;
		private EventInfo trigger;
		private Delegate emittedHandler;
		private RoutedEvent routedEvent;

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
		static RadContextMenu()
		{
			PlacementProperty =
				DependencyProperty.Register("Placement",
											typeof(MenuPlacementMode),
											typeof(RadContextMenu),
											new System.Windows.PropertyMetadata(menuPlacementDefault));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadContextMenu),
                new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadContextMenu))));

            EventManager.RegisterClassHandler(typeof(RadContextMenu), AccessKeyManager.AccessKeyPressedEvent, new AccessKeyPressedEventHandler(RadContextMenu.OnAccessKeyPressed));

            Control.IsTabStopProperty.OverrideMetadata(typeof(RadContextMenu), new FrameworkPropertyMetadata(BooleanBoxes.FalseBox));
            KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(RadContextMenu), new FrameworkPropertyMetadata(KeyboardNavigationMode.Cycle));
            KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(RadContextMenu), new FrameworkPropertyMetadata(KeyboardNavigationMode.Contained));
            KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(RadContextMenu), new FrameworkPropertyMetadata(KeyboardNavigationMode.Cycle));
            FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(RadContextMenu), new FrameworkPropertyMetadata(null));

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RadContextMenu"/> class.
		/// </summary>
		public RadContextMenu()
		{
            //TelerikLicense.Verify(this);//禁止验证许可

			this.DefaultStyleKey = typeof(RadContextMenu);

			this.ClickToOpen = true;


            this.AddEventToRedirectList(CommandManager.PreviewExecutedEvent);
            this.AddEventToRedirectList(CommandManager.ExecutedEvent);
            this.AddEventToRedirectList(CommandManager.PreviewCanExecuteEvent);
            this.AddEventToRedirectList(CommandManager.CanExecuteEvent);
            this.AddEventToRedirectList(RadMenuItem.ClickEvent);
            this.AddEventToRedirectList(RadContextMenu.ClosedEvent);
            this.AddEventToRedirectList(RadContextMenu.OpenedEvent);

		}

		/// <summary>
		/// Occurs when a particular instance of a RadContextMenu closes.
		/// </summary>
		public event RoutedEventHandler Closed
		{
			add
			{
				this.AddHandler(ClosedEvent, value);
			}
			remove
			{
				this.RemoveHandler(ClosedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when a particular instance of a RadContextMenu opens. 
		/// </summary>
		public event RoutedEventHandler Opened
		{
			add
			{
				this.AddHandler(OpenedEvent, value);
			}
			remove
			{
				this.RemoveHandler(OpenedEvent, value);
			}
		}

		/// <summary>
		/// Gets the position of the mouse at the moment when the menu was opened.
		/// </summary>
		public Point MousePosition
		{
			get
			{
				return this.mousePosition ?? new Point();
			}
		}

		/// <summary>
		/// Gets or sets whether RadContextMenu will open on handled routed events.
		/// The default value is false. This is a dependency property.
		/// </summary>
		public bool AttachOnHandledEvents
		{
			get
			{
				return (bool)this.GetValue(AttachOnHandledEventsProperty);
			}
			set
			{
				this.SetValue(AttachOnHandledEventsProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the name of the event that will open the context menu.
		/// </summary>
		/// <value>The name of the event.</value>
		public string EventName
		{
			get
			{
				return (string)this.GetValue(EventNameProperty);
			}
			set
			{
				this.SetValue(EventNameProperty, value);
			}
		}

		/// <summary>
		/// Get or sets the horizontal distance between the target origin and the popup alignment point. This is a dependency property.
		/// </summary>
		[Category("Layout")]
		public double HorizontalOffset
		{
			get
			{
				return (double)this.GetValue(HorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(HorizontalOffsetProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value that indicates whether the RadContextMenu is visible. This is a dependency property.
		/// </summary>
		[Category("Appearance"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool IsOpen
		{
			get
			{
				return (bool)this.GetValue(IsOpenProperty);
			}
			set
			{
				this.SetValue(IsOpenProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a ModifierKey that should be pressed when EventName event occurs to open the RadContextMenu. This is a dependency property. 
		/// </summary>
		public ModifierKeys ModifierKey
		{
			get
			{
				return (ModifierKeys)this.GetValue(ModifierKeyProperty);
			}
			set
			{
				this.SetValue(ModifierKeyProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the Placement property of a RadContextMenu. This is a dependency property.
		/// </summary>
		[Category("Layout")]

        public System.Windows.Controls.Primitives.PlacementMode Placement

		{
			get
			{

                return (System.Windows.Controls.Primitives.PlacementMode)this.GetValue(PlacementProperty);

			}
			set
			{
				this.SetValue(PlacementProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the area relative to which the context menu is positioned when it opens. This is a dependency property.
		/// </summary>
		[Category("Layout")]
		public Rect PlacementRectangle
		{
			get
			{
				return (Rect)this.GetValue(PlacementRectangleProperty);
			}
			set
			{
				this.SetValue(PlacementRectangleProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value that indicates whether the RadContextMenu should close automatically. This is a dependency property.
		/// </summary>
		[Category("Behavior")]
		public bool StaysOpen
		{
			get
			{
				return (bool)this.GetValue(StaysOpenProperty);
			}
			set
			{
				this.SetValue(StaysOpenProperty, value);
			}
		}

		/// <summary>
		/// Get or sets the vertical distance between the target origin and the popup alignment point. This is a dependency property.
		/// </summary>
		[Category("Layout")]
		public double VerticalOffset
		{
			get
			{
				return (double)this.GetValue(VerticalOffsetProperty);
			}
			set
			{
				this.SetValue(VerticalOffsetProperty, value);
			}
		}

		/// <summary>
		/// Get or sets whether RadContexMenu will inherit DataContext of the element on which it is attached.
		/// This is a dependency property.
		/// </summary>
		public bool InheritDataContext
		{
			get
			{
				return (bool)GetValue(InheritDataContextProperty);
			}
			set
			{
				SetValue(InheritDataContextProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the PlacementTarget. This is a dependency property.
		/// </summary>
		[Category("Layout")]
		public UIElement PlacementTarget
		{
			get { return (UIElement)GetValue(PlacementTargetProperty); }
			set { SetValue(PlacementTargetProperty, value); }
		}

		/// <summary>
		/// Gets the element on which RadContextMenu is attached.
		/// </summary>
		public UIElement UIElement
		{
			get
			{
				return this.elementWithContextMenu;
			}
		}

		private bool ModifierKeyPressed
		{
			get
			{
				return (Keyboard.Modifiers & this.ModifierKey) == this.ModifierKey;
			}
		}

		/// <summary>
		/// Gets the value of the ContextMenu property of the specified element. 
		/// </summary>
		public static RadContextMenu GetContextMenu(FrameworkElement element)
		{
			return (RadContextMenu)element.GetValue(ContextMenuProperty);
		}

		/// <summary>
		/// Sets the value of the ContextMenu property of the specified element.
		/// </summary>
		public static void SetContextMenu(FrameworkElement element, RadContextMenu value)
		{
			element.SetValue(ContextMenuProperty, value);
		}

		/// <summary>
		/// Returns the top-most element of the given type 
		/// at the MousePosition coordinates.
		/// </summary>
		/// <typeparam name="T">The type of the element to be returned.</typeparam>
		public T GetClickedElement<T>() where T : FrameworkElement
		{
			return this.elementWithContextMenu.GetElementsInScreenCoordinates<T>(this.MousePosition).FirstOrDefault();
		}

		/// <summary>
		/// Gets the value of the InsideContextMenu property of the specified object.
		/// </summary>
		internal static bool GetInsideContextMenu(DependencyObject obj)
		{
			return (bool)obj.GetValue(InsideContextMenuProperty);
		}

		/// <summary>
		/// Sets the value of the InsideContextMenu property of the specified element.
		/// </summary>
		internal static void SetInsideContextMenu(DependencyObject obj, bool value)
		{
			obj.SetValue(InsideContextMenuProperty, value);
		}

		/// <summary>
		/// Closes all opened menus.
		/// </summary>
		internal override void CloseAll()
		{
			if (!this.StaysOpen || !this.IsOpen)
			{
				base.CloseAll();
				this.IsOpen = false;
			}
		}

        internal override void ForceCloseAll()
        {
            this.IsOpen = false;
        }



        /// <summary>
        /// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
        /// </summary>
        /// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            this.SetDefaultStyleKey();
        }


		/// <summary>
		/// Invoked when keyboard key is pressed while the element has focus.
		/// </summary>
		/// <param name="e">The KeyEventArgs that contains the event data.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled && this.IsOpen)
			{
				switch (e.Key)
				{
					case Key.Up:
						if (this.CurrentSelection == null)
						{
							e.Handled = this.MenuNavigate(0, -1, false);
						}
						else
						{
							int index = this.ItemContainerGenerator.IndexFromContainer(e.OriginalSource as DependencyObject);
							e.Handled = this.MenuNavigate(index - 1, -1, false);
						}
						return;

					case Key.Right:
						return;

					case Key.Down:
						if (this.CurrentSelection == null)
						{
							e.Handled = this.MenuNavigate(0, 1, false);
						}
						else
						{
							int index = this.ItemContainerGenerator.IndexFromContainer(e.OriginalSource as DependencyObject);
							e.Handled = this.MenuNavigate(index + 1, 1, false);
						}
						return;
				}
			}
		}

		/// <summary>
		/// Called when the Opened event occurs.
		/// </summary>
		protected virtual void OnOpened(RadRoutedEventArgs e)
		{
			this.Focus();
			this.RaiseEvent(e);
		}

		/// <summary>
		/// Called when the Closed event occurs.
		/// </summary>
		protected virtual void OnClosed(RadRoutedEventArgs e)
		{
			this.RaiseEvent(e);
		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			RadContextMenu.SetInsideContextMenu(element, true);
		}

		/// <summary>
		/// When overridden in a derived class, undoes the effects of the <see cref="M:System.Windows.Controls.ItemsControl.PrepareContainerForItemOverride(System.Windows.DependencyObject,System.Object)"/> method.
		/// </summary>
		/// <param name="element">The container element.</param>
		/// <param name="item">The Item.</param>
		protected override void ClearContainerForItemOverride(DependencyObject element, object item)
		{
			base.ClearContainerForItemOverride(element, item);
			RadContextMenu.SetInsideContextMenu(this, false);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationPeer OnCreateAutomationPeer()
		{
			return new RadContextMenuAutomationPeer(this);
		}


		private static void OnAccessKeyPressed(object sender, AccessKeyPressedEventArgs e)
		{
			e.Scope = sender;
			e.Handled = true;
		}


		private static void OnEventNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadContextMenu menu = d as RadContextMenu;
			menu.RemoveHandler(e.OldValue as string);
			menu.AttachHandler();
		}

		private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			////if (DesignerProperties.GetIsInDesignMode(d))
			////{
			////    return;
			////}
			RadContextMenu menu = (RadContextMenu)d;
			if ((bool)e.NewValue)
			{
				if (menu.rootPopup == null)
				{
					menu.HookupRootPopup();
				}

			}
			else
			{
				menu.CurrentSelection = null;
				menu.RemoveKeyDownHandler();
				menu.CloseAll();

			}
		}

		private void AddKeyDownHandler()
		{
			if (this.elementWithContextMenu != null)
			{
				this.elementWithContextMenu.AddHandler(UIElement.KeyDownEvent, new KeyEventHandler(OnElementWithContextMenuKeyDown), true);
			}
		}

		private void RemoveKeyDownHandler()
		{
			if (this.elementWithContextMenu != null)
			{
				this.elementWithContextMenu.RemoveHandler(UIElement.KeyDownEvent, new KeyEventHandler(OnElementWithContextMenuKeyDown));
			}
		}

		private void OnElementWithContextMenuKeyDown(object sender, KeyEventArgs e)
		{
			this.ClosingMenu();
		}

		private static void CreateRootPopup(Popup popup, UIElement child)
		{
			if (popup == null)
			{
				throw new ArgumentNullException("popup");
			}
			if (child == null)
			{
				throw new ArgumentNullException("child");
			}

			object parent = null;
			FrameworkElement fe = child as FrameworkElement;
			if (fe != null && fe.Parent != null)
			{
				throw new InvalidOperationException(SR.GetString("CreateRootPopup_ChildHasLogicalParent", new object[] { child, parent }));
			}

			parent = VisualTreeHelper.GetParent(child);
			if (parent != null)
			{
				throw new InvalidOperationException(SR.GetString("CreateRootPopup_ChildHasVisualParent", new object[] { child, parent }));
			}

			popup.Child = child;

            popup.AllowsTransparency = true;

            var binding = new Binding("PlacementTarget") { Mode = BindingMode.OneWay, Source = child };
            popup.SetBinding(Popup.PlacementTargetProperty, binding);

            binding = new Binding("VerticalOffset") { Mode = BindingMode.OneWay, Source = child };
            popup.SetBinding(Popup.VerticalOffsetProperty, binding);

            binding = new Binding("HorizontalOffset") { Mode = BindingMode.OneWay, Source = child };
            popup.SetBinding(Popup.HorizontalOffsetProperty, binding);

            binding = new Binding("PlacementRectangle") { Mode = BindingMode.OneWay, Source = child };
            popup.SetBinding(Popup.PlacementRectangleProperty, binding);

            binding = new Binding("Placement") { Mode = BindingMode.OneWay, Source = child };
            popup.SetBinding(Popup.PlacementProperty, binding);

            binding = new Binding("StaysOpen") { Mode = BindingMode.OneWay, Source = child };
            popup.SetBinding(Popup.StaysOpenProperty, binding);

            binding = new Binding("IsOpen") { Mode = BindingMode.TwoWay, Source = child };
            popup.SetBinding(Popup.IsOpenProperty, binding);

		}

		private static void OnContextMenuChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			FrameworkElement element = d as FrameworkElement;
			RadContextMenu oldMenu = e.OldValue as RadContextMenu;
			RadContextMenu newMenu = e.NewValue as RadContextMenu;

			////if (DesignerProperties.GetIsInDesignMode(d))
			////{
			////    return;
			////}

			if (element == null)
			{
				throw new ArgumentNullException("d");
			}

			if (oldMenu != null)
			{

				oldMenu.ClearReferences();
			}

			if (newMenu != null)
			{
				newMenu.CreateReferences(element);

			}
		}

		private static void OnAttachOnHandledEventsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadContextMenu menu = d as RadContextMenu;
			FrameworkElement element = menu.elementWithContextMenu;
			menu.RemoveHandler(menu.EventName);
			menu.AttachHandler();
		}

		private static void OnEventTriggered(object sender, EventArgs e)
		{
			FrameworkElement fe = sender as FrameworkElement;
			if (fe != null)
			{
				RadContextMenu menu = GetContextMenu(fe);
				if (menu != null)
				{
					// this.mousePosition is not updated correctly when using the Left mouse button,
					// so we eventually get it from the event args.
					MouseButtonEventArgs buttonArgs = e as MouseButtonEventArgs;
					if (buttonArgs != null)
					{
						// Handle MouseButtonEventArgs otherwise they will bubble up and can open another context menu.
						if (menu.ModifierKeyPressed)
						{
							buttonArgs.Handled = true;
						}
						menu.mousePosition = buttonArgs.GetPosition(null);
					}
					menu.TriggerEventFired();
				}
			}
		}

		private void TriggerEventFired()
		{
			this.IsOpen = false;
			if (this.ModifierKeyPressed)
			{
				this.IsOpen = true;
			}
		}

		private void CreateReferences(FrameworkElement element)
		{
			this.elementWithContextMenu = element;
			this.elementWithContextMenu.MouseMove += new MouseEventHandler(this.ElementWithContextMenuMouseMove);

			this.AttachHandler();
		}

		private void ClearReferences()
		{

			if (this.rootPopup != null)
			{
				this.rootPopup.Child = null;
				this.rootPopup.IsOpen = false;
				this.rootPopup = null;
			}

			this.RemoveHandler(this.EventName);
			this.routedEvent = null;
			this.emittedHandler = null;
			this.trigger = null;
			this.elementWithContextMenu.MouseMove -= new MouseEventHandler(this.ElementWithContextMenuMouseMove);
			this.elementWithContextMenu = null;
			if (this.InheritDataContext)
			{
				this.ClearValue(RadContextMenu.DataContextProperty);
			}
		}

		private void AttachHandler()
		{
			if (this.elementWithContextMenu != null)
			{

				if (!string.IsNullOrEmpty(this.EventName))
				{
					Type elementType = this.elementWithContextMenu.GetType();

					this.routedEvent = GetRoutedEvent(elementType);

					if (this.routedEvent != null)
					{
						this.elementWithContextMenu.AddHandler(this.routedEvent, new RoutedEventHandler(RoutedEventFired), this.AttachOnHandledEvents);
					}
					else
					{
						this.trigger = this.elementWithContextMenu.GetType().GetEvent(this.EventName);
						if (this.trigger == null)
						{
							throw new ArgumentException(this.EventName + " event cannot be found.");
						}
						else
						{
							Debug.Assert(methodInfo != null, "Unexpected null methodInfo");
							this.emittedHandler = Delegate.CreateDelegate(this.trigger.EventHandlerType, methodInfo);
							Debug.Assert(this.emittedHandler != null, "Unexpected null delegate");
							this.trigger.AddEventHandler(this.elementWithContextMenu, this.emittedHandler);
						}
					}
				}
			}
		}

		private RoutedEvent GetRoutedEvent(Type elementType)
		{
			while (elementType != typeof(DependencyObject))
			{
				RoutedEvent[] routedEvents = EventManager.GetRoutedEventsForOwner(elementType);
				if (routedEvents != null)
				{
					foreach (RoutedEvent routEvent in routedEvents)
					{
						if (routEvent.Name == this.EventName)
						{
							return routEvent;
						}
					}
				}

				elementType = elementType.BaseType;
			}

			return null;
		}


		private void OnElementWithContextMenuMouseClick(object sender, MouseButtonEventArgs e)
		{
			RadContextMenu.OnEventTriggered(sender, e);
		}

		private void RoutedEventFired(object sender, RoutedEventArgs e)
		{
			RadContextMenu.OnEventTriggered(sender, e);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "eventName")]
		private void RemoveHandler(string eventName)
		{
			if (this.elementWithContextMenu != null)
			{

				if (this.routedEvent != null)
				{
					this.elementWithContextMenu.RemoveHandler(this.routedEvent, new RoutedEventHandler(RoutedEventFired));
					this.routedEvent = null;
				}
				else if (this.trigger != null && this.emittedHandler != null)
				{
					this.trigger.RemoveEventHandler(this.elementWithContextMenu, this.emittedHandler);
				}
			}
		}

		private void OnPopupWrapperClickedOutsidePopup(object sender, EventArgs e)
		{
			this.ClosingMenu();
		}

		private void ElementWithContextMenuMouseMove(object sender, MouseEventArgs e)
		{

            this.mousePosition = e.GetPosition(ApplicationHelper.RootVisual);

		}

		private void OnPopupOpened(object source, EventArgs e)
		{

            Mouse.Capture(this, CaptureMode.SubTree);

			if (this.CurrentSelection != null)
			{
				this.CurrentSelection = null;
			}

			if (this.InheritDataContext)
			{
				Binding b = new Binding("DataContext");
				b.Source = this.elementWithContextMenu;
				this.SetBinding(FrameworkElement.DataContextProperty, b);
			}
			this.OnOpened(new RadRoutedEventArgs(OpenedEvent, this.elementWithContextMenu));
		}

		private void OnPopupClosed(object source, EventArgs e)
		{
			this.OnClosed(new RadRoutedEventArgs(ClosedEvent, this.elementWithContextMenu));
		}

		private void HookupRootPopup()
		{
			this.rootPopup = new Popup();

            if (this.PlacementTarget == null)
            {
                this.PlacementTarget = this.UIElement;
            }


			this.rootPopup.Opened += this.OnPopupOpened;
			this.rootPopup.Closed += this.OnPopupClosed;

			CreateRootPopup(this.rootPopup, this);
		}

		private void ClosingMenu()
		{
			this.CloseAll();
			this.IsOpen = false;
		}


        private void AddEventToRedirectList(RoutedEvent routedEventInstance)
        {
            this.AddHandler(routedEventInstance, new RoutedEventHandler(this.OnEventFired));
        }

        ////private void RemoveEventFromRedirectList(RoutedEvent routedEvent)
        ////{
        ////    this.RemoveHandler(routedEvent, new RoutedEventHandler(this.OnEventFired));
        ////}

        private void OnEventFired(object sender, RoutedEventArgs args)
        {
            if (this.elementWithContextMenu != null)
            {
                this.elementWithContextMenu.RaiseEvent(args);
            }
        }

	}
}
