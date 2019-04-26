using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
//using Orm.Toolkit.Telerik.Windows.Controls.Design;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A ToggleButton control.
	/// </summary>

	public class RadToggleButton : ToggleButton
	{
		/// <summary>
		/// Identifies the CornerRadius property.
		/// </summary>
		public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RadToggleButton), new PropertyMetadata());

		/// <summary>
		/// Identifies the IsBackgroundVisible property.
		/// </summary>
		public static readonly DependencyProperty IsBackgroundVisibleProperty = DependencyProperty.Register("IsBackgroundVisible", typeof(bool), typeof(RadToggleButton), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the Activate routed event.
		/// </summary>
		public static readonly RoutedEvent ActivateEvent = EventManager.RegisterRoutedEvent("Activate", RoutingStrategy.Bubble, typeof(RadRoutedEventArgs), typeof(RadToggleButton));

		/// <summary>
		/// Identifies the PreviewClick property.
		/// </summary>
		public static readonly RoutedEvent PreviewClickEvent = EventManager.RegisterRoutedEvent("PreviewClick", RoutingStrategy.Bubble, typeof(RadRoutedEventHandler), typeof(RadToggleButton));





		static RadToggleButton()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadToggleButton),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadToggleButton))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadToggleButton),
                new FrameworkPropertyMetadata( typeof(RadToggleButton)));
		}


		/// <summary>
		/// Initializes a new instance of the RadToggleButton class.
		/// </summary>
		public RadToggleButton()
		{

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
		/// Occurs when the content will be Clicked.
		/// If the event handler set True for the Handled proterty then the button will not be clicked.
		/// </summary>
		public event RoutedEventHandler PreviewClick
		{
			add
			{
				this.AddHandler(PreviewClickEvent, value);
			}
			remove
			{
				this.RemoveHandler(PreviewClickEvent, value);
			}
		}





		/// <summary>
		/// Invoked whenever application code or internal processes
		/// (such as a rebuilding layout pass) call 
		/// <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

		}



		/// <summary>
		/// Called when a control is clicked by the mouse or the keyboard.
		/// </summary>
		protected override void OnClick()
		{
			RadRoutedEventArgs args = new RadRoutedEventArgs(PreviewClickEvent, this);
			this.RaiseEvent(args);
			if (!args.Handled)
			{
				base.OnClick();

				this.RaiseEvent(new RadRoutedEventArgs(ActivateEvent, this));

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
			this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadToggleButton));
		}



	}
}
