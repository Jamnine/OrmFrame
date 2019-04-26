using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;
//using Orm.Toolkit.Telerik.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{

    using RadRoutedEventArgs = RoutedEventArgs;
    using RadRoutedEventHandler = RoutedEventHandler;

    /// <summary>
    /// A dialog window for adding and editing appointment.
    /// </summary>
    [TemplateVisualState(Name = "RecurrenceRuleIsNull", GroupName = "RecurrenceRuleState")]
    [TemplateVisualState(Name = "RecurrenceRuleIsNotNull", GroupName = "RecurrenceRuleState")]
    public class AppointmentDialogWindow : SchedulerWindow, IAppointmentDialogWindow
    { 
        /// <summary>
        /// Identifies the <see cref="AppointmentSaved"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentSaved"/> event.</returns>
        public static readonly RoutedEvent AppointmentSavedEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentSaved",
                RoutingStrategy.Direct,
                typeof(RoutedEventHandler),
                typeof(AppointmentDialogWindow));

        /// <summary>
        /// Identifies the <see cref="AppointmentSaving"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentSaving"/> event.</returns>
        public static readonly RoutedEvent AppointmentSavingEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentSaving",
                RoutingStrategy.Direct,
                typeof(EventHandler<AppointmentSavingEventArgs>),
                typeof(AppointmentDialogWindow));

        /// <summary>
        /// Identifies the <see cref="EditedAppointment"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="EditedAppointment"/> property.</returns>
        public static readonly DependencyProperty EditedAppointmentProperty;

        /// <summary>
        /// Identifies the <see cref="ResourceTypeModels"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="ResourceTypeModels"/> property.</returns>
        public static readonly DependencyProperty ResourceTypeModelsProperty;

		/// <summary>
		/// Identifies the <see cref="ResourceTypesVisibility"/> property.
		/// </summary>
		public static readonly DependencyProperty ResourceTypesVisibilityProperty =
      DependencyPropertyExtensions.Register(
		  "ResourceTypesVisibility",
		  typeof(Visibility),
          typeof(AppointmentDialogWindow),
          new PropertyMetadata(Visibility.Visible));

        /// <summary>
        /// Identifies the <see cref="TimeMarker"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeMarker"/> property.</returns>
        public static readonly DependencyProperty TimeMarkerProperty =
      DependencyPropertyExtensions.Register(
          "TimeMarker",
          typeof(TimeMarker),
          typeof(AppointmentDialogWindow),
          new PropertyMetadata());

        /// <summary>
        /// Identifies the <see cref="Categories"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Categories"/> property.</returns>
        public static readonly DependencyProperty CategoriesProperty =
  DependencyPropertyExtensions.Register(
      "Categories",
      typeof(IList<Category>),
      typeof(AppointmentDialogWindow),
      new PropertyMetadata(null));

        /// <summary>
        /// Identifies the <see cref="TimeMarkers"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeMarkers"/> property.</returns>
        public static readonly DependencyProperty TimeMarkersProperty =
