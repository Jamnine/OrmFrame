using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Orm.Toolkit.Telerik.Windows.Controls.Calendar;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents a control that allows the user to select dates and times.
	/// </summary>
	[StyleTypedProperty(Property = "CalendarStyle", StyleTargetType = typeof(RadCalendar))]
	[StyleTypedProperty(Property = "ClockStyle", StyleTargetType = typeof(RadClock))]
	public partial class RadDateTimePicker : Control, IThemable
	{
		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectedValue dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectedValue dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty SelectedValueProperty =
			DependencyProperty.Register("SelectedValue", typeof(DateTime?), typeof(RadDateTimePicker), new PropertyMetadata(OnSelectedValueChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectedDate dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectedDate dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty SelectedDateProperty =
			DependencyProperty.Register("SelectedDate", typeof(DateTime?), typeof(RadDateTimePicker), new PropertyMetadata(OnSelectedDateChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectedTime dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectedTime dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty SelectedTimeProperty =
			DependencyProperty.Register("SelectedTime", typeof(TimeSpan?), typeof(RadDateTimePicker), new PropertyMetadata(OnSelectedTimeChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateTimeWatermarkTemplate dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateTimeWatermarkTemplate dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DateTimeWatermarkTemplateProperty =
			DependencyProperty.Register("DateTimeWatermarkTemplate", typeof(DataTemplate), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateTimeWatermarkContent dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateTimeWatermarkContent dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DateTimeWatermarkContentProperty =
			DependencyProperty.Register("DateTimeWatermarkContent", typeof(object), typeof(RadDateTimePicker), new PropertyMetadata("Enter date"));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.ClockItemsSource dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.ClockItemsSource dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty ClockItemsSourceProperty =
			DependencyPropertyExtensions.Register("ClockItemsSource", typeof(IEnumerable<TimeSpan>), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.TextAlignment dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.TextAlignment dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty TextAlignmentProperty =
			DependencyPropertyExtensions.Register("TextAlignment", typeof(TextAlignment), typeof(RadDateTimePicker), new PropertyMetadata(TextAlignment.Left));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.Culture dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.Culture dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty CultureProperty =
			DependencyProperty.Register("Culture", typeof(CultureInfo), typeof(RadDateTimePicker), new PropertyMetadata(OnCultureChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.ControlsRadDateTimePicker..DisplayDate dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DisplayDate dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DisplayDateProperty =
			DependencyProperty.Register("DisplayDate", typeof(DateTime), typeof(RadDateTimePicker), new PropertyMetadata(DateTime.Now));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.CalendarStyle dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.CalendarStyle dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty CalendarStyleProperty =
			DependencyProperty.Register("CalendarStyle", typeof(Style), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.ClockStyle dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.ClockStyle dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty ClockStyleProperty =
			DependencyProperty.Register("ClockStyle", typeof(Style), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateSelectionMode dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateSelectionMode dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DateSelectionModeProperty =
			DependencyProperty.Register("DateSelectionMode", typeof(DateSelectionMode), typeof(RadDateTimePicker), new PropertyMetadata(DateSelectionMode.Day));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.TooltipContent dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.TooltipContent dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty TooltipContentProperty =
			DependencyProperty.Register("TooltipContent", typeof(object), typeof(RadDateTimePicker), new PropertyMetadata("Tooltip"));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.ErrorTooltipContent dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.ErrorTooltipContent dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty ErrorTooltipContentProperty =
			DependencyProperty.Register("ErrorTooltipContent", typeof(object), typeof(RadDateTimePicker), new PropertyMetadata("Error"));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.TooltipTemplate dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.TooltipTemplate dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty TooltipTemplateProperty =
			DependencyProperty.Register("TooltipTemplate", typeof(DataTemplate), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsTooltipOpen dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsTooltipOpen dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty IsTooltipOpenProperty =
			DependencyProperty.Register("IsTooltipOpen", typeof(bool), typeof(RadDateTimePicker), new PropertyMetadata(false));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsTooltipEnabled dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsTooltipEnabled dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty IsTooltipEnabledProperty =
			DependencyProperty.Register("IsTooltipEnabled", typeof(bool), typeof(RadDateTimePicker), new PropertyMetadata(true));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsDropDownOpen dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsDropDownOpen dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty IsDownOpenProperty =
			DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(RadDateTimePicker), new PropertyMetadata(OnIsDropDownOpenChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateTimeText dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DateTimeText dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DateTimeTextProperty =
			DependencyProperty.Register("DateTimeText", typeof(string), typeof(RadDateTimePicker), new PropertyMetadata(OnDateTimeTextChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.CurrentDateTimeText dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.CurrentDateTimeText dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty CurrentDateTimeTextProperty =
			DependencyProperty.Register("CurrentDateTimeText", typeof(string), typeof(RadDateTimePicker), new PropertyMetadata(OnCurrentDateTimeTextChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.InputMode dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.InputMode dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty InputModeProperty =
			DependencyProperty.Register("InputMode", typeof(InputMode), typeof(RadDateTimePicker), new PropertyMetadata(InputMode.DateTimePicker, OnInputModeChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsReadOnly dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.IsReadOnly dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty IsReadOnlyProperty =
			DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.DisplayFormat dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DisplayFormat dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DisplayFormatProperty =
			DependencyProperty.Register("DisplayFormat", typeof(DateTimePickerFormat), typeof(RadDateTimePicker), new PropertyMetadata(DateTimePickerFormat.Short, OnDisplayFormatChanged));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.DisplayDateStart dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DisplayDateStart dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DisplayDateStartProperty =
			DependencyPropertyExtensions.Register("DisplayDateStart", typeof(DateTime?), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.DisplayDateEnd dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.DisplayDateEnd dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty DisplayDateEndProperty =
			DependencyPropertyExtensions.Register("DisplayDateEnd", typeof(DateTime?), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectableDateStart dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectableDateStart dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty SelectableDateStartProperty = DependencyPropertyExtensions.Register("SelectableDateStart", typeof(DateTime?), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectableDateEnd dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectableDateEnd dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty SelectableDateEndProperty = DependencyPropertyExtensions.Register("SelectableDateEnd", typeof(DateTime?), typeof(RadDateTimePicker), null);

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.TimeIntervalProperty dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.TimeIntervalProperty dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty TimeIntervalProperty = DependencyPropertyExtensions.Register("TimeInterval",
																				typeof(TimeSpan),
																				typeof(RadDateTimePicker),
																				new PropertyMetadata(RadClock.TimeIntervalDefaultValue));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.StartTimeProperty dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.StartTimeProperty dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty StartTimeProperty = DependencyProperty.Register("StartTime",
																			typeof(TimeSpan),
																			typeof(RadDateTimePicker),
																			new PropertyMetadata(RadClock.StartTimeDefaultValue));

		/// <summary>
		/// Gets the identifier for the Telerik.Windows.Controls.RadDateTimePicker.EndTimeProperty dependency property.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.EndTimeProperty dependency dependency property.
		/// </returns>
		public static readonly DependencyProperty EndTimeProperty = DependencyProperty.Register("EndTime",
																			typeof(TimeSpan),
																			typeof(RadDateTimePicker),
																			new PropertyMetadata(RadClock.EndTimeDefaultValue));

		/// <summary>
		/// Identifies the Telerik.Windows.Controls.RadDateTimePicker.SelectionChanged routed event.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.SelectionChanged routed event.
		/// </returns>
		public static readonly RoutedEvent SelectionChangedEvent =
								EventManager.RegisterRoutedEvent("SelectionChanged",
																RoutingStrategy.Bubble,
																typeof(SelectionChangedEventHandler),
																typeof(RadDateTimePicker));

		/// <summary>
		/// Identifies the Telerik.Windows.Controls.RadDateTimePicker.ParseDateTimeValue routed event.
		/// </summary>
		/// <returns>
		/// The identifier for the Telerik.Windows.Controls.RadDateTimePicker.ParseDateTimeValue routed event.
		/// </returns>
		public static readonly RoutedEvent ParseDateTimeValueEvent =
								EventManager.RegisterRoutedEvent("ParseDateTimeValue",
																RoutingStrategy.Bubble,
																typeof(ParseDateTimeEventHandler),
																typeof(RadDateTimePicker));

		private bool supressUpdateDateTimeText;
		private bool supressUpdateValue;

		private IDateTimeParser dateParser;
		private IDateTimeParser timeParser;
		private IDateTimeParser dateTimeParser;


		static RadDateTimePicker()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadDateTimePicker),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadDateTimePicker))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadDateTimePicker),
                new FrameworkPropertyMetadata(typeof(RadDateTimePicker)));


			System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(RadDateTimePicker),
				new FrameworkPropertyMetadata(System.Windows.Input.KeyboardNavigationMode.Once));
		}


		/// <summary>
		/// Initializes a new instance of the Telerik.Windows.Controls.RadDateTimePicker class.
		/// </summary>
		public RadDateTimePicker()
		{

			this.dateParser = new CompositeDateTimeParser { new DateParser(), new DayOfWeekParser(), new SpecialNamesParser() };
			this.timeParser = new CompositeDateTimeParser { new DesignatorParser() };
			this.dateTimeParser = new CompositeDateTimeParser { new DateTimePickerParser() };

			this.IsEnabledChanged += this.OnIsEnabledChanged;
			this.Unloaded += this.OnUnloaded;			

			this.AddHandler(UIElement.KeyDownEvent, new KeyEventHandler(this.OnKeyDown), true);

            //TelerikLicense.Verify(this);//禁止验证许可


			this.AddHandler(LostFocusEvent, new RoutedEventHandler(this.OnLostFocus));

		}

		/// <summary>
		/// Represents the method that will handle the Telerik.Windows.Controls.RadDateTimePicker.ParseDateTimeValue routed event.
		/// </summary>
		/// <param name="sender">The object where the event handler is attached.</param>
		/// <param name="args"> The event data.</param>
		public delegate void ParseDateTimeEventHandler(object sender, ParseDateTimeEventArgs args);

		/// <summary> 
		/// Occurs when a date or time is selected.
		/// </summary> 
		/// <remarks>
		/// <para>
		/// The <strong>SelectionChanged</strong> event is fired when the <see cref="SelectedValue"/> has changed.
		/// </para>
		/// </remarks>
		/// <seealso cref="RadDateTimePicker"/>
		/// <seealso cref="RadDateTimePicker.SelectedValue"/>
		/// <seealso cref="SelectionChangedEventArgs"/>
		public event SelectionChangedEventHandler SelectionChanged
		{
			add
			{
				this.AddHandler(SelectionChangedEvent, value);
			}
			remove
			{
				this.RemoveHandler(SelectionChangedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when the input text is parsed to DateTime value. This happens when <see cref="DateTimeText"/> property has changed. 
		/// </summary>
		/// <remarks>
		/// The <strong>ParseDateTimeValue</strong> event is fired when the <see cref="DateTimeText"/> property has changed. For example this happens when the user enters text and leave the control.
		/// </remarks>
		public event ParseDateTimeEventHandler ParseDateTimeValue
		{
			add { this.AddHandler(ParseDateTimeValueEvent, value); }
			remove { this.RemoveHandler(ParseDateTimeValueEvent, value); }
		}

		/// <summary>
		/// Occurs when the DropDownButton is closed.
		/// </summary>
		public event RoutedEventHandler DropDownClosed
		{
			add
			{
				this.AddHandler(RadDropDownButton.DropDownClosedEvent, value);
			}
			remove
			{
				this.RemoveHandler(RadDropDownButton.DropDownClosedEvent, value);
			}
		}

		/// <summary>
		/// Occurs when the DropDownButton is opened.
		/// </summary>
		public event RoutedEventHandler DropDownOpened
		{
			add
			{
				this.AddHandler(RadDropDownButton.DropDownOpenedEvent, value);
			}
			remove
			{
				this.RemoveHandler(RadDropDownButton.DropDownOpenedEvent, value);
			}
		}

		/// <summary>
		/// Gets or sets the currently selected DateTime value. This is a dependency property.
		/// </summary>

		public DateTime? SelectedValue
		{
			get { return (DateTime?)GetValue(SelectedValueProperty); }
			set { SetValue(SelectedValueProperty, value); }
		}

		/// <summary>
		///	Gets or sets the Date part of the currently selected DateTime value. This is a dependency property.
		/// </summary>

		public DateTime? SelectedDate
		{
			get { return (DateTime?)GetValue(SelectedDateProperty); }
			set { SetValue(SelectedDateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the Time part of the currently selected DateTime value This is a dependency property.
		/// </summary>

		public TimeSpan? SelectedTime
		{
			get { return (TimeSpan?)GetValue(SelectedTimeProperty); }
			set { SetValue(SelectedTimeProperty, value); }
		}

		/// <summary>
		///	Gets or sets the System.Windows.DataTemplate used to display DateTimeWatermark when there is no selection. This is a dependency property.
		/// </summary>
		public DataTemplate DateTimeWatermarkTemplate
		{
			get { return (DataTemplate)GetValue(DateTimeWatermarkTemplateProperty); }
			set { SetValue(DateTimeWatermarkTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the content of the RadDateTimePicker control when there is no entered text. This is a dependency property.
		/// </summary>
		public object DateTimeWatermarkContent
		{
			get { return GetValue(DateTimeWatermarkContentProperty); }
			set { SetValue(DateTimeWatermarkContentProperty, value); }
		}

		/// <summary>
		/// Gets the culture used to provide the DateTime operations. This is a dependency property.
		/// </summary>
		public CultureInfo Culture
		{
			get { return (CultureInfo)GetValue(CultureProperty); }
			set { SetValue(CultureProperty, value); }
		}

		/// <summary>
		/// Gets or sets a collection of TimeSpan used to generate the content of the Clock. This is a dependency property.
		/// </summary>
		public IEnumerable<TimeSpan> ClockItemsSource
		{
			get { return (IEnumerable<TimeSpan>)this.GetValue(ClockItemsSourceProperty); }
			set { this.SetValue(ClockItemsSourceProperty, value); }
		}

		/// <summary>
		///	Gets or sets the TextAlignment of the TextBox inside the <see cref="RadDateTimePicker"/>. This is a dependency property.
		/// </summary>
		/// <value>The <strong>TextAlignment</strong> of the TextBox.</value>
		/// <see cref="TextAlignment"/>
		public TextAlignment TextAlignment
		{
			get { return (TextAlignment)this.GetValue(TextAlignmentProperty); }
			set { this.SetValue(TextAlignmentProperty, value); }
		}

		/// <summary>
		/// Gets or sets the date to display in the <see cref="RadDateTimePicker"/>.
		/// If no display date was set, then the <see cref="SelectedDate"/> is used.  This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DisplayDateStart"/> and <see cref="DisplayDateEnd"/> properties defined a range
		///         within which the <strong>DisplayDate</strong> can be set, i.e. a range within which the user 
		///         can navigate. If you try to set a <strong>DisplayDate outside the defined range</strong> an 
		///         <strong>ArgumentOutOfRangeException</strong> would be thrown. Similarly, setting a display 
		///         range that excludes the current DisplayDate would throw an exception.
		///     </para>
		///     <para>
		///         Please note that unlike the other date properties <strong>DisplayDate cannot be set to null</strong>. 
		///     </para>
		/// </remarks>
		/// <seealso cref="SelectedValue"/>
		/// <seealso cref="DisplayDateStart"/>
		/// <seealso cref="DisplayDateEnd"/>
		/// <seealso cref="SelectableDateStart"/>
		/// <seealso cref="SelectableDateEnd"/>

		public DateTime DisplayDate
		{
			get { return (DateTime)GetValue(DisplayDateProperty); }
			set { SetValue(DisplayDateProperty, value); }
		}

		/// <summary>
		///	Gets or sets the style of the Calendar for picking date. This is a dependency property.
		/// </summary>
		/// <value>The <strong>Style</strong> of the Calendar.</value>
		public Style CalendarStyle
		{
			get { return (Style)GetValue(CalendarStyleProperty); }
			set { SetValue(CalendarStyleProperty, value); }
		}

		/// <summary>
		///	Gets or sets the style of the Clock for picking time. This is a dependency property.
		/// </summary>
		/// <value>The <strong>Style</strong> of the Clock.</value>
		public Style ClockStyle
		{
			get { return (Style)GetValue(ClockStyleProperty); }
			set { SetValue(ClockStyleProperty, value); }
		}

		/// <summary>
		///	Gets or sets DateSelectionMode that specifies whether the calendar in RadDateTimePicker will select Days, Months or Years. This is a dependency property.
		/// </summary>
		/// <value>The <strong>DateSelectionMode</strong> of the calendar.</value>
		/// <see cref="Telerik.Windows.Controls.Calendar.DateSelectionMode"/>
		public DateSelectionMode DateSelectionMode
		{
			get { return (DateSelectionMode)GetValue(DateSelectionModeProperty); }
			set { SetValue(DateSelectionModeProperty, value); }
		}

		/// <summary>
		/// Gets or sets the content of the Tooltip when parsing the input text has failed. This is a dependency property.
		/// </summary>
		public object ErrorTooltipContent
		{
			get { return GetValue(ErrorTooltipContentProperty); }
			set { SetValue(ErrorTooltipContentProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value that indicates whether the Tooltip is open or closed. This is a dependency property.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this Tooltip is open; otherwise, <c>false</c>.
		/// </value>
		public bool IsTooltipOpen
		{
			get { return (bool)GetValue(IsTooltipOpenProperty); }
			set { SetValue(IsTooltipOpenProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value that indicates whether the preview ToolTip is enabled. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// When <strong>IsTooltipEnabled</strong> is true, ToolTip can be open or closed. When is false - ToolTip is always closed.
		/// </remarks>
		/// <value>
		/// 	<c>True</c> if this Tooltip is enabled; otherwise, <c>false</c>.
		/// </value>
		public bool IsTooltipEnabled
		{
			get { return (bool)GetValue(IsTooltipEnabledProperty); }
			set { SetValue(IsTooltipEnabledProperty, value); }
		}

		/// <summary>
		/// Gets or sets the content of the Tooltip. RadDateTimePicker sets this property automatically when the user types in its TextBox. This is a dependency property.
		/// </summary>
		public object TooltipContent
		{
			get { return GetValue(TooltipContentProperty); }
			set { SetValue(TooltipContentProperty, value); }
		}

		/// <summary>
		/// Gets or sets a data template to be used for displaying the TooltipContent. This is a dependency property.
		/// </summary>
		public DataTemplate TooltipTemplate
		{
			get { return (DataTemplate)GetValue(TooltipTemplateProperty); }
			set { SetValue(TooltipTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value that indicates whether the DropDown button is open or closed. This is a dependency property.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this DropDown button is open; otherwise, <c>false</c>.
		/// </value>
		public bool IsDropDownOpen
		{
			get { return (bool)GetValue(IsDownOpenProperty); }
			set { SetValue(IsDownOpenProperty, value); }
		}

		/// <summary>
		///	Gets or sets the text in the <see cref="RadDateTimePicker"/> control. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// The <strong>DateTimeText</strong> property changes while user has typed a text in the textbox. 
		/// There is a difference between <strong>DateTimeText</strong> and <strong>CurrentDateTimeText</strong>. 
		/// DateTimeText property changes when user had already entered a text. For example, this happens when the textbox has lost the focus. 
		/// CurrentDateTimeText property changes everytime when user is typing in the textbox.
		/// </remarks>
		/// <see cref="CurrentDateTimeText"/>
		public string DateTimeText
		{
			get { return (string)GetValue(DateTimeTextProperty); }
			set { SetValue(DateTimeTextProperty, value); }
		}

		/// <summary>
		///	Gets or sets the current text in the <see cref="RadDateTimePicker"/> control. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// The <strong>CurrentDateTimeText</strong> property changes while user is typing a text in the textbox. 
		/// There is a difference between <strong>DateTimeText</strong> and <strong>CurrentDateTimeText</strong>. 
		/// DateTimeText property changes when user had already entered a text. For example, this happens when the textbox has lost the focus. 
		/// CurrentDateTimeText property changes everytime when user is typing in the textbox.
		/// </remarks>
		/// <see cref="DateTimeText"/>
		public string CurrentDateTimeText
		{
			get { return (string)GetValue(CurrentDateTimeTextProperty); }
			set { SetValue(CurrentDateTimeTextProperty, value); }
		}

		/// <summary>
		///	Gets or sets InputMode that specifies whether the RadDateTimePicker will allow Time input, Date input or both. This is a dependency property.
		/// </summary>
		/// <remarks>
		/// The default is both - Date and Time input.
		/// </remarks>
		/// <value>The <see cref="InputMode"/> of the <see cref="RadDateTimePicker"/>.</value>
		/// <see cref="Telerik.Windows.Controls.InputMode"/>
		public InputMode InputMode
		{
			get { return (InputMode)GetValue(InputModeProperty); }
			set { SetValue(InputModeProperty, value); }
		}

		/// <summary>
		///	Gets or sets a value that indicates whether this instance of <see cref="RadDateTimePicker"/> is read only. This is a dependency property.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is read only; otherwise, <c>false</c>.
		/// </value>
		public bool IsReadOnly
		{
			get { return (bool)GetValue(IsReadOnlyProperty); }
			set { SetValue(IsReadOnlyProperty, value); }
		}

		/// <summary>
		///	Gets or sets the format that is used to display the selected date. This is a dependency property.
		/// </summary>
		/// <see cref="Telerik.Windows.Controls.DateTimePickerFormat"/>
		public DateTimePickerFormat DisplayFormat
		{
			get { return (DateTimePickerFormat)GetValue(DisplayFormatProperty); }
			set { SetValue(DisplayFormatProperty, value); }
		}

		/// <summary>
		/// Gets or sets the first date to be displayed. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DisplayDateStart"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.DisplayDateStart"/>

		public DateTime? DisplayDateStart
		{
			get { return (DateTime?)GetValue(DisplayDateStartProperty); }
			set { SetValue(DisplayDateStartProperty, value); }
		}

		/// <summary>
		/// Gets or sets the last date to be displayed. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DisplayDateEnd"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.DisplayDateEnd"/>

		public DateTime? DisplayDateEnd
		{
			get { return (DateTime?)GetValue(DisplayDateEndProperty); }
			set { SetValue(DisplayDateEndProperty, value); }
		}

		/// <summary>
		/// Gets or sets the first date that can be selected. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.SelectableDateStart"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.SelectableDateStart"/>

		public DateTime? SelectableDateStart
		{
			get { return (DateTime?)GetValue(SelectableDateStartProperty); }
			set { SetValue(SelectableDateStartProperty, value); }
		}

		/// <summary>
		/// Gets or sets the last date that can be selected. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.SelectableDateEnd"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.SelectableDateEnd"/>

		public DateTime? SelectableDateEnd
		{
			get { return (DateTime?)GetValue(SelectableDateEndProperty); }
			set { SetValue(SelectableDateEndProperty, value); }
		}

		/// <summary>
		/// Gets or sets the time interval that will be used when generating the Time selection (clock, RadClock, etc.) items.
		/// </summary>
		/// <remarks>
		/// Please note that it will not be used if <strong>InputMode</strong> is set to <strong>DatePicker</strong>.
		/// </remarks>
		/// <value>The <strong>TimeSpan</strong> that represents the time interval.</value>
		/// <see cref="InputMode"/>
		public TimeSpan TimeInterval
		{
			get
			{
				return (TimeSpan)this.GetValue(RadDateTimePicker.TimeIntervalProperty);
			}
			set
			{
				this.SetValue(RadDateTimePicker.TimeIntervalProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the end time of Telerik.Windows.Controls.RadDateTimePicker control.
		/// </summary>
		/// <remarks>
		/// The <strong>TimeInterval</strong>property will be used when generating the Time selection (clock, RadClock, etc.) items.
		/// Please note that it will not be used if InputMode is set to <strong>DatePicker</strong>.
		/// </remarks>
		/// <value>The <strong>TimeSpan</strong> that represents end time.</value>
		/// <see cref="InputMode"/>
		public TimeSpan EndTime
		{
			get
			{
				return (TimeSpan)this.GetValue(RadDateTimePicker.EndTimeProperty);
			}
			set
			{
				this.SetValue(RadDateTimePicker.EndTimeProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the start time of Telerik.Windows.Controls.RadDateTimePicker control.
		/// </summary>
		/// <remarks>
		/// The <strong>TimeInterval</strong>property will be used when generating the Time selection (clock, RadClock, etc.) items.
		/// Please note that it will not be used if InputMode is set to <strong>DatePicker</strong>.
		/// </remarks>
		/// <value>The <strong>TimeSpan</strong> that represents start time.</value>
		/// <see cref="InputMode"/>
		public TimeSpan StartTime
		{
			get
			{
				return (TimeSpan)this.GetValue(RadDateTimePicker.StartTimeProperty);
			}
			set
			{
				this.SetValue(RadDateTimePicker.StartTimeProperty, value);
			}
		}

		private DateTime CurrentDateTime
		{
			get
			{
				return this.SelectedValue == null ? DateTime.Now : this.SelectedValue.Value;
			}
		}

		/// <summary>
		///	Resets the theme of the DateTimePicker.
		/// </summary>
		void IThemable.ResetTheme()
		{

			this.SetDefaultStyleKey();

		}

		/// <summary>
		///     When overridden in a derived class, is invoked whenever application code
		///     or internal processes (such as a rebuilding layout pass) call System.Windows.Controls.Control.ApplyTemplate().
		///     In simplest terms, this means the method is called just before a UI element
		///    displays in an application. For more information, see Remarks.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			this.GoToState(false);


			// This is a work-around for a strange bug in WPF that appears when the DateTimePicker is used in a DataGrid, placed in the QSF.
			// In this case the binding is cleared somehow.
			var element = this.GetTemplateChild("PART_DateTimeInput") as RadWatermarkTextBox;
			if (element != null && element.GetBindingExpression(RadWatermarkTextBox.CurrentTextProperty) == null)
			{
				element.SetBinding(RadWatermarkTextBox.CurrentTextProperty,
					new System.Windows.Data.Binding("CurrentDateTimeText") { Source = this, Mode = System.Windows.Data.BindingMode.TwoWay });
			}

		}

		/// <summary>
		///		Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);
			this.SetDefaultStyleKey();
		}


		/// <summary>
		///	Called before the <see cref="System.Windows.UIElement.KeyDown"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			this.ProcessKey(e);
		}

		/// <summary>
		///	Process with the selected key.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void ProcessKey(KeyEventArgs e)
		{
			if (e.Key == Key.F4 || e.Key == Key.Down)
			{
				this.UpdateValueFromCurrentText();
				this.IsDropDownOpen = true;
				e.Handled = true;
			}
			else if (e.Key == Key.Escape && this.IsDropDownOpen)
			{
				this.IsDropDownOpen = false;
				e.Handled = true;
			}
			else if (e.Key == Key.Enter && this.IsDropDownOpen)
			{
				this.IsDropDownOpen = false;
				e.Handled = true;
			}
			else if (e.Key == Key.Enter)
			{
				this.UpdateValueFromCurrentText();
			}
		}

		/// <summary>
		///	Called before the <see cref="System.Windows.UIElement.LostFocus"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnLostFocus(RoutedEventArgs e)
		{
			base.OnLostFocus(e);

			this.OnControlLostFocus(e);

			this.ClosePopupsIfOpen();
		}

		/// <summary>
		///	Called before the <see cref="System.Windows.UIElement.GotFocus"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			base.OnGotFocus(e);

			this.OnControlGotFocus(e);

			var element = this.GetTemplateChild("PART_DateTimeInput") as FrameworkElement;
			if (element != null)
			{
				element.Focus();
			}

		}

		/// <summary>
		///	Called before the <see cref="System.Windows.UIElement.MouseLeave"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnMouseEnter(MouseEventArgs e)
		{
			base.OnMouseEnter(e);

			this.MouseOver(e);
		}

		/// <summary>
		///	Called before the <see cref="System.Windows.UIElement.MouseLeave"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnMouseLeave(MouseEventArgs e)
		{
			base.OnMouseLeave(e);

			this.OnMouseControlLeave(e);
		}

		/// <summary>
		///	Raises the ParseDateTimeValue routed event.
		/// </summary>
		/// <param name="e">The data for the routed event.</param>
		protected virtual void OnParseDateTime(ParseDateTimeEventArgs e)
		{
			this.RaiseEvent(e);
		}

		/// <summary>
		///	Called when the <see cref="Telerik.Windows.Controls.RadDateTimePicker.SelectionChanged"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnSelectionChanged(SelectionChangedEventArgs e)
		{
			this.RaiseEvent(e);
		}

		private static void OnSelectedValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var picker = (RadDateTimePicker)d;
			picker.OnSelectedValueChanged();
			picker.NotifySelectionChanged(e.OldValue as DateTime?, e.NewValue as DateTime?);
		}

		private static void OnSelectedDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).OnSelectedDateChanged();
		}

		private static void OnSelectedTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).OnSelectedTimeChanged();
		}

		private static void OnCultureChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).UpdateText();
		}

		private static void OnDateTimeTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).OnDateTimeTextChanged();
		}

		private static void OnIsDropDownOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).OnIsDropDownOpenChanged();
		}

		private static void OnCurrentDateTimeTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).OnCurrentDateTimeTextChanged();
		}

		private static void OnInputModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).GoToState(true);
			((RadDateTimePicker)d).UpdateText();
		}

		private static void OnDisplayFormatChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadDateTimePicker)d).UpdateText();
		}

		private void UpdateValueFromCurrentText()
		{
			this.DateTimeText = this.CurrentDateTimeText;
		}

		private void OnKeyDown(object sender, KeyEventArgs args)
		{
			// Should process the handled events only. The rest are already processed.
			if (args.Handled)
			{
				this.ProcessKey(args);
			}
		}

		private void OnIsDropDownOpenChanged()
		{
			if (!this.IsDropDownOpen)
			{
				this.Dispatcher.BeginInvoke(new Action(() => this.Focus()));
			}
		}

		private void OnDateTimeTextChanged()
		{
			this.CurrentDateTimeText = this.DateTimeText;
			if (this.supressUpdateDateTimeText)
			{
				return;
			}

			if (string.IsNullOrEmpty(this.DateTimeText))
			{
				this.SelectedValue = null;
				return;
			}

			var parserToUse = this.GetInputParser();
			DateTime? result;

			if (this.ParseDateTime(this.DateTimeText, parserToUse, ParseDateTimeValueEvent, out result))
			{
				this.SelectedValue = result;

				this.UpdateText();
			}
		}

		private void OnCurrentDateTimeTextChanged()
		{
			if (!RadControl.IsInDesignMode && this.IsTooltipEnabled)
			{
				DateTime temp;

				if (string.IsNullOrEmpty(this.CurrentDateTimeText))
				{
					this.IsTooltipOpen = false;
				}
				else
				{
					// TODO: The event should be thrown as well.
					var parser = this.GetInputParser();
					parser.DateTimeFormat = this.GetDateTimeFormatInfo();
					if (parser.TryParse(this.CurrentDateTimeText, out temp, this.CurrentDateTime))
					{
						this.TooltipContent = temp.ToString(this.GetPattern());
					}
					else
					{
						this.TooltipContent = this.ErrorTooltipContent;
					}
					this.IsTooltipOpen = this.CurrentDateTimeText != this.DateTimeText;
				}
			}
		}

		private IDateTimeParser GetInputParser()
		{
			IDateTimeParser targetParser = null;
			switch (this.InputMode)
			{
				case InputMode.DatePicker:
					targetParser = this.dateParser;
					break;
				case InputMode.TimePicker:
					targetParser = this.timeParser;
					break;
				default:
					targetParser = this.dateTimeParser;
					break;
			}
			targetParser.DateTimeFormat = this.GetDateTimeFormatInfo();
			return targetParser;
		}

		// Note: This method should become public after the Beta.
		private void UpdateText()
		{
			Dispatcher.BeginInvoke(new Action(() =>
			{
				this.supressUpdateDateTimeText = true;
				this.DateTimeText = this.SelectedValue.HasValue ? this.SelectedValue.Value.ToString(this.GetPattern()) : string.Empty;
				this.supressUpdateDateTimeText = false;
			}));
		}

		private bool ParseDateTime(string text, IDateTimeParser parser, RoutedEvent eventToFire, out DateTime? dateTime)
		{
			var parseResult = DateTime.Now;
			parser.DateTimeFormat = this.GetDateTimeFormatInfo();
			var isSuccessfull = parser.TryParse(text, out parseResult, this.CurrentDateTime);
			var arguments = new ParseDateTimeEventArgs(eventToFire, text, this.CurrentDateTime, parseResult, isSuccessfull);
			this.OnParseDateTime(arguments);

			if (arguments.IsParsingSuccessful)
			{
				dateTime = arguments.Result;
			}
			else
			{
				dateTime = null;
			}

			return arguments.IsParsingSuccessful;
		}

		private void OnSelectedValueChanged()
		{
			this.UpdateText();

			if (this.InputMode != Controls.InputMode.DateTimePicker)
			{
				this.IsDropDownOpen = false;
			}

			this.supressUpdateValue = true;
			this.SelectedDate = this.SelectedValue.HasValue ? this.SelectedValue.Value.Date : null as DateTime?;
			this.DisplayDate = this.SelectedDate.HasValue ? this.SelectedDate.Value : DateTime.Now;
			this.SelectedTime = this.SelectedValue.HasValue ? this.SelectedValue.Value.TimeOfDay : null as TimeSpan?;
			this.supressUpdateValue = false;
		}

		private string GetPattern()
		{
			var dateTimeFomratInfo = this.GetDateTimeFormatInfo();

			switch (this.InputMode)
			{
				case InputMode.DatePicker:
					return this.DisplayFormat == DateTimePickerFormat.Long ? dateTimeFomratInfo.LongDatePattern : dateTimeFomratInfo.ShortDatePattern;
				case InputMode.TimePicker:
					return this.DisplayFormat == DateTimePickerFormat.Long ? dateTimeFomratInfo.LongTimePattern : dateTimeFomratInfo.ShortTimePattern;
				default:
					return this.DisplayFormat == DateTimePickerFormat.Long ? string.Format("{0} {1}", dateTimeFomratInfo.LongDatePattern, dateTimeFomratInfo.LongTimePattern)
																		   : string.Format("{0} {1}", dateTimeFomratInfo.ShortDatePattern, dateTimeFomratInfo.ShortTimePattern);
			}
		}

		private void NotifySelectionChanged(DateTime? oldValue, DateTime? newValue)
		{
			var oldValues = new List<DateTime>();
			var newValues = new List<DateTime>();

			if (oldValue != null)
			{
				oldValues.Add(oldValue.Value);
			}

			if (newValue != null)
			{
				newValues.Add(newValue.Value);
			}

			this.OnSelectionChanged(new SelectionChangedEventArgs(SelectionChangedEvent, oldValues, newValues));
		}

		private void OnSelectedDateChanged()
		{
			if (!this.supressUpdateValue)
			{
				this.MergeSelectedValue();
			}
		}

		private void OnSelectedTimeChanged()
		{
			if (!this.supressUpdateValue)
			{
				this.MergeSelectedValue();
			}
		}

		private void MergeSelectedValue()
		{
			var current = this.CurrentDateTime;

			var date = this.SelectedDate.HasValue ? this.SelectedDate.Value : current;
			var time = this.SelectedTime.HasValue ? this.SelectedTime.Value : current.TimeOfDay;

			this.SelectedValue = new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, time.Seconds, time.Milliseconds);
		}

		private void ClosePopupsIfOpen()
		{
			if (!this.IsFocusWithin())
			{
				this.IsDropDownOpen = false;
				this.IsTooltipOpen = false;
			}
		}

		private DateTimeFormatInfo GetDateTimeFormatInfo()
		{
			if (this.Culture != null && this.Culture.DateTimeFormat != null)
			{
				return this.Culture.DateTimeFormat;
			}
			else
			{
				return CultureInfo.CurrentCulture.DateTimeFormat;
			}
		}

		private void OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			this.GoToState(true);
		}

		private void OnUnloaded(object sender, RoutedEventArgs e)
		{
			this.IsEnabledChanged -= this.OnIsEnabledChanged;
			this.Unloaded -= this.OnUnloaded;
		}

		private bool IsFocusWithin()
		{

			var visualRoot = ApplicationHelper.GetRootVisual(this);
			UIElement element = visualRoot == null ? null : FocusManager.GetFocusedElement(visualRoot) as UIElement;


			return element != null && element.ParentOfType<RadDateTimePicker>() == this;
		}

		partial void GoToState(bool useTransition);

		partial void MouseOver(MouseEventArgs e);

		partial void OnMouseControlLeave(MouseEventArgs e);

		partial void OnControlGotFocus(RoutedEventArgs e);

		partial void OnControlLostFocus(RoutedEventArgs e);


		private void SetDefaultStyleKey()
		{
			Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(RadDateTimePicker));
            this.DefaultStyleKey =  typeof(RadDateTimePicker);
		}

		private void OnLostFocus(object sender, RoutedEventArgs e)
		{
			this.ClosePopupsIfOpen();
		}

	}
}
