using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Windows.Controls;
    using System.Windows.Data;

    /// <summary>
    /// A dialog window for adding and editing appointment recurrence rule.
    /// </summary>
    public class RecurrenceChoiceDialogWindow : DialogWindow, IRecurrenceChoiceDialogWindow
    {
        /// <summary>
        /// Identifies the <see cref="Confirmed"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="Confirmed"/> event.</returns>
        public static readonly RoutedEvent ConfirmedEvent =
            EventManager.RegisterRoutedEvent(
                "Confirmed",
                RoutingStrategy.Direct,
                typeof(RoutedEventHandler),
                typeof(RecurrenceChoiceDialogWindow));

        /// <summary>
        /// Identifies the <see cref="IsDeleting"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="IsDeleting"/> property.</returns>
        public static readonly DependencyProperty IsDeletingProperty =
            DependencyProperty.Register(
                "IsDeleting",
                typeof(bool),
                typeof(RecurrenceChoiceDialogWindow),
                new PropertyMetadata(false));

        /// <summary>
        /// Identifies the <see cref="SelectedMode"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="SelectedMode"/> property.</returns>
        public static readonly DependencyProperty SelectedModeProperty =
            DependencyProperty.Register(
                "SelectedMode",
                typeof(RecurrenceMode),
                typeof(RecurrenceChoiceDialogWindow),
                new PropertyMetadata(RecurrenceMode.Occurrence));

        static RecurrenceChoiceDialogWindow()
        {

            CommandManager.RegisterClassCommandBinding(
                typeof(DialogWindow), new CommandBinding(WindowCommands.Confirm, OnConfirmCommand));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceChoiceDialogWindow"/> class.
        /// </summary>
        public RecurrenceChoiceDialogWindow()
        {
            this.DefaultStyleKey = typeof(RecurrenceChoiceDialogWindow);
        }

        /// <summary>
        /// Occurs when the confirmed is executed.
        /// </summary>
        public event RoutedEventHandler Confirmed
        {
            add
            {
                this.AddHandler(ConfirmedEvent, value);
            }
            remove
            {
                this.RemoveHandler(ConfirmedEvent, value);
            }
        }

        event RoutedEventHandler IRecurrenceChoiceDialogWindow.Closed
        {
            add
            {
                this.Closed += value;
            }
            remove
            {
                this.Closed -= value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is used for deleting.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance is used for deleting; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeleting
        {
            get
            {
                return (bool)this.GetValue(IsDeletingProperty);
            }
            set
            {
                this.SetValue(IsDeletingProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the occurrence.
        /// </summary>
        /// <value>The occurrence.</value>
        public Occurrence Occurrence { get; set; }

        /// <summary>
        /// Gets or sets SelectedMode. This is a dependency property.
        /// </summary>
        /// <returns>Selected value for occurrence edit. The default value is <see cref="RecurrenceMode.Occurrence"/>.</returns>  
        public RecurrenceMode SelectedMode
        {
            get
            {
                return (RecurrenceMode)this.GetValue(SelectedModeProperty);
            }
            set
            {
                this.SetValue(SelectedModeProperty, value);
            }
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {

        }

        /// <summary>
        /// Raises the <see cref="Confirmed"/> event.
        /// </summary>
        /// <param name="e">The <see cref="Telerik.Windows.RadRoutedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnConfirmCommand(ExecutedRoutedEventArgs e)
        {
            this.RaiseEvent(new Telerik.Windows.RadRoutedEventArgs(ConfirmedEvent, this));
        }


        /// <summary>
        /// Raises the <see cref="E:CloseCommand"/> event.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Input.ExecutedRoutedEventArgs"/> instance containing the event data.</param>

        protected virtual void OnCloseCommand(ExecutedRoutedEventArgs e)
        {
            this.RaiseEvent(new Telerik.Windows.RadRoutedEventArgs(ClosedEvent, this));
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


        private static void OnConfirmCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var window = (RecurrenceChoiceDialogWindow)sender;
            window.OnConfirmCommand(e);
        }

    }
}