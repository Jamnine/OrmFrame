using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Orm.Toolkit.Telerik.Windows.Controls.Animation;
using Orm.Toolkit.Telerik.Windows.Controls.RadWindowPopup;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// This class represents an interactive window and provides static methods
	/// for showing standart dialog windows - Alert, Confirm and Prompt.
	/// </summary>
	[TemplatePart(Name = "W", Type = typeof(Thumb))]
	[TemplatePart(Name = "NW", Type = typeof(Thumb))]
	[TemplatePart(Name = "N", Type = typeof(Thumb))]
	[TemplatePart(Name = "NE", Type = typeof(Thumb))]
	[TemplatePart(Name = "E", Type = typeof(Thumb))]
	[TemplatePart(Name = "SE", Type = typeof(Thumb))]
	[TemplatePart(Name = "S", Type = typeof(Thumb))]
	[TemplatePart(Name = "SW", Type = typeof(Thumb))]
	[TemplatePart(Name = "titleThumb", Type = typeof(Thumb))]
	[TemplatePart(Name = "PART_MinimizeButton", Type = typeof(Button))]
	[TemplatePart(Name = "PART_RestoreButton", Type = typeof(Button))]
	[TemplatePart(Name = "PART_MaximizeButton", Type = typeof(Button))]
	[TemplatePart(Name = "PART_CloseButton", Type = typeof(Button))]
	[TemplatePart(Name = "PART_HeaderButtonsBorder", Type = typeof(Border))]

	public partial class RadWindow : HeaderedContentControl, Telerik.Windows.Controls.INotifyLayoutChange,IWeakEventListener
	{
		/// <summary>
		/// Identifies the <see>ResponseButton</see> Property.
		/// </summary>
		public static readonly DependencyProperty ResponseButtonProperty =
			DependencyProperty.RegisterAttached("ResponseButton", typeof(ResponseButton), typeof(RadWindow), new PropertyMetadata(OnResponseButtonPropertyChanged));

		/// <summary>
		/// Identifies the <see>ModalBackground</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty ModalBackgroundProperty =
			DependencyProperty.Register("ModalBackground", typeof(Brush), typeof(RadWindow), null);

		/// <summary>
		/// Identifies the <see>WindowState</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty WindowStateProperty =
            DependencyProperty.Register("WindowState", typeof(System.Windows.WindowState), typeof(RadWindow), new PropertyMetadata(OnWindowStateChanged));

		/// <summary>
		/// Identifies the <see>Icon</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty IconProperty =
			DependencyProperty.Register("Icon", typeof(object), typeof(RadWindow), null);

		/// <summary>
		/// Identifies the <see>IconTemplate</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty IconTemplateProperty =
			DependencyProperty.Register("IconTemplate", typeof(DataTemplate), typeof(RadWindow), null);

		/// <summary>
		/// Identifies the <see>ResizeMode</see> dependency property.
		/// </summary>
		public static readonly DependencyProperty ResizeModeProperty =
			DependencyProperty.Register("ResizeMode",
										typeof(ResizeMode),
										typeof(RadWindow),
										new PropertyMetadata(ResizeMode.CanResize, OnResizeModeChanged));

		/// <summary>
		/// Identifies the <see>WindowStartupLocation</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty WindowStartupLocationProperty =
            DependencyProperty.Register("WindowStartupLocation", typeof(System.Windows.WindowStartupLocation), typeof(RadWindow), new PropertyMetadata(OnWindowStartupLocationChanged));

		/// <summary>
		/// Identifies the <see>DialogResult</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty DialogResultProperty =
			DependencyProperty.Register("DialogResult", typeof(Nullable<bool>), typeof(RadWindow), null);

		/// <summary>
		/// Identifies the <see>PromptResult</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty PromptResultProperty =
			DependencyProperty.Register("PromptResult", typeof(string), typeof(RadWindow), null);

		/// <summary>
		/// Identifies the <see>Left</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty LeftProperty =
			DependencyProperty.Register("Left", typeof(double), typeof(RadWindow), new PropertyMetadata(OnLeftChanged));

		/// <summary>
		/// Identifies the <see>Top</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty TopProperty =
			DependencyProperty.Register("Top",
											typeof(double),
											typeof(RadWindow),
											new PropertyMetadata(OnTopChanged));

		/// <summary>
		/// Identifies the <see>LeftOffset</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty LeftOffsetProperty =
			DependencyProperty.Register("LeftOffset",
											typeof(double),
											typeof(RadWindow),
											new PropertyMetadata(0.0));

		/// <summary>
		/// Identifies the <see>TopOffset</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty TopOffsetProperty =
			DependencyProperty.Register("TopOffset",
											typeof(double),
											typeof(RadWindow),
											new PropertyMetadata(0.0));

		/// <summary>
		/// Identifies the <see>BorderBackground</see> dependency property. 
		/// </summary>
		public static readonly DependencyProperty BorderBackgroundProperty =
			DependencyProperty.Register("BorderBackground",
											typeof(Brush),
											typeof(RadWindow),
											null);

		/// <summary>
		/// Identifies the <see>RestoreMinimizedLocation</see> Property.
		/// </summary>
		public static readonly DependencyProperty RestoreMinimizedLocationProperty =
			DependencyProperty.Register("RestoreMinimizedLocation",
											typeof(bool),
											typeof(RadWindow),
											null);

		/// <summary>
		/// Identifies the <see>IsHeaderHitTestVisible</see> Property.
		/// </summary>
		public static readonly DependencyProperty IsHeaderHitTestVisibleProperty =
			DependencyProperty.Register("IsHeaderHitTestVisible",
											typeof(bool),
											typeof(RadWindow),
											null);

		/// <summary>
		/// Identifies the <see>IsRestricted</see> Property.
		/// </summary>
		public static readonly DependencyProperty IsRestrictedProperty =
			DependencyProperty.Register("IsRestricted",
											typeof(bool),
											typeof(RadWindow),
											null);

		/// <summary>
		/// Identifies the <see>RestrictedAreaMargin</see> Property.
		/// </summary>
		public static readonly DependencyProperty RestrictedAreaMarginProperty =
			DependencyProperty.Register("RestrictedAreaMargin",
											typeof(Thickness),
											typeof(RadWindow),
											new PropertyMetadata(new Thickness(0)));

		/// <summary>
		/// Identifies the <see>CanMove</see> Property.
		/// </summary>
		public static readonly DependencyProperty CanMoveProperty =
			DependencyProperty.Register("CanMove",
											typeof(bool),
											typeof(RadWindow),
											new PropertyMetadata(true, OnCanMoveChanged));

		/// <summary>
		/// Identifies the <see>CanClose</see> Property.
		/// </summary>
		public static readonly DependencyProperty CanCloseProperty =
			DependencyProperty.Register("CanClose",
											typeof(bool),
											typeof(RadWindow),
											new PropertyMetadata(true, OnCanCloseChanged));

		/// <summary>
		/// Identifies the <see>IsResizing</see> Property.
		/// </summary>
		public static readonly DependencyProperty IsResizingProperty;

		/// <summary>
		/// Identifies the <see>IsDragging</see> Property.
		/// </summary>
		public static readonly DependencyProperty IsDraggingProperty;

		/// <summary>
		/// Identifies the <see>IsActiveWindow</see> Property.
		/// </summary>
		public static readonly DependencyProperty IsActiveWindowProperty;

		/// <summary>
		/// Identifies the <see>IsModal</see> Property.
		/// </summary>
		public static readonly DependencyProperty IsModalProperty;

		private static readonly DependencyPropertyKey IsResizingPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsResizing",
															typeof(bool),
															typeof(RadWindow),
															new PropertyMetadata(OnIsResizingChanged));

		private static readonly DependencyPropertyKey IsDraggingPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsDragging",
															typeof(bool),
															typeof(RadWindow),
															new PropertyMetadata(OnIsDraggingChanged));

		private static readonly DependencyPropertyKey IsActiveWindowPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsActiveWindow",
															typeof(bool),
															typeof(RadWindow),
															new PropertyMetadata(OnIsActiveWindowChanged));

		private static readonly DependencyPropertyKey IsModalPropertyKey =
			DependencyPropertyExtensions.RegisterReadOnly("IsModal",
															typeof(bool),
															typeof(RadWindow),
															new PropertyMetadata(OnIsModalChanged));

		private static readonly string[] thumbNames =
			new string[] { "W", "NW", "N", "NE", "E", "SE", "S", "SW", "titleThumb" };

		private static readonly TimeSpan doubleClickInterval = TimeSpan.FromMilliseconds(300);

		private static WindowPopupFactory popupFactory = GetFactory();

		private WindowPopup popup;
		private Panel backCanvas;

		private FrameworkElement minimizeButton;
		private FrameworkElement maximizeButton;
		private FrameworkElement restoreButton;
		private FrameworkElement closeButton;
		private FrameworkElement headerButtonsBorder;

		private List<Thumb> thumbs;
		private DateTime titleLastClick;
		private RadWindowStateManager manager;
		private bool isTemplateApplied;
		private DragInfo dragInfo = null;
		private FrameworkElement contentElement;
		private bool sizeChangedEventsAttached;
		private bool isOpen;
		private bool isOpening;

		static RadWindow()
		{
            var s =   WindowCommands.Close;
			CommandManager.RegisterClassCommandBinding(typeof(RadWindow), new CommandBinding(WindowCommands.Close, OnCloseClick));
			CommandManager.RegisterClassCommandBinding(typeof(RadWindow), new CommandBinding(WindowCommands.Minimize, OnMinimizeClick));
			CommandManager.RegisterClassCommandBinding(typeof(RadWindow), new CommandBinding(WindowCommands.Maximize, OnMaximizeClick));
			CommandManager.RegisterClassCommandBinding(typeof(RadWindow), new CommandBinding(WindowCommands.Restore, OnRestoreClick));


            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadWindow),
            //new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadWindow))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadWindow), new FrameworkPropertyMetadata(typeof(RadWindow)));

			IsResizingProperty = IsResizingPropertyKey.DependencyProperty;
			IsDraggingProperty = IsDraggingPropertyKey.DependencyProperty;
			IsActiveWindowProperty = IsActiveWindowPropertyKey.DependencyProperty;
			IsModalProperty = IsModalPropertyKey.DependencyProperty;
		}

		/// <summary>
		/// Initializes a new instance of the RadWindow class.
		/// </summary>
		/// <remarks>
		///  Use this constructor to create an instance of the <strong>RadWindow</strong>. In order for the 
		///  RadWindow to be displayed, it is not necessary to add it to the visual tree.
		/// </remarks>
		/// <example>
		///	<code lang="CS">
		/// RadWindow window = new RadWindow();
		///	</code>
		///	<code lang="VB">
		/// Dim window As RadWindow = New RadWindow
		/// </code>
		/// </example>
		public RadWindow()
			: base()
		{


			this.manager = new RadWindowStateManager(this);			

			// The canvas used for modal window.
			this.backCanvas = new Canvas();

			this.backCanvas.SetBinding(Panel.BackgroundProperty, new Binding("ModalBackground") { Source = this, Mode = BindingMode.OneWay });

			if (!this.IsInDesignMode)
			{

				Mouse.AddMouseDownHandler(this.backCanvas, this.OnModalBackgroundClick);
				Mouse.AddMouseUpHandler(this.backCanvas, this.OnModalBackgroundClick);


				this.Visibility = Visibility.Collapsed;

				this.AddHandler(UIElement.MouseLeftButtonDownEvent, new MouseButtonEventHandler(this.OnMouseButtonDown), true);
			}

			this.thumbs = new List<Thumb>(9);

            //TelerikLicense.Verify(this); //禁止验证许可
		}


		/// <summary>
		/// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
		/// </summary>
		/// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadWindow));
            this.DefaultStyleKey = typeof(RadWindow);
		}

		/// <summary>
		/// Occurs when a layout change is ended.
		/// </summary>
		public event EventHandler LayoutChangeEnded;

		/// <summary>
		/// Occurs when a layout change is started.
		/// </summary>
		public event EventHandler LayoutChangeStarted;

		/// <summary>
		/// Occurs when the value of a Left or Top changes.
		/// </summary>
		[SRCategory(RadCategory.Behavior)]
		public event RoutedEventHandler LocationChanged;

		/// <summary>
		/// Occurs when the value of a WindowState changes.
		/// </summary>
		/// <remarks>
		/// The event is raised whenever the <see>WindowState</see> property is changed.
		/// </remarks>
		[SRCategory(RadCategory.Behavior)]
		public event RoutedEventHandler WindowStateChanged;

		/// <summary>
		/// Occurs when the <strong>RadWindow</strong> is activated.
		/// </summary>
		/// <remarks>
		/// The event is raised whenever <strong>RadWindow</strong> is activated.
		/// </remarks>
		[SRCategory(RadCategory.Behavior)]
		public event EventHandler Activated;

		/// <summary>
		/// Occurs when the <strong>RadWindow</strong> is opened.
		/// </summary>
		/// <remarks>
		/// The event is raised whenever <strong>RadWindow</strong> is opened.
		/// </remarks>
		[SRCategory(RadCategory.Behavior)]
		public event RoutedEventHandler Opened;

		/// <summary>
		/// Occurs when the RadWindow is closed.
		/// </summary>
		/// <remarks>
		/// The event is raised right next after the <see>PreviewClosed</see> event. Both events are raise by
		/// <see>Close</see> method.
		/// </remarks>
		[SRCategory(RadCategory.Behavior)]
		public event EventHandler<WindowClosedEventArgs> Closed;

		/// <summary>
		/// Occurs when the RadWindow is closing.
		/// </summary>
		/// <remarks>
		/// The event is raised whenever the <see>Close</see> method is invoked.
		/// </remarks>
		[SRCategory(RadCategory.Behavior)]
		public event EventHandler<WindowPreviewClosedEventArgs> PreviewClosed;

		/// <summary>
		/// Gets or sets a brush to be used to draw the title of <Strong>RadWindow</Strong>.
		/// This is a dependency property.
		/// </summary>
		public Brush BorderBackground
		{
			get { return (Brush)GetValue(BorderBackgroundProperty); }
			set { SetValue(BorderBackgroundProperty, value); }
		}

		/// <summary>
		/// Gets or sets a brush for the modal background of <Strong>RadWindow</Strong>. 
		/// This is a dependency property.
		/// </summary>
		public Brush ModalBackground
		{
			get { return (Brush)GetValue(ModalBackgroundProperty); }
			set { SetValue(ModalBackgroundProperty, value); }
		}

		/// <summary>
		/// Gets a value indicating whether this instance is layout changing.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is layout changing; otherwise, <c>false</c>.
		/// </value>
		public bool IsLayoutChanging
		{
			get
			{
				return this.IsDragging || this.IsResizing;
			}
		}

		/// <summary>
		/// Gets or sets whether <Strong>RadWindow</Strong> can be dragged.
		/// This is a dependency property.
		/// </summary>
		/// <remarks>If the value of this property is <c>true</c>, the instance
		/// can be dragged; otherwize it is is fixed.</remarks>
		/// <value><c>True</c> if this instance can be dragged; otherwise, <c>false</c>.</value>
		public bool CanMove
		{
			get { return (bool)this.GetValue(CanMoveProperty); }
			set { this.SetValue(CanMoveProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether <Strong>RadWindow</Strong> can be dragged.
		/// This is a dependency property.
		/// </summary>
		/// <remarks>If the value of this property is <c>true</c>, the instance
		/// can be dragged; otherwize it is is fixed.</remarks>
		/// <value><c>True</c> if this instance can be dragged; otherwise, <c>false</c>.</value>
		public bool CanClose
		{
			get { return (bool)this.GetValue(CanCloseProperty); }
			set { this.SetValue(CanCloseProperty, value); }
		}

		/// <summary>
		/// Gets or sets a WindowState value for the <Strong>RadWindow</Strong>. This is a dependency property.
		/// </summary>
		public System.Windows.WindowState WindowState
		{
            get { return (System.Windows.WindowState)GetValue(WindowStateProperty); }
			set { SetValue(WindowStateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the IconTemplate property. This is a dependency property.
		/// </summary>
		public DataTemplate IconTemplate
		{
			get { return (DataTemplate)GetValue(IconTemplateProperty); }
			set { SetValue(IconTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the Icon image to appear in the <Strong>RadWindow</Strong> titlebar. This is a dependency property.
		/// </summary>
		public object Icon
		{
			get { return GetValue(IconProperty); }
			set { SetValue(IconProperty, value); }
		}

		/// <summary>
		/// Gets or sets a ResizeMode value for the <Strong>RadWindow</Strong>. This is a dependency property.
		/// </summary>
		public ResizeMode ResizeMode
		{
			get { return (ResizeMode)GetValue(ResizeModeProperty); }
			set { SetValue(ResizeModeProperty, value); }
		}

		/// <summary>
		/// Gets or sets a WindowStartupLocation value for the <Strong>RadWindow</Strong>. This is a dependency property.
		/// </summary>
		public System.Windows.WindowStartupLocation WindowStartupLocation
		{
			get { return (System.Windows.WindowStartupLocation)GetValue(WindowStartupLocationProperty); }
			set { SetValue(WindowStartupLocationProperty, value); }
		}

		/// <summary>
		/// Gets or sets a DialogResult value for the <Strong>RadWindow</Strong>. This is a dependency property.
		/// </summary>
		public Nullable<bool> DialogResult
		{
			get { return (Nullable<bool>)GetValue(DialogResultProperty); }
			set { SetValue(DialogResultProperty, value); }
		}

		/// <summary>
		/// Gets or sets a PromptResult value for the <Strong>RadWindow</Strong>. This is a dependency property.
		/// </summary>
		public string PromptResult
		{
			get { return (string)GetValue(PromptResultProperty); }
			set { SetValue(PromptResultProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value that represents the distance between
		/// the left side of an element and the left side of the page. This is a dependency property.
		/// </summary>
		public double Left
		{
			get { return (double)this.GetValue(LeftProperty); }
			set { this.SetValue(LeftProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value that represents the distance between the 
		/// top of an element and the top of the page. This is a dependency property.
		/// </summary>
		public double Top
		{
			get { return (double)this.GetValue(TopProperty); }
			set { this.SetValue(TopProperty, value); }
		}

		/// <summary>
		/// Gets or sets the value which determines whether the window preserves
		/// its size and location when WindowState property is changed. This is a dependency property.
		/// </summary>
		public bool RestoreMinimizedLocation
		{
			get { return (bool)GetValue(RestoreMinimizedLocationProperty); }
			set { SetValue(RestoreMinimizedLocationProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the header of this instance is hit test visible.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if the header of this instance is hit test visible; otherwise, <c>false</c>.
		/// </value>
		public bool IsHeaderHitTestVisible
		{
			get { return (bool)GetValue(IsHeaderHitTestVisibleProperty); }
			set { SetValue(IsHeaderHitTestVisibleProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is restricted.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is restricted; otherwise, <c>false</c>.
		/// </value>
		public bool IsRestricted
		{
			get { return (bool)GetValue(IsRestrictedProperty); }
			set { SetValue(IsRestrictedProperty, value); }
		}

		/// <summary>
		/// Gets or sets the restricted area margin.
		/// </summary>
		/// <value>The restricted area margin.</value>
		public Thickness RestrictedAreaMargin
		{
			get { return (Thickness)GetValue(RestrictedAreaMarginProperty); }
			set { SetValue(RestrictedAreaMarginProperty, value); }
		}

		/// <summary>
		/// Gets or sets the Owner of the RadWindow.This is a dependency property.
		/// </summary>
		public ContentControl Owner
		{
			get;
			set;
		}

		/// <summary>
		/// Gets a value that represents whether the <Strong>RadWindow</Strong> is modal.
		/// This is a dependecy property.
		/// </summary>
		public bool IsModal
		{
			get { return (bool)this.GetValue(IsModalProperty); }
			private set { this.SetValue(IsModalPropertyKey, value); }
		}

		/// <summary>
		/// Gets or sets an offset value for the Left position in case of<see>WindowStartupLocation</see> is 
		/// set to CenterParent. This is a dependency property.
		/// </summary>
		public double LeftOffset
		{
			get
			{
				return (double)this.GetValue(LeftOffsetProperty);
			}
			set
			{
				this.SetValue(LeftOffsetProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets an offset value for the Top position in case of <see>WindowStartupLocation</see> is 
		/// set to CenterParent. This is a dependency property.
		/// </summary>
		public double TopOffset
		{
			get
			{
				return (double)this.GetValue(TopOffsetProperty);
			}
			set
			{
				this.SetValue(TopOffsetProperty, value);
			}
		}

		/// <summary>
		/// Gets a value for the <Strong>RadWindow</Strong> representing the current open state. 
		/// </summary>
		public bool IsOpen
		{
			get { return this.isOpen; }////this.popup != null && this.popup.IsOpen;
			private set { this.isOpen = value; }
		}

		/// <summary>
		/// Gets a value indicating whether this instance is active. This is a dependency property.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is active; otherwise, <c>false</c>.
		/// </value>
		public bool IsActiveWindow
		{
			get { return (bool)this.GetValue(IsActiveWindowProperty); }
			internal set { this.SetValue(IsActiveWindowPropertyKey, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is resizing. This is a dependency property.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is resizing; otherwise, <c>false</c>.
		/// </value>
		public bool IsResizing
		{
			get { return (bool)this.GetValue(IsResizingProperty); }
			private set { this.SetValue(IsResizingPropertyKey, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is is dragging. This is a dependency property.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is is dragging; otherwise, <c>false</c>.
		/// </value>
		public bool IsDragging
		{
			get { return (bool)this.GetValue(IsDraggingProperty); }
			private set { this.SetValue(IsDraggingPropertyKey, value); }
		}


		internal static bool IsInBrowser
		{
			get
			{

				return System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted;

			}
		}

		/// <summary>
		/// Gets the Z order of the <strong>RadWindow</strong>.
		/// </summary>
		internal int Z
		{
			get { return this.popup == null ? 0 : this.popup.GetZIndex(); }
		}

		// This is currently not working because the PopupManager doesn't support it!
		internal bool IsTopMost
		{
			get;
			set;
		}

		internal WindowPopup Popup
		{
			get { return this.popup; }
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		internal bool IsInDesignMode
		{
			get
			{

				return DesignerProperties.GetIsInDesignMode(this) || (Application.Current != null && Application.Current.MainWindow == null);

			}
		}

		internal bool IsInWinForms
		{
			get
			{
				return !this.IsInDesignMode && Application.Current == null;
			}
		}


		/// <summary>  
		/// This recurses the visual tree for a parent of a specific type.
		/// </summary>  
		/// <param name="child">The object which parent is searched.</param>  
		public static RadWindow GetParentRadWindow(DependencyObject child)
		{
			return child.GetParent<RadWindow>();
		}

		/// <summary>
		/// Gets the response button.
		/// </summary>
		/// <param name="button">The button.</param>
		/// <returns></returns>
		public static ResponseButton GetResponseButton(DependencyObject button)
		{
			return (ResponseButton)button.GetValue(ResponseButtonProperty);
		}

		/// <summary>
		/// Sets the response button.
		/// </summary>
		/// <param name="button">The button.</param>
		/// <param name="value">The ResponseButton value.</param>
		public static void SetResponseButton(DependencyObject button, ResponseButton value)
		{
			button.SetValue(ResponseButtonProperty, value);
		}

		/// <summary>
		/// Opens an Alert modal window.
		/// </summary>
		/// <param name="content">The content to be displayed.</param>
		/// <remarks>
		/// Use this method to populate Alert message that informs the user for a specific problem
		/// or warning.
		/// </remarks>
		public static void Alert(object content)
		{
			DialogParameters pars = new DialogParameters();
			pars.Content = content;
			ConfigureModal(new RadAlert(), pars);
		}

		/// <summary>
		/// Opens an Alert modal window.
		/// </summary>
		/// <param name="content">The content to be displayed.</param>
		/// <param name="closed">Represents the method that will handle the closed event.</param>
		/// <remarks>
		/// Use this method to populate Alert message that informs the user for a specific problem
		/// or warning.
		/// </remarks>
		public static void Alert(object content, EventHandler<WindowClosedEventArgs> closed)
		{
			DialogParameters pars = new DialogParameters();
			pars.Content = content;
			pars.Closed = closed;
			ConfigureModal(new RadAlert(), pars);
		}

		/// <summary>
		/// Opens an Alert modal window.
		/// </summary>
		/// <param name="dialogParameters">Structure that holds all possible parameters for customizing dialog window.</param>
		/// <remarks>
		/// Use this method to populate Alert message that informs the user for a specific problem
		/// or warning.
		/// </remarks>
		public static void Alert(DialogParameters dialogParameters)
		{
			ConfigureModal(new RadAlert(), dialogParameters);
		}

		/// <summary>
		/// Opens a Prompt modal window.
		/// </summary>
		/// <param name="content">Question to the user.</param>
		/// <param name="closed">Represents the method that will handle the closed event.</param>
		/// <remarks>
		/// Use this method to populate Prompt message that requires the user to enter specific value.
		/// </remarks>
		public static void Prompt(object content, EventHandler<WindowClosedEventArgs> closed)
		{
			DialogParameters pars = new DialogParameters();
			pars.Content = content;
			pars.Closed = closed;
			ConfigureModal(new RadPrompt(), pars);
		}

		/// <summary>
		/// Opens a Prompt modal window.
		/// </summary>
		/// <param name="content">Question to the user.</param>
		/// <param name="closed">Represents the method that will handle the closed event.</param>
		/// <param name="defaultPromptResult">The default prompt result value that will appear in the textbox.</param>
		/// <remarks>
		/// Use this method to populate Prompt message that requires the user to enter specific value.
		/// </remarks>
		public static void Prompt(object content, EventHandler<WindowClosedEventArgs> closed, string defaultPromptResult)
		{
			DialogParameters pars = new DialogParameters();
			pars.Content = content;
			pars.Closed = closed;
			pars.DefaultPromptResultValue = defaultPromptResult;
			ConfigureModal(new RadPrompt(), pars);
		}

		/// <summary>
		/// Opens a Prompt modal window.
		/// </summary>
		/// <param name="dialogParameters">Structure that holds all possible parameters for customizing dialog window.</param>
		public static void Prompt(DialogParameters dialogParameters)
		{
			ConfigureModal(new RadPrompt(), dialogParameters);
		}

		/// <summary>
		/// Opens a Confirm modal window.
		/// </summary>
		/// <param name="dialogParameters">Structure that holds all possible parameters for customizing dialog window.</param>
		/// <remarks>
		/// Use this method to populate Confirm message that request the user to
		/// confirm some actions.
		/// </remarks>
		public static void Confirm(DialogParameters dialogParameters)
		{
			ConfigureModal(new RadConfirm(), dialogParameters);
		}

		/// <summary>
		/// Opens a Confirm modal window.
		/// </summary>
		/// <param name="content">The content to be displayed.</param>
		/// <param name="closed">Represents the method that will handle the closed event.</param>
		/// <remarks>
		/// Use this method to populate Confirm message that request the user to
		/// confirm some actions.
		/// </remarks>
		public static void Confirm(object content, EventHandler<WindowClosedEventArgs> closed)
		{
			DialogParameters pars = new DialogParameters();
			pars.Content = content;
			pars.Closed = closed;
			ConfigureModal(new RadConfirm(), pars);
		}

		/// <summary>
		///     When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) 
		///     call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			this.isTemplateApplied = true;

			this.LoadButtons();

			this.LoadLayoutControls();
			this.LoadThumbControls();

			Debug.WriteLine("RadWindow: OnApplyTemplate()");

			this.CheckRestrictedArea();

			if (this.WindowState == System.Windows.WindowState.Normal)
			{
				this.manager.UpdateLayout();
			}

			this.UpdateWindowState();
			////this.UpdateContentVisibility();
			////this.UpdateButtonsVisibility();
			////this.UpdateThumbsVisibility();
			////this.ChangeVisualState(false);
		}

		/// <summary>
		/// Opens <strong>RadWindow</strong> in case it hasn't been already opened.
		/// </summary>
		/// <example>
		///	<code lang="CS">
		/// RadWindow window = new RadWindow();
		/// window.Height = 100;
		/// window.Width = 100;
		/// window.Header = "RadWindow";
		/// window.Content = "This is your content";
		/// window.Show();
		///	</code>
		///	<code lang="VB">
		/// Dim window As RadWindow = New RadWindow
		/// window.Height = 100
		/// window.Width = 100
		/// window.Header = "RadWindow"
		/// window.Content = "This is your content"
		/// window.Show()
		/// </code>
		/// </example>
		public void Show()
		{
			this.ShowWindow(false);
		}

		/// <summary>
		/// Opens modal <strong>RadWindow</strong> in case it hasn't been already opened.
		/// </summary>
		/// <example>
		///	<code lang="CS">
		/// RadWindow window = new RadWindow();
		/// window.Height = 100;
		/// window.Width = 100;
		/// window.Header = "RadWindow";
		/// window.Content = "This is your content";
		/// window.ShowDialog();
		///	</code>
		///	<code lang="VB">
		/// Dim window As RadWindow = New RadWindow
		/// window.Height = 100
		/// window.Width = 100
		/// window.Header = "RadWindow"
		/// window.Content = "This is your content"
		/// window.ShowDialog()
		/// </code>
		/// </example>
		public void ShowDialog()
		{
			this.ShowWindow(true);
		}

		/// <summary>
		/// Manually closes <strong>RadWindow</strong>.
		/// </summary>
		/// <remarks>
		/// Raises <see>Closing</see> and <see>Closed</see> events consequently.
		/// </remarks>
		/// <example>
		///	<code lang="CS">
		/// RadWindow window = new RadWindow();
		/// window.Height = 100;
		/// window.Width = 100;
		/// window.Header = "RadWindow";
		/// window.Content = "This is your content";
		/// window.Show();
		/// window.Close();
		/// </code>
		///	<code lang="VB">
		/// Dim window As RadWindow = New RadWindow
		/// window.Height = 100
		/// window.Width = 100
		/// window.Header = "RadWindow"
		/// window.Content = "This is your content"
		/// window.Show()
		/// window.Close()
		/// </code>
		/// </example>
		public void Close()
		{
			if (this.IsOpen && this.OnPreviewClosed())
			{
				List<RadWindow> windows =
					RadWindowManager.Current
					.Windows
					.Where(w => w.Owner == this)
					.ToList();

				foreach (var win in windows)
				{
					// NOTE: What happens if one of the owned windows was not closed?
					win.Close();
				}

				this.IsOpen = false;
				Action closeCallback = () =>
					{
						this.popup.Close();
						RadWindowManager.Current.RemoveWindow(this);
						this.OnClosed();
					};

				this.StopAllAnimations();
				AnimationManager.Play(this, "Hide", closeCallback);

				Debug.WriteLine("Closed");
			}
			else if (this.isOpening)
			{
				this.isOpening = false;
				this.IsOpen = false;
				this.popup.Close();
			}
		}

		private void StopAllAnimations()
		{
			AnimationManager.StopIfRunning(this, "Show");
			AnimationManager.StopIfRunning(this, "Hide");
		}

		/// <summary>
		/// Attemps to bring the <strong>RadWidnow</strong> over any other <strong>RadWindows</strong> except topmost.
		/// </summary>
		/// <remarks>
		/// Whenever opened <strong>RadWindow</strong> automatically appears over any other windows except topmost.
		/// </remarks>		
		public void BringToFront()
		{
			// It should be asynchronose, because it breaks drag+drop in other cases.
			this.Dispatcher.BeginInvoke(
				new Action(() =>
					{
						// If shouldFocus is false (i.e. is in windows-based application) nothing will focus, because
						// the fe will be null, so the hasFocus will be false and both ifs at the end will fail.

						var fe = IsInBrowser ? null : FocusManager.GetFocusedElement(this) as Control;

						bool hasFocus = (fe != null) && this.IsAncestorOf(fe);

						RadWindowManager.Current.BringToFront(this);
						this.OnActivated();

						if (hasFocus)
						{
							fe.Focus();
						}
						else if (IsInBrowser)
						{
							this.Focus();
						}
					}));

			// We shouldn't do that! Why we need to bring the window to the front twice?
			////RadWindowManager.Current.BringToFront(this);
			////this.OnActivated();
		}

		internal static ThumbType GetThumbType(Thumb draggedElement)
		{
			if (draggedElement != null)
			{
				int index = thumbNames.ToList().IndexOf(draggedElement.Name);
				return (ThumbType)index;
			}
			return ThumbType.NONE;
		}

		internal static void ConfigureModal(RadAlert content, DialogParameters dialogParams)
		{
			RadWindow window = new RadWindow();

			if (dialogParams.Header != null)
			{
				window.Header = dialogParams.Header;
			}
			else
			{
				window.Header = String.Empty;
			}

			content.Content = dialogParams.Content;

			window.Content = content;
			window.Icon = dialogParams.IconContent;
			window.ResizeMode = ResizeMode.NoResize;
			window.CanMove = true;
			window.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			window.IsActiveWindow = true;

			if (dialogParams.ModalBackground != null)
			{
				window.ModalBackground = dialogParams.ModalBackground;
			}

			if (dialogParams.Theme != null)
			{
				StyleManager.SetTheme(content, dialogParams.Theme);
				StyleManager.SetTheme(window, dialogParams.Theme);
			}

			if (dialogParams.WindowStyle != null)
			{
				window.Style = dialogParams.WindowStyle;
			}

			if (dialogParams.ContentStyle != null)
			{
				content.Style = dialogParams.ContentStyle;
			}

			if (dialogParams.Owner != null)
			{
				window.Owner = dialogParams.Owner;
			}

			content.Configure(window, dialogParams);

			RoutedEventHandler openedHandler = null;
			if (dialogParams.Opened != null)
			{
				openedHandler = null;
				openedHandler = (s, e) =>
					{
						dialogParams.Opened(s, e);
						window.Opened -= openedHandler;
					};
				window.Opened += openedHandler;
			}

			EventHandler<WindowClosedEventArgs> helpHandler = null;
			if (dialogParams.Closed != null)
			{
				helpHandler = null;
				helpHandler = (s, args) =>
				{
					dialogParams.Closed(s, args);
					window.Closed -= helpHandler;
				};
				window.Closed += helpHandler;
			}

			window.ShowDialog();
		}

		internal static void InvokeButton(Button button)
		{
			if (button != null)
			{
				button.Focus();
				ButtonAutomationPeer peer = new ButtonAutomationPeer(button);
				IInvokeProvider invkProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
				if (invkProv != null)
				{
					invkProv.Invoke();
				}
			}
		}

		internal Thumb GetThumbByType(ThumbType type)
		{
			return this.thumbs
				.Where(t => GetThumbType(t) == type)
				.FirstOrDefault();
		}

		internal Rect CoerceLocation(double x, double y, double width, double height, Rect initial)
		{
			double left = x;
			double right = x + width;
			double top = y;
			double bottom = y + height;

			if (width < this.MinWidth || width > this.MaxWidth)
			{
				double v = width < this.MinWidth ? this.MinWidth : this.MaxWidth;
				if (left == initial.Left)
				{
					right = left + v;
				}
				else
				{
					left = right - v;
				}
			}

			if (height < this.MinHeight || height > this.MaxHeight)
			{
				double v = height < this.MinHeight ? this.MinHeight : this.MaxHeight;
				if (top == initial.Top)
				{
					bottom = top + v;
				}
				else
				{
					top = bottom - v;
				}
			}

			if (this.IsRestricted)
			{
				Size appSize = this.Popup.GetRootSize();
				double restrictLeft = this.RestrictedAreaMargin.Left;
				double restrictTop = this.RestrictedAreaMargin.Top;
				double restrictRight = appSize.Width - this.RestrictedAreaMargin.Right;
				double restrictBottom = appSize.Height - this.RestrictedAreaMargin.Bottom;

				if (right > restrictRight)
				{
					if (left != initial.Left)
					{
						left -= right - restrictRight;
					}
					right = restrictRight;
				}

				if (left < restrictLeft)
				{
					if (right != initial.Right)
					{
						right += restrictLeft - left;
					}
					left = restrictLeft;
				}

				if (bottom > restrictBottom)
				{
					if (top != initial.Top)
					{
						top -= bottom - restrictBottom;
					}
					bottom = restrictBottom;
				}

				if (top < restrictTop)
				{
					if (bottom != initial.Bottom)
					{
						bottom += restrictTop - top;
					}
					top = restrictTop;
				}
			}

			return new Rect(left,
							top,
							Math.Max(0, right - left),
							Math.Max(0, bottom - top));
		}

		internal void UpdateWindowState()
		{
			if (this.isTemplateApplied)
			{
				var sizeAndPosition = this.manager.SizeAndPosition;
				this.Width = sizeAndPosition.Width;
				this.Height = sizeAndPosition.Height;

				this.Left = sizeAndPosition.Left;
				this.Top = sizeAndPosition.Top;

				this.CheckRestrictedArea();

				this.UpdateContentVisibility();
				this.UpdateButtonsVisibility();
				this.UpdateThumbsVisibility();

				this.ChangeVisualState(true);
			}
		}


		/// <summary>
		/// Updates the visual state of the control.
		/// </summary>
		/// <param name="useTransitions">Indicates whether transitions should be used.</param>
		protected internal virtual void ChangeVisualState(bool useTransitions)
		{
		}

		/// <summary>
		/// Updates the visual state of the control.
		/// </summary>
		protected internal virtual void ChangeVisualState()
		{
		}

		/// <summary>
		/// Raises the <see cref="E:PreviewClose"/> event.
		/// </summary>
		/// <param name="args">The <see cref="Telerik.Windows.Controls.WindowPreviewClosedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnPreviewClosed(WindowPreviewClosedEventArgs args)
		{
			if (this.PreviewClosed != null)
			{
				this.PreviewClosed(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:Activated"/> event.
		/// </summary>
		/// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected virtual void OnActivated(EventArgs args)
		{
			if (this.Activated != null)
			{
				this.Activated(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:Closed"/> event.
		/// </summary>
		/// <param name="args">The <see cref="Telerik.Windows.Controls.WindowClosedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnClosed(WindowClosedEventArgs args)
		{
			if (this.Closed != null)
			{
				this.Closed(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:LocationChanged"/> event.
		/// </summary>
		/// <param name="args">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnLocationChanged(RoutedEventArgs args)
		{
			// Note: Why use RoutedEventArgs when the event is not a RoutedEvent???
			if (this.LocationChanged != null)
			{
				this.LocationChanged(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:WindowStateChanged"/> event.
		/// </summary>
		/// <param name="args">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnWindowStateChanged(RoutedEventArgs args)
		{
			// Note: Why use RoutedEventArgs when the event is not a RoutedEvent???
			if (this.WindowStateChanged != null)
			{
				this.WindowStateChanged(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:Opened"/> event.
		/// </summary>
		/// <param name="args">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnOpened(RoutedEventArgs args)
		{
			// Note: Why use RoutedEventArgs when the event is not a RoutedEvent???
			if (this.Opened != null)
			{
				this.Opened(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:LayoutChangeEnded"/> event.
		/// </summary>
		/// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected virtual void OnLayoutChangeEnded(EventArgs args)
		{
			if (this.LayoutChangeEnded != null)
			{
				this.LayoutChangeEnded(this, args);
			}
		}

		/// <summary>
		/// Raises the <see cref="E:LayoutChangeStarted"/> event.
		/// </summary>
		/// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected virtual void OnLayoutChangeStarted(EventArgs args)
		{
			if (this.LayoutChangeStarted != null)
			{
				this.LayoutChangeStarted(this, args);
			}
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.GotFocus"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			base.OnGotFocus(e);

			// Note: This will never hapen!
			if (e.OriginalSource == this)
			{
				AutomationPeer peer = FrameworkElementAutomationPeer.FromElement(this);
				if (null != peer)
				{
					peer.RaiseAutomationEvent(AutomationEvents.AutomationFocusChanged);
				}
			}
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.LostFocus"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnLostFocus(RoutedEventArgs e)
		{
			// Note: This will never hapen!
			if (e.OriginalSource != this)
			{
				// Note: Try FocusManager.GetFocusedElement() instead e.OriginalSource.
				if (RadWindow.GetParentRadWindow(e.OriginalSource as DependencyObject) == this)
				{
					return;
				}
			}

			base.OnLostFocus(e);

			AutomationPeer peer = FrameworkElementAutomationPeer.FromElement(this);
			if (null != peer)
			{
				peer.RaiseAutomationEvent(AutomationEvents.AutomationFocusChanged);
			}
		}

		/// <summary>
		/// Create the automation peer for this class.
		/// </summary>
		/// <returns></returns>
		protected override AutomationPeer OnCreateAutomationPeer()
		{
			return new RadWindowAutomationPeer(this);
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.KeyDown"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.Key == Key.Enter || e.Key == Key.Escape)
			{
				ResponseButton searchedResponseButton = (e.Key == Key.Enter) ? ResponseButton.Accept : ResponseButton.Cancel;

				InvokeButton(this.ChildrenOfType<Button>()
					.FirstOrDefault(b => GetResponseButton(b) == searchedResponseButton && b.IsEnabled));
			}
		}

		private static void OnResponseButtonPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			if (!Enum.IsDefined(typeof(ResponseButton), e.NewValue))
			{
				throw new ArgumentException("Unknown value for property ResponseButton");
			}

			if (!(sender is Button))
			{
				throw new ArgumentException("Attached property ResponseButton can only be part of Button.");
			}
		}

		/// <summary> 
		///  Top property changed handler. 
		/// </summary>
		/// <param name="d"><Strong>RadWindow</Strong> that changed its <see>Top</see> property.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnTopChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			double top = (double)e.NewValue;

			window.Move(window.Left, top);
			window.manager.UpdateTop(top);


		}

		/// <summary> 
		///     Left property changed handler. 
		/// </summary>
		/// <param name="d"><Strong>RadWindow</Strong> that changed its <see>Left</see> property.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnLeftChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			double left = (double)e.NewValue;

			window.Move(left, window.Top);
			window.manager.UpdateLeft(left);


		}

		/// <summary> 
		///     WindowStartupLocation property changed handler. 
		/// </summary>
		/// <param name="d"><Strong>RadWindow</Strong> that changed its <see>WindowStartupLocation</see> property.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnWindowStartupLocationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
            if (!Enum.IsDefined(typeof(System.Windows.WindowStartupLocation), (System.Windows.WindowStartupLocation)e.NewValue))
			{
				throw new InvalidCastException("Invalid value for WindowStartupLocation");
			}
		}

		/// <summary> 
		/// WindowStateProperty property changed handler. 
		/// </summary>
		/// <param name="d"><Strong>RadWindow</Strong> that changed its <see>WindowState</see> property.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnWindowStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
            if (!Enum.IsDefined(typeof(System.Windows.WindowState), (System.Windows.WindowState)e.NewValue))
			{
				throw new InvalidCastException("Invalid value for WindowState");
			}
			RadWindow window = d as RadWindow;

            var oldValue = (System.Windows.WindowState)e.OldValue;
            if (oldValue == System.Windows.WindowState.Normal)
			{
				window.manager.UpdateLayout();
			}
			window.OnWindowStateChanged();

			RadWindowAutomationPeer peer = FrameworkElementAutomationPeer.FromElement(window)
				as RadWindowAutomationPeer;
			if (null != peer)
			{
				peer.RaiseAutomationWindowStateChanged(e.OldValue, e.NewValue);
			}
		}

		/// <summary> 
		///     ResizeMode property changed handler. 
		/// </summary>
		/// <param name="d"><Strong>RadWindow</Strong> that changed its <see>ResizeMode</see> property.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnResizeModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (!Enum.IsDefined(typeof(ResizeMode), (ResizeMode)e.NewValue))
			{
				throw new InvalidCastException("Invalid value for ResizeMode");
			}

			RadWindow window = d as RadWindow;
			if (window != null)
			{
				window.UpdateWindowState();
			}
		}

		private static void OnIsResizingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			if (window != null)
			{
				window.ChangeVisualState();
			}
		}

		private static void OnIsDraggingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			if (window != null)
			{
				window.ChangeVisualState();
			}
		}

		private static void OnIsActiveWindowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			if (window != null)
			{
				window.ChangeVisualState();
			}
		}

		private static void OnIsModalChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			if (window != null)
			{
				window.ChangeVisualState();
			}
		}

		private static void OnCanMoveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			if (window != null)
			{
				window.UpdateWindowState();
			}
		}

		private static void OnCanCloseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadWindow window = d as RadWindow;
			if (window != null)
			{
				window.UpdateWindowState();
			}
		}

		private static void OnRestoreClick(object sender, ExecutedRoutedEventArgs e)
		{
			var window = sender as RadWindow;

			if (window != null)
			{
                window.WindowState = System.Windows.WindowState.Normal;
			}
		}

		private static void OnMinimizeClick(object sender, ExecutedRoutedEventArgs e)
		{
			var window = sender as RadWindow;

			if (window != null)
			{
                window.WindowState = System.Windows.WindowState.Minimized;
			}
		}

		private static void OnMaximizeClick(object sender, ExecutedRoutedEventArgs e)
		{
			var window = sender as RadWindow;

			if (window != null)
			{
                window.WindowState = System.Windows.WindowState.Maximized;
			}
		}

		private static void OnCloseClick(object sender, ExecutedRoutedEventArgs e)
		{
			var window = sender as RadWindow;

			if (window != null)
			{
				window.Close();
			}
		}

		private static void SetElementVisibility(FrameworkElement element, Visibility newValue)
		{
			if (element != null)
			{
				Control c;
				if ((c = element as Control) != null)
				{
					c.IsEnabled = newValue == Visibility.Visible;
				}

				element.Visibility = newValue;
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "element"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "command")]
		private static void PutCommandToElement(DependencyObject element, ICommand command)
		{

		}



		private static bool IsCompassThumb(Thumb t)
		{
			switch (GetThumbType(t))
			{
				case ThumbType.ElementNorthWestThumb:
				case ThumbType.ElementNorthThumb:
				case ThumbType.ElementNorthEastThumb:
				case ThumbType.ElementWestThumb:
				case ThumbType.ElementEastThumb:
				case ThumbType.ElementSouthWestThumb:
				case ThumbType.ElementSouthThumb:
				case ThumbType.ElementSouthEastThumb:
					return true;
				default:
					return false;
			}
		}

		private static bool IsWestOrNorthThumb(Thumb t)
		{
			switch (GetThumbType(t))
			{
				case ThumbType.ElementNorthWestThumb:
				case ThumbType.ElementNorthThumb:
				case ThumbType.ElementWestThumb:
				case ThumbType.ElementNorthEastThumb:
				case ThumbType.ElementSouthWestThumb:
					return true;
				default:
					return false;
			}
		}

		private static WindowPopupFactory GetFactory()
		{

			if (IsInBrowser)
			{
				return new WindowPopupAdornerFactory();
			}
			return new WindowPopupWindowFactory();

		}

		private static bool HasFocus(UIElement target)
		{
			if (target == null)
			{
				return false;
			}

			return target.IsFocused;

		}

		private void OnApplicationSizeChanged(object sender, EventArgs args)
		{
			if (!this.IsOpen || !IsInBrowser)
			{
				return;
			}

			var appSize = ApplicationHelper.ApplicationSize;

			this.backCanvas.Width = appSize.Width;
			this.backCanvas.Height = appSize.Height;

            if (this.WindowState == System.Windows.WindowState.Maximized)
			{
				var sizeAndPosition = this.manager.SizeAndPosition;
				this.Width = sizeAndPosition.Width;
				this.Height = sizeAndPosition.Height;

				this.Left = sizeAndPosition.Left;
				this.Top = sizeAndPosition.Top;
			}

			this.CheckRestrictedArea();
		}

		private void OnMouseButtonDown(object sender, RoutedEventArgs e)
		{
			if (!this.IsActiveWindow)
			{
				this.BringToFront();
			}
		}

		private void OnLayoutChangeEnded()
		{
			this.OnLayoutChangeEnded(EventArgs.Empty);
		}

		private void OnLayoutChangeStarted()
		{
			this.OnLayoutChangeStarted(EventArgs.Empty);
		}

		private void Move(double x, double y)
		{
			if (this.IsInDesignMode)
			{
				var translate = this.GetTranslateTransform();
				translate.X = x;
				translate.Y = y;
			}
			else
			{
				if (this.popup != null)
				{
					this.popup.Move(Math.Round(x, 0), Math.Round(y, 0));
				}
			}
			Debug.WriteLine(string.Format("Window moved: {0}, {1}", x, y));
			this.OnLocationChanged();
		}

		private void UpdateThumbsVisibility()
		{
			foreach (var thumb in this.thumbs.Where(IsCompassThumb))
			{
                thumb.Visibility = (this.WindowState != System.Windows.WindowState.Normal ||
									this.ResizeMode != ResizeMode.CanResize ||
									(!this.CanMove && IsWestOrNorthThumb(thumb)))
								? Visibility.Collapsed
								: Visibility.Visible;
			}

			var titleThumb = this.GetThumbByType(ThumbType.TitleThumb);
			if (titleThumb != null)
			{
				titleThumb.Visibility = this.CanMove
											? Visibility.Visible
											: Visibility.Collapsed;
			}
		}

		private void UpdateContentVisibility()
		{
            var visibility = this.WindowState != System.Windows.WindowState.Minimized
						? Visibility.Visible
						: Visibility.Collapsed;
			SetElementVisibility(this.contentElement, visibility);
		}

		private void UpdateButtonsVisibility()
		{
			var visibility = this.CanClose
						? Visibility.Visible
						: Visibility.Collapsed;
			SetElementVisibility(this.closeButton, visibility);

            visibility = this.WindowState != System.Windows.WindowState.Normal &&
						 this.ResizeMode != ResizeMode.NoResize
								? Visibility.Visible
								: Visibility.Collapsed;
			SetElementVisibility(this.restoreButton, visibility);

            visibility = this.WindowState != System.Windows.WindowState.Maximized &&
						this.ResizeMode == ResizeMode.CanResize
								? Visibility.Visible
								: Visibility.Collapsed;
			SetElementVisibility(this.maximizeButton, visibility);

            visibility = this.WindowState != System.Windows.WindowState.Minimized &&
						this.ResizeMode != ResizeMode.NoResize
								? Visibility.Visible
								: Visibility.Collapsed;
			SetElementVisibility(this.minimizeButton, visibility);

			visibility = this.CanClose ||
                        this.WindowState != System.Windows.WindowState.Normal ||
						this.ResizeMode == ResizeMode.CanResize ||
						this.ResizeMode != ResizeMode.NoResize
								? Visibility.Visible
								: Visibility.Collapsed;
			SetElementVisibility(this.headerButtonsBorder, visibility);
		}

		private void OnModalBackgroundClick(object sender, RoutedEventArgs e)
		{

			var args = e as System.Windows.Input.MouseButtonEventArgs;
			var fe = FocusManager.GetFocusedElement(this) as UIElement;

			if (fe == null || !this.IsAncestorOf(fe))
			{
				this.Focus();
			}
			args.Handled = true;
		}

		private void OnThumbDragStarted(object sender, DragStartedEventArgs e)
		{
			var thumb = sender as Thumb;

			if (GetThumbType(thumb) == ThumbType.TitleThumb && this.IsTitleDoubleClickClick())
			{
				this.OnTitleDoubleClick();
				return;
			}

			UIElement thumbParent;
            if (this.WindowState != System.Windows.WindowState.Maximized &&
				thumb != null &&
				(thumbParent = thumb.Parent as UIElement) != null)
			{
				var transform = thumbParent.TransformToVisual(this.popup.GetVisual());
				var mouseLocation = new Point(e.HorizontalOffset, e.VerticalOffset);

				var info =
					new DragInfo(transform.Transform(mouseLocation),
									thumb,
									this);

				this.StartDragging(info);
			}
		}

		private void OnThumbDragDelta(object sender, DragDeltaEventArgs e)
		{
			this.DoDrag(e.HorizontalChange, e.VerticalChange);
		}

		private void OnThumbDragCompleted(object sender, DragCompletedEventArgs e)
		{
			this.EndDrag(e.Canceled);
		}

		private void StartDragging(DragInfo info)
		{
			if (this.dragInfo != null ||
				info.DraggedThumbType == ThumbType.NONE ||
				(info.DraggedThumbType == ThumbType.TitleThumb && !this.CanMove) ||
				(info.DraggedThumbType != ThumbType.TitleThumb && this.ResizeMode != ResizeMode.CanResize))
			{
				this.EndDrag(true);
				return;
			}

			this.OnLayoutChangeStarted();

			if (info.DraggedThumbType == ThumbType.TitleThumb)
			{
				this.IsDragging = true;
			}
			else
			{
				this.IsResizing = true;
			}

			this.dragInfo = info;
		}

		private void DoDrag(double horizontalChange, double verticalChange)
		{
			if (this.dragInfo != null)
			{
				this.dragInfo.DoDrag(horizontalChange, verticalChange, this);
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "canceled")]
		private void EndDrag(bool canceled)
		{
			if (this.dragInfo != null)
			{
				DragInfo info = this.dragInfo;
				this.dragInfo = null;

				info.DraggedElement.ReleaseMouseCapture();

				// TODO: This method should support cancelation, but not it is buggy.

				////if (canceled)
				////{
				////    info.RestoreWindowSizeAndLocation(this);
				////}				
			}

			this.OnLayoutChangeEnded();

			this.IsDragging = false;
			this.IsResizing = false;
		}

		private bool OnPreviewClosed()
		{
			WindowPreviewClosedEventArgs closingArgs = new WindowPreviewClosedEventArgs();
			this.OnPreviewClosed(closingArgs);
			return closingArgs.Cancel != true;
		}

		private void OnActivated()
		{
			this.OnActivated(EventArgs.Empty);
		}

		private void OnClosed()
		{			
			this.OnClosed(
				new WindowClosedEventArgs
				{
					DialogResult = this.DialogResult,
					PromptResult = this.PromptResult
				});
		}

		private void OnLocationChanged()
		{
			this.OnLocationChanged(new RoutedEventArgs());
		}

		private void OnWindowStateChanged()
		{
			this.UpdateWindowState();
			this.OnWindowStateChanged(new RoutedEventArgs());
		}

		private void OnOpened()
		{
			this.UpdateWindowState();

			if (this.IsModal)
			{
				var appSize = ApplicationHelper.ApplicationSize;

				this.backCanvas.Width = appSize.Width;
				this.backCanvas.Height = appSize.Height;
			}

			Action callback = () =>
			{
				this.OnActivated();
			};

			RadWindowManager.Current.AddWindow(this);
			this.OnOpened(new RoutedEventArgs());
			this.CheckRestrictedArea();
			this.IsOpen = true;
			this.isOpening = false;

			this.StopAllAnimations();
			AnimationManager.Play(this, "Show", callback);
		}

		private void CheckRestrictedArea()
		{
			if (this.IsRestricted && !this.IsInDesignMode)
			{
				Size appSize = this.Popup.GetRootSize();
				double maxWidth = Math.Max(0, Math.Max(this.MinWidth, appSize.Width - this.RestrictedAreaMargin.Right - this.RestrictedAreaMargin.Left));
				double maxHeight = Math.Max(0, Math.Max(this.MinHeight, appSize.Height - this.RestrictedAreaMargin.Bottom - this.RestrictedAreaMargin.Top));

				double actualWidth = 0;
				double actualHeight = 0;

				if (IsInBrowser && (double.IsNaN(this.Width) || double.IsNaN(this.Height)))
				{
					this.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
				}

				if (!double.IsNaN(this.Width))
				{
					maxWidth = this.Width;
					actualWidth = this.Width;
				}
				else
				{
					actualWidth = this.ActualWidth;
				}

				if (!double.IsNaN(this.Height))
				{
					maxHeight = this.Height;
					actualHeight = this.Height;
				}
				else
				{
					actualHeight = this.ActualHeight;
				}

				var restrictionRect = new Rect(this.RestrictedAreaMargin.Left,
												 this.RestrictedAreaMargin.Top,
												 maxWidth,
												 maxHeight);

				var rect = this.CoerceLocation(this.Left, this.Top, actualWidth, actualHeight, restrictionRect);

				this.Left = rect.Left;
				this.Top = rect.Top;
				if (!double.IsNaN(this.Width))
				{
					this.Width = rect.Width;
				}

				if (!double.IsNaN(this.Height))
				{
					this.Height = rect.Height;
				}
			}
		}

		private void LoadThumbControls()
		{
			foreach (var thumb in this.thumbs)
			{
				thumb.DragStarted -= this.OnThumbDragStarted;
				thumb.DragDelta -= this.OnThumbDragDelta;
				thumb.DragCompleted -= this.OnThumbDragCompleted;
			}

			this.thumbs.Clear();

			foreach (string thumbName in thumbNames)
			{
				var thumb = this.GetTemplateChild(thumbName) as Thumb;

				if (thumb != null)
				{
					thumb.DragStarted += this.OnThumbDragStarted;
					thumb.DragDelta += this.OnThumbDragDelta;
					thumb.DragCompleted += this.OnThumbDragCompleted;
					this.thumbs.Add(thumb);
				}
			}
		}

		private void LoadLayoutControls()
		{
			this.contentElement = this.GetTemplateChild("ContentElement") as FrameworkElement;
		}

		private void OnTitleDoubleClick()
		{
			if (this.ResizeMode != ResizeMode.NoResize)
			{
                if (this.WindowState == System.Windows.WindowState.Normal)
				{
					this.WindowState = (this.ResizeMode == ResizeMode.CanMinimize)
                                        ? System.Windows.WindowState.Minimized
                                        : System.Windows.WindowState.Maximized;
				}
				else
				{
                    this.WindowState = System.Windows.WindowState.Normal;
				}
			}
		}

		private bool IsTitleDoubleClickClick()
		{
			var localTitleLastClick = this.titleLastClick;
			this.titleLastClick = DateTime.Now;

			return this.titleLastClick != null &&
				(DateTime.Now - localTitleLastClick < doubleClickInterval);
		}

		private void RemoveParent()
		{
			if (!this.IsInDesignMode)
			{
				if (this.popup == null)
				{
					HACKS.RemoveParent(this);
				}
			}
		}

		private void PutCommandsToButtons()
		{
			PutCommandToElement(this.closeButton, WindowCommands.Close);
			PutCommandToElement(this.minimizeButton, WindowCommands.Minimize);
			PutCommandToElement(this.maximizeButton, WindowCommands.Maximize);
			PutCommandToElement(this.restoreButton, WindowCommands.Restore);
		}

		private void LoadButtons()
		{
			this.closeButton = this.GetTemplateChild("PART_CloseButton") as FrameworkElement;
			this.minimizeButton = this.GetTemplateChild("PART_MinimizeButton") as FrameworkElement;
			this.maximizeButton = this.GetTemplateChild("PART_MaximizeButton") as FrameworkElement;
			this.restoreButton = this.GetTemplateChild("PART_RestoreButton") as FrameworkElement;

			this.headerButtonsBorder = this.GetTemplateChild("PART_HeaderButtonsBorder") as FrameworkElement;

			this.PutCommandsToButtons();
		}

		private void ShowWindow(bool modal)
		{
			this.ClearValue(DialogResultProperty);
			this.ClearValue(PromptResultProperty);

			this.isOpening = true;

			this.IsModal = modal;

			if (this.popup == null)
			{
				this.RemoveParent();
				this.popup = popupFactory.GetPopup(this, this.backCanvas, this.IsTopMost);
				this.popup.Opened += (s, e) =>
				{
					this.AttachSizeChangedEvents();
					Debug.WriteLine("open");
					this.Dispatcher.BeginInvoke(new Action(() =>
						{

							var fe = FocusManager.GetFocusedElement(this) as Control;

							if (fe == null || !this.IsAncestorOf(fe))
							{
								this.Focus();
							}
						}));

					if (!this.isTemplateApplied)
					{
						RoutedEventHandler loadedHandler = null;
						loadedHandler = (sender, args) =>
							 {
								 this.Loaded -= loadedHandler;
								 this.OnOpened();
							 };
						this.Loaded += loadedHandler;
					}
					else
					{
						this.OnOpened();
					}
				};
			}
			this.popup.WindowStartupLocation = this.WindowStartupLocation;
			this.popup.Owner = this.Owner;

			this.Visibility = Visibility.Visible;

			this.popup.Open(modal);
		}
		
		bool IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
		{
			if (managerType == typeof(SizeChangedEventManager))
			{
				EventArgs args = (EventArgs)e;
				this.OnApplicationSizeChanged(sender, args);
				return true;
			}
			return false;
		}

		private void AttachSizeChangedEvents()
		{
			if (!this.IsInDesignMode && !this.sizeChangedEventsAttached)
			{

				if (!this.IsInWinForms)
				{

					SizeChangedEventManager.AddListener(Application.Current.MainWindow, this);
				}

				this.sizeChangedEventsAttached = true;
			}
		}
	}
}
