using System;
using System.ComponentModel;

using System.Diagnostics;

using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents a RadNumericUpDown control.
	/// </summary>
	[DefaultProperty("Value")]
	[DefaultEvent("ValueChanged")]
	[Themable]
	public partial class RadNumericUpDown : RadRangeBase, IThemable
	{

		/// <summary>
		/// Identifies the ShowTextBox dependency property. 
		/// </summary>
		public static readonly DependencyProperty ShowTextBoxProperty = DependencyProperty.Register("ShowTextBox", typeof(bool), typeof(RadNumericUpDown), new PropertyMetadata(true, OnShowTextBoxChanged));

		/// <summary>
		/// Identifies the ValueFormat dependency property. 
		/// </summary>
		public static readonly DependencyProperty ValueFormatProperty = DependencyProperty.Register("ValueFormat", typeof(ValueFormat), typeof(RadNumericUpDown), new PropertyMetadata(ValueFormat.Numeric, OnValueFormatChanged));

		/// <summary>
		///  Identifies the NumberFormatInfo dependency property. 
		/// </summary>
		public static readonly DependencyProperty NumberFormatInfoProperty = DependencyProperty.Register("NumberFormatInfo", typeof(NumberFormatInfo), typeof(RadNumericUpDown), new PropertyMetadata(null, OnNumberFormatInfoChanged, null));

		/// <summary>
		/// Identifies the RepeatInterval dependency property.
		/// </summary>
		public static readonly DependencyProperty RepeatIntervalProperty = DependencyProperty.Register("RepeatInterval", typeof(int), typeof(RadNumericUpDown), new PropertyMetadata(250));

		/// <summary>
		///     Identifies the DelayProperty dependency property. 
		/// </summary>
		public static readonly DependencyProperty DelayProperty = DependencyProperty.Register("Delay", typeof(int), typeof(RadNumericUpDown), new PropertyMetadata(150));

		/// <summary>
		///    Identifies the UpdateValueEvent dependency property. 
		/// </summary>
		public static readonly DependencyProperty UpdateValueEventProperty = DependencyProperty.Register("UpdateValueEvent", typeof(UpdateValueEvent), typeof(RadNumericUpDown), new PropertyMetadata(UpdateValueEvent.LostFocus));

		/// <summary>
		/// Identifies the IncreaseButtonContentTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty IncreaseButtonContentTemplateProperty = DependencyProperty.Register("IncreaseButtonContentTemplate", typeof(DataTemplate), typeof(RadNumericUpDown), null);

		/// <summary>
		/// Identifies the IncreaseButtonContentTemplate dependency property.
		/// </summary>
		public static readonly DependencyProperty DecreaseButtonContentTemplateProperty = DependencyProperty.Register("DecreaseButtonContentTemplate", typeof(DataTemplate), typeof(RadNumericUpDown), null);

		/// <summary>
		/// Identifies the ShowButtons dependency property.
		/// </summary>
		public static readonly DependencyProperty ShowButtonsProperty = DependencyProperty.Register("ShowButtons", typeof(bool), typeof(RadNumericUpDown), new PropertyMetadata(true, ForceVisualState));

		/// <summary>
		/// Identifies the NullValue dependency property.
		/// </summary>
		public static readonly DependencyProperty NullValueProperty = DependencyProperty.Register("NullValue", typeof(string), typeof(RadNumericUpDown), new PropertyMetadata(String.Empty, OnPropertyChangedThatRequiresUpdateText));

		/// <summary>
		///     Identifies the ChangeAcceleration dependency property. 
		/// </summary> 
		public static readonly DependencyProperty ChangeAccelerationProperty = DependencyProperty.Register("ChangeAcceleration", typeof(bool), typeof(RadNumericUpDown), new PropertyMetadata(null));

		/// <summary>
		/// Gets or sets a value indicating whether this instance is highlighted.
		/// </summary>
		public static readonly DependencyProperty IsHighlightedProperty = DependencyProperty.Register("IsHighlighted", typeof(bool), typeof(RadNumericUpDown), new PropertyMetadata(ForceVisualState));

		/// <summary>
		///  Identifies the IsEditable dependency property. 
		/// </summary>
		public static readonly DependencyProperty IsEditableProperty = DependencyProperty.Register("IsEditable", typeof(bool), typeof(RadNumericUpDown), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the CustomUnit dependency property.
		/// </summary>
		public static readonly DependencyProperty CustomUnitProperty = DependencyProperty.Register("CustomUnit", typeof(string), typeof(RadNumericUpDown), new PropertyMetadata(OnPropertyChangedThatRequiresUpdateText));

		/// <summary>
		/// Identifies the IsInteger dependency property.
		/// </summary>
		public static readonly DependencyProperty IsIntegerProperty = DependencyProperty.Register("IsInteger", typeof(bool), typeof(RadNumericUpDown), new PropertyMetadata(false, OnIsIntegerChanged));

		/// <summary>
		/// Identifies the AreButtonsTabStops dependency property.
		/// </summary>
		public static readonly DependencyProperty AreButtonsTabStopsProperty;

		private static readonly DependencyPropertyKey AreButtonsTabStopsPropertyKey = DependencyPropertyExtensions.RegisterReadOnly("AreButtonsTabStops", typeof(bool), typeof(RadNumericUpDown), null);

		private TextBox textBox;
		private RepeatButton increase;
		private RepeatButton decrease;
		private bool isSpinning;
		private Nullable<double> inputValue = 0.0;
		private bool isChanging = false;
		private string lastInput = String.Empty;
		private bool updatingContent = false;

		/// <summary>
		/// Initializes static members of the <see cref="RadNumericUpDown"/> class.
		/// </summary>
		static RadNumericUpDown()
		{

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadNumericUpDown),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadNumericUpDown))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadNumericUpDown),
                new FrameworkPropertyMetadata( typeof(RadNumericUpDown)));

			AreButtonsTabStopsProperty = AreButtonsTabStopsPropertyKey.DependencyProperty;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RadNumericUpDown"/> class.
		/// </summary>
		public RadNumericUpDown()
		{


			this.NumberFormatInfo = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            //TelerikLicense.Verify(this);//禁止验证许可
		}

		/// <summary>
		/// Read only property identifies if the increase / decrease buttons should be tab stops. Set to true when the ShowTextBox is set to false.
		/// </summary>
		public bool AreButtonsTabStops
		{
			get { return (bool)GetValue(AreButtonsTabStopsProperty); }
			private set { this.SetValue(AreButtonsTabStopsPropertyKey, value); }
		}

		/// <summary>
		/// Gets or sets additional string to appear in the end of numeric values. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// The following example shows how to use <strong>CustomUnit</strong> property.
		/// The default value is <strong>null</strong>.
		/// </remarks>
		/// <example>
		///	<code lang="CS">
		/// public class TestClass
		/// {
		///    static TestClass()
		///    {
		///         RadNumericUpDown numeric = new RadNumericUpDown();
		///         numeric.Value = 10;
		///         numeric.ValueFormat = ValueFormat.Numeric;
		///         numeric.NumberFormatInfo.NumberDecimalDigits = 2;
		///         numeric.CustomUnit = "meters";
		///         //the display result is "10.00 meters"
		///    }
		/// }
		///	</code>
		///	<code lang="VB">
		///	Class TestClass
		///     Shared Sub New()
		///         Dim numeric As RadNumericUpDown = New RadNumericUpDown
		///         numeric.Value = 10
		///         numeric.ValueFormat = ValueFormat.Numeric
		///         numeric.NumberFormatInfo.NumberDecimalDigits = 2
		///         numeric.CustomUnit = "meters"
		///         //the display result is "10.00 meters"
		///     End Sub
		/// End Class
		/// </code>
		/// </example>
		public string CustomUnit
		{
			get { return (string)this.GetValue(CustomUnitProperty); }
			set { this.SetValue(CustomUnitProperty, value); }
		}

		/// <summary>
		/// Gets or sets the bool indicating whether the control is editable or not. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// If it is set to true, the user is able to enter number in <strong>RadNumericUpDown</strong>.
		/// Default value is set to <strong>True</strong>.
		/// </remarks>
		public bool IsEditable
		{
			get { return (bool)this.GetValue(IsEditableProperty); }
			set { this.SetValue(IsEditableProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the format is integer.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if the format is integer; otherwise, <c>false</c>.
		/// </value>
		public bool IsInteger
		{
			get { return (bool)GetValue(IsIntegerProperty); }
			set { SetValue(IsIntegerProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the textbox of RadNumericUpDown is visible.
		/// </summary>
		/// <value><c>True</c> if is visible [default]; otherwise, <c>False</c>.</value>
		public bool ShowTextBox
		{
			get { return (bool)GetValue(ShowTextBoxProperty); }
			set { SetValue(ShowTextBoxProperty, value); }
		}

		/// <summary>
		/// Gets or sets the current value format. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// Used to determine the specific set of properties defined in <see>NumberFormatInfo</see>.
		/// The following example shows you how to constrain input values of <strong>RadNumericUpDown</strong> to integers
		/// in three different cases.
		/// </remarks>
		/// <example>
		///	<code lang="CS">
		/// public class TestClass
		/// {
		///    static TestClass()
		///    {
		///         RadNumericUpDown numeric = new RadNumericUpDown();
		///         numeric.Value = 15.50;
		///         numeric.ValueFormat = ValueFormat.Numeric;
		///         numeric.NumberFormatInfo.NumberDecimalDigits = 0;
		///         //the display result will be "15"
		///         numeric.ValueFormat = ValueFormat.Currency;
		///         numeric.NumberFormatInfo.CurrencyDecimalDigits = 2;
		///         //the display result will be "$15.50"
		///         numeric.ValueFormat = ValueFormat.Percentage;
		///         numeric.NumberFormatInfo.PercentDecimalDigits = 1;
		///         //the display result will be "%1500.5"
		///    }
		/// }
		///	</code>
		///	<code lang="VB">
		///	Class TestClass
		///     Shared Sub New()
		///         Dim numeric As RadNumericUpDown = New RadNumericUpDown
		///         numeric.Value = 15.50
		///         numeric.ValueFormat = ValueFormat.Numeric
		///         numeric.NumberFormatInfo.NumberDecimalDigits = 0
		///         //the display result will be "15"
		///         numeric.ValueFormat = ValueFormat.Currency
		///         numeric.NumberFormatInfo.CurrencyDecimalDigits = 2
		///         //the display result will be "$15.50"
		///         numeric.ValueFormat = ValueFormat.Percentage
		///         numeric.NumberFormatInfo.PercentDecimalDigits = 1
		///         //the display result will be "%1500.5"
		///     End Sub
		/// End Class
		/// </code>
		/// </example>
		public ValueFormat ValueFormat
		{
			get { return (ValueFormat)this.GetValue(ValueFormatProperty); }
			set { this.SetValue(ValueFormatProperty, value); }
		}

		/// <summary>
		/// Gets or sets the NumberFormatInfo value, for more info see <see>ValueFormat</see>. This is a dependency property.
		/// </summary>
		public NumberFormatInfo NumberFormatInfo
		{
			get { return (NumberFormatInfo)this.GetValue(NumberFormatInfoProperty); }
			set { this.SetValue(NumberFormatInfoProperty, value); }
		}

		/// <summary>
		/// Gets or sets the ShowButtons property that indicates whether the up and down buttons are visible.
		/// </summary>
		public bool ShowButtons
		{
			get { return (bool)GetValue(ShowButtonsProperty); }
			set { SetValue(ShowButtonsProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this control is highlighted.
		/// </summary>
		public bool IsHighlighted
		{
			get
			{
				return (bool)GetValue(IsHighlightedProperty);
			}
			set
			{
				SetValue(IsHighlightedProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets string that is displayed when the Value is null.
		/// </summary>
		/// <value>The null value.</value>
		public string NullValue
		{
			get { return (string)GetValue(NullValueProperty); }
			set { SetValue(NullValueProperty, value); }
		}

		/// <summary>
		/// Gets or sets the data template of the IncreaseButton. This is a dependency property.
		/// </summary>
		public DataTemplate IncreaseButtonContentTemplate
		{
			get { return (DataTemplate)GetValue(IncreaseButtonContentTemplateProperty); }
			set { SetValue(IncreaseButtonContentTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the data template of the DecreaseButton. This is a dependency property.
		/// </summary>
		public DataTemplate DecreaseButtonContentTemplate
		{
			get { return (DataTemplate)GetValue(DecreaseButtonContentTemplateProperty); }
			set { SetValue(DecreaseButtonContentTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the way the Value property is updated. This is a dependency property.
		/// </summary>
		public UpdateValueEvent UpdateValueEvent
		{
			get { return (UpdateValueEvent)this.GetValue(UpdateValueEventProperty); }
			set { this.SetValue(UpdateValueEventProperty, value); }
		}

		/// <summary>
		/// Gets the current text content held by the textbox. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// Represents the content of the input textbox of <strong>RadNumericUpDown</strong>.
		/// </remarks>
		/// <example>
		///	<code lang="CS">
		/// public class TestClass
		/// {
		///    static TestClass()
		///    {
		///         RadNumericUpDown numeric = new RadNumericUpDown();
		///         numeric.Value = 15.50;
		///         numeric.ValueFormat = ValueFormat.Numeric;
		///         numeric.NumberFormatInfo.NumberDecimalDigits = 0;
		///         //ContentText is "15"
		///         numeric.ValueFormat = ValueFormat.Currency;
		///         numeric.NumberFormatInfo.CurrencyDecimalDigits = 2;
		///         //ContentText is "$15.50"
		///         numeric.ValueFormat = ValueFormat.Percentage;
		///         numeric.NumberFormatInfo.PercentDecimalDigits = 1;
		///         //ContentText is "%1500.5"
		///    }
		/// }
		///	</code>
		///	<code lang="VB">
		///	Class TestClass
		///     Shared Sub New()
		///         Dim numeric As RadNumericUpDown = New RadNumericUpDown
		///         numeric.Value = 15.50
		///         numeric.ValueFormat = ValueFormat.Numeric
		///         numeric.NumberFormatInfo.NumberDecimalDigits = 0
		///         //the display result is "15"
		///         numeric.ValueFormat = ValueFormat.Currency
		///         numeric.NumberFormatInfo.CurrencyDecimalDigits = 2
		///         //the display result is "$15.50"
		///         numeric.ValueFormat = ValueFormat.Percentage
		///         numeric.NumberFormatInfo.PercentDecimalDigits = 1
		///         //the display result is "%1500.5"
		///     End Sub
		/// End Class
		/// </code>
		/// </example>
		public string ContentText
		{
			get
			{
				if (this.textBox != null)
				{
					return this.textBox.Text;
				}
				else
				{
					return this.FormatDisplay(this.Value);
				}
			}
		}

		/// <summary>
		/// Resets the theme.
		/// </summary>
		void IThemable.ResetTheme()
		{
			this.DefaultStyleKey = this.GetDefaultStyleKey(this);
		}

		/// <summary>
		/// Selects the entire content of RadNumericUpDown textbox.
		/// </summary>
		public void SelectAll()
		{
			if (this.textBox != null)
			{
				this.textBox.SelectAll();
			}
		}

		/// <summary>
		/// Selects a range of text in the RadNumericUpDown textbox.
		/// </summary>
		/// <param name="start">The zero based start.</param>
		/// <param name="length">The length of the selection.</param>
		public void Select(int start, int length)
		{
			if (this.textBox != null)
			{
				this.textBox.Select(start, length);
			}
		}

		/// <summary>
		/// Formats the display value when the control is not focused.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>Returns value that is displayed when the control doesn't have focus.</returns>
		public virtual string FormatDisplay(Nullable<double> value)
		{
			if (value.HasValue)
			{
				string format = String.Empty;
				NumberFormatInfo formatInfo = (NumberFormatInfo)this.NumberFormatInfo.Clone();
				int decimals = this.GetDecimals();
				switch (ValueFormat)
				{
					case ValueFormat.Numeric:
						format = "N";
						formatInfo.NumberDecimalDigits = decimals;
						break;
					case ValueFormat.Currency:
						format = "C";
						formatInfo.CurrencyDecimalDigits = decimals;
						break;
					case ValueFormat.Percentage:
						format = "P";
						formatInfo.PercentDecimalDigits = decimals - 2;
						break;
				}

				string obj = value.Value.ToString(format, formatInfo);

				if (!String.IsNullOrEmpty(this.CustomUnit))
				{
					obj += String.Format(CultureInfo.CurrentCulture, " {0}", this.CustomUnit);
				}

				return obj;
			}
			return this.NullValue;
		}

		/// <summary>
		/// Formats the value when the control is in focus and the user is editting the content.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>Return the value when the control is in focus and the user is editting the content.</returns>
		public virtual string FormatEdit(Nullable<double> value)
		{
			return value.HasValue ? value.Value.ToString("N" + this.GetDecimals(), this.NumberFormatInfo) : String.Empty;
		}

		/// <summary>
		/// Overrides OnApplyTemplate and attach all necessary events to the controls.
		/// TODO: change the binding to TemplateBinding.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			if (this.increase != null)
			{
				this.increase.Click -= this.OnButtonIncreasedClicked;
			}
			this.increase = (RepeatButton)this.GetTemplateChild("increase");
			if (this.increase != null)
			{
				this.increase.Click += this.OnButtonIncreasedClicked;
			}

			if (this.decrease != null)
			{
				this.decrease.Click -= this.OnButtonDecreasedClicked;
			}
			this.decrease = (RepeatButton)this.GetTemplateChild("decrease");
			if (this.decrease != null)
			{
				this.decrease.Click += this.OnButtonDecreasedClicked;
			}

			if (this.textBox != null)
			{
				this.textBox.TextChanged -= this.OnTextBoxTextChanged;

				this.textBox.PreviewKeyDown -= this.OnTextBoxPreviewKeyDown;

			}
			this.textBox = (TextBox)this.GetTemplateChild("textbox");
			if (this.textBox != null)
			{
				this.textBox.TextChanged += this.OnTextBoxTextChanged;

				this.textBox.PreviewKeyDown += this.OnTextBoxPreviewKeyDown;

				this.textBox.IsReadOnly = false;
			}

			this.isSpinning = true;
			this.UpdateText();
		}

		internal int GetDecimals()
		{
			if (!this.IsInteger)
			{
				switch (this.ValueFormat)
				{
					case ValueFormat.Currency:
						return this.NumberFormatInfo.CurrencyDecimalDigits;
					case ValueFormat.Numeric:
						return this.NumberFormatInfo.NumberDecimalDigits;
					case ValueFormat.Percentage:
						////52.3% displayed should be entered as 0.523 that is why
						////2 more digits are required in order to enter the correct percent
						return this.NumberFormatInfo.PercentDecimalDigits + 2;
				}
			}

			return this.ValueFormat != ValueFormat.Percentage ? 0 : 2;
		}

		internal void UpdateText()
		{
			string value;

			if (this.IsKeyboardFocusWithin)

			{
				value = this.FormatEdit(this.Value);
			}
			else
			{
				value = this.FormatDisplay(this.Value);
			}

			if (this.textBox != null)
			{
				this.lastInput = value;
				this.textBox.Text = value;
			}
		}

		internal void UpdateValue()
		{
			if (this.inputValue != this.Value)
			{
				this.Value = this.inputValue;
			}
		}

		internal bool OnTextBoxKeyDownInternal(Key key)
		{
			switch (key)
			{
				case Key.Up:
					this.ChangeValue(this.SmallChange);
					break;
				case Key.Down:
					this.ChangeValue(-this.SmallChange);
					break;
				case Key.PageUp:
					this.ChangeValue(this.LargeChange);
					break;
				case Key.PageDown:
					this.ChangeValue(-this.LargeChange);
					break;
				case Key.Enter:
					this.UpdateValue();
					this.UpdateText();

					// RadGridView needs to handle the Enter key.
					return false;
				default:
					return false;
			}
			return true;
		}

		internal void SimulateUserInput(string input)
		{
			if (this.textBox != null)
			{
				this.textBox.Text = input;
			}
		}

		/// <summary>
		/// Adds the provided delta to the current value.
		/// </summary>
		/// <param name="delta">The amount to add to Value.</param>
		protected internal override void ChangeValue(double delta)
		{
			this.isSpinning = true;
			////updates the value from the textbox input
			this.UpdateValue();
			base.ChangeValue(delta);
			this.UpdateText();
		}

		/// <summary>
		/// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			this.DefaultStyleKey = this.GetDefaultStyleKey(this);
		}

		/// <summary>
		/// Raises the <see cref="E:ValueChanged"/> event.
		/// </summary>
		/// <param name="e">The <see cref="Telerik.Windows.Controls.RadRangeBaseValueChangedEventArgs"/> instance containing the event data.</param>
		protected override void OnValueChanged(RadRangeBaseValueChangedEventArgs e)
		{
			if (this.isChanging)
				return;

			if (this.inputValue != (Nullable<double>)e.NewValue)
			{
				this.inputValue = (Nullable<double>)e.NewValue;
			}

			base.OnValueChanged(e);

			if (!this.IsKeyboardFocusWithin || this.isSpinning)

			{
				this.UpdateText();
			}

			if (e.NewValue.HasValue)
			{
				string[] str = e.NewValue.Value.ToString(CultureInfo.InvariantCulture).Split('.');
				int decimals = this.GetDecimals();
				if (str.Length > 1)
				{
					if (str[1].Length > decimals)
					{
						this.isChanging = true;

						this.Value = Math.Round(this.Value.HasValue ? this.Value.Value : 0.0, decimals);

						this.isChanging = false;
					}
				}
			}
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.KeyDown"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			if (this.OnTextBoxKeyDownInternal(e.Key))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Invoked when an unhandled System.Windows.Input.Mouse.MouseWheel attached event reaches an element 
		/// in its route that is derived from this class. Implement this method to add class handling for this event.
		/// </summary>
		/// <param name="e">The System.Windows.Input.MouseWheelEventArgs that contains the event data.</param>
		protected override void OnMouseWheel(MouseWheelEventArgs e)
		{
			base.OnMouseWheel(e);
			this.HandleMouseWheel(e.Delta);
		}

		/// <summary>
		/// Invoked just before the <see cref="E:System.Windows.UIElement.IsKeyboardFocusWithinChanged"/> event is raised by this element. Implement this method to add class handling for this event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.DependencyPropertyChangedEventArgs"/> that contains the event data.</param>
		protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
		{
			if ((bool)e.NewValue)
			{
				this.OnGotFocus();
			}
			else
			{
				this.OnLostFocus();
			}
		}

		/// <summary>
		/// Forces the update of all visual states.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
		private static void ForceVisualState(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{

		}

		/// <summary> 
		///     NumberFormatInfoProperty property changed handler. 
		/// </summary>
		/// <param name="sender">RadNumericUpDown that changed its NumberFormatInfo.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnNumberFormatInfoChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadNumericUpDown).UpdateText();
		}

		/// <summary> 
		///     ValueFormatProperty property changed handler. 
		/// </summary>
		/// <param name="sender">RadNumericUpDown that changed its ValueFormatProperty.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnValueFormatChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			if (!Enum.IsDefined(typeof(ValueFormat), e.NewValue))
			{
				throw new ArgumentException("Invalid value for the ValueFormat enum.", "e");
			}
			(sender as RadNumericUpDown).UpdateText();
		}

		private static void OnIsIntegerChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadNumericUpDown numeric = sender as RadNumericUpDown;

			var isInteger = (bool)e.NewValue;

			switch (numeric.ValueFormat)
			{
				case ValueFormat.Numeric:
					numeric.NumberFormatInfo.NumberDecimalDigits = isInteger ? 0 : CultureInfo.CurrentCulture.NumberFormat.NumberDecimalDigits;
					break;
				case ValueFormat.Currency:
					numeric.NumberFormatInfo.CurrencyDecimalDigits = isInteger ? 0 : CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalDigits;
					break;
				case ValueFormat.Percentage:
					numeric.NumberFormatInfo.PercentDecimalDigits = isInteger ? 0 : CultureInfo.CurrentCulture.NumberFormat.PercentDecimalDigits;
					break;
			}

			numeric.UpdateText();
		}

		/// <summary>
		/// Called when [property changed that requires update text].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
		private static void OnPropertyChangedThatRequiresUpdateText(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			(sender as RadNumericUpDown).UpdateText();
		}

		/// <summary>
		/// Called when [property changed that requires update text].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
		private static void OnShowTextBoxChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			var numeric = sender as RadNumericUpDown;

			numeric.AreButtonsTabStops = !(bool)e.NewValue;
			numeric.ChangeVisualState(true);
		}

		private void OnTextBoxPreviewKeyDown(object sender, KeyEventArgs e)
		{
			this.OnKeyDown(e);
		}

		private void OnButtonDecreasedClicked(object sender, RoutedEventArgs e)
		{
			this.Focus();
			this.ChangeValue(-this.SmallChange);
		}

		private void OnButtonIncreasedClicked(object sender, RoutedEventArgs e)
		{
			this.Focus();
			this.ChangeValue(this.SmallChange);
		}

		private void OnTextBoxTextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.updatingContent)
			{
				this.updatingContent = false;
				return;
			}

			if (this.IsEditable == false && this.isSpinning == false)
			{
				this.updatingContent = true;
				this.ReturnPreviousInput();
				return;
			}

			if (this.IsFocusWithin())
			{
				NumberFormatInfo formatInfo = this.GetNumberFormatInfo();

				if (String.IsNullOrEmpty(this.textBox.Text))
				{
					this.inputValue = null;
				}
				else
				{
					double parsedValue = 0.0;

					if (double.TryParse(this.textBox.Text, NumberStyles.Any, formatInfo, out parsedValue) || this.IsSymbolException(this.textBox.Text))
					{
						this.inputValue = parsedValue;
						this.lastInput = this.textBox.Text;
					}
					else
					{
						this.updatingContent = true;
						this.ReturnPreviousInput();
					}
				}

				if (this.UpdateValueEvent == UpdateValueEvent.PropertyChanged)
				{
					this.UpdateValue();
				}
			}
			this.isSpinning = false;
		}

		private void ReturnPreviousInput()
		{
			int selectionLenght = this.textBox.SelectionLength;
			int selectionStart = this.textBox.SelectionStart;

			this.textBox.Text = this.lastInput;

			this.textBox.SelectionStart = selectionStart == 0 ? 0 : selectionStart - 1;
			this.textBox.SelectionLength = selectionLenght;
		}

		private bool IsSymbolException(string keyInput)
		{
			NumberFormatInfo formatInfo = this.GetNumberFormatInfo();
			if (keyInput == formatInfo.NumberDecimalSeparator
							|| keyInput == formatInfo.PositiveSign
							|| keyInput == formatInfo.NegativeSign
							|| keyInput == formatInfo.NegativeSign + formatInfo.NumberDecimalSeparator
							|| keyInput == formatInfo.PositiveSign + formatInfo.NumberDecimalSeparator)
			{
				return true;
			}
			return false;
		}

		private NumberFormatInfo GetNumberFormatInfo()
		{
			return this.NumberFormatInfo == null ? CultureInfo.CurrentCulture.NumberFormat : this.NumberFormatInfo;
		}

		private void HandleMouseWheel(int delta)
		{
			if (this.IsFocused)
			{
				if (delta > 0)
				{
					this.ChangeValue(this.SmallChange);
				}
				else
				{
					this.ChangeValue(-this.SmallChange);
				}
			}
		}

		private bool IsFocusWithin()
		{

			return this.IsKeyboardFocusWithin;

		}

		private void OnLostFocus()
		{

			this.UpdateValue();
			this.UpdateText();
		}

		private void OnGotFocus()
		{

			this.UpdateText();
			this.SelectAll();
		}

		private void ChangeVisualState(bool useTransitions)
		{

		}
	}
}