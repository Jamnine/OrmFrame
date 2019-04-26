using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Orm.Toolkit.Telerik.Windows;
//using Orm.Toolkit.Telerik.Windows.Controls.Design;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A Button control.
	/// </summary>

	public class RadButton : Button

	{


		/// <summary>
		/// Identifies the HoverDelay property.
		/// </summary>
		public static readonly DependencyProperty HoverDelayProperty = DependencyProperty.Register("HoverDelay", typeof(TimeSpan), typeof(RadButton), new PropertyMetadata(TimeSpan.Zero, RadButton.OnHoverDelayChanged));

		/// <summary>
		/// Identifies the CornerRadius property.
		/// </summary>
		public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RadButton), new PropertyMetadata());

		/// <summary>
		/// Identifies the IsBackgroundVisible property.
		/// </summary>
		public static readonly DependencyProperty IsBackgroundVisibleProperty = DependencyProperty.Register("IsBackgroundVisible", typeof(bool), typeof(RadButton), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the Activate routed event.
		/// </summary>
		public static readonly RoutedEvent ActivateEvent = EventManager.RegisterRoutedEvent("Activate", RoutingStrategy.Bubble, typeof(EventHandler<RadRoutedEventArgs>), typeof(RadButton));

		/// <summary>
		/// Identifies the Hover routed event.
		/// </summary>
		public static readonly RoutedEvent HoverEvent = EventManager.RegisterRoutedEvent("Hover", RoutingStrategy.Bubble, typeof(EventHandler<RadRoutedEventArgs>), typeof(RadButton));





		private System.Windows.Threading.DispatcherTimer hoverTimer = null;


		static RadButton()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadButton),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadButton))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadButton), new FrameworkPropertyMetadata(typeof(RadButton)));
		}


		/// <summary>
		/// Initializes a new instance of the RadButton class.
		/// </summary>
		public RadButton()
		{

            //TelerikLicense.Verify(this);//禁止验证许可
		}

		/// <summary>
		/// Occurs when button is clicked.
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
		/// Occurs when button is hovered.
		/// </summary>
		[Browsable(false)]
		public event EventHandler<RadRoutedEventArgs> Hover
		{
			add
			{
				this.AddHandler(HoverEvent, value);
			}
			remove
			{
				this.RemoveHandler(HoverEvent, value);
			}
		}



		/// <summary>
		/// Gets or sets whether the popup opens when mouse hovers for pointed milliseconds
		/// Value of zero means no auto open.
		/// This is a dependency property.
		/// </summary>
		[Browsable(false)]
		public TimeSpan HoverDelay
		{
			get
			{
				return (TimeSpan)GetValue(HoverDelayProperty);
			}
			set
			{
				SetValue(HoverDelayProperty, value);
			}
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
		/// Invoked whenever application code or internal processes
		/// (such as a rebuilding layout pass) call.
		/// <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

		}

////#if !WPF
		internal static RadRoutedEventArgs RaiseRadRoutedEvent(RoutedEvent routedEvent, UIElement source)
		{
			RadRoutedEventArgs e = new RadRoutedEventArgs(routedEvent, source);
			source.RaiseEvent(e);
			return e;
		}
////#endif // #if !WPF

		internal static bool HasChildOf(DependencyObject parent, DependencyObject child, bool skipParent)
		{
			if (parent != null && child != null)
			{
				if (!skipParent && parent == child)
				{
					return true;
				}
				FrameworkElement element = child as FrameworkElement;
				DependencyObject currentParent = VisualTreeHelper.GetParent(child);
				if (currentParent == null && element != null)
				{
					currentParent = element.Parent;
				}
				return HasChildOf(parent, currentParent, false);
			}
			return false;
		}





		internal void OnClickInternal()
		{
			this.OnClick();
		}

		/// <summary>
		/// Raises the <see cref="E:Activate"/> event.
		/// </summary>
		protected internal virtual void OnActivate()
		{
			this.RaiseEvent(new RadRoutedEventArgs(ActivateEvent, this));
		}

		/// <summary>
		/// Invocated when the hover happens.
		/// </summary>
		protected internal virtual void OnHover()
		{
			this.RaiseEvent(new RadRoutedEventArgs(HoverEvent, this));
		}

		/// <summary>
		/// Invoke the base OnClick and execute the associated Command.
		/// </summary>
		protected override void OnClick()
		{

			base.OnClick();
			this.OnActivate();

		}


		/// <summary>
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event.
		/// This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadButton));
            this.DefaultStyleKey =  typeof(RadButton);
		}


		/// <summary>
		/// Starts the auto open timer.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseEnter(MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.HoverTimerStart();
		}

		/// <summary>
		/// Stops the auto open timer.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseLeave(MouseEventArgs e)
		{
			this.HoverTimerStop();
			base.OnMouseLeave(e);
		}

		/// <summary>
		/// Restarts the auto open timer.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			this.HoverTimerRestart();
			base.OnMouseMove(e);
		}

		/// <summary>
		/// Restarts the Hover Timer.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e)
		{
			////this.HoverTimerRestart();
			base.OnKeyDown(e);
		}



		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "e")]
		private static void OnHoverDelayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadButton button = d as RadButton;
			if (button != null)
			{
				button.HoverTimerApplyState(true);
			}
		}

		private void OnHoverTimerTick(object sender, EventArgs e)
		{
			this.HoverTimerStop();
			this.OnHover();
		}



		private void HoverTimerDestroy()
		{
			if (this.hoverTimer != null)
			{
				this.hoverTimer.Stop();
				this.hoverTimer.Tick -= this.OnHoverTimerTick;
				this.hoverTimer = null;
			}
		}

		private void HoverTimerStart()
		{
			if (this.HoverTimerApplyState(false))
			{
				this.hoverTimer.Start();
			}
		}

		private void HoverTimerStop()
		{
			if (this.HoverTimerApplyState(false))
			{
				this.hoverTimer.Stop();
			}
		}

		private void HoverTimerRestart()
		{
			if (this.HoverTimerApplyState(false))
			{
				this.hoverTimer.Start();
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
		private bool HoverTimerApplyState(bool applyAction)
		{
			double milliseconds = this.HoverDelay.TotalMilliseconds;
			if (milliseconds > 0)
			{
				if (this.hoverTimer == null)
				{
					this.hoverTimer = new System.Windows.Threading.DispatcherTimer();
					this.hoverTimer.Tick += this.OnHoverTimerTick;
				}

				if (milliseconds != this.hoverTimer.Interval.TotalMilliseconds)
				{
					this.hoverTimer.Interval = this.HoverDelay;
				}

				if (applyAction)
				{
					if (this.IsMouseOver)
					{
						this.HoverTimerStart();
					}
					else
					{
						this.HoverTimerStop();
					}
				}
			}
			else
			{
				this.HoverTimerDestroy();
			}
			return this.hoverTimer != null;
		}


	}
}
