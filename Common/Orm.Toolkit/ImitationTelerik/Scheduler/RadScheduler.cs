using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// RadScheduler is a complex and powerful scheduling control with Outlook® style functionalities. 
	/// The control provides the power to completely customize your application UI as well as customize 
	/// the built-in Day, Week and Month Views. 
	/// </summary>
	[TemplatePart(Name = HeaderElementName, Type = typeof(FrameworkElement))]
	[TemplateVisualState(Name = "DayState", GroupName = "ViewModeStates")]
	[TemplateVisualState(Name = "WeekState", GroupName = "ViewModeStates")]
	[TemplateVisualState(Name = "MonthState", GroupName = "ViewModeStates")]
	public partial class RadScheduler : Control, IScheduler
	{
		/// <summary>
		/// Identifies the <see cref="ActiveViewDefinition"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="ActiveViewDefinition"/> property</returns>
		public static readonly DependencyProperty ActiveViewDefinitionProperty;

		/// <summary>
		/// Identifies the <see cref="AllDayAreaHeight"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AllDayAreaHeight"/> property</returns>
		public static readonly DependencyProperty AllDayAreaHeightProperty =
			DependencyProperty.Register("AllDayAreaHeight", typeof(double), typeof(RadScheduler), new PropertyMetadata(44.0));

		/// <summary>
		/// Identifies the <see cref="AppointmentsSource"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AppointmentsSource"/> property</returns>
		public static readonly DependencyProperty AppointmentsSourceProperty =
			DependencyProperty.Register(
				"AppointmentsSource",
				typeof(IEnumerable),
				typeof(RadScheduler),
				new PropertyMetadata(null, OnAppointmentsSourceChanged));

		/// <summary>
		/// Identifies the <see cref="AppointmentTemplate"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AppointmentTemplate"/> property</returns>
		public static readonly DependencyProperty AppointmentTemplateProperty =
			DependencyProperty.Register(
				"AppointmentTemplate",
				typeof(DataTemplate),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

		/// <summary>
		/// Identifies the <see cref="DragVisualCueTemplate"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="DragVisualCueTemplate"/> property</returns>
		public static readonly DependencyProperty DragVisualCueTemplateProperty =
			DependencyProperty.Register(
				"DragVisualCueTemplate",
				typeof(DataTemplate),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

		/// <summary>
		/// Identifies the <see cref="AppointmentTemplate"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AppointmentTemplate"/> property</returns>
		public static readonly DependencyProperty AppointmentTemplateSelectorProperty =
			DependencyProperty.Register(
				"AppointmentTemplateSelector",
				typeof(DataTemplateSelector),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

		/// <summary>
		/// Identifies the <see cref="AvailableViewModes"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AvailableViewModes"/> property</returns>
		public static readonly DependencyProperty AvailableViewModesProperty =
			DependencyProperty.Register(
			"AvailableViewModes",
			typeof(AvailableViewModes),
			typeof(RadScheduler),
			new PropertyMetadata(AvailableViewModes.All, OnAvailableViewModePropertyChanged));

		/// <summary>
		/// Identifies the <see cref="TimeSlotTemplateSelector"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="TimeSlotTemplateSelector"/> property</returns>
		public static readonly DependencyProperty TimeSlotTemplateSelectorProperty =
			DependencyProperty.Register(
				"TimeSlotTemplateSelector",
				typeof(DataTemplateSelector),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

		/// <summary>
		/// Identifies the <see cref="OpenModalDialogs"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="OpenModalDialogs"/> property</returns>
		public static readonly DependencyProperty OpenModalDialogsProperty =
			DependencyProperty.Register(
				"OpenModalDialogs",
				typeof(bool),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(false));

		/// <summary>
		/// Identifies the <see cref="GroupBy"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="GroupBy"/> property</returns>
		public static readonly DependencyProperty GroupByProperty =
			DependencyProperty.Register(
				"GroupBy",
				typeof(string),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, OnGroupByChanged));

		/// <summary>
		/// Identifies the <see cref="DisplayEmptyGroup"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="DisplayEmptyGroup"/> property</returns>
		public static readonly DependencyProperty DisplayEmptyGroupProperty =
			DependencyProperty.Register(
				"DisplayEmptyGroup",
				typeof(bool),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(false, OnDisplayEmptyGroupChanged));

		/// <summary>
		/// Identifies the <see cref="Culture"/> property. When this property is changed Language property is change too.
		/// </summary>
		/// <returns>The identifier for the <see cref="Culture"/> property</returns>
		public static readonly DependencyProperty CultureProperty =
			DependencyProperty.Register(
				"Culture",
				typeof(CultureInfo),
				typeof(RadScheduler),
				new PropertyMetadata(null, OnCultureChanged, CoerceCulture));

		/// <summary>
		/// Identifies the <see cref="DayHeaderFormat"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="DayHeaderFormat"/> property</returns>
		public static readonly DependencyProperty DayHeaderFormatProperty =
			DependencyProperty.Register(
				"DayHeaderFormat",
				typeof(string),
				typeof(RadScheduler),
				new PropertyMetadata("{0:dddd}"));

		/// <summary>
		/// Identifies the <see cref="DayViewDefinition"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="DayViewDefinition"/> property</returns>
		public static readonly DependencyProperty DayViewDefinitionProperty =
			DependencyProperty.Register(
				"DayViewDefinition",
				typeof(DayViewDefinition),
				typeof(RadScheduler),
				new PropertyMetadata(null, DayViewDefinitionChanged));

		/// <summary>
		/// Identifies the <see cref="DayTemplate"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="DayTemplate"/> property</returns>
		public static readonly DependencyProperty DayTemplateProperty =
			DependencyProperty.Register(
				"DayTemplate",
				typeof(ControlTemplate),
				typeof(RadScheduler),
				new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="MonthTemplate"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MonthTemplate"/> property</returns>
		public static readonly DependencyProperty MonthTemplateProperty =
			DependencyProperty.Register(
				"MonthTemplate",
				typeof(ControlTemplate),
				typeof(RadScheduler),
				new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="TimelineTemplate"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="TimelineTemplate"/> property</returns>
		public static readonly DependencyProperty TimelineTemplateProperty =
			DependencyProperty.Register(
				"TimelineTemplate",
				typeof(ControlTemplate),
				typeof(RadScheduler),
				new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="EditAppointmentStyle"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="EditAppointmentStyle"/> property</returns>
		public static readonly DependencyProperty EditAppointmentStyleProperty =
			DependencyProperty.Register("EditAppointmentStyle", typeof(Style), typeof(RadScheduler), null);

		/// <summary>
		/// Identifies the <see cref="NavigationHeaderStyle"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="NavigationHeaderStyle"/> property</returns>
		public static readonly DependencyProperty NavigationHeaderStyleProperty =
			DependencyProperty.Register("NavigationHeaderStyle", typeof(Style), typeof(RadScheduler), null);

		/// <summary>
		/// Identifies the <see cref="TimeRulerHostStyle"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="TimeRulerHostStyle"/> property</returns>
		public static readonly DependencyProperty TimeRulerHostStyleProperty =
			DependencyProperty.Register("TimeRulerHostStyle", typeof(Style), typeof(RadScheduler), null);

		/// <summary>
		/// Identifies the <see cref="FirstDayOfWeek"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="FirstDayOfWeek"/> property</returns>
		public static readonly DependencyProperty FirstDayOfWeekProperty =
			DependencyProperty.Register(
				"FirstDayOfWeek",
				typeof(DayOfWeek?),
				typeof(RadScheduler),
				new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="MonthHeaderFormat"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MonthHeaderFormat"/> property</returns>
		public static readonly DependencyProperty MonthHeaderFormatProperty =
			DependencyProperty.Register(
				"MonthHeaderFormat",
				typeof(string),
				typeof(RadScheduler),
				new PropertyMetadata("{0:dddd}"));

		/// <summary>
		/// Identifies the <see cref="MonthViewDayHeaderDayFormat"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MonthViewDayHeaderDayFormat"/> property</returns>
		public static readonly DependencyProperty MonthViewDayHeaderDayFormatProperty =
			DependencyProperty.Register(
				"MonthViewDayHeaderDayFormat",
				typeof(string),
				typeof(RadScheduler),
				new PropertyMetadata("{0:%d}"));

		/// <summary>
		/// Identifies the <see cref="MonthViewDayHeaderMonthFormat"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MonthViewDayHeaderMonthFormat"/> property</returns>
		public static readonly DependencyProperty MonthViewDayHeaderFormatProperty =
			DependencyProperty.Register(
				"MonthViewDayHeaderMonthFormat",
				typeof(string),
				typeof(RadScheduler),
				new PropertyMetadata("{0:MMMM}"));

		/// <summary>
		/// Identifies the <see cref="MonthViewDefinition"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MonthViewDefinition"/> property</returns>
		public static readonly DependencyProperty MonthViewDefinitionProperty =
			DependencyProperty.Register(
				"MonthViewDefinition",
				typeof(MonthViewDefinition),
				typeof(RadScheduler),
				new PropertyMetadata(null, MonthViewDefinitionChanged));

		/// <summary>
		/// Identifies the <see cref="MonthViewDefinition"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MonthViewDefinition"/> property</returns>
		public static readonly DependencyProperty TimelineViewDefinitionProperty =
			DependencyProperty.Register(
				"TimelineViewDefinition",
				typeof(TimelineViewDefinition),
				typeof(RadScheduler),
				new PropertyMetadata(null, TimelineViewDefinitionChanged));

		/// <summary>
		/// Identifies the <see cref="TimelineHeaderFormat"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="TimelineHeaderFormat"/> property</returns>
		public static readonly DependencyProperty TimelineHeaderFormatProperty =
			DependencyProperty.Register(
				"TimelineHeaderFormat",
				typeof(string),
				typeof(RadScheduler),
				new PropertyMetadata("{0:yyyy-M-d}"));

		/// <summary>
		/// Identifies the <see cref="SelectedAppointment"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedAppointment"/> property</returns>
		public static readonly DependencyProperty SelectedAppointmentProperty =
			DependencyProperty.Register(
				"SelectedAppointment",
				typeof(IAppointment),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedAppointmentChanged));

		/// <summary>
		/// Identifies the <see cref="SelectedAppointments"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedAppointments"/> property</returns>
		public static readonly DependencyProperty SelectedAppointmentsProperty;

		/// <summary>
		/// Identifies the <see cref="ResourceTypes"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="ResourceTypes"/> property</returns>
		public static readonly DependencyProperty ResourceTypesProperty = DependencyProperty.Register(
				"ResourceTypes",
				typeof(ResourceTypeCollection),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

		/// <summary>
		/// Identifies the <see cref="ResourceStyleMappings"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="ResourceStyleMappings"/> property</returns>
		public static readonly DependencyProperty ResourceStyleMappingsProperty = DependencyProperty.Register(
				"ResourceStyleMappings",
				typeof(ResourceStyleMappingCollection),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

		/// <summary>
		/// Identifies the <see cref="SelectedTimeSlot"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedTimeSlot"/> property</returns>
		public static readonly DependencyProperty SelectedTimeSlotProperty =
			DependencyProperty.Register(
				"SelectedTimeSlot",
				typeof(TimeSlot),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

			/// <summary>
		/// Identifies the <see cref="CurrentTimeSlotItemsControl"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="CurrentTimeSlotItemsControl"/> property</returns>
		public static readonly DependencyProperty CurrentTimeSlotItemsControlProperty =
			DependencyProperty.Register(
				"CurrentTimeSlotItemsControl",
				typeof(TimeSlotItemsControl),
				typeof(RadScheduler),
				new PropertyMetadata(null, CurrentTimeSlotItemsControlChanged));
		
		/// <summary>
		/// Identifies the <see cref="SelectedResource"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="SelectedResource"/> property</returns>
		public static readonly DependencyProperty SelectedResourceProperty =
		 DependencyProperty.Register(
			 "SelectedResource",
			 typeof(IResource),
			 typeof(RadScheduler),
			 new FrameworkPropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="ShowsConfirmationWindowOnDelete"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="ShowsConfirmationWindowOnDelete"/> property</returns>
		public static readonly DependencyProperty ShowsConfirmationWindowOnDeleteProperty =
			DependencyProperty.Register(
				"ShowsConfirmationWindowOnDelete",
				typeof(bool),
				typeof(RadScheduler),
				new PropertyMetadata(true));

		/// <summary>
		/// Identifies the <see cref="ShowsConfirmationWindowOnClose"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="ShowsConfirmationWindowOnClose"/> property</returns>
		public static readonly DependencyProperty ShowsConfirmationWindowOnCloseProperty =
			DependencyProperty.Register(
				"ShowsConfirmationWindowOnClose",
				typeof(bool),
				typeof(RadScheduler),
				new PropertyMetadata(false));

		/// <summary>
		/// Identifies the <see cref="IsReadOnly"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsReadOnly"/> property</returns>
		public static readonly DependencyProperty IsReadOnlyProperty =
			DependencyProperty.Register(
				"IsReadOnly",
				typeof(bool),
				typeof(RadScheduler),
				new PropertyMetadata(false));

		/// <summary>
		/// Identifies the <see cref="IsViewModeNavigationEnabled"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsViewModeNavigationEnabled"/> property</returns>
		public static readonly DependencyProperty IsViewModeNavigationEnabledProperty =
			DependencyProperty.Register(
				"IsViewModeNavigationEnabled",
				typeof(bool),
				typeof(RadScheduler),
				new PropertyMetadata(true, OnViewModeNavigationChanged));

		/// <summary>
		/// Identifies the <see cref="IsBackAndForwardNavigationEnabled"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsBackAndForwardNavigationEnabled"/> property</returns>
		public static readonly DependencyProperty IsBackAndForwardNavigationEnabledProperty =
			DependencyProperty.Register(
				"IsBackAndForwardNavigationEnabled",
				typeof(bool),
				typeof(RadScheduler),
				new PropertyMetadata(true, OnIsBackAndForwardNavigationChanged));

		/// <summary>
		/// Identifies the <see cref="CalendarVisibility"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="CalendarVisibility"/> property</returns>
		public static readonly DependencyProperty CalendarVisibilityProperty =
			DependencyProperty.Register(
				"CalendarVisibility",
				typeof(Visibility),
				typeof(RadScheduler),
				new PropertyMetadata(Visibility.Visible));

		/// <summary>
		/// Identifies the <see cref="MonthViewScrollBarVisibility"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="MonthViewScrollBarVisibility"/> property</returns>
		public static readonly DependencyProperty MonthViewScrollBarVisibilityProperty =
			DependencyProperty.Register(
				"MonthViewScrollBarVisibility",
				typeof(Visibility),
				typeof(RadScheduler),
				new PropertyMetadata(Visibility.Visible));

		/// <summary>
		/// Identifies the <see cref="IsInlineEditingEnabled"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsInlineEditingEnabled"/> property</returns>
		public static readonly DependencyProperty IsInlineEditingEnabledProperty =
			DependencyProperty.Register("IsInlineEditingEnabled", typeof(bool), typeof(RadScheduler), new FrameworkPropertyMetadata(true));

		/// <summary>
		/// Identifies the <see cref="ViewMode"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="ViewMode"/> property</returns>
		public static readonly DependencyProperty ViewModeProperty =
			DependencyProperty.Register(
				"ViewMode",
				typeof(SchedulerViewMode),
				typeof(RadScheduler),
				new PropertyMetadata(SchedulerViewMode.Month, OnViewModeChanged));

		/// <summary>
		/// Identifies the <see cref="View"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="View"/> property</returns>
		public static readonly DependencyProperty ViewProperty;

		/// <summary>
		/// Identifies the <see cref="VisibleRangeEnd"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="VisibleRangeEnd"/> property.</returns>
		public static readonly DependencyProperty VisibleRangeEndProperty;

		/// <summary>
		/// Identifies the <see cref="VisibleRangeStart"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="VisibleRangeStart"/> property.</returns>
		public static readonly DependencyProperty VisibleRangeStartProperty;

		/// <summary>
		/// Identifies the <see cref="WeekViewDefinition"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="WeekViewDefinition"/> property</returns>
		public static readonly DependencyProperty WeekViewDefinitionProperty =
			DependencyProperty.Register(
				"WeekViewDefinition",
				typeof(WeekViewDefinition),
				typeof(RadScheduler),
				new PropertyMetadata(null, WeekViewDefinitionChanged));

		/// <summary>
		/// Identifies the <see cref="Categories"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="Categories"/> property.</returns>
		public static readonly DependencyProperty CategoriesProperty =
			  DependencyPropertyExtensions.Register(
				  "Categories",
				  typeof(CategoryCollection),
				  typeof(RadScheduler),
				  new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="TimeFormatString"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="TimeFormatString"/> property.</returns>
		public static readonly DependencyProperty TimeFormatStringProperty =
			DependencyProperty.Register("TimeFormatString", typeof(string), typeof(RadScheduler), new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="RecurrenceChoiceDialogDefaultRecurrenceMode" /> property.
		/// </summary>
		public static readonly DependencyProperty RecurrenceChoiceDialogDefaultRecurrenceModeProperty =
			DependencyProperty.Register("RecurrenceChoiceDialogDefaultRecurrenceMode", typeof(RecurrenceMode), typeof(RadScheduler), new PropertyMetadata(RecurrenceMode.None));

		internal static readonly DependencyPropertyKey SelectedAppointmentsPropertyKey;
		private static readonly DependencyPropertyKey ActiveViewDefinitionPropertyKey;

		private readonly SchedulerAnimation animation;
		private readonly AppointmentCollectionView appointments;
		private const string HeaderElementName = "PART_Header";

		private readonly Dictionary<Occurrence, IAppointmentDialogWindow> appointmentWindows =
			new Dictionary<Occurrence, IAppointmentDialogWindow>();
		private readonly Dictionary<Occurrence, IRecurrenceChoiceDialogWindow> reccWindows =
		  new Dictionary<Occurrence, IRecurrenceChoiceDialogWindow>();

		private readonly SelectedAppointmentCollection selectedAppointments;
		private static readonly DependencyPropertyKey ViewPropertyKey;

		/// <summary>
		/// <see cref="VisibleRangeEnd"/> Read-Only Dependency Property.
		/// </summary>
		private static readonly DependencyPropertyKey VisibleRangeEndPropertyKey;

		/// <summary>
		/// <see cref="VisibleRangeStart"/> Read-Only Dependency Property.
		/// </summary>
		private static readonly DependencyPropertyKey VisibleRangeStartPropertyKey;

		private SchedulerPresenter schedulerPresenter;
		private ResourceGroupsCollection resourceGroupsCollection;
		private bool preventClosing = false;
		private bool isSelectedDateChanged = false;

		static RadScheduler()
		{

            //DefaultStyleKeyProperty.OverrideMetadata(
            //    typeof(RadScheduler),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey { ElementType = typeof(RadScheduler) }));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadScheduler), new FrameworkPropertyMetadata(typeof(RadScheduler)));



			ActiveViewDefinitionPropertyKey = DependencyPropertyExtensions.RegisterReadOnly(
				"ActiveViewDefinition",
				typeof(ViewDefinitionBase),
				typeof(RadScheduler),
				new PropertyMetadata(null, OnActiveViewDefinitionChanged));
			ActiveViewDefinitionProperty = ActiveViewDefinitionPropertyKey.DependencyProperty;

			ViewPropertyKey = DependencyPropertyExtensions.RegisterReadOnly(
				"View", typeof(SchedulerViewModel), typeof(RadScheduler), new PropertyMetadata(null));
			ViewProperty = ViewPropertyKey.DependencyProperty;

			// TODO: investigate further why normal (not attached) DP did not inherit in Day View =>
			// ScrollViewer breaks the inheritance chain
			SelectedAppointmentsPropertyKey = DependencyPropertyExtensions.RegisterAttachedReadOnly(
				"SelectedAppointments",
				typeof(IList<IAppointment>),
				typeof(RadScheduler),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			SelectedAppointmentsProperty = SelectedAppointmentsPropertyKey.DependencyProperty;

			VisibleRangeEndPropertyKey = DependencyPropertyExtensions.RegisterReadOnly(
				"VisibleRangeEnd",
				typeof(DateTime),
				typeof(RadScheduler),
				new PropertyMetadata(DateTime.MinValue));
			VisibleRangeEndProperty = VisibleRangeEndPropertyKey.DependencyProperty;

			VisibleRangeStartPropertyKey = DependencyPropertyExtensions.RegisterReadOnly(
				"VisibleRangeStart",
				typeof(DateTime),
				typeof(RadScheduler),
				new PropertyMetadata(DateTime.MinValue));
			VisibleRangeStartProperty = VisibleRangeStartPropertyKey.DependencyProperty;

			RegisterCommands();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RadScheduler"/> class.
		/// </summary>
		public RadScheduler()
		{
            //TelerikLicense.Verify(this);//禁止验证许可

			////Set correct Language
			this.OnCultureChanged();

			this.WindowFactory = new DialogWindowFactory();

			this.appointments = new AppointmentCollectionView();
			this.DayViewDefinition = new DayViewDefinition();
			this.WeekViewDefinition = new WeekViewDefinition();
			this.MonthViewDefinition = new MonthViewDefinition();
			this.TimelineViewDefinition = new TimelineViewDefinition();

			this.SetActiveViewDefinition();

			this.View = new SchedulerViewModel(this);
			this.View.PropertyChanged += this.OnViewPropertyChanged;
			this.View.IsGrouped = !String.IsNullOrEmpty(this.GroupBy);

			this.VisibleRangeEnd = this.View.VisibleRangeEnd;
			this.VisibleRangeStart = this.View.VisibleRangeStart;

			this.selectedAppointments = new SelectedAppointmentCollection();
			((INotifyPropertyChanged)this.selectedAppointments).PropertyChanged +=
				this.OnSelectedAppointmentCollectionPropertyChanged;
			this.SelectedAppointments = this.selectedAppointments;
			this.SetValue(ResourceTypesProperty, new ResourceTypeCollection());
			this.SetValue(ResourceStyleMappingsProperty, new ResourceStyleMappingCollection());
			this.SetValue(CategoriesProperty, new CategoryCollection());
			this.resourceGroupsCollection = new ResourceGroupsCollection(this.appointments, this);
			//// Note: do not use binding, because if someone else bind to SelectedAppointment this binding will be removed
			//// SetBinding( SelectedAppointmentProperty, new Binding( "SelectedAppointment" ) { Source = selectedAppointments } );
			this.animation = new SchedulerAnimation(this);
		}

		/// <summary>
		/// Occurs when <see cref="ViewMode"/> is changed.
		/// </summary>
		public event EventHandler ActiveViewDefinitionChanged;

		/// <summary>
		/// Occurs when <see cref="GroupBy"/> is changed.
		/// </summary>
		public event EventHandler SchedulerPerformedGrouping;

		/// <summary>
		/// Occurs when <see cref="VisibleRangeStart"/> is changed.
		/// </summary>
		public event EventHandler SelectedViewStartDateChanged;

		/// <summary>
		/// Gets the active view definition - day, week or month depending on <see cref="ViewMode"/>.
		/// </summary>
		/// <value>The active view definition.</value>
		public ViewDefinitionBase ActiveViewDefinition
		{
			get
			{
				return (ViewDefinitionBase)this.GetValue(ActiveViewDefinitionProperty);
			}
			private set
			{
				this.SetValue(ActiveViewDefinitionPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets the all day area min height.
		/// </summary>
		/// <value>The all day area min height.</value>
		public double AllDayAreaHeight
		{
			get
			{
				return (double)GetValue(AllDayAreaHeightProperty);
			}
			set
			{
				SetValue(AllDayAreaHeightProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the Appointments property.
		/// </summary>
		[SRCategory(RadCategory.Common)]
		public AppointmentCollectionView Appointments
		{
			get
			{
				return this.appointments;
			}
		}

		/// <summary>
		/// Gets or sets the AppointmentsSource property. This is a dependency property.
		/// </summary>
		[SRCategory(RadCategory.Common)]
		public IEnumerable AppointmentsSource
		{
			get
			{
				return (IEnumerable)this.GetValue(AppointmentsSourceProperty);
			}
			set
			{
				this.SetValue(AppointmentsSourceProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the AppointmentTemplate property. It defines the look and behavior for each appointment.
		/// The default value is null. This is a dependency property.
		/// </summary>
		public DataTemplate AppointmentTemplate
		{
			get
			{
				return (DataTemplate)this.GetValue(AppointmentTemplateProperty);
			}
			set
			{
				this.SetValue(AppointmentTemplateProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the DragVisualCueTemplate property. It defines the look and behavior for each appointment.
		/// The default value is null. This is a dependency property.
		/// </summary>
		public DataTemplate DragVisualCueTemplate
		{
			get
			{
				return (DataTemplate)this.GetValue(DragVisualCueTemplateProperty);
			}
			set
			{
				this.SetValue(DragVisualCueTemplateProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the AppointmentTemplate property. It defines the look and behavior for each appointment.
		/// The default value is null. This is a dependency property.
		/// </summary>
		public DataTemplateSelector AppointmentTemplateSelector
		{
			get
			{
				return (DataTemplateSelector)this.GetValue(AppointmentTemplateSelectorProperty);
			}
			set
			{
				this.SetValue(AppointmentTemplateSelectorProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the available view modes property.
		/// </summary>
		/// <value>The available view modes property.</value>
		public AvailableViewModes AvailableViewModes
		{
			get { return (AvailableViewModes)GetValue(AvailableViewModesProperty); }
			set { SetValue(AvailableViewModesProperty, value); }
		}

		/// <summary>
		/// Gets or sets the TimeSlotItemTemplate property. It defines the look and behavior for each appointment.
		/// The default value is null. This is a dependency property.
		/// </summary>
		public DataTemplateSelector TimeSlotTemplateSelector
		{
			get
			{
				return (DataTemplateSelector)this.GetValue(TimeSlotTemplateSelectorProperty);
			}
			set
			{
				this.SetValue(TimeSlotTemplateSelectorProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the OpenModalDialogs property. It defines the behavior of dialog windows.
		/// The default value is false. This is a dependency property.
		/// </summary>
		public bool OpenModalDialogs
		{
			get
			{
				return (bool)this.GetValue(OpenModalDialogsProperty);
			}
			set
			{
				this.SetValue(OpenModalDialogsProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the GroupBy property. 
		/// </summary>
		public string GroupBy
		{
			get
			{
				return (string)this.GetValue(GroupByProperty);
			}
			set
			{
				this.SetValue(GroupByProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the DisplayEmptyGroup property. 
		/// </summary>
		public bool DisplayEmptyGroup
		{
			get
			{
				return (bool)this.GetValue(DisplayEmptyGroupProperty);
			}
			set
			{
				this.SetValue(DisplayEmptyGroupProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets time format string to show the time in different formats. Used by controls like <see cref="TimeRuler"/>. This is a dependency property.
		/// </summary>
		/// <returns>The time format <see cref="string"/>. The default value is null.</returns>  
		public string TimeFormatString
		{
			get
			{
				return (string)this.GetValue(TimeFormatStringProperty);
			}
			set
			{
				this.SetValue(TimeFormatStringProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets culture of the scheduler. This is a dependency property.
		/// </summary>
		/// <returns>
		/// Culture info that is used for culture specific operations.
		/// The default value is null (use current culture).
		/// </returns>  
		[Obsolete("This property is obsolete. You can use LocalizationManager.DefaultCulture property to change the culture of RadScheduler")]
		public CultureInfo Culture
		{
			get
			{
				if (LocalizationManager.DefaultCulture != null)
				{
					return GetCulture();
				}
				return (CultureInfo)this.GetValue(CultureProperty);
			}
			set
			{
				this.SetValue(CultureProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the DayHeaderFormat property. The default value is "{0:dddd,}". It's used as format string in String.Format method.
		/// This is a dependency property.
		/// </summary>
		public string DayHeaderFormat
		{
			get
			{
				return (string)this.GetValue(DayHeaderFormatProperty);
			}
			set
			{
				this.SetValue(DayHeaderFormatProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets day view definition. This is a dependency property.
		/// </summary>
		/// <returns>The definition of the day view. The default value is new instance of <see cref="DayViewDefinition"/>.</returns>  
		public DayViewDefinition DayViewDefinition
		{
			get
			{
				return (DayViewDefinition)this.GetValue(DayViewDefinitionProperty);
			}
			set
			{
				this.SetValue(DayViewDefinitionProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets day view template. This is a dependency property.
		/// </summary>
		/// <returns>The template of the day view. The default value is new instance of <see cref="DayViewDefinition"/>.</returns>  
		public ControlTemplate DayTemplate
		{
			get
			{
				return (ControlTemplate)this.GetValue(DayTemplateProperty);
			}
			set
			{
				this.SetValue(DayTemplateProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets month view template. This is a dependency property.
		/// </summary>
		/// <returns>The tempalte of the month view. The default value is new instance of <see cref="MonthTemplate"/>.</returns>  
		public ControlTemplate MonthTemplate
		{
			get
			{
				return (ControlTemplate)this.GetValue(MonthTemplateProperty);
			}
			set
			{
				this.SetValue(MonthTemplateProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets timeline view template. This is a dependency property.
		/// </summary>
		/// <returns>The tempalte of the timeline view. The default value is new instance of <see cref="TimelineTemplate"/>.</returns>  
		public ControlTemplate TimelineTemplate
		{
			get
			{
				return (ControlTemplate)this.GetValue(TimelineTemplateProperty);
			}
			set
			{
				this.SetValue(TimelineTemplateProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the EditAppointmentStyle property. This property allows changing the edit template window for custom 
		/// <see cref="IAppointment"/> implementations. This is a dependency property.
		/// </summary>
		public Style EditAppointmentStyle
		{
			get
			{
				return (Style)this.GetValue(EditAppointmentStyleProperty);
			}
			set
			{
				this.SetValue(EditAppointmentStyleProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the NavigationHeaderStyle property. This property allows changing the header template. This is a dependency property.
		/// </summary>
		public Style NavigationHeaderStyle
		{
			get
			{
				return (Style)this.GetValue(NavigationHeaderStyleProperty);
			}
			set
			{
				this.SetValue(NavigationHeaderStyleProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the TimeRulerStyle property. This property allows changing the header template. This is a dependency property.
		/// </summary>
		public Style TimeRulerHostStyle
		{
			get
			{
				return (Style)this.GetValue(TimeRulerHostStyleProperty);
			}
			set
			{
				this.SetValue(TimeRulerHostStyleProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets calendar info of the scheduler. This is a dependency property.
		/// </summary>
		/// <returns>
		/// Calendar info that is used for calendar operations: first day of week, day names, etc. 
		/// The default value is null.
		/// </returns>  

		public DayOfWeek? FirstDayOfWeek
		{
			get
			{
				return (DayOfWeek?)this.GetValue(FirstDayOfWeekProperty);
			}
			set
			{
				this.SetValue(FirstDayOfWeekProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the MonthHeaderFormat property. The default value "{0:dddd}". It's used as format string in String.Format method.
		/// This is a dependency property.
		/// </summary>
		public string MonthHeaderFormat
		{
			get
			{
				return (string)this.GetValue(MonthHeaderFormatProperty);
			}
			set
			{
				this.SetValue(MonthHeaderFormatProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the MonthViewDayHeaderDayFormat property. The default value is "{0:%d}". It's used as format string in String.Format method.
		/// This is a dependency property.
		/// </summary>
		public string MonthViewDayHeaderDayFormat
		{
			get
			{
				return (string)this.GetValue(MonthViewDayHeaderDayFormatProperty);
			}
			set
			{
				this.SetValue(MonthViewDayHeaderDayFormatProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the MonthViewDayHeaderMonthFormat property. The default value is "{0:MMMM}". It's used as format string in String.Format method.
		/// This is a dependency property.
		/// </summary>
		public string MonthViewDayHeaderMonthFormat
		{
			get
			{
				return (string)this.GetValue(MonthViewDayHeaderFormatProperty);
			}
			set
			{
				this.SetValue(MonthViewDayHeaderFormatProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets month view definition. This is a dependency property.
		/// </summary>
		/// <returns>The definition of the month view. The default value is new instance of <see cref="MonthViewDefinition"/>.</returns>  
		public MonthViewDefinition MonthViewDefinition
		{
			get
			{
				return (MonthViewDefinition)this.GetValue(MonthViewDefinitionProperty);
			}
			set
			{
				this.SetValue(MonthViewDefinitionProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets timeline view definition. This is a dependency property.
		/// </summary>
		/// <returns>The definition of the timeline view. The default value is new instance of <see cref="TimelineViewDefinition"/>.</returns>  
		public TimelineViewDefinition TimelineViewDefinition
		{
			get
			{
				return (TimelineViewDefinition)this.GetValue(TimelineViewDefinitionProperty);
			}
			set
			{
				this.SetValue(TimelineViewDefinitionProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the TimelineHeaderFormat property. The default value "{0:d-M-yyyy}". It's used as format string in String.Format method.
		/// This is a dependency property.
		/// </summary>
		public string TimelineHeaderFormat
		{
			get
			{
				return (string)this.GetValue(TimelineHeaderFormatProperty);
			}
			set
			{
				this.SetValue(TimelineHeaderFormatProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets currently selected appointment. This is a dependency property.
		/// </summary>
		/// <returns>Appointment that is currently selected. The default value is null</returns>  
		public IAppointment SelectedAppointment
		{
			get
			{
				return (IAppointment)this.GetValue(SelectedAppointmentProperty);
			}
			set
			{
				this.SetValue(SelectedAppointmentProperty, value);
			}
		}

		/// <summary>
		/// Gets list with all selected appointments. This is a dependency property.
		/// </summary>
		/// <returns>List with selected appointments. The default value is empty collection.</returns>  
		public IList<IAppointment> SelectedAppointments
		{
			get
			{
				return (IList<IAppointment>)this.GetValue(SelectedAppointmentsProperty);
			}
			private set
			{
				this.SetValue(SelectedAppointmentsPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets or sets the resource types.
		/// </summary>
		/// <value>The resource types.</value>
		public ResourceTypeCollection ResourceTypes
		{
			get
			{
				return (ResourceTypeCollection)this.GetValue(ResourceTypesProperty);
			}
		}

		/// <summary>
		/// Gets or sets the resource style mappings.
		/// </summary>
		/// <value>The resource style mappings.</value>
		public ResourceStyleMappingCollection ResourceStyleMappings
		{
			get
			{
				return (ResourceStyleMappingCollection)this.GetValue(ResourceStyleMappingsProperty);
			}
		}

		/// <summary>
		/// Gets or sets the selected <see cref="TimeSlot"/>. If there are more than one selected time slot, a single time slot is returned
		/// that starts from the first selected time slot and end at the end of the last selected time slot. This is a dependency property.
		/// </summary>
		/// <returns>Currently selected <see cref="TimeSlot"/> if any, otherwise null. The default value is null</returns>  
		public TimeSlot SelectedTimeSlot
		{
			get
			{
				return (TimeSlot)this.GetValue(SelectedTimeSlotProperty);
			}
			set
			{
				this.SetValue(SelectedTimeSlotProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the current time slot items control.
		/// </summary>
		/// <value>The current time slot items control.</value>
		public TimeSlotItemsControl CurrentTimeSlotItemsControl
		{
			get
			{
				return (TimeSlotItemsControl)this.GetValue(CurrentTimeSlotItemsControlProperty);
			}
			set
			{
				this.SetValue(CurrentTimeSlotItemsControlProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the selected <see cref="TimeSlot"/>. If there are more than one selected time slot, a single time slot is returned
		/// that starts from the first selected time slot and end at the end of the last selected time slot. This is a dependency property.
		/// </summary>
		/// <returns>Currently selected <see cref="TimeSlot"/> if any, otherwise null. The default value is null</returns>  
		public IResource SelectedResource
		{
			get
			{
				return (IResource)this.GetValue(SelectedResourceProperty);
			}
			set
			{
				this.SetValue(SelectedResourceProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether confiramtion window should be  displayed.
		/// </summary>
		/// <value><c>True</c> if displays window; otherwise, <c>false</c>.</value>
		public bool ShowsConfirmationWindowOnDelete
		{
			get
			{
				return (bool)this.GetValue(ShowsConfirmationWindowOnDeleteProperty);
			}
			set
			{
				this.SetValue(ShowsConfirmationWindowOnDeleteProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [shows confirmation window on close].
		/// </summary>
		/// <value>
		/// 	<c>True</c> if [shows confirmation window on close]; otherwise, <c>false</c>.
		/// </value>
		public bool ShowsConfirmationWindowOnClose
		{
			get
			{
				return (bool)this.GetValue(ShowsConfirmationWindowOnCloseProperty);
			}
			set
			{
				this.SetValue(ShowsConfirmationWindowOnCloseProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether RadScheduler should be editable.
		/// </summary>
		/// <value><c>True</c> if it is read only; otherwise, <c>false</c>.</value>
		public bool IsReadOnly
		{
			get
			{
				return (bool)this.GetValue(IsReadOnlyProperty);
			}
			set
			{
				this.SetValue(IsReadOnlyProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether RadScheduler should be editable.
		/// </summary>
		/// <value><c>True</c> if it is read only; otherwise, <c>false</c>.</value>
		public bool IsViewModeNavigationEnabled
		{
			get
			{
				return (bool)this.GetValue(IsViewModeNavigationEnabledProperty);
			}
			set
			{
				this.SetValue(IsViewModeNavigationEnabledProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether RadScheduler should be editable.
		/// </summary>
		/// <value><c>True</c> if it is read only; otherwise, <c>false</c>.</value>
		public bool IsBackAndForwardNavigationEnabled
		{
			get
			{
				return (bool)this.GetValue(IsBackAndForwardNavigationEnabledProperty);
			}
			set
			{
				this.SetValue(IsBackAndForwardNavigationEnabledProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="CalendarVisibility"/> property. This is a dependency property.
		/// </summary>
		/// <returns>The <see cref="CalendarVisibility"/>. The default value is Visibility.Visible</returns>  
		public Visibility CalendarVisibility
		{
			get
			{
				return (Visibility)GetValue(CalendarVisibilityProperty);
			}
			set
			{
				SetValue(CalendarVisibilityProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="MonthViewScrollBarVisibility"/> property. This is a dependency property.
		/// </summary>
		/// <returns>The <see cref="MonthViewScrollBarVisibility"/>. The default value is Visibility.Visible</returns>  
		public Visibility MonthViewScrollBarVisibility
		{
			get
			{
				return (Visibility)GetValue(MonthViewScrollBarVisibilityProperty);
			}
			set
			{
				SetValue(MonthViewScrollBarVisibilityProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="IsInlineEditingEnabled"/> property. This is a dependency property.
		/// </summary>
		/// <returns>The <see cref="IsInlineEditingEnabled"/>. The default value is false</returns>  
		public bool IsInlineEditingEnabled
		{
			get
			{
				return (bool)GetValue(IsInlineEditingEnabledProperty);
			}
			set
			{
				SetValue(IsInlineEditingEnabledProperty, value);
			}
		}

		/// <summary>
		/// Gets the View property. The default value is view model created for the scheduler.
		/// This is a dependency property.
		/// </summary>
		public SchedulerViewModel View
		{
			get
			{
				return (SchedulerViewModel)this.GetValue(ViewProperty);
			}
			protected set
			{
				this.SetValue(ViewPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets or sets the ViewMode property. The default value is <see cref="SchedulerViewMode.Month"/>.
		/// This is a dependency property.
		/// </summary>
		public SchedulerViewMode ViewMode
		{
			get
			{
				return (SchedulerViewMode)this.GetValue(ViewModeProperty);
			}
			set
			{
				this.SetValue(ViewModeProperty, value);
			}
		}

		/// <summary>
		/// Gets the VisibleRangeEnd property. This dependency property 
		/// indicates visible end date of the current view.
		/// </summary>
		/// <remarks>
		///		All tasks rendered in the current view will be within the range specified by the <see cref="VisibleRangeStart" />
		///     and <see cref="VisibleRangeEnd" /> properties.
		/// </remarks>
		public DateTime VisibleRangeEnd
		{
			get
			{
				return (DateTime)this.GetValue(VisibleRangeEndProperty);
			}
			protected set
			{
				this.SetValue(VisibleRangeEndPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets the VisibleRangeStart property.  This dependency property 
		/// indicates visible start date of the current view.
		/// </summary>
		/// <remarks>
		///		All tasks rendered in the current view will be within the range specified by the <see cref="VisibleRangeStart" />
		///     and <see cref="VisibleRangeEnd" /> properties.
		/// </remarks>
		public DateTime VisibleRangeStart
		{
			get
			{
				return (DateTime)this.GetValue(VisibleRangeStartProperty);
			}
			protected set
			{
				this.SetValue(VisibleRangeStartPropertyKey, value);
			}
		}

		/// <summary>
		/// Gets or sets week view definition. This is a dependency property.
		/// </summary>
		/// <returns>The definition of the week view. The default value is new instance of <see cref="WeekViewDefinition"/>.</returns>  
		public WeekViewDefinition WeekViewDefinition
		{
			get
			{
				return (WeekViewDefinition)this.GetValue(WeekViewDefinitionProperty);
			}
			set
			{
				this.SetValue(WeekViewDefinitionProperty, value);
			}
		}

		/// <summary>
		/// Gets the resource type models.
		/// </summary>
		/// <value>The resource type models.</value>
		public CategoryCollection Categories
		{
			get
			{
				return (CategoryCollection)this.GetValue(CategoriesProperty);
			}
		}

		/// <summary>
		/// Gets or sets the recurrence choice dialog default recurrence mode.
		/// </summary>
		/// <value>The recurrence choice dialog default recurrence mode.</value>
		public RecurrenceMode RecurrenceChoiceDialogDefaultRecurrenceMode
		{
			get { return (RecurrenceMode)GetValue(RecurrenceChoiceDialogDefaultRecurrenceModeProperty); }
			set { SetValue(RecurrenceChoiceDialogDefaultRecurrenceModeProperty, value); }
		}

		internal SchedulerPresenter SchedulerPresenter
		{
			get
			{
				return this.schedulerPresenter;
			}
		}

		internal ResourceGroupsCollection ResourceGroupsCollection
		{
			get
			{
				return this.resourceGroupsCollection;
			}
		}

		internal bool IsSelectedDateChanged
		{
			get
			{
				return this.isSelectedDateChanged;
			}
			set
			{
				this.isSelectedDateChanged = value;
			}
		}
		internal IDialogWindowFactory WindowFactory { get; set; }

		internal FrameworkElement HeaderElement { get; private set; }

		internal TimeSpan DroppedAppointmentDuration { get; set; }


		/// <summary>
		/// Decreases the visible date with amount specified in <see cref="ViewDefinitionBase.LargeChangeInterval"/>.
		/// </summary>
		public virtual void DecreaseVisibleDateLarge()
		{
			this.isSelectedDateChanged = true;
			this.animation.BeginViewTransitionAnimation(ViewTransitionMode.SlideRight);
			this.View.DecreaseViewDates(this.ActiveViewDefinition.LargeChangeInterval);
		}

		/// <summary>
		/// Decreases the visible date with amount specified in <see cref="ViewDefinitionBase.SmallChangeInterval"/>.
		/// </summary>
		public virtual void DecreaseVisibleDateSmall()
		{
			this.isSelectedDateChanged = true;
			this.View.DecreaseViewDates(this.ActiveViewDefinition.SmallChangeInterval);

		}

		/// <summary>
		/// Increases the visible date with amount specified in <see cref="ViewDefinitionBase.LargeChangeInterval"/>.
		/// </summary>
		public virtual void IncreaseVisibleDateLarge()
		{
			this.isSelectedDateChanged = true;
			this.animation.BeginViewTransitionAnimation(ViewTransitionMode.SlideLeft);

			this.View.IncreaseViewDates(this.ActiveViewDefinition.LargeChangeInterval);
		}

		/// <summary>
		/// Increases the visible date with amount specified in <see cref="ViewDefinitionBase.SmallChangeInterval"/>.
		/// </summary>
		public virtual void IncreaseVisibleDateSmall()
		{
			this.isSelectedDateChanged = true;
			this.View.IncreaseViewDates(this.ActiveViewDefinition.SmallChangeInterval);

		}

		/// <summary>
		/// Sets the first visible date.
		/// </summary>
		/// <param name="firstVisibleDate">The first visible date.</param>
		public virtual void SetFirstVisibleDate(DateTime firstVisibleDate)
		{
			DateTime startDate = firstVisibleDate;
            this.SelectedTimeSlot.Start = firstVisibleDate.Date;
            this.SelectedTimeSlot.End = firstVisibleDate.Date.AddDays(1);
			if (this.ActiveViewDefinition is MonthViewDefinition || this.ActiveViewDefinition is WeekViewDefinition)
			{
				startDate = this.FirstDayOfWeekForVisibleDate(firstVisibleDate);
			}

			this.View.StartDate = startDate;
		}

		/// <summary>
		/// Finds <see cref="SchedulerPresenter"/> in the template.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.schedulerPresenter = this.GetTemplateChild("presenter") as SchedulerPresenter;

			if (this.schedulerPresenter != null)
			{
				this.schedulerPresenter.Template = this.ReturnViewTemplate();
			}
			////Set correct Language
			this.HeaderElement = this.GetTemplateChild(HeaderElementName) as FrameworkElement;
			if (this.HeaderElement != null)
			{
				this.HeaderElement.Style = this.NavigationHeaderStyle;
			}
			this.OnCultureChanged();
			this.SetActiveViewDefinition();

			RadDatePicker datePicker = this.GetTemplateChild("PART_navigationDatePicker") as RadDatePicker;
			if (datePicker != null)
			{
				datePicker.SelectionChanged += this.OnDatePickerSelectionChanged;
				datePicker.Culture = this.GetCultureInUse();
			}
		}

		/// <summary>
		/// Gets the culture in use.
		/// </summary>
		/// <returns></returns>
		public CultureInfo GetCultureInUse()
		{
			var culture = CultureInfo.CurrentCulture;
			if (LocalizationManager.DefaultCulture != null)
			{
				culture = LocalizationManager.DefaultCulture;
			}
			return culture;
		}

		/// <summary>
		/// Gets the first day of week in use.
		/// </summary>
		/// <returns></returns>
		public DayOfWeek GetFirstDayOfWeekInUse()
		{
			return this.FirstDayOfWeek ?? ((IScheduler)this).GetCultureInUse().DateTimeFormat.FirstDayOfWeek;
		}

		/// <summary>
		/// Raises the <see cref="SelectedViewStartDateChanged"/> event.
		/// </summary>
		public virtual void OnSelectedViewStartDateChanged()
		{
			if (this.SelectedViewStartDateChanged != null)
			{
				this.SelectedViewStartDateChanged(this, EventArgs.Empty);
			}
		}

		internal virtual void ShowEditAppointmentDialog(RecurrenceMode reccMode, Occurrence occurrence, AppointmentViewMode mode)
		{
			if (occurrence == null)
			{
				return;
			}
            else if(occurrence.Appointment.IsReadOnly)
                return;

			IAppointmentDialogWindow window;
			if (this.appointmentWindows.TryGetValue(occurrence, out window))
			{
				window.Show();
			}
			else
			{
				IAppointmentDialogWindow dialogWindow = this.WindowFactory.CreateAppointmentDialogWindow();
				DialogWindow dw = dialogWindow as DialogWindow;
				if (dw != null)
				{
					dw.IsModal = this.OpenModalDialogs;
					if (dw.WindowWrapper != null && dw.WindowWrapper.PopupWindow != null)
					{

						dw.WindowWrapper.PopupWindow.Owner = this.ParentOfType<Window>();

						dw.WindowWrapper.PopupWindow.PreviewClosed += this.OnAppointmentWindowPreviewClosed;
					}
				}
				dialogWindow.Scheduler = this;
				dialogWindow.Occurrence = occurrence;
				dialogWindow.Style = this.EditAppointmentStyle;
				dialogWindow.RecurrenceMode = reccMode;
				dialogWindow.ViewMode = mode;
				dialogWindow.AppointmentSaving += this.OnDialogWindowAppointmentSaving;
				dialogWindow.AppointmentSaved += this.OnAppointmentSaved;
				dialogWindow.Closed += this.OnAppointmentWindowClosed;
				dialogWindow.EditParentAppointment += this.OnEditParentAppointment;
				this.appointmentWindows.Add(dialogWindow.Occurrence, dialogWindow);

				dialogWindow.Show();
			}
			this.preventClosing = true;
		}

		/// <summary>
		/// Changes the view template.
		/// </summary>
		/// <returns></returns>
		protected internal ControlTemplate ReturnViewTemplate()
		{
			switch (this.ViewMode)
			{
				case SchedulerViewMode.Day:
					{
						return this.DayTemplate;
					}
				case SchedulerViewMode.Week:
					{
						return this.DayTemplate;
					}
				case SchedulerViewMode.Month:
					{
						return this.MonthTemplate;
					}
				case SchedulerViewMode.Timeline:
					{
						return this.TimelineTemplate;
					}
			}
			return null;
		}

		/// <summary>
		/// Raises the <see cref="ActiveViewDefinition"/> event.
		/// </summary>
		protected virtual void OnActiveViewDefinitionChanged()
		{
			if (this.ActiveViewDefinitionChanged != null)
			{
				this.ActiveViewDefinitionChanged(this, EventArgs.Empty);
			}
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the <see cref="AppointmentsSource"/> property.
		/// </summary>
		protected virtual void OnAppointmentsSourceChanged(DependencyPropertyChangedEventArgs args)
		{
			var sourceCollection = args.NewValue as IEnumerable;
			this.Appointments.SetSourceCollection(sourceCollection);
		}


		/// <summary>
		/// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
		/// </summary>
		/// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			((IThemable)this).ResetTheme();
		}


		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the <see cref="SelectedAppointment"/> property.
		/// </summary>
		protected virtual void OnSelectedAppointmentChanged(DependencyPropertyChangedEventArgs args)
		{
			this.selectedAppointments.SelectedAppointment = args.NewValue as IAppointment;
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the <see cref="ViewMode"/> property.
		/// </summary>
		protected virtual void OnViewModeChanged()
		{
			this.ChangeViewTemplate();
			this.SetActiveViewDefinition();
			this.animation.BeginViewTransitionAnimation(ViewTransitionMode.Fade);
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the <see cref="ViewMode"/> property.
		/// </summary>
		protected virtual void OnIsBackAndForwardNavigationChanged()
		{
			if (!this.IsBackAndForwardNavigationEnabled)
			{
				this.MonthViewScrollBarVisibility = this.CalendarVisibility = Visibility.Collapsed;
			}
			else
			{
				this.MonthViewScrollBarVisibility = this.CalendarVisibility = Visibility.Visible;
			}

		}

		private static CultureInfo GetCulture()
		{
			var culture = LocalizationManager.DefaultCulture;

			if (culture != null && culture.IsNeutralCulture)
			{
				return CultureInfo.CreateSpecificCulture(culture.IetfLanguageTag);
			}

			return culture;
		}

		private static object CoerceCulture(DependencyObject d, object baseValue)
		{
			var culture = baseValue as CultureInfo;

			if (culture != null && culture.IsNeutralCulture)
			{

				LocalizationManager.DefaultCulture = CultureInfo.CreateSpecificCulture(culture.IetfLanguageTag);

				return CultureInfo.CreateSpecificCulture(culture.IetfLanguageTag);

			}
			LocalizationManager.DefaultCulture = culture;

			return culture;
		}

		private static void DayViewDefinitionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var scheduler = (RadScheduler)d;
			if (scheduler.ViewMode == SchedulerViewMode.Day)
			{
				scheduler.OnActiveViewDefinitionChanged();
			}
		}

		private static void MonthViewDefinitionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var scheduler = (RadScheduler)d;
			if (scheduler.ViewMode == SchedulerViewMode.Month)
			{
				scheduler.OnActiveViewDefinitionChanged();
			}
		}

		private static void TimelineViewDefinitionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var scheduler = (RadScheduler)d;
			if (scheduler.ViewMode == SchedulerViewMode.Timeline)
			{
				scheduler.OnActiveViewDefinitionChanged();
			}
		}

		private static void OnActiveViewDefinitionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadScheduler)d).OnActiveViewDefinitionChanged();
		}

		private static void OnAppointmentsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
		{
			((RadScheduler)d).OnAppointmentsSourceChanged(args);
		}

		private static void OnAvailableViewModePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{

		}

		private static void OnCultureChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadScheduler)d).OnCultureChanged();
		}
		private static void OnGroupByChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadScheduler)d).OnGroupByChanged();
		}
		private static void OnDisplayEmptyGroupChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadScheduler)d).OnDisplayEmptyGroupChanged();
		}
		private static void OnSelectedAppointmentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadScheduler)d).OnSelectedAppointmentChanged(e);
		}

		private static void OnViewModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadScheduler)d).OnViewModeChanged();
		}
		private static void OnIsBackAndForwardNavigationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			((RadScheduler)d).OnIsBackAndForwardNavigationChanged();
		}
		private static void OnViewModeNavigationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{

		}
		private static void CurrentTimeSlotItemsControlChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var previousControl = e.OldValue as TimeSlotItemsControl;
			if (previousControl != null)
			{
				foreach (var item in previousControl.TimeSlotItems)
				{
					item.IsDropPossible = false;
				}
			}
		}
		private static void WeekViewDefinitionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var scheduler = (RadScheduler)d;
			if (scheduler.ViewMode == SchedulerViewMode.Week)
			{
				scheduler.OnActiveViewDefinitionChanged();
			}
		}

		private static void DisableButton(Button btn)
		{
			if (btn != null)
			{
				btn.IsEnabled = false;
			}
		}

		private void OnAppointmentWindowPreviewClosed(object sender, WindowPreviewClosedEventArgs e)
		{
			if (this.ShowsConfirmationWindowOnClose && this.preventClosing)
			{
				IAppointmentClosingDialogWindow dw = this.WindowFactory.CreateAppointmentClosingDialogWindow();
				DialogWindow dialogWindow = dw as DialogWindow;
				if (dialogWindow != null)
				{
					dialogWindow.WindowWrapper.PopupWindow.Owner = sender as RadWindow;
					StyleManager.SetTheme(dialogWindow, StyleManager.GetTheme(this));
					dialogWindow.IsModal = this.OpenModalDialogs;
				}
				dw.Confirmed += this.OnAppointmentClosingWindowConfirmed;
				dw.Closed += this.OnAppointmentClosingWindowClosed;
				e.Cancel = true;
				dw.Show();
			}
		}

		private void AddAppointment(IAppointment appointment)
		{
			var addingArgs = new AppointmentAddingEventArgs(AppointmentAddingEvent, this, appointment);
			this.OnAppointmentAdding(addingArgs);

			if (addingArgs.Cancel)
			{
				return;
			}

			this.Appointments.Add(appointment);

			var addedArgs = new AppointmentAddedEventArgs(AppointmentAddedEvent, this, appointment);
			this.OnAppointmentAdded(addedArgs);
		}

		private void CreateAppointment(IDateSpan dateSpan)
		{
			var creatingArgs = new AppointmentCreatingEventArgs(AppointmentCreatingEvent, this);
			this.OnAppointmentCreating(creatingArgs);

			if (creatingArgs.Cancel)
			{
				return;
			}

			IAppointment newAppointment = creatingArgs.NewAppointment ?? this.Appointments.CreateNewAppointment();

			if (newAppointment != null)
			{
				// if there is no predifined start and end for the appointment use the SelectedTimeSlot
				if (dateSpan == null)
				{
					dateSpan = this.SelectedTimeSlot;
				}

				newAppointment.Start = dateSpan.Start;
				newAppointment.End = dateSpan.End;
				if (this.SelectedResource != null)
				{
					newAppointment.Resources.Add(this.SelectedResource);
				}
				var createdArgs = new AppointmentCreatedEventArgs(AppointmentCreatedEvent, this, newAppointment);
				this.OnAppointmentCreated(createdArgs);

				this.ShowEditAppointmentDialog(RecurrenceMode.None, Occurrence.CreateMaster(newAppointment), AppointmentViewMode.Add);
			}
		}

		private void DeleteAppointment(IAppointment appointment)
		{
			var deletingArgs = new AppointmentDeletingEventArgs(AppointmentDeletingEvent, this, appointment);
			this.OnAppointmentDeleting(deletingArgs);

			if (deletingArgs.Cancel)
			{
				return;
			}

			bool isRemoved = this.Appointments.Remove(appointment);

			if (isRemoved)
			{
				if (appointment == this.SelectedAppointment)
				{
					this.SelectedAppointment = null;
				}
				var deletedArgs = new AppointmentDeletedEventArgs(AppointmentDeletedEvent, this, appointment);
				this.OnAppointmentDeleted(deletedArgs);
			}
		}

		private void DeleteAppointmentOccurence(Occurrence occurrence)
		{
			if (occurrence == null)
			{
				IAppointment selectedAppointment = this.SelectedAppointment;
				if (selectedAppointment != null)
				{
					occurrence = Occurrence.CreateMaster(selectedAppointment);
				}
			}

			if (occurrence == null)
			{
				return;
			}

			switch (occurrence.State)
			{
				case RecurrenceState.Master:
					if (this.ShowsConfirmationWindowOnDelete)
					{
						this.ShowDeleteDialogWindow(occurrence);
					}
					else
					{
						this.DeleteAppointment(occurrence.Master);
					}
					break;
				case RecurrenceState.Occurrence:
				case RecurrenceState.Exception:
					if (this.ShowsConfirmationWindowOnDelete)
					{
						this.ShowRecurrenceChoiceDialogWindow(occurrence, true);
					}
					else
					{
						this.DeleteOccurrenceFromRecurrentAppointment(this.RecurrenceChoiceDialogDefaultRecurrenceMode, occurrence);
					}
					break;
			}
		}

		private void EditAppointmentOccurence(Occurrence occurrence)
		{
			if (occurrence == null)
			{
				IAppointment selectedAppointment = this.SelectedAppointment;
				if (selectedAppointment != null)
				{
					occurrence = Occurrence.CreateMaster(selectedAppointment);
				}
			}

            if (occurrence == null)
            {
                return;
            }
            else
            {
                //Add By Ben 2015-11-12
                if (occurrence.State == RecurrenceState.Occurrence)
                    return;
            }

			if (occurrence.Appointment.IsRecurring())
			{
				this.OpenOcurrenceFromRecurrentAppointment(this.RecurrenceChoiceDialogDefaultRecurrenceMode, occurrence);
			}
			else
			{
				this.RaiseAppointmentEditingAndShowDialog(RecurrenceMode.None, occurrence, AppointmentViewMode.Edit);
			}
		}

		private void EndAppointmentEdit(IAppointment appointment, ExceptionAction exceptionAction, Occurrence occurence)
		{
			var editedArgs = new AppointmentEditedEventArgs(AppointmentEditedEvent, this, appointment);

			editedArgs.ExceptionAction = exceptionAction;
			editedArgs.ExceptionOccurrence = occurence;

			this.OnAppointmentEdited(editedArgs);
		}

		private void OnAppointmentDeleteWindowClosed(object sender, RoutedEventArgs e)
		{
			var window = (IAppointmentDeleteDialogWindow)sender;
			window.Closed -= this.OnAppointmentDeleteWindowClosed;
			window.Confirmed -= this.OnAppointmentDeleteWindowConfirmed;
		}

		private void OnAppointmentDeleteWindowConfirmed(object sender, RoutedEventArgs e)
		{
			var window = (IAppointmentDeleteDialogWindow)sender;
			window.Close();

			Occurrence occurrence = window.Occurrence;
			this.DeleteAppointment(occurrence.Master);
		}

		private void OnAppointmentClosingWindowClosed(object sender, RoutedEventArgs e)
		{
			var window = (IAppointmentClosingDialogWindow)sender;
			window.Closed -= this.OnAppointmentClosingWindowClosed;
			window.Confirmed -= this.OnAppointmentClosingWindowConfirmed;
		}

		private void OnAppointmentClosingWindowConfirmed(object sender, RoutedEventArgs e)
		{
			var window = (DialogWindow)sender;
			window.Close();
			this.preventClosing = false;
			var parentWindow = window.WindowWrapper.PopupWindow.Owner as RadWindow;
			if (parentWindow != null)
			{
				parentWindow.Close();
			}
		}

		private void OnAppointmentSaved(object sender, RoutedEventArgs e)
		{
			var window = (IAppointmentDialogWindow)sender;

			if (window.ViewMode == AppointmentViewMode.Add)
			{
				Occurrence occurrence = window.Occurrence;
				if (occurrence.State == RecurrenceState.Exception)
				{
					occurrence.Master.RecurrenceRule.AddException(occurrence.Start, occurrence.Exception);

					this.EndAppointmentEdit(window.Occurrence.Appointment, ExceptionAction.Add, occurrence);
				}
				else
				{
					this.AddAppointment(occurrence.Master);
				}
			}
			else if (window.ViewMode == AppointmentViewMode.Edit)
			{
				Occurrence occurrence = window.Occurrence;
				if (occurrence.State == RecurrenceState.Exception)
				{
					occurrence.Master.RecurrenceRule.ReplaceExceptionOccurrence(occurrence.Exception);
					this.EndAppointmentEdit(occurrence.Appointment, ExceptionAction.Edit, occurrence);
				}
				else
				{
					this.EndAppointmentEdit(occurrence.Appointment, ExceptionAction.None, occurrence);
				}
			}

			window.AppointmentSaved -= this.OnAppointmentSaved;
			window.EditParentAppointment -= this.OnEditParentAppointment;
			this.preventClosing = false;
			window.Close();

		}

		private void OnAppointmentWindowClosed(object sender, RoutedEventArgs e)
		{
			if (this.ShowsConfirmationWindowOnClose && this.preventClosing)
			{
				return;
			}
			var window = (IAppointmentDialogWindow)sender;

			window.Closed -= this.OnAppointmentWindowClosed;
			var dw = window as DialogWindow;
			if (dw != null)
			{
				dw.WindowWrapper.PopupWindow.PreviewClosed -= this.OnAppointmentWindowPreviewClosed;
			}
			Debug.Assert(
				this.appointmentWindows.ContainsKey(window.Occurrence),
				"AppointmentWindows should contains Occurrence");
			this.appointmentWindows.Remove(window.Occurrence);
		}
		private void OnDisplayEmptyGroupChanged()
		{
			this.GroupScheduler();
		}
		private void OnGroupByChanged()
		{
			this.GroupScheduler();
			if (this.SchedulerPerformedGrouping != null)
			{
				this.SchedulerPerformedGrouping(this, EventArgs.Empty);
			}
			this.View.IsGrouped = !String.IsNullOrEmpty(this.GroupBy);
		}

		private void GroupScheduler()
		{
			this.ResourceGroupsCollection.RecreateGroups(true);
		}

		private void OnCultureChanged()
		{
			CultureInfo culture = ((IScheduler)this).GetCultureInUse();

			if (culture != null && culture.IsNeutralCulture)
			{

				LocalizationManager.DefaultCulture = CultureInfo.CreateSpecificCulture(culture.IetfLanguageTag);
				culture = LocalizationManager.DefaultCulture;

			}

			this.Language = XmlLanguage.GetLanguage(culture.IetfLanguageTag);

			if (this.View != null)
			{
				this.View.InvalidateDisplayInterval();
			}
		}

		private void OnDialogWindowAppointmentSaving(object sender, RoutedEventArgs args)
		{
			var dialogWindowSavingArgs = args as AppointmentSavingEventArgs;

			if (dialogWindowSavingArgs != null)
			{
				var schedulerSavingArgs = new AppointmentSavingEventArgs(
					AppointmentSavingEvent, dialogWindowSavingArgs.OriginalSource, dialogWindowSavingArgs.Appointment);
				this.OnAppointmentSaving(schedulerSavingArgs);
				dialogWindowSavingArgs.Cancel = schedulerSavingArgs.Cancel;
			}
		}

		private void OnEditParentAppointment(object sender, RoutedEventArgs e)
		{
			var window = (IAppointmentDialogWindow)sender;
			Occurrence occurrence = Occurrence.CreateMaster(window.Occurrence.Master);

			window.AppointmentSaved -= this.OnAppointmentSaved;
			window.EditParentAppointment -= this.OnEditParentAppointment;

			window.Close();

			this.ShowEditAppointmentDialog(RecurrenceMode.None, occurrence, AppointmentViewMode.Edit);
		}

		private void OnRecurrenceChoiceWindowClosed(object sender, RoutedEventArgs e)
		{
			var window = (IRecurrenceChoiceDialogWindow)sender;
			this.reccWindows.Remove(window.Occurrence);
			window.Closed -= this.OnRecurrenceChoiceWindowClosed;
			window.Confirmed -= this.OnRecurrenceChoiceWindowConfirmed;
		}

		private void OnRecurrenceChoiceWindowConfirmed(object sender, RoutedEventArgs e)
		{
			var window = (IRecurrenceChoiceDialogWindow)sender;
			RecurrenceMode mode = window.SelectedMode;
			window.Close();

			Occurrence occurrence = window.Occurrence;
			if (window.IsDeleting)
			{
				this.DeleteOccurrenceFromRecurrentAppointment(mode, occurrence);
			}
			else
			{
				this.OpenOcurrenceFromRecurrentAppointment(mode, occurrence);
			}
			this.reccWindows.Remove(occurrence);
		}

		private void OpenOcurrenceFromRecurrentAppointment(RecurrenceMode mode, Occurrence occurrence)
		{
			if (mode == RecurrenceMode.None)
			{
				this.ShowRecurrenceChoiceDialogWindow(occurrence, false);
			}
			if (mode == RecurrenceMode.Series)
			{
				occurrence = Occurrence.CreateMaster(occurrence.Master);
				this.RaiseAppointmentEditingAndShowDialog(mode, occurrence, AppointmentViewMode.Edit);
			}
			else if (mode == RecurrenceMode.Occurrence && occurrence.State == RecurrenceState.Occurrence)
			{
				IAppointment appException = occurrence.Master.Copy();
				appException.Start = occurrence.Start;
				appException.End = occurrence.End;
				appException.RecurrenceRule = null;

				occurrence = Occurrence.CreateException(occurrence.Master, appException);

				this.RaiseAppointmentEditingAndShowDialog(mode, occurrence, AppointmentViewMode.Add);
			}
		}

		private void DeleteOccurrenceFromRecurrentAppointment(RecurrenceMode mode, Occurrence occurrence)
		{
			if (mode == RecurrenceMode.Series)
			{
				this.DeleteAppointment(occurrence.Master);
			}
			else if (mode == RecurrenceMode.Occurrence)
			{
				var appointmentEditingArgs = new AppointmentEditingEventArgs(AppointmentEditingEvent, this, occurrence.Appointment);
				appointmentEditingArgs.ExceptionOccurrence = occurrence;
				if (occurrence.State == RecurrenceState.Occurrence)
				{
					appointmentEditingArgs.ExceptionAction = ExceptionAction.Add;
				}
				else
				{
					appointmentEditingArgs.ExceptionAction = ExceptionAction.Delete;
				}
				this.OnAppointmentEditing(appointmentEditingArgs);

				if (!appointmentEditingArgs.Cancel)
				{
					if (occurrence.State == RecurrenceState.Occurrence)
					{
						occurrence.Master.RecurrenceRule.AddException(occurrence.Start);
						this.EndAppointmentEdit(occurrence.Appointment, ExceptionAction.Add, occurrence);
					}
					else
					{
						occurrence.Master.RecurrenceRule.RemoveException(occurrence.Exception);
						this.EndAppointmentEdit(occurrence.Appointment, ExceptionAction.Delete, occurrence);
					}
				}
			}
			this.SelectedAppointments.Clear();
		}

		private void OnSelectedAppointmentCollectionPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "SelectedAppointment")
			{
				this.SelectedAppointment = this.selectedAppointments.SelectedAppointment;
			}
		}

		private void OnViewPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "VisibleRangeStart")
			{
				this.VisibleRangeStart = this.View.VisibleRangeStart;
			}

			if (e.PropertyName == "VisibleRangeEnd")
			{
				this.VisibleRangeEnd = this.View.VisibleRangeEnd;
			}
		}

		private void RaiseAppointmentEditingAndShowDialog(RecurrenceMode mode, Occurrence occurrence, AppointmentViewMode viewMode)
		{
			var editingArgs = new AppointmentEditingEventArgs(AppointmentEditingEvent, this, occurrence.Appointment);
			if (occurrence.State == RecurrenceState.Exception)
			{
				editingArgs.ExceptionOccurrence = occurrence;
				editingArgs.ExceptionAction = viewMode == AppointmentViewMode.Add ? ExceptionAction.Add : ExceptionAction.Edit;
			}
			this.OnAppointmentEditing(editingArgs);

			if (!editingArgs.Cancel)
			{
				this.ShowEditAppointmentDialog(mode, occurrence, viewMode);
			}
		}

		private void SetActiveViewDefinition()
		{

			switch (this.ViewMode)
			{
				case SchedulerViewMode.Day:
					{

						this.ActiveViewDefinition = this.DayViewDefinition;
						break;
					}
				case SchedulerViewMode.Week:
					{

						this.ActiveViewDefinition = this.WeekViewDefinition;
						break;
					}
				case SchedulerViewMode.Month:
					{

						this.ActiveViewDefinition = this.MonthViewDefinition;
						break;
					}
				case SchedulerViewMode.Timeline:
					{

						this.ActiveViewDefinition = this.TimelineViewDefinition;
						break;
					}
				default:
					{
						Debug.Assert(false, "Invalid SchedulerViewMode: " + this.ViewMode);
						break;
					}
			}
		}

		private void ShowDeleteDialogWindow(Occurrence occurrence)
		{
			if (occurrence == null)
			{
				return;
			}
			IAppointmentDeleteDialogWindow dw = this.WindowFactory.CreateAppointmentDeleteDialogWindow();
			DialogWindow dialogWindow = dw as DialogWindow;
			if (dialogWindow != null)
			{
				StyleManager.SetTheme(dialogWindow, StyleManager.GetTheme(this));
				dialogWindow.IsModal = this.OpenModalDialogs;
			}
			dw.Occurrence = occurrence;
			dw.Confirmed += this.OnAppointmentDeleteWindowConfirmed;
			dw.Closed += this.OnAppointmentDeleteWindowClosed;
			dw.Show();
		}

		private void ShowRecurrenceChoiceDialogWindow(Occurrence occurrence, bool isDeleting)
		{
			if (occurrence == null)
			{
				return;
			}
			IRecurrenceChoiceDialogWindow window;
			if (this.reccWindows.TryGetValue(occurrence, out window))
			{
				window.Show();
			}
			else
			{
				IRecurrenceChoiceDialogWindow dw = this.WindowFactory.CreateRecurrenceChoiceDialogWindow();
				DialogWindow dialogWindow = dw as DialogWindow;
				if (dialogWindow != null)
				{
					StyleManager.SetTheme(dialogWindow, StyleManager.GetTheme(this));
					dialogWindow.IsModal = this.OpenModalDialogs;
				}
				dw.Occurrence = occurrence;
				dw.IsDeleting = isDeleting;
				dw.Confirmed += this.OnRecurrenceChoiceWindowConfirmed;
				dw.Closed += this.OnRecurrenceChoiceWindowClosed;
				this.reccWindows.Add(occurrence, dw);
				dw.Show();
			}
		}


		private void OnDatePickerSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var radDatePicker = sender as RadDatePicker;
			if (radDatePicker != null && radDatePicker.SelectedDate != null)
			{
				if (!this.isSelectedDateChanged)
				{
                    DateTime newDate = ((DateTime)e.AddedItems[0]).Date;
                    
                    DateTime newSelectedTimeSlotStart = this.SelectedTimeSlot.Start.AddDays((newDate - this.SelectedTimeSlot.Start.Date).Days);
                    DateTime newSelectedTimeSlotEnd = this.SelectedTimeSlot.End.AddDays((newDate - this.SelectedTimeSlot.End.Date).Days);

                    var newTimeSlot = new TimeSlot();

                    if (newSelectedTimeSlotEnd >= newSelectedTimeSlotStart)
                    {
                        newTimeSlot = new TimeSlot(newSelectedTimeSlotStart, newSelectedTimeSlotEnd);
                        if (newTimeSlot.Duration() == TimeSpan.Zero)
                        {
                            newTimeSlot.End = newTimeSlot.End.Add(this.ActiveViewDefinition.TimeSlotLength);
                        }
                    }
                    else
                    {
                        newSelectedTimeSlotEnd = newSelectedTimeSlotStart.Add(this.ActiveViewDefinition.TimeSlotLength);
                        newTimeSlot = new TimeSlot(newSelectedTimeSlotStart, newSelectedTimeSlotEnd);
                    }
                    
                    this.SelectedTimeSlot = newTimeSlot;
                    this.View.StartDate = this.View.GetStartDateForViewDefinition(this.ActiveViewDefinition, newDate);
				}
				this.isSelectedDateChanged = false;
			}
		}

		private void ChangeViewTemplate()
		{
			if (this.schedulerPresenter != null)
			{
				this.schedulerPresenter.Template = this.ReturnViewTemplate();
			}
		}

        public void ScrollVerticalOffsetToTimeSpan(DateTime time)
        {
            if (this.schedulerPresenter != null)
            {
                this.schedulerPresenter.ScrollVerticalOffset(TimeSpan.Parse(time.ToString("HH:mm")));
            }
        }
	}
}
