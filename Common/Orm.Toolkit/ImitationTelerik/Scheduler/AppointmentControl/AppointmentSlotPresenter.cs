
using System;
using System.Diagnostics;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Content presenter for <see cref="AppointmentSlot"/> control.
    /// </summary>
    [TemplatePart(Name = SubjectTextBoxName, Type = typeof(TextBox))]
    public class AppointmentSlotPresenter : ContentPresenter
    {
        /// <summary>
        /// Identifies the <see cref="IsEditingSubject"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="IsEditingSubject"/> property.</returns>
        public static readonly DependencyProperty IsEditingSubjectProperty;

        private static readonly DependencyPropertyKey IsEditingSubjectPropertyKey;

        private const string SubjectTextBoxName = "PART_SubjectTextBox";

        private bool appointmentEditingIsCancelled;
        private AppointmentItem parentAppointmentItem;
        private bool shouldAbortInlineEditing;
        private bool shouldStartInlineEditing;

        static AppointmentSlotPresenter()
        {

            // TODO: Move to the control Style
            FocusableProperty.OverrideMetadata(
                typeof(AppointmentSlotPresenter), new FrameworkPropertyMetadata(BooleanBoxes.TrueBox));

            IsEditingSubjectPropertyKey =
                DependencyPropertyExtensions.RegisterReadOnly(
                    "IsEditingSubject",
                    typeof(bool),
                    typeof(AppointmentSlotPresenter),
                    new PropertyMetadata(BooleanBoxes.FalseBox, OnIsEditingSubjectChanged));

            IsEditingSubjectProperty = IsEditingSubjectPropertyKey.DependencyProperty;
        }

        /// <summary>
        /// Gets the appointment slot.
        /// </summary>
        /// <value>The appointment slot.</value>
        public AppointmentSlot AppointmentSlot
        {
            get
            {
                return this.Content as AppointmentSlot;
            }
        }

        /// <summary>
        /// Gets value indicating that the appointment's subject is being edited. The default value is false.
        /// This is a dependency property.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if appointment's subject is being edited; otherwise, <c>false</c>.
        /// </value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "value")]
        public bool IsEditingSubject
        {
            get
            {
                return (bool)this.GetValue(IsEditingSubjectProperty);
            }
            internal set
            {
                this.SetValue(IsEditingSubjectPropertyKey, value);
            }
        }

        internal TextBox SubjectTextBox { get; private set; }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or
        /// internal processes call ApplyTemplate.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.DetachFromVisualTree();
            this.AttachToVisualTree();
        }

        /// <summary>
        /// Called when subject text box lost focus.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnSubjectTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            this.IsEditingSubject = false;
            this.SubjectTextBox.IsHitTestVisible = false;
            this.shouldStartInlineEditing = false;
        }

        private static void OnIsEditingSubjectChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((AppointmentSlotPresenter)d).OnIsEditingSubjectChanged();
        }

        private bool AppointmentEditingIsCancelled()
        {
            var editingEventArgs = new AppointmentEditingEventArgs(
                RadScheduler.AppointmentEditingEvent, this.AppointmentSlot.Occurrence.Appointment);
            
            editingEventArgs.AppointmentEditAction = AppointmentEditAction.EditInline;
            
            if (this.AppointmentSlot.Occurrence.State == RecurrenceState.Exception)
            {
                editingEventArgs.ExceptionAction = ExceptionAction.Edit;
                editingEventArgs.ExceptionOccurrence = this.AppointmentSlot.Occurrence;
            }
            this.RaiseEvent(editingEventArgs);
            return editingEventArgs.Cancel;
        }

        private void AttachToVisualTree()
        {
            this.KeyDown += this.OnKeyDown;

            this.SubjectTextBox = this.GetTemplateChild(SubjectTextBoxName) as TextBox;

            if (this.SubjectTextBox != null)
            {
                this.SubjectTextBox.GotFocus += this.OnSubjectTextBoxGotFocus;
                this.SubjectTextBox.LostFocus += this.OnSubjectTextBoxLostFocus;
                this.parentAppointmentItem = this.ParentOfType<AppointmentItem>();
                this.parentAppointmentItem.MouseLeftButtonUp += this.OnParentAppointmentItemMouseLeftButtonUp;

                this.parentAppointmentItem.MouseDoubleClick += this.OnParentAppointmentItemMouseDoubleClick;

                this.parentAppointmentItem.Unselected += this.OnParentAppointmentItemUnselected;
                this.parentAppointmentItem.LostFocus += this.OnParentAppointmentItemLostFocus;
                this.shouldStartInlineEditing = this.parentAppointmentItem.IsSelected;
            }
        }

        private void ClearSubjectBindings()
        {

            BindingOperations.ClearBinding(this.SubjectTextBox, TextBox.TextProperty);

        }

        private void DetachFromVisualTree()
        {
            if (this.SubjectTextBox != null)
            {
                this.ClearSubjectBindings();
                this.SubjectTextBox.LostFocus -= this.OnSubjectTextBoxLostFocus;
                this.SubjectTextBox.GotFocus -= this.OnSubjectTextBoxGotFocus;
                this.parentAppointmentItem.MouseLeftButtonUp -= this.OnParentAppointmentItemMouseLeftButtonUp;
                this.parentAppointmentItem.Unselected -= this.OnParentAppointmentItemUnselected;
                this.parentAppointmentItem.LostFocus -= this.OnParentAppointmentItemLostFocus;

                this.parentAppointmentItem.MouseDoubleClick -= this.OnParentAppointmentItemMouseDoubleClick;

            }
        }

        private void OnIsEditingSubjectChanged()
        {
            if (this.IsEditingSubject)
            {
                this.appointmentEditingIsCancelled = this.AppointmentEditingIsCancelled();
            }
            else
            {
                if (!this.appointmentEditingIsCancelled)
                {
                    this.RaiseAppointmentEditedEvent();
                }
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && this.IsEditingSubject && this.parentAppointmentItem != null)
            {

                this.parentAppointmentItem.Focus();
                this.IsEditingSubject = false;
                e.Handled = true;
            }
            if (e.Key == Key.Escape && this.IsEditingSubject && this.parentAppointmentItem != null)
            {
                this.SubjectTextBox.Text = this.AppointmentSlot.Occurrence.Appointment.Subject;
                this.parentAppointmentItem.Focus();
                this.IsEditingSubject = false;
                e.Handled = true;
            }
        }

        private void OnParentAppointmentItemLostFocus(object sender, RoutedEventArgs e)
        {

            var focusedElementAsTextBox = FocusManager.GetFocusedElement(FocusManager.GetFocusScope(this)) as TextBox;
            bool subjectTextBoxIsFocused = focusedElementAsTextBox != null && focusedElementAsTextBox.Name == this.SubjectTextBox.Name;

            if (!subjectTextBoxIsFocused && this.IsEditingSubject == false)
            {
                this.SubjectTextBox.IsHitTestVisible = false;
            }
        }


        private void OnParentAppointmentItemMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.shouldAbortInlineEditing = true;
        }


        private void OnParentAppointmentItemMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var parentScheduler = this.ParentOfType<RadScheduler>();
            if (parentScheduler != null && parentScheduler.IsInlineEditingEnabled)
            {
                if (this.shouldStartInlineEditing)
                {
                    this.shouldStartInlineEditing = false;
                    this.StartInlineEditingTimer();
                }
                else
                {
                    this.shouldStartInlineEditing = true;
                }
            }
        }

        private void OnParentAppointmentItemUnselected(object sender, RoutedEventArgs e)
        {
            this.SubjectTextBox.IsHitTestVisible = false;
            this.shouldStartInlineEditing = false;
        }

        private void OnSubjectTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            this.IsEditingSubject = true;
            this.SubjectTextBox.IsReadOnly = this.appointmentEditingIsCancelled || (this.parentAppointmentItem.Scheduler != null && this.parentAppointmentItem.Scheduler.IsReadOnly);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (!this.shouldAbortInlineEditing && this.parentAppointmentItem.IsSelected)
            {
                this.SubjectTextBox.IsHitTestVisible = true;
                this.SubjectTextBox.Focus();
            }

            var timer = (DispatcherTimer)sender;
            timer.Stop();
            timer.Tick -= this.OnTimerTick;

            this.shouldAbortInlineEditing = false;
            if (this.parentAppointmentItem.IsSelected)
            {
                this.shouldStartInlineEditing = true;
            }
        }

        private void RaiseAppointmentEditedEvent()
        {
            var editedEventArgs = new AppointmentEditedEventArgs(
                RadScheduler.AppointmentEditedEvent,
                this.AppointmentSlot.Occurrence.Appointment);
            if (this.AppointmentSlot.Occurrence.State == RecurrenceState.Exception)
            {
                editedEventArgs.ExceptionAction = ExceptionAction.Edit;
                editedEventArgs.ExceptionOccurrence = this.AppointmentSlot.Occurrence;
            }
            this.RaiseEvent(editedEventArgs);
        }

        private void StartInlineEditingTimer()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(550) };
            timer.Tick += this.OnTimerTick;
            timer.Start();
        }
    }
}
