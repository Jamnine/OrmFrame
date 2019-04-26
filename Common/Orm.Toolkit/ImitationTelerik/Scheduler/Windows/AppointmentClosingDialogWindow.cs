using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{

    using RadRoutedEventArgs = RoutedEventArgs;


    /// <summary>
    /// A dialog window for adding and editing appointment recurrence rule.
    /// </summary>
    public class AppointmentClosingDialogWindow : DialogWindow, IAppointmentClosingDialogWindow
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
                typeof(AppointmentClosingDialogWindow));

        static AppointmentClosingDialogWindow()
        {

            CommandManager.RegisterClassCommandBinding(
          typeof(AppointmentClosingDialogWindow), new CommandBinding(WindowCommands.Confirm, OnConfirmCommand));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentClosingDialogWindow"/> class.
        /// </summary>
        public AppointmentClosingDialogWindow()
        {
            this.DefaultStyleKey = typeof(AppointmentClosingDialogWindow);
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

        /// <summary>
        /// Gets or sets the occurrence.
        /// </summary>
        /// <value>The occurrence.</value>
        public AppointmentDialogWindow ParentWindow { get; set; }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.Title = LocalizationManager.GetString("CloseItem");
        }

   
        /// <summary>
        /// Raises the <see cref="Confirmed"/> event.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Input.ExecutedRoutedEventArgs"/> instance containing the event data.</param>

        protected virtual void OnConfirmCommand(ExecutedRoutedEventArgs e)
        {
            this.RaiseEvent(new RadRoutedEventArgs(ConfirmedEvent, this));
        }


        /// <summary>
        /// Raises the <see cref="E:CloseCommand"/> event.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Input.ExecutedRoutedEventArgs"/> instance containing the event data.</param>

        protected virtual void OnCloseCommand(ExecutedRoutedEventArgs e)
        {
            this.RaiseEvent(new RadRoutedEventArgs(ClosedEvent, this));
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
            var window = (AppointmentClosingDialogWindow)sender;
            window.OnConfirmCommand(e);
        }

    }
}
