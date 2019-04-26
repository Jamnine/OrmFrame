using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents scroll bar for <see cref="RadScheduler"/>. It is used for navigation to different dates. 
    /// </summary>
    [TemplatePart(Name = ScrollBarControlName, Type = typeof(ScrollBar))]
    public class SchedulerScrollBar : Control
    {
        /// <summary>
        /// Identifies the <see cref="MaximumDateTime"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="MaximumDateTime"/> property.</returns>
        public static readonly DependencyProperty MaximumDateTimeProperty =
            DependencyProperty.Register(
                "MaximumDateTime",
                typeof(DateTime),
                typeof(SchedulerScrollBar),
                new PropertyMetadata(DateTime.Today.AddYears(1), OnMaximumDateTimeChanged));

        /// <summary>
        /// Identifies the <see cref="MinimumDateTime"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="MinimumDateTime"/> property.</returns>
        public static readonly DependencyProperty MinimumDateTimeProperty =
            DependencyProperty.Register(
                "MinimumDateTime",
                typeof(DateTime),
                typeof(SchedulerScrollBar),
                new PropertyMetadata(DateTime.Today.AddYears(-1), OnMinimumDateTimeChanged));

        /// <summary>
        /// Identifies the <see cref="Scheduler"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Scheduler"/> property.</returns>
        public static readonly DependencyProperty SchedulerProperty =
            DependencyProperty.Register(
                "Scheduler",
                typeof(RadScheduler),
                typeof(SchedulerScrollBar),
                new PropertyMetadata(null, OnSchedulerChanged));

        /// <summary>
        /// Identifies the <see cref="TimeSlotValue"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeSlotValue"/> property.</returns>
        internal static readonly DependencyProperty TimeSlotValueProperty =
            DependencyProperty.Register(
                "TimeSlotValue",
                typeof(TimeSlot),
                typeof(SchedulerScrollBar),
                new PropertyMetadata(null, OnTimeSlotValueChanged));

        private const string ScrollBarControlName = "PART_ScrollBar";

        private ScrollBar scrollBar;

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerScrollBar"/> class.
        /// </summary>
        public SchedulerScrollBar()
        {
            SetBinding(
                TimeSlotValueProperty,
                new Binding("Scheduler.SelectedTimeSlot") { Source = this, Mode = BindingMode.TwoWay });

        }

        /// <summary>
        /// Gets or sets the MaximumDateTime property.
        /// The default value is a date one year after <see cref="System.DateTime.Today"/>. This dependency property.
        /// </summary>
        public DateTime MaximumDateTime
        {
            get { return (DateTime)GetValue(MaximumDateTimeProperty); }
            set { SetValue(MaximumDateTimeProperty, value); }
        }

        /// <summary>
        /// Gets or sets the MinimumDateTime property.
        /// The default value is a date one year before <see cref="System.DateTime.Today"/>. This dependency property.
        /// </summary>
        public DateTime MinimumDateTime
        {
            get { return (DateTime)GetValue(MinimumDateTimeProperty); }
            set { SetValue(MinimumDateTimeProperty, value); }
        }

        /// <summary>
        /// Gets or sets parent scheduler for the . This is a dependency property.
        /// </summary>
        /// <returns>The parent scheduler for this . The default value is null</returns>  
        public RadScheduler Scheduler
        {
            get { return (RadScheduler)GetValue(SchedulerProperty); }
            set { SetValue(SchedulerProperty, value); }
        }

        /// <summary>
        /// Gets or sets the TimeSlotValue property. The default value is <see cref="System.DateTime.MinValue"/>.
        /// This is a dependency property.
        /// </summary>
        internal TimeSlot TimeSlotValue
        {
            get { return (TimeSlot)GetValue(TimeSlotValueProperty); }
            set { SetValue(TimeSlotValueProperty, value); }
        }

        /// <summary>
        /// Gets the date time.
        /// </summary>
        /// <value>The date time.</value>
        protected DateTime DateTime
        {
            get { return this.MinimumDateTime.AddDays(Math.Round(this.scrollBar.Value)); }
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate"/>.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (this.scrollBar != null)
            {
                this.scrollBar.Scroll -= this.OnScroll;
            }
            this.scrollBar = this.GetTemplateChild(ScrollBarControlName) as ScrollBar;
            if (this.scrollBar != null)
            {
                this.scrollBar.Scroll += this.OnScroll;
                this.scrollBar.Minimum = 0;

                // TODO: Why do we need OnSchedulerChanged here? The code inside will not execute due the new instance of DependencyPropertyChangedEventArgs
                OnSchedulerChanged(new DependencyPropertyChangedEventArgs());
                OnMaximumDateTimeChanged(new DependencyPropertyChangedEventArgs());
                OnTimeSlotValueChanged(new DependencyPropertyChangedEventArgs());
            }
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="MaximumDateTime"/> property.
        /// </summary>
        protected virtual void OnMaximumDateTimeChanged(DependencyPropertyChangedEventArgs args)
        {
            TimeSpan timeSpan = this.MaximumDateTime.Subtract(this.MinimumDateTime);
            this.scrollBar.Maximum = timeSpan.Days;
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="MinimumDateTime"/> property.
        /// </summary>
        protected virtual void OnMinimumDateTimeChanged(DependencyPropertyChangedEventArgs args)
        {
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="Scheduler" /> property.
        /// </summary>
        /// <param name="args">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnSchedulerChanged(DependencyPropertyChangedEventArgs args)
        {
            var scheduler = args.NewValue as IScheduler;
            if (scheduler != null && this.scrollBar != null)
            {
                ViewDefinitionBase viewDefinition = scheduler.ActiveViewDefinition;

                this.scrollBar.SmallChange =
                    viewDefinition.SmallChangeInterval.GetApproximateTotalDays(scheduler.GetCultureInUse().Calendar);
                this.scrollBar.LargeChange =
                    viewDefinition.LargeChangeInterval.GetApproximateTotalDays(scheduler.GetCultureInUse().Calendar);
                this.scrollBar.ViewportSize = 2 * this.scrollBar.LargeChange;
            }
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="TimeSlotValue"/> property.
        /// </summary>
        protected virtual void OnTimeSlotValueChanged(DependencyPropertyChangedEventArgs args)
        {
            if (this.TimeSlotValue != null)
            {
                TimeSpan timeSpan = this.TimeSlotValue.Start.Subtract(this.MinimumDateTime);
                if (this.scrollBar != null)
                {
                    this.scrollBar.Value = timeSpan.Days;
                }
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


        private static void OnMaximumDateTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((SchedulerScrollBar)d).OnMaximumDateTimeChanged(e);
        }

        private static void OnMinimumDateTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            ((SchedulerScrollBar)d).OnMinimumDateTimeChanged(args);
        }

        private static void OnSchedulerChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            ((SchedulerScrollBar)d).OnSchedulerChanged(args);
        }

        private static void OnTimeSlotValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            ((SchedulerScrollBar)d).OnTimeSlotValueChanged(args);
        }

        private void OnScroll(object sender, ScrollEventArgs e)
        {
            if (this.Scheduler == null || !this.Scheduler.IsBackAndForwardNavigationEnabled) return;

            e.Handled = true;

            DateTime startDate = this.Scheduler.View.StartDate;
            int intervalMonths;
            DateTimeInterval dateTimeInterval;
            switch (e.ScrollEventType)
            {
                case ScrollEventType.EndScroll:
                case ScrollEventType.ThumbPosition:
                    intervalMonths = ((DateTime.Year - startDate.Year) * 12) + DateTime.Month - startDate.Month;
                    dateTimeInterval = new DateTimeInterval(0, intervalMonths);
                    this.Scheduler.View.IncreaseViewDates(dateTimeInterval);
                    break;
                case ScrollEventType.First:
                    intervalMonths = ((this.MinimumDateTime.Year - startDate.Year) * 12) + this.MinimumDateTime.Month -
                                     startDate.Month;
                    dateTimeInterval = new DateTimeInterval(0, intervalMonths);
                    this.Scheduler.View.IncreaseViewDates(dateTimeInterval);
                    break;
                case ScrollEventType.LargeDecrement:
                    this.Scheduler.View.DecreaseViewDates(this.Scheduler.ActiveViewDefinition.LargeChangeInterval);
                    break;
                case ScrollEventType.LargeIncrement:
                    this.Scheduler.View.IncreaseViewDates(this.Scheduler.ActiveViewDefinition.LargeChangeInterval);
                    break;
                case ScrollEventType.Last:
                    intervalMonths = ((this.MaximumDateTime.Year - startDate.Year) * 12) + this.MaximumDateTime.Month -
                                     startDate.Month;
                    dateTimeInterval = new DateTimeInterval(0, intervalMonths);
                    this.Scheduler.View.IncreaseViewDates(dateTimeInterval);
                    break;
                case ScrollEventType.SmallDecrement:
                    RadSchedulerCommands.DecreaseVisibleDateSmall.Execute(null, this.Scheduler);
                    break;
                case ScrollEventType.SmallIncrement:
                    RadSchedulerCommands.IncreaseVisibleDateSmall.Execute(null, this.Scheduler);
                    break;
            }
        }
    }
}