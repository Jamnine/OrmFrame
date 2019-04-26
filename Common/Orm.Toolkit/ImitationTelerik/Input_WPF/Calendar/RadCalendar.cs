using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Calendar;


using CalendarButton = Orm.Toolkit.Telerik.Windows.Controls.Calendar.CalendarButton;
using CalendarDateChangedEventArgs = Orm.Toolkit.Telerik.Windows.Controls.Calendar.CalendarDateChangedEventArgs;
using CalendarModeChangedEventArgs = Orm.Toolkit.Telerik.Windows.Controls.Calendar.CalendarModeChangedEventArgs;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	///     Represents a selection control that allows you to slect dates from a calendar.
	/// </summary>
	/// <remarks>
	///     <para>
	///         The <strong>Calendar</strong> control allows the user to select a single date.
	///     </para>
	///     <para>
	///         The user can navigate in the <strong>Calendar</strong> by clicking the arrow buttons in the calendar 
	///         header that would cycle through the list of days, months or years. Clicking inbetween the two 
	///         arrows would change the <see cref="DisplayMode"/> of the calendar so that it displays a year 
	///         if a month was displayed (The same applies for. Clicking the button with today's date would 
	///         navigate to the month view of the current month.
	///     </para>
	///     <para>
	///         The <strong>SelectionMode</strong> allows more than one date to be selected. There are three 
	///         modes of selection - SelectionMode.Single, SelectionMode.Multiple 
	///         and SelectionMode.Extended. Advanced keyboard selection - dragging while 
	///         holding Ctrl or/and Shift is supported. The <see cref="SelectedDates"/> property is a list of all 
	///         selected dates.
	///     </para>
	///     <para>
	///         The <see cref="DisplayMode"/> property allows you to get or set the current display mode. 
	///         By handling the <see cref="DisplayModeChanged"/> routed event you would recieve a notification 
	///         whenever a change in the display mode occurs.
	///     </para>
	///     <para>
	///         <strong>Disabling or enabling the selection of dates</strong> can be controlled by the <see cref="SelectableDateStart"/> 
	///         and <see cref="SelectableDateEnd"/> properties. If none of the latter 
	///         two has been set, i.e. their value is <strong>null</strong> 
	///         then all the <strong>calendar</strong> dates are selctable. 
	///     </para>
	///     <para>
	///         The <see cref="SelectedDate"/> property holds the <strong>DateTime</strong> value of the selected date. 
	///         The default value is <strong>null</strong> (no date is selected). Adding a handler for the <see cref="SelectedDate"/> 
	///         event would enable you to be notified whenever a date is selected.
	///     </para>
	///     <para>
	///         Similarly, to modify which dates the user can navigate to, use the DisplayDateStart and DisplayDateEnd 
	///         properties. Setting the <see cref="DisplayDate"/> property navigates the calendar to the month or year 
	///         that contain this date (depending on the current <strong>DisplayMode</strong>). Please note that the 
	///         DisplayDate property <strong>cannot be set to null</strong>.
	///     </para>
	///     <para>
	///         The Calendar has more than 20 properties which allow you to set styles, style seelectors, templates and
	///         template selectors for the different views and buttons of the Calendar. The Calendar help articles provide 
	///         more information on the control parts and template structures.
	///     </para>
	///     <para>
	///         Please note that the <strong>RadCalendar</strong> currently supports <strong>only Gregorian</strong> calendar
	///     </para>
	/// </remarks>
	/// <seealso cref="RadCalendar.SelectedDate"/>
	/// <seealso cref="RadCalendar.DisplayDate"/>
	/// <seealso cref="RadCalendar.SelectableDateStart"/>
	/// <seealso cref="RadCalendar.DisplayDateStart"/>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Currently not feasible")]
	[DefaultProperty("SelectedDate")]
	[DefaultEvent("DateSelected")]


	[Themable]

	[StyleTypedProperty(Property = "CenturyViewStyle", StyleTargetType = typeof(CalendarView))]
	[StyleTypedProperty(Property = "DecadeViewStyle", StyleTargetType = typeof(CalendarView))]
	[StyleTypedProperty(Property = "YearViewStyle", StyleTargetType = typeof(CalendarView))]
	[StyleTypedProperty(Property = "MonthViewStyle", StyleTargetType = typeof(CalendarView))]

	[StyleTypedProperty(Property = "DecadeButtonStyle", StyleTargetType = typeof(CalendarButton))]
	[StyleTypedProperty(Property = "YearButtonStyle", StyleTargetType = typeof(CalendarButton))]
	[StyleTypedProperty(Property = "MonthButtonStyle", StyleTargetType = typeof(CalendarButton))]
	[StyleTypedProperty(Property = "DayButtonStyle", StyleTargetType = typeof(CalendarButton))]
	public class RadCalendar : Control, IThemable
	{
		/// <summary>
		/// Identifies the <c cref="SelectionChanged"/> Event.
		/// </summary>
		public static readonly RoutedEvent SelectionChangedEvent = EventManager.RegisterRoutedEvent("SelectionChanged", RoutingStrategy.Bubble, typeof(SelectionChangedEventHandler), typeof(RadCalendar));

		/// <summary>
		/// Identifies the <c cref="DisplayDateChanged"/> Event.
		/// </summary>
		public static readonly RoutedEvent DisplayDateChangedEvent = EventManager.RegisterRoutedEvent("DisplayDateChanged", RoutingStrategy.Bubble, typeof(EventHandler<CalendarDateChangedEventArgs>), typeof(RadCalendar));

		/// <summary>
		/// Identifies the <c cref="DisplayModeChanged"/> Event.
		/// </summary>
		public static readonly RoutedEvent DisplayModeChangedEvent = EventManager.RegisterRoutedEvent("DisplayModeChanged", RoutingStrategy.Bubble, typeof(EventHandler<CalendarModeChangedEventArgs>), typeof(RadCalendar));

		/// <summary>
		/// Identifies the <c cref="YearViewHeaderFormat"/> property.
		/// </summary>
		public static readonly DependencyProperty YearViewHeaderFormatProperty = DependencyProperty.Register("YearViewHeaderFormat", typeof(string), typeof(RadCalendar), new PropertyMetadata(OnYearViewHeaderFormatChanged));

		/// <summary>
		/// Identifies the <c cref="YearViewPanel"/> property.
		/// </summary>
		public static readonly DependencyProperty YearViewPanelProperty = DependencyProperty.Register("YearViewPanel", typeof(ItemsPanelTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="YearViewStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty YearViewStyleProperty = DependencyProperty.Register("YearViewStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="YearTemplateSelector"/> property.
		/// </summary>
		public static readonly DependencyProperty YearTemplateSelectorProperty = DependencyProperty.Register("YearTemplateSelector", typeof(DataTemplateSelector), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="YearTemplate"/> property.
		/// </summary>
		public static readonly DependencyProperty YearTemplateProperty = DependencyProperty.Register("YearTemplate", typeof(DataTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="YearButtonStyleSelector"/> property.
		/// </summary>
		public static readonly DependencyProperty YearButtonStyleSelectorProperty = DependencyProperty.Register("YearButtonStyleSelector", typeof(StyleSelector), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="YearButtonStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty YearButtonStyleProperty = DependencyProperty.Register("YearButtonStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="ViewsHeaderVisibility"/> property.
		/// </summary>
		public static readonly DependencyProperty ViewsHeaderVisibilityProperty = DependencyProperty.Register("ViewsHeaderVisibility", typeof(Visibility), typeof(RadCalendar), new PropertyMetadata(Visibility.Collapsed, null, null));

		/// <summary>
		///     Identifies the <c cref="SelectableDateStart"/> dependency property. 
		/// </summary>
		public static readonly DependencyProperty SelectableDateStartProperty = DependencyPropertyExtensions.Register("SelectableDateStart", typeof(DateTime?), typeof(RadCalendar), new PropertyMetadata(null, OnSelectableDateStartChanged, CoerceSelectableDateStart));

		/// <summary>
		///     Identifies the <c cref="SelectionMode"/> dependency property. 
		/// </summary> 
		public static readonly DependencyProperty SelectionModeProperty = DependencyProperty.Register("SelectionMode", typeof(SelectionMode), typeof(RadCalendar), new PropertyMetadata(SelectionMode.Single, OnSelectionModeChanged, null));

		/// <summary>
		///     Identifies the <c cref="SelectableDateEnd"/> property.
		/// </summary> 
		public static readonly DependencyProperty SelectableDateEndProperty = DependencyPropertyExtensions.Register("SelectableDateEnd", typeof(DateTime?), typeof(RadCalendar), new PropertyMetadata(null, OnSelectableDateEndChanged, CoerceSelectableDateEnd));

		/// <summary>
		///     Identifies the <c cref="SelectedDate"/> dependency property. 
		/// </summary> 
		public static readonly DependencyProperty SelectedDateProperty = DependencyPropertyExtensions.Register("SelectedDate", typeof(DateTime?), typeof(RadCalendar), new PropertyMetadata(null, OnSelectedDateChanged, null));

		/// <summary>
		/// Identifies the <c cref="MonthViewPanel"/> property.
		/// </summary>
		public static readonly DependencyProperty MonthViewPanelProperty = DependencyProperty.Register("MonthViewPanel", typeof(ItemsPanelTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="MonthViewStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty MonthViewStyleProperty = DependencyProperty.Register("MonthViewStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="Orientation"/> property.
		/// </summary>
		public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register("Orientation", typeof(Orientation), typeof(RadCalendar), new PropertyMetadata(Orientation.Horizontal, null, null));

		/// <summary>
		/// Identifies the <c cref="Rows"/> property.
		/// </summary>
		public static readonly DependencyProperty RowsProperty = DependencyPropertyExtensions.Register("Rows", typeof(int), typeof(RadCalendar), new PropertyMetadata(1, OnRowsChanged, CoerceRows));

		/// <summary>
		/// Identifies the <c cref="MonthViewHeaderFormat"/> property.
		/// </summary>
		public static readonly DependencyProperty MonthViewHeaderFormatProperty = DependencyProperty.Register("MonthViewHeaderFormat", typeof(string), typeof(RadCalendar), new PropertyMetadata(OnMonthViewHeaderFormatChanged));

		/// <summary>
		/// Identifies the <c cref="MonthButtonStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty MonthButtonStyleProperty = DependencyProperty.Register("MonthButtonStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="MonthButtonStyleSelector"/> property.
		/// </summary>
		public static readonly DependencyProperty MonthButtonStyleSelectorProperty = DependencyProperty.Register("MonthButtonStyleSelector", typeof(StyleSelector), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="MonthTemplate"/> property.
		/// </summary>
		public static readonly DependencyProperty MonthTemplateProperty = DependencyProperty.Register("MonthTemplate", typeof(DataTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="MonthTemplateSelector"/> property.
		/// </summary>
		public static readonly DependencyProperty MonthTemplateSelectorProperty = DependencyProperty.Register("MonthTemplateSelector", typeof(DataTemplateSelector), typeof(RadCalendar), null);

		/// <summary> 
		///     Identifies the <c cref="IsTodayHighlighted"/> dependency property.
		/// </summary>
		public static readonly DependencyProperty IsTodayHighlightedProperty = DependencyProperty.Register("IsTodayHighlighted", typeof(bool), typeof(RadCalendar), new PropertyMetadata(true, OnIsTodayHighlightedChanged, null));

		/// <summary>
		///     Identifies the <c cref="IsReadOnly"/> proeprty.
		/// </summary>
		public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(RadCalendar), null);

		/// <summary>
		///     Identifies the <c cref="HeaderVisibility"/> property.
		/// </summary>
		public static readonly DependencyProperty HeaderVisibilityProperty = DependencyProperty.Register("HeaderVisibility", typeof(Visibility), typeof(RadCalendar), new PropertyMetadata(OnHeaderVisibilityChanged));

		/// <summary>
		/// Identifies the <c cref="FirstDayOfWeek"/> property.
		/// </summary>
		public static readonly DependencyProperty FirstDayOfWeekProperty = DependencyProperty.Register("FirstDayOfWeek", typeof(DayOfWeek?), typeof(RadCalendar), new PropertyMetadata(OnFirstDayOfWeekChanged));

		/// <summary>
		///     Identifies the <c cref="DisplayMode"/> Property.
		/// </summary>
		public static readonly DependencyProperty DisplayModeProperty = DependencyProperty.Register("DisplayMode", typeof(DisplayMode), typeof(RadCalendar), new PropertyMetadata(DisplayMode.MonthView, OnDisplayModeChanged, null));

		/// <summary>
		/// Identifies the <c cref="DisplayDateStartProperty"/>.
		/// </summary>
		public static readonly DependencyProperty DisplayDateStartProperty = DependencyPropertyExtensions.Register("DisplayDateStart", typeof(DateTime?), typeof(RadCalendar), new PropertyMetadata(null, OnDisplayDateStartChanged, CoerceDisplayDateStart));

		/// <summary>
		/// Identifies the <c cref="DisplayDateEnd"/> Property.
		/// </summary>
		public static readonly DependencyProperty DisplayDateEndProperty = DependencyPropertyExtensions.Register("DisplayDateEnd", typeof(DateTime?), typeof(RadCalendar), new PropertyMetadata(null, OnDisplayDateEndChanged, CoerceDisplayDateEnd));

		/// <summary>
		/// Identifies the <c cref="DisplayDate"/> property.
		/// </summary>
		public static readonly DependencyProperty DisplayDateProperty =
			DependencyPropertyExtensions.Register(
			"DisplayDate",
			typeof(DateTime),
			typeof(RadCalendar),
			new PropertyMetadata(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), OnDisplayDateChanged, CoerceDisplayDate));

		/// <summary>
		/// Identifies the <c cref="DecadeViewStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty DecadeViewStyleProperty = DependencyProperty.Register("DecadeViewStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DecadeViewPanel"/> property.
		/// </summary>
		public static readonly DependencyProperty DecadeViewPanelProperty = DependencyProperty.Register("DecadeViewPanel", typeof(ItemsPanelTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DecadeViewHeaderFormat"/> property.
		/// </summary>
		public static readonly DependencyProperty DecadeViewHeaderFormatProperty = DependencyProperty.Register("DecadeViewHeaderFormat", typeof(string), typeof(RadCalendar), new PropertyMetadata(OnDecadeViewHeaderFormatChanged));

		/// <summary>
		/// Identifies the <c cref="DayButtonStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty DecadeTemplateSelectorProperty = DependencyProperty.Register("DecadeTemplateSelector", typeof(DataTemplateSelector), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DecadeTemplate"/> property.
		/// </summary>
		public static readonly DependencyProperty DecadeTemplateProperty = DependencyProperty.Register("DecadeTemplate", typeof(DataTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DecadeButtonStyleSelector"/> property.
		/// </summary>
		public static readonly DependencyProperty DecadeButtonStyleSelectorProperty = DependencyProperty.Register("DecadeButtonStyleSelector", typeof(StyleSelector), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DecadeButtonStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty DecadeButtonStyleProperty = DependencyProperty.Register("DecadeButtonStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DayTemplateSelector"/> property.
		/// </summary>
		public static readonly DependencyProperty DayTemplateSelectorProperty = DependencyProperty.Register("DayTemplateSelector", typeof(DataTemplateSelector), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DayTemplate"/> property.
		/// </summary>
		public static readonly DependencyProperty DayTemplateProperty = DependencyProperty.Register("DayTemplate", typeof(DataTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DayButtonStyleSelector"/> property.
		/// </summary>
		public static readonly DependencyProperty DayButtonStyleSelectorProperty = DependencyProperty.Register("DayButtonStyleSelector", typeof(StyleSelector), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="DayButtonStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty DayButtonStyleProperty = DependencyProperty.Register("DayButtonStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="Columns"/> property.
		/// </summary>
		public static readonly DependencyProperty ColumnsProperty = DependencyPropertyExtensions.Register("Columns", typeof(int), typeof(RadCalendar), new PropertyMetadata(1, OnColumnsChanged, CoerceColumns));

		/// <summary>
		/// Indetifies the <c cref="Culture"/> property.
		/// </summary>
		public static readonly DependencyProperty CultureProperty = DependencyProperty.Register("Culture", typeof(CultureInfo), typeof(RadCalendar), new PropertyMetadata(null, OnCultureChange, null));

		/// <summary>
		/// Identifies the <c cref="CenturyViewStyle"/> property.
		/// </summary>
		public static readonly DependencyProperty CenturyViewStyleProperty = DependencyProperty.Register("CenturyViewStyle", typeof(Style), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="CenturyViewPanel"/> property.
		/// </summary>
		public static readonly DependencyProperty CenturyViewPanelProperty = DependencyProperty.Register("CenturyViewPanel", typeof(ItemsPanelTemplate), typeof(RadCalendar), null);

		/// <summary>
		/// Identifies the <c cref="CenturyViewHeaderFormat"/> property.
		/// </summary>
		public static readonly DependencyProperty CenturyViewHeaderFormatProperty = DependencyProperty.Register("CenturyViewHeaderFormat", typeof(string), typeof(RadCalendar), new PropertyMetadata(OnCenturyViewHeaderFormatChanged));

		/// <summary>
		///     Identifies the <c cref="CalendarWeekRule"/> property.
		/// </summary>
		public static readonly DependencyProperty CalendarWeekRuleProperty = DependencyProperty.Register("CalendarWeekRule", typeof(CalendarWeekRule?), typeof(RadCalendar), new PropertyMetadata(OnCalendarWeekRuleChanged));

		/// <summary>
		/// Identifies the <c cref="AreWeekNamesVisible"/> proeprty.
		/// </summary>
		public static readonly DependencyProperty AreWeekNamesVisibleProperty = DependencyProperty.Register("AreWeekNamesVisible", typeof(bool), typeof(RadCalendar), new PropertyMetadata(true, OnAreWeekNamesNumbersVisibleChanged, null));

		/// <summary>
		///		Identifies the <c cref="AreWeekNumbersVisible"/> proeprty.
		/// </summary>
		public static readonly DependencyProperty AreWeekNumbersVisibleProperty = DependencyProperty.Register("AreWeekNumbersVisible", typeof(bool), typeof(RadCalendar), new PropertyMetadata(true, OnAreWeekNamesNumbersVisibleChanged, null));

		/// <summary>
		///		Identifies the <c cref="DateSelectionMode"/> proeprty.
		/// </summary>
		public static readonly DependencyProperty DateSelectionModeProperty = DependencyProperty.Register("DateSelectionMode", typeof(DateSelectionMode), typeof(RadCalendar), new PropertyMetadata(DateSelectionMode.Day, OnDateSelectionModeChanged, null));



		/// <summary>
		/// Gets the latest date that the calendar can display.
		/// </summary>
		public static readonly DateTime MaxDate = new DateTime(3000, 1, 1);

		/// <summary>
		/// Gets the earliest date that the calendar can display.
		/// </summary>
		public static readonly DateTime MinDate = new DateTime(1000, 1, 1);

		//// Constants:

		internal const int MaxColumns = 4;
		internal const int MaxRows = 4;



		private StateFlags stateflags = new StateFlags();
		private TransitionPanel transitionPanel;
		private Button headerButton;
		private RepeatButton moveRightButton;
		private RepeatButton moveLeftButton;
		private Panel monthViews;
		private Panel yearViews;
		private Panel decadeViews;
		private Panel centuryViews;
		private SelectionChanger<DateTime> selection;
		private DateTime? lastSelectedDate;
		private bool controlKeyPressed;
		private bool suppressChange;
		private double multiplier = 1;
		private DateTime visibleDateEnd;
		private DateTime visibleDateStart;
		private bool selectOnEnter;
		private bool skipNextChange;
		private bool setThroughSelectedDate;
		private DateTime? currentDate;
		private bool suspendPopulation;


		// Constructors:
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
		static RadCalendar()
		{

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadCalendar),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadCalendar))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadCalendar),
                new FrameworkPropertyMetadata(typeof(RadCalendar)));

			System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(RadCalendar),
				new FrameworkPropertyMetadata(System.Windows.Input.KeyboardNavigationMode.Once));

		}

		/// <summary>
		///     Initializes a new instance of the RadCalendar class.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to the <see cref="RadCalendar"/> information examples on 
		///         how to use the control.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar"/>
		public RadCalendar()
		{

			this.DisplayDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			this.selection = new SelectionChanger<DateTime>(this.IsDateSelectable);
			this.selection.CoerceItemCallback = new Func<DateTime, DateTime>(this.StripDate);
			this.selection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);

            //TelerikLicense.Verify(this);//禁止验证许可
		}

		//// Events:

		/// <summary> 
		///     Occurs when a date is selected.
		/// </summary> 
		/// <remarks>
		///     <para>
		///         The <strong>DateSelected</strong> event is fired when the <see cref="SelectedDate"/> or 
		///         <see cref="SelectedDates"/> have changed.
		///     </para>
		///     <para>
		///         The DateSelected is designed to be used in single selction mode. For more information 
		///         on handling events in multiple selection mode, please refer to <see cref="RadCalendar.SelectedDates"/>
		///         help article.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar"/>
		/// <seealso cref="RadCalendar.SelectedDate"/>
		/// <seealso cref="RadCalendar.SelectableDateStart"/>
		/// <seealso cref="RadCalendar.SelectableDateEnd"/>
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
		///     Occurs when the DisplayDate property is changed.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>DisplayDateChanged</strong> event is fired when the <see cref="DisplayDate"/> 
		///         property of the calendar changes. 
		///     </para>
		///     <para>
		///         For more information on the event go to the <see cref="RadCalendar.DisplayDate"/> 
		///         help article. 
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar"/>
		/// <seealso cref="RadCalendar.DisplayDate"/>
		/// <seealso cref="RadCalendar.SelectedDate"/>
		/// <seealso cref="RadCalendar.DisplayDateStart"/>
		/// <seealso cref="RadCalendar.DisplayDateEnd"/>
		/// <seealso cref="CalendarDateChangedEventArgs"/>
		public event EventHandler<CalendarDateChangedEventArgs> DisplayDateChanged
		{
			add
			{
				this.AddHandler(DisplayDateChangedEvent, value);
			}
			remove
			{
				this.RemoveHandler(DisplayDateChangedEvent, value);
			}
		}

		/// <summary>
		///     Occurs when the DisplayMode property is changed. 
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>DisplayModeChanged</strong> event is  fired when the <see cref="RadCalendar.DisplayDate"/> proeprty changes.
		///     </para>
		///     <para>
		///         For more infromation please go to the <see cref="RadCalendar.DisplayMode"/> article. 
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar"/>
		/// <seealso cref="RadCalendar.DisplayMode"/>
		/// <seealso cref="RadCalendar.SelectedDate"/>
		public event EventHandler<CalendarModeChangedEventArgs> DisplayModeChanged
		{
			add
			{
				this.AddHandler(DisplayModeChangedEvent, value);
			}
			remove
			{
				this.RemoveHandler(DisplayModeChangedEvent, value);
			}
		}

		internal event EventHandler<RoutedPropertyChangedEventArgs<DateTime>> FocusDateChanged;

		// Public Properties:

		/// <summary>
		///     Gets or sets the DataTemplate selectors for the year buttons in the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="YearTemplateSelector"/> together with the <see cref="YearTemplate"/> specify the 
		///         DataTemplate of the Year buttons in the Decade CalenndarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		[DefaultValue(null)]
		public DataTemplateSelector YearTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(YearTemplateSelectorProperty); }
			set { SetValue(YearTemplateSelectorProperty, value); }
		}

		/// <summary>
		///     Gets or sets the format for the header of the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The YearViewHeaderFormat is a DateTime format which will be used for the header of the YearView.
		///     </para>
		///     <para>
		///         If the property is set to null, a default format "yyyy" will be used.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		[DefaultValue(null)]
		public string YearViewHeaderFormat
		{
			get { return (string)GetValue(YearViewHeaderFormatProperty); }
			set { SetValue(YearViewHeaderFormatProperty, value); }
		}

		/// <summary>
		///     Gets or sets the items panel template for the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The YearView Panel specifies the panel that arranges the month buttons in the year view. By default
		///         it is an UniformGrid with 3 rows and 4 columns.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public ItemsPanelTemplate YearViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(YearViewPanelProperty); }
			set { SetValue(YearViewPanelProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style of the calendar year view. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The year view style specifies the style for the year view. By setting the style
		///         every aspect of the Calendarview can be changed.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Style YearViewStyle
		{
			get { return (Style)GetValue(YearViewStyleProperty); }
			set { SetValue(YearViewStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the visibility of the header of the calendar views (month, year, decade, century). This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         When multi-view calendar is used (the <see cref="Rows"/> and <see cref="Columns"/> properties have been set) 
		///         showing the CalendarViews headers helps the specific views to be identified. 
		///         For example if 4 months are visible, headers would appear on top of each month and not just 
		///         the calendar header.
		///     </para>
		///     <para>
		///         The default value is Collapsed.
		///     </para>
		/// </remarks>
		[DefaultValue(Visibility.Collapsed)]
		[Category(RadCategory.Appearance)]
		public Visibility ViewsHeaderVisibility
		{
			get { return (Visibility)GetValue(ViewsHeaderVisibilityProperty); }
			set { SetValue(ViewsHeaderVisibilityProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style for the year buttons in the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="YearButtonStyleSelector"/> together with the <see cref="YearButtonStyle"/> specify the 
		///         Style of the Year buttons in the Decade CalenndarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Style YearButtonStyle
		{
			get { return (Style)GetValue(YearButtonStyleProperty); }
			set { SetValue(YearButtonStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style selector for the year buttons in the decade views of the Calendar.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="YearButtonStyleSelector"/> together with the <see cref="YearButtonStyle"/> specify the 
		///         Style of the Year buttons in the Decade CalenndarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public StyleSelector YearButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(YearButtonStyleSelectorProperty); }
			set { SetValue(YearButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		///     Gets or sets the content templates for the year buttons in the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="YearTemplateSelector"/> together with the <see cref="YearTemplate"/> specify the 
		///         DataTemplate of the Year buttons in the Decade CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public DataTemplate YearTemplate
		{
			get { return (DataTemplate)GetValue(YearTemplateProperty); }
			set { SetValue(YearTemplateProperty, value); }
		}

		/// <summary>
		///     Gets or sets the types of selection that would be allowed in the Calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The Selection mode in the Calendar works very much like the SelectionMode in a ListBox.
		///     </para>
		///     <list type="bullrt">
		///         <listheader>
		///             <see cref="SelectionMode"/> behaviours:    
		///         </listheader>
		///         <item>
		///             <strong>Single</strong>: At most one date can be selected at any given time. Clicking on a selected 
		///             date deselects it. The arrow keys of the keyboard move the selection.
		///         </item>
		///         <item>
		///             <strong>Multiple</strong>: There is no limit on the number of selected dates. Dragging toggles 
		///             the selection of the dates. Arrow keys movement does not select a date, they can be 
		///             selected with space.
		///         </item>
		///         <item>
		///             <strong>Extended</strong>: Selection very much like the the selection in Explorer. 
		///             Keyboard movement, Shif-Selection and Control-Selection also work.    
		///         </item>
		///     </list>
		///     <para>
		///         Selection across several months is possible, either by navigating to a different month and 
		///         selecting dates there or by displaying more than one months at a time (See 
		///         <see cref="Rows"/> and <see cref="Columns"/> properties).
		///     </para>
		///     <para>
		///         The default value is Single.
		///     </para>
		/// </remarks>
		[DefaultValue(SelectionMode.Single)]
		[Category(RadCategory.Behavior)]
		public SelectionMode SelectionMode
		{
			get { return (SelectionMode)GetValue(SelectionModeProperty); }
			set { SetValue(SelectionModeProperty, value); }
		}

		/// <summary>
		///     Gets or sets the last date that can be selected. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>SelectableDateEnd</strong> specifies the last date that can be selected by the user. 
		///     </para>
		///     <para>
		///         Please note that the SelectableDateEnd should not be set to a date larger than the 
		///         <see cref="DisplayDateEnd"/> or <see cref="MaxDate"/>. The SelectableDate end cannot be set to 
		///         a date smaller than the <see cref="SelectedDate"/>.
		///     </para>
		///     <para>
		///         To specify the range of dates that will be visible to the users, use <see cref="DisplayDateStart"/> 
		///         and <see cref="DisplayDateEnd"/>.
		///     </para>
		/// </remarks>
		/// <see cref="SelectableDateStart"/>
		[DefaultValue(null)]
		[Category(RadCategory.Behavior)]

		public DateTime? SelectableDateEnd
		{
			get { return (DateTime?)GetValue(SelectableDateEndProperty); }
			set { SetValue(SelectableDateEndProperty, value); }
		}

		/// <summary>
		///     Gets or sets the first date that can be selected. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>SelectableDateStart</strong> specifies the first date that can be selected by the user. 
		///     </para>
		///     <para>
		///         Please note that the SelectableDateStart should not be set to a date larger than the 
		///         <see cref="SelectedDate"/>. The SelectableDate end cannot be set to a date smaller than 
		///         the <see cref="DisplayDateStart"/> or <see cref="MinDate"/>
		///     </para>
		///     <para>
		///         To specify the range of dates that will be visible to the users, use <see cref="DisplayDateStart"/> 
		///         and <see cref="DisplayDateEnd"/>.
		///     </para>
		/// </remarks>
		/// <see cref="SelectableDateEnd"/>
		[DefaultValue(null)]
		[Category(RadCategory.Behavior)]

		public DateTime? SelectableDateStart
		{
			get { return (DateTime?)GetValue(SelectableDateStartProperty); }
			set { SetValue(SelectableDateStartProperty, value); }
		}

		/// <summary>
		///     Gets or sets the currently selected date. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>SelectedDate</strong> property identifies the last date that has been selected. 
		///         If more than one date needs to be selected, please see the <see cref="RadCalendar.SelectedDates"/> property.
		///     </para>
		///     <para>
		///         Setting the <strong>SelectedDate</strong> proeprty to <strong>null</strong> would deselect 
		///         any selection. The <strong>default value is null</strong>.
		///     </para>
		///     <para>
		///         Selecting a date fires the <see cref="SelectedDate"/> event. An example about handling 
		///         events is provided below.
		///     </para>
		///     <para>
		///         Please note that the user would not be able to select dates outside the <strong>SelctdableDates</strong>
		///         range defined by the <see cref="SelectableDateStart"/> and <see cref="SelectableDateEnd"/> properties. 
		///         Setting a date outside this range in 
		///         code would result in an <strong>ArgumentOutOfRangeException</strong>.
		///     </para>
		///     <para>
		///         Note that all <strong>DateTime</strong> properties of the <strong>RadCalendar</strong> 
		///         discard the time of the DateTime object, i.e. the <strong>time is coerced to 0:0:0</strong>.
		///     </para>
		/// </remarks>
		[DefaultValue(null)]
		[Category(RadCategory.Appearance)]

		public DateTime? SelectedDate
		{
			get { return (DateTime?)GetValue(SelectedDateProperty); }
			set { SetValue(SelectedDateProperty, value); }
		}

		/// <summary>
		///     Gets an list of the currenly selected dates.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>SelectedDates</strong> collection is an <strong>observable collection</strong> (although it is 
		///         exposed as an IList) which contains the currently selected dates and can be used in binding.
		///     </para>
		///     <para>
		///         In Single SelectionMode the collection would still be populated with the selected date (if any).
		///     </para>
		///     <para>
		///         Just as with <see cref="SelectedDate"/>, all the dates in the collection will be coerced and 
		///         should be between the SelectableDateStart/End and DisplayDateStart/End.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public IList<DateTime> SelectedDates
		{
			get
			{
				return this.selection;
			}
		}

		/// <summary>
		///     Gets or sets the items panel template for the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The MonthView Panel specifies the panel that arranges the day buttons in the month view. By default
		///         it is an UniformGrid with 7 rows and 8 columns.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public ItemsPanelTemplate MonthViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(MonthViewPanelProperty); }
			set { SetValue(MonthViewPanelProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style of the month calendar view. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The month view style specifies the style for the month view. By setting the style
		///         every aspect of the CalendarView can be changed.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Style MonthViewStyle
		{
			get { return (Style)GetValue(MonthViewStyleProperty); }
			set { SetValue(MonthViewStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets whether the orientation of the Calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>Orientation</strong> property specifies how should the dates be arranged 
		///         with regard to the position of the Week Names and Week Numbers. When the 
		///         orientation is <strong>Horizontal</strong>, the <strong>WeekNames appear on top</strong>,
		///         horizontally while the <strong>week numbers are a column</strong> on the left. If 
		///         the Orientation is <strong>Vertical</strong>, the <strong>WeekNames are arranged in a 
		///         Column</strong> on the left, and the <strong>numbers are a row</strong> on the top.
		///     </para>
		///     <para>
		///         The default value is Horizontal.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Orientation Orientation
		{
			get { return (Orientation)GetValue(OrientationProperty); }
			set { SetValue(OrientationProperty, value); }
		}

		/// <summary>
		///     Gets or sets the number of rows of calendar views in the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         When there is more than one calendar view present, the <see cref="ViewsHeaderVisibility"/> 
		///         may make identifying the different months/years easier.
		///     </para>
		///     <para>
		///         The minimum value of the Rows property is one and the maximum is four.
		///     </para>
		/// </remarks>
		/// <seealso cref="Columns"/>
		[Category(RadCategory.Appearance)]
		[DefaultValue(1)]
		public int Rows
		{
			get { return (int)GetValue(RowsProperty); }
			set { SetValue(RowsProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style selector for the month buttons in the year views of the Calendar.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="MonthButtonStyleSelector"/> together with the <see cref="MonthButtonStyle"/> specify the 
		///         Style of the Month buttons in the Year CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public StyleSelector MonthButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(MonthButtonStyleSelectorProperty); }
			set { SetValue(MonthButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		///     Gets or sets the content templates for the month buttons in the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="MonthTemplateSelector"/> together with the <see cref="MonthTemplate"/> specify the 
		///         DataTemplate of the Month buttons in the Year CalenndarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public DataTemplate MonthTemplate
		{
			get { return (DataTemplate)GetValue(MonthTemplateProperty); }
			set { SetValue(MonthTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the DataTemplate selectors for the month buttons in the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="MonthTemplateSelector"/> together with the <see cref="MonthTemplate"/> specify the 
		///         DataTemplate of the Month buttons in the Year CalenndarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public DataTemplateSelector MonthTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(MonthTemplateSelectorProperty); }
			set { SetValue(MonthTemplateSelectorProperty, value); }
		}

		/// <summary>
		///     Gets or sets the format for the header of the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The MonthViewHeaderFormat is a DateTime format which will be used for the header of the MonthView.
		///     </para>
		///     <para>
		///         If the property is set to null, a default format "MMMM' - 'yyyy" will be used.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public string MonthViewHeaderFormat
		{
			get { return (string)GetValue(MonthViewHeaderFormatProperty); }
			set { SetValue(MonthViewHeaderFormatProperty, value); }
		}

		/// <summary>
		///     Gets or sets whether the Calendar's selection can be changed. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>IsReadOnly</strong> property specifies whether the current selection can be changed. 
		///         Please note that the IsReadOnly property governs user intaraction, i.e. the selected 
		///         dates can be changed programatically - through a binding or setting the SelectedDate(s) properties.
		///     </para>
		///     <para>
		///         To disable all the interaction with the Calendar, use the <strong>IsEnabled</strong> property.
		///     </para>
		/// </remarks>
		[DefaultValue(false)]
		[Category(RadCategory.Behavior)]
		public bool IsReadOnly
		{
			get { return (bool)GetValue(IsReadOnlyProperty); }
			set { SetValue(IsReadOnlyProperty, value); }
		}

		/// <summary>
		///     Gets or sets whether the today date would be highlighted. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>IsTodayHighlighted</strong> property indicates whether the today date in 
		///         the calendar would be highlighted. The <strong>default value is true</strong>.
		///     </para>
		///     <para>
		///         Please note that the <strong>IsTodayHighlighted</strong> property does not affect 
		///         whether the today date is selected or not. Use the <see cref="RadCalendar.SelectedDate"/>
		///         or <see cref="RadCalendar.SelectedDates"/> properties to specify the selected date(s).
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.SelectedDate"/>
		/// <seealso cref="RadCalendar.SelectedDates"/>
		[DefaultValue(true)]
		[Category(RadCategory.Appearance)]
		public bool IsTodayHighlighted
		{
			get { return (bool)GetValue(IsTodayHighlightedProperty); }
			set { SetValue(IsTodayHighlightedProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style for the month buttons in the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="MonthButtonStyleSelector"/> together with the <see cref="MonthButtonStyle"/> specify the 
		///         Style of the Month buttons in the Year CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Style MonthButtonStyle
		{
			get { return (Style)GetValue(MonthButtonStyleProperty); }
			set { SetValue(MonthButtonStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the display mode of the Calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>DisplayMode</strong> property controls the span of time the calendar is 
		///         currenly displaying: month, year, decade and century.
		///     </para>
		///     <para>
		///         The display mode can be changed by clicking the calendar header between 
		///         the previous and next buttons and by choosing from the list of months/years/decades. 
		///         Alternatively the DisplayMode can be changed programmaticcally although 
		///         this is not recommeded since this may contradict user expectations.
		///     </para>
		///     <list type="bullet">
		///         <listheader>
		///             The <see cref="DisplayMode">DisplayModes</see> available are:
		///         </listheader>
		///         <item>
		///             <strong>CalendarMode.Month</strong>: The Calendar displays a month, days from the previous 
		///             or next months can also be visible but are visually differentiated and clicking them would 
		///             navigate to the respective month. The names of the days are <strong>localized</strong>
		///             according to the current <strong>thread culture</strong>.
		///         </item>
		///         <item>
		///             <strong>CalendarMode.Year</strong>: The Calendar displays a year - twelve buttons with 
		///             the localized names of the months. The current thread culture is used for the localizaton.
		///         </item>
		///         <item>
		///             <Strong>CalendarMode.Decade</Strong>: The Calendar displays a decade - twelve years, starting
		///             from a year before the chosen decade and ending a year after it.
		///         </item>
		///         <item>
		///             <Strong>CalendarMode.Century</Strong>:  The Calendar displays a century with twelve calendar buttons.
		///         </item>
		///     </list>
		///     <para>
		///         The <see cref="DisplayModeChanged"/> event is fired when the property changes. 
		///         The <see cref="CalendarModeChangedEventArgs"/> provide the old and new value of the 
		///         display mode. An example where the event is used can be found on the 
		///         <see cref="RadCalendar.SelectedDate"/> help page.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.SelectedDate"/>
		/// <seealso cref="CalendarModeChangedEventArgs"/>
		/// <seealso cref="DisplayModeChanged"/>
		/// <seealso cref="DisplayMode"/>
		[DefaultValue(DisplayMode.MonthView)]
		[Category(RadCategory.Appearance)]
		public DisplayMode DisplayMode
		{
			get { return (DisplayMode)GetValue(DisplayModeProperty); }
			set { SetValue(DisplayModeProperty, value); }
		}

		/// <summary> 
		///     Gets or sets the day that is considered the beginning of the week.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>FirstDayOfWeek</strong> property specifies which is the day in the leftmost 
		///         column of the calendar view, i.e. which is the first day of the week. 
		///     </para>
		///     <para>
		///         If the property is set to <strong>null</strong>, the <see cref="Culture"/> will be checked, 
		///         if a specific culture is set, its FirstDayOfWeek is considered.
		///         Otherwise the <strong>CurrentCulture</strong> will be used.
		///     </para>
		///     <para>
		///         Generally, the start of the week varies with different cultures so if you would like 
		///         the <strong>Calendar</strong> to display the dates as you see them, be sure to set the 
		///         FirstDayOfWeek property or the <see cref="Culture"/> property.
		///         <code><![CDATA[
		///             calendar.FirstDayOfWeek = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
		///         ]]></code>
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.DisplayMode"/>
		/// <seealso cref="Culture"/>
		[DefaultValue(DayOfWeek.Sunday)]
		[Category(RadCategory.Appearance)]

		public DayOfWeek? FirstDayOfWeek
		{
			get { return (DayOfWeek?)GetValue(FirstDayOfWeekProperty); }
			set { SetValue(FirstDayOfWeekProperty, value); }
		}

		/// <summary>
		///     Gets or sets the visibility of the Calendar's header. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The header of the calendar is the area on the top in which the Header Button and the Previous
		///         and NextButtons reside.
		///     </para>
		///     <para>
		///         To make the buttons invisible, but still have a header, you can set the HeaderVisibility to <strong>Collapsed</strong> and
		///         <see cref="ViewsHeaderVisibility"/> to <strong>Visible</strong>.
		///     </para>
		/// </remarks>
		[DefaultValue(Visibility.Visible)]
		[Category(RadCategory.Appearance)]
		public Visibility HeaderVisibility
		{
			get { return (Visibility)GetValue(HeaderVisibilityProperty); }
			set { SetValue(HeaderVisibilityProperty, value); }
		}

		/// <summary>
		///     Gets or sets the last date that would be able to be displayed. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>DisplayDateEnd</strong> property can limit the dates which can be navigated to. 
		///         The <strong>DisplayDateEnd</strong> is the date furthest away in time that can be displayed. Setting 
		///         the property to <strong>null</strong> would enable all dates to be viewed.
		///     </para>
		///     <para>
		///         Please note that <strong>ArgumentOutOfRange</strong> exception would be thrown if the 
		///         <strong>DisplayDateEnd</strong> is set to a date earlier than the currently displayed date
		///         (<see cref="DisplayDate"/>).
		///     </para>
		///     <para>
		///         More information about setting the displayble dates' range and an example can be found 
		///         on the <see cref="DisplayDateStart"/> help page.
		///     </para>
		/// </remarks>
		/// <seealso cref="DisplayDateStart"/>
		/// <seealso cref="DisplayDate"/>
		[DefaultValue(null)]
		[Category(RadCategory.Behavior)]

		public DateTime? DisplayDateEnd
		{
			get { return (DateTime?)GetValue(DisplayDateEndProperty); }
			set { SetValue(DisplayDateEndProperty, value); }
		}

		/// <summary>
		///     Gets or sets the first date that would be able to be displayed. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>DisplayDateStart</strong> property together with <see cref="DisplayDateEnd"/> 
		///         allows you to define a range within which the user would be able to navigate. The 
		///         <strong>DisplayDateStart</strong> does not affect whether a date can be selected or not. 
		///         Please refer to <see cref="SelectableDateStart"/> for more information on controlling selection. 
		///     </para>
		///     <para>
		///         For example setting the <strong>DisplayDateStart</strong> to <strong>DateTime.Today</strong>
		///         would ensure that the <strong>Calendar</strong> would not be able to navigate to the 
		///         previous month or year but changing the <see cref="DisplayMode"/> or selecting dates 
		///         from the current month is unaffected.
		///     </para>
		///     <para>
		///         Similarly to the other date properties of the Calendar, the time part of the <strong>DateTime</strong> 
		///         object is not only ignored but set to <strong>00:00:00</strong> as well (coerced). See <see cref="SelectedDate"/>
		///         for an example and more infromation on that behaviour.
		///     </para>
		///     <para>
		///         Setting the <strong>DisplayDateStart</strong> to <strong>null</strong> means that 
		///         <strong>DateTime.MinValue</strong>
		///         would be the start of the displayable range. The default values is null.
		///     </para>
		/// </remarks>
		/// <seealso cref="SelectedDate"/>
		/// <seealso cref="DisplayDateStart"/>
		/// <seealso cref="DisplayDateEnd"/>
		/// <seealso cref="SelectableDateStart"/>
		/// <seealso cref="SelectableDateEnd"/>
		[DefaultValue(null)]
		[Category(RadCategory.Behavior)]

		public DateTime? DisplayDateStart
		{
			get { return (DateTime?)GetValue(DisplayDateStartProperty); }
			set { SetValue(DisplayDateStartProperty, value); }
		}

		/// <summary>
		///     Gets or sets the format for the header of the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The DecadeViewHeaderFormat is a DateTime format which will be used for the header of the DecadeView.
		///     </para>
		///     <para>
		///         If the property is set to null, a default format "yyyy" will be used.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		[DefaultValue(null)]
		public string DecadeViewHeaderFormat
		{
			get { return (string)GetValue(DecadeViewHeaderFormatProperty); }
			set { SetValue(DecadeViewHeaderFormatProperty, value); }
		}

		/// <summary>
		/// Gets or sets the items panel template for the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The DecadeView Panel specifies the panel that arranges the year buttons in the decade view. By default
		///         it is an UniformGrid with 3 rows and 4 columns.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public ItemsPanelTemplate DecadeViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(DecadeViewPanelProperty); }
			set { SetValue(DecadeViewPanelProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style of the decade calendar view. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The decade view style specifies the style for the decade view. By setting the style
		///         every aspect of the CalendarView can be changed.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Style DecadeViewStyle
		{
			get { return (Style)GetValue(DecadeViewStyleProperty); }
			set { SetValue(DecadeViewStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the current date to display. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>DisplayDate</strong> property specifies the date to display in the <see cref="RadCalendar"/>.
		///         If no display date was set, then the <see cref="SelectedDate"/> is used. Alternatively, if no 
		///         date is selected then <strong>DateTime.Today</strong> is used.
		///     </para>
		///     <para>
		///         Setting the display date does not affect the <see cref="DisplayMode"/> of the Calendar, e.g. 
		///         if the <strong>DisplayMode</strong> is set to <strong>Year</strong> changing the DisplayDate 
		///         within the same year would not change the view, while setting a DisplayDate of a different 
		///         year would change the view.
		///     </para>
		///     <para>
		///         Similarly to the other date properties of the Calendar, the time part of the <strong>DateTime</strong> 
		///         object is not only ignored but set to <strong>00:00:00</strong> as well. See <see cref="SelectedDate"/>
		///         for an example and more infromation on that behaviour.
		///     </para>
		///     <para>
		///         The <see cref="DisplayDateStart"/> and <see cref="DisplayDateEnd"/> properties defined a range
		///         within which the <strong>DisplayDate</strong> can be set, i.e. a range within which the user 
		///         can navigate. If you try to set a <strong>DisplayDate outside the defined range</strong> an 
		///         <strong>ArgumentOutOfRangeException</strong> would be thrown. Similarly, setting a display 
		///         range that excludes the current DisplayDate would throw an exception.
		///     </para>
		///     <para>
		///         Changing the <strong>DisplayDate</strong> property fires the <see cref="RadCalendar.DisplayDateChanged"/> 
		///         event. Please note that unless the DisplayDate is changed from code the event would fire 
		///         only when the displayed month or year actually changes, i.e. selecting a day within the 
		///         currenly viewed month would not fire the event (or cahnge the property). Selecting a 
		///         month while the DisplayMode is Year would fire the event if the month is different from the
		///         previously selected.
		///     </para>
		///     <para>
		///         Please note that unlike the other date properties <strong>DisplayDate cannot be set to null</strong>. 
		///     </para>
		/// </remarks>
		/// <seealso cref="SelectedDate"/>
		/// <seealso cref="DisplayDateStart"/>
		/// <seealso cref="DisplayDateEnd"/>
		/// <seealso cref="SelectableDateStart"/>
		/// <seealso cref="SelectableDateEnd"/>
		[Category(RadCategory.Appearance)]

		public DateTime DisplayDate
		{
			get { return (DateTime)GetValue(DisplayDateProperty); }
			set { SetValue(DisplayDateProperty, value); }
		}

		/// <summary>
		///     Gets or sets the content templates for the decade buttons in the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DecadeTemplateSelector"/> together with the <see cref="DecadeTemplate"/> specify the 
		///         DataTemplate of the Decade buttons in the Cantury CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public DataTemplate DecadeTemplate
		{
			get { return (DataTemplate)GetValue(DecadeTemplateProperty); }
			set { SetValue(DecadeTemplateProperty, value); }
		}

		/// <summary>
		///     Gets or sets the DataTemplate selectors for the decade buttons in the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DecadeTemplateSelector"/> together with the <see cref="DecadeTemplate"/> specify the 
		///         DataTemplate of the Decade buttons in the Cantury CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		[DefaultValue(null)]
		public DataTemplateSelector DecadeTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(DecadeTemplateSelectorProperty); }
			set { SetValue(DecadeTemplateSelectorProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style for the day buttons in the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DayButtonStyleSelector"/> together with the <see cref="DayButtonStyle"/> specify the 
		///         Style of the Day buttons in the Month CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Style DayButtonStyle
		{
			get { return (Style)GetValue(DayButtonStyleProperty); }
			set { SetValue(DayButtonStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style selector for the day buttons in the month views of the Calendar.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DayButtonStyleSelector"/> together with the <see cref="DayButtonStyle"/> specify the 
		///         Style of the Day buttons in the Month CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		[DefaultValue(null)]
		public StyleSelector DayButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(DayButtonStyleSelectorProperty); }
			set { SetValue(DayButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		///     Gets or sets the content templates for the day buttons in the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DayTemplateSelector"/> together with the <see cref="DayTemplate"/> specify the 
		///         DataTemplate of the Day buttons in the Month CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public DataTemplate DayTemplate
		{
			get { return (DataTemplate)GetValue(DayTemplateProperty); }
			set { SetValue(DayTemplateProperty, value); }
		}

		/// <summary>
		///     Gets or sets the DataTemplate selectors for the day buttons in the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DayTemplateSelector"/> together with the <see cref="DayTemplate"/> specify the 
		///         DataTemplate of the Day buttons in the Month CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public DataTemplateSelector DayTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(DayTemplateSelectorProperty); }
			set { SetValue(DayTemplateSelectorProperty, value); }
		}

		/// <summary>
		///     Gets or sets the style for the year decade in the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DecadeButtonStyleSelector"/> together with the <see cref="DecadeButtonStyle"/> specify the 
		///         Style of the Day buttons in the Century CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public Style DecadeButtonStyle
		{
			get { return (Style)GetValue(DecadeButtonStyleProperty); }
			set { SetValue(DecadeButtonStyleProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style selector for the decade buttons in the century views of the Calendar.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <see cref="DecadeButtonStyleSelector"/> together with the <see cref="DecadeButtonStyle"/> specify the 
		///         Style of the Day buttons in the Century CalendarView.
		///     </para>
		///     <para>
		///         For more information on styling, see the Calendar help articles.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		public StyleSelector DecadeButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(DecadeButtonStyleSelectorProperty); }
			set { SetValue(DecadeButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style of the century calendar view. This is a dependency property.
		/// </summary>
		[Category(RadCategory.Appearance)]
		public Style CenturyViewStyle
		{
			get { return (Style)GetValue(CenturyViewStyleProperty); }
			set { SetValue(CenturyViewStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the culture that the Calendar uses. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Some of the elements in the Calendar are culture-specific, for example: The <strong>day/month names</strong>,
		///         rules for <strong>date formatting</strong>, the <see cref="FirstDayOfWeek"/>, 
		///         <see cref="CalendarWeekRule"/>. Some more specific properties like <see cref="FirstDayOfWeek"/> 
		///         take precedence over the Culture property if they are set.
		///     </para>
		///     <para>
		///         If no Culture is specified, all the elements that rely on it will fall back to the 
		///         <strong>CultureInfo.CurrentCulture</strong>.
		///     </para>
		///     <para>
		///         The default value is <strong>null</strong>.
		///     </para>
		/// </remarks>
		[DefaultValue(null)]
		[Category(RadCategory.Appearance)]
		public CultureInfo Culture
		{
			get { return (CultureInfo)GetValue(CultureProperty); }
			set { SetValue(CultureProperty, value); }
		}

		/// <summary>
		/// Gets or sets the number of columns of calendar views in the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The minimum value of the Columns property is one and the maximum is four.
		///     </para>
		/// </remarks>
		/// <seealso cref="Rows"/>
		[Category(RadCategory.Appearance)]
		[DefaultValue(1)]
		public int Columns
		{
			get { return (int)GetValue(ColumnsProperty); }
			set { SetValue(ColumnsProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether WeekNumbers will be displayed.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please note that if you hide the WeekNumbers it would not automatically change the template of 
		///         the calendar. Depending on the skin, you may need to change the template to visually 
		///         make up for the fewer displayed elements.
		///     </para>
		///     <para>
		///         The <see cref="AreWeekNamesVisible"/> can also be hidden.    
		///     </para>
		///     <para>
		///         The default value is true.
		///     </para>
		/// </remarks>
		/// <see cref="AreWeekNumbersVisible"/>
		public bool AreWeekNumbersVisible
		{
			get { return (bool)GetValue(AreWeekNumbersVisibleProperty); }
			set { SetValue(AreWeekNumbersVisibleProperty, value); }
		}

		/// <summary>
		///     Gets or sets how should the first week in the year be counted. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         By default if no value is set (or is set to null), the CalendarWeek rule will be ta
		///     </para>
		/// </remarks>
		[Category(RadCategory.Behavior)]
		[DefaultValue(null)]

		public CalendarWeekRule? CalendarWeekRule
		{
			get { return (CalendarWeekRule?)GetValue(CalendarWeekRuleProperty); }
			set { SetValue(CalendarWeekRuleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the format for the header of the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         The CenturyViewHeaderFormat is a DateTime format which will be used for the header of the CenturyView.
		///     </para>
		///     <para>
		///         If the property is set to null, a default format "yyyy" will be used.
		///     </para>
		/// </remarks>
		[Category(RadCategory.Appearance)]
		[DefaultValue(null)]
		public string CenturyViewHeaderFormat
		{
			get { return (string)GetValue(CenturyViewHeaderFormatProperty); }
			set { SetValue(CenturyViewHeaderFormatProperty, value); }
		}

		/// <summary>
		///     Gets or sets the items panel template for the century views of the calendar. This is a dependency property.
		/// </summary>
		[Category(RadCategory.Appearance)]
		public ItemsPanelTemplate CenturyViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(CenturyViewPanelProperty); }
			set { SetValue(CenturyViewPanelProperty, value); }
		}



		/// <summary>
		///     Gets or sets whether WeekNames will be displayed.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please note that if you hide the WeekNames would not automatically change the template of 
		///         the calendar. Depending on the skin, you may need to change the template to visually 
		///         make up for the fewer displayed elements.
		///     </para>
		///     <para>
		///         The <see cref="AreWeekNumbersVisible"/> can also be hidden.    
		///     </para>
		///     <para>
		///         The default value is true.
		///     </para>
		/// </remarks>
		/// <see cref="AreWeekNumbersVisible"/>
		public bool AreWeekNamesVisible
		{
			get { return (bool)GetValue(AreWeekNamesVisibleProperty); }
			set { SetValue(AreWeekNamesVisibleProperty, value); }
		}



		/// <summary>
		///		Gets or sets DateSelectionMode property. This is a dependency property.
		/// </summary>
		public DateSelectionMode DateSelectionMode
		{
			get { return (DateSelectionMode)GetValue(DateSelectionModeProperty); }
			set { SetValue(DateSelectionModeProperty, value); }
		}

		internal StateFlags Flags
		{
			get
			{
				return this.stateflags;
			}
		}

		internal int ViewsCount
		{
			get
			{
				return this.Rows * this.Columns;
			}
		}

		internal bool FocusHandled
		{
			get;
			set;
		}

		internal SelectionChanger<DateTime> SelectionHelper
		{
			get
			{
				return this.selection;
			}
		}

		internal bool SelectOnEnter
		{
			get
			{
				return this.selectOnEnter;
			}
			set
			{
				if (this.skipNextChange)
				{
					this.skipNextChange = false;
				}
				else
				{
					this.selectOnEnter = value;
				}
			}
		}

		private DateTime LastSelectedDate
		{
			get
			{
				if (!this.lastSelectedDate.HasValue)
				{
					this.lastSelectedDate = this.CurrentDate;
				}

				return this.lastSelectedDate.Value;
			}
			set
			{
				this.lastSelectedDate = value;
			}
		}

		private DateTime VisibleDateStart
		{
			get
			{
				if (!this.Flags.IsLoaded)
				{
					return this.GetLastDayofMonth(this.DisplayDate);
				}
				return this.visibleDateStart;
			}
			set
			{
				DateTime displayDateStart = this.DisplayDateStart ?? MinDate;
				int result = DateTime.Compare(value, displayDateStart);
				if (result > 0)
				{
					this.visibleDateStart = value;
				}
				else
				{
					this.visibleDateStart = displayDateStart;
				}
			}
		}

		private DateTime VisibleDateEnd
		{
			get
			{
				if (!this.Flags.IsLoaded)
				{
					return this.GetLastDayofMonth(this.DisplayDate);
				}
				return this.visibleDateEnd;
			}
			set
			{
				DateTime displayDateEnd = this.DisplayDateEnd ?? MaxDate;
				int result = DateTime.Compare(value, displayDateEnd);
				if (result > 0)
				{
					this.visibleDateEnd = displayDateEnd;
				}
				else
				{
					this.visibleDateEnd = value;
				}
			}
		}

		private DateTime CurrentDate
		{
			get
			{
				if (!this.currentDate.HasValue)
				{
					this.currentDate = this.DisplayDate;
				}
				return this.currentDate.Value;
			}
			set
			{
				this.OnFocusDateChanged(this.CurrentDate, value);
				this.currentDate = value;
			}
		}

		/// <summary>
		/// Checks whether the given date is a valid display date for the calendar.
		/// </summary>
		/// <param name="calendar">The calendar to check the display date for.</param>
		/// <param name="newDisplayDate">The new display date to test.</param>
		/// <returns>True if it is a valid display date, flase otherwise.</returns>
		public static bool IsDisplayDateValid(RadCalendar calendar, DateTime newDisplayDate)
		{
			return newDisplayDate <= MaxDate
				&& newDisplayDate >= MinDate
				&& (!calendar.DisplayDateEnd.HasValue || newDisplayDate <= calendar.DisplayDateEnd)
				&& (!calendar.DisplayDateStart.HasValue || newDisplayDate >= calendar.DisplayDateStart);
		}

		/// <summary>
		/// Checks whether the date is a valid SelectableDateStart value for the given calendar.
		/// </summary>
		/// <param name="calendar">The calendar to test for.</param>
		/// <param name="newSelectableDateStart">The date to test.</param>
		/// <returns>True if it is a valid selectable date start, false otherwise.</returns>
		public static bool IsSelectableDateStartValid(RadCalendar calendar, DateTime? newSelectableDateStart)
		{
			if (newSelectableDateStart == null)
			{
				return true;
			}

			DateTime shouldBeLargerThan = calendar.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = calendar.SelectableDateEnd ?? calendar.DisplayDateEnd ?? MaxDate;

			return newSelectableDateStart.Value.Date <= shouldBeSmallerThan.Date
				&& newSelectableDateStart.Value.Date >= shouldBeLargerThan.Date;
		}

		/// <summary>
		/// Checks whether the date is a valid SelectableDateEnd value for the given calendar.
		/// </summary>
		/// <param name="calendar">The calendar to test for.</param>
		/// <param name="newSelectableDateEnd">The date to test.</param>
		/// <returns>True if it is a valid selectable date end, false otherwise.</returns>
		public static bool IsSelectableDateEndValid(RadCalendar calendar, DateTime? newSelectableDateEnd)
		{
			if (newSelectableDateEnd == null)
			{
				return true;
			}

			DateTime shouldBeLargerThan = calendar.SelectableDateStart ?? calendar.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = calendar.DisplayDateEnd ?? MaxDate;

			return newSelectableDateEnd.Value.Date <= shouldBeSmallerThan.Date
				&& newSelectableDateEnd.Value.Date >= shouldBeLargerThan.Date;
		}

		/// <summary>
		/// Checks whether the date is a valid DisplayDateStart value for the given calendar.
		/// </summary>
		/// <param name="calendar">The calendar for which to test the value.</param>
		/// <param name="newDisplayDate">The date to test.</param>
		/// <returns>True if it is a valid display date start, flase otherwise.</returns>
		public static bool IsDisplayDateStartValid(RadCalendar calendar, DateTime? newDisplayDate)
		{
			if (newDisplayDate == null)
			{
				return true;
			}

			return newDisplayDate >= MinDate
				&& newDisplayDate <= calendar.DisplayDate;
		}

		/// <summary>
		/// Checks whether the date is a valid DisplayDateEnd value for the given calendar.
		/// </summary>
		/// <param name="calendar">The calendar for which to test the value.</param>
		/// <param name="newDisplayDateEnd">The date to test.</param>
		/// <returns>True if it is a valid display date end, flase otherwise.</returns>
		public static bool IsDisplayDateEndValid(RadCalendar calendar, DateTime? newDisplayDateEnd)
		{
			if (newDisplayDateEnd == null)
			{
				return true;
			}

			return newDisplayDateEnd <= MaxDate
				&& newDisplayDateEnd >= calendar.DisplayDate;
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			if (this.Flags.HasHeaderButton)
			{
				this.headerButton.Click -= this.OnHeaderButtonClick;
			}
			if (this.Flags.HasMoveLeftButton)
			{
				this.moveLeftButton.Click -= this.OnMoveLeftButtonClick;
			}
			if (this.Flags.HasMoveRightButton)
			{
				this.moveRightButton.Click -= this.MoveRightButtonClick;
			}

			this.transitionPanel = GetTemplateChild("TransitionPanel") as TransitionPanel;
			this.headerButton = GetTemplateChild("Header") as Button;
			this.Flags.HasHeaderButton = this.headerButton != null;
			this.moveLeftButton = GetTemplateChild("MoveLeft") as RepeatButton;
			this.Flags.HasMoveLeftButton = this.moveLeftButton != null;
			this.moveRightButton = GetTemplateChild("MoveRight") as RepeatButton;
			this.Flags.HasMoveRightButton = this.moveRightButton != null;
			this.monthViews = GetTemplateChild("MonthViews") as Panel;
			this.yearViews = GetTemplateChild("YearViews") as Panel;
			this.Flags.HasYearViewsPanel = this.yearViews != null;
			this.decadeViews = GetTemplateChild("DecadeViews") as Panel;
			this.Flags.HasDecadeViewsPanel = this.decadeViews != null;
			this.centuryViews = GetTemplateChild("CenturyViews") as Panel;
			this.Flags.HasCenturyViewsPanel = this.centuryViews != null;

			if (this.Flags.HasHeaderButton)
			{
				this.headerButton.Click += new RoutedEventHandler(this.OnHeaderButtonClick);
			}
			if (this.Flags.HasMoveRightButton)
			{
				this.moveRightButton.Click += new RoutedEventHandler(this.MoveRightButtonClick);
			}
			if (this.Flags.HasMoveLeftButton)
			{
				this.moveLeftButton.Click += new RoutedEventHandler(this.OnMoveLeftButtonClick);
			}

			this.Flags.IsLoaded = true;

			this.UpdateRowsAndColumns();
			this.UpdateCalendarViews();
			this.UpdateTransitionPanel(DisplayMode.DecadeView, DisplayMode);


		}

		/// <summary>
		/// Resets the theme.
		/// </summary>
		public void ResetTheme()
		{

			////this.DefaultStyleKey = this.GetDefaultStyleKey(this);
			this.SetDefaultStyleKey();

		}

		internal static object CoerceSelectableDateStart(DependencyObject sender, object value)
		{
			if (value == null)
			{
				return null;
			}
			RadCalendar calendar = sender as RadCalendar;
			DateTime result = ((DateTime)value).Date;

			DateTime shouldBeLargerThan = calendar.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = calendar.SelectableDateEnd ?? calendar.DisplayDateEnd ?? MaxDate;

			if (result < shouldBeLargerThan)
			{
				return shouldBeLargerThan;
			}

			if (result > shouldBeSmallerThan)
			{
				return shouldBeSmallerThan;
			}

			return result;
		}

		internal static object CoerceSelectableDateEnd(DependencyObject sender, object value)
		{
			if (value == null)
			{
				return null;
			}
			RadCalendar calendar = sender as RadCalendar;
			DateTime result = ((DateTime)value).Date;

			DateTime shouldBeLargerThan = calendar.SelectableDateStart ?? calendar.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = calendar.DisplayDateEnd ?? MaxDate;

			if (result < shouldBeLargerThan)
			{
				return shouldBeLargerThan;
			}

			if (result > shouldBeSmallerThan)
			{
				return shouldBeSmallerThan;
			}

			return result;
		}

		internal static object CoerceDisplayDateStart(DependencyObject sender, object value)
		{
			if (value == null)
			{
				return null;
			}

			RadCalendar calendar = sender as RadCalendar;
			DateTime result = ((DateTime)value).Date;

			DateTime shouldBeLargerThan = MinDate;
			DateTime shouldBeSmallerThan = calendar.DisplayDateEnd ?? MaxDate;

			if (result < shouldBeLargerThan)
			{
				return shouldBeLargerThan;
			}

			if (result > shouldBeSmallerThan)
			{
				return shouldBeSmallerThan;
			}

			return result;
		}

		internal static object CoerceDisplayDate(DependencyObject sender, object value)
		{
			if (value == null)
			{
				return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			}
			RadCalendar calendar = sender as RadCalendar;
			DateTime result = ((DateTime)value).Date;

			DateTime shouldBeLargerThan = calendar.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = calendar.DisplayDateEnd ?? MaxDate;

			if (result < shouldBeLargerThan)
			{
				return shouldBeLargerThan;
			}

			if (result > shouldBeSmallerThan)
			{
				return shouldBeSmallerThan;
			}

			////TODO: Discuss why is this so!
			////BUG: The focus is on a wrong item when diabled and invisible items are present.
			////result = new DateTime(result.Year, result.Month, 1);

			return result;
		}

		internal static object CoerceDisplayDateEnd(DependencyObject sender, object value)
		{
			if (value == null)
			{
				return null;
			}
			RadCalendar calendar = sender as RadCalendar;
			DateTime result = ((DateTime)value).Date;

			DateTime shouldBeLargerThan = calendar.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = MaxDate;

			if (result < shouldBeLargerThan)
			{
				return shouldBeLargerThan;
			}

			if (result > shouldBeSmallerThan)
			{
				return shouldBeSmallerThan;
			}

			return result;
		}

		internal static object CoerceSelectedDate(DependencyObject sender, object value)
		{
			if (value == null)
			{
				return null;
			}

			RadCalendar calendar = sender as RadCalendar;
			DateTime result = ((DateTime)value).Date;

			DateTime shouldBeLargerThan = calendar.SelectableDateStart ?? calendar.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = calendar.SelectableDateEnd ?? calendar.DisplayDateEnd ?? MaxDate;

			if (result < shouldBeLargerThan)
			{
				return null;
			}

			if (result > shouldBeSmallerThan)
			{
				return null;
			}

			return result;
		}

		internal DateTime StripDate(DateTime value)
		{
			return value.Date;
		}


		internal void FocusSelectedDate()
		{
			if (this.SelectedDate.HasValue)
			{
				this.OnFocusDateChanged(DateTime.Now, this.SelectedDate.Value);
			}
			else
			{
				this.OnFocusDateChanged(DateTime.Now, this.CurrentDate);
			}
		}


		internal void OnMoveLeftButtonClick(object sender, RoutedEventArgs e)
		{
			this.MovePrev();
		}

		internal void MoveRightButtonClick(object sender, RoutedEventArgs e)
		{
			this.MoveNext();
		}

		internal void OnHeaderButtonClick(object sender, RoutedEventArgs e)
		{
			DateTime calculatedDate = this.CurrentDate;

			switch (DisplayMode)
			{
				case DisplayMode.MonthView:
					this.DisplayMode = DisplayMode.YearView;
					calculatedDate = GetFirstDayofMonth(this.CurrentDate);
					if (calculatedDate < this.VisibleDateStart)
					{
						calculatedDate = new DateTime(this.VisibleDateStart.Year, this.VisibleDateStart.Month, 1);
					}
					break;
				case DisplayMode.YearView:
					this.DisplayMode = DisplayMode.DecadeView;
					calculatedDate = GetFirstDayofYear(this.CurrentDate);
					if (calculatedDate < this.VisibleDateStart)
					{
						calculatedDate = new DateTime(this.VisibleDateStart.Year, 1, 1);
					}
					break;
				case DisplayMode.DecadeView:
					DisplayMode = DisplayMode.CenturyView;
					calculatedDate = GetFirstDayofDecade(this.CurrentDate);
					break;
				case DisplayMode.CenturyView:
					DisplayMode = DisplayMode.MonthView;
					calculatedDate = GetFirstDayofCentury(this.CurrentDate);
					break;
			}
			this.CurrentDate = calculatedDate;
		}

		internal bool WeekContainsDisplayableDates(DateTime startingWeekDay)
		{
			return IsDisplayDateValid(this, startingWeekDay) || IsDisplayDateValid(this, startingWeekDay.AddDays(7));
		}

		internal bool MonthContainsDisplayableDates(DateTime monthDateTime)
		{
			DateTime invalidIfEndBefore = this.DisplayDateStart ?? MinDate;
			DateTime invalidIfStartAfter = this.DisplayDateEnd ?? MaxDate;

			return !(monthDateTime > invalidIfStartAfter || monthDateTime.AddMonths(1).AddDays(-1) < invalidIfEndBefore);
		}

		internal bool DecadeContainsDisplayableDates(DateTime decadeDateTime)
		{
			DateTime invalidIfEndBefore = this.DisplayDateStart ?? MinDate;
			DateTime invalidIfStartAfter = this.DisplayDateEnd ?? MaxDate;

			return !(decadeDateTime > invalidIfStartAfter || decadeDateTime.AddYears(10) < invalidIfEndBefore);
		}

		internal DateTime GetNewDateAfterMove(int direction)
		{
			switch (this.DisplayMode)
			{
				case DisplayMode.MonthView:
					return this.DisplayDate.AddMonths(this.ViewsCount * direction);
				case DisplayMode.YearView:
					return this.DisplayDate.AddYears(this.ViewsCount * direction);
				case DisplayMode.DecadeView:
					return this.DisplayDate.AddYears(this.ViewsCount * 10 * direction);
				case DisplayMode.CenturyView:
					return this.DisplayDate.AddYears(this.ViewsCount * 100 * direction);
			}
			return this.DisplayDate;
		}

		internal void MoveNext()
		{
			this.DisplayDate = this.GetNewDateAfterMove(1);
			this.UpdateCanMovePrevNext();
		}

		internal void MovePrev()
		{
			this.DisplayDate = this.GetNewDateAfterMove(-1);
			this.UpdateCanMovePrevNext();
		}

		internal DayOfWeek GetFirstDayOfWeekToUse()
		{
			return this.FirstDayOfWeek ?? this.GetCultureToUse().DateTimeFormat.FirstDayOfWeek;
		}

		internal CultureInfo GetCultureToUse()
		{
			return this.Culture ?? CultureInfo.CurrentCulture;
		}

		internal bool ProcessCalendarKey(System.Windows.Input.Key key)
		{

			int offsetX = (this.Orientation == Orientation.Horizontal) ? 1 : 7;
			int offsetY = (this.Orientation == Orientation.Horizontal) ? 7 : 1;

			switch (key)
			{
				case System.Windows.Input.Key.Up:
					return this.ProcessKey(-offsetY);

				case System.Windows.Input.Key.Down:
					return this.ProcessKey(offsetY);

				case System.Windows.Input.Key.Left:
					return this.ProcessKey(-offsetX);

				case System.Windows.Input.Key.Right:
					return this.ProcessKey(offsetX);

				////case System.Windows.Input.Key.PageDown:
				////    return ProcessPageDownKey();

				////case System.Windows.Input.Key.PageUp:
				////    return ProcessPageUpKey();

				case System.Windows.Input.Key.Home:
					return this.ProcessHomeKey();

				case System.Windows.Input.Key.End:
					return this.ProcessEndKey();

				case System.Windows.Input.Key.Space:
					return this.ProcessSpaceKey();

				case System.Windows.Input.Key.Enter:
					return this.ProcessEnterKey();

				case System.Windows.Input.Key.LeftCtrl:
				case System.Windows.Input.Key.RightCtrl:

					if (!this.controlKeyPressed)
					{
						this.controlKeyPressed = true;
						this.LastSelectedDate = this.CurrentDate;
					}
					break;

				////case System.Windows.Input.Key.Tab:
				////    return ProcessTabKey();
			}
			return false;
		}

		internal bool Select(DateTime selectedDate)
		{
			return this.Select(selectedDate, false);
		}

		internal bool Select(DateTime selectedDate, bool forceSelection)
		{
			////DateTime oldCurrent = this.CurrentDate;

			this.Flags.SelectedWithKeyboard = !forceSelection;
			if (this.IsReadOnly && DisplayMode == DisplayMode.MonthView)
			{
				return true;
			}
			if (!this.IsDateSelectable(selectedDate))
			{
				return true;
			}

			if (this.DisplayMode != DisplayMode.MonthView)
			{
				// NOTE: These two enumerations are ordered in the same way.
				if ((int)this.DateSelectionMode == (int)this.DisplayMode && !this.IsReadOnly)
				{
					if (this.SelectionMode != SelectionMode.Single)
					{
						this.SelectedDates.Clear();
					}
					this.SelectedDate = selectedDate;
				}
				this.HandleClickInViews(selectedDate, forceSelection);

				return true;
			}

			bool controlKeyDown = System.Windows.Input.Keyboard.Modifiers == (System.Windows.Input.Keyboard.Modifiers | System.Windows.Input.ModifierKeys.Control);
			bool shiftKeyDown = System.Windows.Input.Keyboard.Modifiers == (System.Windows.Input.Keyboard.Modifiers | System.Windows.Input.ModifierKeys.Shift);

			if (!this.SelectOnEnter && this.Flags.IsLoaded)
			{
				this.MovePrevNext(selectedDate);
			}

			bool handled = true;

			switch (this.SelectionMode)
			{
				case SelectionMode.Single:
					try
					{
						this.setThroughSelectedDate = true;
						this.AddToSelection(selectedDate, false, false);
					}
					finally
					{
						this.setThroughSelectedDate = false;
					}
					break;
				case SelectionMode.Multiple:
					this.CurrentDate = selectedDate;
					if (forceSelection)
					{
						this.AddToSelection(selectedDate, true, false);
					}
					break;
				case SelectionMode.Extended:
					if (!controlKeyDown || forceSelection)
					{
						if (this.SelectOnEnter)
						{
							this.AddToSelection(selectedDate, controlKeyDown, true);
						}
						else
						{
							this.AddToSelection(selectedDate, controlKeyDown, shiftKeyDown);
						}
					}
					else if (controlKeyDown)
					{
						if (IsDateSelectable(selectedDate))
						{
							this.CurrentDate = selectedDate;
						}
					}
					break;
				default:
					handled = false;
					break;
			}

			////if (handled)
			////{
			////    OnFocusDateChanged(selectedDate);
			////}

			return handled;
		}

		internal void FocusCurrentDate()
		{
			this.OnFocusDateChanged(DateTime.Now, this.CurrentDate);
		}

		internal void AddToSelection(DateTime selectedDate, bool controlKeyDown, bool shiftKeyDown)
		{
			bool handled = false;
			if (shiftKeyDown)
			{
				this.selection.Begin();

				DateTime previousSelectedDate = this.LastSelectedDate;
				Debug.WriteLine("PreviousSelectedDate: " + previousSelectedDate);
				int num = 1;
				if (selectedDate < previousSelectedDate)
				{
					num = -1;
				}
				else if (selectedDate == previousSelectedDate)
				{
					num = 0;
				}

				List<DateTime> dateToSelect = new List<DateTime>();
				if (num == 0 && !controlKeyDown)
				{
					foreach (DateTime date in this.SelectedDates)
					{
						if (date == selectedDate)
						{
							continue;
						}
						this.SelectedDates.Remove(date);
					}
				}
				else
				{
					while (previousSelectedDate.CompareTo(selectedDate) != num)
					{
						dateToSelect.Add(previousSelectedDate);
						previousSelectedDate = previousSelectedDate.AddDays(num);
					}

					if (controlKeyDown)
					{
						foreach (DateTime newlySelected in dateToSelect)
						{
							this.selection.Add(newlySelected);
						}
					}
					else
					{
						int oldSelectionCount = this.selection.Count;
						int x = 0;
						while (x < oldSelectionCount)
						{
							DateTime date = this.selection[x];
							if (!dateToSelect.Contains(date))
							{
								this.selection.Remove(date);
							}

							x++;
						}
						foreach (DateTime newlySelected in dateToSelect)
						{
							this.selection.Add(newlySelected);
						}
					}
				}

				this.selection.End();
			}
			else if (controlKeyDown)
			{
				this.selection.Begin();

				if (this.selection.Contains(selectedDate))
				{
					this.selection.Remove(selectedDate);
				}
				else
				{
					this.selection.Add(selectedDate);
				}
				if (this.IsDateSelectable(selectedDate))
				{
					this.LastSelectedDate = selectedDate;
				}
				this.selection.End();
			}
			else
			{
				if (this.selection.Contains(selectedDate))
				{
					this.selection.Clear();
				}
				////else
				////{
				if (this.IsDateSelectable(selectedDate))
				{
					this.CurrentDate = selectedDate;
					handled = true;
				}
				this.selection.AddJustThis(selectedDate);
				////}

				if (this.selection.Contains(selectedDate))
				{
					this.LastSelectedDate = selectedDate;
				}
				else
				{
					this.lastSelectedDate = null;
				}
			}

			if (!handled)
			{
				if (this.IsDateSelectable(selectedDate))
				{
					this.CurrentDate = selectedDate;
				}
			}
		}

		internal bool IsDateSelectable(DateTime? date)
		{
			if (date == null)
			{
				return true;
			}
			return this.IsDateSelectable((DateTime)date);
		}

		internal bool IsDateSelectable(DateTime date)
		{
			if (date.Hour == 1 || date.Hour == 2)
			{
				return false;
			}

			switch (this.DisplayMode)
			{
				case DisplayMode.MonthView:
					return this.DateSelectableInMonth(date);
				case DisplayMode.YearView:
					return this.DateSelectableInYear(date);
				case DisplayMode.DecadeView:
					return this.DateSelectableInDecade(date);
				case DisplayMode.CenturyView:
					return this.DateSelectableInCentury(date);
				default:
					return false;
			}

			////TODO: Take into account other stuff as well!
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
		/// OnSelectionChanged is called whenever the selected dates of the calnedar change.
		/// </summary>
		/// <param name="e">Parameter that describes how the selection has changed.</param>
		protected virtual void OnSelectionChanged(SelectionChangedEventArgs e)
		{
			e.RoutedEvent = SelectionChangedEvent;
			this.RaiseEvent(e);
		}

		/// <summary>
		/// The OnDisplayDateChanged is called when the display date of the calendar chnages.
		/// </summary>
		/// <param name="e">The parameter contains the new and the old display dates.</param>
		protected virtual void OnDisplayDateChanged(CalendarDateChangedEventArgs e)
		{
			e.RoutedEvent = DisplayDateChangedEvent;
			this.RaiseEvent(e);
		}

		/// <summary>
		/// OnDisplayModeChanged is called when the display mode of the calendar changes.
		/// </summary>
		/// <param name="e">The oarameter contains the old and the new display modes.</param>
		protected virtual void OnDisplayModeChanged(CalendarModeChangedEventArgs e)
		{
			e.RoutedEvent = DisplayModeChangedEvent;
			this.RaiseEvent(e);
		}

		/// <summary>
		/// Called when SelectionMode changed.
		/// </summary>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		protected virtual void OnSelectionModeChanged(SelectionMode oldValue, SelectionMode newValue)
		{
			if (this.SelectedDate.HasValue)
			{
				switch (newValue)
				{
					case SelectionMode.Single:
						this.selection.Begin();
						foreach (DateTime date in this.selection)
						{
							if (date != this.SelectedDate)
							{
								this.selection.Remove(date);
							}
						}

						////AddToSelection((DateTime)this.SelectedDate, false /*control not pressed*/, false /*shift not pressed*/);
						this.selection.End();
						break;
				}
			}
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.KeyDown"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled)
			{
				e.Handled = this.ProcessCalendarKey(e.Key);
			}
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.KeyUp"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnKeyUp(System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (!e.Handled)
			{
				switch (e.Key)
				{

					case System.Windows.Input.Key.LeftCtrl:
					case System.Windows.Input.Key.RightCtrl:

						this.controlKeyPressed = false;
						break;
				}
			}
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.MouseLeave"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnMouseLeave(System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.SelectOnEnter = false;
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.MouseLeftButtonUp"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.SelectOnEnter = false;
		}

		/// <summary>
		/// Called before the System.Windows.UIElement.GotFocus event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			base.OnGotFocus(e);

			if (!(e.OriginalSource is CalendarButton))
			{
				this.FocusSelectedDate();
			}

		}



		private static void OnYearViewHeaderFormatChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			////TODO: Check isValid!
		}

		/// <summary> 
		///     SelectableDateStartProperty property changed handler.
		/// </summary>
		/// <param name="sender">Calendar that changed its SelectableDateStart.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param> 
		private static void OnSelectableDateStartChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			Debug.Assert(calendar != null, "The sender should be Calendar PropertyChanged");

			if (IsSelectableDateStartValid(calendar, e.NewValue as DateTime?))
			{
				UpdateSelectionAfterSelectableRangeChange();
				if (calendar.Flags.IsLoaded)
				{
					calendar.Flags.ForceNewCalendarButtons = true;
					calendar.UpdateCalendarViews();
				}
			}
			else
			{
				throw new ArgumentOutOfRangeException("sender", "Invalid SelectableDateStart value.");
			}
		}

		private static void OnSelectionModeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			Debug.Assert(calendar != null, "The sender should be Calendar PropertyChanged");

			////TODO: Check for validity!

			SelectionMode oldValue = (SelectionMode)e.OldValue;
			SelectionMode newValue = (SelectionMode)e.NewValue;
			try
			{
				calendar.setThroughSelectedDate = true;
				calendar.OnSelectionModeChanged(oldValue, newValue);
			}
			finally
			{
				calendar.setThroughSelectedDate = false;
			}
		}

		/// <summary>
		///     SelectableDateEndProperty property changed handler. 
		/// </summary>
		/// <param name="sender">Calendar that changed its SelectableDateEnd.</param>
		/// <param name="e">DependencyPropertyChangedEventArgs.</param> 
		private static void OnSelectableDateEndChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			Debug.Assert(calendar != null, "The sender should be Calendar PropertyChanged");

			if (IsSelectableDateEndValid(calendar, e.NewValue as DateTime?))
			{
				UpdateSelectionAfterSelectableRangeChange();
				if (calendar.Flags.IsLoaded)
				{
					calendar.Flags.ForceNewCalendarButtons = true;
					calendar.UpdateCalendarViews();
				}
			}
			else
			{
				throw new ArgumentOutOfRangeException("sender", "Invalid SelectableDateStart value.");
			}
		}

		private static void OnSelectedDateChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			Debug.Assert(calendar != null, "The sender should be Calendar PropertyChanged");
			if (e.NewValue != null)
			{
				if (!calendar.suppressChange)
				{
					try
					{
						calendar.setThroughSelectedDate = true;
						calendar.AddToSelection((DateTime)e.NewValue, false, false);
					}
					finally
					{
						calendar.setThroughSelectedDate = false;
					}
				}
			}
			else
			{
				try
				{
					calendar.setThroughSelectedDate = true;
					calendar.selection.Clear();
				}
				finally
				{
					calendar.setThroughSelectedDate = false;
				}
			}
		}

		private static object CoerceRows(DependencyObject sender, object value)
		{
			int rowsValue = (int)value;

			rowsValue = Math.Min(MaxColumns, rowsValue);
			rowsValue = Math.Max(1, rowsValue);

			return rowsValue;
		}

		private static void OnRowsChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			if (calendar.Flags.IsLoaded)
			{
				calendar.UpdateRowsAndColumns();
				calendar.UpdateCalendarViews();
			}
		}

		private static void OnMonthViewHeaderFormatChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			////TODO: Check isValid!
		}

		/// <summary>
		///     IsTodayHighlightedProperty property changed handler.
		/// </summary> 
		/// <param name="d">Calendar that changed its IsTodayHighlighted.</param> 
		/// <param name="e">DependencyPropertyChangedEventArgs.</param>
		private static void OnIsTodayHighlightedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = d as RadCalendar;
			Debug.Assert(calendar != null, "The sender should be Calendar PropertyChanged");

			if (calendar.Flags.IsLoaded)
			{
				calendar.UpdateCalendarViews();
			}
		}

		private static void OnHeaderVisibilityChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			////RadCalendar calendar = sender as RadCalendar;

			////TODO: What should be done here?

			////calendar.UpdateMonths();
		}

		private static void OnFirstDayOfWeekChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			Debug.Assert(calendar != null, "The sender should be Calendar PropertyChanged");

			if (IsValidFirstDayOfWeek(e.NewValue))
			{
				if (calendar.Flags.IsLoaded)
				{
					calendar.UpdateCalendarViews();
				}
			}
			else
			{
				throw new ArgumentOutOfRangeException("sender", "Invalid FirstDayOfWeek value.");
			}
		}

		private static bool IsValidFirstDayOfWeek(object value)
		{
			DayOfWeek? day = (DayOfWeek?)value;

			return Enum.IsDefined(typeof(DayOfWeek), day) || day == null;
		}

		private static void OnDisplayModeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;

			if (calendar.Flags.IsLoaded)
			{
				if (calendar.ValidateDateSelectionMode((DateSelectionMode)(DisplayMode)e.NewValue))
				{
					calendar.UpdateCalendarViews();
					calendar.UpdateTransitionPanel((DisplayMode)e.OldValue, (DisplayMode)e.NewValue);
					calendar.UpdateCanMovePrevNext();
				}

				////calendar.HandleClickInViews(calendar.CurrentDate, false);				
			}

			calendar.OnDisplayModeChanged(new CalendarModeChangedEventArgs(DisplayModeChangedEvent, calendar, (DisplayMode)e.OldValue, (DisplayMode)e.NewValue));

			DisplayMode mode = (DisplayMode)e.NewValue;
			if (mode == DisplayMode.MonthView)
			{
				calendar.multiplier = 1.0;
			}
			else
			{
				calendar.multiplier = 4.0 / 7.0;
			}

			////TODO: Validate!
		}

		private static void OnDateSelectionModeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			((RadCalendar)sender).DisplayMode = (DisplayMode)(DateSelectionMode)e.NewValue;
		}

		private static void OnDisplayDateStartChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			DateTime? newDisplayDate = e.NewValue as DateTime?;

			if (IsDisplayDateStartValid(calendar, newDisplayDate))
			{
				if (calendar.Flags.IsLoaded)
				{
					calendar.UpdateCalendarViews();
				}
			}
			else
			{
				throw new ArgumentOutOfRangeException("sender", "Invalid DisplayDateStart value.");
			}
		}

		private static void OnDisplayDateEndChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			DateTime? newDisplayDateEnd = e.NewValue as DateTime?;

			if (IsDisplayDateEndValid(calendar, newDisplayDateEnd))
			{
				if (calendar.Flags.IsLoaded)
				{
					calendar.UpdateCalendarViews();
				}
			}
			else
			{
				throw new ArgumentOutOfRangeException("sender", "Invalid DisplayDateEnd value.");
			}
		}

		private static void OnDisplayDateChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			if (calendar.Flags.IsLoaded && !calendar.suspendPopulation)
			{
				calendar.UpdateCalendarViews();
			}
			calendar.CurrentDate = calendar.DisplayDate;
			calendar.OnDisplayDateChanged(new CalendarDateChangedEventArgs(DisplayDateChangedEvent, calendar, e.OldValue as DateTime?, e.NewValue as DateTime?));
		}

		private static void OnDecadeViewHeaderFormatChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			////TODO: Check isValid!
		}

		private static object CoerceColumns(DependencyObject sender, object value)
		{
			int columnsValue = (int)value;

			columnsValue = Math.Min(MaxColumns, columnsValue);
			columnsValue = Math.Max(1, columnsValue);

			return columnsValue;
		}

		private static void OnColumnsChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;

			if (calendar.Flags.IsLoaded)
			{
				calendar.UpdateRowsAndColumns();
				calendar.UpdateCalendarViews();
			}
		}

		private static void OnCultureChange(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			if (calendar.Flags.IsLoaded)
			{
				calendar.UpdateCalendarViews();
			}
		}

		private static void OnCenturyViewHeaderFormatChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			////TODO: Check isValid!
		}

		private static void OnCalendarWeekRuleChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			RadCalendar calendar = sender as RadCalendar;
			if (calendar.Flags.IsLoaded)
			{
				calendar.UpdateCalendarViews();
			}
		}

		private static void OnAreWeekNamesNumbersVisibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			////#if WPF
			RadCalendar calendar = d as RadCalendar;

			if (calendar != null)
			{
				ChangeView(calendar.monthViews, calendar.Orientation, calendar.AreWeekNamesVisible, calendar.AreWeekNumbersVisible);
			}
			////#endif
		}

		private static void ChangeView(Panel panel, Orientation orientation, bool areWeekNamesVisible, bool areWeekNumbersVisible)
		{
			if (panel == null)
			{
				return;
			}

			foreach (UIElement element in panel.Children)
			{
				CalendarView view = element as CalendarView;
				if (view != null)
				{
					if (orientation == Orientation.Horizontal)
					{
						view.HideRow = !areWeekNamesVisible;
						view.HideColumn = !areWeekNumbersVisible;
					}
					else
					{
						view.HideRow = !areWeekNumbersVisible;
						view.HideColumn = !areWeekNamesVisible;
					}
				}
			}
		}

		private static void UpdateSelectionAfterSelectableRangeChange()
		{
			////TODO: This method is called even when the control is not loaded, change behaviour if needed!
			////throw new NotImplementedException();
		}

		private static DateTime GetFirstDayofDecade(DateTime selectedDate)
		{
			return new DateTime((selectedDate.Year / 10) * 10, 1, 1);
		}

		private static DateTime GetFirstDayofMonth(DateTime selectedDate)
		{
			return new DateTime(selectedDate.Year, selectedDate.Month, 1).Date;
		}

		private static DateTime GetFirstDayofCentury(DateTime selectedDate)
		{
			return new DateTime(((selectedDate.Year / 100) * 100), 1, 1);
		}

		private static DateTime GetFirstDayofYear(DateTime selectedDate)
		{
			return new DateTime(selectedDate.Year, 1, 1);
		}

		private bool ValidateDateSelectionMode(DateSelectionMode newValue)
		{
			return (int)this.DateSelectionMode <= (int)newValue;
		}

		private void ResetTheme(Panel viewPanel)
		{
			if (viewPanel != null)
			{
				foreach (CalendarView view in viewPanel.Children)
				{
					StyleManager.SetThemeFromParent(view, this);
				}
			}
		}





		private void OnSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (this.SelectionMode == SelectionMode.Single && !this.setThroughSelectedDate)
			{
				throw new InvalidOperationException("Can only change SelectedDates collection in multiple selection modes. Use SelectedDate in single select mode.");
			}

			if (this.suppressChange)
			{
				return;
			}

			if (this.SelectedDates.Count > 0)
			{
				if (this.SelectedDate.HasValue)
				{
					if (!this.SelectedDates.Contains(this.SelectedDate.Value))
					{
						try
						{
							this.suppressChange = true;
							this.SelectedDate = this.SelectedDates[0];
						}
						finally
						{
							this.suppressChange = false;
						}
					}
				}
				else
				{
					try
					{
						this.suppressChange = true;
						this.SelectedDate = this.SelectedDates[0];
					}
					finally
					{
						this.suppressChange = false;
					}
				}
			}
			else
			{
				////try
				////{
				////    this.suppressChange = true;
				////    this.SelectedDate = null;
				////}
				////finally
				////{
				////    this.suppressChange = false;
				////}
			}

			this.OnSelectionChanged(new SelectionChangedEventArgs(SelectionChangedEvent, e.RemovedItems, e.AddedItems));
		}

		private void PopulateDays()
		{
			if (this.DisplayMode != DisplayMode.MonthView)
			{
				return;
			}

			CultureInfo cultureToUse = this.GetCultureToUse();
			DayOfWeek firstDayOfWeekToUse = this.GetFirstDayOfWeekToUse();
			CalendarWeekRule calendarWeekRuleToUse = this.GetCalendarWeekRule();
			string headerFormatToUse = this.GetMonthViewHeaderFormat();

			DateTime monthStartDate = new DateTime(this.DisplayDate.Year, this.DisplayDate.Month, 1);

			for (int j = 0; j < this.ViewsCount; j++)
			{
				List<CalendarButtonContent> itemsSource = new List<CalendarButtonContent>(60);
				DateTime firstDayInMonth = monthStartDate.AddMonths(j);
				DateTime lastDayInMonth = firstDayInMonth.AddMonths(1).AddDays(-1);
				if (j == 0)
				{
					this.VisibleDateStart = firstDayInMonth;
				}
				if (j == this.ViewsCount - 1)
				{
					this.VisibleDateEnd = this.GetLastDayofMonth(firstDayInMonth);
				}

				int daysToSubstract = (int)firstDayInMonth.DayOfWeek - (int)firstDayOfWeekToUse;
				if (daysToSubstract < 0)
				{
					daysToSubstract += 7;
				}
				DateTime firstDayToDisplay = firstDayInMonth.AddDays(-daysToSubstract);

				////Add week names:
				itemsSource.AddRange(Enumerable.Range(0, 7).Select(o =>
					new CalendarButtonContent()
					{
						Text = cultureToUse.DateTimeFormat.AbbreviatedDayNames.GetValue(((int)firstDayToDisplay.DayOfWeek + o) % 7) as string,
						Date = firstDayToDisplay.AddDays(7 + o).AddHours(1),
						ButtonType = CalendarButtonType.WeekName,
						IsFromCurrentView = true,
					}));

				////Which month is it?
				int monthNum = firstDayInMonth.Month;

				for (int i = 0; i < 6; i++)
				{
					////Get first day of week:
					DateTime startingWeekDay = firstDayToDisplay.AddDays(i * 7);

					if (startingWeekDay.Month != firstDayInMonth.Month && i > 0 && j < this.ViewsCount - 1)
					{
						break;
					}

					////Add week num:
					itemsSource.Add(
						new CalendarButtonContent()
						{
							Text = cultureToUse.Calendar.GetWeekOfYear(startingWeekDay, calendarWeekRuleToUse, firstDayOfWeekToUse).ToString(CultureInfo.InvariantCulture),
							Date = startingWeekDay.AddHours(2),
							ButtonType = CalendarButtonType.WeekNumber,
							IsFromCurrentView = true,
							IsInAnotherView = !this.WeekContainsDisplayableDates(startingWeekDay),

							////IsSelected = false
						});

					////Add days:
					itemsSource.AddRange(Enumerable.Range(0, 7).Select(o =>
					{
						DateTime dateToAdd = startingWeekDay.AddDays(o);
						CalendarButtonType type = CalendarButtonType.Date;
						if (IsTodayHighlighted && dateToAdd == DateTime.Today.Date)
						{
							type = CalendarButtonType.TodayDate;
						}
						return new CalendarButtonContent()
						{
							Text = dateToAdd.Day.ToString(CultureInfo.InvariantCulture),
							Date = dateToAdd,
							ButtonType = type,
							IsFromCurrentView = dateToAdd.Month == monthNum,
							IsInAnotherView = !IsDisplayDateValid(this, dateToAdd) || ((j != 0 && dateToAdd < firstDayInMonth) || (j != ViewsCount - 1 && dateToAdd > lastDayInMonth)),
							IsSelected = selection.Contains(dateToAdd),
							IsEnabled = IsDateSelectable(dateToAdd)
						};
					}));
				}
				CalendarView calItemsControl = this.monthViews.Children[j] as CalendarView;
				calItemsControl.ItemsSource = itemsSource;
				calItemsControl.Header = firstDayInMonth.ToString(headerFormatToUse, cultureToUse.DateTimeFormat);
				if (j == 0 && this.Flags.HasHeaderButton)
				{
					this.headerButton.Content = calItemsControl.Header;
				}
			}
		}

		private void PopulateMonths()
		{
			if (DisplayMode != DisplayMode.YearView)
			{
				return;
			}

			CultureInfo cultureToUse = this.GetCultureToUse();
			string headerFormatToUse = this.GetYearViewHeaderFormat();

			DateTime startYear = GetFirstDayofYear(this.DisplayDate);

			for (int j = 0; j < this.ViewsCount; j++)
			{
				DateTime yearDisplayDate = startYear.AddYears(j);
				List<CalendarButtonContent> itemsSource = new List<CalendarButtonContent>(12);

				if (j == 0)
				{
					this.VisibleDateStart = startYear;
				}
				if (j == this.ViewsCount - 1)
				{
					this.VisibleDateEnd = yearDisplayDate.AddYears(1).AddDays(-1);
				}

				itemsSource.AddRange(Enumerable.Range(0, 12).Select(o =>
				{
					DateTime monthDateTime = yearDisplayDate.AddMonths(o);

					return new CalendarButtonContent()
					{
						Text = cultureToUse.DateTimeFormat.GetAbbreviatedMonthName(o + 1),
						Date = monthDateTime,
						ButtonType = CalendarButtonType.Month,
						IsFromCurrentView = true,
						IsInAnotherView = !MonthContainsDisplayableDates(monthDateTime)

						////IsSelected = false
					};
				}));
				CalendarView calItemsControl = this.yearViews.Children[j] as CalendarView;
				calItemsControl.ItemsSource = itemsSource;
				calItemsControl.Header = yearDisplayDate.ToString(headerFormatToUse, cultureToUse.DateTimeFormat);
				if (j == 0 && this.Flags.HasHeaderButton)
				{
					this.headerButton.Content = calItemsControl.Header;
				}
			}
		}

		private void PopulateYears()
		{
			if (DisplayMode != DisplayMode.DecadeView)
			{
				return;
			}

			CultureInfo cultureToUse = this.GetCultureToUse();
			string headerFormatToUse = this.GetDecadeViewHeaderFormat();

			DateTime startYear = GetFirstDayofDecade(this.DisplayDate);

			for (int j = 0; j < this.ViewsCount; j++)
			{
				DateTime decadeDisplayDate = startYear.AddYears(j * 10);
				List<CalendarButtonContent> itemsSource = new List<CalendarButtonContent>(12);

				if (j == 0)
				{
					this.VisibleDateStart = startYear;
				}
				if (j == this.ViewsCount - 1)
				{
					this.VisibleDateEnd = decadeDisplayDate.AddYears(10).AddDays(-1);
				}

				itemsSource.AddRange(Enumerable.Range(-1, 12).Select(o =>
				{
					DateTime yearDateTime = decadeDisplayDate.AddYears(o);
					return new CalendarButtonContent()
					{
						Text = yearDateTime.Year.ToString(cultureToUse),
						Date = yearDateTime,
						ButtonType = CalendarButtonType.Year,
						IsFromCurrentView = o > -1 && o < 10,
						IsInAnotherView = !YearContainsDisplayableDates(yearDateTime) || ((j != ViewsCount - 1 && o == 10) || (j != 0 && o == -1)),
						IsSelected = false
					};
				}));

				CalendarView calItemsControl = this.decadeViews.Children[j] as CalendarView;
				calItemsControl.ItemsSource = itemsSource;
				calItemsControl.Header = String.Format(cultureToUse, headerFormatToUse, decadeDisplayDate.Year);
				if (j == 0 && this.Flags.HasHeaderButton)
				{
					this.headerButton.Content = calItemsControl.Header;
				}
			}
		}

		private bool YearContainsDisplayableDates(DateTime yearDateTime)
		{
			DateTime invalidIfEndBefore = this.DisplayDateStart ?? MinDate;
			DateTime invalidIfStartAfter = this.DisplayDateEnd ?? MaxDate;

			return !(yearDateTime > invalidIfStartAfter || yearDateTime.AddYears(1) < invalidIfEndBefore);
		}

		/// <summary>
		/// Throughout the method it is assumed that the current display date does not conain ivalid (out-of-range) dates.
		/// </summary>
		private void PopulateDecades()
		{
			if (this.DisplayMode != DisplayMode.CenturyView)
			{
				return;
			}

			CultureInfo cultureToUse = this.GetCultureToUse();
			string headerFormatToUse = this.GetCenturyViewHeaderFormat();

			DateTime startYear = GetFirstDayofCentury(this.DisplayDate);

			for (int j = 0; j < this.ViewsCount; j++)
			{
				DateTime centuryDisplayDate = startYear.AddYears(j * 100);
				List<CalendarButtonContent> itemsSource = new List<CalendarButtonContent>(12);

				if (j == 0)
				{
					this.VisibleDateStart = startYear;
				}
				if (j == this.ViewsCount - 1)
				{
					this.VisibleDateEnd = centuryDisplayDate.AddYears(100).AddDays(-1);
				}

				itemsSource.AddRange(Enumerable.Range(-1, 12).Select(o =>
				{
					DateTime decadeDateTime = centuryDisplayDate.AddYears(o * 10);
					return new CalendarButtonContent()
					{
						Text = String.Format(cultureToUse, "{0}-\n{1}", decadeDateTime.Year, decadeDateTime.Year + 10),
						Date = decadeDateTime,
						ButtonType = CalendarButtonType.Decade,

						////TODO: add a real check ?!
						IsFromCurrentView = o > -1 && o < 10,
						IsInAnotherView = !DecadeContainsDisplayableDates(decadeDateTime) || ((j != ViewsCount - 1 && o == 10) || (j != 0 && o == -1)),
						IsSelected = false
					};
				}));
				CalendarView calItemsControl = this.centuryViews.Children[j] as CalendarView;
				calItemsControl.ItemsSource = itemsSource;
				calItemsControl.Header = String.Format(cultureToUse, headerFormatToUse, centuryDisplayDate.Year);
				if (j == 0 && this.Flags.HasHeaderButton)
				{
					this.headerButton.Content = calItemsControl.Header;
				}
			}
		}

		private void UpdateRowsAndColumns()
		{
			int needed = this.ViewsCount;
			if (needed > this.monthViews.Children.Count)
			{
				int numToAdd = needed - this.monthViews.Children.Count;
				for (int i = 0; i < numToAdd; i++)
				{
					this.monthViews.Children.Add(this.CreateView("DayButtonStyle", "DayButtonStyleSelector", "DayTemplate", "DayTemplateSelector", "MonthViewPanel", DisplayMode.MonthView, "MonthViewStyle"));
					this.yearViews.Children.Add(this.CreateView("MonthButtonStyle", "MonthButtonStyleSelector", "MonthTemplate", "DayTemplateSelector", "YearViewPanel", DisplayMode.YearView, "YearViewStyle"));
					this.decadeViews.Children.Add(this.CreateView("YearButtonStyle", "YearButtonStyleSelector", "YearTemplate", "YearTemplateSelector", "DecadeViewPanel", DisplayMode.DecadeView, "DecadeViewStyle"));
					this.centuryViews.Children.Add(this.CreateView("DecadeButtonStyle", "DecadeButtonStyleSelector", "DecadeTemplate", "DecadeTemplateSelector", "CenturyViewPanel", DisplayMode.CenturyView, "CenturyViewStyle"));
				}
			}
			else if (needed < this.monthViews.Children.Count)
			{
				while (needed != this.monthViews.Children.Count)
				{
					CalendarView cv = this.monthViews.Children[needed] as CalendarView;
					if (cv != null)
					{
						cv.ClearEvents();
					}
					this.monthViews.Children.RemoveAt(needed);
					this.yearViews.Children.RemoveAt(needed);
					this.decadeViews.Children.RemoveAt(needed);
					this.centuryViews.Children.RemoveAt(needed);
				}
			}
		}

		private CalendarView CreateView(string itemContainerStylePath, string itemContainerStyleSelectorPath, string itemTempaltePath, string itemTemplateSelectorPath, string itemsPanelPath, DisplayMode mode, string viewStylePath)
		{
			CalendarView view = new CalendarView(this);
			view.DisplayMode = mode;

			Binding binding = new Binding(itemContainerStylePath);
			binding.Source = this;
			view.SetBinding(ItemsControl.ItemContainerStyleProperty, binding);

			binding = new Binding(itemContainerStyleSelectorPath);
			binding.Source = this;
			view.SetBinding(ItemsControl.ItemContainerStyleSelectorProperty, binding);

			binding = new Binding(itemTempaltePath);
			binding.Source = this;
			view.SetBinding(ItemsControl.ItemTemplateProperty, binding);

			binding = new Binding(itemTemplateSelectorPath);
			binding.Source = this;
			view.SetBinding(ItemsControl.ItemTemplateSelectorProperty, binding);

			binding = new Binding(itemsPanelPath);
			binding.Source = this;
			view.SetBinding(ItemsControl.ItemsPanelProperty, binding);

			binding = new Binding("ViewsHeaderVisibility");
			binding.Source = this;
			view.SetBinding(CalendarView.HeaderVisibilityProperty, binding);

			binding = new Binding(viewStylePath);
			binding.Source = this;
			view.SetBinding(FrameworkElement.StyleProperty, binding);

			binding = new Binding("Orientation");
			binding.Source = this;
			view.SetBinding(CalendarView.OrientationProperty, binding);

			//// StyleManager.SetThemeFromParent(view, this);

			bool horizontal = this.Orientation == Orientation.Horizontal;
			if (horizontal)
			{
				view.HideColumn = !this.AreWeekNumbersVisible;
				view.HideRow = !this.AreWeekNamesVisible;
			}
			else
			{
				view.HideColumn = !this.AreWeekNamesVisible;
				view.HideRow = !this.AreWeekNumbersVisible;
			}

			switch (mode)
			{
				case DisplayMode.YearView:
				case DisplayMode.DecadeView:
				case DisplayMode.CenturyView:
					if (horizontal)
					{
						view.Rows = 3;
						view.Columns = 4;
					}
					else
					{
						view.Rows = 4;
						view.Columns = 3;
					}
					break;
				default:
					break;
			}

			return view;
		}

		private void UpdateCanMovePrevNext()
		{
			if (this.Flags.HasHeaderButton)
			{
				switch (DisplayMode)
				{
					case DisplayMode.CenturyView:
						this.headerButton.IsEnabled = false;
						break;
					case DisplayMode.DecadeView:
						this.headerButton.IsEnabled = this.Flags.HasCenturyViewsPanel;
						break;
					case DisplayMode.YearView:
						this.headerButton.IsEnabled = this.Flags.HasDecadeViewsPanel;
						break;
					case DisplayMode.MonthView:
						this.headerButton.IsEnabled = this.Flags.HasYearViewsPanel;
						break;
				}
			}
			this.moveLeftButton.IsEnabled = IsDisplayDateValid(this, this.VisibleDateStart.AddDays(-1));
			this.moveRightButton.IsEnabled = IsDisplayDateValid(this, this.VisibleDateEnd.AddDays(1));
		}

		private CalendarWeekRule GetCalendarWeekRule()
		{
			return this.CalendarWeekRule ?? this.GetCultureToUse().DateTimeFormat.CalendarWeekRule;
		}

		private void UpdateCalendarViews()
		{
			this.PopulateDays();
			this.PopulateMonths();
			this.PopulateYears();
			this.PopulateDecades();
			this.Flags.ForceNewCalendarButtons = false;
		}

		private void UpdateTransitionPanel(DisplayMode oldMode, DisplayMode newMode)
		{
			if (this.Flags.IsFirstAnimation)
			{
				this.Flags.IsFirstAnimation = false;
				int visibleChildIndex = (int)newMode;
				for (int i = 0; i < this.transitionPanel.Children.Count; i++)
				{
					this.transitionPanel.Children[i].Visibility = (visibleChildIndex == i) ? Visibility.Visible : Visibility.Collapsed;
				}
			}
			else
			{
				if ((int)oldMode > (int)newMode)
				{
					this.transitionPanel.TransitionDownTo(this.transitionPanel.Children[(int)DisplayMode] as FrameworkElement);
				}
				else
				{
					this.transitionPanel.TransitionUpTo(this.transitionPanel.Children[(int)DisplayMode] as FrameworkElement);
				}
			}
		}


		private string GetMonthViewHeaderFormat()
		{
			return this.MonthViewHeaderFormat ?? "MMMM' - 'yyyy";
		}

		private string GetYearViewHeaderFormat()
		{
			return this.YearViewHeaderFormat ?? "yyyy";
		}

		private string GetDecadeViewHeaderFormat()
		{
			return this.DecadeViewHeaderFormat ?? "{0}";
		}

		private string GetCenturyViewHeaderFormat()
		{
			return this.CenturyViewHeaderFormat ?? "{0}";
		}

		private bool ProcessEndKey()
		{
			DateTime? newDate = null;
			switch (this.DisplayMode)
			{
				case DisplayMode.MonthView:
					newDate = this.GetLastDayofMonth(this.CurrentDate);
					break;
				case DisplayMode.YearView:
					newDate = GetFirstDayofYear(this.CurrentDate).AddYears(1).AddMonths(-1);
					break;
				case DisplayMode.DecadeView:
					newDate = GetFirstDayofDecade(this.CurrentDate).AddYears(9);
					break;
				case DisplayMode.CenturyView:
					newDate = GetFirstDayofCentury(this.CurrentDate).AddYears(90);
					break;
				default:
					break;
			}
			if (newDate.HasValue)
			{
				if (newDate.Value <= this.VisibleDateEnd)
				{
					return this.Select(newDate.Value);
				}
				else
				{
					return this.Select(GetFirstDayofDecade(this.VisibleDateEnd));
				}
			}

			return false;
		}

		private bool ProcessHomeKey()
		{
			DateTime? newDate = null;
			switch (this.DisplayMode)
			{
				case DisplayMode.MonthView:
					newDate = GetFirstDayofMonth(this.CurrentDate);
					break;
				case DisplayMode.YearView:
					newDate = GetFirstDayofYear(this.CurrentDate);
					break;
				case DisplayMode.DecadeView:
					newDate = GetFirstDayofDecade(this.CurrentDate);
					break;
				case DisplayMode.CenturyView:
					newDate = GetFirstDayofCentury(this.CurrentDate);
					break;
				default:
					break;
			}
			if (newDate.HasValue)
			{
				return this.Select(newDate.Value);
			}

			return false;
		}

		private bool ProcessSpaceKey()
		{
			if (this.DisplayMode == DisplayMode.MonthView)
			{
				DateTime newDate = this.CurrentDate;
				return this.Select(newDate, true);
			}

			return false;
		}

		private bool ProcessEnterKey()
		{
			if (this.DisplayMode != DisplayMode.MonthView)
			{
				this.HandleClickInViews(this.CurrentDate, true);
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool ProcessKey(int value)
		{
			DateTime? result = null;
			value = (int)Math.Round(value * this.multiplier);

			switch (this.DisplayMode)
			{
				case DisplayMode.MonthView:
					result = this.AddDays(value);
					break;
				case DisplayMode.YearView:
					result = this.AddMonths(value);
					result = new DateTime(result.Value.Year, result.Value.Month, 1);
					break;
				case DisplayMode.DecadeView:
					result = this.AddMonths(value * 12);
					result = new DateTime(result.Value.Year, 1, 1);
					break;
				case DisplayMode.CenturyView:
					result = this.AddMonths(value * 12 * 10);
					result = new DateTime(result.Value.Year, 1, 1);
					break;
				default:
					break;
			}
			if (result.HasValue)
			{
				return this.Select(result.Value);
			}

			return false;
		}

		private DateTime AddDays(int days)
		{
			DateTime result = this.CurrentDate;
			return result.AddDays(days);
		}

		private DateTime GetLastDayofMonth(DateTime? dateOfMonth)
		{
			DateTime date = GetFirstDayofMonth(this.CurrentDate.Date);
			if (dateOfMonth.HasValue)
			{
				date = GetFirstDayofMonth(dateOfMonth.Value);
			}
			DateTime selectedDate;

			System.Globalization.Calendar cal = this.GetCultureToUse().Calendar;

			// int index = cal.GetDaysInMonth(date.Year, date.Month);
			selectedDate = cal.AddMonths(date, 1);
			selectedDate = cal.AddDays(selectedDate, -1);
			return selectedDate;
		}

		private DateTime AddMonths(int months)
		{
			DateTime result = this.CurrentDate;
			return result.AddMonths(months);
		}

		private void HandleClickInViews(DateTime selectedDate, bool forceSelection)
		{
			DateTime result = selectedDate;
			if (!this.IsDateSelectable(selectedDate))
			{
				return;
			}

			if (!forceSelection)
			{
				this.MovePrevNext(selectedDate);
			}

			if (forceSelection)
			{
				if (this.DisplayMode == DisplayMode.YearView)
				{
					result = GetFirstDayofMonth(selectedDate);
					if (this.DisplayDateStart.HasValue && result < this.DisplayDateStart.Value)
					{
						result = this.DisplayDateStart.Value;
					}
				}
				else if (this.DisplayMode == DisplayMode.DecadeView)
				{
					result = GetFirstDayofYear(selectedDate);
					if (this.DisplayDateStart.HasValue && result < this.DisplayDateStart.Value)
					{
						result = new DateTime(this.DisplayDateStart.Value.Year, this.DisplayDateStart.Value.Month, 1);
					}
				}
				else if (this.DisplayMode == DisplayMode.CenturyView)
				{
					result = GetFirstDayofDecade(selectedDate);
					if (this.DisplayDateStart.HasValue && result < this.DisplayDateStart.Value)
					{
						result = new DateTime(this.DisplayDateStart.Value.Year, 1, 1);
					}
				}
			}
			else
			{
				if (this.DisplayMode == DisplayMode.YearView)
				{
					result = GetFirstDayofMonth(selectedDate);
					if (this.DisplayDateStart.HasValue && result < this.DisplayDateStart.Value)
					{
						result = new DateTime(this.DisplayDateStart.Value.Year, this.DisplayDateStart.Value.Month, 1);
					}
				}
				else if (this.DisplayMode == DisplayMode.DecadeView)
				{
					result = GetFirstDayofYear(selectedDate);
					if (this.DisplayDateStart.HasValue && result < this.DisplayDateStart.Value)
					{
						result = new DateTime(this.DisplayDateStart.Value.Year, 1, 1);
					}
				}
				else if (this.DisplayMode == DisplayMode.CenturyView)
				{
					result = GetFirstDayofDecade(selectedDate);
					if (this.DisplayDateStart.HasValue && result < this.DisplayDateStart.Value)
					{
						result = new DateTime(((this.DisplayDateStart.Value.Year / 10) * 10), 1, 1);
					}
				}
			}

			if (forceSelection)
			{
				this.ChangeViews(result);
			}
			this.CurrentDate = result;
		}

		private void MovePrevNext(DateTime selectedDate)
		{
			DateTime shouldBeLargerThan = this.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = this.DisplayDateEnd ?? MaxDate;
			this.SelectOnEnter = false;
			if (this.VisibleDateStart > selectedDate && selectedDate > shouldBeLargerThan)
			{
				this.skipNextChange = true;
				this.MovePrev();
			}
			else if (selectedDate > this.VisibleDateEnd && selectedDate < shouldBeSmallerThan)
			{
				this.skipNextChange = true;
				this.MoveNext();
			}
		}

		private void ChangeViews(DateTime selectedDate)
		{
			try
			{
				this.suspendPopulation = true;
				this.DisplayDate = selectedDate;
			}
			finally
			{
				this.suspendPopulation = false;
			}

			switch (this.DisplayMode)
			{
				case DisplayMode.YearView:
					if (this.DateSelectionMode == DateSelectionMode.Month)
						return;
					this.DisplayMode = DisplayMode.MonthView;
					break;
				case DisplayMode.DecadeView:
					if (this.DateSelectionMode == DateSelectionMode.Year)
						return;
					this.DisplayMode = DisplayMode.YearView;
					break;
				case DisplayMode.CenturyView:
					this.DisplayMode = DisplayMode.DecadeView;
					break;
				default:
					break;
			}
		}

		private void OnFocusDateChanged(DateTime oldFocused, DateTime focusedDate)
		{
			this.FocusHandled = false;
			if (this.FocusDateChanged != null)
			{
				this.FocusDateChanged(this, new RoutedPropertyChangedEventArgs<DateTime>(oldFocused, focusedDate));
			}
		}

		private bool DateSelectableInMonth(DateTime date)
		{
			if (this.monthViews != null && !this.Flags.ForceNewCalendarButtons)
			{
				foreach (var childView in this.monthViews.Children)
				{
					CalendarView monthView = childView as CalendarView;
					if (monthView.DateToContent.ContainsKey(date))
					{
						return monthView.DateToContent[date].IsEnabled;
					}
				}
			}

			DateTime shouldBeLargerThan = this.SelectableDateStart ?? this.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = this.SelectableDateEnd ?? this.DisplayDateEnd ?? MaxDate;

			return date >= shouldBeLargerThan
				&& date <= shouldBeSmallerThan;
		}

		private bool DateSelectableInYear(DateTime date)
		{
			DateTime shouldBeLargerThan = this.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = this.DisplayDateEnd ?? MaxDate;

			return date >= GetFirstDayofMonth(shouldBeLargerThan)
				&& date <= GetFirstDayofMonth(shouldBeSmallerThan).AddMonths(1).AddDays(-1);
		}

		private bool DateSelectableInDecade(DateTime date)
		{
			DateTime shouldBeLargerThan = this.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = this.DisplayDateEnd ?? MaxDate;

			return date >= GetFirstDayofYear(shouldBeLargerThan)
				&& date <= GetFirstDayofYear(shouldBeSmallerThan).AddYears(1).AddDays(-1);
		}

		private bool DateSelectableInCentury(DateTime date)
		{
			DateTime shouldBeLargerThan = this.SelectableDateStart ?? this.DisplayDateStart ?? MinDate;
			DateTime shouldBeSmallerThan = this.SelectableDateEnd ?? this.DisplayDateEnd ?? MaxDate;

			return date >= GetFirstDayofDecade(shouldBeLargerThan)
				&& date <= GetFirstDayofDecade(shouldBeSmallerThan).AddYears(10).AddYears(-1);
		}


        private void SetDefaultStyleKey()
        {
            //Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(RadCalendar));

            this.DefaultStyleKey =  typeof(RadCalendar);
        }


		internal class StateFlags
		{
			public StateFlags()
			{
				this.IsFirstAnimation = true;
			}

			internal bool IsLoaded
			{
				get;
				set;
			}
			internal bool IsFirstAnimation
			{
				get;
				set;
			}
			internal bool HasHeaderButton
			{
				get;
				set;
			}
			internal bool HasMoveRightButton
			{
				get;
				set;
			}
			internal bool HasMoveLeftButton
			{
				get;
				set;
			}
			internal bool HasYearViewsPanel
			{
				get;
				set;
			}
			internal bool HasDecadeViewsPanel
			{
				get;
				set;
			}
			internal bool HasCenturyViewsPanel
			{
				get;
				set;
			}
			internal bool SelectedWithKeyboard
			{
				get;
				set;
			}
			internal bool ForceNewCalendarButtons
			{
				get;
				set;
			}
		}
	}
}