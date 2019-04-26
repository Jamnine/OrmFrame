using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Orm.Toolkit.Telerik.Windows.Controls.Calendar;

using TelerikCalendarDateChangedEventArgs = Orm.Toolkit.Telerik.Windows.Controls.Calendar.CalendarDateChangedEventArgs;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	public partial class RadDatePicker
	{
		/// <summary>
		/// Identifies the <c cref="DisplayDateChanged"/> Event.
		/// </summary>		
		public static readonly RoutedEvent DisplayDateChangedEvent = RadCalendar.DisplayDateChangedEvent.AddOwner(typeof(RadDatePicker));

		/// <summary>
		/// Identifies the <c cref="DisplayModeChanged"/> Event.
		/// </summary>
		public static readonly RoutedEvent DisplayModeChangedEvent = RadCalendar.DisplayModeChangedEvent.AddOwner(typeof(RadDatePicker));

		/// <summary>
		/// Occurs when the drop-down Telerik.Windows.Controls.RadCalendar is closed.
		/// </summary>
		public static readonly RoutedEvent CalendarClosedEvent = EventManager.RegisterRoutedEvent("CalendarClosed", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RadDatePicker));

		/// <summary>
		/// Occurs when the drop-down Telerik.Windows.Controls.RadCalendar is opened.
		/// </summary>
		public static readonly RoutedEvent CalendarOpenedEvent = EventManager.RegisterRoutedEvent("CalendarOpened", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RadDatePicker));

		/// <summary>
		/// Identifies the AreWeekNumbersVisible property.
		/// </summary>
		public static readonly DependencyProperty AreWeekNumbersVisibleProperty = DependencyProperty.Register("AreWeekNumbersVisible", typeof(bool), typeof(RadDatePicker), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the AreWeekNamesVisible property.
		/// </summary>
		public static readonly DependencyProperty AreWeekNamesVisibleProperty = DependencyProperty.Register("AreWeekNamesVisible", typeof(bool), typeof(RadDatePicker), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the CalendarWeekRule property.
		/// </summary>
		public static readonly DependencyProperty CalendarWeekRuleProperty = DependencyProperty.Register("CalendarWeekRule", typeof(CalendarWeekRule?), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the CenturyViewHeaderFormat property.
		/// </summary>
		public static readonly DependencyProperty CenturyViewHeaderFormatProperty = DependencyProperty.Register("CenturyViewHeaderFormat", typeof(string), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the CenturyViewPanel property.
		/// </summary>
		public static readonly DependencyProperty CenturyViewPanelProperty = DependencyProperty.Register("CenturyViewPanel", typeof(ItemsPanelTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the CenturyViewStyle property.
		/// </summary>
		public static readonly DependencyProperty CenturyViewStyleProperty = DependencyProperty.Register("CenturyViewStyle", typeof(Style), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the Columns property.
		/// </summary>
		public static readonly DependencyProperty ColumnsProperty = DependencyPropertyExtensions.Register("Columns", typeof(int), typeof(RadDatePicker), new PropertyMetadata(1));

		/// <summary>
		/// Identifies the DayButtonStyle property.
		/// </summary>
		public static readonly DependencyProperty DayButtonStyleProperty = DependencyProperty.Register("DayButtonStyle", typeof(Style), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DayButtonStyleSelector property.
		/// </summary>
		public static readonly DependencyProperty DayButtonStyleSelectorProperty = DependencyProperty.Register("DayButtonStyleSelector", typeof(StyleSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DayTemplate property.
		/// </summary>
		public static readonly DependencyProperty DayTemplateProperty = DependencyProperty.Register("DayTemplate", typeof(DataTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DayTemplateSelector property.
		/// </summary>
		public static readonly DependencyProperty DayTemplateSelectorProperty = DependencyProperty.Register("DayTemplateSelector", typeof(DataTemplateSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DecadeButtonStyle property.
		/// </summary>
		public static readonly DependencyProperty DecadeButtonStyleProperty = DependencyProperty.Register("DecadeButtonStyle", typeof(Style), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DecadeButtonStyleSelector property.
		/// </summary>
		public static readonly DependencyProperty DecadeButtonStyleSelectorProperty = DependencyProperty.Register("DecadeButtonStyleSelector", typeof(StyleSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DecadeTemplate property.
		/// </summary>
		public static readonly DependencyProperty DecadeTemplateProperty = DependencyProperty.Register("DecadeTemplate", typeof(DataTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DayButtonStyle property.
		/// </summary>
		public static readonly DependencyProperty DecadeTemplateSelectorProperty = DependencyProperty.Register("DecadeTemplateSelector", typeof(DataTemplateSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DecadeViewHeaderFormat property.
		/// </summary>
		public static readonly DependencyProperty DecadeViewHeaderFormatProperty = DependencyProperty.Register("DecadeViewHeaderFormat", typeof(string), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DecadeViewPanel property.
		/// </summary>
		public static readonly DependencyProperty DecadeViewPanelProperty = DependencyProperty.Register("DecadeViewPanel", typeof(ItemsPanelTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the DecadeViewStyle property.
		/// </summary>
		public static readonly DependencyProperty DecadeViewStyleProperty = DependencyProperty.Register("DecadeViewStyle", typeof(Style), typeof(RadDatePicker), null);

		/// <summary> 
		/// Identifies the DisplayMode dependency property.
		/// </summary>
		public static readonly DependencyProperty DisplayModeProperty = DependencyProperty.Register("DisplayMode", typeof(DisplayMode), typeof(RadDatePicker), null);

		/// <summary> 
		/// Identifies the FirstDayOfWeek dependency property.
		/// </summary>
		public static readonly DependencyProperty FirstDayOfWeekProperty = DependencyProperty.Register("FirstDayOfWeek", typeof(DayOfWeek?), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the HeaderVisibility property.
		/// </summary>
		public static readonly DependencyProperty HeaderVisibilityProperty = DependencyProperty.Register("HeaderVisibility", typeof(Visibility), typeof(RadDatePicker), null);

		/// <summary> 
		/// Identifies the IsTodayHighlighted dependency property.
		/// </summary>		
		public static readonly DependencyProperty IsTodayHighlightedProperty = DependencyProperty.Register("IsTodayHighlighted", typeof(bool), typeof(RadDatePicker), new PropertyMetadata(true));

		/// <summary>
		/// Identifies the MonthButtonStyle property.
		/// </summary>
		public static readonly DependencyProperty MonthButtonStyleProperty = DependencyProperty.Register("MonthButtonStyle", typeof(Style), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the MonthButtonStyleSelector property.
		/// </summary>
		public static readonly DependencyProperty MonthButtonStyleSelectorProperty = DependencyProperty.Register("MonthButtonStyleSelector", typeof(StyleSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the MonthTemplate property.
		/// </summary>
		public static readonly DependencyProperty MonthTemplateProperty = DependencyProperty.Register("MonthTemplate", typeof(DataTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the MonthTemplateSelector property.
		/// </summary>
		public static readonly DependencyProperty MonthTemplateSelectorProperty = DependencyProperty.Register("MonthTemplateSelector", typeof(DataTemplateSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the MonthViewHeaderFormat property.
		/// </summary>
		public static readonly DependencyProperty MonthViewHeaderFormatProperty = DependencyProperty.Register("MonthViewHeaderFormat", typeof(string), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the MonthViewPanel property.
		/// </summary>
		public static readonly DependencyProperty MonthViewPanelProperty = DependencyProperty.Register("MonthViewPanel", typeof(ItemsPanelTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the MonthViewStyle property.
		/// </summary>
		public static readonly DependencyProperty MonthViewStyleProperty = DependencyProperty.Register("MonthViewStyle", typeof(Style), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the Orientation property.
		/// </summary>
		public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register("Orientation", typeof(Orientation), typeof(RadDatePicker), new PropertyMetadata(Orientation.Horizontal));

		/// <summary>
		/// Identifies the Rows property.
		/// </summary>
		public static readonly DependencyProperty RowsProperty = DependencyPropertyExtensions.Register("Rows", typeof(int), typeof(RadDatePicker), new PropertyMetadata(1));

		/// <summary>
		/// Identifies the ViewsHeaderVisibility property.
		/// </summary>
		public static readonly DependencyProperty ViewsHeaderVisibilityProperty = DependencyProperty.Register("ViewsHeaderVisibility", typeof(Visibility), typeof(RadDatePicker), new PropertyMetadata(Visibility.Collapsed));

		/// <summary>
		/// Identifies the YearButtonStyle property.
		/// </summary>
		public static readonly DependencyProperty YearButtonStyleProperty = DependencyProperty.Register("YearButtonStyle", typeof(Style), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the YearButtonStyleSelector property.
		/// </summary>
		public static readonly DependencyProperty YearButtonStyleSelectorProperty = DependencyProperty.Register("YearButtonStyleSelector", typeof(StyleSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the YearTemplate property.
		/// </summary>
		public static readonly DependencyProperty YearTemplateProperty = DependencyProperty.Register("YearTemplate", typeof(DataTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the YearTemplateSelector property.
		/// </summary>
		public static readonly DependencyProperty YearTemplateSelectorProperty = DependencyProperty.Register("YearTemplateSelector", typeof(DataTemplateSelector), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the YearViewHeaderFormat property.
		/// </summary>
		public static readonly DependencyProperty YearViewHeaderFormatProperty = DependencyProperty.Register("YearViewHeaderFormat", typeof(string), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the YearViewPanel property.
		/// </summary>
		public static readonly DependencyProperty YearViewPanelProperty = DependencyProperty.Register("YearViewPanel", typeof(ItemsPanelTemplate), typeof(RadDatePicker), null);

		/// <summary>
		/// Identifies the YearViewStyle property.
		/// </summary>
		public static readonly DependencyProperty YearViewStyleProperty = DependencyProperty.Register("YearViewStyle", typeof(Style), typeof(RadDatePicker), null);



		/// <summary> 
		///     Occurs when the DisplayDate property is changed.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DisplayDateChanged"/> for more information on the event.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.DisplayDateChanged"/>
		[Obsolete]
		public event EventHandler<TelerikCalendarDateChangedEventArgs> DisplayDateChanged
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
		///         Please refer to <see cref="RadCalendar.DisplayModeChanged"/> for more information on the event.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.DisplayModeChanged"/>
		[Obsolete]
		public event EventHandler<TelerikCalendarDateChangedEventArgs> DisplayModeChanged
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

		/// <summary>
		///     Occurs when the RadCalendar is closed. 
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>CalendarClosed</strong> event is fired when the <see cref="RadCalendar"/>
		///         have closed.
		///     </para>
		/// </remarks>
		[Obsolete]
		public event RoutedEventHandler CalendarClosed
		{
			add
			{
				this.AddHandler(CalendarClosedEvent, value);
			}
			remove
			{
				this.RemoveHandler(CalendarClosedEvent, value);
			}
		}

		/// <summary>
		///     Occurs when the RadCalendar is opened. 
		/// </summary>
		/// <remarks>
		///     <para>
		///         The <strong>CalendarOpened</strong> event is fired when the <see cref="RadCalendar"/>
		///         have opened.
		///     </para>
		/// </remarks>
		[Obsolete]
		public event RoutedEventHandler CalendarOpened
		{
			add
			{
				this.AddHandler(CalendarOpenedEvent, value);
			}
			remove
			{
				this.RemoveHandler(CalendarOpenedEvent, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the week numbers are visible.
		/// </summary>
		/// <value>
		/// Returns <c>true</c> if the week numbers are visible otherwise, <c>false</c>.
		/// </value>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public bool AreWeekNumbersVisible
		{
			get { return (bool)GetValue(AreWeekNumbersVisibleProperty); }
			set { SetValue(AreWeekNumbersVisibleProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value indicating whether the week numbers are visible.
		/// </summary>
		/// <value>
		/// Returns <c>true</c> if the week numbers are visible otherwise, <c>false</c>.
		/// </value>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public bool AreWeekNamesVisible
		{
			get { return (bool)GetValue(AreWeekNamesVisibleProperty); }
			set { SetValue(AreWeekNamesVisibleProperty, value); }
		}

		/// <summary>
		///     Gets or sets how should the first week in the year be counted. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.CalendarWeekRule"/> for more information on the property.
		///     </para>
		/// </remarks>

		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public CalendarWeekRule? CalendarWeekRule
		{
			get { return (CalendarWeekRule?)GetValue(CalendarWeekRuleProperty); }
			set { SetValue(CalendarWeekRuleProperty, value); }
		}

		/// <summary>
		/// Gets or sets the format for the header of the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.CenturyViewHeaderFormat"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public string CenturyViewHeaderFormat
		{
			get { return (string)GetValue(CenturyViewHeaderFormatProperty); }
			set { SetValue(CenturyViewHeaderFormatProperty, value); }
		}

		/// <summary>
		/// Gets or sets the items panel template for the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.CenturyViewPanel"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public ItemsPanelTemplate CenturyViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(CenturyViewPanelProperty); }
			set { SetValue(CenturyViewPanelProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style of the century calendar view. This is a dependency property.
		/// </summary>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Style CenturyViewStyle
		{
			get { return (Style)GetValue(CenturyViewStyleProperty); }
			set { SetValue(CenturyViewStyleProperty, value); }
		}

		/// <summary>
		/// Gets or sets the number of columns of calendar views in the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.Columns"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="Rows"/>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public int Columns
		{
			get { return (int)GetValue(ColumnsProperty); }
			set { SetValue(ColumnsProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style for the day buttons in the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DayButtonStyle"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Style DayButtonStyle
		{
			get { return (Style)GetValue(DayButtonStyleProperty); }
			set { SetValue(DayButtonStyleProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style selector for the day buttons in the month views of the Calendar.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DayButtonStyleSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public StyleSelector DayButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(DayButtonStyleSelectorProperty); }
			set { SetValue(DayButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the content templates for the day buttons in the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DayTemplate"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public DataTemplate DayTemplate
		{
			get { return (DataTemplate)GetValue(DayTemplateProperty); }
			set { SetValue(DayTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the DataTemplate selectors for the day buttons in the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DayTemplateSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public DataTemplateSelector DayTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(DayTemplateSelectorProperty); }
			set { SetValue(DayTemplateSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style for the year decade in the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DecadeButtonStyle"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
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
		///         Please refer to <see cref="RadCalendar.DecadeButtonStyleSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public StyleSelector DecadeButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(DecadeButtonStyleSelectorProperty); }
			set { SetValue(DecadeButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the content templates for the decade buttons in the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DecadeTemplate"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public DataTemplate DecadeTemplate
		{
			get { return (DataTemplate)GetValue(DecadeTemplateProperty); }
			set { SetValue(DecadeTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the DataTemplate selectors for the decade buttons in the century views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DecadeTemplateSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public DataTemplateSelector DecadeTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(DecadeTemplateSelectorProperty); }
			set { SetValue(DecadeTemplateSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the format for the header of the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DecadeViewHeaderFormat"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
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
		///         Please refer to <see cref="RadCalendar.DecadeViewPanel"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public ItemsPanelTemplate DecadeViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(DecadeViewPanelProperty); }
			set { SetValue(DecadeViewPanelProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style of the decade calendar view. This is a dependency property.
		/// </summary>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Style DecadeViewStyle
		{
			get { return (Style)GetValue(DecadeViewStyleProperty); }
			set { SetValue(DecadeViewStyleProperty, value); }
		}

		/// <summary>
		///     Gets or sets the display mode of the Calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.DisplayMode"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.DisplayMode"/>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
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
		///         Please refer to <see cref="RadCalendar.FirstDayOfWeek"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.FirstDayOfWeek"/>

		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
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
		///         Please refer to <see cref="RadCalendar.HeaderVisibility"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.HeaderVisibility"/>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Visibility HeaderVisibility
		{
			get { return (Visibility)GetValue(HeaderVisibilityProperty); }
			set { SetValue(HeaderVisibilityProperty, value); }
		}



		/// <summary>
		///     Gets or sets whether the today date would be highlighted. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.IsTodayHighlighted"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="RadCalendar.IsTodayHighlighted"/>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
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
		///         Please refer to <see cref="RadCalendar.MonthButtonStyle"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Style MonthButtonStyle
		{
			get { return (Style)GetValue(MonthButtonStyleProperty); }
			set { SetValue(MonthButtonStyleProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style selector for the month buttons in the year views of the Calendar.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.MonthButtonStyleSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public StyleSelector MonthButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(MonthButtonStyleSelectorProperty); }
			set { SetValue(MonthButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the content templates for the month buttons in the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.MonthTemplate"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
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
		///         Please refer to <see cref="RadCalendar.MonthTemplateSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public DataTemplateSelector MonthTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(MonthTemplateSelectorProperty); }
			set { SetValue(MonthTemplateSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the format for the header of the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.MonthViewHeaderFormat"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public string MonthViewHeaderFormat
		{
			get { return (string)GetValue(MonthViewHeaderFormatProperty); }
			set { SetValue(MonthViewHeaderFormatProperty, value); }
		}

		/// <summary>
		/// Gets or sets the items panel template for the month views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.MonthViewPanel"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public ItemsPanelTemplate MonthViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(MonthViewPanelProperty); }
			set { SetValue(MonthViewPanelProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style of the month calendar view. This is a dependency property.
		/// </summary>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Style MonthViewStyle
		{
			get { return (Style)GetValue(MonthViewStyleProperty); }
			set { SetValue(MonthViewStyleProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether the orientation of the Calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.Orientation"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Orientation Orientation
		{
			get { return (Orientation)GetValue(OrientationProperty); }
			set { SetValue(OrientationProperty, value); }
		}

		/// <summary>
		/// Gets or sets the number of rows of calendar views in the calendar. This is a dependency proeprty.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.SelectedDate"/> for more information on the property.
		///     </para>
		/// </remarks>
		/// <seealso cref="Columns"/>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public int Rows
		{
			get { return (int)GetValue(RowsProperty); }
			set { SetValue(RowsProperty, value); }
		}

		/// <summary>
		///     Gets or sets the visibility of the header of the calendar views (month, year, decade, century). This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.ViewsHeaderVisibility"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Visibility ViewsHeaderVisibility
		{
			get { return (Visibility)GetValue(ViewsHeaderVisibilityProperty); }
			set { SetValue(ViewsHeaderVisibilityProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style for the year buttons in the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.YearButtonStyle"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Style YearButtonStyle
		{
			get { return (Style)GetValue(YearButtonStyleProperty); }
			set { SetValue(YearButtonStyleProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style selector for the year buttons in the decade views of the Calendar.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.YearButtonStyleSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public StyleSelector YearButtonStyleSelector
		{
			get { return (StyleSelector)GetValue(YearButtonStyleSelectorProperty); }
			set { SetValue(YearButtonStyleSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the content templates for the year buttons in the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.YearTemplate"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public DataTemplate YearTemplate
		{
			get { return (DataTemplate)GetValue(YearTemplateProperty); }
			set { SetValue(YearTemplateProperty, value); }
		}

		/// <summary>
		/// Gets or sets the DataTemplate selectors for the year buttons in the decade views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.YearTemplateSelector"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public DataTemplateSelector YearTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(YearTemplateSelectorProperty); }
			set { SetValue(YearTemplateSelectorProperty, value); }
		}

		/// <summary>
		/// Gets or sets the format for the header of the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.YearViewHeaderFormat"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public string YearViewHeaderFormat
		{
			get { return (string)GetValue(YearViewHeaderFormatProperty); }
			set { SetValue(YearViewHeaderFormatProperty, value); }
		}

		/// <summary>
		/// Gets or sets the items panel template for the year views of the calendar. This is a dependency property.
		/// </summary>
		/// <remarks>
		///     <para>
		///         Please refer to <see cref="RadCalendar.YearViewPanel"/> for more information on the property.
		///     </para>
		/// </remarks>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public ItemsPanelTemplate YearViewPanel
		{
			get { return (ItemsPanelTemplate)GetValue(YearViewPanelProperty); }
			set { SetValue(YearViewPanelProperty, value); }
		}

		/// <summary>
		/// Gets or sets the style of the calendar year view. This is a dependency property.
		/// </summary>
		[Obsolete("Use the CalendarStyle property to set this property to the Calendar.")]
		public Style YearViewStyle
		{
			get { return (Style)GetValue(YearViewStyleProperty); }
			set { SetValue(YearViewStyleProperty, value); }
		}

		/// <summary>
		/// Selects a range of text in the text box.
		/// </summary>
		[Obsolete]
		public void Select(int start, int length)
		{
		}

		/// <summary>
		/// Select the entire contents of the text box.
		/// </summary>
		[Obsolete]
		public void SelectAll()
		{
		}

		/// <summary>
		///     Called when the focus has been changed.
		/// </summary>
		/// <param name="oldValue">The previous value of IsFocused.</param>
		/// <param name="newValue">The current value of IsFocused.</param>
		/// <remarks>
		///     <para>
		///         When overriden in a derived class, the <strong>OnIsFocusChanged</strong> method can be used for a place to
		///         act when focus is changed. If the base call is supressed, the visuals of the TabItem will not change to 
		///         reflect the change.
		///     </para>
		/// </remarks>
		[Obsolete]
		protected virtual void OnIsFocusedChanged(bool oldValue, bool newValue)
		{
		}

		/// <summary>
		/// OnCalendarClosed is called whenever the RadCalendar is closed.
		/// </summary>
		/// <param name="e">Parameter that describes how the event has changed.</param>
		[Obsolete]
		protected virtual void OnCalendarClosed(RadRoutedEventArgs e)
		{
		}

		/// <summary>
		/// OnCalendarOpened is called whenever the RadCalendar is opened.
		/// </summary>
		/// <param name="e">Parameter that describes how the event has changed.</param>
		[Obsolete]
		protected virtual void OnCalendarOpened(RadRoutedEventArgs e)
		{
		}
	}
}