DependencyPropertyExtensions.Register(
   "TimeMarkers",
   typeof(IList<TimeMarker>),
   typeof(AppointmentDialogWindow),
   new PropertyMetadata(null));

        /// <summary>
        /// Identifies the <see cref="Category"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Category"/> property.</returns>
        public static readonly DependencyProperty CategoryProperty =
    DependencyPropertyExtensions.Register(
        "Category",
        typeof(Category),
        typeof(AppointmentDialogWindow),
        new PropertyMetadata(null));

        /// <summary>
        /// Identifies the <see cref="EditParentAppointment"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="EditParentAppointment"/> event.</returns>
        public static readonly RoutedEvent EditParentAppointmentEvent =
            EventManager.RegisterRoutedEvent(
                "EditParentAppointment",
                RoutingStrategy.Direct,
                typeof(RoutedEventHandler),
                typeof(AppointmentDialogWindow));

        /// <summary>
        /// Identifies the <see cref="Occurrence"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Occurrence"/> property.</returns>
        public static readonly DependencyProperty OccurrenceProperty =
            DependencyProperty.Register(
                "Occurrence",
                typeof(Occurrence),
                typeof(AppointmentDialogWindow),
                new PropertyMetadata(null, OnOccurrenceChanged));

        /// <summary>
        /// Identifies the <see cref="ViewMode"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="ViewMode"/> property.</returns>
        public static readonly DependencyProperty ViewModeProperty =
            DependencyProperty.Register(
                "ViewMode",
                typeof(AppointmentViewMode),
                typeof(AppointmentDialogWindow),
                new PropertyMetadata(AppointmentViewMode.Add));

        private static readonly DependencyPropertyKey EditedAppointmentPropertyKey;
        private static readonly DependencyPropertyKey ResourceTypeModelsPropertyKey;

        static AppointmentDialogWindow()
        {


            CommandManager.RegisterClassCommandBinding(
                typeof(AppointmentDialogWindow),
                new CommandBinding(RadSchedulerCommands.SaveAppointment, OnSaveAppointmentCommand, OnQuerySaveAppointmentCommand));

            CommandManager.RegisterClassCommandBinding(
                typeof(AppointmentDialogWindow),
                new CommandBinding(RadSchedulerCommands.EditRecurrenceRule, OnEditRecurrenceCommand, OnQueryEditRecurrenceCommand));

            CommandManager.RegisterClassCommandBinding(
                typeof(AppointmentDialogWindow),
                new CommandBinding(RadSchedulerCommands.EditParentAppointment, OnEditParentAppointmentCommand, OnQueryEditParentAppointmentCommand));

            CommandManager.RegisterClassCommandBinding(
          typeof(AppointmentDialogWindow),
          new CommandBinding(RadSchedulerCommands.ChangeTimePickersVisibility, ChangeTimePickersVisibilityCommand));

            CommandManager.RegisterClassCommandBinding(
       typeof(AppointmentDialogWindow),
       new CommandBinding(RadSchedulerCommands.SetAppointmentImportance, SetAppointmentImportanceCommand));

            EditedAppointmentPropertyKey =
                DependencyPropertyExtensions.RegisterReadOnly(
                    "EditedAppointment",
                    typeof(IAppointment),
                    typeof(AppointmentDialogWindow),
                    new PropertyMetadata());
            EditedAppointmentProperty = EditedAppointmentPropertyKey.DependencyProperty;

            ResourceTypeModelsPropertyKey =
         DependencyPropertyExtensions.RegisterReadOnly(
             "ResourceTypeModels",
             typeof(ResourceTypeViewModelCollection),
             typeof(AppointmentDialogWindow),
             new PropertyMetadata());
             ResourceTypeModelsProperty = ResourceTypeModelsPropertyKey.DependencyProperty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentDialogWindow"/> class.
        /// </summary>
        public AppointmentDialogWindow()
        {
         
            this.DataContext = this;

            this.TimeMarkers = Telerik.Windows.Controls.Scheduler.TimeMarkers.AllTimeMarkers;
            this.WindowWrapper.PopupWindow.SetBinding(RadWindow.HeaderProperty, new Binding("Occurrence") { Source = this });
        }

        /// <summary>
        /// Occurs when the appointment is  saved.
        /// </summary>
        public event RoutedEventHandler AppointmentSaved
        {
            add
            {
                this.AddHandler(AppointmentSavedEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentSavedEvent, value);
            }
        }

        /// <summary>
        /// Occurs before the appointment is saved.
        /// </summary>
        public event EventHandler<AppointmentSavingEventArgs> AppointmentSaving
        {
            add
            {
                this.AddHandler(AppointmentSavingEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentSavingEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the parent appointment is edited.
        /// </summary>
        public event RoutedEventHandler EditParentAppointment
        {
            add
            {
                this.AddHandler(EditParentAppointmentEvent, value);
            }
            remove
            {
                this.RemoveHandler(EditParentAppointmentEvent, value);
            }
        }

        /// <summary>
        /// Gets the EditedAppointment property. This property contains the a copy of the appointment the real appointment 
        /// that is being edited. Use this property for binding in XAML. This is a dependency property.
        /// </summary>
        public IAppointment EditedAppointment
        {
            get
            {
                return (IAppointment)this.GetValue(EditedAppointmentProperty);
            }
            protected set
            {
                this.SetValue(EditedAppointmentPropertyKey, value);
            }
        }

        /// <summary>
        /// Gets the resource type models.
        /// </summary>
        /// <value>The resource type models.</value>
        public ResourceTypeViewModelCollection ResourceTypeModels
        {
            get
            {
                return (ResourceTypeViewModelCollection)this.GetValue(ResourceTypeModelsProperty);
            }
            private set
            {
                this.SetValue(ResourceTypeModelsPropertyKey, value);
            }
        }

		/// <summary>
		/// Gets the resource type models.
		/// </summary>
		/// <value>The resource type models.</value>
		public Visibility ResourceTypesVisibility
		{
			get
			{
				return (Visibility)this.GetValue(ResourceTypesVisibilityProperty);
			}
			 set
			{
				this.SetValue(ResourceTypesVisibilityProperty, value);
			}
		}

        /// <summary>
        /// Gets the resource type models.
        /// </summary>
        /// <value>The resource type models.</value>
        public IList<Category> Categories
        {
            get
            {
                return (IList<Category>)this.GetValue(CategoriesProperty);
            }
            internal set
            {
                this.SetValue(CategoriesProperty, value);
            }
        }

        /// <summary>
        /// Gets the resource type models.
        /// </summary>
        /// <value>The resource type models.</value>
        public IList<TimeMarker> TimeMarkers
        {
            get
            {
                return (IList<TimeMarker>)this.GetValue(TimeMarkersProperty);
            }
            internal set
            {
                this.SetValue(TimeMarkersProperty, value);
            }
        }

        /// <summary>
        /// Gets the resource type models.
        /// </summary>
        /// <value>The resource type models.</value>
        public TimeMarker TimeMarker
        {
            get
            {
                return (TimeMarker)this.GetValue(TimeMarkerProperty);
            }
            set
            {
                this.SetValue(TimeMarkerProperty, value);
            }
        }

        /// <summary>
        /// Gets the resource type models.
        /// </summary>
        /// <value>The resource type models.</value>
        public Category Category
        {
            get
            {
                return (Category)this.GetValue(CategoryProperty);
            }
            set
            {
                this.SetValue(CategoryProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the Occurrence property. The default value is null.
        /// This is a dependency property.
        /// </summary>
        public Occurrence Occurrence
        {
            get
            {
                return (Occurrence)this.GetValue(OccurrenceProperty);
            }
            set
            {
                this.SetValue(OccurrenceProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the view mode of the window. This is a dependency property.
        /// </summary>
        /// <returns>The current view mode of the window. The default value is <see cref="AppointmentViewMode.Add"/>.</returns>  
        public AppointmentViewMode ViewMode
        {
            get
            {
                return (AppointmentViewMode)this.GetValue(ViewModeProperty);
            }
            set
            {
                this.SetValue(ViewModeProperty, value);
            }
        }

        Style IAppointmentDialogWindow.Style
        {
            get
            {
                return this.Style;
            }
            set
            {
                this.Style = value;
            }
        }

		/// <summary>
		/// Gets or sets the recurrence mode.
		/// </summary>
		/// <value>The recurrence mode.</value>
		public RecurrenceMode RecurrenceMode
		{
			get;
			set;
		}

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
		
            RadContextMenu menu = this.GetChildByName("PART_categoryMenu") as RadContextMenu;
            if (menu != null)
            {

                menu.ItemClick += this.MenuItemClick;

                menu.ClickToOpen = true;
            }

			RadComboBox timeMarker = this.GetChildByName("PART_TimeMarkers") as RadComboBox;
			if (timeMarker != null)
			{
				timeMarker.ClearSelectionButtonContent = LocalizationManager.GetString("Clear");
			}
            RadScheduler scheduler = Scheduler as RadScheduler;
			if (scheduler != null && !String.IsNullOrEmpty(scheduler.GroupBy) && this.RecurrenceMode == RecurrenceMode.Occurrence)
			{
				this.ResourceTypesVisibility = Visibility.Collapsed;
			}
            var appointment = this.EditedAppointment as AppointmentBase;
            if (appointment != null)
            {
                if (appointment.TimeMarker != null)
                {
                    this.TimeMarker = this.TimeMarkers.SingleOrDefault(tm => tm.TimeMarkerName == appointment.TimeMarker.TimeMarkerName);
                }
                if (appointment.Category != null)
                {
                    this.Category = appointment.Category;
                }
            }
            if (scheduler != null)
            {
                if (this.Categories == null)
                {
                    if (scheduler.Categories != null && scheduler.Categories.Count > 0)
                    {
                        this.Categories = scheduler.Categories;
                    }
                    else
                    {
                        this.Categories = Telerik.Windows.Controls.Scheduler.Categories.AllCategories;
                    }
                }
                this.ResourceTypeModels = new ResourceTypeViewModelCollection();
                foreach (var resourceType in scheduler.ResourceTypes)
                {
                    this.ResourceTypeModels.Add(new ResourceTypeViewModel(resourceType, this.EditedAppointment));
                }
            }

            this.ConfigureDateTimePickers();
            this.ConfigureButtons();
        }

        /// <summary>
        /// Updates the visual state of the control.
        /// </summary>
        /// <param name="useTransitions">Indicates whether transitions should be used.</param>
        protected internal virtual void ChangeVisualState(bool useTransitions)
        {

        }

        /// <summary>
        /// Called when <see cref="RadSchedulerCommands.SaveAppointment"/> command gets executed.
        /// </summary>
        protected virtual void OnAppointmentSaved()
        {
            var appointment = this.EditedAppointment as AppointmentBase;
            if (appointment != null)
            {
                appointment.TimeMarker = this.TimeMarker;
                appointment.Category = this.Category;
            }
            this.Occurrence.Appointment.CopyFrom(this.EditedAppointment);

            this.RaiseEvent(new RadRoutedEventArgs(AppointmentSavedEvent, this));
        }

        /// <summary>
        /// Called when <see cref="RadSchedulerCommands.SaveAppointment"/> command gets executed.
        /// </summary>
        protected virtual void OnAppointmentResourceAdded()
        {
            Button editReccBtn = this.GetTemplateChild("EditRecurrenceRuleBtn") as Button;
        }

        /// <summary>
        /// Called when <see cref="RadSchedulerCommands.EditParentAppointment"/> command gets executed.
        /// </summary>
        protected virtual void OnEditParentAppointment()
        {
            this.RaiseEvent(new RadRoutedEventArgs(EditParentAppointmentEvent, this));
        }

        /// <summary>
        /// Called when <see cref="RadSchedulerCommands.EditRecurrenceRule"/> command gets executed.
        /// </summary>
        protected virtual void OnEditRecurrenceExecuted()
        {
            var recurrenceDialogWindow = new RecurrenceDialogWindow(this.Scheduler);
            recurrenceDialogWindow.ParentDialogWindow = this;

            StyleManager.SetTheme((recurrenceDialogWindow as DialogWindow), StyleManager.GetTheme(this.Scheduler as RadScheduler));

            (recurrenceDialogWindow as DialogWindow).IsModal = this.IsModal;
            recurrenceDialogWindow.Appointment = this.EditedAppointment;
            recurrenceDialogWindow.RecurrenceRuleSaved += this.OnRecurrenceRuleSaved;
            recurrenceDialogWindow.Closed += OnRecurrenceDialogWindowClosed;
            recurrenceDialogWindow.Show();
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="AppointmentDialogWindow.Occurrence" /> property.
        /// </summary>
        protected virtual void OnOccurrenceChanged(DependencyPropertyChangedEventArgs args)
        {
            IAppointment app = this.Occurrence.Appointment;
            if (this.EditedAppointment != app)
            {
                this.EditedAppointment = app.Copy();
            }
        }
  
        private static void ChangeTimePickersVisibilityCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            CheckBox checkbox = e.Source as CheckBox;
            window.EditedAppointment.IsAllDayEvent = checkbox.IsChecked.Value;
            window.ChangeVisualState(true);
        }

        private static void SetAppointmentImportanceCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            Button btn = e.Source as Button;
            Importance importance = Importance.Low;
            switch (e.Parameter.ToString())
            {
                case "High":
                    if ((window.EditedAppointment as Appointment).Importance == Importance.High)
                    {
                        importance = Importance.None;
                    }
                    else
                    {
                        importance = Importance.High;
                    }
                    break;
                case "Low":
                    if ((window.EditedAppointment as Appointment).Importance == Importance.Low)
                    {
                        importance = Importance.None;
                    }
                    else
                    {
                        importance = Importance.Low;
                    }
                    break;
            }
            (window.EditedAppointment as Appointment).Importance = importance;
        }


        /// <summary>
        /// Called when <see cref="RadSchedulerCommands.EditParentAppointment"/> command gets executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Input.ExecutedRoutedEventArgs"/> instance containing the event data.</param>

        private static void OnEditParentAppointmentCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            window.OnEditParentAppointment();
        }
        
        private static void OnEditRecurrenceCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            window.OnEditRecurrenceExecuted();
        }

        private static void OnOccurrenceChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            var window = (AppointmentDialogWindow)d;
            window.OnOccurrenceChanged(args);
        }

        private static void OnQueryEditParentAppointmentCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            e.CanExecute = window.Occurrence != null && window.Occurrence.State != RecurrenceState.Master;
        }

        private static void OnQueryEditRecurrenceCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            RecurrenceState state = window.Occurrence.State;
            e.CanExecute = window.EditedAppointment != null && state == RecurrenceState.Master;
        }

        private static void OnQuerySaveAppointmentCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            e.CanExecute = window.EditedAppointment != null;
        }

        private static void OnRecurrenceDialogWindowClosed(object sender, RoutedEventArgs e)
        {
            var recurrenceDialogWindow = (RecurrenceDialogWindow)sender;
            recurrenceDialogWindow.ParentDialogWindow.ChangeVisualState(true);
            recurrenceDialogWindow.Closed -= OnRecurrenceDialogWindowClosed;
        }

        private static void OnSaveAppointmentCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var window = (AppointmentDialogWindow)sender;
            var savingEventArgs = new AppointmentSavingEventArgs(AppointmentSavingEvent, window, window.EditedAppointment);
            window.RaiseEvent(savingEventArgs);
            if (!savingEventArgs.Cancel)
            {
                window.OnAppointmentSaved();
            }
        }



        private void MenuItemClick(object sender, RoutedEventArgs e)
        {

            RadMenuItem item = e.OriginalSource as RadMenuItem;
            AppointmentBase app = this.EditedAppointment as AppointmentBase;
            if (item != null && app != null)
            {
                Category category = item.Header as Category;
                if (this.Category == category)
                {
                    category.IsChecked = false;
                    app.Category = this.Category = null;
                }
                else
                {
                    if (this.Category != null)
                    {
                        this.Category.IsChecked = false;
                    }
                    category.IsChecked = true;
                    app.Category = this.Category = category;
                }
            }
        }

        private void ConfigureDateTimePickers()
        {
            var startPricker = this.GetTemplateChild("StartDateTime") as DateTimePicker;
            var endPricker = this.GetTemplateChild("EndDateTime") as DateTimePicker;
            if (startPricker != null && endPricker != null)
            {
                StartEndDatePicker.SetEndPicker(startPricker, endPricker);
            }
        }
        private void ConfigureButtons()
        {
            Button editReccBtn = this.GetTemplateChild("EditRecurrenceRuleBtn") as Button;
            Button editParentBtn = this.GetTemplateChild("EditParentAppointmentBtn") as Button;

            if (editReccBtn != null && editReccBtn != null)
            {
                if (this.Occurrence != null && this.Occurrence.State != RecurrenceState.Master)
                {
                    editParentBtn.Visibility = Visibility.Visible;
                    editReccBtn.Visibility = Visibility.Collapsed;
                }
                else
                {
                    editParentBtn.Visibility = Visibility.Collapsed;
                    editReccBtn.Visibility = Visibility.Visible;
                }
            }
        }

        private void OnRecurrenceRuleSaved(object sender, RoutedEventArgs e)
        {
            var recurrenceDialogWindow = (RecurrenceDialogWindow)sender;

            recurrenceDialogWindow.RecurrenceRuleSaved -= this.OnRecurrenceRuleSaved;
            recurrenceDialogWindow.Close();
        }
	}
}
