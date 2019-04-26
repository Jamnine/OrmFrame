using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Orm.Toolkit.Telerik.Windows;
//using Orm.Toolkit.Telerik.Windows.Controls.Design;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A SplitButton control.
	/// </summary>
	public class RadSplitButton : ContentControl
	{
		/// <summary>
		/// Identifies the CornerRadius property.
		/// </summary>
		public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RadSplitButton), new PropertyMetadata());

		/// <summary>
		/// Identifies the IsBackgroundVisible property.
		/// </summary>
		public static readonly DependencyProperty IsBackgroundVisibleProperty = DependencyProperty.Register("IsBackgroundVisible", typeof(bool), typeof(RadSplitButton), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the CommandParameter property.
		/// </summary>
		public static readonly DependencyProperty CommandParameterProperty =
			DependencyProperty.Register("CommandParameter",
				typeof(object),
				typeof(RadSplitButton),
				new PropertyMetadata(new PropertyChangedCallback(RadSplitButton.OnCommandParameterChanged)));

		/// <summary>
		/// Identifies the Command property.
		/// </summary>
		public static readonly DependencyProperty CommandProperty =
			DependencyProperty.Register("Command",
				typeof(ICommand),
				typeof(RadSplitButton),
				new PropertyMetadata(new PropertyChangedCallback(RadSplitButton.OnCommandChanged)));

		/// <summary>
		/// Identifies the CommandTarget property.
		/// </summary>
		public static readonly DependencyProperty CommandTargetProperty =
			DependencyProperty.Register("CommandTarget",
				typeof(UIElement),
				typeof(RadSplitButton),
				new PropertyMetadata(new PropertyChangedCallback(RadSplitButton.OnCommandTargetChanged)));

		/// <summary>
		/// Identifies the DropDownContent property.
		/// </summary>
		public static readonly DependencyProperty DropDownIndicatorVisibilityProperty = DependencyProperty.Register("DropDownIndicatorVisibility", typeof(Visibility), typeof(RadSplitButton), new PropertyMetadata(Visibility.Visible));

		/// <summary>
		/// Identifies the AutoOpenDelay property.
		/// </summary>
		public static readonly DependencyProperty AutoOpenDelayProperty = DependencyProperty.Register("AutoOpenDelay", typeof(TimeSpan), typeof(RadSplitButton), new PropertyMetadata(TimeSpan.Zero, RadSplitButton.OnAutoOpenDelayChanged));

		/// <summary>
		/// Identifies the CloseOnEscape property.
		/// </summary>
		public static readonly DependencyProperty CloseOnEscapeProperty = DependencyProperty.Register("CloseOnEscape", typeof(bool), typeof(RadSplitButton), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the IsChecked property.
		/// </summary>
		public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register("IsChecked", typeof(bool), typeof(RadSplitButton), new PropertyMetadata(false, (d, a) => (d as RadSplitButton).OnIsCheckedChanged()));

		/// <summary>
		/// Identifies the IsToggle property.
		/// </summary>
		public static readonly DependencyProperty IsToggleProperty = DependencyProperty.Register("IsToggle", typeof(bool), typeof(RadSplitButton), new PropertyMetadata(false, (d, a) => (d as RadSplitButton).OnIsToggleChanged()));

		/// <summary>
		/// Identifies the DropDownContent property.
		/// </summary>
		public static readonly DependencyProperty DropDownContentProperty =
			DependencyProperty.Register("DropDownContent",
				typeof(object),
				typeof(RadSplitButton),
				new PropertyMetadata(null, RadSplitButton.OnDropDownContentChanged, null));

		/// <summary>
		/// Identifies the PopupWidth property.
		/// </summary>
		public static readonly DependencyProperty DropDownWidthProperty =
			DependencyProperty.Register("DropDownWidth",
				typeof(double),
				typeof(RadSplitButton),
				new PropertyMetadata(double.NaN));

		/// <summary>
		/// Identifies the PopupHeight property.
		/// </summary>
		public static readonly DependencyProperty DropDownHeightProperty =
			DependencyProperty.Register("DropDownHeight",
				typeof(double),
				typeof(RadSplitButton),
				new PropertyMetadata(double.NaN));

		/// <summary>
		/// Identifies the PopupMaxWidth property.
		/// </summary>
		public static readonly DependencyProperty DropDownMaxWidthProperty =
			DependencyProperty.Register("DropDownMaxWidth",
				typeof(double),
				typeof(RadSplitButton),
				new PropertyMetadata(double.PositiveInfinity));

		/// <summary>
		/// Identifies the PopupMaxHeight property.
		/// </summary>
		public static readonly DependencyProperty DropDownMaxHeightProperty =
			DependencyProperty.Register("DropDownMaxHeight",
				typeof(double),
				typeof(RadSplitButton),
				new PropertyMetadata(double.PositiveInfinity));

		/// <summary>
		/// Identifies the IsOpen property.
		/// </summary>
		public static readonly DependencyProperty IsOpenProperty =
			DependencyProperty.Register("IsOpen",
				typeof(bool),
				typeof(RadSplitButton),
				new PropertyMetadata(false, RadSplitButton.OnIsOpenChanged));



		/// <summary>
		/// Identifies the DropDownButtonPosition property.
		/// </summary>
		public static readonly DependencyProperty DropDownButtonPositionProperty =
			DependencyProperty.Register("DropDownButtonPosition",
				typeof(DropDownButtonPosition),
				typeof(RadSplitButton),
				new PropertyMetadata(DropDownButtonPosition.Right, (d, a) => (d as RadSplitButton).OnDropDownButtonPositionChanged((DropDownButtonPosition)a.NewValue), null));

		/// <summary>
		/// Identifies the PopupPlacement property.
		/// </summary>

		public static readonly DependencyProperty DropDownPlacementProperty =
			DependencyProperty.Register("DropDownPlacement",
				typeof(System.Windows.Controls.Primitives.PlacementMode),
				typeof(RadSplitButton),
				new PropertyMetadata(System.Windows.Controls.Primitives.PlacementMode.Bottom, (d, a) => (d as RadSplitButton).OnDropDownPlacementChanged((System.Windows.Controls.Primitives.PlacementMode)a.NewValue), null));


		/// <summary>
		/// Identifies the DropDownContentTemplate property.
		/// </summary>
		public static readonly DependencyProperty DropDownContentTemplateProperty =
			DependencyProperty.Register("DropDownContentTemplate",
				typeof(DataTemplate),
				typeof(RadSplitButton),
				new PropertyMetadata(RadSplitButton.OnDropDownContentTemplateChanged));

		/// <summary>
		/// Identifies the DropDownContentTemplateSelector property.
		/// </summary>
		public static readonly DependencyProperty DropDownContentTemplateSelectorProperty =
			DependencyProperty.Register("DropDownContentTemplateSelector",
				typeof(DataTemplateSelector),
				typeof(RadSplitButton),
				new PropertyMetadata(RadSplitButton.OnDropDownContentTemplateSelectorChanged));

		/// <summary>
		/// Identifies the Click property.
		/// </summary>
		public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent("Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RadSplitButton));

		/// <summary>
		/// Occurs when the Button part become checked.
		/// </summary>
		public static readonly RoutedEvent CheckedEvent = EventManager.RegisterRoutedEvent("Checked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RadSplitButton));

		/// <summary>
		/// Occurs when the Button part become unchecked.
		/// </summary>
		public static readonly RoutedEvent UncheckedEvent = EventManager.RegisterRoutedEvent("Unchecked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RadSplitButton));

		/// <summary>
		/// Identifies the Activate routed event.
		/// </summary>
		public static readonly RoutedEvent ActivateEvent = EventManager.RegisterRoutedEvent("Activate", RoutingStrategy.Bubble, typeof(EventHandler<RadRoutedEventArgs>), typeof(RadSplitButton));

		/// <summary>
		/// Identifies the DropDownClosed property.
		/// </summary>
		public static readonly RoutedEvent DropDownClosedEvent =
			EventManager.RegisterRoutedEvent("DropDownClosed",
				RoutingStrategy.Bubble,
				typeof(RoutedEventHandler),
				typeof(RadSplitButton));

		/// <summary>
		/// Identifies the DropDownOpened property.
		/// </summary>
		public static readonly RoutedEvent DropDownOpenedEvent =
			EventManager.RegisterRoutedEvent("DropDownOpened",
				RoutingStrategy.Bubble,
				typeof(RoutedEventHandler),
				typeof(RadSplitButton));

		/// <summary>
		/// Identifies the DropDownOpening property.
		/// </summary>
		public static readonly RoutedEvent DropDownOpeningEvent =
			EventManager.RegisterRoutedEvent("DropDownOpening",
				RoutingStrategy.Bubble,
				typeof(RadRoutedEventHandler),
				typeof(RadSplitButton));


		/// <summary>
		/// How many [ms] to wait before to enable a Toggle.
		/// </summary>
		internal static int preventReopenTimeout = 555;

		// Guards the handler against the garbage collecting:
		private EventHandler guardCanExecuteChangedHandler;
		private System.Windows.Threading.DispatcherTimer autoOpenTimer = null;
		private bool isTemplateApplied;

		private DateTime popupClosedIn = DateTime.MinValue;



		static RadSplitButton()
		{
			IsTabStopProperty.OverrideMetadata(typeof(RadSplitButton), new FrameworkPropertyMetadata(false));
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadSplitButton),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadSplitButton))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadSplitButton), new FrameworkPropertyMetadata(typeof(RadSplitButton)));
		}


		/// <summary>
		/// Initializes a new instance of the RadSplitButton class.
		/// </summary>
		public RadSplitButton()
		{

			this.Loaded += this.OnLoaded;
            //TelerikLicense.Verify(this);//禁止验证许可
		}

		/// <summary>
		/// Gets or sets a value that represents the degree to which the corners of the control are rounded. This is a dependency property.
		/// </summary>
		public CornerRadius CornerRadius
		{
			get
			{
				return (CornerRadius)base.GetValue(CornerRadiusProperty);
			}
			set
			{
				base.SetValue(CornerRadiusProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome not to render in Normal mode.
		/// </summary>
		[Browsable(false)]
		public bool IsBackgroundVisible
		{
			get
			{
				return (bool)GetValue(IsBackgroundVisibleProperty);
			}
			set
			{
				SetValue(IsBackgroundVisibleProperty, value);
			}
		}

		/// <summary>
		/// Occurs when the action button is clicked.
		/// </summary>
		public event RoutedEventHandler Click
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
		/// Occurs when the action button is checked.
		/// </summary>
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
		/// Occurs when the action button is unchecked.
		/// </summary>
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
		/// Occurs when the action button is clicked.
		/// </summary>
		public event EventHandler<RadRoutedEventArgs> Activate
		{
			add
			{
				this.AddHandler(ActivateEvent, value);
			}
			remove
			{
				this.RemoveHandler(ActivateEvent, value);
			}
		}

		/// <summary>
		/// Occurs when the Popup closed.
		/// </summary>
		public event RoutedEventHandler DropDownClosed
		{
			add
			{
				this.AddHandler(DropDownClosedEvent, value);
			}
			remove
			{
				this.RemoveHandler(DropDownClosedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when the Popup opened.
		/// </summary>
		public event RoutedEventHandler DropDownOpened
		{
			add
			{
				this.AddHandler(DropDownOpenedEvent, value);
			}
			remove
			{
				this.RemoveHandler(DropDownOpenedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when the Popup will be opened.
		/// If the event handler set True for the Handled proterty then the Popup doesn't open.
		/// </summary>
		public event RoutedEventHandler DropDownOpening
		{
			add
			{
				this.AddHandler(DropDownOpeningEvent, value);
			}
			remove
			{
				this.RemoveHandler(DropDownOpeningEvent, value);
			}
		}

		/// <summary>
		/// Gets the command that will be executed when the command source is invoked.
		/// This is a dependency property.
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
		/// This is a dependency property.
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
		/// This is a dependency property.
		/// </summary>
		public UIElement CommandTarget
		{
			get
			{
				return (UIElement)this.GetValue(CommandTargetProperty);
			}
			set
			{
				this.SetValue(CommandTargetProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets whether the popup window is expanded.
		/// This is a dependency property.
		/// </summary>
		public bool IsOpen
		{
			get
			{
				return (bool)GetValue(IsOpenProperty);
			}
			set
			{
				SetValue(IsOpenProperty, value);
			}
		}


		/// <summary>
		/// Gets or sets whether the DropDown indicator visibility.
		/// This is a dependency property.
		/// </summary>
		public Visibility DropDownIndicatorVisibility
		{
			get
			{
				return (Visibility)GetValue(DropDownIndicatorVisibilityProperty);
			}
			set
			{
				SetValue(DropDownIndicatorVisibilityProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets whether the popup opens when mouse hovers for pointed milliseconds
		/// Value of zero means no auto open.
		/// This is a dependency property.
		/// </summary>
		[Browsable(false)]
		public TimeSpan AutoOpenDelay
		{
			get
			{
				return (TimeSpan)GetValue(AutoOpenDelayProperty);
			}
			set
			{
				SetValue(AutoOpenDelayProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets whether the popup closes when the Escape key toggles.
		/// This is a dependency property.
		/// </summary>
		public bool CloseOnEscape
		{
			get
			{
				return (bool)GetValue(CloseOnEscapeProperty);
			}
			set
			{
				SetValue(CloseOnEscapeProperty, value);
			}
		}

		/// <summary>
		/// Simulates the IsChecked of the ToggleButton.
		/// This is a dependency property.
		/// </summary>
		public bool IsChecked
		{
			get
			{
				return this.IsToggle && (bool)GetValue(IsCheckedProperty);
			}
			set
			{
				SetValue(IsCheckedProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets whether the popup supports toggle mode.
		/// This is a dependency property.
		/// </summary>
		public bool IsToggle
		{
			get
			{
				return (bool)GetValue(IsToggleProperty);
			}
			set
			{
				SetValue(IsToggleProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a content to popup.
		/// This is a dependency property.
		/// </summary>
		public object DropDownContent
		{
			get
			{
				return GetValue(DropDownContentProperty);
			}
			set
			{
				SetValue(DropDownContentProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the position of the drop down indicator.
		/// This is a dependency property.
		/// </summary>
		public DropDownButtonPosition DropDownButtonPosition
		{
			get
			{
				return (DropDownButtonPosition)GetValue(DropDownButtonPositionProperty);
			}
			set
			{
				SetValue(DropDownButtonPositionProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the position of the popup.
		/// This is a dependency property.
		/// </summary>

		public System.Windows.Controls.Primitives.PlacementMode DropDownPlacement
		{
			get
			{
				return (System.Windows.Controls.Primitives.PlacementMode)GetValue(DropDownPlacementProperty);

			}
			set
			{
				SetValue(DropDownPlacementProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the template used to display the drop-down content of the button.
		/// This is a dependency property.
		/// </summary>
		public DataTemplate DropDownContentTemplate
		{
			get
			{
				return (DataTemplate)GetValue(DropDownContentTemplateProperty);
			}
			set
			{
				SetValue(DropDownContentTemplateProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the template used to display the drop-down content of the button.
		/// This is a dependency property.
		/// </summary>
		public DataTemplateSelector DropDownContentTemplateSelector
		{
			get
			{
				return (DataTemplateSelector)GetValue(DropDownContentTemplateSelectorProperty);
			}
			set
			{
				SetValue(DropDownContentTemplateSelectorProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the Width of the popup.
		/// This is a dependency property.
		/// </summary>
		public double DropDownWidth
		{
			get
			{
				return (double)GetValue(DropDownWidthProperty);
			}
			set
			{
				SetValue(DropDownWidthProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the Height of the popup.
		/// This is a dependency property.
		/// </summary>
		public double DropDownHeight
		{
			get
			{
				return (double)GetValue(DropDownHeightProperty);
			}
			set
			{
				SetValue(DropDownHeightProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the MaxWidth of the popup.
		/// This is a dependency property.
		/// </summary>
		public double DropDownMaxWidth
		{
			get
			{
				return (double)GetValue(DropDownMaxWidthProperty);
			}
			set
			{
				SetValue(DropDownMaxWidthProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the MaxHeight of the popup.
		/// This is a dependency property.
		/// </summary>
		public double DropDownMaxHeight
		{
			get
			{
				return (double)GetValue(DropDownMaxHeightProperty);
			}
			set
			{
				SetValue(DropDownMaxHeightProperty, value);
			}
		}

		internal Popup DropDownPopup
		{
			get;
			set;
		}



		internal RadButton ActionButton
		{
			get;
			set;
		}

		internal RadToggleButton DropDownButton
		{
			get;
			set;
		}

		/// <summary>
		/// Get/set te placement for the popup element.
		/// </summary>
		internal FrameworkElement PopupPlacementTarget
		{
			get;
			set;
		}

		/// <summary>
		/// Invoked whenever application code or internal processes
		/// (such as a rebuilding layout pass) call.
		/// <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			if (this.IsOpen)
			{
				this.IsOpen = false;
			}
			base.OnApplyTemplate();
			this.isTemplateApplied = true;

			this.SetDropDownContentTemplate();

			this.InitializeElements();
			this.InitializeDropdownPopup();
			this.UpdateVisualState(false);
		}



		internal virtual void UpdateVisualState(bool useTransitions)
		{

			this.ApplyDropDownButtonPositionState();
			this.ApplyDropDownPlacementState();
		}



		/// <summary>
		/// Initializes the position of the DropDown indicator and
		/// correct the placement of the Popup window.
		/// </summary>
		internal virtual void ApplyDropDownButtonPositionState()
		{
			if (this.DropDownButtonPosition == DropDownButtonPosition.Left)
			{

			}
			else if (this.DropDownButtonPosition == DropDownButtonPosition.Right)
			{

			}
			else if (this.DropDownButtonPosition == DropDownButtonPosition.Top)
			{

			}
			else
			{

			}
		}

		/// <summary>
		/// Set the placement of the Popup window.
		/// </summary>
		internal virtual void ApplyDropDownPlacementState()
		{

		}

		internal void OnClickInternal()
		{
			this.OnClick();
		}

		internal void SetPopupPlacementTarget(FrameworkElement placementTarget)
		{
			this.PopupPlacementTarget = placementTarget;

			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.PlacementTarget = this.PopupPlacementTarget;
			}

		}



		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		internal void ApplyPopupPlacement()
        {

		}

		/// <summary>
		/// Raises the <see cref="E:Activate"/> event.
		/// </summary>
		protected internal virtual void OnActivate()
		{
			this.RaiseEvent(new RadRoutedEventArgs(ActivateEvent, this));
		}

		/// <summary>
		/// Toggle the IsOpen property and execute the associated Command.
		/// </summary>
		protected virtual void OnClick()
		{
			//RadRoutedEventArgs e = this.RaiseClick();
			//if (e.Handled)
			//{
			//    return;
			//}

			this.OnToggle();
			this.RaiseClick();
			this.OnActivate();
			this.ExecuteCommand();
		}

		/// <summary>
		/// Toggle the IsChecked property and raise the Checked/Unchecked events.
		/// </summary>
		protected virtual void OnToggle()
		{
			if (this.IsToggle)
			{
				this.IsChecked = !this.IsChecked;
			}
		}

		/// <summary>
		/// Called when IsChecked property is initialised to true. Raises the Checked events.
		/// </summary>
		protected virtual void OnChecked()
		{
			this.RaiseChecked();
		}

		/// <summary>
		/// Called when IsChecked property is initialised to false. Raises the Unchecked events.
		/// </summary>
		protected virtual void OnUnchecked()
		{
			this.RaiseUnchecked();
		}

		/// <summary>
		/// Closes the popup on Escape key.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled)
			{
				if (e.Key == Key.Escape)
				{
					if (this.IsOpen && this.CloseOnEscape)
					{
						this.IsOpen = false;
						e.Handled = true;
						this.Focus();
					}
				}
				else if (e.Key == Key.Down)
				{
					if (!this.IsOpen)
					{
						this.IsOpen = true;
						e.Handled = true;
					}
				}
			}
		}

		/// <summary>
		/// Handles the mouse over and starts the auto open timer.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseEnter(MouseEventArgs e)
		{
			base.OnMouseEnter(e);

			this.AutoOpenTimerStart();
		}

		/// <summary>
		/// Handles the mouse over and stops the auto open timer.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseLeave(MouseEventArgs e)
		{
			this.AutoOpenTimerStop();

			base.OnMouseLeave(e);
		}

		/// <summary>
		/// Restarts the auto open timer.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			this.AutoOpenTimerRestart();
			base.OnMouseMove(e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		protected virtual void OnDropDownContentChanged(object oldValue, object newValue)
		{
		}

		/// <summary>
		/// Called when the DropDownContentTemplate property of a RadSplitButton changes.
		/// </summary>
		/// <param name="oldValue">The old value of the DropDownContentTemplate property.</param>
		/// <param name="newValue">The new value of the DropDownContentTemplate property.</param>
		protected virtual void OnDropDownContentTemplateChanged(DataTemplate oldValue, DataTemplate newValue)
		{
			this.SetDropDownContentTemplate();
		}

		/// <summary>
		/// Called when the DropDownContentTemplateSelector property of a RadSplitButton changes.
		/// </summary>
		/// <param name="oldValue">The old value of the DropDownContentTemplateSelector property.</param>
		/// <param name="newValue">The new value of the DropDownContentTemplateSelector property.</param>
		protected virtual void OnDropDownContentTemplateSelectorChanged(DataTemplateSelector oldValue, DataTemplateSelector newValue)
		{
			this.SetDropDownContentTemplate();
		}


		/// <summary>
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event.
		/// This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadSplitButton));
		}


		private static void OnDropDownContentTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadSplitButton)d).OnDropDownContentTemplateChanged(e.OldValue as DataTemplate, e.NewValue as DataTemplate);
		}

		private static void OnDropDownContentTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadSplitButton)d).OnDropDownContentTemplateSelectorChanged(e.OldValue as DataTemplateSelector, e.NewValue as DataTemplateSelector);
		}

		private static void OnCommandParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadSplitButton button = d as RadSplitButton;
			if (button != null)
			{
				button.CanExecuteApply();
			}
		}

		private static void OnCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadSplitButton button = d as RadSplitButton;
			if (button != null)
			{
				button.ChangeCommand((ICommand)e.OldValue, (ICommand)e.NewValue);
			}
		}

		private static void OnCommandTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadSplitButton button = d as RadSplitButton;
			if (button != null)
			{
				button.CanExecuteApply();
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "e")]
		private static void OnAutoOpenDelayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadSplitButton button = d as RadSplitButton;
			if (button != null)
			{
				button.AutoOpenTimerApplyState(true);
			}
		}

		private static void OnDropDownContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadSplitButton button = d as RadSplitButton;
			if (button != null)
			{
				button.UpdateVisualState(false);
				button.OnDropDownContentChanged(e.OldValue, e.NewValue);
			}
		}

		private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadSplitButton button = d as RadSplitButton;
			if (button != null)
			{
				bool newValue = (bool)e.NewValue;
				if (newValue)
				{
					RadRoutedEventArgs args = button.RaisePopupOpening();
					if (args.Handled)
					{
						button.IsOpen = false;
						return;
					}

				}
			}
		}



		private void OnAutoOpenTimerTick(object sender, EventArgs e)
		{
			if (!this.IsOpen)
			{
				this.Focus();
				this.IsOpen = true;
			}
			this.AutoOpenTimerStop();
		}

		private RadRoutedEventArgs RaiseClick()
		{
			return RadButton.RaiseRadRoutedEvent(ClickEvent, this);
		}

		private RadRoutedEventArgs RaiseChecked()
		{
			return RadButton.RaiseRadRoutedEvent(CheckedEvent, this);
		}

		private RadRoutedEventArgs RaiseUnchecked()
		{
			return RadButton.RaiseRadRoutedEvent(UncheckedEvent, this);
		}

		private void RaisePopupClosed()
		{
			this.RaiseEvent(new RadRoutedEventArgs(DropDownClosedEvent, this));
		}

		private void RaisePopupOpened()
		{
			this.RaiseEvent(new RadRoutedEventArgs(DropDownOpenedEvent, this));
		}

		private RadRoutedEventArgs RaisePopupOpening()
		{
			RadRoutedEventArgs args = new RadRoutedEventArgs(DropDownOpeningEvent, this);
			this.RaiseEvent(args);
			return args;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "newValue")]
		private void OnDropDownButtonPositionChanged(DropDownButtonPosition newValue)
		{
			this.UpdateVisualState(false);
		}

		private void OnIsToggleChanged()
		{
			this.UpdateVisualState(false);
		}

		private void OnIsCheckedChanged()
		{
			this.UpdateVisualState(false);
			if (this.IsToggle)
			{
				if (this.IsChecked)
				{
					this.OnChecked();
				}
				else
				{
					this.OnUnchecked();
				}
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "newValue")]

		private void OnDropDownPlacementChanged(System.Windows.Controls.Primitives.PlacementMode newValue)

		{
			this.UpdateVisualState(false);
		}

		private void DropDownPopup_KeyDown(object sender, KeyEventArgs e)
		{
			if (!e.Handled)
			{
				if (this.IsOpen && this.CloseOnEscape && e.Key == Key.Escape)
				{
					e.Handled = true;
					this.IsOpen = false;
					this.Focus();
				}
			}
		}

		private void InitializeElements()
		{

			if (this.ActionButton != null)
			{
				this.ActionButton.Click -= this.ActionButton_Click;
			}

			this.ActionButton = GetTemplateChild("ButtonPart") as RadButton;
			this.DropDownButton = GetTemplateChild("DropDownPart") as RadToggleButton;

			if (this.ActionButton != null)
			{
				this.ActionButton.Click += this.ActionButton_Click;
			}
			if (this.DropDownButton != null)
			{
				this.DropDownButton.IsChecked = this.IsOpen;

				this.DropDownButton.PreviewClick += this.DropDownButton_PreviewClick;

			}
		}

		private void ActionButton_Click(object sender, RoutedEventArgs e)
		{
			this.OnClick();
		}



		private void InitializeDropdownPopup()
		{
			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.Opened -= this.DropDownPopupOpened;
				this.DropDownPopup.Closed -= this.DropDownPopupClosed;
				if (this.DropDownPopup.Child != null)
				{
					this.DropDownPopup.Child.KeyDown -= this.DropDownPopup_KeyDown;
				}

			}
			DependencyObject dependencyObject = GetTemplateChild("DropDownPopup");
			this.DropDownPopup = dependencyObject as Popup;
			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.Opened += this.DropDownPopupOpened;
				this.DropDownPopup.Closed += this.DropDownPopupClosed;
				if (this.DropDownPopup.Child != null)
				{
					this.DropDownPopup.Child.KeyDown += this.DropDownPopup_KeyDown;
				}

				this.DropDownPopup.Placement = this.DropDownPlacement;
				this.DropDownPopup.PlacementTarget = this.PopupPlacementTarget;

			}
		}

		private void DropDownPopupClosed(object sender, EventArgs e)
		{
			this.RaisePopupClosed();
			if (this.IsOpen)
			{
				this.IsOpen = false;
			}

			this.popupClosedIn = DateTime.Now;

		}

		private void DropDownPopupOpened(object sender, EventArgs e)
		{
			this.RaisePopupOpened();
			if (!this.IsOpen)
			{
				this.IsOpen = true;
			}
		}

		private void SetDropDownContentTemplate()
		{
			if (this.isTemplateApplied == true)
			{
				DataTemplate template = null;
				if (this.DropDownContentTemplateSelector != null)
				{
					template = this.DropDownContentTemplateSelector.SelectTemplate(this.DropDownContent, this);
				}

				if (template == null)
				{
					template = this.DropDownContentTemplate;
				}

				if (template != null)
				{
					DependencyObject element = this.GetTemplateChild("DropDownPopupContent");
					ContentPresenter dropDownContentElement = element as ContentPresenter;
					if (dropDownContentElement != null && !template.Equals(dropDownContentElement.ContentTemplate))
					{
						dropDownContentElement.ContentTemplate = template;
					}
				}
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
		private bool AutoOpenTimerApplyState(bool applyAction)
		{
			double milliseconds = this.AutoOpenDelay.TotalMilliseconds;
			if (milliseconds > 0)
			{
				if (this.autoOpenTimer == null)
				{
					this.autoOpenTimer = new System.Windows.Threading.DispatcherTimer();
					this.autoOpenTimer.Tick += this.OnAutoOpenTimerTick;
				}

				if (milliseconds != this.autoOpenTimer.Interval.TotalMilliseconds)
				{
					this.autoOpenTimer.Interval = this.AutoOpenDelay;
				}

				if (applyAction)
				{
					if (this.IsMouseOver)
					{
						this.AutoOpenTimerStart();
					}
					else
					{
						this.AutoOpenTimerStop();
					}
				}
			}
			else
			{
				this.AutoOpenTimerDestroy();
			}
			return this.autoOpenTimer != null;
		}

		private void AutoOpenTimerDestroy()
		{
			if (this.autoOpenTimer != null)
			{
				this.autoOpenTimer.Stop();
				this.autoOpenTimer.Tick -= this.OnAutoOpenTimerTick;
				this.autoOpenTimer = null;
			}
		}

		private void AutoOpenTimerStart()
		{
			if (this.AutoOpenTimerApplyState(false))
			{
				this.autoOpenTimer.Start();
			}
		}

		private void AutoOpenTimerStop()
		{
			if (this.AutoOpenTimerApplyState(false))
			{
				this.autoOpenTimer.Stop();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void AutoOpenTimerRestart()
		{
			if (this.AutoOpenTimerApplyState(false))
			{
				this.autoOpenTimer.Start();
			}
		}

		private void OnLoaded(object sender, EventArgs e)
		{
			this.CanExecuteApply();
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

				this.IsEnabled = (routedCommand == null) ?
					this.Command.CanExecute(this.CommandParameter) :
					routedCommand.CanExecute(this.CommandParameter, this.CommandTarget ?? this);
			}
		}

		private void ChangeCommand(ICommand oldCommand, ICommand newCommand)
		{
			if (oldCommand != null)
			{
				// Remove handlers from the oldCommand:
				oldCommand.CanExecuteChanged -= new EventHandler(this.CanExecuteChanged);
			}
			if (newCommand != null)
			{
				// Add handlers to the oldCommand:
				this.guardCanExecuteChangedHandler = new EventHandler(this.CanExecuteChanged);
				newCommand.CanExecuteChanged += this.guardCanExecuteChangedHandler;
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


		void DropDownButton_PreviewClick(object sender, RoutedEventArgs e)
		{
			if (!this.IsOpen && (DateTime.Now - this.popupClosedIn).TotalMilliseconds < RadSplitButton.preventReopenTimeout)
			{
				e.Handled = true;
				this.popupClosedIn = DateTime.MinValue;
			}
		}

	}
}
