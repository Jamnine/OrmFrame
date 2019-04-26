using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

using System.Windows.Data;

using System.Windows.Input;

using System.Windows.Media;

using System.Windows.Threading;
using Orm.Toolkit.Telerik.Windows.Controls.Animation;


namespace Orm.Toolkit.Telerik.Windows.Controls
{


	/// <summary>
	/// Represents a selectable item inside a RadMenu or RadContextMenu.
	/// </summary>
	[TemplateVisualState(Name = "Checked", GroupName = "CheckStateGroup")]
	[TemplateVisualState(Name = "Unchecked", GroupName = "CheckStateGroup")]
	[TemplateVisualState(Name = "HideIcon", GroupName = "CheckStateGroup")]
	[TemplateVisualState(Name = "Highlighted", GroupName = "CommonStateGroup")]
	[TemplateVisualState(Name = "Focused", GroupName = "CommonStateGroup")]
	[TemplatePart(Name = "PART_Popup", Type = typeof(Popup))]
	[DefaultProperty("StaysOpenOnClick")]
	[DefaultEvent("Click")]
	[StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(RadMenuItem))]
	public class RadMenuItem : HeaderedItemsControl, ICommandSource
	{
		/// <summary>
		/// Identifies the IconTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty IconTemplateProperty =
			DependencyProperty.Register("IconTemplate", typeof(DataTemplate), typeof(RadMenuItem), null);

		/// <summary>
		/// Identifies the CommandParameter dependency property.
		/// </summary>
		public static readonly DependencyProperty CommandParameterProperty =
			DependencyProperty.Register("CommandParameter", typeof(object), typeof(RadMenuItem), new PropertyMetadata(OnCommandParameterChanged));

		/// <summary>
		/// Identifies the Command dependency property.
		/// </summary>
		public static readonly DependencyProperty CommandProperty =
			DependencyProperty.Register("Command", typeof(ICommand), typeof(RadMenuItem), new PropertyMetadata(OnCommandChanged));

		/// <summary>
		/// Identifies the CommandTarget property.
		/// </summary>
		public static readonly DependencyProperty CommandTargetProperty =
			DependencyProperty.Register("CommandTarget", typeof(UIElement), typeof(RadMenuItem), new PropertyMetadata(OnCommandTargetChanged));

		/// <summary>
		/// Identifies the SubmenuHeaderTemplateKey dependency property.
		/// </summary>
		public static readonly DependencyProperty SubmenuHeaderTemplateKeyProperty =
			DependencyProperty.Register("SubmenuHeaderTemplateKey", typeof(ControlTemplate), typeof(RadMenuItem), new PropertyMetadata(OnTemplateChanged));

		/// <summary>
		/// Identifies the SubmenuHeaderTemplateKey dependency property.
		/// </summary>
		public static readonly DependencyProperty SeparatorTemplateKeyProperty =
			DependencyProperty.Register("SeparatorTemplateKey", typeof(ControlTemplate), typeof(RadMenuItem), new PropertyMetadata(OnTemplateChanged));

		/// <summary>
		/// Identifies the SubmenuItemTemplateKey dependency property.
		/// </summary>
		public static readonly DependencyProperty SubmenuItemTemplateKeyProperty =
			DependencyProperty.Register("SubmenuItemTemplateKey", typeof(ControlTemplate), typeof(RadMenuItem), new PropertyMetadata(OnTemplateChanged));

		/// <summary>
		/// Identifies the TopLevelHeaderTemplateKey dependency property.
		/// </summary>
		public static readonly DependencyProperty TopLevelHeaderTemplateKeyProperty =
			DependencyProperty.Register("TopLevelHeaderTemplateKey", typeof(ControlTemplate), typeof(RadMenuItem), new PropertyMetadata(OnTemplateChanged));

		/// <summary>
		/// Identifies the TopLevelItemTemplateKey dependency property.
		/// </summary>
		public static readonly DependencyProperty TopLevelItemTemplateKeyProperty =
			DependencyProperty.Register("TopLevelItemTemplateKey", typeof(ControlTemplate), typeof(RadMenuItem), new PropertyMetadata(OnTemplateChanged));

		/// <summary>
		/// Identifies the Icon dependency property.
		/// </summary>
		public static readonly DependencyProperty IconProperty =
			DependencyProperty.Register("Icon",
			typeof(object),
			typeof(RadMenuItem),
			new System.Windows.PropertyMetadata(null, RadMenuItem.OnIconChanged));

		/// <summary>
		/// Identifies the IsCheckable dependency property.
		/// </summary>
		public static readonly DependencyProperty IsCheckableProperty =
			DependencyProperty.Register("IsCheckable",
			typeof(bool),
			typeof(RadMenuItem),
			new System.Windows.PropertyMetadata(false, RadMenuItem.OnIsCheckableChanged));

		/// <summary>
		/// Identifies the IsChecked dependency property.
		/// </summary>
		public static readonly DependencyProperty IsCheckedProperty =
			DependencyProperty.Register("IsChecked",
			typeof(bool),
			typeof(RadMenuItem),
			new System.Windows.PropertyMetadata(false, RadMenuItem.OnIsCheckedChanged));

		/// <summary>
		/// Identifies the IsHighlighted dependency property.
		/// </summary>
		public static readonly DependencyProperty IsHighlightedProperty;

		/// <summary>
		/// Identifies the IsSubmenuOpen dependency property.
		/// </summary>
		public static readonly DependencyProperty IsSubmenuOpenProperty;

		/// <summary>
		/// Identifies the Role dependency property.
		/// </summary>
		public static readonly DependencyProperty RoleProperty;

		/// <summary>
		/// Identifies the Menu readonly dependency property.
		/// </summary>
		public static readonly DependencyProperty MenuProperty;

		/// <summary>
		/// Identifies the StaysOpenOnClick dependency property.
		/// </summary>
		public static readonly DependencyProperty StaysOpenOnClickProperty =
			DependencyProperty.Register("StaysOpenOnClick",
			typeof(bool),
			typeof(RadMenuItem),
			new PropertyMetadata(false));

		/// <summary>
		/// Identifies the IsSeparatorProperty dependency property.
		/// </summary>
		public static readonly DependencyProperty IsSeparatorProperty =
			DependencyProperty.Register("IsSeparator", typeof(bool), typeof(RadMenuItem), new FrameworkPropertyMetadata(false, OnIsSeparatorChanged));

		/// <summary>
		/// Identifies the Checked routed event.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly RoutedEvent CheckedEvent =
			EventManager.RegisterRoutedEvent("Checked",
			RoutingStrategy.Bubble,
			typeof(RoutedEventHandler),
			typeof(RadMenuItem));

		/// <summary>
		/// Identifies the Click routed event.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly RoutedEvent ClickEvent =
			EventManager.RegisterRoutedEvent("Click",
			RoutingStrategy.Bubble,
			typeof(RadRoutedEventHandler),
			typeof(RadMenuItem));

		/// <summary>
		/// Identifies the SubmenuClosed routed event.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly RoutedEvent SubmenuClosedEvent =
			EventManager.RegisterRoutedEvent("SubmenuClosed",
			RoutingStrategy.Bubble,
			typeof(RadRoutedEventHandler),
			typeof(RadMenuItem));

		/// <summary>
		/// Identifies the SubmenuOpened routed event.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly RoutedEvent SubmenuOpenedEvent =
			EventManager.RegisterRoutedEvent("SubmenuOpened",
			RoutingStrategy.Bubble,
			typeof(RadRoutedEventHandler),
			typeof(RadMenuItem));

		/// <summary>
		/// Identifies the Unchecked routed event.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly RoutedEvent UncheckedEvent =
			EventManager.RegisterRoutedEvent("Unchecked",
			RoutingStrategy.Bubble,
			typeof(RoutedEventHandler),
			typeof(RadMenuItem));

		/// <summary>
		/// Identifies the IsSelected dependency property.
		/// </summary>
		internal static readonly DependencyProperty IsSelectedProperty =
			DependencyProperty.Register("IsSelected",
			typeof(bool),
			typeof(RadMenuItem),
			new System.Windows.PropertyMetadata(false, RadMenuItem.OnIsSelectedChanged));

		/// <summary>
		/// Identifies the MenuPropertyKey dependency property.
		/// </summary>
		private static readonly DependencyPropertyKey MenuPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("Menu",
			typeof(MenuBase),
			typeof(RadMenuItem),
			null);

		/// <summary>
		/// Identifies the RoleKey dependency property.
		/// </summary>
		private static readonly DependencyPropertyKey RolePropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("Role",
			typeof(MenuItemRole),
			typeof(RadMenuItem),
			new PropertyMetadata(MenuItemRole.SubmenuItem, RadMenuItem.OnRoleChanged));

		/// <summary>
		/// Identifies the IsSubmenuOpen dependency property.
		/// </summary>
		private static readonly DependencyPropertyKey IsSubmenuOpenPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsSubmenuOpen",
			typeof(bool),
			typeof(RadMenuItem),
			new PropertyMetadata(false, RadMenuItem.OnIsSubmenuOpenChanged));

		/// <summary>
		/// Identifies the IsHighlighted dependency property.
		/// </summary>
		private static readonly DependencyPropertyKey IsHighlightedPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsHighlighted",
			typeof(bool),
			typeof(RadMenuItem),
			new PropertyMetadata(false, RadMenuItem.OnIsHighlighted));

		private static readonly DependencyProperty OrientationProperty =
			DependencyProperty.Register("Orientation", typeof(Orientation), typeof(RadMenuItem), new PropertyMetadata(Orientation.Horizontal, RadMenuItem.OnOrientationChanged));

		private DispatcherTimer closeTimer;
		private DispatcherTimer openTimer;
		private RadMenuItem currentSelection;
		private RadMenuItem lastSubMenuHeaderSelected;
		private Popup submenuPopup;


		static RadMenuItem()
		{
			EventManager.RegisterClassHandler(typeof(RadMenuItem),
				MenuBase.IsSelectedChangedEvent,
				new RadRoutedPropertyChangedEventHandler<bool>(RadMenuItem.OnIsSelectedChanged));

			RoleProperty = RolePropertyKey.DependencyProperty;
			IsSubmenuOpenProperty = IsSubmenuOpenPropertyKey.DependencyProperty;
			IsHighlightedProperty = IsHighlightedPropertyKey.DependencyProperty;
			MenuProperty = MenuPropertyKey.DependencyProperty;

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadMenuItem),
            //  new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadMenuItem))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadMenuItem),
              new FrameworkPropertyMetadata(typeof(RadMenuItem)));

			EventManager.RegisterClassHandler(typeof(RadMenuItem), AccessKeyManager.AccessKeyPressedEvent, new AccessKeyPressedEventHandler(RadMenuItem.OnAccessKeyPressed));

			Control.ForegroundProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(SystemColors.MenuTextBrush));
			Control.FontFamilyProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(SystemFonts.MessageFontFamily));
			Control.FontSizeProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(SystemFonts.MessageFontSize));
			Control.FontStyleProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(SystemFonts.MessageFontStyle));
			Control.FontWeightProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(SystemFonts.MessageFontWeight));
			ToolTipService.IsEnabledProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(null, new CoerceValueCallback(RadMenuItem.CoerceToolTipIsEnabled)));

			KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(KeyboardNavigationMode.None));
			FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(null));
			InputMethod.IsInputMethodSuspendedProperty.OverrideMetadata(typeof(RadMenuItem), new FrameworkPropertyMetadata(BooleanBoxes.TrueBox, FrameworkPropertyMetadataOptions.Inherits));

		}

		/// <summary>
		/// Initializes a new instance of the RadMenuItem class without menu text or a value.
		/// </summary>
		public RadMenuItem()
		{
			DefaultStyleKey = typeof(RadMenuItem);
			this.Loaded += new RoutedEventHandler(this.OnLoaded);


		}

		/// <summary>
		/// Occurs when a RadMenuItem is checked.
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public event RoutedEventHandler Checked
		{
			add
			{
				this.AddHandler(CheckedEvent, value);
			}
			remove
			{
				this.RemoveHandler(CheckedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when a RadMenuItem is clicked.
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public event RadRoutedEventHandler Click
		{
			add
			{
				this.AddHandler(ClickEvent, value);
			}
			remove
			{
				this.RemoveHandler(ClickEvent, value);
			}
		}

		/// <summary>
		/// Occurs when the state of the IsSubmenuOpen property changes to false.
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public event RadRoutedEventHandler SubmenuClosed
		{
			add
			{
				this.AddHandler(SubmenuClosedEvent, value);
			}
			remove
			{
				this.RemoveHandler(SubmenuClosedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when the state of the IsSubmenuOpen property changes to true.
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public event RadRoutedEventHandler SubmenuOpened
		{
			add
			{
				this.AddHandler(SubmenuOpenedEvent, value);
			}
			remove
			{
				this.RemoveHandler(SubmenuOpenedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when a RadMenuItem is unchecked.
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public event RoutedEventHandler Unchecked
		{
			add
			{
				this.AddHandler(UncheckedEvent, value);
			}
			remove
			{
				this.RemoveHandler(UncheckedEvent, value);
			}
		}

		/// <summary>
		/// Gets or sets the icon that appears in a RadMenuItem. This is a dependency property. 
		/// </summary>
		[SRCategory(RadCategory.Appearance)]
		[TypeConverter(typeof(ImageConverter))]
		public object Icon
		{
			get
			{
				return this.GetValue(IconProperty);
			}
			set
			{
				this.SetValue(IconProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the data template used for Icon. This is a dependency property.
		/// </summary>
		public DataTemplate IconTemplate
		{
			get
			{
				return (DataTemplate)this.GetValue(IconTemplateProperty);
			}
			set
			{
				this.SetValue(IconTemplateProperty, value);
			}
		}

		/// <summary>
		/// Gets the RadMenu for this RadMenuItem. This is a readonly dependency property. 
		/// </summary>
		public MenuBase Menu
		{
			get
			{
				return (MenuBase)this.GetValue(MenuProperty);
			}
			internal set
			{
				this.SetValue(MenuPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets a value that indicates whether a RadMenuItem can be checked. This is a dependency property. 
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public bool IsCheckable
		{
			get
			{
				return (bool)this.GetValue(IsCheckableProperty);
			}
			set
			{
				this.SetValue(IsCheckableProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value that indicates whether the RadMenuItem is checked. This is a dependency property.
		/// </summary>
		[SRCategory(RadCategory.Appearance)]
		public bool IsChecked
		{
			get
			{
				return (bool)this.GetValue(IsCheckedProperty);
			}
			set
			{
				this.SetValue(IsCheckedProperty, value);
			}
		}

		/// <summary>
		/// Gets a value that indicates whether a RadMenuItem is highlighted. This is a dependency property. 
		/// </summary>
		[Browsable(false), SRCategory(RadCategory.Appearance)]
		public bool IsHighlighted
		{
			get
			{
				return (bool)this.GetValue(IsHighlightedProperty);
			}
			protected set
			{
				this.SetValue(IsHighlightedPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets a value that indicates whether the submenu of the RadMenuItem is open. This is a dependency property.
		/// </summary>
		[Browsable(false), SRCategory(RadCategory.Appearance)]
		public bool IsSubmenuOpen
		{
			get
			{
				return (bool)this.GetValue(IsSubmenuOpenProperty);
			}
			internal set
			{
				this.SetValue(IsSubmenuOpenPropertyKey, BooleanBoxes.Box(value));
			}
		}

		/// <summary>
		/// Gets a value that indicates the role of a RadMenuItem. This is a dependency property. 
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public MenuItemRole Role
		{
			get
			{
				return (MenuItemRole)this.GetValue(RoleProperty);
			}
			private set
			{
				this.SetValue(RolePropertyKey, value);
			}
		}

		/// <summary>
		/// Gets or sets a value that indicates that the submenu in which this RadMenuItem is located should not close when this item is clicked. This is a dependency property. 
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public bool StaysOpenOnClick
		{
			get
			{
				return (bool)this.GetValue(StaysOpenOnClickProperty);
			}
			set
			{
				this.SetValue(StaysOpenOnClickProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is a separator.
		/// </summary>
		public bool IsSeparator
		{
			get { return (bool)GetValue(IsSeparatorProperty); }
			set { SetValue(IsSeparatorProperty, value); }
		}

		/// <summary>
		/// Gets the resource key for a style applied to a RadMenuItem when the RadMenuItem is a header of a submenu.
		/// </summary>
		public ControlTemplate SubmenuHeaderTemplateKey
		{
			get { return (ControlTemplate)GetValue(SubmenuHeaderTemplateKeyProperty); }
			set { SetValue(SubmenuHeaderTemplateKeyProperty, value); }
		}

		/// <summary>
		/// Gets the resource key for a style applied to a RadMenuItem when the RadMenuItem is a separator.
		/// </summary>
		public ControlTemplate SeparatorTemplateKey
		{
			get { return (ControlTemplate)GetValue(SeparatorTemplateKeyProperty); }
			set { SetValue(SeparatorTemplateKeyProperty, value); }
		}

		/// <summary>
		/// Gets the resource key for a style applied to a RadMenuItem when the RadMenuItem is a submenu.
		/// </summary>
		public ControlTemplate SubmenuItemTemplateKey
		{
			get { return (ControlTemplate)GetValue(SubmenuItemTemplateKeyProperty); }
			set { SetValue(SubmenuItemTemplateKeyProperty, value); }
		}

		/// <summary>
		/// Gets the resource key for a style applied to a RadMenuItem when the RadMenuItem is a header of a top-level menu.
		/// </summary>
		public ControlTemplate TopLevelHeaderTemplateKey
		{
			get { return (ControlTemplate)GetValue(TopLevelHeaderTemplateKeyProperty); }
			set { SetValue(TopLevelHeaderTemplateKeyProperty, value); }
		}

		/// <summary>
		/// Gets the resource key for a style applied to a RadMenuItem when it is a top-level RadMenuItem.
		/// </summary>
		public ControlTemplate TopLevelItemTemplateKey
		{
			get { return (ControlTemplate)GetValue(TopLevelItemTemplateKeyProperty); }
			set { SetValue(TopLevelItemTemplateKeyProperty, value); }
		}

		/// <summary>
		/// Gets the command that will be executed when the command source is invoked.
		/// </summary>
		[TypeConverter(typeof(CommandConverter))]
		public ICommand Command
		{
			get
			{
				return (ICommand)this.GetValue(CommandProperty);
			}
			set
			{
				this.SetValue(CommandProperty, value);
			}
		}

		/// <summary>
		/// Represents a user defined data value that can be passed to the command when it is executed.
		/// </summary>
		public object CommandParameter
		{
			get
			{
				return this.GetValue(CommandParameterProperty);
			}
			set
			{
				this.SetValue(CommandParameterProperty, value);
			}
		}

		/// <summary>
		/// The object that the command is being executed on.
		/// </summary>
		public IInputElement CommandTarget
		{
			get
			{
				return (IInputElement)this.GetValue(CommandTargetProperty);
			}
			set
			{
				this.SetValue(CommandTargetProperty, value);
			}
		}

		internal bool InsideContextMenu
		{
			get
			{
				return RadContextMenu.GetInsideContextMenu(this);
			}
		}

		internal bool IsSelected
		{
			get
			{
				return (bool)this.GetValue(IsSelectedProperty);
			}
			set
			{
				this.SetValue(IsSelectedProperty, value);
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
				if (this.currentSelection != value)
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
		}

		internal RadMenuItem ParentItem
		{
			get
			{
				return ItemsControl.ItemsControlFromItemContainer(this) as RadMenuItem;
			}
		}

		internal bool IsTopHeader
		{
			get
			{
				return this.Role == MenuItemRole.TopLevelHeader;
			}
		}
		internal bool IsTopItem
		{
			get
			{
				return this.Role == MenuItemRole.TopLevelItem;
			}
		}
		internal bool IsSubHeader
		{
			get
			{
				return this.Role == MenuItemRole.SubmenuHeader;
			}
		}
		internal bool IsSubItem
		{
			get
			{
				return this.Role == MenuItemRole.SubmenuItem;
			}
		}

		private bool MouseOverPopup
		{
			get
			{
				if (this.Menu != null)
				{
					return this.Menu.MouseOverPopup;
				}
				else
				{
					return false;
				}
			}
		}

		private bool ClickToOpen
		{
			get
			{
				MenuBase menu = this.Menu;
				if (menu != null)
				{
					return menu.ClickToOpen;
				}

				return false;
			}
		}

		private bool MenuIsSelected
		{
			get
			{
				RadMenu menu = this.Menu as RadMenu;
				if (menu != null)
				{
					return menu.CurrentSelection != null && menu.CurrentSelection != this;
				}
				return false;
			}
		}

		/// <summary>
		/// Gets or sets the time, in milliseconds, before displaying menu when the mouse cursor is over a submenu item.
		/// </summary>
		private Duration ShowDelay
		{
			get
			{
				if (this.Menu != null)
				{
					return this.Menu.ShowDelay;
				}

				return new Duration(TimeSpan.FromMilliseconds(150));
			}
		}

		/// <summary>
		/// Gets or sets the time, in milliseconds, before closing menu when the mouse cursor leave a submenu item.
		/// </summary>
		private Duration HideDelay
		{
			get
			{
				if (this.Menu != null)
				{
					return this.Menu.HideDelay;
				}

				return new Duration(TimeSpan.FromMilliseconds(250));
			}
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.InitializeComponent();

			if (this.IsSelected)
			{
				this.FocusOrSelect();
			}
			this.ChangeVisualState(true);


			bool isAnimationEnabled = !System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted;
			AnimationManager.SetIsAnimationEnabled(this, isAnimationEnabled);

		}

		/// <summary>
		/// Resets the theme.
		/// </summary>
		public void ResetTheme()
		{
			this.SetDefaultStyleKey();
		}

		internal void FocusOrSelect()
		{
			this.Focus();
			if (!this.IsSelected)
			{
				this.IsSelected = true;
			}
			if (this.IsSelected && !this.IsHighlighted)
			{
				this.IsHighlighted = true;
			}
		}

		internal void OpenSubmenuWithKeyboard()
		{
			if (this.ItemContainerGenerator.Status == GeneratorStatus.NotStarted)
			{
				this.ItemContainerGenerator.StatusChanged += new EventHandler(this.OnItemContainerGeneratorStatusChanged);
			}
			else if (this.ItemContainerGenerator.Status == GeneratorStatus.ContainersGenerated
				&& !this.IsSubmenuOpen)
			{
				this.SubmenuOpened += new RadRoutedEventHandler(this.OnSubmenuOpened);
			}

			if (this.IsSubmenuOpen)
			{
				this.NavigateToIndex(0, 1);
			}
			else
			{
				this.OpenMenu();
			}
		}

		internal void OpenMenu()
		{
			if (!this.IsTopHeader && !this.IsSubHeader)
			{
				return;
			}

			bool hasParent = this.ParentItem != null;
			if (this.IsSubHeader && hasParent)
			{
				if (this.ParentItem.lastSubMenuHeaderSelected != null &&
					this.ParentItem.lastSubMenuHeaderSelected != this)
				{
					this.ParentItem.lastSubMenuHeaderSelected.CloseMenu();
					this.ParentItem.lastSubMenuHeaderSelected.IsSelected = false;
					this.ParentItem.lastSubMenuHeaderSelected = null;
				}
			}
			if (!hasParent && this.MenuIsSelected)
			{
				this.Menu.CurrentSelection.CloseMenu();
				this.Menu.CurrentSelection.IsSelected = false;
			}

			if ((hasParent && this.ParentItem.IsSubmenuOpen)
				|| this.IsTopHeader
				|| (!hasParent && this.InsideContextMenu))
			{
				this.FocusOrSelect();
				if (!this.IsSubmenuOpen)
				{
					this.IsSubmenuOpen = true;
				}
				if (hasParent)
				{
					this.ParentItem.lastSubMenuHeaderSelected = this;
				}
			}
		}

		internal void CloseMenu()
		{
			if (this.lastSubMenuHeaderSelected != null)
			{
				this.lastSubMenuHeaderSelected.CloseMenu();
				this.lastSubMenuHeaderSelected = null;
			}

			this.StopOpenTimer();
			this.StopCloseTimer();

			if (this.IsSubmenuOpen)
			{
				this.IsSubmenuOpen = false;
			}
		}

		internal bool ProcessKey(Key key)
		{
			bool handled = false;
			MenuItemRole role = this.Role;

			if (this.FlowDirection == FlowDirection.RightToLeft)
			{
				switch (key)
				{
					case Key.Right:
						key = Key.Left;
						break;

					case Key.Left:
						key = Key.Right;
						break;
				}
			}

			switch (key)
			{
				case Key.Escape:
					handled = this.HandleEscapeKey();
					break;

				case Key.Left:
					handled = this.HandleLeftKey();
					break;

				case Key.Up:
					handled = this.HandleUpKey(role);
					break;

				case Key.Right:
					handled = this.HandleRightKey(role);
					break;

				case Key.Down:
					handled = this.HandleDownKey(role);
					break;

				case Key.Enter:
					handled = this.HandleEnterKey(role);
					break;
			}
			if (!handled)
			{
				handled = this.MenuItemNavigate(key);
			}
			if (handled)
			{
				this.ChangeVisualState(true);
			}

			return handled;
		}

		internal void HandleMouseDown()
		{
			MenuItemRole role = this.Role;
			switch (role)
			{
				case MenuItemRole.TopLevelHeader:
				case MenuItemRole.SubmenuHeader:
					this.ClickHeader(role);
					break;
			}

			this.ChangeVisualState(true);
		}

		internal void HandleMouseLeave()
		{

			MenuItemRole role = this.Role;

			if (role == MenuItemRole.TopLevelHeader)
			{
				if (!this.IsSubmenuOpen)
				{
					this.UnSelectOrUnHighlight();
				}
				else
				{
					if (!this.ClickToOpen)
					{
						this.CloseSubMenu();
					}
				}
			}
			else if (role == MenuItemRole.TopLevelItem)
			{
				if (!this.ClickToOpen)
				{
					this.UnSelectOrUnHighlight();
				}
				else if (!this.MenuIsSelected)
				{
					this.IsHighlighted = false;
				}
			}
			else if (role == MenuItemRole.SubmenuItem)
			{
				this.UnSelectOrUnHighlight();
			}
			else if (role == MenuItemRole.SubmenuHeader)
			{
				if (!this.IsSubmenuOpen)
				{
					this.UnSelectOrUnHighlight();
				}
				else
				{
					if (this.ClickToOpen) return;
					this.CloseSubMenu();
				}
			}

			if (role == MenuItemRole.TopLevelHeader || role == MenuItemRole.TopLevelItem)
			{
				this.StopOpenTimer();
				this.IsHighlighted = false;
				this.ChangeVisualState(true);
			}
		}

		internal void HandleMouseEnter()
		{

			this.IsHighlighted = true;

			switch (this.Role)
			{
				case MenuItemRole.TopLevelItem:
				case MenuItemRole.TopLevelHeader:
					if (!this.ClickToOpen || this.MenuIsSelected)
					{
						this.OpenSubMenu();
					}
					break;
				case MenuItemRole.SubmenuHeader:
				case MenuItemRole.SubmenuItem:
					this.OpenSubMenu();
					break;
			}

			this.ChangeVisualState(true);
		}

		internal void HandleMouseUp()
		{
			switch (this.Role)
			{
				case MenuItemRole.TopLevelHeader:
				case MenuItemRole.SubmenuHeader:
					if (this.Menu.NotifyOnHeaderClick)
					{
						goto case MenuItemRole.TopLevelItem;
					}
					break;
				case MenuItemRole.TopLevelItem:
				case MenuItemRole.SubmenuItem:
					this.ClickItem();
					this.ChangeVisualState(true);
					break;
			}
		}

		internal void OnClickImpl()
		{
			this.FocusOrSelect();

			if (this.IsCheckable)
			{
				this.IsChecked = !this.IsChecked;
			}

			this.RaiseEvent(new RadRoutedEventArgs(ClickEvent, this));
			this.ExecuteCommand();

			MenuBase menu = this.Menu;

			if (!this.StaysOpenOnClick && (this.Role == MenuItemRole.SubmenuItem || this.Role == MenuItemRole.TopLevelItem))
			{

				this.IsHighlighted = false;
				this.ChangeVisualState(true);

				if (menu != null)
				{
					menu.CloseAll();
				}
			}

			if (AutomationPeer.ListenerExists(AutomationEvents.InvokePatternOnInvoked))
			{
				AutomationPeer peer = FrameworkElementAutomationPeer.CreatePeerForElement(this);
				if (peer != null)
				{
					peer.RaiseAutomationEvent(AutomationEvents.InvokePatternOnInvoked);
				}
			}
		}

		internal void UpdateRole()
		{
			MenuItemRole role;
			RadMenu parentMenu = ItemsControl.ItemsControlFromItemContainer(this) as RadMenu;

			if (this.IsSeparator)
			{
				role = MenuItemRole.Separator;
			}
			else
			{
				if (!this.IsCheckable && this.HasItems)
				{
					if (parentMenu != null)
					{
						role = MenuItemRole.TopLevelHeader;
					}
					else
					{
						role = MenuItemRole.SubmenuHeader;
					}
				}
				else if (parentMenu != null)
				{
					role = MenuItemRole.TopLevelItem;
				}
				else
				{
					role = MenuItemRole.SubmenuItem;
				}
			}

			if (role != this.Role)
			{
				this.ChangeTemplate(role);

				this.ChangeVisualState(true);

			}
		}

		/// <summary>
		/// Invoked when an unhandled Keyboard.GotKeyboardFocus attached event reaches an element in its route that is derived from this class.
		/// </summary>
		/// <param name="e">The KeyboardFocusChangedEventArgs that contains the event data.</param>
		protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
		{
			base.OnGotKeyboardFocus(e);
			if (!e.Handled && (e.NewFocus == this))
			{
				this.IsSelected = true;
			}
		}


		/// <summary>
		/// Updates the visual state of the control.
		/// </summary>
		/// <param name="useTransitions">Indicates whether transitions should be used.</param>

		protected internal virtual void ChangeVisualState(bool useTransitions)

		{
			if (this.IsHighlighted || this.IsSubmenuOpen)
			{
				this.GoToState(useTransitions, new string[] { "Highlighted", "Normal" });
			}
			else
			{
				this.GoToState(useTransitions, "Normal");
			}

			if (this.IsChecked)
			{
				this.GoToState(useTransitions, new string[] { "Checked", "Normal" });
			}
			else if (this.Icon == null)
			{
				this.GoToState(useTransitions, new string[] { "HideIcon", "Normal" });
			}
			else
			{
				this.GoToState(useTransitions, "Unchecked");
			}

			if (this.IsSelected && this.IsEnabled)
			{
				this.GoToState(useTransitions, new string[] { "Focused", "Unfocused" });
			}
			else
			{
				this.GoToState(useTransitions, new string[] { "Unfocused" });
			}

			if (!this.IsEnabled)
			{
				this.GoToState(useTransitions, new string[] { "Disabled", "Normal" });
			}
		}

		/// <summary>
		/// Raises the <see cref="E:MouseLeftButtonUp"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
		protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (!e.Handled)
			{
				this.HandleMouseUp();
				e.Handled = true;
			}
		}

		/// <summary>
		/// Raises the <see cref="E:MouseLeftButtonDown"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!e.Handled)
			{
				this.HandleMouseDown();
				e.Handled = true;
			}
		}

		/// <summary>
		/// Handles MouseRightButtonUp event.
		/// </summary>
		/// <param name="e">The MouseButtonEventArgs that contains the event data. The event data reports that the right mouse button was released.</param>
		protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
		{
			if (!e.Handled)
			{
				this.HandleMouseUp();
				e.Handled = true;
			}
			base.OnMouseRightButtonUp(e);
		}

		/// <summary>
		/// Handles MouseRightButtonDown event.
		/// </summary>
		/// <param name="e">The MouseButtonEventArgs that contains the event data. The event data reports that the right mouse button was pressed.</param>
		protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
		{
			if (!e.Handled)
			{
				this.HandleMouseDown();
				e.Handled = true;
			}
			base.OnMouseRightButtonDown(e);
		}


		/// <summary>
		/// Raises the <see cref="E:MouseEnter"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.Windows.Input.MouseEventArgs"/> instance containing the event data.</param>
		protected override void OnMouseEnter(MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.HandleMouseEnter();
		}

		/// <summary>
		/// Raises the <see cref="E:MouseLeave"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.Windows.Input.MouseEventArgs"/> instance containing the event data.</param>
		protected override void OnMouseLeave(MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.HandleMouseLeave();
		}

		/// <summary>
		/// Raises the <see cref="E:KeyDown"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.Windows.Input.KeyEventArgs"/> instance containing the event data.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled)
			{
				e.Handled = this.ProcessKey(e.Key);
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
				menuItem.Menu = this.Menu;
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
		/// Invoked when the <see cref="P:System.Windows.Controls.ItemsControl.Items"/> property changes.
		/// </summary>
		/// <param name="e">Information about the change.</param>
		protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			if (this.IsLoaded || (this.ReadLocalValue(RoleProperty) != DependencyProperty.UnsetValue))
			{
				this.UpdateRole();
			}
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
		/// Called when the IsChecked property becomes true.
		/// </summary>
		/// <param name="e">The event data for the Checked event.</param>

		protected virtual void OnChecked(RoutedEventArgs e)
		{
			this.RaiseEvent(e);
		}

		/// <summary>
		/// Called when the IsChecked property becomes false.
		/// </summary>
		/// <param name="e">The event data for the Unchecked event.</param>

		protected virtual void OnUnchecked(RoutedEventArgs e)
		{
			this.RaiseEvent(e);
		}

		/// <summary>
		/// Provides class handling for when an access key that is meaningful for this
		/// element is invoked.
		/// </summary>
		/// <param name="e">The event data to the access key event. The event data reports which key
		/// was invoked, and indicate whether the System.Windows.Input.AccessKeyManager
		/// object that controls the sending of these events also sent this access key
		/// invocation to other elements.
		/// </param>
		protected override void OnAccessKey(AccessKeyEventArgs e)
		{
			base.OnAccessKey(e);
			if (!e.IsMultiple)
			{
				switch (this.Role)
				{
					case MenuItemRole.TopLevelItem:
					case MenuItemRole.SubmenuItem:
						this.ClickItem();
						return;

					case MenuItemRole.TopLevelHeader:
					case MenuItemRole.SubmenuHeader:
						this.OpenSubmenuWithKeyboard();
						this.ClickItem();
						return;

					default:
						return;
				}
			}
		}


		/// <summary>
		/// Called when a RadMenuItem is clicked and raises a Click event.
		/// </summary>
		protected virtual void OnClick()
		{
			this.OnClickImpl();
		}

		/// <summary>
		/// Called when the submenu of a RadMenuItem is closed.
		/// </summary>
		/// <param name="e">The event data for the SubmenuClosed event.</param>
		protected virtual void OnSubmenuClosed(RadRoutedEventArgs e)
		{
			this.RaiseEvent(e);
		}

		/// <summary>
		/// Called when the submenu of a RadMenuItem is opened. 
		/// </summary>
		/// <param name="e">The event data for the SubmenuOpened event.</param>
		protected virtual void OnSubmenuOpened(RadRoutedEventArgs e)
		{
			this.RaiseEvent(e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationPeer OnCreateAutomationPeer()
		{
			return new RadMenuItemAutomationPeer(this);
		}

		private static void OnIsSeparatorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem item = d as RadMenuItem;
			if (item != null)
			{
				item.IsTabStop = !(bool)e.NewValue;
			}
		}

		private static void OnOrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem radMenuItem = d as RadMenuItem;

			if (radMenuItem != null && radMenuItem.submenuPopup != null)
			{
				radMenuItem.submenuPopup.Placement = ((Orientation)e.NewValue == Orientation.Horizontal)
					? System.Windows.Controls.Primitives.PlacementMode.Bottom
					: System.Windows.Controls.Primitives.PlacementMode.Right;
			}

		}

		private static void OnCommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem menuItem = d as RadMenuItem;
			if (menuItem != null)
			{
				menuItem.CanExecuteApply();
			}
		}

		private static void OnCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem menuItem = d as RadMenuItem;
			if (menuItem != null)
			{
				menuItem.ChangeCommand((ICommand)e.OldValue, (ICommand)e.NewValue);
			}
		}

		private static void OnCommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem menuItem = d as RadMenuItem;
			if (menuItem != null)
			{
				menuItem.CanExecuteApply();
			}
		}

		private static void OnTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{

		}

		private static bool IsMouseOverParent(RadMenuItem item)
		{
			RadMenuItem currentItem = item;
			while (currentItem != null)
			{
				if (currentItem.IsMouseOver)
				{
					return true;
				}
				else
				{
					currentItem = currentItem.ParentItem;
				}
			}

			return false;
		}

		private static void OnIsSelectedChanged(object sender, RadRoutedPropertyChangedEventArgs<bool> e)
		{
			RadMenuItem item = (RadMenuItem)sender;
			RadMenuItem originalSource = e.OriginalSource as RadMenuItem;
			if (sender != e.OriginalSource)
			{
				if (originalSource != null)
				{
					if (e.NewValue)
					{
						if (item.CurrentSelection == originalSource)
						{
							item.StopCloseTimer();
						}
						if ((item.CurrentSelection != originalSource) && (originalSource.ParentItem == item))
						{
							if (item.CurrentSelection != null)
							{
								item.CurrentSelection.CloseSubMenu();
							}

							item.CurrentSelection = originalSource;
							item.CurrentSelection.StopCloseTimer();
							item.StopCloseTimer();
							RadMenuItem parentMenuItem = item.ParentItem;
							if (parentMenuItem != null)
							{
								parentMenuItem.StopCloseTimer();
							}
							if (!item.IsSelected)
							{
								item.IsSelected = true;
							}
						}
					}
					else if (item.CurrentSelection == originalSource)
					{
						item.CurrentSelection = null;
						RadMenuItem parentItem = item.ParentItem;
						if (parentItem != null && !parentItem.IsSelected)
						{
							item.CloseMenu();
						}
						else
						{
							if (!item.ClickToOpen && item.IsSubmenuOpen && !item.IsMouseOver)
							{
								item.CloseSubMenu();
							}
						}
					}

					e.Handled = true;
				}
			}
		}

		private static object GetItemOrContainerFromContainer(DependencyObject container)
		{
			object itemOrContainer = container;
			ItemsControl owner = ItemsControl.ItemsControlFromItemContainer(container) as ItemsControl;

			if (owner != null)
			{
				itemOrContainer = owner.ItemContainerGenerator.ItemFromContainer(container);
			}

			return itemOrContainer;
		}

		private static RadMenuItem GetTopLevelItem(RadMenuItem item)
		{
			RadMenuItem topLevelItem = item;
			while (topLevelItem != null &&
				topLevelItem.Role != MenuItemRole.TopLevelHeader &&
				topLevelItem.Role != MenuItemRole.TopLevelItem)
			{
				topLevelItem = ItemsControl.ItemsControlFromItemContainer(topLevelItem) as RadMenuItem;
			}
			return topLevelItem;
		}

		private static FocusNavigationDirection KeyToTraversalDirection(Key key)
		{
			switch (key)
			{
				case Key.Left:
					return FocusNavigationDirection.Left;

				case Key.Up:
					return FocusNavigationDirection.Up;

				case Key.Right:
					return FocusNavigationDirection.Right;

				case Key.Down:
					return FocusNavigationDirection.Down;
			}
			throw new NotSupportedException();
		}

		private static void OnIsCheckableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem item = d as RadMenuItem;
			if (item.IsLoaded)
			{
				item.UpdateRole();
			}
		}

		private static void OnIsHighlighted(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem item = (RadMenuItem)d;
			item.ChangeVisualState(true);
		}

		private static void OnIsCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem item = (RadMenuItem)d;
			if (item.IsLoaded)
			{
				item.UpdateRole();
			}
			if ((bool)e.NewValue)
			{

				item.OnChecked(new RoutedEventArgs(CheckedEvent, item));

			}
			else
			{

				item.OnUnchecked(new RoutedEventArgs(UncheckedEvent, item));

			}
			item.ChangeVisualState(true);
		}

		private static void OnIsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem item = (RadMenuItem)d;
			bool newValue = (bool)e.NewValue;

			item.IsHighlighted = newValue;
			item.ChangeVisualState(true);

			if ((bool)e.OldValue)
			{
				item.StopOpenTimer();

				if (item.IsSubmenuOpen && (item.IsTopHeader || item.InsideContextMenu))
				{
					item.CloseMenu();
				}
			}
			item.RaiseEvent(new RadRoutedPropertyChangedEventArgs<bool>((bool)e.OldValue, (bool)e.NewValue, MenuBase.IsSelectedChangedEvent));
		}

		private static void OnIsSubmenuOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem menuItem = (RadMenuItem)d;
			menuItem.StopOpenTimer();
			menuItem.StopCloseTimer();

			bool newValue = (bool)e.NewValue;
			bool oldValue = (bool)e.OldValue;

			if (newValue)
			{
				menuItem.IsSelected = true;
				menuItem.CurrentSelection = null;

				EventHandler animateOnPopupOpen = null;
				animateOnPopupOpen = (sender, args) =>
				{
					RunExpandAnimation(menuItem);

					menuItem.submenuPopup.Opened -= animateOnPopupOpen;

				};

				if (!menuItem.submenuPopup.IsOpen)
				{

					menuItem.submenuPopup.Opened += animateOnPopupOpen;

				}
				else
				{
					RunExpandAnimation(menuItem);
				}

				if (menuItem.ClickToOpen)
				{
					Mouse.Capture(menuItem.Menu, CaptureMode.SubTree);
				}

			}
			else
			{
				if (menuItem.CurrentSelection != null)
				{
					menuItem.Focus();
					if (menuItem.CurrentSelection.IsSubmenuOpen)
					{
						menuItem.CurrentSelection.CloseMenu();
					}
				}

				menuItem.CurrentSelection = null;

				if (!menuItem.IsMouseOver)
				{
					menuItem.IsHighlighted = false;
				}

				AnimationManager.StopIfRunning(menuItem, "Expand");
				AnimationManager.Play(menuItem,
					"Collapse",
					new Action(() =>
					{

						// TODO: Hide the popup.

					}));
			}

			menuItem.ChangeVisualState(true);

			RadMenuItemAutomationPeer peer = FrameworkElementAutomationPeer.FromElement(menuItem)
				as RadMenuItemAutomationPeer;
			if (null != peer)
			{
				peer.RaiseExpandCollapseAutomationEvent(oldValue, newValue);
			}
		}

		private static void RunExpandAnimation(RadMenuItem menuItem)
		{
			AnimationManager.StopIfRunning(menuItem, "Collapse");
			var menu = menuItem.Menu as RadMenu;
			Orientation orientation = Orientation.Horizontal;
			SlideMode slideMode = SlideMode.Top;
			if (menu != null)
			{
				orientation =
					(menuItem.IsTopHeader && menu.Orientation == Orientation.Horizontal) ?
						Orientation.Vertical :
						Orientation.Horizontal;
				PlacementMode placementMode = PlacementMode.Absolute;

				if (menuItem.submenuPopup != null)
				{
					placementMode = GetPlacementMode(menuItem.submenuPopup);
				}


				switch (placementMode)
				{
					//case PlacementMode.Absolute:
					//case PlacementMode.Bottom:
					//case PlacementMode.Center:
					//case PlacementMode.Right:
					//    slideMode = SlideMode.Top;
					//    break;

					case PlacementMode.Left:
					case PlacementMode.Top:
						if (menuItem.FlowDirection == FlowDirection.LeftToRight)
						{
							slideMode = SlideMode.Bottom;
						}
						break;
				}
			}
			AnimationManager.Play(menuItem, "Expand", null, orientation, slideMode);
		}


		private static PlacementMode GetPlacementMode(Popup popup)
		{
			if (popup != null)
			{
				switch (popup.Placement)
				{
					case System.Windows.Controls.Primitives.PlacementMode.Absolute:
						return PlacementMode.Absolute;

					case System.Windows.Controls.Primitives.PlacementMode.Bottom:
						return PlacementMode.Bottom;

					case System.Windows.Controls.Primitives.PlacementMode.Center:
						return PlacementMode.Center;

					case System.Windows.Controls.Primitives.PlacementMode.Left:
						return PlacementMode.Left;

					case System.Windows.Controls.Primitives.PlacementMode.Right:
						return PlacementMode.Right;

					case System.Windows.Controls.Primitives.PlacementMode.Top:
						return PlacementMode.Top;
				}
			}

			return PlacementMode.Bottom;
		}


		private static void OnRoleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem item = d as RadMenuItem;
			if (((MenuItemRole)e.OldValue) == MenuItemRole.TopLevelHeader)
			{
				item.ClearValue(OrientationProperty);
			}
		}

		private static void OnIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenuItem item = d as RadMenuItem;
			item.ChangeVisualState(true);
		}

		private static void StartOpenTimer(DispatcherTimer timer, Duration interval)
		{
			timer.Interval = interval.TimeSpan;
			timer.Start();
		}

		private static void StartCloseTimer(DispatcherTimer timer, Duration interval)
		{
			timer.Interval = interval.TimeSpan;
			timer.Start();
		}

		private static void StopTimer(ref DispatcherTimer timer)
		{
			if (timer != null)
			{
				timer.Stop();
				timer = null;
			}
		}

		private static void OnAccessKeyPressed(object sender, AccessKeyPressedEventArgs e)
		{
			RadMenuItem item = sender as RadMenuItem;
			bool flag = false;
			if (e.Target == null)
			{
				if ((Mouse.Captured == null) || (Mouse.Captured is MenuBase))
				{
					e.Target = item;
					if ((e.OriginalSource == item) && item.IsSubmenuOpen)
					{
						flag = true;
					}
				}
				else
				{
					e.Handled = true;
				}
			}
			else if (e.Scope == null)
			{
				if ((e.Target != item) && (e.Target is RadMenuItem))
				{
					flag = true;
				}
				else
				{
					for (DependencyObject obj2 = e.Source as DependencyObject; obj2 != null; obj2 = VisualTreeHelper.GetParent(obj2))
					{
						if (obj2 == item)
						{
							break;
						}
						UIElement container = obj2 as UIElement;
						if ((container != null) && (ItemsControl.ItemsControlFromItemContainer(container) == item))
						{
							flag = true;
							break;
						}
					}
				}
			}
			if (flag)
			{
				e.Scope = item;
				e.Handled = true;
			}
		}

		private static object CoerceToolTipIsEnabled(DependencyObject d, object value)
		{
			RadMenuItem item = (RadMenuItem)d;
			if (!item.IsSubmenuOpen)
			{
				return value;
			}
			return BooleanBoxes.FalseBox;
		}

		private void CanExecuteChanged(object sender, EventArgs e)
		{
			this.CanExecuteApply();
		}

		private void CanExecuteApply()
		{
			if (this.Command != null)
			{
				RoutedCommand routedCommand = this.Command as RoutedCommand;
				if (routedCommand == null)
				{
					this.IsEnabled = this.Command.CanExecute(this.CommandParameter);
				}
				else
				{
					this.IsEnabled = routedCommand.CanExecute(this.CommandParameter, this.CommandTarget ?? this);
				}
			}
		}

		private void ChangeCommand(ICommand oldCommand, ICommand newCommand)
		{
			if (oldCommand != null)
			{
				oldCommand.CanExecuteChanged -= this.CanExecuteChanged;
			}
			if (newCommand != null)
			{
				newCommand.CanExecuteChanged += this.CanExecuteChanged;
			}
			this.CanExecuteApply();
		}

		private void ExecuteCommand()
		{
			if (this.Command != null)
			{
				RoutedCommand routedCommand = this.Command as RoutedCommand;
				if (routedCommand == null)
				{
					this.Command.Execute(this.CommandParameter);
				}
				else
				{
					routedCommand.Execute(this.CommandParameter, this.CommandTarget ?? this);
				}
			}
		}

		private void OnItemContainerGeneratorStatusChanged(object sender, EventArgs e)
		{
			if (this.ItemContainerGenerator.Status == GeneratorStatus.ContainersGenerated)
			{
				this.ItemContainerGenerator.StatusChanged -= new EventHandler(this.OnItemContainerGeneratorStatusChanged);
				this.NavigateToIndex(0, 1);
			}
		}


		private void OnSubmenuOpened(object sender, RoutedEventArgs e)
		{
			this.SubmenuOpened -= new RadRoutedEventHandler(this.OnSubmenuOpened);
			this.NavigateToIndex(0, 1);
		}

		private void PopupMouseLeave(object sender, MouseEventArgs e)
		{
			if (this.Menu != null 
			
				&& !this.IsMouseOver

				)
			{
				this.Menu.MouseOverPopup = false;
			}

			if (!this.ClickToOpen)
			{
				this.CloseSubMenu();
			}
		}

		private void PopupMouseEnter(object sender, MouseEventArgs e)
		{
			if (this.Menu != null)
			{
				this.Menu.MouseOverPopup = true;
			}
		}

		private void OnLoaded(object sender, RoutedEventArgs e)
		{


			this.UpdateRole();
			this.CanExecuteApply();
			this.ChangeVisualState(true);
		}

		private void InitializeComponent()
		{
			this.UnBindEvents();
			this.GetTemplateParts();
			this.BindEvents();
		}

		private void BindEvents()
		{
			if (this.submenuPopup != null)
			{
				this.submenuPopup.Opened += new EventHandler(this.OnPopupOpened);
				this.submenuPopup.Closed += new EventHandler(this.OnPopupClosed);
				if (this.submenuPopup.Child != null)
				{
					this.submenuPopup.Child.MouseEnter += new MouseEventHandler(this.PopupMouseEnter);
					this.submenuPopup.Child.MouseLeave += new MouseEventHandler(this.PopupMouseLeave);
				}
			}
		}

		private void UnBindEvents()
		{
			if (this.submenuPopup != null)
			{
				this.submenuPopup.Opened -= new EventHandler(this.OnPopupOpened);
				this.submenuPopup.Closed -= new EventHandler(this.OnPopupClosed);
				if (this.submenuPopup.Child != null)
				{
					this.submenuPopup.Child.MouseEnter -= new MouseEventHandler(this.PopupMouseEnter);
					this.submenuPopup.Child.MouseLeave -= new MouseEventHandler(this.PopupMouseLeave);
				}
			}
		}

		private void GetTemplateParts()
		{
			if (this.submenuPopup != null)
			{

				this.submenuPopup.Child = null;
			}
			this.submenuPopup = this.GetTemplateChild("PART_Popup") as Popup;


			if (this.submenuPopup != null)
			{
				if (this.IsTopHeader)
				{
					RadMenu menu = ItemsControl.ItemsControlFromItemContainer(this) as RadMenu;
					if (menu != null)
					{
						this.SetBinding(OrientationProperty,
							new System.Windows.Data.Binding("Orientation") { Source = menu });
					}
					this.submenuPopup.Placement = menu.Orientation == Orientation.Vertical
								? System.Windows.Controls.Primitives.PlacementMode.Right
								: System.Windows.Controls.Primitives.PlacementMode.Bottom;
				}
				else
				{
					this.submenuPopup.Placement = System.Windows.Controls.Primitives.PlacementMode.Right;
				}
			}

		}



		private void OnMenuPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Orientation")
			{

				RadMenu menu = this.Menu as RadMenu;
				this.submenuPopup.Placement = (menu.Orientation == Orientation.Horizontal)
					? System.Windows.Controls.Primitives.PlacementMode.Bottom
					: System.Windows.Controls.Primitives.PlacementMode.Right;

			}
		}

		private void ChangeTemplate(MenuItemRole role)
		{
			ControlTemplate newTemplate = null;

			switch (role)
			{
				case MenuItemRole.TopLevelItem:
					newTemplate = this.TopLevelItemTemplateKey;
					break;
				case MenuItemRole.TopLevelHeader:
					newTemplate = this.TopLevelHeaderTemplateKey;
					break;
				case MenuItemRole.SubmenuItem:
					newTemplate = this.SubmenuItemTemplateKey;
					break;
				case MenuItemRole.SubmenuHeader:
					newTemplate = this.SubmenuHeaderTemplateKey;
					break;
				case MenuItemRole.Separator:
					newTemplate = this.SeparatorTemplateKey;
					break;
				default:
					break;
			}
			this.Role = role;

		}

		private bool MenuItemNavigate(Key key)
		{
			if (((key == Key.Left) || (key == Key.Right)) || ((key == Key.Up) || (key == Key.Down)))
			{
				ItemsControl control = ItemsControl.ItemsControlFromItemContainer(this) as ItemsControl;
				if (control != null)
				{
					if (!control.HasItems)
					{
						return false;
					}
					if (((control.Items.Count == 1) && !(control is RadMenu)) && ((key == Key.Up) || (key == Key.Down)))
					{
						return true;
					}

					object focusedElement = Keyboard.FocusedElement;

					RadMenuItem menuItem = control as RadMenuItem;
					if (menuItem != null)
					{
						menuItem.NavigateTo(KeyToTraversalDirection(key), this);
					}

					object obj3 = Keyboard.FocusedElement;

					if ((obj3 != focusedElement) && (obj3 != this))
					{
						return true;
					}
				}
			}
			return false;
		}

		private void NavigateTo(FocusNavigationDirection direction, RadMenuItem menuItem)
		{
			int index = -1;
			RadMenuItem topLevelItem = null;
			RadMenu menu = null;

			switch (direction)
			{
				case FocusNavigationDirection.Left:
					topLevelItem = GetTopLevelItem(this);
					if (topLevelItem != null)
					{
						menu = topLevelItem.Menu as RadMenu;
						if (menu != null && menu.CurrentSelection != null)
						{
							index = menu.Items.IndexOf(GetItemOrContainerFromContainer(topLevelItem));
							menu.MenuNavigate(index - 1, -1, true);
						}
					}
					break;
				case FocusNavigationDirection.Right:
					topLevelItem = GetTopLevelItem(this);
					if (topLevelItem != null)
					{
						menu = topLevelItem.Menu as RadMenu;
						if (menu != null && menu.CurrentSelection != null)
						{
							index = menu.Items.IndexOf(GetItemOrContainerFromContainer(topLevelItem));
							menu.MenuNavigate(index + 1, 1, true);
						}
					}
					break;
				case FocusNavigationDirection.Up:
					index = this.Items.IndexOf(GetItemOrContainerFromContainer(menuItem));
					this.NavigateToIndex(index - 1, -1);
					break;
				case FocusNavigationDirection.Down:
					index = this.Items.IndexOf(GetItemOrContainerFromContainer(menuItem));
					this.NavigateToIndex(index + 1, 1);
					break;
			}
		}

		private bool NavigateToIndex(int index, int direction)
		{
			DependencyObject control = MenuBase.NavigateToItem(this, index, direction);

			if (!this.SetCurrentSelection(control))
			{
				RadMenuItem item = control as RadMenuItem;
				if (item.IsSeparator)
				{
					int separatorIndex = this.ItemContainerGenerator.IndexFromContainer(item);
					control = MenuBase.NavigateToItem(this, separatorIndex + direction, direction);
					return this.SetCurrentSelection(control);
				}
			}
			else
			{
				return true;
			}

			return false;
		}

		private bool SetCurrentSelection(DependencyObject control)
		{
			RadMenuItem menuItem = control as RadMenuItem;
			if (menuItem != null && !menuItem.IsSeparator)
			{
				this.CurrentSelection = menuItem;
				menuItem.FocusOrSelect();
				menuItem.ChangeVisualState(true);

				return true;
			}
			return false;
		}

		private bool HandleEnterKey(MenuItemRole role)
		{
			bool handled = false;
			switch (role)
			{
				case MenuItemRole.TopLevelHeader:
				case MenuItemRole.SubmenuHeader:
					if (this.Menu.NotifyOnHeaderClick)
					{
						goto case MenuItemRole.TopLevelItem;
					}
					break;
				case MenuItemRole.TopLevelItem:
				case MenuItemRole.SubmenuItem:
					this.ClickItem();
					handled = true;
					break;
			}
			if ((role == MenuItemRole.TopLevelHeader && this.Menu.CurrentSelection != null)
				|| ((role == MenuItemRole.SubmenuHeader) && !this.IsSubmenuOpen))
			{
				this.OpenSubmenuWithKeyboard();
				handled = true;
			}

			return handled;
		}

		private bool HandleDownKey(MenuItemRole role)
		{
			bool handled = false;
			if (((role == MenuItemRole.SubmenuHeader) && this.IsSubmenuOpen) && (this.CurrentSelection == null))
			{
				this.NavigateToIndex(0, 1);
				handled = true;
			}
			return handled;
		}

		private bool HandleRightKey(MenuItemRole role)
		{
			bool handled = false;
			if ((role == MenuItemRole.SubmenuHeader) && !this.IsSubmenuOpen)
			{
				this.OpenSubmenuWithKeyboard();
				handled = true;
			}
			else if ((role == MenuItemRole.SubmenuHeader) && this.IsSubmenuOpen)
			{
				this.NavigateToIndex(0, 1);
				handled = true;
			}
			return handled;
		}

		private bool HandleUpKey(MenuItemRole role)
		{
			bool handled = false;
			if (((role == MenuItemRole.SubmenuHeader) && this.IsSubmenuOpen) && (this.CurrentSelection == null))
			{
				this.NavigateToIndex(this.Items.Count - 1, -1);
				handled = true;
			}
			return handled;
		}

		private bool HandleLeftKey()
		{
			bool handled = false;
			if (this.Role == MenuItemRole.SubmenuHeader && this.IsSubmenuOpen)
			{
				this.CloseMenu();
				this.IsHighlighted = true;
				handled = true;
				return handled;
			}

			RadMenuItem parent = this.ParentItem;
			if (parent != null && parent.IsSubmenuOpen && parent.Role == MenuItemRole.SubmenuHeader)
			{
				parent.CloseMenu();
				parent.IsHighlighted = true;
				parent.ChangeVisualState(true);
				handled = true;
			}
			return handled;
		}

		private bool HandleEscapeKey()
		{
			bool handled = false;
			RadMenuItem parent = this.ParentItem;
			if (parent != null && parent.IsSubmenuOpen)
			{
				parent.FocusOrSelect();
				parent.CloseMenu();
				parent.IsHighlighted = true;
				parent.ChangeVisualState(true);
				handled = true;
			}

			return handled;
		}

		private void StopOpenTimer()
		{
			if (this.openTimer != null)
			{
				this.openTimer.Tick -= this.OnOpenTimerTick;
			}
			StopTimer(ref this.openTimer);
		}

		private void StopCloseTimer()
		{
			if (this.closeTimer != null)
			{
				this.closeTimer.Tick -= this.OnCloseTimerTick;
			}
			StopTimer(ref this.closeTimer);
		}

		private void OpenSubMenu()
		{
			if (this.IsSubmenuOpen)
			{
				this.StopCloseTimer();
				this.FocusOrSelect();
				return;
			}

			if (this.Role == MenuItemRole.SubmenuHeader)
			{
				if (this.ParentItem != null && this.ParentItem.CurrentSelection == null)
				{
					this.FocusOrSelect();
				}

				if (this.openTimer == null)
				{
					this.openTimer = new DispatcherTimer();
					this.openTimer.Tick += new EventHandler(this.OnOpenTimerTick);
				}
				else
				{
					this.openTimer.Stop();
				}

				StartOpenTimer(this.openTimer, this.ShowDelay);
			}
			else if (this.Role == MenuItemRole.TopLevelHeader)
			{
				this.OpenMenu();
			}
			else if (this.Role == MenuItemRole.TopLevelItem ||
					 this.Role == MenuItemRole.SubmenuItem)
			{
				this.FocusOrSelect();
			}
		}

		private void CloseSubMenu()
		{
			if (this.closeTimer == null)
			{
				this.closeTimer = new DispatcherTimer();
				this.closeTimer.Tick += new EventHandler(this.OnCloseTimerTick);
			}

			StartCloseTimer(this.closeTimer, this.HideDelay);
		}

		private void UnSelectOrUnHighlight()
		{
			if (this.IsSelected)
			{
				this.IsSelected = false;
			}
			else
			{
				this.IsHighlighted = false;
			}
		}

		private void ClickItem()
		{
			this.OnClick();
		}

		private void ClickHeader(MenuItemRole role)
		{
			this.FocusOrSelect();
			if (role == MenuItemRole.TopLevelHeader && this.ClickToOpen && this.IsSubmenuOpen)
			{
				this.CloseMenu();
			}
			else
			{
				if (!this.IsSubmenuOpen)
				{
					this.OpenMenu();
				}
			}
		}

		private void OnPopupOpened(object sender, EventArgs e)
		{
			RadMenuItemAutomationPeer peer = FrameworkElementAutomationPeer.CreatePeerForElement(this) as RadMenuItemAutomationPeer;
			if (peer != null)
			{
				peer.RaiseExpandCollapseAutomationEvent(false, true);
			}
			this.OnSubmenuOpened(new RadRoutedEventArgs(SubmenuOpenedEvent, this));
		}

		private void OnPopupClosed(object source, EventArgs e)
		{
			RadMenuItemAutomationPeer peer = FrameworkElementAutomationPeer.CreatePeerForElement(this) as RadMenuItemAutomationPeer;
			if (peer != null)
			{
				peer.RaiseExpandCollapseAutomationEvent(true, false);
			}
			this.OnSubmenuClosed(new RadRoutedEventArgs(SubmenuClosedEvent, this));
		}

		private void OnCloseTimerTick(object sender, EventArgs e)
		{
			this.StopCloseTimer();

			if (!this.ClickToOpen && this.Menu != null)
			{
				if (!this.MouseOverPopup)
				{
					RadMenuItem topLevelItem = GetTopLevelItem(this);
					if (topLevelItem == null || !topLevelItem.IsMouseOver)
					{
						this.Menu.CloseAll();
					}
				}
			}

			if (!this.MouseOverPopup)
			{
				this.CloseMenu();
				this.IsSelected = false;
			}
			else
			{
				if (this.ParentItem != null && this.ParentItem.CurrentSelection != this)
				{
					this.CloseMenu();
					this.IsSelected = false;
				}
			}
		}

		private void OnOpenTimerTick(object sender, EventArgs e)
		{
			if (this.IsMouseOver)
			{
				this.OpenMenu();
			}
			else
			{
				this.IsHighlighted = false;
			}

			this.StopOpenTimer();
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "useTransitions"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "stateNames"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		private void GoToState(bool useTransitions, params string[] stateNames)
		{

		}
	}
}
