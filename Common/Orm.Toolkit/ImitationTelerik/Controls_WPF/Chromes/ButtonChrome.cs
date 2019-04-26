using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.Chromes
{
	/// <summary>
	/// Renders visual states of a button.
	/// </summary>
    public class ButtonChrome : Control
    {
		/// <summary>
		/// Identifies the CornerRadius dependency property.
		/// </summary>
		public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ButtonChrome), new PropertyMetadata(OnCornerRadiusChanged));

		/// <summary>
		/// Identifies the InnerCornerRadius dependency property.
		/// </summary>
		public static readonly DependencyProperty InnerCornerRadiusProperty;

		/// <summary>
		/// Identifies the Orientation property.
		/// </summary>
		public static readonly DependencyProperty OrientationProperty =

 DependencyProperty.Register("Orientation", typeof(Orientation), typeof(ButtonChrome), new PropertyMetadata(Orientation.Horizontal));


		/// <summary>
		/// Identifies the RenderEnabled property.
		/// </summary>
		public static readonly DependencyProperty RenderEnabledProperty =

			DependencyProperty.Register("RenderEnabled", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(true));


		/// <summary>
		/// Identifies the RenderNormal property.
		/// </summary>
		public static readonly DependencyProperty RenderNormalProperty =

 DependencyProperty.Register("RenderNormal", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(true));


		/// <summary>
		/// Identifies the RenderActive property.
		/// </summary>
		public static readonly DependencyProperty RenderActiveProperty =

 DependencyProperty.Register("RenderActive", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(false));


		/// <summary>
		/// Identifies the RenderHighlighted property.
		/// </summary>
		public static readonly DependencyProperty RenderHighlightedProperty =

 DependencyProperty.Register("RenderHighlighted", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(false));


		/// <summary>
		/// Identifies the RenderSelected property.
		/// </summary>
		public static readonly DependencyProperty RenderSelectedProperty =

 DependencyProperty.Register("RenderSelected", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(false));


		/// <summary>
		/// Identifies the RenderChecked property.
		/// </summary>
		public static readonly DependencyProperty RenderCheckedProperty =

 DependencyProperty.Register("RenderChecked", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(false));


		/// <summary>
		/// Identifies the RenderMouseOver property.
		/// </summary>
		public static readonly DependencyProperty RenderMouseOverProperty =

			DependencyProperty.Register("RenderMouseOver", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(false));


		/// <summary>
		/// Identifies the RenderPressed property.
		/// </summary>
		public static readonly DependencyProperty RenderPressedProperty =

			DependencyProperty.Register("RenderPressed", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(false));


		/// <summary>
		/// Identifies the RenderFocused property.
		/// </summary>
		public static readonly DependencyProperty RenderFocusedProperty =

			DependencyProperty.Register("RenderFocused", typeof(bool), typeof(ButtonChrome), new PropertyMetadata(false));


		internal const string GroupCommon = @"CommonStates";
		internal const string StateNone = @"None";
		internal const string StateNormal = @"Normal";
        internal const string StateNormalFocused = @"NormalFocused";
		internal const string StateActive = @"Active";
		internal const string StateHighlighted = @"Highlighted";
		internal const string StateChecked = @"Checked";
        internal const string StateCheckedFocused = @"CheckedFocused";
		internal const string StateDisabledChecked = @"DisabledChecked";
		internal const string StateMouseOverChecked = @"MouseOverChecked";
		internal const string StateSelected = @"Selected";
        internal const string StateSelectedHighlighted = @"SelectedHighlighted";
        internal const string StateSelectedHighlightedVertical = @"SelectedHighlightedVertical";
		internal const string StateMouseOver = @"MouseOver";
		internal const string StatePressed = @"Pressed";
		internal const string StateDisabled = @"Disabled";
		internal const string StateNoneVertical = @"NoneVertical";
		internal const string StateNormalVertical = @"NormalVertical";
		internal const string StateActiveVertical = @"ActiveVertical";
		internal const string StateHighlightedVertical = @"HighlightedVertical";
		internal const string StateSelectedVertical = @"SelectedVertical";
		internal const string StateMouseOverVertical = @"MouseOverVertical";
		internal const string StatePressedVertical = @"PressedVertical";
		internal const string StateDisabledVertical = @"DisabledVertical";

		internal const string GroupFocus = @"FocusStates";
		internal const string StateFocused = @"Focused";
		internal const string StateUnfocused = @"Unfocused";

		private static readonly DependencyPropertyKey InnerCornerRadiusPropertyKey = DependencyPropertyExtensions.RegisterReadOnly("InnerCornerRadius", typeof(CornerRadius), typeof(ButtonChrome), null);

		/// <summary>
		/// Initializes static members of the <see cref="ButtonChrome"/> class.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
		static ButtonChrome()
		{

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonChrome),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(ButtonChrome))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonChrome),
                new FrameworkPropertyMetadata(typeof(ButtonChrome)));

			InnerCornerRadiusProperty = InnerCornerRadiusPropertyKey.DependencyProperty;
		}

		/// <summary>
		/// Initializes a new instance of the ButtonChrome class.
		/// </summary>
		public ButtonChrome()
		{

		}

		

		/// <summary>
		/// Identifies the CornerRadius dependency property.
		/// </summary>
		public CornerRadius InnerCornerRadius
		{
			get
			{
				return (CornerRadius)GetValue(InnerCornerRadiusProperty);
			}
			private set
			{
				this.SetValue(InnerCornerRadiusPropertyKey, value);
			}
		}

		/// <summary>
		/// Identifies the CornerRadius dependency property.
		/// </summary>
		[System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public CornerRadius CornerRadius
		{
			get
			{
				return (CornerRadius)GetValue(ButtonChrome.CornerRadiusProperty);
			}
			set
			{
				SetValue(ButtonChrome.CornerRadiusProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render Horizontal or Vertical button.
		/// </summary>
		public Orientation Orientation
		{
			get
			{
				return (Orientation)GetValue(OrientationProperty);
			}
			set
			{
				SetValue(OrientationProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render Enabled.
		/// </summary>
		public bool RenderEnabled
		{
			get
			{
				return (bool)GetValue(RenderEnabledProperty);
			}
			set
			{
				SetValue(RenderEnabledProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome not to render in Normal mode.
		/// </summary>
		public bool RenderNormal
		{
			get
			{
				return (bool)GetValue(RenderNormalProperty);
			}
			set
			{
				SetValue(RenderNormalProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome not to render in Active mode.
		/// </summary>
		public bool RenderActive
		{
			get
			{
				return (bool)GetValue(RenderActiveProperty);
			}
			set
			{
				SetValue(RenderActiveProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render in Highlighted mode.
		/// </summary>
		public bool RenderHighlighted
		{
			get
			{
				return (bool)GetValue(RenderHighlightedProperty);
			}
			set
			{
				SetValue(RenderHighlightedProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render in Selected mode.
		/// </summary>
		public bool RenderSelected
		{
			get
			{
				return (bool)GetValue(RenderSelectedProperty);
			}
			set
			{
				SetValue(RenderSelectedProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render in Selected mode.
		/// </summary>
		public bool RenderChecked
		{
			get
			{
				return (bool)GetValue(RenderCheckedProperty);
			}
			set
			{
				SetValue(RenderCheckedProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render MouseOver.
		/// </summary>
		public bool RenderMouseOver
		{
			get
			{
				return (bool)GetValue(RenderMouseOverProperty);
			}
			set
			{
				SetValue(RenderMouseOverProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render Pressed state.
		/// </summary>
		public bool RenderPressed
		{
			get
			{
				return (bool)GetValue(RenderPressedProperty);
			}
			set
			{
				SetValue(RenderPressedProperty, value);
			}
		}

		/// <summary>
		/// Sets the visual appearance of the chrome to render Focused state.
		/// </summary>
		public bool RenderFocused
		{
			get
			{
				return (bool)GetValue(RenderFocusedProperty);
			}
			set
			{
				SetValue(RenderFocusedProperty, value);
			}
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{

			base.OnApplyTemplate();
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


		private static void OnCornerRadiusChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			ButtonChrome buttonChromeSender = (ButtonChrome)sender;
			CornerRadius newCornerRadius = (CornerRadius) e.NewValue;

			CornerRadius newInnerCornerRadius = new CornerRadius(
				Math.Max(0, newCornerRadius.TopLeft - 1),
				Math.Max(0, newCornerRadius.TopRight - 1),
				Math.Max(0, newCornerRadius.BottomRight - 1),
				Math.Max(0, newCornerRadius.BottomLeft - 1));

			buttonChromeSender.InnerCornerRadius = newInnerCornerRadius;
		}


		private void SetDefaultStyleKey()
		{
            //Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(ButtonChrome));


            this.DefaultStyleKey = typeof(ButtonChrome);
		}

	}
}
