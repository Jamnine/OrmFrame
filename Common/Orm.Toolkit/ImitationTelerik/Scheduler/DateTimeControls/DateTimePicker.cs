using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{  
    /// <summary>
    /// Time picker control.
    /// </summary>
    [TemplatePart(Name = TimePickerControlName, Type = typeof(SchedulerTimePicker))]
    [TemplatePart(Name = DatePickerControlName, Type = typeof(RadDatePicker))]
    public class DateTimePicker : Control, IDateTimeControl

    { 
        /// <summary>
        /// Identifies the <see cref="DatePickerVisibility"/> property.
        /// </summary>
        public static readonly DependencyProperty DatePickerVisibilityProperty =
            DependencyProperty.Register(
                "DatePickerVisibility",
                typeof(Visibility),
                typeof(DateTimePicker),
                new PropertyMetadata(Visibility.Visible));

         /// <summary>
        /// Identifies the <see cref="SelectedDateTime"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="SelectedDateTime"/> property.</returns>
        public static readonly DependencyProperty SelectedDateTimeProperty =
            DependencyProperty.Register(
                "SelectedDateTime",
                typeof(DateTime?),
                typeof(DateTimePicker),
                new PropertyMetadata(null, OnSelectedDateTimeChanged));

        /// <summary>
        /// Identifies the <see cref="TimePickerItems"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimePickerItems"/> property.</returns>
        public static readonly DependencyProperty TimePickerItemsProperty =
            DependencyProperty.Register(
                "TimePickerItems",
                typeof(TimeSpan),
                typeof(DateTimePicker),
                new PropertyMetadata(TimeSpan.FromMinutes(30), OnTimePickerItemsChanged));

        /// <summary>
        /// Identifies the <see cref="TimePickerStartTime"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimePickerStartTime"/> property.</returns>
        public static readonly DependencyProperty TimePickerStartTimeProperty =
            DependencyProperty.Register(
                "TimePickerStartTime",
                typeof(TimeSpan),
                typeof(DateTimePicker),
                new PropertyMetadata(TimeSpan.Zero, new PropertyChangedCallback(OnTimePickerStartTimeChanged)));

        /// <summary>
        /// Identifies the <see cref="TimePickerVisibility"/> property.
        /// </summary>
        public static readonly DependencyProperty TimePickerVisibilityProperty =
            DependencyProperty.Register(
                "TimePickerVisibility",
                typeof(Visibility),
                typeof(DateTimePicker),
                new PropertyMetadata(Visibility.Visible));
        
        /// <summary>
        /// Identifies the <see cref="TimeItems"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="TimeItems"/> property.</returns>
        public static readonly DependencyProperty TimeItemsProperty;

        private static readonly DependencyPropertyKey TimeItemsPropertyKey;

        private const string DatePickerControlName = "PART_DatePicker";
        private const string TimePickerControlName = "PART_TimePicker";

        private RadDatePicker datePicker;

        private SchedulerTimePicker schedulerTimePicker;

        static DateTimePicker()
        {
            TimeItemsPropertyKey = DependencyPropertyExtensions.RegisterReadOnly(
                "TimeItems", typeof(ObservableCollection<TimeSpan>), typeof(DateTimePicker), new PropertyMetadata(null));
            TimeItemsProperty = TimeItemsPropertyKey.DependencyProperty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimePicker"/> class.
        /// </summary>
        public DateTimePicker()
        {

			if (!(DesignerProperties.GetIsInDesignMode(this) || (Application.Current != null && Application.Current.MainWindow == null)))
			{
				this.SetTimeItems();
			}

        }

        /// <summary>
        /// Occurs when selected date time changed event is raised.
        /// </summary>
        public event RoutedPropertyChangedEventHandler<DateTime?> SelectedDateTimeChangedEvent;  
     
        /// <summary>
        /// Occurs when <see cref="SelectedDateTime"/> is changed.
        /// </summary>    
        public event RoutedPropertyChangedEventHandler<DateTime?> SelectedDateTimeChanged
        {
            add
            {
                this.SelectedDateTimeChangedEvent += value;
            }
            remove
            {
                this.SelectedDateTimeChangedEvent -= value;
            }
        }

        /// <summary>
        /// Gets or sets the date picker visibility.
        /// </summary>
        /// <value>The date picker visibility.</value>
        public Visibility DatePickerVisibility
        {
            get
            {
                return (Visibility)this.GetValue(DatePickerVisibilityProperty);
            }
            set
            {
                this.SetValue(DatePickerVisibilityProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets SelectedDateTime. This is a dependency property.
        /// </summary>
        /// <returns>The default value is null.</returns> 
        public DateTime? SelectedDateTime
        {
            get
            {
                return (DateTime?)this.GetValue(SelectedDateTimeProperty);
            }
            set
            {
                this.SetValue(SelectedDateTimeProperty, value);
            }
        }

        /// <summary>
        /// Gets the <see cref="ObservableCollection{T}"/> values which can be used as items source for the time picker. This is a dependency property.
        /// </summary>
        public ObservableCollection<TimeSpan> TimeItems
        {
            get
            {
                return (ObservableCollection<TimeSpan>)this.GetValue(TimeItemsProperty);
            }
            private set
            {
                this.SetValue(TimeItemsPropertyKey, value);
            }
        }

        /// <summary>
        /// Gets or sets time interval between time items. This is a dependency property.
        /// </summary>
        public TimeSpan TimePickerItems
        {
            get
            {
                return (TimeSpan)this.GetValue(TimePickerItemsProperty);
            }
            set
            {
                this.SetValue(TimePickerItemsProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the start of the <see cref="TimeItems" />. This is a dependency property.
        /// </summary>
        /// <returns>The <see cref="TimeItems" /> start.</returns> 
        public TimeSpan TimePickerStartTime
        {
            get
            {
                return (TimeSpan)this.GetValue(TimePickerStartTimeProperty);
            }
            set
            {
                this.SetValue(TimePickerStartTimeProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the time picker visibility.
        /// </summary>
        /// <value>The time picker visibility.</value>
        public Visibility TimePickerVisibility
        {
            get
            {
                return (Visibility)this.GetValue(TimePickerVisibilityProperty);
            }
            set
            {
                this.SetValue(TimePickerVisibilityProperty, value);
            }
        }


        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes call ApplyTemplate />.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.schedulerTimePicker = (SchedulerTimePicker)this.Template.FindName(TimePickerControlName, this);
            this.datePicker = (RadDatePicker)this.Template.FindName(DatePickerControlName, this);

            this.datePicker.SelectionChanged += this.OnDatePickerSelectionChanged;
            this.schedulerTimePicker.SelectedTimeChanged += this.OnTimePickerSelectedTimeChanged;

            var window = this.GetParent<RadWindow>();
            if (this.datePicker != null && window != null)
            {
				this.datePicker.Culture = LocalizationManager.DefaultCulture;
                StyleManager.SetThemeFromParent(this.datePicker, window);
            }
            if (this.schedulerTimePicker != null && window != null)
            {
                StyleManager.SetThemeFromParent(this.schedulerTimePicker, window);
            }
            this.UpdateSelection();
        }

        internal void SetTimeItems()
        {
            this.TimeItems = GenerateTimeItems(this.TimePickerItems, this.TimePickerStartTime);
        }

        /// <summary>
        /// Raises the <see cref="SelectedDateTimeChanged"/> event and updates inner pickers values.
        /// </summary>
        /// <param name="args">The <see cref="DependencyPropertyChangedEventArgs"/> instance from which event data will be populated.</param>
        protected virtual void OnSelectedDateTimeChanged(DependencyPropertyChangedEventArgs args)
        {
            this.UpdateSelection();
            var eventArgs = new RoutedPropertyChangedEventArgs<DateTime?>((DateTime?)args.OldValue, (DateTime?)args.NewValue);

            if (this.SelectedDateTimeChangedEvent != null)
            {
                this.SelectedDateTimeChangedEvent(this, eventArgs);
            }
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="TimePickerItems"/> property.
        /// </summary>
        protected virtual void OnTimePickerItemsChanged(DependencyPropertyChangedEventArgs args)
        {
            this.SetTimeItems();
        }

        /// <summary>
        /// Provides derived classes an opportunity to handle changes to the <see cref="TimePickerStartTime" /> property.
        /// </summary>
        protected virtual void OnTimePickerStartTimeChanged(DependencyPropertyChangedEventArgs args)
        {
            this.SetTimeItems();
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


        private static ObservableCollection<TimeSpan> GenerateTimeItems(TimeSpan interval, TimeSpan start)
        {
            var intervals = new ObservableCollection<TimeSpan>();
            TimeSpan day = TimeSpan.FromDays(1);
            TimeSpan ts = start;
            do
            {
                intervals.Add(ts);
                ts = ts.Add(interval);
            }
            while (ts - start < day);

            return intervals;
        }

        private static void OnSelectedDateTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            ((DateTimePicker)d).OnSelectedDateTimeChanged(args);
        }

        /// <summary>
        /// Handles changes to the <see cref="TimePickerItems"/> property.
        /// </summary>
        private static void OnTimePickerItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            ((DateTimePicker)d).OnTimePickerItemsChanged(args);
        }

        /// <summary>
        /// Handles changes to the <see cref="TimePickerStartTime" /> property.
        /// </summary>
        private static void OnTimePickerStartTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            ((DateTimePicker)d).OnTimePickerStartTimeChanged(args);
        }

        private void OnDatePickerSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            DateTime? newSelectedDate = this.datePicker.SelectedDate;

            if (this.SelectedDateTime.HasValue)
            {
                if (newSelectedDate != null && newSelectedDate.Value.Date == this.SelectedDateTime.Value.Date)
                {
                    return;
                }
                else
                {
                    if (newSelectedDate != null)
                    {
                        this.SelectedDateTime = newSelectedDate.Value.Add(this.SelectedDateTime.Value.TimeOfDay);
                    }
                    else
                    {
                        this.datePicker.SelectedDate = this.SelectedDateTime;
                    }
                }
            }
            else
            {
                this.SelectedDateTime = (newSelectedDate != null) ? newSelectedDate.Value.Add(this.schedulerTimePicker.SelectedTime) : newSelectedDate;
            }
        }

        private void OnTimePickerSelectedTimeChanged(object sender, EventArgs e)
        {
            TimeSpan newTimeOfDay = this.schedulerTimePicker.SelectedTime;
            if (this.SelectedDateTime.HasValue)
            {
                if (this.SelectedDateTime.Value.TimeOfDay == newTimeOfDay)
                {
                    return;
                }
                else
                {
                    if (this.TimePickerStartTime > newTimeOfDay)
                    {
                        newTimeOfDay = newTimeOfDay.AddDays(1);
                    }

                    this.SelectedDateTime = this.SelectedDateTime.Value.Date.Add(newTimeOfDay);
                }
            }
            else
            {
                this.SelectedDateTime = DateTime.Today.Add(newTimeOfDay);
            }
        }

        private void UpdateSelection()
        {
            if (this.datePicker != null)
            {
                this.datePicker.SelectedDate = this.SelectedDateTime;
            }

            if (this.schedulerTimePicker != null && this.SelectedDateTime.HasValue)
            {
                this.schedulerTimePicker.SelectedTime = this.SelectedDateTime.Value.TimeOfDay;
            }
        }
    }
}
