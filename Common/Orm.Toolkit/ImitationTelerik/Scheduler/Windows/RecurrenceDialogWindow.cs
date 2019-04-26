using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;
using Orm.Toolkit.ImitationTelerik;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// A dialog window for adding and editing recurrence to appointment.
    /// </summary>
    [TemplateVisualState(Name = "Weekly", GroupName = "RecurrenceStates")]
    [TemplateVisualState(Name = "Daily", GroupName = "RecurrenceStates")]
	[TemplateVisualState(Name = "WeekDays", GroupName = "RecurrenceStates")]
    [TemplateVisualState(Name = "Monthly", GroupName = "RecurrenceStates")]
    [TemplateVisualState(Name = "Yearly", GroupName = "RecurrenceStates")]
    public class RecurrenceDialogWindow : SchedulerWindow
    {
        /// <summary>
        /// Identifies the <see cref="RecurrencePattern"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty AppointmentProperty =
            DependencyProperty.Register(
                "Appointment",
                typeof(IAppointment),
                typeof(RecurrenceDialogWindow),
                new PropertyMetadata(null, OnRecurrenceRuleChanged));

        /// <summary>
        /// Identifies the <see cref="RecurrenceRuleSaved"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="RecurrenceRuleSaved"/> event.</returns>
        public static readonly RoutedEvent RecurrenceRuleSavedEvent =
            EventManager.RegisterRoutedEvent(
                "RecurrenceRuleSaved",
                RoutingStrategy.Direct,
                typeof(RoutedEventHandler),
                typeof(RecurrenceDialogWindow));

        private RecurrenceDialogViewModel viewModel;

        static RecurrenceDialogWindow()
        {
            CommandManager.RegisterClassCommandBinding(
                typeof(RecurrenceDialogWindow),
                new CommandBinding(RadSchedulerCommands.SaveRecurrenceRule, OnSaveRecurrenceRuleCommand, OnQuerySaveRecurrenceRuleCommand));

            CommandManager.RegisterClassCommandBinding(
                typeof(RecurrenceDialogWindow),
                new CommandBinding(RadSchedulerCommands.DeleteRecurrenceRule, OnDeleteRecurrenceRuleCommand, OnQueryDeleteRecurrenceRuleCommand));

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceDialogWindow"/> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        public RecurrenceDialogWindow(IScheduler scheduler)
        {
            this.Scheduler = scheduler;

        }

        /// <summary>
        /// Occurs when the recurrence rule of appointment is saved.
        /// </summary>
        public event RoutedEventHandler RecurrenceRuleSaved
        {
            add
            {
                this.AddHandler(RecurrenceRuleSavedEvent, value);
            }
            remove
            {
                this.RemoveHandler(RecurrenceRuleSavedEvent, value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="RecurrencePattern"/>. This is a dependency property.
        /// </summary>
        /// <value>The recurrence rule.</value>
        public IAppointment Appointment
        {
            get
            {
                return (IAppointment)this.GetValue(AppointmentProperty);
            }
            set
            {
                this.SetValue(AppointmentProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="RecurrencePattern"/>. This is a dependency property.
        /// </summary>
        /// <value>The recurrence rule.</value>
        public AppointmentDialogWindow ParentDialogWindow
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <value>The view.</value>
        public RecurrenceDialogViewModel ViewModel
        {
            get
            {
                return this.viewModel;
            }
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

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
        /// Called when DeleteRecurrenceRule command is executed.
        /// </summary>
        protected virtual void OnDeleteRecurrenceRule()
        {
            if (this.Appointment != null && this.Appointment.IsRecurring())
            {
                this.Appointment.RecurrenceRule = null;
                this.RaiseEvent(new RadRoutedEventArgs(RecurrenceRuleSavedEvent, this));
            }
        }

        /// <summary>
        /// Raises the <see cref="RecurrencePattern"/> property changed event.
        /// </summary>
        /// <param name="args">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnRecurrenceRuleChanged(DependencyPropertyChangedEventArgs args)
        {
            this.viewModel = RecurrenceDialogViewModel.CreateView(this.Scheduler, this.Appointment);
        }

        /// <summary>
        /// Called when recurrence rule is saved.
        /// </summary>
        protected virtual void OnRecurrenceRuleSaved()
        {
            IAppointment newAppointment = this.viewModel.CreateRule();
            if (newAppointment != null)
            {
                this.Appointment.RecurrenceRule = newAppointment.RecurrenceRule;
                this.Appointment.Start = newAppointment.Start;
                this.Appointment.End = newAppointment.End;

                this.RaiseEvent(new RadRoutedEventArgs(RecurrenceRuleSavedEvent, this));
            }
            else
            {

                MessageBox.Show(
                    Strings.InvalidRecurrenceRuleMessage,
                    Strings.InvalidRecurrenceRuleTitle,
                    MessageBoxButton.OK, 
                    MessageBoxImage.Exclamation);

            }
        }


        /// <summary>
        /// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
        /// </summary>
        /// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            this.DefaultStyleKey = this.GetDefaultStyleKey();
        }

        
        private static void OnDeleteRecurrenceRuleCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var dw = sender as RecurrenceDialogWindow;
            if (dw != null)
            {
                dw.OnDeleteRecurrenceRule();
            }
        }


        private static void OnQueryDeleteRecurrenceRuleCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var dw = sender as RecurrenceDialogWindow;
            if (dw != null)
            {
                dw.OnQueryDeleteRecurrenceRuleCommand(e);
            }
        }

        private static void OnQuerySaveRecurrenceRuleCommand(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }

        private static void OnRecurrenceRuleChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            var dw = d as RecurrenceDialogWindow;
            if (dw != null)
            {
                dw.OnRecurrenceRuleChanged(args);
            }
        }

        private static void OnSaveRecurrenceRuleCommand(object sender, ExecutedRoutedEventArgs args)
        {
            var dw = sender as RecurrenceDialogWindow;
            if (dw != null)
            {
                dw.OnRecurrenceRuleSaved();
            }
        }


        private void ConfigureButtons()
        {
            Button btn = this.GetTemplateChild("RemoveRecurrenceBtn") as Button;
            if (btn != null && (this.Appointment == null || (this.Appointment != null && !this.Appointment.IsRecurring())))
            {
                btn.Visibility = Visibility.Collapsed;
            }
        }

        private void OnQueryDeleteRecurrenceRuleCommand(CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.Appointment != null && this.Appointment.IsRecurring();
        }

        private void ConfigureDateTimePickers()
        {
            var startPricker = this.GetTemplateChild("StartTimePicker") as DateTimePicker;
            var endPricker = this.GetTemplateChild("EndTimePicker") as DateTimePicker;
            if (startPricker != null && endPricker != null)
            {
                StartEndDatePicker.SetEndPicker(startPricker, endPricker);
            }
        }
    }
}