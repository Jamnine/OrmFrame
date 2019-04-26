using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using Orm.Toolkit.Telerik.Windows;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A DropDownButton control.
	/// </summary>
	public class RadDropDownButton
		: RadButton
	{
		/// <summary>
		/// Identifies the DropDownContent property.
		/// </summary>
		public static readonly DependencyProperty DropDownIndicatorVisibilityProperty = DependencyProperty.Register("DropDownIndicatorVisibility", typeof(Visibility), typeof(RadDropDownButton), new PropertyMetadata(Visibility.Visible));

		/// <summary>
		/// Identifies the AutoOpenDelay property.
		/// </summary>
		public static readonly DependencyProperty AutoOpenDelayProperty = DependencyProperty.Register("AutoOpenDelay", typeof(TimeSpan), typeof(RadDropDownButton), new PropertyMetadata(TimeSpan.Zero, RadDropDownButton.OnAutoOpenDelayChanged));

		/// <summary>
		/// Identifies the CloseOnEscape property.
		/// </summary>
		public static readonly DependencyProperty CloseOnEscapeProperty = DependencyProperty.Register("CloseOnEscape", typeof(bool), typeof(RadDropDownButton), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the CloseOnEnter property.
		/// </summary>
		public static readonly DependencyProperty CloseOnEnterProperty = DependencyProperty.Register("CloseOnEnter", typeof(bool), typeof(RadDropDownButton), new PropertyMetadata(false));

		/// <summary>
		/// Identifies the DropDownContent property.
		/// </summary>
		public static readonly DependencyProperty DropDownContentProperty =
			DependencyProperty.Register("DropDownContent",
				typeof(object),
				typeof(RadDropDownButton),
				new PropertyMetadata(null, RadDropDownButton.OnDropDownContentChanged, null));

		/// <summary>
		/// Identifies the PopupWidth property.
		/// </summary>
		public static readonly DependencyProperty DropDownWidthProperty =
			DependencyProperty.Register("DropDownWidth",
				typeof(double),
				typeof(RadDropDownButton),
				new PropertyMetadata(double.NaN));

		/// <summary>
		/// Identifies the PopupHeight property.
		/// </summary>
		public static readonly DependencyProperty DropDownHeightProperty =
			DependencyProperty.Register("DropDownHeight",
				typeof(double),
				typeof(RadDropDownButton),
				new PropertyMetadata(double.NaN));

		/// <summary>
		/// Identifies the PopupMaxWidth property.
		/// </summary>
		public static readonly DependencyProperty DropDownMaxWidthProperty =
			DependencyProperty.Register("DropDownMaxWidth",
				typeof(double),
				typeof(RadDropDownButton),
				new PropertyMetadata(double.PositiveInfinity));

		/// <summary>
		/// Identifies the PopupMaxHeight property.
		/// </summary>
		public static readonly DependencyProperty DropDownMaxHeightProperty =
			DependencyProperty.Register("DropDownMaxHeight",
				typeof(double),
				typeof(RadDropDownButton),
				new PropertyMetadata(double.PositiveInfinity));

		/// <summary>
		/// Identifies the IsOpen property.
		/// </summary>
		public static readonly DependencyProperty IsOpenProperty =
			DependencyProperty.Register("IsOpen",
				typeof(bool),
				typeof(RadDropDownButton),
				new PropertyMetadata(false, RadDropDownButton.OnIsOpenChanged, null));

		/// <summary>
		/// Identifies the DropDownButtonPosition property.
		/// </summary>
		public static readonly DependencyProperty DropDownButtonPositionProperty =
			DependencyProperty.Register("DropDownButtonPosition",
				typeof(DropDownButtonPosition),
				typeof(RadDropDownButton),
				new PropertyMetadata(DropDownButtonPosition.Right, (d, a) => (d as RadDropDownButton).OnDropDownButtonPositionChanged((DropDownButtonPosition)a.NewValue), null));

		/// <summary>
		/// Identifies the DropDownPlacement property.
		/// </summary>
		public static readonly DependencyProperty DropDownPlacementProperty =
			DependencyProperty.Register("DropDownPlacement",
				typeof(PlacementMode),
				typeof(RadDropDownButton),
				new PropertyMetadata(PlacementMode.Bottom, RadDropDownButton.OnDropDownPlacementChanged, null));

		/// <summary>
		/// Identifies the PopupPlacementTarget property.
		/// </summary>
		public static readonly DependencyProperty PopupPlacementTargetProperty =
			DependencyProperty.Register("PopupPlacementTarget",
				typeof(FrameworkElement),
				typeof(RadDropDownButton),
				new PropertyMetadata(null, RadDropDownButton.OnPopupPlacementTargetChanged, null));


		/// <summary>
		/// Identifies the DropDownContentTemplate property.
		/// </summary>
		public static readonly DependencyProperty DropDownContentTemplateProperty =
			DependencyProperty.Register("DropDownContentTemplate",
				typeof(DataTemplate),
				typeof(RadDropDownButton),
				new PropertyMetadata(RadDropDownButton.OnDropDownContentTemplateChanged));

		/// <summary>
		/// Identifies the DropDownContentTemplateSelector property.
		/// </summary>
		public static readonly DependencyProperty DropDownContentTemplateSelectorProperty =
			DependencyProperty.Register("DropDownContentTemplateSelector",
				typeof(DataTemplateSelector),
				typeof(RadDropDownButton),
				new PropertyMetadata(RadDropDownButton.OnDropDownContentTemplateSelectorChanged));

		/// <summary>
		/// Identifies the DropDownClosed property.
		/// </summary>
		public static readonly RoutedEvent DropDownClosedEvent =
			EventManager.RegisterRoutedEvent("DropDownClosed",
				RoutingStrategy.Bubble,
				typeof(RoutedEventHandler),
				typeof(RadDropDownButton));

		/// <summary>
		/// Identifies the DropDownOpened property.
		/// </summary>
		public static readonly RoutedEvent DropDownOpenedEvent =
			EventManager.RegisterRoutedEvent("DropDownOpened",
				RoutingStrategy.Bubble,
				typeof(RoutedEventHandler),
				typeof(RadDropDownButton));

		/// <summary>
		/// Identifies the DropDownOpening property.
		/// </summary>
		public static readonly RoutedEvent DropDownOpeningEvent =
			EventManager.RegisterRoutedEvent("DropDownOpening",
				RoutingStrategy.Bubble,
				typeof(RadRoutedEventHandler),
				typeof(RadDropDownButton));

		private bool isTemplateApplied;
		private bool isLoaded;

		private DateTime popupClosedIn = DateTime.MinValue;
        private ButtonsPopupAdorner popupAdorner;
        private Canvas adornerCanvas;



		static RadDropDownButton()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadDropDownButton),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadDropDownButton))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadDropDownButton),
                new FrameworkPropertyMetadata(typeof(RadDropDownButton)));
		}


		/// <summary>
		/// Initializes a new instance of the RadDropDownButton class.
		/// </summary>
		public RadDropDownButton()
		{

            //TelerikLicense.Verify(this);//禁止验证许可

			this.Loaded += this.OnLoaded;
			this.Unloaded += this.OnUnloaded;
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
		/// Occurs when the Popup opening.
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
		/// Gets or sets whether the drop-down area is opened.
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
		/// Gets or sets whether the DropDown indicator is visible.
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
		/// Gets or sets whether the popup opens when mouse hovers for pointed milliseconds.
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
		/// Gets or sets whether the popup closes when the Enter key toggles.
		/// This is a dependency property.
		/// </summary>
		public bool CloseOnEnter
		{
			get
			{
				return (bool)GetValue(CloseOnEnterProperty);
			}
			set
			{
				SetValue(CloseOnEnterProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the drop-down area's content.
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
		/// Gets or sets the position of the drop-down area.
		/// This is a dependency property.
		/// </summary>
		public PlacementMode DropDownPlacement
		{
			get
			{
				return (PlacementMode)GetValue(DropDownPlacementProperty);
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
		/// Gets or sets the template-selector used to display the drop-down content of the button.
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
		/// Gets or sets the Width of the drop-down area.
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
		/// Gets or sets the Height of the drop-down area.
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
		/// Gets or sets the MaxWidth of the drop-down area.
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
		/// Gets or sets the MaxHeight of the drop-down area.
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

		/// <summary>
		/// Get/set te placement for the popup element.
		/// </summary>
		public FrameworkElement PopupPlacementTarget
		{
			get { return (FrameworkElement)GetValue(PopupPlacementTargetProperty); }
			set { SetValue(PopupPlacementTargetProperty, value); }
		}



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        internal bool IsBrowserHosted
        {
            get;
            set;
        }


		internal Popup DropDownPopup
		{
			get;
			set;
		}


        internal FrameworkElement DropDownPopupChild
        {
            get;
            set;
        }




		/// <summary>
		/// Invoked whenever application code or internal processes
		/// (such as a rebuilding layout pass) call 
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

			this.InitializeDropdownPopup();

			this.ApplyDropDownButtonPosition();
			this.ApplyPopupPlacement();
		}



		internal void SetPopupPlacementTarget(FrameworkElement placementTarget)
		{
			this.PopupPlacementTarget = placementTarget;

			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.PlacementTarget = this.PopupPlacementTarget;
			}

            if(this.popupAdorner != null)
            {
                this.adornerPlacementTraget = placementTarget;
            }

		}

		/// <summary>
		/// Initializes the placement of the Popup window.
		/// </summary>
		/// <param name="placement">
		/// Position to place the Popup window.
		/// </param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "placement"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]

		internal void SetPopupPlacement(System.Windows.Controls.Primitives.PlacementMode placement)
		{
			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.Placement = placement;
			}
            if (this.popupAdorner != null)
            {
                this.popupAdorner.Placement = placement;
            }

		}

		/// <summary>
		/// Invocated when the hover happens.
		/// </summary>
		protected internal override void OnHover()
		{
			if (!this.IsOpen)
			{
				this.Focus();
				this.IsOpen = true;
			}
		}

		/// <summary>
		/// Raises the <see cref="E:Activate"/> event.
		/// </summary>
		protected internal override void OnActivate()
		{
			//// do nothing - just brake the RadButton's ActivateEvent.
		}

		/// <summary>
		/// Invoke the base OnClick and toggle the IsOpen property.
		/// </summary>
		protected override void OnClick()
		{

			if ((DateTime.Now - this.popupClosedIn).TotalMilliseconds < RadSplitButton.preventReopenTimeout)
			{
				this.popupClosedIn = DateTime.MinValue;
				return;
			}

			if (this.IsOpen || this.DropDownContent != null)
			{
				this.IsOpen = !this.IsOpen;
			}
			base.OnClick();
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
				else if (e.Key == Key.Enter)
				{
					if (this.IsOpen && this.CloseOnEnter)
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
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event.
		/// This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadDropDownButton));
		}


		/// <summary>
		/// Initializes the position of the DropDown indicator and
		/// correct the placement of the Popup window.
		/// </summary>
		protected virtual void ApplyDropDownButtonPosition()
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
		protected virtual void ApplyPopupPlacement()
		{
			if (this.DropDownPlacement == PlacementMode.Left)
			{

				this.SetPopupPlacement(System.Windows.Controls.Primitives.PlacementMode.Left);

			}
			else if (this.DropDownPlacement == PlacementMode.Right)
			{

				this.SetPopupPlacement(System.Windows.Controls.Primitives.PlacementMode.Right);

			}
			else if (this.DropDownPlacement == PlacementMode.Top)
			{

				this.SetPopupPlacement(System.Windows.Controls.Primitives.PlacementMode.Top);

			}
			else
			{

				this.SetPopupPlacement(System.Windows.Controls.Primitives.PlacementMode.Bottom);

			}
		}

		/// <summary>
		/// Called when the DropDownContent property of a RadDropDownButton changes.
		/// </summary>
		/// <param name="oldValue">The old value of the DropDownContent property.</param>
		/// <param name="newValue">The new value of the DropDownContent property.</param>
		protected virtual void OnDropDownContentChanged(object oldValue, object newValue)
		{
		}

		/// <summary>
		/// Called when the DropDownPlacement property of a RadDropDownButton changes.
		/// </summary>
		/// <param name="oldValue">The old value of the DropDownPlacement property.</param>
		/// <param name="newValue">The new value of the DropDownPlacement property.</param>
		protected virtual void OnDropDownPlacementChanged(DataTemplate oldValue, DataTemplate newValue)
		{
			this.ApplyPopupPlacement();
		}

		/// <summary>
		/// Called when the DropDownContentTemplate property of a RadDropDownButton changes.
		/// </summary>
		/// <param name="oldValue">The old value of the DropDownContentTemplate property.</param>
		/// <param name="newValue">The new value of the DropDownContentTemplate property.</param>
		protected virtual void OnDropDownContentTemplateChanged(DataTemplate oldValue, DataTemplate newValue)
		{
			this.SetDropDownContentTemplate();
		}

		/// <summary>
		/// Called when the DropDownContentTemplateSelector property of a RadDropDownButton changes.
		/// </summary>
		/// <param name="oldValue">The old value of the DropDownContentTemplateSelector property.</param>
		/// <param name="newValue">The new value of the DropDownContentTemplateSelector property.</param>
		protected virtual void OnDropDownContentTemplateSelectorChanged(DataTemplateSelector oldValue, DataTemplateSelector newValue)
		{
			this.SetDropDownContentTemplate();
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "e")]
		private static void OnAutoOpenDelayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadDropDownButton button = d as RadDropDownButton;
			if (button != null)
			{
				button.HoverDelay = button.AutoOpenDelay;
			}
		}

		private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadDropDownButton button = d as RadDropDownButton;
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
				if (newValue)
				{
					button.OpenPopup();
				}
				else
				{

                    if (button.IsBrowserHosted)
                    {
                        button.popupAdorner.Close();
                        button.RaisePopupClosed();
                    }

				}

			}
		}

		private static void OnDropDownPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDropDownButton)d).OnDropDownPlacementChanged(e.OldValue as DataTemplate, e.NewValue as DataTemplate);
		}

		private static void OnPopupPlacementTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDropDownButton)d).SetPopupPlacementTarget(e.NewValue as FrameworkElement);
		}

		private static void OnDropDownContentTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDropDownButton)d).OnDropDownContentTemplateChanged(e.OldValue as DataTemplate, e.NewValue as DataTemplate);
		}

		private static void OnDropDownContentTemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDropDownButton)d).OnDropDownContentTemplateSelectorChanged(e.OldValue as DataTemplateSelector, e.NewValue as DataTemplateSelector);
		}

		private static void OnDropDownContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadDropDownButton button = d as RadDropDownButton;
			if (button != null)
			{

				button.OnDropDownContentChanged(e.OldValue, e.NewValue);
			}
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

		}


        private void PositionAdornerPopup()
        {
            if (this.adornerPlacementTraget != null && this.IsBrowserHosted)
            {
                var hostingWindow = Window.GetWindow(this);
				if (hostingWindow != null)
				{
					this.adornerCanvas.Width = hostingWindow.ActualWidth;
					this.adornerCanvas.Height = hostingWindow.ActualHeight;
					var topLeft = this.adornerPlacementTraget.TransformToAncestor(hostingWindow).Transform(new Point());

					if (popupAdorner.Placement == System.Windows.Controls.Primitives.PlacementMode.Bottom)
					{
						this.popupAdorner.Move(topLeft.X, topLeft.Y + adornerPlacementTraget.ActualHeight);
					}
					else if (popupAdorner.Placement == System.Windows.Controls.Primitives.PlacementMode.Right)
					{
						this.popupAdorner.Move(topLeft.X + adornerPlacementTraget.ActualWidth, topLeft.Y);
					}
					else if (popupAdorner.Placement == System.Windows.Controls.Primitives.PlacementMode.Relative)
					{
						this.popupAdorner.Move(topLeft.X, topLeft.Y);
					}
					else
					{
					}
				}
            }
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
				if (this.IsOpen && this.CloseOnEnter && e.Key == Key.Enter)
				{
					e.Handled = true;
					this.IsOpen = false;
					this.Focus();
				}
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
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

            if (this.IsBrowserHosted)
            {
                adornerCanvas = new Canvas()
                    {
                        Background = Brushes.Transparent
                    };
                adornerCanvas.MouseLeftButtonDown += new MouseButtonEventHandler(OnCanvasMouseLeftButtonDown);
                this.popupAdorner = new ButtonsPopupAdorner();
                Popup popup = dependencyObject as Popup;
                if (popup == null)
                {
                    return;
                }
                this.DropDownPopupChild = popup.Child as FrameworkElement;
                popup.Child = null;
                popupAdorner.Configure(this.DropDownPopupChild, adornerCanvas, false);
                this.RemovePopupFromVisualTree(popup);
                this.popupAdorner.Opened -= this.DropDownPopupOpened;
            }
            else 
            {
                this.DropDownPopup = dependencyObject as Popup;
            }

			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.Opened += this.DropDownPopupOpened;
				this.DropDownPopup.Closed += this.DropDownPopupClosed;
				if (this.DropDownPopup.Child != null)
				{
					this.DropDownPopup.Child.KeyDown += this.DropDownPopup_KeyDown;
				}

				this.DropDownPopup.PlacementTarget = this.PopupPlacementTarget;
                if (this.IsBrowserHosted)
                {
                    this.adornerPlacementTraget = this.PopupPlacementTarget;
                }

			}
        }


        private void OnCanvasMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.IsOpen = false;
        }

        private FrameworkElement adornerPlacementTraget;

        private void RemovePopupFromVisualTree(Popup popup)
        {
            System.Windows.Data.BindingOperations.ClearAllBindings(popup);
            var dummyBinding = new System.Windows.Data.Binding("");
            dummyBinding.Mode = System.Windows.Data.BindingMode.OneTime;
            popup.SetBinding(Popup.IsOpenProperty, dummyBinding);

            popupAdorner.VerticalOffset = popup.VerticalOffset;
            popupAdorner.HorizontalOffset = popup.HorizontalOffset;

            adornerPlacementTraget = popup.PlacementTarget as FrameworkElement;
            if (adornerPlacementTraget == null)
            {
                adornerPlacementTraget = this;
            }

            var parent = VisualTreeHelper.GetParent(popup);
            var panel = parent as Panel;
            if (panel != null)
            {
                panel.Children.Remove(popup);
            }
            var border = parent as Border;
            if (border != null)
            {
                border.Child = null;
            }
            var contentControl = parent as ContentControl;
            if (contentControl != null)
            {
                contentControl.Content = null;
            }
        }

		private void OpenPopup()
		{
			if (this.isLoaded)
			{

				if (this.IsBrowserHosted)
				{
					this.PositionAdornerPopup();
					this.popupAdorner.Open(true);
				}

			}
		}

		private void OnLoaded(object sender, EventArgs e)
		{
			this.isLoaded = true;
			if (this.IsOpen)
			{
				this.OpenPopup();
			}
		}

		private void OnUnloaded(object sender, EventArgs e)
		{
			this.isLoaded = false;
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

		private void DropDownPopupOpened(object sender, EventArgs e)
		{
			this.RaisePopupOpened();
		}
	}
}
