using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	/// CalendarView is the calendar items wrapper for the calendar.
	/// </summary>
	/// <remarks>
	/// 	<strong>CalendarView</strong> is primitive building block for the calendar control and is not
	/// intended to be used separately.
	/// </remarks>
	[DefaultProperty("HeaderVisibility")]
	public class CalendarView : HeaderedItemsControl
	{
		/// <summary>
		/// Identifies the Columns property.
		/// </summary>
		public static readonly DependencyProperty ColumnsProperty = DependencyProperty.Register("Columns", typeof(int), typeof(CalendarView), new PropertyMetadata(8, null, null));

		/// <summary>
		/// Identifies the HeaderVisibility proeprty.
		/// </summary>
		public static readonly DependencyProperty HeaderVisibilityProperty = DependencyProperty.Register("HeaderVisibility", typeof(Visibility), typeof(CalendarView), null);

		/// <summary>
		/// Identifies the HideColumn property.
		/// </summary>
		public static readonly DependencyProperty HideColumnProperty = DependencyProperty.Register("HideColumn", typeof(bool), typeof(CalendarView), null);

		/// <summary>
		/// Identifies the HideRow property.
		/// </summary>
		public static readonly DependencyProperty HideRowProperty = DependencyProperty.Register("HideRow", typeof(bool), typeof(CalendarView), null);

		/// <summary>
		/// Identifies the Orientation property.
		/// </summary>
		public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register("Orientation", typeof(Orientation), typeof(CalendarView), new PropertyMetadata(Orientation.Horizontal, OnOrientationChange, null));

		/// <summary>
		/// Identifies the Rows property.
		/// </summary>
		public static readonly DependencyProperty RowsProperty = DependencyProperty.Register("Rows", typeof(int), typeof(CalendarView), new PropertyMetadata(7, null, null));

		internal static readonly DependencyProperty DisplayModeProperty = DependencyProperty.Register("DisplayMode", typeof(DisplayMode), typeof(CalendarView), new PropertyMetadata(DisplayMode.MonthView, null, null));

		private static DateTime? dateToFocus;
		private RadCalendar calendar;
		private CalendarPanel itemsPanel;

		//// Constructors:

        static CalendarView()
        {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarView),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(CalendarView))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarView),
            new FrameworkPropertyMetadata(typeof(CalendarView)));


            System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(CalendarView),
                new FrameworkPropertyMetadata(System.Windows.Input.KeyboardNavigationMode.Once));
        }


		/// <summary>
		/// Initializes a new instance of the <see cref="CalendarView"/> class.
		/// </summary>
		public CalendarView()
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CalendarView"/> class.
		/// </summary>
		/// <param name="calendar">The owner calendar of the calendar view.</param>
		public CalendarView(RadCalendar calendar)
		{

			this.calendar = calendar;
			calendar.FocusDateChanged += new EventHandler<RoutedPropertyChangedEventArgs<DateTime>>(this.FocusDateChanged);
			calendar.SelectionHelper.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionHelperSelectionChanged);
			this.DateToContent = new Dictionary<DateTime, CalendarButtonContent>();
		}

		//// Properties:

		/// <summary>
		/// Gets or sets whether the number of columns of the CalendarView. This is a dependency property.
		/// </summary>
		public int Columns
		{
			get { return (int)GetValue(ColumnsProperty); }
			set { SetValue(ColumnsProperty, value); }
		}

		/// <summary>
		/// Gets or sets the visibility of the header of the Calendar view. This is a dependency property.
		/// </summary>
		public Visibility HeaderVisibility
		{
			get { return (Visibility)GetValue(HeaderVisibilityProperty); }
			set { SetValue(HeaderVisibilityProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether first column will be displayed.
		/// </summary>
		public bool HideColumn
		{
			get { return (bool)GetValue(HideColumnProperty); }
			set { SetValue(HideColumnProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether first row will be displayed.
		/// </summary>
		public bool HideRow
		{
			get { return (bool)GetValue(HideRowProperty); }
			set { SetValue(HideRowProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether the orientation of the CalendarView. This is a dependency property.
		/// </summary>
		public Orientation Orientation
		{
			get { return (Orientation)GetValue(OrientationProperty); }
			set { SetValue(OrientationProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether the number of rows of the CalendarView. This is a dependency property.
		/// </summary>
		public int Rows
		{
			get { return (int)GetValue(RowsProperty); }
			set { SetValue(RowsProperty, value); }
		}

		internal DisplayMode DisplayMode
		{
			get { return (DisplayMode)GetValue(DisplayModeProperty); }
			set { SetValue(DisplayModeProperty, value); }
		}

		internal Dictionary<DateTime, CalendarButtonContent> DateToContent
		{
			get;
			set;
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			this.itemsPanel = null;

			this.DataContext = this;

			base.OnApplyTemplate();
		}

		/// <summary>
		/// Clears the attached events.
		/// </summary>
		internal void ClearEvents()
		{
			this.calendar.SelectionHelper.SelectionChanged -= new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionHelperSelectionChanged);
			this.calendar.FocusDateChanged -= new EventHandler<RoutedPropertyChangedEventArgs<DateTime>>(this.FocusDateChanged);
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
		/// Invoked whenever an unhandled <see cref="E:System.Windows.UIElement.GotFocus"/> event reaches this element in its route.
		/// </summary>
		/// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			if (this.calendar != null)
			{
				e.Handled = true;
				this.calendar.FocusSelectedDate();
			}
		}

		/// <summary>
		/// Determines if the specified item is (or is eligible to be) its own container.
		/// </summary>
		/// <param name="item">The item to check.</param>
		/// <returns>
		/// True if the item is (or is eligible to be) its own container; otherwise, false.
		/// </returns>
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is CalendarButton;
		}

		/// <summary>
		/// Creates or identifies the element that is used to display the given item.
		/// </summary>
		/// <returns>
		/// The element that is used to display the given item.
		/// </returns>
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new CalendarButton();
		}

		/// <summary>
		/// When overridden in a derived class, undoes the effects of the <see cref="M:System.Windows.Controls.ItemsControl.PrepareContainerForItemOverride(System.Windows.DependencyObject,System.Object)"/> method.
		/// </summary>
		/// <param name="element">The container element.</param>
		/// <param name="item">The item.</param>
		protected override void ClearContainerForItemOverride(DependencyObject element, object item)
		{
			CalendarButton button = element as CalendarButton;
			if (button != null)
			{
				button.MouseEnter -= new System.Windows.Input.MouseEventHandler(this.CalendarButtonMouseEnter);
				////button.MouseLeftButtonDown -= new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonDown);
				////button.MouseLeftButtonUp -= new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonUp);
				button.RemoveHandler(CalendarButton.MouseLeftButtonDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonDown));
				button.RemoveHandler(CalendarButton.MouseLeftButtonUpEvent, new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonUp));
			}
			CalendarButtonContent content = item as CalendarButtonContent;
			if (content != null && this.DateToContent.ContainsKey(content.Date))
			{
				this.DateToContent.Remove(content.Date);
			}

			base.ClearContainerForItemOverride(element, item);
		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);

			CalendarButtonContent content = item as CalendarButtonContent;


			StyleManager.SetTheme(element, StyleManager.GetTheme(this));


			if (content != null)
			{
				// This check fixed an integratin problem with DataForm
				// TODO: Investigate why this check fixed an integratin problem with DataForm
				if (!this.DateToContent.ContainsKey(content.Date))
				{
					this.DateToContent.Add(content.Date, content);
				}
			}

			CalendarButton button = element as CalendarButton;
			if (button != null && button != item)
			{
				if (content.ButtonType == CalendarButtonType.WeekName ||
				   content.ButtonType == CalendarButtonType.WeekNumber)
				{
					button.IsTabStop = false;

					string propertyPath = content.ButtonType == CalendarButtonType.WeekName ? "HideRow" : "HideColumn";

					Binding binding = new Binding(propertyPath)
					{
						Source = this,
						Converter = new BoleanToVisibilityConverterRevert(),
						Mode = BindingMode.TwoWay
					};
					button.SetBinding(Button.VisibilityProperty, binding);

					if (this.itemsPanel == null)
					{
						var calendarPanel = this.GetItemsPanel<CalendarPanel>();
						if (calendarPanel != null)
						{
							this.itemsPanel = calendarPanel;

							calendarPanel.SetBinding(CalendarPanel.HideFirstColumnProperty, new Binding("HideColumn") { Source = this });
							calendarPanel.SetBinding(CalendarPanel.HideFirstRowProperty, new Binding("HideRow") { Source = this });
						}
					}
				}
				button.Content = item;
				button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.CalendarButtonMouseEnter);
				////button.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonDown);
				////button.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonUp);
				button.AddHandler(CalendarButton.MouseLeftButtonDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonDown), true);
				button.AddHandler(CalendarButton.MouseLeftButtonUpEvent, new System.Windows.Input.MouseButtonEventHandler(this.CalendarButtonMouseLeftButtonUp), true);

				if (dateToFocus.HasValue && content.Date.Equals(dateToFocus.Value))
				{
					button.FocusOnLoad = true;
					dateToFocus = null;
				}
			}
		}

		/// <summary>
		/// Called before the <see cref="E:System.Windows.UIElement.MouseLeftButtonUp"/> event occurs.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.DisableSelectOnMouseEnter();
		}

        private static void OnOrientationChange(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            CalendarView calendarView = sender as CalendarView;
            SwapRowsAndColumns(calendarView);
            bool cache = calendarView.HideRow;
            calendarView.HideRow = calendarView.HideColumn;
            calendarView.HideColumn = cache;
        }

        private static void SwapRowsAndColumns(CalendarView calendarView)
        {
            switch (calendarView.DisplayMode)
            {
                case DisplayMode.MonthView:
                    if (calendarView.Orientation == Orientation.Horizontal)
                    {
                        calendarView.Rows = 7;
                        calendarView.Columns = 8;
                    }
                    else
                    {
                        calendarView.Rows = 8;
                        calendarView.Columns = 7;
                    }
                    break;
                case DisplayMode.YearView:
                case DisplayMode.DecadeView:
                case DisplayMode.CenturyView:
                    if (calendarView.Orientation == Orientation.Horizontal)
                    {
                        calendarView.Rows = 3;
                        calendarView.Columns = 4;
                    }
                    else
                    {
                        calendarView.Rows = 4;
                        calendarView.Columns = 3;
                    }
                    break;
                default:
                    break;
            }
        }

        private void SetDefaultStyleKey()
        {
            //Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(CalendarView));

            this.DefaultStyleKey =  typeof(CalendarView);
        }


		private void CalendarButtonMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			////if (this.calendar.SelectionMode == SelectionMode.Single)
			////{
			////    this.HandleMouseEvents(sender, e);
			////}
			e.Handled = true;
			this.DisableSelectOnMouseEnter();
		}

		private void CalendarButtonMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			////if (this.calendar.SelectionMode == SelectionMode.Single)
			////{
			//    //return;
			////}
			this.HandleMouseEvents(sender, e);
		}

		private void HandleMouseEvents(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.calendar != null && this.calendar.SelectionMode != SelectionMode.Single
				&& this.calendar.DisplayMode == DisplayMode.MonthView)
			{
				e.Handled = this.AddDate(sender);
				this.calendar.SelectOnEnter = true;
			}
			else
			{
				e.Handled = this.AddDate(sender);
			}
		}

		private void CalendarButtonMouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			if (this.calendar != null && this.calendar.SelectOnEnter)
			{
				this.AddDate(sender);
			}
		}

		private void DisableSelectOnMouseEnter()
		{
			if (this.calendar != null)
			{
				this.calendar.SelectOnEnter = false;
			}
		}

		private void SelectionHelperSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{

			foreach (DateTime date in e.AddedItems)
			{
				CalendarButtonContent content;
				if (this.DateToContent.TryGetValue(date, out content))
				{
					content.IsSelected = true;
				}
			}

			foreach (DateTime date in e.RemovedItems)
			{
				CalendarButtonContent content;
				if (this.DateToContent.TryGetValue(date, out content))
				{
					content.IsSelected = false;
				}
			}

		}

		private bool AddDate(object sender)
		{
			CalendarButton btn = sender as CalendarButton;
			CalendarButtonContent content = null;
			if (btn != null)
			{
				content = btn.Content as CalendarButtonContent;
			}
			if (content != null)
			{
				return this.AddDateToCalendarSelection(content);
			}

			return false;
		}

		private bool AddDateToCalendarSelection(CalendarButtonContent content)
		{
			if (this.calendar == null)
			{
				return false;
			}
			return this.calendar.Select(content.Date, true);
		}

		private void FocusDateChanged(object sender, RoutedPropertyChangedEventArgs<DateTime> e)
		{
			if (this.DisplayMode != this.calendar.DisplayMode)
			{
				return;
			}

			if (this.calendar != null && this.calendar.FocusHandled)
			{
				return;
			}

			CalendarButton btn = null;
			CalendarButtonContent content;
			if (this.DateToContent.TryGetValue((DateTime)e.NewValue, out content))
			{
				btn = content.Owner;
			}
			else
			{
				System.Diagnostics.Debug.WriteLine("Not Found: " + e.NewValue);
				if (this.DateToContent.Count == 0)
				{
					dateToFocus = e.NewValue;
					this.calendar.FocusHandled = true;
				}
			}

			if (btn != null && btn.Focus())
			{
				this.calendar.FocusHandled = true;
			}
		}
	}
}